using demo.api.Models;
using System.Collections.Generic;

namespace demo.api.Documentation.Examples
{
    /// <summary>
    /// Clase para generar ejemplos de tipo <![CDATA[see cref="IDictionary<string, ValidationErrorModel>"]]>
    /// </summary>
    public class ResponseFailModelBadRequestExample : BaseExample<ResponseFailModel<IDictionary<string, ValidationErrorModel>>>
    {
        /// <summary>
        /// Asignar valores de ejemplo a la instancia.
        /// </summary>
        public override void SetExampleData()
        {
            var data = new Dictionary<string, ValidationErrorModel>
            {
                { "ExampleProperty1", new ValidationErrorModel("VAL00001", "Error de validación I.") },
                { "ExampleProperty2", new ValidationErrorModel("VAL00002", "Error de validación II.") }
            };

            this.Instance.Data = data;
        }
    }
}