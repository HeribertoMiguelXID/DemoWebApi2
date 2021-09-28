using demo.api.Models;

namespace demo.api.Documentation.Examples
{
    /// <summary>
    /// Clase para generar ejemplos de tipo <![CDATA[see cref="ResponseSuccessModel<T[]>"]]>
    /// </summary>
    public class ResponseSuccessModelIEnumerableExample<T> : BaseExample<ResponseSuccessModel<T[]>>
        where T : new()
    {
        /// <summary>
        /// Asignar valores de ejemplo a la instancia.
        /// </summary>
        public override void SetExampleData()
        {
            var example1 = this.GetClassExample<T>();
            var example2 = this.GetClassExample<T>();
            this.Instance.Data = new T[] { example1.GetInstance(), example2.GetInstance() };
        }
    }
}