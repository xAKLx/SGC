using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGCBLL
{
    /// <summary>
    /// Clase representativa de un agente.
    /// </summary>
    public class Agente
    {
        #region Declaracion de datos
        /// <summary>
        /// Identificador del Agente. (No puede ser null)
        /// </summary>
        private String idAgente;

        /// <summary>
        /// Telefono del Agente.
        /// </summary>
        private long? telefono;

        /// <summary>
        /// Direccion del Agente, no puede ser null ni vacia.
        /// </summary>
        private String direccion;
        #endregion

        #region Property
        /// <summary>
        /// Retorna y asigna el Id del Agente.
        /// El valor asignado debe ser de longitud 11.
        /// </summary>
        /// <exception cref="ArgumentOutOfRangeException.ArgumentOutOfRangeException">Si el valor a asignar no es de longitud 11.</exception>
        /// <exception cref="System.NullReferenceException">Si el valor a asignar es null.</exception>
        public String IdAgente
        {
            get { return idAgente; }
            set
            {
                if (11 != value.Length)
                    throw new ArgumentOutOfRangeException("value", "La longitud debe ser igual a 11");
                idAgente = value;
            }
        }

        /// <summary>
        /// Retorna y asigna el telefono del Agente.
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
        /// Retorna y asigna la direccion del Agente.
        /// No puede ser ni null ni cadena vacia.
        /// </summary>
        /// <exception cref="ArgumentOutOfRangeException.ArgumentOutOfRangeException">Si el valor a asignar no es una cadena vacia.</exception>
        /// <exception cref="System.NullReferenceException">Si el valor a asignar es null.</exception>
        public String Direccion
        {
            get { return direccion; }
            set
            {
                if (0 == value.Length)
                    throw new ArgumentOutOfRangeException("value", "La direccion no puede estar vacia.");
                direccion = value;
            }
        }
        #endregion

        #region Constructores
        /// <summary>
        /// Instancia la clase Agente.
        /// </summary>
        /// <param name="idAgente">Identificador del Agente. La longitud debe tener 11 digitos. No puede ser null.</param>
        /// <param name="telefono">telefono del Agente</param>
        /// <exception cref="ArgumentOutOfRangeException.ArgumentOutOfRangeException">En caso de que la longitud de idAgente no sea 11 o direccion sea una cadena vacia.</exception>
        /// <exception cref="System.NullReferenceException">En caso de que idAgente o direccion sea null.</exception>
        public Agente(String idAgente, String direccion, long? telefono = null)
        {
            try
            {
                IdAgente = idAgente;
            }
            catch (ArgumentOutOfRangeException e)
            {
                throw new ArgumentOutOfRangeException("idAgente", e.Message);
            }
            catch (NullReferenceException)
            {
                throw new ArgumentNullException("idAgente");
            }

            try
            {
                Direccion = direccion;
            }
            catch (ArgumentOutOfRangeException e)
            {
                throw new ArgumentOutOfRangeException("direccion", e.Message);
            }
            catch (NullReferenceException)
            {
                throw new ArgumentNullException("direccion");
            }

            Telefono = telefono;
        }
        #endregion
        
    }
}
