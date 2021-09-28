using demo.common.Resources;
using FluentValidation;

namespace demo.dtos.Validators
{
    /// <summary>
    /// Validador de la clase <see cref="AddOrUpdateTagDto"/>
    /// </summary>
    public class AddOrUpdateTagDtoValidator : AbstractValidator<AddOrUpdateTagDto>
    {
        /// <summary>
        /// Crear una nueva instancia de <see cref="AddOrUpdateTagDtoValidator"/>
        /// </summary>
        public AddOrUpdateTagDtoValidator()
        {
            RuleFor(x => x.Name)
                .Cascade(CascadeMode.Continue)
                .MinimumLength(3).WithMessage(ErrorCodeResourceManager.GetValue("VAL00001")).WithErrorCode("VAL00001")
                .MaximumLength(15).WithMessage(ErrorCodeResourceManager.GetValue("VAL00002")).WithErrorCode("VAL00002");
        }
    }
}