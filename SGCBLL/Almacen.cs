using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGCBLL
{
    /// <summary>
    /// Clase representativa del un almacen
    /// </summary>
    public class Almacen
    {
        /// <summary>
        /// breve descripcion del almacen.
        /// </summary>
        public String Descripcion { get; set;}

        /// <summary>
        /// Identificador del almacen.
        /// </summary>
        public int Id { get; set; }
        
        /// <summary>
        /// instancia la clase almacen.
        /// </summary>
        /// <param name="id">Identificador del almacen.</param>
        /// <param name="descripcion"> breve descripcion del almacen.</param>
        public Almacen(int id, String descripcion)
        {
            Id = id;
            Descripcion = descripcion;
        }
    }
}
