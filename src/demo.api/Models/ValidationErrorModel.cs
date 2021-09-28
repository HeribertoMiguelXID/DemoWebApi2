namespace demo.api.Models
{
    /// <summary>
    /// Modelo que representa el error detectado al validar un objeto.
    /// </summary>
    public class ValidationErrorModel
    {
        /// <summary>
        /// Código de error.
        /// </summary>
        public string ErrorCode { get; set; }

        /// <summary>
        /// Mensaje de error.
        /// </summary>
        public string ErrorMessage { get; set; }

        /// <summary>
        /// Crear una nueva instancia de <see cref="ValidationErrorModel"/>
        /// </summary>
        /// <param name="errorCode">Código de error.</param>
        /// <param name="errorMessage">Mensaje de error.</param>
        public ValidationErrorModel(string errorCode, string errorMessage)
        {
            this.ErrorCode = errorCode;
            this.ErrorMessage = errorMessage;
        }
    }
}