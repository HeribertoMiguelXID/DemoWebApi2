using Swashbuckle.Examples;
using System;
using System.Linq;
using System.Reflection;

namespace demo.api.Documentation.Examples
{
    /// <summary>
    /// Clase base para generar ejemplos de solicitud y respuesta que se mostraran en swagger
    /// </summary>
    /// <typeparam name="T">Tipo de objeto.</typeparam>
    public abstract class BaseExample<T>: IExamplesProvider where T : new()
    {
        /// <summary>
        /// Instancia con información de prueba.
        /// </summary>
        protected T Instance = new T();

        /// <summary>
        /// Constructor de la clase base.
        /// </summary>
        protected BaseExample()
            => this.SetExampleData();

        /// <summary>
        /// Implementación de la interfaz para swagger examples.
        /// </summary>
        /// <returns>Instancia con la información de ejemplo.</returns>
        public object GetExamples()
            =>  this.GetInstance();

        /// <summary>
        /// Obtener instancia tipada. 
        /// </summary>
        /// <returns></returns>
        public T GetInstance()
            => this.Instance;

        /// <summary>
        /// Clase que se implementara en las subclases para asignar valores a la instancia. 
        /// </summary>
        public abstract void SetExampleData();

        /// <summary>
        /// Obtener un ejemplo de forma dinámica.
        /// </summary>
        /// <typeparam name="Y">Tipo de objeto.</typeparam>
        /// <returns>Instancia del generador de ejemplos.</returns>
        public BaseExample<Y> GetClassExample<Y> () where Y: new()
        {
            string typeNamespace = typeof(BaseExample<Y>).Namespace;
            var allTypes = Assembly.GetExecutingAssembly().GetTypes().Where(x => x.Namespace == typeNamespace && x.IsClass);
            var exampleType = allTypes.Where(x => typeof(BaseExample<Y>).IsAssignableFrom(x));
            return Activator.CreateInstance(exampleType.First()) as BaseExample<Y>;
        }
    }
}