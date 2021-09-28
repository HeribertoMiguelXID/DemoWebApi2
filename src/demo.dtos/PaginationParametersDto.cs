namespace demo.dtos
{
    /// <summary>
    /// Entidad que representa los parámetros para realizar la consulta de datos paginados.
    /// </summary>
    public class PaginationParametersDto
    {
        /// <summary>
        /// Numero de página a consultar.
        /// </summary>
        public int PageNumber { get; set; }

        /// <summary>
        /// Número de elementos por página
        /// </summary>
        public int Size { get; set; }

        /// <summary>
        /// Columna o columnas por las que se ordenara
        /// </summary>
        public string SortBy { get; set; }

        /// <summary>
        /// Filtros que se aplicaran a la información
        /// </summary>
        public string FilterBy { get; set; }
    }
}

