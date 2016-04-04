using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace SGCDAL
{
    /// <summary>
    /// Clase representativa de una capa de acceso de datos.
    /// </summary>
    public class SGCDAL : I_SGCDAL
    {
        #region Database connection
        private SqlDataAdapter myAdapter;
        /// <summary>
        /// Connection to the database
        /// </summary>
        private SqlConnection conn;

        /// <summary>
        /// Instancia unica de la clase.
        /// </summary>
        private static SGCDAL _unique = null;

        /// <summary>
        /// Constructor de SGCDAL
        /// </summary>
        /// <param name="dbname">Nombre de la base de datos a accesar.</param>
        private SGCDAL(string dbname)
        {
            myAdapter = new SqlDataAdapter();
            //conn = new SqlConnection("Server=(local);AttachDbFilename=|DataDirectory|proyecto.mdf;Database=" + dbname + ";Trusted_Connection=Yes;");
            conn = new SqlConnection("Server=(local);AttachDbFilename=C:\\temp\\proyecto.mdf;Database=" + dbname + ";Trusted_Connection=Yes;");
        }

        /// <summary>
        /// Provee una instancia unica de la clase que manipula la base de datos
        /// </summary>
        /// <param name="catalog">Nombre de la base de datos a utilizar.</param>
        /// <returns>Devuelve la instancia unica solicitada.</returns>
        public static SGCDAL GetUnique(string catalog)
        {
            if (_unique == null)
            {
                _unique = new SGCDAL(catalog);
            }
            return _unique;
        }

        //private string ConnectionString(string DBname)
        //{
        //    if(DBname == null){
        //        return null;
        //    }
        //    string connection = "Server=(local);AttachDbFilename=|DataDirectory|projects.mdf;Database="+ DBname + ";Trusted_Connection=Yes;";
        //    return connection;
        //}

        /// <method>
        /// Abre la conexion con la base de datos si esta se rompio o esta cerrada.
        /// </method>
        private SqlConnection openConnection()
        {
            if (conn.State == ConnectionState.Closed || conn.State == ConnectionState.Broken)
            {
                conn.Open();
            }
            return conn;
        }

        public DataTable executeSelectQuery(string _query, SqlParameter[] _Parameters)
        {
            SqlCommand myCommand = new SqlCommand();
            DataTable dataTable = new DataTable();
            dataTable = null;
            DataSet ds = new DataSet();
            try
            {
                myCommand.Connection = openConnection();
                myCommand.CommandText = _query;
                if (_Parameters != null)
                    myCommand.Parameters.AddRange(_Parameters);
                myCommand.ExecuteNonQuery();
                myAdapter.SelectCommand = myCommand;
                myAdapter.Fill(ds);
                dataTable = ds.Tables[0];
            }
            catch (SqlException e)
            {
                Console.Write("Error - Connection.executeSelectQuery - Query: " + _query + " \nException: " + e.StackTrace.ToString());
                return null;
            }
            finally
            {
                conn.Close();
                myCommand.Dispose();
            }
            return dataTable;
        }

        public bool executeInsertQuery(string _query, SqlParameter[] _Parameters)
        {
            SqlCommand myCommand = new SqlCommand();
            try
            {
                myCommand.Connection = openConnection();
                myCommand.CommandText = _query;
                if (_Parameters != null)
                    myCommand.Parameters.AddRange(_Parameters);
                myAdapter.InsertCommand = myCommand;
                myCommand.ExecuteNonQuery();
            }
            catch (SqlException e)
            {
                Console.Write("Error - Connection.executeInsertQuery - Query: " + _query + " \nException: \n" + e.StackTrace.ToString());
                return false;
            }
            finally
            {
                conn.Close();
                myCommand.Dispose();
            }
            return true;
        }

        public bool executeDeleteQuery(string _query, SqlParameter[] _Parameters)
        {
            SqlCommand myCommand = new SqlCommand();
            try
            {
                myCommand.Connection = openConnection();
                myCommand.CommandText = _query;
                if (_Parameters != null)
                    myCommand.Parameters.AddRange(_Parameters);
                myAdapter.DeleteCommand = myCommand;
                myCommand.ExecuteNonQuery();
            }
            catch (SqlException e)
            {
                Console.Write("Error - Connection.executeUpdateQuery - Query: " + _query + " \nException: " + e.StackTrace.ToString());
                return false;
            }
            finally
            {
                conn.Close();
                myCommand.Dispose();
            }
            return true;
        }

        public bool executeUpdateQuery(string _query, SqlParameter[] _Parameters)
        {
            SqlCommand myCommand = new SqlCommand();
            try
            {
                myCommand.Connection = openConnection();
                myCommand.CommandText = _query;
                if (_Parameters != null)
                    myCommand.Parameters.AddRange(_Parameters);
                myAdapter.UpdateCommand = myCommand;
                myCommand.ExecuteNonQuery();
            }
            catch (SqlException e)
            {
                Console.Write("Error - Connection.executeUpdateQuery - Query: " + _query + " \nException: " + e.StackTrace.ToString());
                return false;
            }
            finally
            {
                conn.Close();
                myCommand.Dispose();
            }
            return true;
        }

        public DataTable executeStoredProcedure(string _query, SqlParameter[] _Parameters)
        {
            SqlCommand myCommand = new SqlCommand();
            DataTable dataTable = new DataTable();
            dataTable = null;
            DataSet ds = new DataSet();
            try
            {
                myCommand.Connection = openConnection();
                myCommand.CommandText = _query;
                if (_Parameters != null)
                    myCommand.Parameters.AddRange(_Parameters);
                myCommand.CommandType = CommandType.StoredProcedure;
                myCommand.ExecuteNonQuery();
                myAdapter.SelectCommand = myCommand;
                myAdapter.Fill(ds);
                dataTable = ds.Tables[0];
            }
            catch (SqlException e)
            {
                Console.Write("Error - Connection.executeSelectQuery - Query: " + _query + " \nException: " + e.StackTrace.ToString());
                return null;
            }
            finally
            {
                conn.Close();
                myCommand.Dispose();
            }
            return dataTable;
        }
        #endregion

        #region Select Methods
        public DataTable getCliente(string idCliente)
        {
            string query = string.Format("select * from cliente C where C.idCliente like @idCliente");
            SqlParameter[] sqlParameters = new SqlParameter[1];
            sqlParameters[0] = new SqlParameter("@idCliente", SqlDbType.VarChar);
            sqlParameters[0].Value = idCliente;
            return executeSelectQuery(query, sqlParameters);
        }

        public DataTable getCliente()
        {
            string query = string.Format("select * from cliente");
            return executeSelectQuery(query, null);
        }

        public DataTable getEmpleado(string idEmpleado)
        {
            string query = string.Format("select * from empleado E where E.idEmpleado like @idEmpleado");
            SqlParameter[] sqlParameters = new SqlParameter[1];
            sqlParameters[0] = new SqlParameter("@idEmpleado", SqlDbType.VarChar);
            sqlParameters[0].Value = idEmpleado;
            return executeSelectQuery(query, sqlParameters);
        }

        public DataTable getEmpleado()
        {
            string query = string.Format("select * from empleado");
            return executeSelectQuery(query, null);
        }

        public DataTable getUsuarioEmpleado(string username)
        {
            string query = string.Format("select * from empleadoUsuario U where U.usuario like @usuario");
            SqlParameter[] sqlParameters = new SqlParameter[1];
            sqlParameters[0] = new SqlParameter("@usuario", SqlDbType.VarChar);
            sqlParameters[0].Value = username;
            return executeSelectQuery(query, sqlParameters);
        }

        public DataTable getUsuarioEmpleado()
        {
            string query = string.Format("select * from empleadoUsuario");
            return executeSelectQuery(query, null);
        }

        public DataTable getCargas()
        {
            string query = string.Format("select * from carga");
            return executeSelectQuery(query, null);
        }

        public DataTable getFurgones()
        {
            string query = string.Format("select * from furgon");
            return executeSelectQuery(query, null);
        }

        public DataTable getAlmacenes()
        {
            string query = string.Format("select * from almacen");
            return executeSelectQuery(query, null);
        }

        public DataTable getCargasDeFurgon(int idFurgon)
        {
            string query = string.Format("select * from furgon_carga WHERE idFurgon = @id");
            SqlParameter[] parameters = new SqlParameter[1];
            parameters[0] = new SqlParameter("@id", SqlDbType.Int);
            parameters[0].Value = idFurgon;
            return executeSelectQuery(query, parameters);
        }

        public DataTable getFurgonesDeCarga(int idCarga)
        {
            string query = string.Format("select * from furgon_carga WHERE idCarga = @id");
            SqlParameter[] parameters = new SqlParameter[1];
            parameters[0] = new SqlParameter("@id", SqlDbType.Int);
            parameters[0].Value = idCarga;
            return executeSelectQuery(query, parameters);
        }

        public DataTable getCargasDeAlmacen(int idAlmacen)
        {
            string query = string.Format("select * from almacen_carga WHERE idAlmacen = @id");
            SqlParameter[] parameters = new SqlParameter[1];
            parameters[0] = new SqlParameter("@id", SqlDbType.Int);
            parameters[0].Value = idAlmacen;
            return executeSelectQuery(query, parameters);
        }

        public DataTable getAlmacenesDeCarga(int idCarga)
        {
            string query = string.Format("select * from almacen_carga WHERE idCarga = @id");
            SqlParameter[] parameters = new SqlParameter[1];
            parameters[0] = new SqlParameter("@id", SqlDbType.Int);
            parameters[0].Value = idCarga;
            return executeSelectQuery(query, parameters);
        }

        public DataTable getAgentes()
        {
            string query = string.Format("select * from agente");
            return executeSelectQuery(query, null);
        }
        #endregion


        //public bool addCarga(SGCBLL.Carga newCarga)
        //{
        //    throw new NotImplementedException();
        //}

        #region Insert Methods
        public bool insertCliente(string idCliente, string nombreCliente, string direccion, long? telefono = null)
        {
            //Query de insercion.
            string query = string.Format("INSERT INTO cliente (idCliente, nombreCliente, direccion, telefono) " +
                                         "VALUES(@id, @name, @dir, @tel)");
            //Parametros de insercion.
            SqlParameter[] sqlParameters = new SqlParameter[4];
            sqlParameters[0] = new SqlParameter("@id", SqlDbType.VarChar);
            sqlParameters[0].Value = idCliente;
            sqlParameters[1] = new SqlParameter("@name", SqlDbType.VarChar);
            sqlParameters[1].Value = nombreCliente;
            sqlParameters[2] = new SqlParameter("@dir", SqlDbType.VarChar);
            sqlParameters[2].Value = direccion;
            //Esta es la forma en la que se tratan los numeric de sql.
            sqlParameters[3] = new SqlParameter("@tel", SqlDbType.Decimal);
            sqlParameters[3].Precision = 10;
            sqlParameters[3].Scale = 0;
            sqlParameters[3].Value = telefono;
            //Si alguno de los parametros es null se le asigna un tipo especial aceptado por sql.
            foreach (var param in sqlParameters)
            {
                if (null == param.Value)
                    param.Value = DBNull.Value;
            }
            return executeInsertQuery(query, sqlParameters);
        }

        public bool insertCarga(int id, string destino, string estado, string idCliente, string descripcion = null, string idAgente = null)
        {
            //Query de insercion.
            string query = string.Format("INSERT INTO carga (idCarga, estado, idCliente, idAgente, descripcion, destino) " +
                                         "VALUES(@id, @estado, @idCliente, @idAgente, @des, @destino)");
            //Parametros de insercion.
            SqlParameter[] sqlParameters = new SqlParameter[6];
            sqlParameters[0] = new SqlParameter("@id", SqlDbType.Int);
            sqlParameters[0].Value = id;
            sqlParameters[1] = new SqlParameter("@estado", SqlDbType.VarChar);
            sqlParameters[1].Value = estado;
            sqlParameters[2] = new SqlParameter("@idCliente", SqlDbType.VarChar);
            sqlParameters[2].Value = idCliente;
            sqlParameters[3] = new SqlParameter("@idAgente", SqlDbType.VarChar);
            sqlParameters[3].Value = idAgente;
            sqlParameters[4] = new SqlParameter("@des", SqlDbType.VarChar);
            sqlParameters[4].Value = descripcion;
            sqlParameters[5] = new SqlParameter("@destino", SqlDbType.VarChar);
            sqlParameters[5].Value = destino;
            //Si alguno de los parametros es null se le asigna un tipo especial aceptado por sql.
            foreach (var param in sqlParameters)
            {
                if (null == param.Value)
                    param.Value = DBNull.Value;
            }
            return executeInsertQuery(query, sqlParameters);
        }

        public bool insertFurgon(int id, float capacidad)
        {
            //Query de insercion.
            string query = string.Format("INSERT INTO furgon (idFurgon, Capacidad) " +
                                         "VALUES(@id, @cap)");
            //Parametros de insercion.
            SqlParameter[] sqlParameters = new SqlParameter[2];
            sqlParameters[0] = new SqlParameter("@id", SqlDbType.Int);
            sqlParameters[0].Value = id;
            sqlParameters[1] = new SqlParameter("@cap", SqlDbType.Float);
            sqlParameters[1].Value = capacidad;
            //Si alguno de los parametros es null se le asigna un tipo especial aceptado por sql.
            foreach (var param in sqlParameters)
            {
                if (null == param.Value)
                    param.Value = DBNull.Value;
            }
            return executeInsertQuery(query, sqlParameters);
        }

        public bool insertAlmacen(int id, string descripcion)
        {
            //Query de insercion.
            string query = string.Format("INSERT INTO almacen (idAlmacen, descripcion) " +
                                         "VALUES(@id, @des)");
            //Parametros de insercion.
            SqlParameter[] sqlParameters = new SqlParameter[2];
            sqlParameters[0] = new SqlParameter("@id", SqlDbType.Int);
            sqlParameters[0].Value = id;
            sqlParameters[1] = new SqlParameter("@des", SqlDbType.VarChar);
            sqlParameters[1].Value = descripcion;
            //Si alguno de los parametros es null se le asigna un tipo especial aceptado por sql.
            foreach (var param in sqlParameters)
            {
                if (null == param.Value)
                    param.Value = DBNull.Value;
            }
            return executeInsertQuery(query, sqlParameters);
        }

        public bool insertFurgonCarga(int idFurgon, int idCarga, DateTime ingreso, DateTime? fin)
        {
            //Query de insercion.
            string query = string.Format("INSERT INTO furgon_carga (idFurgon, idCarga, fecha_ingreso, fecha_salida) " +
                                         "VALUES(@id, @idCarga, @ingreso, @fin)");
            //Parametros de insercion.
            SqlParameter[] sqlParameters = new SqlParameter[4];
            sqlParameters[0] = new SqlParameter("@id", SqlDbType.Int);
            sqlParameters[0].Value = idFurgon;
            sqlParameters[1] = new SqlParameter("@idCarga", SqlDbType.Int);
            sqlParameters[1].Value = idCarga;
            sqlParameters[2] = new SqlParameter("@ingreso", SqlDbType.DateTime);
            sqlParameters[2].Value = ingreso;
            sqlParameters[3] = new SqlParameter("@fin", SqlDbType.DateTime);
            sqlParameters[3].Value = fin;
            //Si alguno de los parametros es null se le asigna un tipo especial aceptado por sql.
            foreach (var param in sqlParameters)
            {
                if (null == param.Value)
                    param.Value = DBNull.Value;
            }
            return executeInsertQuery(query, sqlParameters);
        }

        public bool insertAlmacenCarga(int idAlmacen, int idCarga, DateTime ingreso, DateTime? fin)
        {
            //Query de insercion.
            string query = string.Format("INSERT INTO almacen_carga (idAlmacen, idCarga, fecha_ingreso, fecha_salida) " +
                                         "VALUES(@id, @idCarga, @ingreso, @fin)");
            //Parametros de insercion.
            SqlParameter[] sqlParameters = new SqlParameter[4];
            sqlParameters[0] = new SqlParameter("@id", SqlDbType.Int);
            sqlParameters[0].Value = idAlmacen;
            sqlParameters[1] = new SqlParameter("@idCarga", SqlDbType.Int);
            sqlParameters[1].Value = idCarga;
            sqlParameters[2] = new SqlParameter("@ingreso", SqlDbType.DateTime);
            sqlParameters[2].Value = ingreso;
            sqlParameters[3] = new SqlParameter("@fin", SqlDbType.DateTime);
            sqlParameters[3].Value = fin;
            //Si alguno de los parametros es null se le asigna un tipo especial aceptado por sql.
            foreach (var param in sqlParameters)
            {
                if (null == param.Value)
                    param.Value = DBNull.Value;
            }
            return executeInsertQuery(query, sqlParameters);
        }

        public bool insertEmpleado(string idEmpleado, string nombreEmpleado, string seccion, long? telefono = null)
        {
            //Query de insercion.
            string query = string.Format("INSERT INTO empleado (idEmpleado, nombreEmp, telefono, seccion) " +
                                         "VALUES(@id, @name, @tel, @sec)");
            //Parametros de insercion.
            SqlParameter[] sqlParameters = new SqlParameter[4];
            sqlParameters[0] = new SqlParameter("@id", SqlDbType.VarChar);
            sqlParameters[0].Value = idEmpleado;
            sqlParameters[1] = new SqlParameter("@name", SqlDbType.VarChar);
            sqlParameters[1].Value = nombreEmpleado;
            sqlParameters[2] = new SqlParameter("@sec", SqlDbType.VarChar);
            sqlParameters[2].Value = seccion;
            //Esta es la forma en la que se tratan los numeric de sql.
            sqlParameters[3] = new SqlParameter("@tel", SqlDbType.Decimal);
            sqlParameters[3].Precision = 10;
            sqlParameters[3].Scale = 0;
            sqlParameters[3].Value = telefono;
            //Si alguno de los parametros es null se le asigna un tipo especial aceptado por sql.
            foreach (var param in sqlParameters)
            {
                if (null == param.Value)
                    param.Value = DBNull.Value;
            }
            return executeInsertQuery(query, sqlParameters);
        }

        public bool insertEmpleadoUsuario(string idEmpleado, string usuario, string clave)
        {
            //Query de insercion.
            string query = string.Format("INSERT INTO empleadoUsuario (idEmpleado, usuario, clave) " +
                                         "VALUES(@id, @name, @pass)");
            //Parametros de insercion.
            SqlParameter[] sqlParameters = new SqlParameter[3];
            sqlParameters[0] = new SqlParameter("@id", SqlDbType.VarChar);
            sqlParameters[0].Value = idEmpleado;
            sqlParameters[1] = new SqlParameter("@name", SqlDbType.VarChar);
            sqlParameters[1].Value = usuario;
            sqlParameters[2] = new SqlParameter("@pass", SqlDbType.VarChar);
            sqlParameters[2].Value = clave;
            //Si alguno de los parametros es null se le asigna un tipo especial aceptado por sql.
            foreach (var param in sqlParameters)
            {
                if (null == param.Value)
                    param.Value = DBNull.Value;
            }
            return executeInsertQuery(query, sqlParameters);
        }

        public bool insertAgente(string idAgente, string direccion, long? telefono)
        {
            //Query de insercion.
            string query = string.Format("INSERT INTO agente (idAgente, direccion, telefono) " +
                                         "VALUES(@id, @dir, @tel)");
            //Parametros de insercion.
            SqlParameter[] sqlParameters = new SqlParameter[3];
            sqlParameters[0] = new SqlParameter("@id", SqlDbType.VarChar);
            sqlParameters[0].Value = idAgente;
            sqlParameters[1] = new SqlParameter("@dir", SqlDbType.VarChar);
            sqlParameters[1].Value = direccion;
            //Esta es la forma en la que se tratan los numeric de sql.
            sqlParameters[2] = new SqlParameter("@tel", SqlDbType.Decimal);
            sqlParameters[2].Precision = 10;
            sqlParameters[2].Scale = 0;
            sqlParameters[2].Value = telefono;
            //Si alguno de los parametros es null se le asigna un tipo especial aceptado por sql.
            foreach (var param in sqlParameters)
            {
                if (null == param.Value)
                    param.Value = DBNull.Value;
            }
            return executeInsertQuery(query, sqlParameters);
        }
        #endregion

        #region Update Methods
        public bool updateCliente(string idCliente, string nombreCliente, string direccion, long? telefono = null)
        {
            string query = string.Format("UPDATE cliente SET idCliente = @id, nombreCliente = @name, direccion = @dir, telefono = @tel" +
                                         " WHERE idCliente = @id");
            //Parametros de insercion.
            SqlParameter[] sqlParameters = new SqlParameter[4];
            sqlParameters[0] = new SqlParameter("@id", SqlDbType.VarChar);
            sqlParameters[0].Value = idCliente;
            sqlParameters[1] = new SqlParameter("@name", SqlDbType.VarChar);
            sqlParameters[1].Value = nombreCliente;
            sqlParameters[2] = new SqlParameter("@dir", SqlDbType.VarChar);
            sqlParameters[2].Value = direccion;
            //Esta es la forma en la que se tratan los numeric de sql.
            sqlParameters[3] = new SqlParameter("@tel", SqlDbType.Decimal);
            sqlParameters[3].Precision = 10;
            sqlParameters[3].Scale = 0;
            sqlParameters[3].Value = telefono;
            //Si alguno de los parametros es null se le asigna un tipo especial aceptado por sql.
            foreach (var param in sqlParameters)
            {
                if (null == param.Value)
                    param.Value = DBNull.Value;
            }
            return executeUpdateQuery(query, sqlParameters);
        }

        public bool updateCarga(int id, string destino, string estado, string idCliente, string descripcion = null, string idAgente = null)
        {
            string query = string.Format("UPDATE carga SET idCarga = @id, estado = @estado, idCliente = @idCliente, idAgente = @idAgente, descripcion = @des, destino = @destino" +
                                         " WHERE idCarga = @id");
            //Parametros de insercion.
            SqlParameter[] sqlParameters = new SqlParameter[6];
            sqlParameters[0] = new SqlParameter("@id", SqlDbType.Int);
            sqlParameters[0].Value = id;
            sqlParameters[1] = new SqlParameter("@estado", SqlDbType.VarChar);
            sqlParameters[1].Value = estado;
            sqlParameters[2] = new SqlParameter("@idCliente", SqlDbType.VarChar);
            sqlParameters[2].Value = idCliente;
            sqlParameters[3] = new SqlParameter("@idAgente", SqlDbType.VarChar);
            sqlParameters[3].Value = idAgente;
            sqlParameters[4] = new SqlParameter("@des", SqlDbType.VarChar);
            sqlParameters[4].Value = descripcion;
            sqlParameters[5] = new SqlParameter("@destino", SqlDbType.VarChar);
            sqlParameters[5].Value = destino;
            //Si alguno de los parametros es null se le asigna un tipo especial aceptado por sql.
            foreach (var param in sqlParameters)
            {
                if (null == param.Value)
                    param.Value = DBNull.Value;
            }
            return executeInsertQuery(query, sqlParameters);
        }

        public bool updateEmpleadoUsuario(string idEmpleado, string usuario, string clave)
        {
            string query = string.Format("UPDATE empleadoUsuario SET idEmpleado = @id, usuario = @user, clave = @pass" +
                                         " WHERE idEmpleado = @id");
            //Parametros de insercion.
            SqlParameter[] sqlParameters = new SqlParameter[3];
            sqlParameters[0] = new SqlParameter("@id", SqlDbType.VarChar);
            sqlParameters[0].Value = idEmpleado;
            sqlParameters[1] = new SqlParameter("@user", SqlDbType.VarChar);
            sqlParameters[1].Value = usuario;
            sqlParameters[2] = new SqlParameter("@pass", SqlDbType.VarChar);
            sqlParameters[2].Value = clave;
            //Si alguno de los parametros es null se le asigna un tipo especial aceptado por sql.
            foreach (var param in sqlParameters)
            {
                if (null == param.Value)
                    param.Value = DBNull.Value;
            }
            return executeInsertQuery(query, sqlParameters);
        }

        public bool updateFurgon(int id, float capacidad)
        {
            string query = string.Format("UPDATE furgon SET idFurgon = @id, Capacidad = @cap" +
                                         " WHERE idFurgon = @id");
            //Parametros de insercion.
            SqlParameter[] sqlParameters = new SqlParameter[2];
            sqlParameters[0] = new SqlParameter("@id", SqlDbType.Int);
            sqlParameters[0].Value = id;
            sqlParameters[1] = new SqlParameter("@cap", SqlDbType.Float);
            sqlParameters[1].Value = capacidad;
            //Si alguno de los parametros es null se le asigna un tipo especial aceptado por sql.
            foreach (var param in sqlParameters)
            {
                if (null == param.Value)
                    param.Value = DBNull.Value;
            }
            return executeInsertQuery(query, sqlParameters);
        }

        public bool updateAlmacen(int id, string descripcion)
        {
            string query = string.Format("UPDATE almacen SET idAlmacen = @id, descripcion = @des" +
                                         " WHERE idAlmacen = @id");
            //Parametros de insercion.
            SqlParameter[] sqlParameters = new SqlParameter[2];
            sqlParameters[0] = new SqlParameter("@id", SqlDbType.Int);
            sqlParameters[0].Value = id;
            sqlParameters[1] = new SqlParameter("@des", SqlDbType.VarChar);
            sqlParameters[1].Value = descripcion;
            //Si alguno de los parametros es null se le asigna un tipo especial aceptado por sql.
            foreach (var param in sqlParameters)
            {
                if (null == param.Value)
                    param.Value = DBNull.Value;
            }
            return executeInsertQuery(query, sqlParameters);
        }

        public bool updateFurgonCarga(int idFurgon, int idCarga, DateTime ingreso, DateTime? fin)
        {
            string query = string.Format("UPDATE furgon_carga SET idFurgon = @id, idCarga = @idCarga, fecha_ingreso = @ingreso, fecha_salida = @fin" +
                                         " WHERE idFurgon = @id AND idCarga = @idCarga");
            
            SqlParameter[] sqlParameters = new SqlParameter[4];
            sqlParameters[0] = new SqlParameter("@id", SqlDbType.Int);
            sqlParameters[0].Value = idFurgon;
            sqlParameters[1] = new SqlParameter("@idCarga", SqlDbType.Int);
            sqlParameters[1].Value = idCarga;
            sqlParameters[2] = new SqlParameter("@ingreso", SqlDbType.DateTime);
            sqlParameters[2].Value = ingreso;
            sqlParameters[3] = new SqlParameter("@fin", SqlDbType.DateTime);
            sqlParameters[3].Value = fin;
            //Si alguno de los parametros es null se le asigna un tipo especial aceptado por sql.
            foreach (var param in sqlParameters)
            {
                if (null == param.Value)
                    param.Value = DBNull.Value;
            }
            return executeInsertQuery(query, sqlParameters);
        }

        public bool updateAlmacenCarga(int idAlmacen, int idCarga, DateTime ingreso, DateTime? fin)
        {
            string query = string.Format("UPDATE almacen_carga SET idAlmacen = @id, idCarga = @idCarga, fecha_ingreso = @ingreso, fecha_salida = @fin" +
                                         " WHERE idAlmacen = @id AND idCarga = @idCarga");
            //Parametros de insercion.
            SqlParameter[] sqlParameters = new SqlParameter[4];
            sqlParameters[0] = new SqlParameter("@id", SqlDbType.Int);
            sqlParameters[0].Value = idAlmacen;
            sqlParameters[1] = new SqlParameter("@idCarga", SqlDbType.Int);
            sqlParameters[1].Value = idCarga;
            sqlParameters[2] = new SqlParameter("@ingreso", SqlDbType.DateTime);
            sqlParameters[2].Value = ingreso;
            sqlParameters[3] = new SqlParameter("@fin", SqlDbType.DateTime);
            sqlParameters[3].Value = fin;
            //Si alguno de los parametros es null se le asigna un tipo especial aceptado por sql.
            foreach (var param in sqlParameters)
            {
                if (null == param.Value)
                    param.Value = DBNull.Value;
            }
            return executeInsertQuery(query, sqlParameters);
        }

        public bool updateEmpleado(string idEmpleado, string nombreEmpleado, string seccion, long? telefono = null)
        {
            string query = string.Format("UPDATE empleado SET idEmpleado = @id, nombreEmp = @name, telefono = @tel, seccion = @sec" +
                                         " WHERE idEmpleado = @id");
            //Parametros de insercion.
            SqlParameter[] sqlParameters = new SqlParameter[4];
            sqlParameters[0] = new SqlParameter("@id", SqlDbType.VarChar);
            sqlParameters[0].Value = idEmpleado;
            sqlParameters[1] = new SqlParameter("@name", SqlDbType.VarChar);
            sqlParameters[1].Value = nombreEmpleado;
            sqlParameters[2] = new SqlParameter("@sec", SqlDbType.VarChar);
            sqlParameters[2].Value = seccion;
            //Esta es la forma en la que se tratan los numeric de sql.
            sqlParameters[3] = new SqlParameter("@tel", SqlDbType.Decimal);
            sqlParameters[3].Precision = 10;
            sqlParameters[3].Scale = 0;
            sqlParameters[3].Value = telefono;
            //Si alguno de los parametros es null se le asigna un tipo especial aceptado por sql.
            foreach (var param in sqlParameters)
            {
                if (null == param.Value)
                    param.Value = DBNull.Value;
            }
            return executeInsertQuery(query, sqlParameters);
        }

        public bool updateAgente(string idAgente, string direccion, long? telefono)
        {
            string query = string.Format("UPDATE agente SET idEmpleado = @id, direccion = @dir, telefono = @tel" +
                                         " WHERE idAgente = @id");
            //Parametros de insercion.
            SqlParameter[] sqlParameters = new SqlParameter[3];
            sqlParameters[0] = new SqlParameter("@id", SqlDbType.VarChar);
            sqlParameters[0].Value = idAgente;
            sqlParameters[1] = new SqlParameter("@dir", SqlDbType.VarChar);
            sqlParameters[1].Value = direccion;
            //Esta es la forma en la que se tratan los numeric de sql.
            sqlParameters[2] = new SqlParameter("@tel", SqlDbType.Decimal);
            sqlParameters[2].Precision = 10;
            sqlParameters[2].Scale = 0;
            sqlParameters[2].Value = telefono;
            //Si alguno de los parametros es null se le asigna un tipo especial aceptado por sql.
            foreach (var param in sqlParameters)
            {
                if (null == param.Value)
                    param.Value = DBNull.Value;
            }
            return executeInsertQuery(query, sqlParameters);
        }
        #endregion

        #region Delete Methods
        public bool deleteCliente(string idCliente)
        {
            string query = string.Format("DELETE FROM cliente WHERE idCliente = @ID");
            SqlParameter[] sqlParameters = new SqlParameter[1];
            sqlParameters[0] = new SqlParameter("@ID", SqlDbType.VarChar);
            sqlParameters[0].Value = Convert.ToString(idCliente);
            return executeDeleteQuery(query, sqlParameters);
        }

        public bool deleteCarga(int idCarga)
        {
            string query = string.Format("DELETE FROM carga WHERE idCarga = @ID");
            SqlParameter[] sqlParameters = new SqlParameter[1];
            sqlParameters[0] = new SqlParameter("@ID", SqlDbType.VarChar);
            sqlParameters[0].Value = Convert.ToString(idCarga);
            return executeDeleteQuery(query, sqlParameters);
        }

        public bool deleteFurgon(int idFurgon)
        {
            string query = string.Format("DELETE FROM furgon WHERE idFurgon = @ID");
            SqlParameter[] sqlParameters = new SqlParameter[1];
            sqlParameters[0] = new SqlParameter("@ID", SqlDbType.VarChar);
            sqlParameters[0].Value = Convert.ToString(idFurgon);
            return executeDeleteQuery(query, sqlParameters);
        }
        #endregion
    }
}
