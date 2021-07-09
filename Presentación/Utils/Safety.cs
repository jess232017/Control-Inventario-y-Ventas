using System;
using System.Drawing;
using System.IO;

namespace Presentación
{

    public static class Safety
    {

        /// <summary>
        /// Convierte una Objecto de tipo Image a una arreglo de byte
        /// </summary>
        /// <param name="image">Imagen a convertir</param>
        /// <returns>un arreglo de byte</returns>
        public static byte[] SafeByte(Image image)
        {
            if(image != null)
            {
                using (var ms = new MemoryStream())
                {
                    image.Save(ms, image.RawFormat);
                    return ms.ToArray();
                }
            }

            byte[] imgtype = { 0 };

            return imgtype;
        }

        /// <summary>
        /// Convierte un arreglo de Bytes a un objecto de tipo Image
        /// </summary>
        /// <param name="byteArrayIn">Bytes a convertir en Imagen</param>
        /// <returns>retorna una Imagen</returns>
        public static Image SafeImage(byte[] byteArrayIn)
        {
            using (var ms = new MemoryStream(byteArrayIn))
            {
                return Image.FromStream(ms);
            }
        }

        /// <summary>
        /// Retorno seguro de un valor entero
        /// </summary>
        /// <param name="text">Cadena de texto a convertir</param>
        /// <returns>Retorna -1 si no se realizo la conversion con exito o el numero convertido</returns>
        public static int SafeInt(string text) => int.TryParse(text, out int result) ? result : -1;

        /// <summary>
        /// Retorno seguro de un valor flotante
        /// </summary>
        /// <param name="text">Cadena de texto a convertir</param>
        /// <returns>Retorna 0.0f si no se realizo la conversion con exito o el numero convertido</returns>
        public static float SafeFloat(string text) => float.TryParse(text, out float result) ? result : 0.0f;

        /// <summary>
        /// Retorno seguro de un valor flotante con doble precision
        /// </summary>
        /// <param name="text">Cadena de texto a convertir</param>
        /// <returns>Retorna 0.0f si no se realizo la conversion con exito o el numero convertido</returns>
        public static double SafeDouble(string text) => double.TryParse(text, out double result) ? result : 0.0f;

        public static DateTime SafeDateTime(string text) => DateTime.TryParse(text, out DateTime result) ? result : new DateTime();
    }
}
