using FluentValidation.WebApi;
using System.Web.Http;

namespace demo.api
{
    /// <summary>
    /// Configuración de la API
    /// </summary>
    public static class WebApiConfig
    {
        /// <summary>
        /// Configuración de la API
        /// </summary>
        /// <param name="config">Objeto de configuración </param>
        public static void Register(HttpConfiguration config)
        {
            // Fluent Validation
            FluentValidationModelValidatorProvider.Configure(config);

            // Web API routes
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{version}/{controller}/{id}",
                defaults: new {
                    id = RouteParameter.Optional,
                    version = 1
                }
            );
        }
    }
}
