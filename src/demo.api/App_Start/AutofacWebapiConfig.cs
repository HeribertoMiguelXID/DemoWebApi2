using Autofac;
using Autofac.Integration.WebApi;
using demo.api.Services;
using demo.bussiness.adapter;
using demo.facade;
using demo.facade.Mapping;
using System.Reflection;
using System.Web.Http;

namespace demo.api.App_Start
{
    /// <summary>
    /// Configuracion de Autofac
    /// </summary>
    public static class AutofacWebapiConfig
    {
        /// <summary>
        /// Inicializar Autofac.
        /// </summary>
        /// <param name="config">Configuracion de la WebApi.</param>
        public static void Initialize(HttpConfiguration config)
        {
            Initialize(config, RegisterServices(new ContainerBuilder()));
        }

        /// <summary>
        /// Inicializar Autofac como el contenedor de dependencias.
        /// </summary>
        /// <param name="config">Configuracion de la WebApi.</param>
        /// <param name="container">Contenedor de Autofac.</param>
        public static void Initialize(HttpConfiguration config, IContainer container)
        {
            config.DependencyResolver = new AutofacWebApiDependencyResolver(container);
        }

        /// <summary>
        /// Registro de las dependencias.
        /// </summary>
        /// <param name="builder">Constructor del contenedor de Autofac.</param>
        /// <returns>Contenedor de Autofac.</returns>
        private static IContainer RegisterServices(ContainerBuilder builder)
        {
            // Registro de los controladores.  
            builder.RegisterApiControllers(Assembly.GetExecutingAssembly());

            // Registro del singleton para el uso de Automapper.  
            builder.RegisterType<SingletonMapperService>().AsSelf().AsImplementedInterfaces().SingleInstance();

            // Registro de facade.  
            builder.RegisterType<TagFacade>().As<ITagFacade>().InstancePerRequest();
            
            // Registro de adapter.  
            builder.RegisterType<TagBussinessAdapter>().As<ITagBussinessAdapter>().InstancePerRequest();

            // Registro de servicios.  
            builder.RegisterType<FluentValidationService>().As<IValidationService>().InstancePerRequest();

            return builder.Build();
        }
    }
}