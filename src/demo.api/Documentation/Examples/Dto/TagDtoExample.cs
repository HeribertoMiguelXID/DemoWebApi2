using demo.dtos;
using System;

namespace demo.api.Documentation.Examples
{
    /// <summary>
    /// Clase para generar ejemplos de tipo <see cref="TagDto"/>
    /// </summary>
    public class TagDtoExample : BaseExample<TagDto>
    {
        /// <summary>
        /// Asignar valores de ejemplo a la instancia.
        /// </summary>
        public override void SetExampleData()
        {
            this.Instance.Id = 1;
            this.Instance.Name = "Tag de Ejemplo";
            this.Instance.CreationDate = DateTime.Now;
        }
    }
}