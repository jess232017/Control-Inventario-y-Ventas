using System.Data;

namespace Negocio.Utils
{
    /// <summary>
    /// Interfaz que permite leer la tabla y hacer cambios a la BD desde la interfaz heredable
    /// (Edicion de objectos) para no repetir el mismo codigo en cada formulario que se usa para guardar registros
    /// </summary>
    public interface IModelo
    {
        string Mensaje { get; set; }
        Accion Accion { get; set; }
        bool Exito { get; set; }

        /// <summary>
        /// Dispara la Accion establecidad: Agregar, Actualizar, Eliminar
        /// </summary>
        /// <returns>Un entero con las columnas afectadas</returns>
        int Accionar();

        /// <summary>
        /// Lee todas o una sola columna especifica
        /// </summary>
        /// <returns>Un DataTable con las filas obtenidas</returns>
        DataTable LeerTabla();
    }

    public enum Accion
    {
        Agregar, Actualizar, Eliminar
    }
}
