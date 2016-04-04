using SGCBLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SGCUI
{
    public partial class MainUI : MetroFramework.Forms.MetroForm
    {
        I_SGCBLL BLL = SGCBLL.SGCBLL.getUniqueInstance();

        EmpleadoUsuario cUser = null;

        public EmpleadoUsuario CurrentUser
        {
            get { return cUser; }
            set { cUser = value; }
        }

        Dialog_Form_Closing FDialog_Form_Closing = new Dialog_Form_Closing();

        public MainUI()
        {
            InitializeComponent();
        }

        private void MainUI_Load(object sender, EventArgs e)
        {
            Init FInit = new Init();
            Login FLogin = new Login();
            FInit.ShowDialog();
            FLogin.ShowDialog();

            while (FLogin.Exit == true && FLogin.Valid == false)
            {
                this.ShowInTaskbar = true;
                FDialog_Form_Closing = new Dialog_Form_Closing();
                FDialog_Form_Closing.ShowDialog();
                if (FDialog_Form_Closing.Valid_Close == true)
                {
                    break;
                }
                if (FDialog_Form_Closing.Valid_Close == false)
                {
                    this.ShowInTaskbar = false;
                    this.Hide();
                    FLogin = new Login();
                    FLogin.ShowDialog();
                }
            }
            if (FDialog_Form_Closing.Valid_Close == true)
            {
                Application.ExitThread();
            }
            if (FLogin.Valid == true)
            {
                this.Show();
                CurrentUser = FLogin.CurrentUser;
                btUserList.Text = "Cuenta activa: " + CurrentUser.Usuario;
            }
        }

        private void MainUI_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (FDialog_Form_Closing.Valid_Close == false)
            {
                FDialog_Form_Closing = new Dialog_Form_Closing();
                FDialog_Form_Closing.ShowDialog();
                if (FDialog_Form_Closing.Valid_Close == false)
                {
                    e.Cancel = true;
                }
            }
        }

        private void metroButtonLogOut_Click(object sender, EventArgs e)
        {
            Login FLogin = new Login();

            this.Hide();
            this.ShowInTaskbar = false;

            FLogin.ShowDialog();
            while (FLogin.Exit == true && FLogin.Valid == false)
            {
                this.ShowInTaskbar = true;
                FDialog_Form_Closing = new Dialog_Form_Closing();
                FDialog_Form_Closing.ShowDialog();
                if (FDialog_Form_Closing.Valid_Close == true)
                {
                    break;
                }
                if (FDialog_Form_Closing.Valid_Close == false)
                {
                    this.ShowInTaskbar = false;
                    this.Hide();
                    FLogin = new Login();
                    FLogin.ShowDialog();
                }
            }
            if (FDialog_Form_Closing.Valid_Close == true)
            {
                Application.ExitThread();
            }
            if (FLogin.Valid == true)
            {
                this.Show();
            }
        }

        private void metroTileClientes_Click(object sender, EventArgs e)
        {
            ListForm FListForm = new ListForm();
            FListForm.lsLoad = ListForm.listType.Clientes;
            FListForm.ShowDialog();
        }

        private void btUserList_Click(object sender, EventArgs e)
        {
            empleadosUsuarios FempleadosUsuarios = new empleadosUsuarios();
            FempleadosUsuarios.EditUser = true;
            FempleadosUsuarios.CurrentUser = CurrentUser;
            FempleadosUsuarios.ShowDialog();
        }

        private void metroTileAdminTools_Click(object sender, EventArgs e)
        {
            ListForm FListForm = new ListForm();
            FListForm.CurrentUser = CurrentUser;
            FListForm.lsLoad = ListForm.listType.Usuarios;
            FListForm.ShowDialog();
        }

        private void metroTileAbout_Click(object sender, EventArgs e)
        {
            About FAbout = new About();
            FAbout.ShowDialog();
        }

        private void metroTileCargas_Click(object sender, EventArgs e)
        {
            ListForm FListForm = new ListForm();
            FListForm.CurrentUser = CurrentUser;
            FListForm.lsLoad = ListForm.listType.Cargas;
            FListForm.ShowDialog();
        }

        private void metroTileTemp_Click(object sender, EventArgs e)
        {
            ListForm FListForm = new ListForm();
            FListForm.CurrentUser = CurrentUser;
            FListForm.lsLoad = ListForm.listType.Furgones;
            FListForm.ShowDialog();
        }

        private void metroTileAgentes_Click(object sender, EventArgs e)
        {
            ListForm FListForm = new ListForm();
            FListForm.lsLoad = ListForm.listType.Agentes;

            //var temp = new Agente("12345678910", "Somewhere", Convert.ToInt64(8090011234));
            //BLL.addAgente(temp);

            FListForm.ShowDialog();
        }
    }
}
