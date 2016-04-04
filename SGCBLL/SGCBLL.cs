using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using SGCDAL;

namespace SGCBLL
{
    /// <summary>
    /// Clase representativa de una capa logica de negocios.
    /// </summary>
    public class SGCBLL: I_SGCBLL
    {
        /// <summary>
        /// Usuario activo
        /// </summary>
        private EmpleadoUsuario currentUser= null;

        /// <summary>
        /// Base de datos.
        /// </summary>
        private I_SGCDAL db = SGCDAL.SGCDAL.GetUnique("proyecto");

        /// <summary>
        /// Instancia unica de la clase.
        /// </summary>
        private static SGCBLL uniqueInstance= null;

        #region Constructores

        /// <summary>
        /// Instancia la clase SGCBLL.
        /// </summary>
        private SGCBLL()
        {

        }
        #endregion

        #region Metodos

        public List<EmpleadoUsuario> empleadosUsuarios()
        {
            var lista = new List<EmpleadoUsuario>();

            EmpleadoUsuario temp;

            foreach(DataRow row in db.getUsuarioEmpleado().Rows)
            {
                try
                {
                    temp = new EmpleadoUsuario(row["idEmpleado"].ToString(), row["usuario"].ToString(), row["clave"].ToString());
                    lista.Add(temp);
                }
                catch (Exception) { }
            }

            return lista;
        }

        public bool login(string usr, string pass)
        {
            currentUser = null;
            foreach (var node in empleadosUsuarios())
                if (0 == node.Usuario.CompareTo(usr))
                {
                    if (0 == node.Clave.CompareTo(pass))
                    {
                        currentUser = node;
                        return true;
                    }
                    else
                        break;
                }                

            return false;
        }

        public EmpleadoUsuario CurrentUser()
        {
            return currentUser;
        }

        /// <summary>
        /// Metodo encargado de crear o instanciar la instancia unica de la clase.
        /// </summary>
        /// <returns>Instancia unica de la clase.</returns>
        public static SGCBLL getUniqueInstance()
        {
            if (null == uniqueInstance)
                uniqueInstance = new SGCBLL();
            return uniqueInstance;
        }
        #endregion

        public bool EditUser(EmpleadoUsuario usr)
        {
            foreach (var node in empleadosUsuarios())
                if (0 == usr.IdEmpleado.CompareTo(node.IdEmpleado))
                    return db.updateEmpleadoUsuario(usr.IdEmpleado, usr.Usuario, usr.Clave);
            throw new InvalidOperationException("El usuario a editar no existe.");
        }

        public List<Cliente> getClientes()
        {
            var lista = new List<Cliente>();

            Cliente temp;
            long? telefono;

            foreach (DataRow row in db.getCliente().Rows)
            {
                try
                {
                    telefono = long.Parse(row["telefono"].ToString());
                }
                catch(Exception)
                {
                    telefono = null;
                }

                try
                {
                    
                    temp = new Cliente(row["idCliente"].ToString(), row["direccion"].ToString(), row["nombreCliente"].ToString(), telefono);
                    lista.Add(temp);
                }
                catch (Exception) { }
            }

            return lista;
        }

        public Cliente getCliente(string idCliente)
        {
            if (null == idCliente)
                throw new ArgumentNullException("idCliente");

            foreach (var node in getClientes())
                if (0 == node.IdCliente.CompareTo(idCliente))
                    return node;

            return null;
        }

        public bool addCliente(Cliente cliente)
        {
            if (null != getCliente(cliente.IdCliente))
                throw new InvalidOperationException();
            return db.insertCliente(cliente.IdCliente, cliente.NombreCliente, cliente.Direccion, cliente.Telefono);
        }

        public bool updateCliente(Cliente cliente)
        {
            if (null == getCliente(cliente.IdCliente))
                throw new InvalidOperationException();
            return db.updateCliente(cliente.IdCliente, cliente.NombreCliente, cliente.Direccion, cliente.Telefono);
        }

        public bool deleteCliente(string idCliente)
        {
            if (null == getCliente(idCliente))
                throw new ArgumentNullException("idCliente");
            return db.deleteCliente(idCliente);
        }

        public EmpleadoUsuario getUserByEmpleado(string idEmpleado)
        {
            foreach (var node in empleadosUsuarios())
                if (0 == node.IdEmpleado.CompareTo(idEmpleado))
                    return node;
            return null;
        }

        public EmpleadoUsuario getUserByUsuario(string idUsuario)
        {
            foreach (var node in empleadosUsuarios())
                if (0 == node.Usuario.CompareTo(idUsuario))
                    return node;
            return null;
        }

        public bool AddUser(EmpleadoUsuario usr)
        {
            foreach (var node in empleadosUsuarios())
                if(0 == node.Usuario.CompareTo(usr.Usuario))
                    throw new InvalidOperationException("Ya existe un usuario con el mismo nombre.");
                else if(0 == node.IdEmpleado.CompareTo(usr.IdEmpleado))
                    throw new InvalidOperationException("Ya existe un usuario asignado al empleado.");

            return db.insertEmpleadoUsuario(usr.IdEmpleado, usr.Usuario, usr.Clave);
        }

        public List<Carga> getCargas()
        {
            var lista = new List<Carga>();

            String idAgente;
            String descripcion;

            foreach (DataRow row in db.getCargas().Rows)
            {
                if (row["idAgente"].GetType() == DBNull.Value.GetType())
                    idAgente = null;
                else
                    idAgente = row["idAgente"].ToString();

                if (row["descripcion"].GetType() == DBNull.Value.GetType())
                    descripcion = null;
                else
                    descripcion = row["descripcion"].ToString();

                try
                {
                    lista.Add(new Carga(int.Parse(row["idCarga"].ToString()), row["destino"].ToString(), row["estado"].ToString(), row["idCliente"].ToString(), descripcion, idAgente));
                }
                catch (Exception) { }
            }

            return lista;
        }

        public Carga getCarga(int idCarga)
        {
            foreach (var node in getCargas())
                if (node.Id == idCarga)
                    return node;

            return null;
        }

        public bool addCarga(Carga carga)
        {
            if (null != getCarga(carga.Id))
                throw new InvalidOperationException();
            return db.insertCarga(carga.Id, carga.Descripcion, carga.Estado, carga.IdCliente, carga.Descripcion, carga.IdAgente);
        }

        public bool updateCarga(Carga carga)
        {
            if (null == getCarga(carga.Id))
                throw new InvalidOperationException();
            return db.updateCarga(carga.Id, carga.Descripcion, carga.Estado, carga.IdCliente, carga.Descripcion, carga.IdAgente);
        }

        public List<Furgon> getFurgones()
        {
            var lista = new List<Furgon>();

            foreach (DataRow row in db.getFurgones().Rows)
            {
                try
                {
                    lista.Add(new Furgon(int.Parse(row["idFurgon"].ToString()), float.Parse(row["Capacidad"].ToString())));
                }
                catch (Exception) { }
            }

            return lista;
        }

        public Furgon getFurgon(int id)
        {
            foreach (var node in getFurgones())
                if (node.Id == id)
                    return node;

            return null;
        }
        

        public bool addFurgon(Furgon furgon)
        {
            if (null != getFurgon(furgon.Id))
                throw new InvalidOperationException();
            return db.insertFurgon(furgon.Id, furgon.Capacidad);
        }

        public bool updateFurgon(Furgon furgon)
        {
            if (null == getFurgon(furgon.Id))
                throw new InvalidOperationException();
            return db.updateFurgon(furgon.Id, furgon.Capacidad);
        }

        public List<Almacen> getAlmacenes()
        {
            var lista = new List<Almacen>();

            String descripcion;
            foreach (DataRow row in db.getFurgones().Rows)
            {
                if (row["descripcion"].GetType() == DBNull.Value.GetType())
                    descripcion = null;
                else
                    descripcion = row["descripcion"].ToString();

                try
                {
                    lista.Add(new Almacen(int.Parse(row["idFurgon"].ToString()), descripcion));
                }
                catch (Exception) { }
            }

            return lista;
        }

        public Almacen getAlmacen(int id)
        {
            foreach (var node in getAlmacenes())
                if (node.Id == id)
                    return node;
            return null;
        }

        public bool addAlmacen(Almacen almacen)
        {
            if (null != getAlmacen(almacen.Id))
                throw new InvalidOperationException();
            return db.insertAlmacen(almacen.Id, almacen.Descripcion);
        }

        public bool updateAlmacen(Almacen almacen)
        {
            if (null == getAlmacen(almacen.Id))
                throw new InvalidOperationException();
            return db.updateAlmacen(almacen.Id, almacen.Descripcion);
        }

        public List<FurgonCarga> getCargasDeFurgon(int idFurgon)
        {
            return dataTableToFurgonCarga(db.getCargasDeFurgon(idFurgon));
        }

        public List<FurgonCarga> getFurgonesDeCarga(int idCarga)
        {
            return dataTableToFurgonCarga(db.getFurgonesDeCarga(idCarga));
        }

        public bool addFurgonCarga(FurgonCarga furgonCarga)
        {
            foreach(var node in getFurgonesDeCarga(furgonCarga.IdCarga))
                if (node.IdFurgon == furgonCarga.IdFurgon)
                    throw new InvalidOperationException();
            return db.insertFurgonCarga(furgonCarga.IdFurgon, furgonCarga.IdCarga, furgonCarga.FechaIngreso, furgonCarga.FechaFin);
        }

        public bool updateFurgonCarga(FurgonCarga furgonCarga)
        {
            FurgonCarga temp = null;

            foreach (var node in getFurgonesDeCarga(furgonCarga.IdCarga))
                if (node.IdFurgon == furgonCarga.IdFurgon)
                    temp = node;

            if (null == temp)
                throw new InvalidOperationException();

            return db.updateFurgonCarga(furgonCarga.IdFurgon, furgonCarga.IdCarga, furgonCarga.FechaIngreso, furgonCarga.FechaFin);
        }

        public List<AlmacenCarga> getCargasDeAlmacen(int idAlmacen)
        {
            return dataTableToAlmacenCarga(db.getCargasDeAlmacen(idAlmacen));
        }

        public List<AlmacenCarga> getAlmacenesDeCarga(int idCarga)
        {
            return dataTableToAlmacenCarga(db.getAlmacenesDeCarga(idCarga));
        }

        public bool addAlmacenCarga(AlmacenCarga almacenCarga)
        {
            foreach (var node in getAlmacenesDeCarga(almacenCarga.IdCarga))
                if (node.IdAlmacen == almacenCarga.IdAlmacen)
                    throw new InvalidOperationException();
            return db.insertAlmacenCarga(almacenCarga.IdAlmacen, almacenCarga.IdCarga, almacenCarga.FechaIngreso, almacenCarga.FechaFin);
        }

        public bool updateAlmacenCarga(AlmacenCarga almacenCarga)
        {
            AlmacenCarga temp = null;

            foreach (var node in getAlmacenesDeCarga(almacenCarga.IdCarga))
                if (node.IdAlmacen == almacenCarga.IdCarga)
                    temp = node;

            if (null == temp)
                throw new InvalidOperationException();

            return db.updateAlmacenCarga(almacenCarga.IdAlmacen, almacenCarga.IdCarga, almacenCarga.FechaIngreso, almacenCarga.FechaFin);
        }

        public List<Empleado> getEmpleados()
        {
            var lista = new List<Empleado>();

            long? telefono;

            foreach (DataRow row in db.getEmpleado().Rows)
            {
                try
                {
                    telefono = long.Parse(row["telefono"].ToString());
                }
                catch (Exception)
                {
                    telefono = null;
                }

                try
                {
                    lista.Add(new Empleado(row["idEmpleado"].ToString(), row["nombreEmp"].ToString(), row["seccion"].ToString(), telefono));
                }
                catch (Exception) { }
            }

            return lista;
        }

        public Empleado getEmpleado(string id)
        {
            foreach (var node in getEmpleados())
                if (0 == node.IdEmpleado.CompareTo(id))
                    return node;
            return null;
        }

        public bool addEmpleado(Empleado empleado)
        {
            if (null != getEmpleado(empleado.IdEmpleado))
                throw new InvalidOperationException();
            return db.insertEmpleado(empleado.IdEmpleado, empleado.NombreEmpleado, empleado.Seccion, empleado.Telefono);
        }

        public bool updateEmpleado(Empleado empleado)
        {
            if (null == getEmpleado(empleado.IdEmpleado))
                throw new InvalidOperationException();
            return db.updateEmpleado(empleado.IdEmpleado, empleado.NombreEmpleado, empleado.Seccion, empleado.Telefono);
        }

        public List<Agente> getAgentes()
        {
            var lista = new List<Agente>();

            long? telefono;

            foreach (DataRow row in db.getEmpleado().Rows)
            {
                try
                {
                    telefono = long.Parse(row["telefono"].ToString());
                }
                catch (Exception)
                {
                    telefono = null;
                }

                try
                {
                    lista.Add(new Agente(row["idAgente"].ToString(), row["direccion"].ToString(), telefono));
                }
                catch (Exception) { }
            }

            return lista;
        }

        public Agente getAgente(string idAgente)
        {
            foreach (var node in getAgentes())
                if (0 == node.IdAgente.CompareTo(idAgente))
                    return node;
            return null;
        }

        public bool addAgente(Agente agente)
        {
            if (null != getAgente(agente.IdAgente))
                throw new InvalidOperationException();
            return db.insertAgente(agente.IdAgente, agente.Direccion, agente.Telefono);
        }

        public bool updateAgente(Agente agente)
        {
            if (null == getAgente(agente.IdAgente))
                throw new InvalidOperationException();
            return db.updateAgente(agente.IdAgente, agente.Direccion, agente.Telefono);
        }

        private List<FurgonCarga> dataTableToFurgonCarga(DataTable furgonCarga)
        {
            var lista = new List<FurgonCarga>();

            DateTime? fin;
            foreach(DataRow row in furgonCarga.Rows)
            {
                if (row["fecha_salida"].GetType() == DBNull.Value.GetType())
                    fin = null;
                else
                    fin = (DateTime)row["fecha_salida"];

                try
                {
                    lista.Add(new FurgonCarga(int.Parse( row["idFurgon"].ToString() ), int.Parse( row["idCarga"].ToString() ), (DateTime)row["fecha_ingreso"], fin));
                }
                catch (Exception) { }
            }

            return lista;
        }

        private List<AlmacenCarga> dataTableToAlmacenCarga(DataTable almacenCarga)
        {
            var lista = new List<AlmacenCarga>();

            DateTime? fin;
            foreach (DataRow row in almacenCarga.Rows)
            {
                if (row["fecha_salida"].GetType() == DBNull.Value.GetType())
                    fin = null;
                else
                    fin = (DateTime)row["fecha_salida"];

                try
                {
                    lista.Add(new AlmacenCarga(int.Parse(row["idAlmacen"].ToString()), int.Parse(row["idCarga"].ToString()), (DateTime)row["fecha_ingreso"], fin));
                }
                catch (Exception) { }
            }

            return lista;
        }
    }
}
