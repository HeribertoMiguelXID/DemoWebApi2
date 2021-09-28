using System;

namespace demo.common.Extensions
{
    /// <summary>
    /// Metodos de extension de la clase <see cref="Type"/>
    /// </summary>
    public static class TypeExtensions
    {
        /// <summary>
        /// Obtener un atributo desde la definicion de un tipo.
        /// </summary>
        /// <typeparam name="T">Tipo del atributo.</typeparam>
        /// <param name="type">Definicion del tipo.</param>
        /// <returns>Atributo o null en caso de no existir.</returns>
        public static T GetCustomAttribute<T>(this Type type) where T: class
        {
            foreach (var attribute in Attribute.GetCustomAttributes(type))
            {
                var customAttribute = attribute as T;
                if (customAttribute != null)
                {
                    return customAttribute;
                }
            }

            return null;
        }
    }
}
