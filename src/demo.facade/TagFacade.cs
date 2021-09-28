using demo.facade.Mapping;
using demo.bussiness;
using demo.dtos;
using demo.entities;
using System.Collections.Generic;
using System.Threading.Tasks;
using demo.bussiness.adapter;

namespace demo.facade
{
    /// <summary>
    /// Implementación de Facade para Tags.
    /// </summary>
    public class TagFacade: ITagFacade
    {
        /// <summary>
        /// Instancia de servicio para mapeo de entidades.
        /// </summary>
        private readonly IMapperService _mapperService;

        /// <summary>
        /// Instancia de adapter de la capa de negocio de Tags
        /// </summary>
        private readonly ITagBussinessAdapter _tagBussinessAdapter;

        /// <summary>
        /// Crear una nueva instancia de la clase <see cref="TagFacade"/>
        /// </summary>
        /// <param name="mapperService">Instancia de la implementación de <see cref="IMapperService"/>.</param>
        /// <param name="tagBussinessAdapter">Instancia de la implementación de <see cref="ITagBussinessAdapter"/>.</param>
        public TagFacade(IMapperService mapperService, ITagBussinessAdapter tagBussinessAdapter)
        {
            this._mapperService = mapperService;
            this._tagBussinessAdapter = tagBussinessAdapter;
        }

        /// <summary>
        /// Obtener todos los tags.
        /// </summary>
        /// <returns>Listado de tags.</returns>
        public async Task<IEnumerable<TagDto>> GetAll()
        {
            var result = await this._tagBussinessAdapter.GetAll();
            return this._mapperService.Map<IEnumerable<TagDto>, IEnumerable<Tag>>(result);
        }

        /// <summary>
        /// Obtener tags paginados indicando el numero de pagina.
        /// </summary>
        /// <returns>Listado de tags paginados.</returns>
        public async Task<PaginatedResultsDto<TagDto>> GetPaginated(int page)
        {
            var result = await this._tagBussinessAdapter.GetPaginated(page);
            return this._mapperService.Map<PaginatedResultsDto<TagDto>, PaginatedResults<Tag>>(result);
        }

        /// <summary>
        /// Obtener un tag por id.
        /// </summary>
        /// <param name="id">Id del tag a consultar.</param>
        /// <returns>Tag consultado o null si no existe.</returns>
        public async Task<TagDto> GetById(int id)
        {
            var result = await this._tagBussinessAdapter.GetById(id);
            return this._mapperService.Map<TagDto, Tag>(result);
        }

        /// <summary>
        /// Eliminar un tag por id.
        /// </summary>
        /// <param name="id">Id del tag a eliminar.</param>
        /// <returns>Sin resultado.</returns>
        public async Task Delete(int id)
        {
            await this._tagBussinessAdapter.Delete(id);
        }

        /// <summary>
        /// Agregar un nuevo tag.
        /// </summary>
        /// <param name="tag">Tag a agregar.</param>
        /// <returns>Nuevo tag.</returns>
        public async Task<TagDto> Add(AddOrUpdateTagDto tag)
        {
            var result = await this._tagBussinessAdapter.Add(this._mapperService.Map<Tag, AddOrUpdateTagDto>(tag));
            return this._mapperService.Map<TagDto, Tag>(result);
        }

        /// <summary>
        /// Actualizar un tag.
        /// </summary>
        /// <param name="id">Id del tag a actualizar.</param>
        /// <param name="tag">Tag con nueva información.</param>
        /// <returns>Tag actualizado.</returns>
        public async Task<TagDto> Update(int id, AddOrUpdateTagDto tag)
        {
            var result = await this._tagBussinessAdapter.Update(id, this._mapperService.Map<Tag, AddOrUpdateTagDto>(tag));
            return this._mapperService.Map<TagDto, Tag>(result);
        }
    }
}
