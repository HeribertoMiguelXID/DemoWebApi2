using demo.dtos;

namespace demo.api.Documentation.Examples
{
    /// <summary>
    /// Clase para generar ejemplos de tipo <see cref="PaginationParametersDto"/>
    /// </summary>
    public class RequestPaginationParametersDtoExample : BaseExample<PaginationParametersDto>
    {
        /// <summary>
        /// Asignar valores de ejemplo a la instancia.
        /// </summary>
        public override void SetExampleData()
        {
            this.Instance.PageNumber = 1;
            this.Instance.Size = 10;
            this.Instance.SortBy = "-Name,+Id";
            this.Instance.FilterBy = "Name=Tag";
        }
    }
}