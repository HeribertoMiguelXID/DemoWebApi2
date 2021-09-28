namespace demo.api.Models
{
    /// <summary>
    /// Instancia resultado de una operación fallida
    /// </summary>
    /// <typeparam name="T">Tipo de la data</typeparam>
    public class ResponseFailModel<T>
    {
        /// <summary>
        /// Estatus de la operación
        /// </summary>
        public string Status => "Fail";

        /// <summary>
        /// Código de estatus de la operación 
        /// </summary>
        public int StatusCode => 2;

        /// <summary>
        /// Data 
        /// </summary>
        public T Data { get; set; }

        /// <summary>
        /// Inicializar una nueva instancia de la clase <![CDATA[see cref="ResponseFailModel<T>"]]>
        /// </summary>
        public ResponseFailModel(T data)
        {
            this.Data = data;
        }

        /// <summary>
        /// Inicializar una nueva instancia de la clase <![CDATA[see cref="ResponseFailModel<T>"]]>
        /// </summary>
        public ResponseFailModel()
        {
        }
    }
}