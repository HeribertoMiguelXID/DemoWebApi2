using demo.api.Models;

namespace demo.api.Documentation.Examples
{
    /// <summary>
    /// Clase para generar ejemplos de tipo <see cref="ResponseErrorModel"/>
    /// </summary>
    public class ResponseErrorModelInternalServerErrorExample : BaseExample<ResponseErrorModel>
    {
        /// <summary>
        /// Asignar valores de ejemplo a la instancia.
        /// </summary>
        public override void SetExampleData()
        {
            this.Instance.ErrorCode = "ERR00001";
            this.Instance.Message = "Ocurrió un error inesperado.";
        }
    }
}