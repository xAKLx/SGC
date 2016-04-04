using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGCBLL
{
    /// <summary>
    /// Clase representativa de un empleado
    /// </summary>
    public class Empleado
    {
        #region Declaracion de datos
        /// <summary>
        /// Identificador del empleado (cedula)
        /// </summary>
        private String idEmpleado;

        /// <summary>
        /// Nombre del empleado. (Nunca sera null)
        /// </summary>
        private String nombreEmpleado;

        /// <summary>
        /// Telefono del empleado.
        /// </summary>
        private long? telefono;

        #endregion

        #region Property
        /// <summary>
        /// Retorna y asigna el Id del empleado.
        /// El valor asignado debe ser de longitud 11.
        /// </summary>
        /// <exception cref="ArgumentOutOfRangeException.ArgumentOutOfRangeException">Si el valor a asignar no es de longitud 11.</exception>
        /// <exception cref="System.NullReferenceException">Si el valor a asignar es null.</exception>
        public String IdEmpleado
        {
            get { return idEmpleado; }
            set
            {
                
                if (11 != value.Length)
                    throw new ArgumentOutOfRangeException("value", "La longitud debe ser igual a 11");
                idEmpleado = value;
            }
        }

        /// <summary>
        /// Retorna y asigna el nombre del empleado.
        /// En caso de recivir un null para asignar, el nombre
        /// del empleado sera igual a una cadena vacia.
        /// </summary>
        public String NombreEmpleado
        {
            get { return nombreEmpleado; }
            set
            {
                if (null == value)
                    nombreEmpleado = "";
                else
                    nombreEmpleado = value;
            }
        }

        /// <summary>
        /// Retorna y asigna el telefono del empleado.
        /// En caso de que el valor a asignar se encuentre fuera de rango,
        /// se le asignara null.
        /// </summary>
        public long? Telefono
        {
            get { return telefono; }
            set
            {
                if (null != value &&
                    (1000000000 > value || 9999999999 < value))
                    telefono = null;
                else
                    telefono = value;
            }
        }

        /// <summary>
        /// Retorna y asigna la seccion del empleado.
        /// </summary>
        public String Seccion { get; set; }
        #endregion

        /// <summary>
        /// Instancia una clase Empleado
        /// </summary>
        /// <param name="idEmpleado"></param>
        /// <param name="nombreEmpleado"></param>
        /// <param name="seccion"></param>
        /// <param name="telefono"></param>
        /// <exception cref="ArgumentOutOfRangeException.ArgumentOutOfRangeException">Cuando la longitud de idEmpleado es invalida.</exception>
        /// <exception cref="ArgumentNullException.ArgumentNullException">Cuando idEmpleado es null.</exception>
        public Empleado(String idEmpleado, String nombreEmpleado, String seccion, long? telefono= null)
        {
            try
            {
                IdEmpleado = idEmpleado;
            }
            catch (ArgumentOutOfRangeException e)
            {
                throw new ArgumentOutOfRangeException("idEmpleado", e.Message);
            }
            catch(NullReferenceException)
            {
                throw new ArgumentNullException("idEmpleado");
            }

            NombreEmpleado = nombreEmpleado;

            Telefono = telefono;

            Seccion = seccion;
        }

    }
}
