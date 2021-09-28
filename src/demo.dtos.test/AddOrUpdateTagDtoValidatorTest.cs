using NUnit.Framework;

namespace demo.dtos.test
{
    /// <summary>
    /// Pruebas de la clase <see cref="AddOrUpdateTagDto"/>
    /// </summary>
    [TestFixture]
    public class AddOrUpdateTagDtoValidatorTest : BaseUnitTest<AddOrUpdateTagDto>
    {
        /// <summary>
        /// Asignar valores validos a la instancia bajo prueba.
        /// </summary>
        public override void SetValidMockData()
        {
            this._classUndetTest.Name = "Test Name";
        }

        /// <summary>
        /// Pruebas para validar la propiedad Name cuando tiene un valor correcto.
        /// </summary>
        [TestCase("Tag")]
        [TestCase("Tag Name")]
        public void ValidateName_ValidName_ValidInstance(string name)
        {
            // Arrange
            this._classUndetTest.Name = name;

            // Act
            var validationResult = this._validator.Validate(this._classUndetTest);

            // Assert
            Assert.IsTrue(validationResult.IsValid);
        }

        /// <summary>
        /// Pruebas para validar la propiedad Name cuando tiene un valor incorrecto.
        /// </summary>
        [TestCase("")]
        [TestCase("Ta")]
        [TestCase("Tag with large name")]
        public void ValidateNamee_InvalidName_InvalidInstance(string name)
        {
            // Arrange
            this._classUndetTest.Name = name;

            // Act
            var validationResult = this._validator.Validate(this._classUndetTest);

            // Assert
            Assert.IsFalse(validationResult.IsValid);
            Assert.IsTrue(validationResult.Errors.Count == 1);
            Assert.AreEqual(validationResult.Errors[0].PropertyName, nameof(AddOrUpdateTagDto.Name));
        }
    }
}
