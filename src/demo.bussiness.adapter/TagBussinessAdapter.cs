using demo.entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace demo.bussiness.adapter
{
    /// <summary>
    /// Implementación de adapter para la clase <see cref="TagBussiness"/>.
    /// </summary>
    public class TagBussinessAdapter: ITagBussinessAdapter
    {
        /// <summary>
        /// Instancia de la clase <see cref="TagBussiness"/>.
        /// </summary>
        private readonly TagBussiness _tagBussiness;

        /// <summary>
        /// Crear una nueva insstancia de la clase <see cref="TagBussinessAdapter"/>
        /// </summary>
        public TagBussinessAdapter()
        {
            this._tagBussiness = new TagBussiness();
        }

        /// <summary>
        /// Obtener todos los tags.
        /// </summary>
        /// <returns>Listado de tags.</returns>
        public async Task<IEnumerable<Tag>> GetAll()
            => await this._tagBussiness.GetAll();


        /// <summary>
        /// Obtener tags paginados indicando el numero de pagina.
        /// </summary>
        /// <returns>Listado de tags paginados.</returns>
        public async Task<PaginatedResults<Tag>> GetPaginated(int page)
            => await this._tagBussiness.GetPaginated(page);

        /// <summary>
        /// Obtener un tag por id.
        /// </summary>
        /// <param name="id">Id del tag a consultar.</param>
        /// <returns>Tag consultado o null si no existe.</returns>
        public async Task<Tag> GetById(int id)
            => await this._tagBussiness.GetById(id);

        /// <summary>
        /// Eliminar un tag por id.
        /// </summary>
        /// <param name="id">Id del tag a eliminar.</param>
        /// <returns>Sin resultado.</returns>
        public async Task Delete(int id)
            => await this._tagBussiness.Delete(id);

        /// <summary>
        /// Agregar un nuevo tag.
        /// </summary>
        /// <param name="tag">Tag a agregar.</param>
        /// <returns>Nuevo tag.</returns>
        public async Task<Tag> Add(Tag tag)
            => await this._tagBussiness.Add(tag);

        /// <summary>
        /// Actualizar un tag.
        /// </summary>
        /// <param name="id">Id del tag a actualizar.</param>
        /// <param name="tag">Tag con nueva información.</param>
        /// <returns>Tag actualizado.</returns>
        public async Task<Tag> Update(int id, Tag tag)
            => await this._tagBussiness.Update(id, tag);
    }
}
