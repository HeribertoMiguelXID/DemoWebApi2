namespace demo.dtos
{
    /// <summary>
    /// Entidad que representa la metadata para una tabla paginada.
    /// </summary>
    public class PaginatedResultsMetadataDto
    {
        /// <summary>
        /// Número de página actual.
        /// </summary>
        public int Page { get; set; }

        /// <summary>
        /// Número de elementos por página.
        /// </summary>
        public int PerPage { get; set; }

        /// <summary>
        /// Número de paginas existentes.
        /// </summary>
        public int PageCount => this.TotalCount / this.PerPage;

        /// <summary>
        /// Número de registros totales por todas las paginas
        /// </summary>
        public int TotalCount  { get; set; }
    }
}
