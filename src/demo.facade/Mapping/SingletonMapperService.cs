using AutoMapper;

namespace demo.facade.Mapping
{
    /// <summary>
    /// Clase que abstrae la implementacion del mapeo de entidades utilizando AutoMapper.
    /// </summary>
    public class SingletonMapperService: IMapperService
    {
        /// <summary>
        /// Instancia de AutoMapper.
        /// </summary>
        private static IMapper s_mapper;

        /// <summary>
        /// Crear una instancia de AutoMapper utilizando el patron Singleton para manejar la misma instancia en cada solicitud.
        /// </summary>
        /// <returns>Instancia de Automapper.</returns>
        private static IMapper GetMapperInstance()
        {
            if (s_mapper is null)
            {
                var config = new MapperConfiguration(cfg => cfg.AddProfile<AutoMapperProfile>());
                s_mapper = config.CreateMapper();
            }

            return s_mapper;
        }

        /// <summary>
        /// Mapear una entidad a otro tipo de entidad.
        /// </summary>
        /// <typeparam name="YDest">Tipo de entidad destino.</typeparam>
        /// <typeparam name="TSource">Tipo de entidad origen.</typeparam>
        /// <param name="source">Instancia a copiar.</param>
        /// <returns>Nueva instancia con la informacion de la instancia origen.</returns>
        public YDest Map<YDest, TSource>(TSource source)
            => GetMapperInstance().Map<YDest>(source);
    }
}
