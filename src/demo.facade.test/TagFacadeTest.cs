using demo.bussiness.adapter;
using demo.facade.test.Mocks;
using NUnit.Framework;
using System.Linq;
using System.Threading.Tasks;

namespace demo.facade.test
{
    /// <summary>
    /// Clase de pruebas unitarias de la clase <see cref="TagFacade"/>.
    /// </summary>
    [TestFixture]
    public class TagFacadeTest : BaseUnitTest<TagFacade>
    { 
        /// <summary>
        /// Obtener todos los tags.
        /// </summary>
        /// <returns>Ok</returns>
        [Test]
        public async Task GetAll_ExistingTags_GetAllTagsCorrectly()
        {
            using (var mock = this.GetAutoMock())
            {
                // Arrange
                mock.Mock<ITagBussinessAdapter>().Setup(x => x.GetAll()).Returns(TagBussinessAdapterMocks.GetAll(numberOfItems: 2));
                this._classUnderTest = mock.Create<TagFacade>();

                // Act
                var tags = await this._classUnderTest.GetAll();

                // Assert
                mock.Mock<ITagBussinessAdapter>().Verify(x => x.GetAll());
                Assert.AreEqual(2, tags.Count());
            }
        }
    }
}
