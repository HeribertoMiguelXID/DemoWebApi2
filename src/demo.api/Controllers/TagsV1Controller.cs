using demo.api.Documentation.Examples;
using demo.api.Models;
using demo.api.Services;
using demo.dtos;
using demo.facade;
using Swashbuckle.Examples;
using Swashbuckle.Swagger.Annotations;
using System.Collections.Generic;
using System.Net;
using System.Threading.Tasks;
using System.Web.Http;

namespace demo.api.Controllers
{
    /// <summary>
    /// Controlador para acceso a Tags V1
    /// </summary>
    [RoutePrefix("api/v1/tags")]
    [SwaggerResponse(HttpStatusCode.Unauthorized, "Unauthorized. No se ha indicado o es incorrecto el Token de acceso.", typeof(ResponseErrorModel))]
    [SwaggerResponseExample(HttpStatusCode.Unauthorized, typeof(ResponseErrorModelUnauthorizedExample))]
    [SwaggerResponse(HttpStatusCode.InternalServerError, "InternalServerError. Ocurrió un error inesperado", typeof(ResponseErrorModel))]
    [SwaggerResponseExample(HttpStatusCode.InternalServerError, typeof(ResponseErrorModelInternalServerErrorExample))]

    public class TagsV1Controller : BaseController
    {
        internal readonly ITagFacade _tagFacade;
        internal readonly IValidationService _validator;

        /// <summary>
        /// Inicializar una nueva instancia de la clase <see cref="TagsV1Controller"/>.
        /// </summary>
        public TagsV1Controller(ITagFacade tagFacade, IValidationService validator)
        {
            this._tagFacade = tagFacade;
            this._validator = validator;
        }

        /// <summary>
        /// Obtiene un el listado de tags.
        /// </summary>
        /// <remarks>
        /// Descripción larga de la operación.
        /// </remarks>
        [HttpGet, Route("")]
        [SwaggerResponse(HttpStatusCode.OK, "OK. Devuelve los objetos solicitados.", typeof(ResponseSuccessModel<IEnumerable<TagDto>>))]
        [SwaggerResponseExample(HttpStatusCode.OK, typeof(ResponseSuccessModelIEnumerableExample<TagDto>))]
        public async Task<IHttpActionResult> GetAll()
        {
            return ResponseOk(await this._tagFacade.GetAll());
        }

        /// <summary>
        /// Obtiene un listado de tags paginados.
        /// </summary>
        /// <remarks>
        /// Descripción larga de la operación.
        /// </remarks>
        [HttpGet, Route("paginated")]
        [SwaggerResponse(HttpStatusCode.OK, "OK. Devuelve los objetos solicitados.", typeof(ResponseSuccessModel<PaginatedResultsDto<TagDto>>))]
        [SwaggerResponseExample(HttpStatusCode.OK, typeof(ResponseSuccessTableExample<TagDto>))]
        [SwaggerRequestExample(typeof(PaginationParametersDto), typeof(RequestPaginationParametersDtoExample))]
        public async Task<IHttpActionResult> GetPage([FromUri] PaginationParametersDto page)
        {
            return ResponseOk(await this._tagFacade.GetPaginated(page.PageNumber));
        }

        /// <summary>
        /// Obtiene un tag por id
        /// </summary>
        /// <remarks>
        /// Descripción larga de la operación.
        /// </remarks>
        /// <param name="id">Identificador del tag a consultar.</param>  
        [HttpGet, Route("{id}")]
        [SwaggerResponse(HttpStatusCode.OK, "OK. Devuelve el tag solicitado.", typeof(ResponseSuccessModel<TagDto>))]
        [SwaggerResponseExample(HttpStatusCode.OK, typeof(ResponseSuccessModelObjectExample<TagDto>))]
        [SwaggerResponse(HttpStatusCode.NotFound, "NotFound. No se ha encontrado el tag solicitado.", typeof(ResponseErrorModel))]
        [SwaggerResponseExample(HttpStatusCode.NotFound, typeof(ResponseErrorModelNotFoundExample))]
        public async Task<IHttpActionResult> GetById(int id)
        {
            var result = await this._tagFacade.GetById(id);

            if (result is null)
            {
                return ResponseNotFound();
            }

            return ResponseOk(result);
        }

        /// <summary>
        /// Agregar un nuevo tag
        /// </summary>
        /// <remarks>
        /// Descripción larga de la operación.
        /// </remarks>
        /// <param name="tag">Informacion con la que se creara el tag.</param>  
        [HttpPost, Route("")]
        [SwaggerResponse(HttpStatusCode.Created, "Created. Creacion correcta del tag.", typeof(ResponseSuccessModel<TagDto>))]
        [SwaggerResponseExample(HttpStatusCode.Created, typeof(ResponseSuccessModelObjectExample<TagDto>))]
        [SwaggerResponse(HttpStatusCode.BadRequest, "BadRequest. La solicitud no cumple con los requerimientos.", typeof(ResponseFailModel<Dictionary<string, string>>))]
        [SwaggerResponseExample(HttpStatusCode.BadRequest, typeof(ResponseFailModelBadRequestExample))]
        [SwaggerRequestExample(typeof(AddOrUpdateTagDto), typeof(AddOrUpdateTagDtoExample))]
        public async Task<IHttpActionResult> Post([FromBody]AddOrUpdateTagDto tag)
        {
            var validationResult = this._validator.Validate(tag);
            if (!validationResult.IsValid)
            {
                return ResponseBadRequest(validationResult.Errors);
            }

            var result = await this._tagFacade.Add(tag);
            return ResponseCreated(result);
        }

        /// <summary>
        /// Actualizar un tag por id
        /// </summary>
        /// <remarks>
        /// Descripción larga de la operación.
        /// </remarks>
        /// <param name="id">Identificador del tag a modificar.</param>  
        /// <param name="tag">Nueva informacion para el tag.</param>  
        [HttpPut, Route("{id}")]
        [SwaggerResponse(HttpStatusCode.OK, "OK. Actualización correcta del tag.", typeof(ResponseSuccessModel<TagDto>))]
        [SwaggerResponseExample(HttpStatusCode.OK, typeof(ResponseSuccessModelObjectExample<TagDto>))]
        [SwaggerResponse(HttpStatusCode.NotFound, "NotFound. No se ha encontrado el tag que se intenta actualizar.", typeof(ResponseErrorModel))]
        [SwaggerResponseExample(HttpStatusCode.NotFound, typeof(ResponseErrorModelNotFoundExample))]
        [SwaggerResponse(HttpStatusCode.BadRequest, "BadRequest. La solicitud no cumple con los requerimientos.", typeof(ResponseFailModel<Dictionary<string, string>>))]
        [SwaggerResponseExample(HttpStatusCode.BadRequest, typeof(ResponseFailModelBadRequestExample))]
        [SwaggerRequestExample(typeof(AddOrUpdateTagDto), typeof(AddOrUpdateTagDtoExample))]
        public async Task<IHttpActionResult> Put(int id, [FromBody]AddOrUpdateTagDto tag)
        {
            var existingTag = await this._tagFacade.GetById(id);
            if (existingTag is null)
            {
                return ResponseNotFound();
            }

            var validationResult = this._validator.Validate(tag);
            if (!validationResult.IsValid)
            {
                return ResponseBadRequest(validationResult.Errors);
            }

            var result = await this._tagFacade.Update(id, tag);

            return ResponseOk(result);
        }

        /// <summary>
        /// Eliminar un tag por id
        /// </summary>
        /// <remarks>
        /// Descripción larga de la operación.
        /// </remarks>
        /// <param name="id">Identificador del tag a eliminar.</param>  
        [HttpDelete, Route("{id}")]
        [SwaggerResponse(HttpStatusCode.OK, "OK. Eliminacion correcta del tag.", typeof(ResponseSuccessModel<string>))]
        [SwaggerResponseExample(HttpStatusCode.OK, typeof(ResponseSuccessModelDeleteExample))]
        [SwaggerResponse(HttpStatusCode.NotFound, "NotFound. No se ha encontrado el tag que se intenta eliminar.", typeof(ResponseErrorModel))]
        [SwaggerResponseExample(HttpStatusCode.NotFound, typeof(ResponseErrorModelNotFoundExample))]
        public async Task<IHttpActionResult> Delete(int id)
        {
            var existingTag = await this._tagFacade.GetById(id);

            if (existingTag is null)
            {
                return ResponseNotFound();
            }

            await this._tagFacade.Delete(id);
            return ResponseOk();
        }
    }
}
