namespace demo.entities
{
    /// <summary>
    /// Entidad que representa la metadata para una tabla paginada.
    /// </summary>
    public class PaginatedResultsMetadata
    {
        /// <summary>
        /// Numero de pagina actual.
        /// </summary>
        public int Page { get; set; }

        /// <summary>
        /// Numero de elementos por pagina.
        /// </summary>
        public int PerPage { get; set; }

        /// <summary>
        /// Numero de paginas existentes.
        /// </summary>
        public int PageCount => this.TotalCount / this.PerPage;

        /// <summary>
        /// Numero de registros totales por todas las paginas
        /// </summary>
        public int TotalCount  { get; set; }
    }
}
