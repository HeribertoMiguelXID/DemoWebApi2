namespace demo.api.Models
{
    /// <summary>
    /// Instancia resultado de una operación que ha generado un error.
    /// </summary>
    public class ResponseErrorModel
    {
        /// <summary>
        /// Estatus de la operación
        /// </summary>
        public string Status => "Error";

        /// <summary>
        /// Código de estatus de la operación
        /// </summary>
        public int StatusCode => 3;

        /// <summary>
        /// Código de error.
        /// </summary>
        public string ErrorCode { get; set; }

        /// <summary>
        /// Mensaje descriptivo del error
        /// </summary>
        public string Message { get; set; }

        /// <summary>
        /// Inicializar una nueva instancia de la clase ResponseSuccessModel.
        /// </summary>
        public ResponseErrorModel(string errorMessage)
        {
            this.Message = errorMessage;
        }

        /// <summary>
        /// Inicializar una nueva instancia de la clase ResponseSuccessModel.
        /// </summary>
        public ResponseErrorModel()
        {
        }
    }
}