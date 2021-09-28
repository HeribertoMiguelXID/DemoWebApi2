using demo.bussiness;
using demo.bussiness.adapter;
using demo.entities;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace demo.facade.test.Mocks
{
    /// <summary>
    /// Respuestas mock para la interfaz <see cref="ITagBussinessAdapter"/>
    /// </summary>
    public static class TagBussinessAdapterMocks
    {
        /// <summary>
        /// Obtener todos los tags.
        /// </summary>
        /// <param name="numberOfItems">Numero de tags a devolver en el listado.</param>
        /// <returns>Listado de tags.</returns>
        public static Task<IEnumerable<Tag>> GetAll(int numberOfItems)
        {
            var tags = new List<Tag>();

            for (int tagId = 1; tagId <= numberOfItems; tagId++)
            {
                tags.Add(new Tag
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
