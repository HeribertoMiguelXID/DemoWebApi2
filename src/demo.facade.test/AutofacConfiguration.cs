using Autofac;
using demo.facade.Mapping;

namespace demo.facade.test
{
    /// <summary>
    /// Configuración de Autofac para las pruebas unitarias.
    /// </summary>
    public static class AutofacConfiguration
    {
        /// <summary>
        /// Agragar las configuraciones iniciales para el contenedor de Autofac.
        /// </summary>
        /// <param name="builder">Instancia del contenedor de Autofac.</param>
        public static void Configure(ContainerBuilder builder) {
            var mapper = new SingletonMapperService();
            builder.RegisterInstance(mapper).As<IMapperService>();
        }
    }
}