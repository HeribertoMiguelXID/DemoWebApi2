using System.Collections.Generic;

namespace demo.dtos
{
    /// <summary>
    /// Entidad que representa una tabla paginada.
    /// </summary>
    /// <typeparam name="T">Tipo de los registros.</typeparam>
    public class PaginatedResultsDto<T>
    {
        /// <summary>
        /// Meetadata de la tabla.
        /// </summary>
        public PaginatedResultsMetadataDto Metadata { get; set; }

        /// <summary>
        /// Registros en la pagina
        /// </summary>
        public IList<T> Records { get; set; }
    }
}
