using demo.api.Models;
using Swashbuckle.Swagger.Annotations;
using System.Net;
using System.Web.Http;
using System.Web.Http.Results;

namespace demo.api.Controllers
{
    /// <summary>
    /// Clase base para los controladores de WebApi
    /// </summary>
    [SwaggerResponseRemoveDefaults]
    public abstract class BaseController : ApiController
    {
        /// <summary>
        /// Generar el estatus 404 de forma personalizada.
        /// </summary>
        /// <returns>Respuesta http.</returns>
        protected NegotiatedContentResult<ResponseErrorModel> ResponseNotFound()
            => Content(HttpStatusCode.NotFound, new ResponseErrorModel("El recurso solicitado no existe."));

        /// <summary>
        /// Generar el estatus 200 de forma personalizada.
        /// </summary>
        /// <typeparam name="T">Tipo de contenido en la respuesta.</typeparam>
        /// <param name="content">Contenido de la respuesta.</param>
        /// <returns>Respuesta http.</returns>
        protected NegotiatedContentResult<ResponseSuccessModel<T>> ResponseOk<T>(T content)
            => Content(HttpStatusCode.OK, new ResponseSuccessModel<T>(content));

        /// <summary>
        /// Generar el estatus 201 de forma personalizada.
        /// </summary>
        /// <typeparam name="T">Tipo de contenido en la respuesta.</typeparam>
        /// <param name="content">Contenido de la respuesta.</param>
        /// <returns>Respuesta http.</returns>
        protected NegotiatedContentResult<ResponseSuccessModel<T>> ResponseCreated<T>(T content)
            => Content(HttpStatusCode.Created, new ResponseSuccessModel<T>(content));

        /// <summary>
        /// Generar el estatus 200 de forma personalizada.
        /// </summary>
        /// <returns>Respuesta http.</returns>
        protected NegotiatedContentResult<ResponseSuccessModel<string>> ResponseOk()
            => Content(HttpStatusCode.OK, new ResponseSuccessModel<string>(null));

        /// <summary>
        /// Generar el estatus 400 de forma personalizada.
        /// </summary>
        /// <typeparam name="T">Tipo de contenido en la respuesta.</typeparam>
        /// <param name="content">Contenido de la respuesta.</param>
        /// <returns>Respuesta http.</returns>
        protected NegotiatedContentResult<ResponseFailModel<T>> ResponseBadRequest<T>(T content)
            => Content(HttpStatusCode.BadRequest, new ResponseFailModel<T>(content));

        
    }
}
