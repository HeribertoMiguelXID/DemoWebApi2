using AutoMapper;
using demo.dtos;
using demo.entities;

namespace demo.facade.Mapping
{
    /// <summary>
    /// Clase de configuracion para Automapper.
    /// </summary>
    public class AutoMapperProfile : Profile
    {
        /// <summary>
        /// Inicializar una nueva instancia de la clase <see cref="AutoMapperProfile"/>.
        /// </summary>
        public AutoMapperProfile()
        {
            this.AddMapper<TagDto, Tag>();
            this.AddMapper<AddOrUpdateTagDto, Tag>();
            this.AddMapper<PaginatedResultsMetadataDto, PaginatedResultsMetadata>();
            this.AddMapper<PaginatedResultsDto<TagDto>, PaginatedResults<Tag>>();
        }

        /// <summary>
        /// Agregar un nuevo mapeo
        /// </summary>
        /// <typeparam name="T">Tipo del Dto</typeparam>
        /// <typeparam name="Y">Tipo de la Entidad</typeparam>
        public void AddMapper<T, Y>() 
            where T : new() 
            where Y : new()
        {
            this.CreateMap<Y, T>();
            this.CreateMap<T, Y>();
        }
    }
}
