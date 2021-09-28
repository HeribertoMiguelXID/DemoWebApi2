using demo.dtos;

namespace demo.api.Documentation.Examples
{
    /// <summary>
    /// Clase para generar ejemplos de tipo <see cref="AddOrUpdateTagDto"/>
    /// </summary>
    public class AddOrUpdateTagDtoExample : BaseExample<AddOrUpdateTagDto>
    {
        /// <summary>
        /// Asignar valores de ejemplo a la instancia.
        /// </summary>
        public override void SetExampleData()
        {
            this.Instance.Name = "Tag de Ejemplo";
        }
    }
}