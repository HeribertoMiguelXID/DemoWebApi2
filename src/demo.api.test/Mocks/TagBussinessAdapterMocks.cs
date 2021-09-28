using demo.dtos;
using demo.facade;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace demo.api.test.Mocks
{
    /// <summary>
    /// Respuestas mock para la interfaz <see cref="ITagFacade"/>
    /// </summary>
    public static class TagFacadeMocks
    {
        /// <summary>
        /// Obtener todos los tags.
        /// </summary>
        /// <param name="numberOfItems">Numero de tags a devolver en el listado.</param>
        /// <returns>Listado de tags.</returns>
        public static Task<IEnumerable<TagDto>> GetAll(int numberOfItems)
        {
            var tags = new List<TagDto>();

            for (int tagId = 1; tagId <= numberOfItems; tagId++)
            {
                tags.Add(new TagDto
                {
                    Id = tagId,
                    Name = $"Tag {tagId}",
                    CreationDate = DateTime.Now.AddDays(-tagId),
                });
            }

            return Task.FromResult(tags.AsEnumerable());
        }
    }
}
