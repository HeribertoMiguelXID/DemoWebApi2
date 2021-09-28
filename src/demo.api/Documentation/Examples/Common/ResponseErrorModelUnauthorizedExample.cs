using demo.api.Models;

namespace demo.api.Documentation.Examples
{
    /// <summary>
    /// Clase para generar ejemplos de tipo <see cref="ResponseErrorModel"/>
    /// </summary>
    public class ResponseErrorModelUnauthorizedExample : BaseExample<ResponseErrorModel>
    {
        /// <summary>
        /// Asignar valores de ejemplo a la instancia.
        /// </summary>
        public override void SetExampleData()
        {
            this.Instance.ErrorCode = "ERR00003";
            this.Instance.Message = "No se ha indicado o es incorrecto el Token de acceso.";
        }
    }
}