using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

/// Paquete de clases encargadas de manipular la base de datos.
namespace SGCDAL
{
    /// <summary>
    /// Interfaz para el manejo de las transacciones con la base de datos.
    /// </summary>
    public interface I_SGCDAL
    {
        #region Data access methods
        ///// <summary>
        ///// Funcion para la creacion de la conexion con la base de datos.
        ///// </summary>
        ///// <param name="DBname">Nombre de la base de datos</param>
        ///// <returns>String de conexion con la base de datos dada.</returns>
        //string ConnectionString(string DBname);
        /// <summary>
        /// Funcion que ejecuta un query de seleccion utilizando la conexion con la base de datos
        /// </summary>
        /// <param name="_Query">Query a ejecutar</param>
        /// <param name="_Parameters">Parametros de comparacion para la condicional del query</param>
        /// <returns>Resultado de la consulta</returns>
        DataTable executeSelectQuery(string _Query, SqlParameter[] _Parameters);
        /// <summary>
        /// Funcion que ejecuta un query de insersion utilizando la conexion con la base de datos
        /// </summary>
        /// <param name="_Query">Query a ejecutar</param>
        /// <param name="_Parameters">Parametros de comparacion para la condicional del query</param>
        /// <returns>true si se realizo la transaccion; false en cualquier otro caso.</returns>
        bool executeInsertQuery(string _Query, SqlParameter[] _Parameters);
        /// <summary>
        /// Funcion que ejecuta un query de borrado utilizando la conexion con la base de datos
        /// </summary>
        /// <param name="_Query">Query a ejecutar</param>
        /// <param name="_Parameters">Parametros de comparacion para la condicional del query</param>
        /// <returns>true si se realizo la transaccion; false en cualquier otro caso.</returns>
        bool executeDeleteQuery(string _Query, SqlParameter[] _Parameters);
        /// <summary>
        /// Funcion que ejecuta un query de modificacion utilizando la conexion con la base de datos
        /// </summary>
        /// <param name="_Query">Query a ejecutar</param>
        /// <param name="_Parameters">Parametros de comparacion para la condicional del query</param>
        /// <returns>true si se realizo la transaccion; false en cualquier otro caso.</returns>
        bool executeUpdateQuery(string _Query, SqlParameter[] _Parameters);
        /// <summary>
        /// Funcion que ejecuta un stored procedure utilizando la conexion con la base de datos
        /// </summary>
        /// <param name="_Query">Stored procedure a ejecutar</param>
        /// <param name="_Parameters">Parametros del stored procedure</param>
        /// <returns>Resultado de ejecutar el stored procedure.</returns>
        DataTable executeStoredProcedure(string _Query, SqlParameter[] _Parameters);
        #endregion

        #region Select Methods
        /// <summary>
        /// Funcion de busqueda de clientes.
        /// </summary>
        /// <param name="idCliente">Identificador unico para buscar un cliente.</param>
        /// <returns>Retorna el cliente si se encontro o null en cualquier otro caso.</returns>
        DataTable getCliente(string idCliente);

        /// <summary>
        /// Funcion de busqueda de clientes
        /// </summary>
        /// <returns>Retorna un datatable Representativo de todos los clientes.</returns>
        DataTable getCliente();

        /// <summary>
        /// Funcion encargada de retornar todas las cargas.
        /// </summary>
        /// <returns>
        /// Datatable representativo de todas las cargas. Columnas:
        /// *idCarga
        /// *estado
        /// *idCliente
        /// *idAgente
        /// *descripcion
        /// *destino</returns>
        DataTable getCargas();

        /// <summary>
        /// Funcion de busqueda de empleados.
        /// </summary>
        /// <param name="idEmpleado">Identificador unico para buscar un empleado.</param>
        /// <returns>Retorna el empleado si se encontro o null en cualquier otro caso.</returns>
        DataTable getEmpleado(string idEmpleado);

        /// <summary>
        /// Funcion de busqueda de empleados.
        /// </summary>
        /// <returns>
        /// Retorna un datatable Representativo de todos los empleados.
        /// Columnas:
        /// *idEmpleado
        /// *nombreEmp
        /// *telefono
        /// *seccion
        /// </returns>
        DataTable getEmpleado();

        /// <summary>
        /// Funcion de busqueda de usuario.
        /// </summary>
        /// <param name="username">Identificador unico para buscar un usuario.</param>
        /// <returns>Retorna el usuario si se encontro o null en cualquier otro caso.</returns>
        DataTable getUsuarioEmpleado(string username);

        /// <summary>
        /// Funcion de busqueda de usuario.
        /// </summary>
        /// <returns>
        /// Retorna un datatable Representativo de todos los usuarios de los empleados.
        /// Columnas:
        /// *idEmpleado
        /// *usuario
        /// *clave
        /// </returns>
        DataTable getUsuarioEmpleado();

        /// <summary>
        /// Metodo encargado de obtener todos los furgones.
        /// </summary>
        /// <returns>DataTable representativo de todos los furgones. Columnas:
        /// *idFurgon
        /// *Capacidad</returns>
        DataTable getFurgones();

        /// <summary>
        /// Metodo encargado de obtener todos los almacenes.
        /// </summary>
        /// <returns>DataTable representativo de todos los almacenes. Columnas:
        /// *idAlmacen
        /// *descripcion</returns>
        DataTable getAlmacenes();

        /// <summary>
        /// Obtiene las cargas que han estado en un furgon.
        /// </summary>
        /// <param name="idFurgon"></param>
        /// <returns>DataTable representativo de la relacion FurgonCarga correspondiente a idFurgon.
        /// Columnas:
        /// *idFurgon
        /// *idCarga
        /// *fecha_ingreso
        /// *fecha_salida</returns>
        DataTable getCargasDeFurgon(int idFurgon);

        /// <summary>
        /// Obtiene los furgones en los que ha estado una carga.
        /// </summary>
        /// <param name="idCarga"></param>
        /// <returns>DataTable representativo de la relacion FurgonCarga correspondiente a idCarga.
        /// Columnas:
        /// *idFurgon
        /// *idCarga
        /// *fecha_ingreso
        /// *fecha_salida</returns>
        DataTable getFurgonesDeCarga(int idCarga);

        /// <summary>
        /// Obtiene las cargas que han estado en un almacen.
        /// </summary>
        /// <param name="idAlmacen"></param>
        /// <returns>DataTable representativo de la relacion AlmacenCarga correspondiente a idFurgon.
        /// Columnas:
        /// *idAlmacen
        /// *idCarga
        /// *fecha_ingreso
        /// *fecha_salida</returns>
        DataTable getCargasDeAlmacen(int idAlmacen);

        /// <summary>
        /// Obtiene los almacenes en los que ha estado una carga.
        /// </summary>
        /// <param name="idCarga"></param>
        /// <returns>DataTable representativo de la relacion AlmacenCarga correspondiente a idFurgon.
        /// Columnas:
        /// *idAlmacen
        /// *idCarga
        /// *fecha_ingreso
        /// *fecha_salida</returns>
        DataTable getAlmacenesDeCarga(int idCarga);

        /// <summary>
        /// Obtiene todos los agentes.
        /// </summary>
        /// <returns>DataTable representativo de todos los Agentes.
        /// Columnas:
        /// *idAgente
        /// *direccion
        /// *telefono</returns>
        DataTable getAgentes();
        #endregion

        #region Insert Methods
        /// <summary>
        /// Inserta un cliente en la base de datos.
        /// </summary>
        /// <param name="idCliente"></param>
        /// <param name="nombreCliente"></param>
        /// <param name="direccion"></param>
        /// <param name="telefono"></param>
        /// <returns>True si se pude insertar, de otra manera false.</returns>
        /// <exception cref="ArgumentNullException.ArgumentNullException"> Si idCliente o direccion son null (con param name de cual parametro fue el del problema.</exception>
        bool insertCliente(String idCliente, String nombreCliente, String direccion, long? telefono = null);

        /// <summary>
        /// Inserta una carga en la base de datos.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="destino"></param>
        /// <param name="estado"></param>
        /// <param name="idCliente"></param>
        /// <param name="descripcion"></param>
        /// <param name="idAgente"></param>
        /// <returns>True si se pudo agregar, de otra manera false.</returns>
        /// <exception cref="ArgumentNullException.ArgumentNullException"> Si idCliente, destino o estado son null (con param name de cual parametro fue el del problema.</exception>
        bool insertCarga(int id, String destino, String estado, String idCliente, String descripcion = null, String idAgente = null);

        /// <summary>
        /// Inserta un furgon en la base de datos.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="capacidad"></param>
        /// <returns>True si se pudo insertar, de otra manera false.</returns>
        /// <exception cref="ArgumentOutOfRangeException.ArgumentOutOfRangeException">Si capacidad es menor o igual a 0.</exception>
        bool insertFurgon(int id, float capacidad);

        /// <summary>
        /// Inserta un Almacen en la base de datos.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="descripcion"></param>
        /// <returns>True si se pudo insertar, de otra manera false.</returns>
        bool insertAlmacen(int id, String descripcion);

        /// <summary>
        /// Inserta una relacion entre un Furgon y una carga.
        /// </summary>
        /// <param name="idFurgon"></param>
        /// <param name="idCarga"></param>
        /// <param name="ingreso"></param>
        /// <param name="fin"></param>
        /// <returns>True si se pudo insertar, de otra manera false.</returns>
        bool insertFurgonCarga(int idFurgon, int idCarga, DateTime ingreso, DateTime? fin);

        /// <summary>
        /// Inserta una relacion entre un Almacen y una carga.
        /// </summary>
        /// <param name="idAlmacen"></param>
        /// <param name="idCarga"></param>
        /// <param name="ingreso"></param>
        /// <param name="fin"></param>
        /// <returns>True si se pudo insertar, de otra manera false.</returns>
        bool insertAlmacenCarga(int idAlmacen, int idCarga, DateTime ingreso, DateTime? fin);

        /// <summary>
        /// Inserta un empleado.
        /// </summary>
        /// <param name="idEmpleado"></param>
        /// <param name="nombreEmpleado"></param>
        /// <param name="seccion"></param>
        /// <param name="telefono"></param>
        /// <returns>True si se pudo insertar, de otra manera false.</returns>
        bool insertEmpleado(String idEmpleado, String nombreEmpleado, String seccion, long? telefono = null);

        /// <summary>
        /// Inserta el usuario de un empleado.
        /// </summary>
        /// <param name="idEmpleado"></param>
        /// <param name="usuario"></param>
        /// <param name="clave"></param>
        /// <returns>True si se pudo insertar, de otra manera false.</returns>
        /// <exception cref="ArgumentNullException.ArgumentNullException">Si idEmpleado, usuario o clave son null.</exception>
        bool insertEmpleadoUsuario(String idEmpleado, String usuario, String clave);

        /// <summary>
        /// Inserta un agente en la base de datos.
        /// </summary>
        /// <param name="idAgente"></param>
        /// <param name="direccion"></param>
        /// <param name="telefono"></param>
        /// <returns>True si se pudo insertar, de otra manera false.</returns>
        /// <exception cref="ArgumentNullException.ArgumentNullException">Si idAgente o direccion.</exception>
        bool insertAgente(String idAgente, String direccion, long? telefono);
        #endregion

        #region Update Methods
        /// <summary>
        /// Actualiza un cliente en la base de datos.
        /// </summary>
        /// <param name="idCliente"></param>
        /// <param name="nombreCliente"></param>
        /// <param name="direccion"></param>
        /// <param name="telefono"></param>
        /// <returns>True si se pudo actualizar, de otra manera false.</returns>
        /// <exception cref="ArgumentNullException.ArgumentNullException"> Si idCliente o direccion son null (con param name de cual parametro fue el del problema.</exception>
        bool updateCliente(String idCliente, String nombreCliente, String direccion, long? telefono = null);

        /// <summary>
        /// Actualiza una carga en la base de datos.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="destino"></param>
        /// <param name="estado"></param>
        /// <param name="idCliente"></param>
        /// <param name="descripcion"></param>
        /// <param name="idAgente"></param>
        /// <returns>True si se pudo actualizar, de otra manera false.</returns>
        /// <exception cref="ArgumentNullException.ArgumentNullException"> Si idCliente, destino o estado son null (con param name de cual parametro fue el del problema.</exception>
        bool updateCarga(int id, String destino, String estado, String idCliente, String descripcion = null, String idAgente = null);

        /// <summary>
        /// Actualiza el usuario de un empleado.
        /// </summary>
        /// <param name="idEmpleado"></param>
        /// <param name="usuario"></param>
        /// <param name="clave"></param>
        /// <returns>True si se pudo actualizar, de otra manera false.</returns>
        /// <exception cref="ArgumentNullException.ArgumentNullException">Si idEmpleado, usuario o clave son null.</exception>
        bool updateEmpleadoUsuario(String idEmpleado, String usuario, String clave);

        /// <summary>
        /// Actualiza un furgon en la base de datos.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="capacidad"></param>
        /// <returns>True si se pudo actualiza, de otra manera false.</returns>
        /// <exception cref="ArgumentOutOfRangeException.ArgumentOutOfRangeException">Si capacidad es menor o igual a 0.</exception>
        bool updateFurgon(int id, float capacidad);

        /// <summary>
        /// Actualiza un Almacen en la base de datos.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="descripcion"></param>
        /// <returns>True si se pudo actualiza, de otra manera false.</returns>
        bool updateAlmacen(int id, String descripcion);

        /// <summary>
        /// Actualiza una relacion entre un Furgon y una carga.
        /// </summary>
        /// <param name="idFurgon"></param>
        /// <param name="idCarga"></param>
        /// <param name="ingreso"></param>
        /// <param name="fin"></param>
        /// <returns>True si se pudo actualizar, de otra manera false.</returns>
        bool updateFurgonCarga(int idFurgon, int idCarga, DateTime ingreso, DateTime? fin);

        /// <summary>
        /// Actualiza una relacion entre un Almacen y una carga.
        /// </summary>
        /// <param name="idAlmacen"></param>
        /// <param name="idCarga"></param>
        /// <param name="ingreso"></param>
        /// <param name="fin"></param>
        /// <returns>True si se pudo actualizar, de otra manera false.</returns>
        bool updateAlmacenCarga(int idAlmacen, int idCarga, DateTime ingreso, DateTime? fin);

        /// <summary>
        /// Actualiza un empleado.
        /// </summary>
        /// <param name="idEmpleado"></param>
        /// <param name="nombreEmpleado"></param>
        /// <param name="seccion"></param>
        /// <param name="telefono"></param>
        /// <returns>True si se pudo actualizar, de otra manera false.</returns>
        bool updateEmpleado(String idEmpleado, String nombreEmpleado, String seccion, long? telefono = null);

        /// <summary>
        /// Actualiza un agente en la base de datos.
        /// </summary>
        /// <param name="idAgente"></param>
        /// <param name="direccion"></param>
        /// <param name="telefono"></param>
        /// <returns>True si se pudo actualizar, de otra manera false.</returns>
        /// <exception cref="ArgumentNullException.ArgumentNullException">Si idAgente o direccion.</exception>
        bool updateAgente(String idAgente, String direccion, long? telefono);
        #endregion

        #region Delete Methods
        /// <summary>
        /// Borra un cliente de la base de datos.
        /// </summary>
        /// <param name="idCliente"></param>
        /// <returns>true si se pudo borrar, de otra manera false.</returns>
        bool deleteCliente(String idCliente);

        /// <summary>
        /// Borra una carga de la base de datos.
        /// </summary>
        /// <param name="idCarga"></param>
        /// <returns>True si se pudo borrar, de otra manera false.</returns>
        bool deleteCarga(int idCarga);

        /// <summary>
        /// Borra un furgon de la base de datos.
        /// </summary>
        /// <param name="idFurgon"></param>
        /// <returns>True si se pudo borrar, de otra manera false.</returns>
        bool deleteFurgon(int idFurgon);
        #endregion
    }
}
