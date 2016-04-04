using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGCBLL
{
    /// <summary>
    /// Clase representativa de una carga.
    /// </summary>
    public class  Carga
    {
        #region Declaraciones
        /// <summary>
        /// Identificador del cliente. (No puede ser null)
        /// </summary>
        private String idCliente;

        /// <summary>
        /// Direccion destino de la carga. (no puede ser null)
        /// </summary>
        private String destino;

        /// <summary>
        /// Estado de la carga. (no puede ser null)
        /// </summary>
        private String estado;

        /// <summary>
        /// Identificador del agente.
        /// </summary>
        private String idAgente;
        #endregion

        #region Property
        /// <summary>
        /// Retorna y asigna el estado de la carga.
        /// </summary>
        /// <exception cref="ArgumentNullException.ArgumentNullException">Si el valor asignado es null.</exception>
        public String Estado
        {
            get { return estado; }
            set
            {
                if (null == value)
                    throw new ArgumentNullException("value", "Estado no puede ser null.");
                estado = value;
            }
        }

        /// <summary>
        /// Identificador de la carga.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Descripcion de la carga.
        /// </summary>
        public String Descripcion { get; set; }

        /// <summary>
        /// Retorna y asigna destino.
        /// </summary>
        /// <exception cref="ArgumentNullException.ArgumentNullException">Si el valor asignado es null.</exception>
        public String Destino
        {
            get { return destino; }
            set
            {
                if (null == value)
                    throw new ArgumentNullException("value", "El destino no puede ser null.");
                destino = value;
            }
        }

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
        /// Retorna y asigna el Id del agente.
        /// Si el valor no es null, el valor asignado debe ser de longitud 11.
        /// </summary>
        /// <exception cref="ArgumentOutOfRangeException.ArgumentOutOfRangeException">Si el valor a asignar no es de longitud 11.</exception>
        public String IdAgente
        {
            get { return idAgente; }
            set
            {
                if(null != value)
                    if (11 != value.Length)
                        throw new ArgumentOutOfRangeException("value", "La longitud debe ser igual a 11");
                idAgente = value;
            }
        }
        #endregion

        /// <summary>
        /// instancia la clase carga.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="destino"></param>
        /// <param name="estado"></param>
        /// <param name="idCliente"></param>
        /// <param name="descripcion"></param>
        /// <param name="idAgente"></param>
        /// <exception cref="ArgumentNullException.ArgumentNullException">Si destino, estado o idCliente son null.</exception>
        /// <exception cref="System.ArgumentOutOfRangeException">Si las String de idCliente o idAgente son de longitud diferente a 11.</exception>
        public Carga(int id, String destino, String estado, String idCliente, String descripcion= null, String idAgente= null)
        {
            Id = id;

            try
            {
                Destino = destino;
            }catch(ArgumentNullException e)
            {
                throw new ArgumentNullException("destino", e.Message);
            }

            try
            {
                Estado = estado;
            }
            catch (ArgumentNullException e)
            {
                throw new ArgumentNullException("estado", e.Message);
            }

            try
            {
                IdCliente = idCliente;
            }
            catch (ArgumentNullException e)
            {
                throw new ArgumentNullException("idCliente", e.Message);
            }
            catch(ArgumentOutOfRangeException e)
            {
                throw new ArgumentNullException("idCliente", e.Message);
            }
            
            Descripcion = descripcion;

            try
            {
                IdAgente = idAgente;
            }
            catch (ArgumentOutOfRangeException e)
            {
                throw new ArgumentOutOfRangeException("idAgente", e.Message);
            }
        }

    }
}
