using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGCBLL
{
    /// <summary>
    /// Clase representativa de un furgon.
    /// </summary>
    public class Furgon
    {
        /// <summary>
        /// Capacidad del furgon, debe ser mayor a 0.
        /// </summary>
        private float capacidad;

        /// <summary>
        /// Identificador del Furgon.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Retorna y asigna capacidad.
        /// </summary>
        /// <exception cref="ArgumentOutOfRangeException.ArgumentOutOfRangeException">Si la capacidad es menor o igual a 0.</exception>
        public float Capacidad
        {
            get { return capacidad; }

            set
            {
                if (value <= 0)
                    throw new ArgumentOutOfRangeException("value", "La capacidad no puede ser menor o igual a 0.");
                capacidad = value;
            }
        }
        
        /// <summary>
        /// instancia la clase Furgon.
        /// </summary>
        /// <param name="id">Identificador del furgon.</param>
        /// <param name="capacidad">Capacidad de carga del furgon</param>
        /// <exception cref="ArgumentOutOfRangeException.ArgumentOutOfRangeException">Si capacidad es menor o igual a 0.</exception>
        public Furgon(int id, float capacidad)
        {
            Id = id;
            Capacidad = capacidad;
        }
    }
}
