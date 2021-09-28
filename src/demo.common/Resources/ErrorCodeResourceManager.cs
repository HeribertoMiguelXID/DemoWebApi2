namespace demo.common.Resources
{
    /// <summary>
    /// Clase para acceder a los recursos de los códigos de error.
    /// </summary>
    public static class ErrorCodeResourceManager
    {
        /// <summary>
        /// Obtener el mensaje de error por clave.
        /// </summary>
        /// <param name="key">Clave del error.</param>
        /// <returns>Mensaje de error</returns>
        public static string GetValue(string key)
        {
            // Código de error en la validación de información.
            if (key.StartsWith("VAL"))
                return ValidationErrorCodes.ResourceManager.GetString(key);

            return string.Empty;
        }
    }
}
