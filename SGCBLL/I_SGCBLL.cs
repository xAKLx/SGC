using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// Paquetes de clases encargadas de efectuar los procesos logicos.
namespace SGCBLL
{
    /// <summary>
    /// Interface de una clase logica de negocios.
    /// </summary>
    public interface I_SGCBLL
    {
        /// <summary>
        /// Metodo encargado de retornar todos los usuarios de los empleados de la base de datos.
        /// </summary>
        /// <returns>Lista de usuarios de los empleados.</returns>
        List<EmpleadoUsuario> empleadosUsuarios();

        /// <summary>
        /// Metodo encargado de obtener un usuario por su empleado.
        /// </summary>
        /// <param name="idEmpleado">Identificador del empleado correspondiente al usuario.</param>
        /// <returns>Usuario del empleado o null si no existe.</returns>
        EmpleadoUsuario getUserByEmpleado(String idEmpleado);

        /// <summary>
        /// Metodo encargado de obtener un usuario de un empleado por su usuario
        /// </summary>
        /// <param name="idUsuario">Identificador del usuario.</param>
        /// <returns>Usuario obtenido o null si no existe.</returns>
        EmpleadoUsuario getUserByUsuario(String idUsuario);

        /// <summary>
        /// Método de login para un usuario, si había un usuario logeado, se deslogea.
        /// </summary>
        /// <param name="usr"></param>
        /// <param name="pass"></param>
        /// <returns>True si login es valido</returns>
        bool login(string usr, string pass);

        /// <summary>
        /// Método para retornar el usuario actual.
        /// </summary>
        /// <returns>Null si no hay usuario, de lo contrario retorna el usuario actual</returns>
        EmpleadoUsuario CurrentUser();

        /// <summary>
        /// Método para agregar un usuario. 
        /// Debe recibir un EmpleadoUsuario  y agregarlo a la base de datos.
        /// </summary>
        /// <param name="usr"></param>
        /// <returns>Truie si se pudo agregar, de otra manera false.</returns>
        /// <exception cref="InvalidOperationException.InvalidOperationException">msg:"Ya existe un usuario con el mismo nombre."</exception>
        /// <exception cref="InvalidOperationException.InvalidOperationException">msg:"Ya existe un usuario asignado al empleado."</exception>
        bool AddUser(EmpleadoUsuario usr);
        
        /// <summary>
        /// Método para editar un usuario. 
        /// Debe recibir un usuario de tipo EmpleadoUsuario.
        /// </summary>
        /// <param name="usr"></param>
        /// <returns></returns>
        /// <exception cref="InvalidOperationException.InvalidOperationException">Si el usuario a editar no existe en la base de datos. (no se encontro un usuario cuyo empleado id se correspondiera con el de usr.</exception>
        bool EditUser(EmpleadoUsuario usr);

        /// <summary>
        /// Metodo encargado de obtener una lista de todos los clientes en la base de datos.
        /// </summary>
        /// <returns>Lista de todos los clientes.</returns>
        List<Cliente> getClientes();

        /// <summary>
        /// Obtiene un cliente en espeficido de la base de datos.
        /// </summary>
        /// <param name="idCliente"></param>
        /// <returns>Cliente correspondiente al idCliente otorgado. null si no se encuentra.</returns>
        /// <exception cref="ArgumentNullException.ArgumentNullException">Si idCliente es null.</exception>
        Cliente getCliente(String idCliente);

        /// <summary>
        /// Agrega un cliente a la base de datos.
        /// </summary>
        /// <param name="cliente"></param>
        /// <returns>True si se pudo agregar el cliente, de otra manera false.</returns>
        /// <exception cref="System.NullReferenceException">Si cliente es null.</exception>
        /// <exception cref="System.InvalidOperationException">Si el id del cliente ya existe en la base de datos.</exception>
        bool addCliente(Cliente cliente);

        /// <summary>
        /// Edita un cliente de la base de datos.
        /// </summary>
        /// <param name="cliente"></param>
        /// <returns>True si se pudo editar, de otra manera false.</returns>
        /// <exception cref="System.NullReferenceException">Si cliente es null.</exception>
        /// <exception cref="System.InvalidOperationException">Si el id del cliente no existe en la base de datos.</exception>
        bool updateCliente(Cliente cliente);

        /// <summary>
        /// Borra un cliente de la base de datos.
        /// </summary>
        /// <param name="idCliente"></param>
        /// <returns>True si se pudo borrar, de otra manera false.</returns>
        /// <exception cref="ArgumentNullException.ArgumentNullException">Si idCliente es null.</exception>
        /// <exception cref="System.InvalidOperationException">Si el id del cliente no existe en la base de datos.</exception>
        bool deleteCliente(String idCliente);

        /// <summary>
        /// Retorna todas las cargas.
        /// </summary>
        /// <returns>Lista de cargas.</returns>
        List<Carga> getCargas();

        /// <summary>
        /// Retorna una carga correspondiente a idCarga.
        /// </summary>
        /// <param name="idCarga"></param>
        /// <returns>Carga correspondiente a idCarga, null si no se encuentra.</returns>
        Carga getCarga(int idCarga);

        /// <summary>
        /// Agrega una carga a la base de datos.
        /// </summary>
        /// <param name="carga"></param>
        /// <returns>True si se pudo agregar, de otra manera false.</returns>
        /// <exception cref="System.NullReferenceException">Si Carga es null.</exception>
        /// <exception cref="System.InvalidOperationException">Si el id de la carga ya existe en la base de datos.</exception>
        bool addCarga(Carga carga);

        /// <summary>
        /// Actualiza una carga a la base de datos.
        /// </summary>
        /// <param name="carga"></param>
        /// <returns>True si se pudo actualizare, de otra manera false.</returns>
        /// <exception cref="System.NullReferenceException">Si Carga es null.</exception>
        /// <exception cref="System.InvalidOperationException">Si el id de la carga no existe en la base de datos.</exception>
        bool updateCarga(Carga carga);

        /// <summary>
        /// Metodo encargado de obtener todos los furgones.
        /// </summary>
        /// <returns>Lista de todos los furgones.</returns>
        List<Furgon> getFurgones();

        /// <summary>
        /// Metodo encargado de obtener un furgon especifico.
        /// </summary>
        /// <param name="id"></param>
        /// <returns>El furgon correspondiente al id, null si no se encuentra.</returns>
        Furgon getFurgon(int id);

        /// <summary>
        /// Agrega un furgon a la base de datos.
        /// </summary>
        /// <param name="furgon"></param>
        /// <returns>True si se pudo agregar, de otra manera false.</returns>
        /// <exception cref="System.NullReferenceException">Si Furgon es null.</exception>
        /// <exception cref="System.InvalidOperationException">Si el id del furgon ya existe en la base de datos.</exception>
        bool addFurgon(Furgon furgon);

        /// <summary>
        /// Actualiza un furgon a la base de datos.
        /// </summary>
        /// <param name="furgon"></param>
        /// <returns>True si se pudo actualizar, de otra manera false.</returns>
        /// <exception cref="System.NullReferenceException">Si Furgon es null.</exception>
        /// <exception cref="System.InvalidOperationException">Si el id del furgon no existe en la base de datos.</exception>
        bool updateFurgon(Furgon furgon);

        /// <summary>
        /// Metodo encargado de obtener todos los almacenes.
        /// </summary>
        /// <returns>Lista de todos los furgones.</returns>
        List<Almacen> getAlmacenes();

        /// <summary>
        /// Metodo encargado de obtener un almacen en especifico.
        /// </summary>
        /// <param name="id"></param>
        /// <returns>El almacen correspondiente al id, null si no se encuentra.</returns>
        Almacen getAlmacen(int id);

        /// <summary>
        /// Agrega un almacen a la base de datos.
        /// </summary>
        /// <param name="almacen"></param>
        /// <returns>True si se pudo agregar, de otra manera false.</returns>
        /// <exception cref="System.NullReferenceException">Si almacen es null.</exception>
        /// <exception cref="System.InvalidOperationException">Si el id del almacen ya existe en la base de datos.</exception>
        bool addAlmacen(Almacen almacen);

        /// <summary>
        /// Actualiza un almacen a la base de datos.
        /// </summary>
        /// <param name="almacen"></param>
        /// <returns>True si se pudo actualizar, de otra manera false.</returns>
        /// <exception cref="System.NullReferenceException">Si almacen es null.</exception>
        /// <exception cref="System.InvalidOperationException">Si el id del almacen no existe en la base de datos.</exception>
        bool updateAlmacen(Almacen almacen);

        /// <summary>
        /// Obtiene las cargas que han estado en un furgon.
        /// </summary>
        /// <param name="idFurgon"></param>
        /// <returns>Lista de FurgonCarga</returns>
        List<FurgonCarga> getCargasDeFurgon(int idFurgon);

        /// <summary>
        /// Obtiene los furgones en que ha estado una carga.
        /// </summary>
        /// <param name="idCarga"></param>
        /// <returns>Lista de FurgonCarga</returns>
        List<FurgonCarga> getFurgonesDeCarga(int idCarga);
        
        /// <summary>
        /// Agrega la relacion entre un furgon y una carga. (si la carga se encontraba en otro furgon, se le asigna la fecha de retiro de hoy)
        /// </summary>
        /// <param name="furgonCarga"></param>
        /// <returns>True si se pudo agregar, False de otra forma.</returns>
        /// <exception cref="System.NullReferenceException">Si furgonCarga es null.</exception>
        /// <exception cref="System.InvalidOperationException">Si la combinacion de idFurgon y idCarga ya existe en la base de datos.</exception>
        bool addFurgonCarga(FurgonCarga furgonCarga);

        /// <summary>
        /// Actualiza la relacion entre un furgon y una carga.
        /// </summary>
        /// <param name="furgonCarga"></param>
        /// <returns>True si se pudo agregar, False de otra forma.</returns>
        /// <exception cref="System.NullReferenceException">Si furgonCarga es null.</exception>
        /// <exception cref="System.InvalidOperationException">Si la combinacion de idFurgon y idCarga no existe en la base de datos.</exception>
        bool updateFurgonCarga(FurgonCarga furgonCarga);

        /// <summary>
        /// Obtiene las cargas que han estado en un almacen.
        /// </summary>
        /// <param name="idAlmacen"></param>
        /// <returns>Lista de AlmacenCarga</returns>
        List<AlmacenCarga> getCargasDeAlmacen(int idAlmacen);

        /// <summary>
        /// Obtiene los Almacenes en que ha estado una carga.
        /// </summary>
        /// <param name="idCarga"></param>
        /// <returns>Lista de AlmacenCarga</returns>
        List<AlmacenCarga> getAlmacenesDeCarga(int idCarga);

        /// <summary>
        /// Agrega la relacion entre un almacen y una carga. (si la carga se encontraba en otro almacen, se le asigna la fecha de retiro de hoy)
        /// </summary>
        /// <param name="almacenCarga"></param>
        /// <returns>True si se pudo agregar, False de otra forma.</returns>
        /// <exception cref="System.NullReferenceException">Si v es null.</exception>
        /// <exception cref="System.InvalidOperationException">Si la combinacion de idAlmacen y idCarga ya existe en la base de datos.</exception>
        bool addAlmacenCarga(AlmacenCarga almacenCarga);

        /// <summary>
        /// Actualiza la relacion entre un almacen y una carga.
        /// </summary>
        /// <param name="almacenCarga"></param>
        /// <returns>True si se pudo agregar, False de otra forma.</returns>
        /// <exception cref="System.NullReferenceException">Si almacenCarga es null.</exception>
        /// <exception cref="System.InvalidOperationException">Si la combinacion de idAlmacen y idCarga no existe en la base de datos.</exception>
        bool updateAlmacenCarga(AlmacenCarga almacenCarga);

        /// <summary>
        /// Obtiene todos los empleados de la base de datos.
        /// </summary>
        /// <returns>Lista de todos los empleados.</returns>
        List<Empleado> getEmpleados();

        /// <summary>
        /// Obtiene un empleado
        /// </summary>
        /// <param name="id"></param>
        /// <returns>Empleado obtenido o null si no se encontro.</returns>
        Empleado getEmpleado(String id);

        /// <summary>
        /// Agrega un empleado a la base de datos.
        /// </summary>
        /// <param name="empleado"></param>
        /// <returns>True si se pudo agregar, de otra manera false.</returns>
        /// <exception cref="System.InvalidOperationException">Si el id del empleado ya existe en la base de datos.</exception>
        bool addEmpleado(Empleado empleado);

        /// <summary>
        /// Actualiza un empleado a la base de datos.
        /// </summary>
        /// <param name="empleado"></param>
        /// <returns>True si se pudo actualizar, de otra manera false.</returns>
        /// <exception cref="System.InvalidOperationException">Si el id del empleado no existe en la base de datos.</exception>
        bool updateEmpleado(Empleado empleado);

        /// <summary>
        /// Obtiene todos los agentes de la base de datos.
        /// </summary>
        /// <returns>Lista representativa de todos los agentes de la base de datos.</returns>
        List<Agente> getAgentes();

        /// <summary>
        /// Obtiene un agente de la base de datos.
        /// </summary>
        /// <param name="idAgente"></param>
        /// <returns>Agente obtenido o null si no se encontro.</returns>
        Agente getAgente(String idAgente);

        /// <summary>
        /// Agrega un agente a la base de datos.
        /// </summary>
        /// <param name="agente"></param>
        /// <returns>True si se pudo agregar, de otra manera false.</returns>
        /// <exception cref="System.NullReferenceException">Si agente es null.</exception>
        /// <exception cref="System.InvalidOperationException">Si el id del agente ya existe en la base de datos.</exception>
        bool addAgente(Agente agente);

        /// <summary>
        /// Actualiza un agente a la base de datos.
        /// </summary>
        /// <param name="agente"></param>
        /// <returns>True si se pudo agregar, de otra manera false.</returns>
        /// <exception cref="System.NullReferenceException">Si agente es null.</exception>
        /// <exception cref="System.InvalidOperationException">Si el id del agente no existe en la base de datos.</exception>
        bool updateAgente(Agente agente);
    }
}
