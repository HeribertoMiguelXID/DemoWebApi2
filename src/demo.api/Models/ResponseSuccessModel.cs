namespace demo.api.Models
{
    /// <summary>
    /// Instancia resultado de una operación exitosa
    /// </summary>
    /// <typeparam name="T">Tipo de la data</typeparam>
    public class ResponseSuccessModel<T>
    {
        /// <summary>
        /// Estatus de la operación 
        /// </summary>
        public string Status => "Success";

        /// <summary>
        /// Código de estatus de la operación 
        /// </summary>
        public int StatusCode => 1;

        /// <summary>
        /// Data 
        /// </summary>
        public T Data { get; set; }

        /// <summary>
        /// Inicializar una nueva instancia de la clase <![CDATA[see cref="ResponseSuccessModel<T>"]]>
        /// </summary>
        public ResponseSuccessModel(T data)
        {
            this.Data = data;
        }

        /// <summary>
        /// Inicializar una nueva instancia de la clase <![CDATA[see cref="ResponseSuccessModel<T>"]]>
        /// </summary>
        public ResponseSuccessModel()
        {
        }
    }
}