using demo.api.Models;
using demo.dtos;
using System.Collections.Generic;

namespace demo.api.Documentation.Examples
{
    /// <summary>
    /// Clase para generar ejemplos de tipo <![CDATA[see cref="ResponseSuccessModel<PaginatedResultsDto<T>>"]]>
    /// </summary>
    public class ResponseSuccessTableExample<T> : BaseExample<ResponseSuccessModel<PaginatedResultsDto<T>>> where T: new()
    {
        /// <summary>
        /// Asignar valores de ejemplo a la instancia.
        /// </summary>
        public override void SetExampleData()
        {
            this.Instance.Data = new PaginatedResultsDto<T>();
            this.Instance.Data.Records = new List<T>();
            this.Instance.Data.Metadata = new PaginatedResultsMetadataDto() {
                Page = 1,
                PerPage = 2,
                TotalCount = 10
            };

            for (int i = 1; i <= Instance.Data.Metadata.PerPage; i++)
            {
                var instance = this.GetClassExample<T>().GetInstance();
                this.Instance.Data.Records.Add(instance); 
            }
        }
    }
}