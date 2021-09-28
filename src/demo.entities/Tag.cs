using System;

namespace demo.entities
{
    /// <summary>
    /// Entidad que representa un Tag
    /// </summary>
    public class Tag
    {
        /// <summary>
        /// Identificador del tag
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Nombre del tag
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Fecha en que se creo el recurso 
        /// </summary>
        public DateTime CreationDate { get; set; }
    }
}
