using demo.api.Models;

namespace demo.api.Documentation.Examples
{
    /// <summary>
    /// Clase para generar ejemplos de tipo <![CDATA[see cref="ResponseSuccessModel<T>"]]>
    /// </summary>
    public class ResponseSuccessModelObjectExample<T> : BaseExample<ResponseSuccessModel<T>> where T: new()
    {
        /// <summary>
        /// Asignar valores de ejemplo a la instancia.
        /// </summary>
        public override void SetExampleData()
        {
            this.Instance.Data = this.GetClassExample<T>().GetInstance();
        }
    }
}