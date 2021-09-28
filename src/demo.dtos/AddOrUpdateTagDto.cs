using demo.dtos.Validators;
using FluentValidation.Attributes;
using System.ComponentModel.DataAnnotations;

namespace demo.dtos
{
    /// <summary>
    /// DTO que representa la informacion requerida para la creacion de un Tag
    /// </summary>
    [Validator(typeof(AddOrUpdateTagDtoValidator))]
    public class AddOrUpdateTagDto
    {
        /// <summary>
        /// Nombre del tag
        /// </summary>
        [Required]
        public string Name { get; set; }
    }
}
