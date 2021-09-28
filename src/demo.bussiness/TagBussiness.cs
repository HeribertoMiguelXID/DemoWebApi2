using demo.entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace demo.bussiness
{
    /// <summary>
    /// Clase que representa un ejemplo de la capa de negocio en el codigo legacy
    /// El codigo ejemplo no cuenta con interfaz, inyeccion de dependencias o metodos virtuales
    /// </summary>
    public class TagBussiness
    {
        public async Task<IEnumerable<Tag>> GetAll()
        {
            var tags = new List<Tag>();

            for (int tagId = 1; tagId <= 10; tagId++)
            {
                tags.Add(new Tag
                {
                    Id = tagId,
                    Name = $"Tag {tagId}",
                    CreationDate = DateTime.Now.AddDays(-tagId),
                });
            }

            return await Task.FromResult(tags.AsEnumerable<Tag>());
        }

        public async Task<PaginatedResults<Tag>> GetPaginated(int page)
        {
            var tags = new List<Tag>();

            for (int tagId = 1; tagId <= 10; tagId++)
            {
                tags.Add(new Tag
                {
                    Id = tagId,
                    Name = $"Tag {tagId}",
                    CreationDate = DateTime.Now.AddDays(-tagId),
                });
            }

            var pageData = new PaginatedResults<Tag>();
            pageData.Records = tags;
            pageData.Metadata = new PaginatedResultsMetadata() {
                Page = page,
                PerPage = 10,
                TotalCount = 10 * page
            };

            return await Task.FromResult(pageData);
        }


        public async Task<Tag> GetById(int id)
        {
            var tags = await this.GetAll();
            return tags.FirstOrDefault(x => x.Id == id);
        }

        public async Task Delete(int id)
        {
            await Task.FromResult(0);
        }

        public async Task<Tag> Add(Tag tag)
        {
            tag.Id = 11;
            tag.CreationDate = DateTime.Now;
            return await Task.FromResult(tag);
        }

        public async Task<Tag> Update(int id, Tag tag)
        {
            tag.Id = id;
            tag.CreationDate = DateTime.Now;
            return await Task.FromResult(tag);
        }
    }
}
