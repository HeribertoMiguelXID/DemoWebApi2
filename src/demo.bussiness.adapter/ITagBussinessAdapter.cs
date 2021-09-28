using demo.entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace demo.bussiness.adapter
{
    /// <summary>
    /// Interfaz que define la estructura de la clase que creara el adapter para la clase <see cref="TagBussiness"/>.
    /// </summary>
    public interface ITagBussinessAdapter
    {
        /// <summary>
        /// Obtener todos los tags.
        /// </summary>
        /// <returns>Listado de tags.</returns>
        Task<IEnumerable<Tag>> GetAll();

        /// <summary>
        /// Obtener tags paginados indicando el numero de pagina.
        /// </summary>
        /// <returns>Listado de tags paginados.</returns>
        Task<PaginatedResults<Tag>> GetPaginated(int page);

        /// <summary>
        /// Obtener un tag por id.
        /// </summary>
        /// <param name="id">Id del tag a consultar.</param>
        /// <returns>Tag consultado o null si no existe.</returns>
        Task<Tag> GetById(int id);

        /// <summary>
        /// Eliminar un tag por id.
        /// </summary>
        /// <param name="id">Id del tag a eliminar.</param>
        /// <returns>Sin resultado.</returns>
        Task Delete(int id);

        /// <summary>
        /// Agregar un nuevo tag.
        /// </summary>
        /// <param name="tag">Tag a agregar.</param>
        /// <returns>Nuevo tag.</returns>
        Task<Tag> Add(Tag tag);

        /// <summary>
        /// Actualizar un tag.
        /// </summary>
        /// <param name="id">Id del tag a actualizar.</param>
        /// <param name="tag">Tag con nueva información.</param>
        /// <returns>Tag actualizado.</returns>
        Task<Tag> Update(int id, Tag tag);
    }
}
