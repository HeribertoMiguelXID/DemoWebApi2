using System.Collections.Generic;

namespace demo.entities
{
    /// <summary>
    /// Entidad que representa una tabla paginada.
    /// </summary>
    /// <typeparam name="T">Tipo de los registros.</typeparam>
    public class PaginatedResults<T>
    {
        /// <summary>
        /// Meetadata de la tabla.
        /// </summary>
        public PaginatedResultsMetadata Metadata { get; set; }

        /// <summary>
        /// Resgistros en la pagina
        /// </summary>
        public IList<T> Records { get; set; }
    }
}
