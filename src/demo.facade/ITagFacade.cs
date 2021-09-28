using demo.dtos;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace demo.facade
{
    /// <summary>
    /// Interfaz de Facade para Tags.
    /// </summary>
    public interface ITagFacade
    {
        /// <summary>
        /// Obtener todos los tags.
        /// </summary>
        /// <returns>Listado de tags.</returns>
        Task<IEnumerable<TagDto>> GetAll();

        /// <summary>
        /// Obtener tags paginados indicando el numero de pagina.
        /// </summary>
        /// <returns>Listado de tags paginados.</returns>
        Task<PaginatedResultsDto<TagDto>> GetPaginated(int page);

        /// <summary>
        /// Obtener un tag por id.
        /// </summary>
        /// <param name="id">Id del tag a consultar.</param>
        /// <returns>Tag consultado o null si no existe.</returns>
        Task<TagDto> GetById(int id);

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
        Task<TagDto> Add(AddOrUpdateTagDto tag);

        /// <summary>
        /// Actualizar un tag.
        /// </summary>
        /// <param name="id">Id del tag a actualizar.</param>
        /// <param name="tag">Tag con nueva información.</param>
        /// <returns>Tag actualizado.</returns>
        Task<TagDto> Update(int id, AddOrUpdateTagDto tag);
    }
}
