using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGCBLL
{
    /// <summary>
    /// Clase representativa de un cliente.
    /// </summary>
    public class Cliente
    {
        #region Declaracion de datos
        /// <summary>
        /// Identificador del cliente. (No puede ser null)
        /// </summary>
        private String idCliente;

        /// <summary>
        /// Nombre del cliente. (Nunca sera null)
        /// </summary>
        private String nombreCliente;

        /// <summary>
        /// Telefono del cliente.
        /// </summary>
        private long? telefono;

        /// <summary>
        /// Direccion del cliente, no puede ser null ni vacia.
        /// </summary>
        private String direccion;
        #endregion

        #region Property
        /// <summary>
        /// Retorna y asigna el Id del cliente.
        /// El valor asignado debe ser de longitud 11.
        /// </summary>
        /// <exception cref="ArgumentOutOfRangeException.ArgumentOutOfRangeException">Si el valor a asignar no es de longitud 11.</exception>
        /// <exception cref="System.NullReferenceException">Si el valor a asignar es null.</exception>
        public String IdCliente
        {
            get { return idCliente; }
            set
            {
                if (11 != value.Length)
                    throw new ArgumentOutOfRangeException("value", "La longitud debe ser igual a 11");
                idCliente = value;
            }
        }

        /// <summary>
        /// Retorna y asigna el nombre del cliente.
        /// En caso de recivir un null para asignar, el nombre
        /// del cliente sera igual a una cadena vacia.
        /// </summary>
        public String NombreCliente
        {
            get { return nombreCliente; }
            set
            {
                if (null == value)
                    nombreCliente = "";
                else
                    nombreCliente = value;
            }
        }

        /// <summary>
        /// Retorna y asigna el telefono del cliente.
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
        /// Retorna y asigna la direccion del cliente.
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
        /// Instancia la clase Cliente.
        /// </summary>
        /// <param name="idCliente">Identificador del cliente. La longitud debe tener 11 digitos. No puede ser null.</param>
        /// <param name="nombreCliente">Nombre del cliente.</param>
        /// <param name="telefono">telefono del cliente</param>
        /// <exception cref="ArgumentOutOfRangeException.ArgumentOutOfRangeException">En caso de que la longitud de idCliente no sea 11 o direccion sea una cadena vacia.</exception>
        /// <exception cref="System.NullReferenceException">En caso de que idCliente o direccion sea null.</exception>
        public Cliente(String idCliente, String direccion, String nombreCliente = null, long? telefono = null)
        {
            try
            {
                IdCliente = idCliente;
            }
            catch (ArgumentOutOfRangeException e)
            {
                throw new ArgumentOutOfRangeException("idCliente", e.Message);
            }
            catch (NullReferenceException)
            {
                throw new ArgumentNullException("idCliente");
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

            NombreCliente = nombreCliente;

            Telefono = telefono;
        }

        /// <summary>
        /// Instancia la clase Cliente con el nombre como cadena vacia..
        /// </summary>
        /// <param name="idCliente">Identificador del cliente. La longitud debe tener 11 digitos. No puede ser null.</param>
        /// <param name="telefono">telefono del cliente</param>
        /// <exception cref="ArgumentOutOfRangeException.ArgumentOutOfRangeException">En caso de que la longitud de idCliente no sea 11.</exception>
        /// <exception cref="System.NullReferenceException">En caso de que idCliente sea null.</exception>
        public Cliente(String idCliente, String direccion, long? telefono): this(idCliente, direccion, null, telefono)
        {
            
        }
        #endregion
    }
}
