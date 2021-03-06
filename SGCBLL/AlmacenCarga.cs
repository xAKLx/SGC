﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGCBLL
{
    /// <summary>
    /// Clase representativa de un almacen
    /// </summary>
    public class AlmacenCarga
    {
        #region Declaraciones
        /// <summary>
        /// Fecha en la que la carga fue retirada del furgon.
        /// </summary>
        private DateTime? fechaFin;
        #endregion

        #region Property
        /// <summary>
        /// Retorna y Asinga la fecha de ingreso de la carga en el furgon.
        /// </summary>
        public DateTime FechaIngreso { get; set; }

        /// <summary>
        /// Retorna y asigna la fecha de retiro de la carga en el furgon. (debe ser asignada despues de la fecha de Ingreso)
        /// </summary>
        /// <exception cref="ArgumentOutOfRangeException.ArgumentOutOfRangeException">Si el valor a asignar es una fecha previa a la fecha de ingreso.</exception>
        public DateTime? FechaFin
        {
            get { return fechaFin; }
            set
            {
                if (null != value && 0 <= FechaIngreso.CompareTo(value.Value))
                    throw new ArgumentOutOfRangeException("value", "La fecha de retiro no puede ser antes de la fecha de ingreso.");
                fechaFin = value;
            }
        }

        /// <summary>
        /// Retorna y asigna el identificador del almacen.
        /// </summary>
        public int IdAlmacen { get; set; }

        /// <summary>
        /// Retorna y asigna el identificador de la carga.
        /// </summary>
        public int IdCarga { get; set; }
        #endregion

        #region Constructores
        /// <summary>
        /// Instancia la clase furgon carga.
        /// </summary>
        /// <param name="idAlmacen"></param>
        /// <param name="idCarga"></param>
        /// <param name="fechaIngreso"></param>
        /// <param name="fechaFin"></param>
        /// <exception cref="ArgumentOutOfRangeException.ArgumentOutOfRangeException">Si el valor a asignar a la fecha de retiro es una fecha previa a la fecha de ingreso.</exception>
        public AlmacenCarga(int idAlmacen, int idCarga, DateTime fechaIngreso, DateTime? fechaFin= null)
        {
            IdAlmacen = idAlmacen;

            IdCarga = idCarga;

            FechaIngreso = fechaIngreso;

            try
            {
                FechaFin = fechaFin;
            }catch(ArgumentOutOfRangeException e)
            {
                throw new ArgumentOutOfRangeException("fechaFin", e.Message);
            }
        }
        #endregion

    }
}
