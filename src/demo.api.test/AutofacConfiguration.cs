using Autofac;
using demo.facade.Mapping;

namespace demo.api.test
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
        }
    }
}