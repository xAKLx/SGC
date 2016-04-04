using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGCBLL
{
    /// <summary>
    /// Clase representativa del usuario de un empleado.
    /// </summary>
    public class EmpleadoUsuario
    {
        #region Declaracion de datos
        /// <summary>
        /// Identificador del empleado (cedula)
        /// </summary>
        private String idEmpleado;

        /// <summary>
        /// Usuario del empleado.
        /// </summary>
        private String usuario;

        /// <summary>
        /// Clave del empleado.
        /// </summary>
        private String clave;
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
        /// Retorna y asigna el usuario del empleado.
        /// Rango de longitud del valor asignado: 6-20.
        /// </summary>
        /// <exception cref="ArgumentOutOfRangeException.ArgumentOutOfRangeException">Si el valor a asignar se encuentra fuera del rango.</exception>
        /// <exception cref="System.NullReferenceException">Si el valor a asignar es null.</exception>
        public String Usuario
        {
            get { return usuario; }
            set
            {
                if (20 < value.Length || 0 > value.Length)
                    throw new ArgumentOutOfRangeException("value", "La longitud debe estar entre 6 y 20.");
                usuario = value;
            }
        }

        /// <summary>
        /// Retorna y asigna la clave del empleado.
        /// Rango de longitud del valor asignado: 6-30.
        /// </summary>
        /// <exception cref="ArgumentOutOfRangeException.ArgumentOutOfRangeException">Si el valor a asignar se encuentra fuera del rango.</exception>
        /// <exception cref="System.NullReferenceException">Si el valor a asignar es null.</exception>
        public String Clave
        {
            get { return clave; }
            set
            {
                if (30 < value.Length || 0 > value.Length)
                    throw new ArgumentOutOfRangeException("value", "La longitud debe estar entre 6 y 30.");
                clave = value;
            }
        }
        #endregion

        /// <summary>
        /// Instancia a un Usuario de un empleado.
        /// </summary>
        /// <param name="idEmpleado">Identificador del empleado. Su longitud debe ser igual a 11.</param>
        /// <param name="usuario">Usuario del empleado. Su longitud debe estar entre 6 y 20.</param>
        /// <param name="clave">Clave del usuario. Su longitud debe estar entre 6 y 30.</param>
        /// <exception cref="ArgumentOutOfRangeException.ArgumentOutOfRangeException">Cuando la longitud de uno de los parametros es invalida.</exception>
        /// <exception cref="ArgumentNullException.ArgumentNullException">Cuando uno de los parametros es null.</exception>
        public EmpleadoUsuario(String idEmpleado, String usuario, String clave)
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


            try
            {
                Usuario = usuario;
            }
            catch (ArgumentOutOfRangeException e)
            {
                throw new ArgumentOutOfRangeException("usuario", e.Message);
            }
            catch (NullReferenceException)
            {
                throw new ArgumentNullException("usuario");
            }

            try
            {
                Clave = clave;
            }
            catch (ArgumentOutOfRangeException e)
            {
                throw new ArgumentOutOfRangeException("clave", e.Message);
            }
            catch (NullReferenceException)
            {
                throw new ArgumentNullException("clave");
            }
        }
    }
}
