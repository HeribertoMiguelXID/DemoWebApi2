using demo.dtos.Validators;
using FluentValidation.Attributes;
using System;
using System.ComponentModel.DataAnnotations;

namespace demo.dtos
{
    /// <summary>
    /// DTO que representa un Tag
    /// </summary>
    public class TagDto
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
