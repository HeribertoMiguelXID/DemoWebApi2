using demo.common.Extensions;
using FluentValidation;
using FluentValidation.Attributes;
using NUnit.Framework;
using System;

namespace demo.dtos.test
{
    /// <summary>
    /// Clase base para pruebas unitarias de una clase Dto utilizando FluentValidation.
    /// </summary>
    /// <typeparam name="TDto">Tipo de la instancia a validar.</typeparam>
    public abstract class BaseUnitTest <TDto> 
        where TDto : new()
    {
        /// <summary>
        /// Instancia de la clase que se está probando.
        /// </summary>
        internal TDto _classUndetTest;

        /// <summary>
        /// Validador de FluentValidation.
        /// </summary>
        internal AbstractValidator<TDto> _validator;

        /// <summary>
        /// Configuracion inicial del test.
        /// </summary>
        [SetUp]
        public void Setup()
        {
            this._classUndetTest = new TDto();
            this._validator = this.GetValidatorInstance();
            this.SetValidMockData();
        }

        /// <summary>
        /// Asignar valores validos a la instancia bajo prueba.
        /// </summary>
        public abstract void SetValidMockData();

        /// <summary>
        /// Crear una instancia del validador
        /// </summary>
        /// <returns></returns>
        private AbstractValidator<TDto> GetValidatorInstance()
        {
            var validatorAttribute = typeof(TDto).GetCustomAttribute<ValidatorAttribute>();

            if (validatorAttribute != null)
            {
                return Activator.CreateInstance(validatorAttribute.ValidatorType) as AbstractValidator<TDto>;
            }

            return null;
        }
    }
}
