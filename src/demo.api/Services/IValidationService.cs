using demo.api.Models;
using System.Collections.Generic;

namespace demo.api.Services
{
    /// <summary>
    /// Servicio para la validación personalizada de información contenida en las peticiones.
    /// </summary>
    public interface IValidationService
    {
        /// <summary>
        /// Validar un objeto.
        /// </summary>
        /// <typeparam name="T">Tipo del objeto.</typeparam>
        /// <param name="entity">Objeto a validar.</param>
        /// <returns>Resultado con el estatus y errores encontrados al realizar la validacion.</returns>
        ValidationResultModel Validate<T>(T entity)
            where T : class;
    }
}