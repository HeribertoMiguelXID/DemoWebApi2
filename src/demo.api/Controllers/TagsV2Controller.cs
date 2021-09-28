using demo.api.Documentation.Examples;
using demo.api.Models;
using demo.dtos;
using Swashbuckle.Examples;
using Swashbuckle.Swagger.Annotations;
using System.Collections.Generic;
using System.Net;
using System.Web.Http;
using System.Web.Http.Description;

namespace demo.api.Controllers
{
    /// <summary>
    /// Controlador para acceso a Tags V2
    /// </summary>
    [RoutePrefix("api/v2/tags")]
    [SwaggerResponse(HttpStatusCode.Unauthorized, "Unauthorized. No se ha indicado o es incorrecto el Token de acceso.", typeof(ResponseErrorModel))]
    [SwaggerResponseExample(HttpStatusCode.Unauthorized, typeof(ResponseErrorModelUnauthorizedExample))]
    [SwaggerResponse(HttpStatusCode.InternalServerError, "InternalServerError. Ocurrió un error inesperado", typeof(ResponseErrorModel))]
    [SwaggerResponseExample(HttpStatusCode.InternalServerError, typeof(ResponseErrorModelInternalServerErrorExample))]

    public class TagsV2Controller : ApiController
    {
        /// <summary>
        /// Inicializar una nueva instancia de la clase <see cref="TagsV1Controller"/>.
        /// </summary>
        public TagsV2Controller()
        {
        }

        /// <summary>
        /// Obtiene un el listado de tags
        /// </summary>
        /// <remarks>
        /// Descripción larga de la operación.
        /// </remarks>
        [SwaggerResponse(HttpStatusCode.OK, "OK. Devuelve los objetos solicitados.", typeof(ResponseSuccessModel<IEnumerable<TagDto>>))]
        [SwaggerResponseExample(HttpStatusCode.OK, typeof(ResponseSuccessModelIEnumerableExample<TagDto>))]
        [HttpGet, Route("")]
        [ResponseType(typeof(string[]))]
        public IEnumerable<string> GetAll()
        {
            return new string[] { };
        }
    }
}
