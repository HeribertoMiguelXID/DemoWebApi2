namespace demo.facade.Mapping
{
    /// <summary>
    /// Interfaz de la clase que abstrae la implementacion del mapeo de entidades.
    /// </summary>
    public interface IMapperService
    {
        /// <summary>
        /// Mapear una entidad a otro tipo de entidad.
        /// </summary>
        /// <typeparam name="YDest">Tipo de entidad destino.</typeparam>
        /// <typeparam name="TSource">Tipo de entidad origen.</typeparam>
        /// <param name="source">Instancia a copiar.</param>
        /// <returns>Nueva instancia con la informacion de la instancia origen.</returns>
        YDest Map<YDest, TSource>(TSource source);
    }
}
