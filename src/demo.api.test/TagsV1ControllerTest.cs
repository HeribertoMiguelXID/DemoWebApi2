using demo.api.Controllers;
using demo.api.Models;
using demo.api.test.Mocks;
using demo.dtos;
using demo.facade;
using NUnit.Framework;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Http.Results;

namespace demo.api.test
{
    /// <summary>
    /// Clase de prueba del controlador <see cref="TagsV1Controller"/>.
    /// </summary>
    [TestFixture]
    public class TagsV1ControllerTest: BaseUnitTest<TagsV1Controller>
    {
        /// <summary>
        /// Test method to get all tags
        /// </summary>
        /// <returns></returns>
        [Test]
        public async Task GetAll_ExistingTags_GetAllTagsCorrectly()
        {
            using (var mock = this.GetAutoMock())
            {
                // Arrange
                mock.Mock<ITagFacade>().Setup(x => x.GetAll()).Returns(TagFacadeMocks.GetAll(numberOfItems: 2));
                this._classUnderTest = mock.Create<TagsV1Controller>();

                // Act
                var result = (await this._classUnderTest.GetAll()) as NegotiatedContentResult<ResponseSuccessModel<IEnumerable<TagDto>>>;

                // Assert
                mock.Mock<ITagFacade>().Verify(x => x.GetAll());
                Assert.AreEqual("Success", result.Content.Status);
                Assert.AreEqual(2, result.Content.Data.Count());
            }
        }
    }
}
