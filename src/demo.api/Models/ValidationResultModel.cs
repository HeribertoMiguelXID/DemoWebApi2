using System.Collections.Generic;

namespace demo.api.Models
{
    /// <summary>
    /// Modelo que representa el resultado de la validacion de un objeto.
    /// </summary>
    public class ValidationResultModel
    {
        /// <summary>
        /// Bandera que indica si el objeto es valido.
        /// </summary>
        public bool IsValid { get; set; }

        /// <summary>
        /// Diccionario con los errores encontrados en el objeto.
        /// </summary>
        public IDictionary<string, ValidationErrorModel> Errors { get; set; } = new Dictionary<string, ValidationErrorModel>();
    }
}