using Autofac.Extras.Moq;

namespace demo.api.test
{
    /// <summary>
    /// Clase base para las pruebas unitarias de los controladores.
    /// </summary>
    /// <typeparam name="T">Tipo del controlador a testear.</typeparam>
    public class BaseUnitTest<T>
    {
        /// <summary>
        /// Instancia de la clase bajo prueba.
        /// </summary>
        internal T _classUnderTest;

        /// <summary>
        /// Generar la instancia de AutoMock para las pruebas.
        /// </summary>
        /// <returns>Instancia de AutoMock configurada.</returns>
        public AutoMock GetAutoMock()
            => AutoMock.GetLoose(cfg => AutofacConfiguration.Configure(cfg));
    }
}
