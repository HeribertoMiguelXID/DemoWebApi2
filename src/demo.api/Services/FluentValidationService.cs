using demo.api.Models;
using demo.common.Extensions;
using FluentValidation;
using FluentValidation.Attributes;
using System;

namespace demo.api.Services
{
    /// <summary>
    /// Servicio para la validación personalizada de información contenida en las peticiones utilizando FluentValidation.
    /// </summary>
    public class FluentValidationService : IValidationService
    {
        /// <summary>
        /// Validar un objeto.
        /// </summary>
        /// <typeparam name="T">Tipo del objeto.</typeparam>
        /// <param name="entity">Objeto a validar.</param>
        /// <returns>Resultado con el estatus y errores encontrados al realizar la validacion.</returns>
        public ValidationResultModel Validate<T>(T entity)
            where T : class
        {
            var validationResult = new ValidationResultModel();
            var validatorAttribute = typeof(T).GetCustomAttribute<ValidatorAttribute>();

            if (validatorAttribute != null)
            {
                var validator = Activator.CreateInstance(validatorAttribute.ValidatorType) as AbstractValidator<T>;
                var result = validator.Validate(entity);

                validationResult.IsValid = result.IsValid;

                foreach (var error in result.Errors)
                {
                    validationResult.Errors.Add(error.PropertyName, new ValidationErrorModel(error.ErrorCode, error.ErrorMessage));
                }

                return validationResult;
            }

            validationResult.IsValid = true;
            return validationResult;
        }
    }
}