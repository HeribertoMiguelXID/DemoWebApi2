using Autofac.Extras.Moq;

namespace demo.facade.test
{
    /// <summary>
    /// Clase base para las pruebas unitarias de los facade.
    /// </summary>
    /// <typeparam name="T">Tipo de la clase facade a testear.</typeparam>
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
