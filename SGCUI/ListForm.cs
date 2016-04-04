using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SGCBLL;

namespace SGCUI
{
    public partial class ListForm : MetroFramework.Forms.MetroForm
    {
        I_SGCBLL BLL = SGCBLL.SGCBLL.getUniqueInstance();
        EmpleadoUsuario cUser = null;
        int CurrentCell = 0;

        public EmpleadoUsuario CurrentUser
        {
            get { return cUser; }
            set { cUser = value; }
        }

        listType bLoad;
        public listType lsLoad
        {
            get { return bLoad; }
            set { bLoad = value; }
        }

        public enum listType
        {
            Usuarios = 0,
            Empleados,
            Clientes,
            Agentes,
            Cargas,
            Furgones,
            Almacenes,
        }

        void LoadForm()
        {
            if (lsLoad == listType.Usuarios)
            {
                this.Text = "Usuarios";
                if (BLL.empleadosUsuarios() != null)
                {
                    var list = new List<string>();
                    foreach (var ls in BLL.empleadosUsuarios())
                    {
                        list.Add(ls.Usuario);
                    }
                    Display_List(list);
                    Display_User_Info();
                }
            }
            if (lsLoad == listType.Empleados)
            {
                this.Text = "Empleados";
                if (BLL.getEmpleados() != null)
                {
                    var list = new List<string>();
                    foreach (var ls in BLL.getEmpleados())
                    {
                        list.Add(ls.IdEmpleado);
                    }
                    Display_List(list);
                    Display_User_Info();
                }
            }
            if (lsLoad == listType.Clientes)
            {
                this.Text = "Clientes";
                if (BLL.getClientes() != null)
                {
                    var list = new List<string>();
                    foreach (var ls in BLL.getClientes())
                    {
                        list.Add(ls.IdCliente);
                    }
                    Display_List(list);
                    Display_Client_Info();
                }
            }
            if (lsLoad == listType.Agentes)
            {
                this.Text = "Agentes";
                if (BLL.getAgentes() != null)
                {
                    var list = new List<string>();
                    foreach (var ls in BLL.getAgentes())
                    {
                        list.Add(ls.IdAgente);
                    }
                    Display_List(list);
                    Display_Agents_Info();
                }
            }
            if (lsLoad == listType.Cargas)
            {
                this.Text = "Cargas";
                if (BLL.getAgentes() != null)
                {
                    var list = new List<string>();
                    foreach (var ls in BLL.getCargas())
                    {
                        list.Add(ls.Id.ToString());
                    }
                    Display_List(list);
                    Display_Cargas_Info();
                }
            }
            if (lsLoad == listType.Furgones)
            {
                this.Text = "Furgones";
                if (BLL.getFurgones() != null)
                {
                    var list = new List<string>();
                    foreach (var ls in BLL.getFurgones())
                    {
                        list.Add(ls.Id.ToString());
                    }
                    Display_List(list);
                    Display_Furgones_Info();
                }
            }
            if (lsLoad == listType.Almacenes)
            {
                this.Text = "Almacenes";
                if (BLL.getAlmacenes() != null)
                {
                    var list = new List<string>();
                    foreach (var ls in BLL.getAlmacenes())
                    {
                        list.Add(ls.Id.ToString());
                    }
                    Display_List(list);
                    Display_Almacenes_Info();
                }
            }
        }

        private void Display_Almacenes_Info()
        {
            int liC = dgvInfo.RowCount = 0;

            if (null == dgvListForm.CurrentCell)
                return;

            var list = BLL.getAlmacen(Convert.ToInt32(dgvListForm.CurrentCell.Value));

            metroButtonEdit.Visible = true;
            dgvInfo.BackgroundColor = System.Drawing.Color.White;
            dgvInfo.RowTemplate.Height = 60;

            dgvInfo.RowCount += 1;
            dgvInfo.Rows[liC].Cells[0].Value = "ID: ";
            dgvInfo.Rows[liC].Cells[1].Value = list.Id.ToString();
            dgvInfo.RowCount += 1;
            liC++;
            dgvInfo.Rows[liC].Cells[0].Value = "Capacidad: ";
            dgvInfo.Rows[liC].Cells[1].Value = list.Descripcion;
        }

        private void Display_Furgones_Info()
        {
            int liC = dgvInfo.RowCount = 0;

            if (null == dgvListForm.CurrentCell)
                return;

            var list = BLL.getFurgon(Convert.ToInt32(dgvListForm.CurrentCell.Value));

            metroButtonEdit.Visible = true;
            dgvInfo.BackgroundColor = System.Drawing.Color.White;
            dgvInfo.RowTemplate.Height = 60;

            dgvInfo.RowCount += 1;
            dgvInfo.Rows[liC].Cells[0].Value = "ID: ";
            dgvInfo.Rows[liC].Cells[1].Value = list.Id.ToString();
            dgvInfo.RowCount += 1;
            liC++;
            dgvInfo.Rows[liC].Cells[0].Value = "Capacidad: ";
            dgvInfo.Rows[liC].Cells[1].Value = list.Capacidad;
        }

        private void Display_Cargas_Info()
        {
            int liC = dgvInfo.RowCount = 0;

            if (null == dgvListForm.CurrentCell)
                return;

            var list = BLL.getCarga(Convert.ToInt32(dgvListForm.CurrentCell.Value));

            metroButtonEdit.Visible = true;
            dgvInfo.BackgroundColor = System.Drawing.Color.White;
            dgvInfo.RowTemplate.Height = 60;

            dgvInfo.RowCount += 1;
            dgvInfo.Rows[liC].Cells[0].Value = "ID: ";
            dgvInfo.Rows[liC].Cells[1].Value = list.Id.ToString();
            dgvInfo.RowCount += 1;
            liC++;
            dgvInfo.Rows[liC].Cells[0].Value = "Estado: ";
            dgvInfo.Rows[liC].Cells[1].Value = list.Estado;
            dgvInfo.RowCount += 1;
            liC++;
            dgvInfo.Rows[liC].Cells[0].Value = "ID Cliente: ";
            dgvInfo.Rows[liC].Cells[1].Value = list.IdCliente;
            dgvInfo.RowCount += 1;
            liC++;
            dgvInfo.Rows[liC].Cells[0].Value = "ID Agente: ";
            dgvInfo.Rows[liC].Cells[1].Value = list.IdAgente;
            dgvInfo.RowCount += 1;
            liC++;
            dgvInfo.Rows[liC].Cells[0].Value = "Descripción: ";
            dgvInfo.Rows[liC].Cells[1].Value = list.Descripcion;
            dgvInfo.RowCount += 1;
            liC++;
            dgvInfo.Rows[liC].Cells[0].Value = "Destino: ";
            dgvInfo.Rows[liC].Cells[1].Value = list.Destino;
        }

        private void Display_Agents_Info()
        {
            int liC = dgvInfo.RowCount = 0;

            if (null == dgvListForm.CurrentCell)
                return;

            var list = BLL.getAgente(dgvListForm.CurrentCell.Value.ToString());

            metroButtonEdit.Visible = true;
            dgvInfo.BackgroundColor = System.Drawing.Color.White;
            dgvInfo.RowTemplate.Height = 60;
            

            dgvInfo.RowCount += 1;
            dgvInfo.Rows[liC].Cells[0].Value = "ID: ";
            dgvInfo.Rows[liC].Cells[1].Value = list.IdAgente;
            dgvInfo.RowCount += 1;
            liC++;
            dgvInfo.Rows[liC].Cells[0].Value = "Teléfono: ";
            dgvInfo.Rows[liC].Cells[1].Value = list.Telefono;
            dgvInfo.RowCount += 1;
            liC++;
            dgvInfo.Rows[liC].Cells[0].Value = "Dirección: ";
            dgvInfo.Rows[liC].Cells[1].Value = list.Direccion;
        }
        
        /// <summary>
        /// Método para poblar la lista.
        /// </summary>
        protected void Display_List(List<String> lista)
        {
            int liC = 0;
            dgvInfo.RowCount = 0;

            dgvListForm.RowTemplate.Height = 60;
            dgvListForm.RowCount = 0;

            foreach (var ls in lista)
            {
                dgvListForm.RowCount += 1;
                dgvListForm.Rows[liC].Cells[0].Value = ls;
                liC++;
            }

            if (dgvListForm.RowCount >= 1)
            {
                dgvListForm.CurrentCell = dgvListForm.Rows[CurrentCell].Cells[0];
            }
        }

        public void Display_User_Info()
        {
            int liC = dgvInfo.RowCount = 0;

            if (null == dgvListForm.CurrentCell)
                return;

            var list = BLL.getEmpleado(BLL.getUserByUsuario(dgvListForm.CurrentCell.Value.ToString()).IdEmpleado);

            metroButtonEdit.Visible = true;
            dgvInfo.BackgroundColor = System.Drawing.Color.White;
            dgvInfo.RowTemplate.Height = 60;

            dgvInfo.RowCount += 1;
            dgvInfo.Rows[liC].Cells[0].Value = "Nombre: ";
            dgvInfo.Rows[liC].Cells[1].Value = list.NombreEmpleado;
            dgvInfo.RowCount += 1;
            liC++;
            dgvInfo.Rows[liC].Cells[0].Value = "ID: ";
            dgvInfo.Rows[liC].Cells[1].Value = Convert.ToInt64(BLL.getUserByUsuario(dgvListForm.CurrentCell.Value.ToString()).IdEmpleado).ToString("000-0000000-0");
            dgvInfo.RowCount += 1;
            liC++;
            dgvInfo.Rows[liC].Cells[0].Value = "Sección: ";
            dgvInfo.Rows[liC].Cells[1].Value = list.Seccion;
            dgvInfo.RowCount += 1;
            liC++;
            dgvInfo.Rows[liC].Cells[0].Value = "Teléfono: ";
            dgvInfo.Rows[liC].Cells[1].Value = Convert.ToInt64(list.Telefono).ToString("(000) 000-0000");
        }

        public void Display_Client_Info()
        {
            int liC = dgvInfo.RowCount = 0;

            if (null == dgvListForm.CurrentCell)
                return;

            var list = BLL.getCliente(dgvListForm.CurrentCell.Value.ToString());

            metroButtonEdit.Visible = true;
            dgvInfo.BackgroundColor = System.Drawing.Color.White;
            dgvInfo.RowTemplate.Height = 60;

            dgvInfo.RowCount += 1;
            dgvInfo.Rows[liC].Cells[0].Value = "ID: ";
            dgvInfo.Rows[liC].Cells[1].Value = list.IdCliente;
            dgvInfo.RowCount += 1;
            liC++;
            dgvInfo.Rows[liC].Cells[0].Value = "Nombre: ";
            dgvInfo.Rows[liC].Cells[1].Value = list.NombreCliente;
            dgvInfo.RowCount += 1;
            liC++;
            dgvInfo.Rows[liC].Cells[0].Value = "Teléfono: ";
            dgvInfo.Rows[liC].Cells[1].Value = list.Telefono;
            dgvInfo.RowCount += 1;
            liC++;
            dgvInfo.Rows[liC].Cells[0].Value = "Dirección: ";
            dgvInfo.Rows[liC].Cells[1].Value = list.Direccion;
        }

        public ListForm()
        {
            InitializeComponent();
        }

        private void dgvListForm_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (lsLoad == listType.Usuarios)
            {
                Display_User_Info();
            }
            if (lsLoad == listType.Empleados)
            {
                Display_User_Info();
            }
            if (lsLoad == listType.Clientes)
            {
                Display_Client_Info();
            }
            if (lsLoad == listType.Agentes)
            {
                Display_Agents_Info();
            }
            if (lsLoad == listType.Cargas)
            {
                Display_Cargas_Info();
            }
            if (lsLoad == listType.Furgones)
            {
                Display_Furgones_Info();
            }
            if (lsLoad == listType.Almacenes)
            {
                Display_Almacenes_Info();
            }
        }

        private void ListForm_Load(object sender, EventArgs e)
        {
            metroButtonDelete.Visible = false;
            LoadForm();
        }

        private void metroButtonOK_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void metroButtonAdd_Click(object sender, EventArgs e)
        {
            if (lsLoad == listType.Usuarios || lsLoad == listType.Empleados)
            {
                empleadosUsuarios FempleadosUsuarios = new empleadosUsuarios();
                FempleadosUsuarios.ShowDialog();
                LoadForm();
                this.Focus();
            }

            if (lsLoad == listType.Clientes)
            {
                ClientesAgentes FClientesAgentes = new ClientesAgentes();
                FClientesAgentes.lsLoad = ClientesAgentes.listType.Clientes;
                FClientesAgentes.ShowDialog();
                LoadForm();
                this.Focus();
            }

            if (lsLoad == listType.Agentes)
            {
                ClientesAgentes FClientesAgentes = new ClientesAgentes();
                FClientesAgentes.lsLoad = ClientesAgentes.listType.Agentes;
                FClientesAgentes.ShowDialog();
                LoadForm();
                this.Focus();
            }

            if (lsLoad == listType.Furgones)
            {
                Furgon FFurgon = new Furgon();
                FFurgon.ShowDialog();
                LoadForm();
                this.Focus();
            }

            if (lsLoad == listType.Cargas)
            {
                Cargas FCargas = new Cargas();
                FCargas.ShowDialog();
                LoadForm();
                this.Focus();
            }
        }

        private void metroButtonEdit_Click(object sender, EventArgs e)
        {
            if (lsLoad == listType.Usuarios || lsLoad == listType.Empleados)
            {
                empleadosUsuarios FempleadosUsuarios = new empleadosUsuarios();
                FempleadosUsuarios.EditUser = true;
                FempleadosUsuarios.CurrentUser = BLL.getUserByUsuario(dgvListForm.CurrentCell.Value.ToString());
                FempleadosUsuarios.ShowDialog();
                CurrentCell = dgvListForm.CurrentCell.RowIndex;
                LoadForm();
                this.Focus();
            }

            if (lsLoad == listType.Clientes)
            {
                ClientesAgentes FClientesAgentes = new ClientesAgentes();
                FClientesAgentes.lsLoad = ClientesAgentes.listType.Clientes;
                FClientesAgentes.EditMode = true;
                FClientesAgentes.CurrentClient = BLL.getCliente(dgvListForm.CurrentCell.Value.ToString());
                FClientesAgentes.ShowDialog();
                LoadForm();
                this.Focus();
            }

            if (lsLoad == listType.Agentes)
            {
                ClientesAgentes FClientesAgentes = new ClientesAgentes();
                FClientesAgentes.lsLoad = ClientesAgentes.listType.Agentes;
                FClientesAgentes.EditMode = true;
                FClientesAgentes.CurrentAgent = BLL.getAgente(dgvListForm.CurrentCell.Value.ToString());
                FClientesAgentes.ShowDialog();
                LoadForm();
                this.Focus();
            }
            
            if (lsLoad == listType.Furgones)
            {
                Furgon FFurgon = new Furgon();
                FFurgon.EditMode = true;
                FFurgon.Current = BLL.getFurgon(Convert.ToInt32(dgvListForm.CurrentCell.Value));
                FFurgon.ShowDialog();
                LoadForm();
                this.Focus();
            }

            if (lsLoad == listType.Cargas)
            {
                Cargas FCargas = new Cargas();
                FCargas.EditMode = true;
                FCargas.Current = BLL.getCarga(Convert.ToInt32(dgvListForm.CurrentCell.Value));
                FCargas.ShowDialog();
                LoadForm();
                this.Focus();
            }
        }
    }
}
