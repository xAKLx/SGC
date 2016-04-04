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
    public partial class Login : MetroFramework.Forms.MetroForm
    {
        /// <summary>
        /// Atributos para comprobar si el close del form es válido.
        /// </summary>
        bool bExit = false, bValid = false;
        EmpleadoUsuario cUser = null;
        I_SGCBLL BLL = SGCBLL.SGCBLL.getUniqueInstance();

        public bool Exit
        {
            get { return bExit; }
            set { bExit = value; }
        }

        public bool Valid
        {
            get { return bValid; }
            set { bValid = value; }
        }

        public EmpleadoUsuario CurrentUser
        {
            get { return cUser; }
            set { cUser = value; }
        }

        public Login()
        {
            InitializeComponent();
        }

        private void metroButtonExit_Click(object sender, EventArgs e)
        {
            //Dialog_Box_OK FDialog_Box_OK = new Dialog_Box_OK();
            //FDialog_Box_OK.Style = MetroFramework.MetroColorStyle.Red; 
            //FDialog_Box_OK.lsText = "'I don't blame you'";
            //FDialog_Box_OK.ShowDialog();
            Exit = true;
            this.Close();
        }

        private void metroButtonLogin_Click(object sender, EventArgs e)
        {
            if (BLL.login(tbUsername.Text, tbPassword.Text))
            {
                Valid = true;
                CurrentUser = BLL.getUserByUsuario(tbUsername.Text);
                this.Close();
            }
            else
            {
                if (tbUsername.Text.Length <= 6 || tbPassword.Text.Length <= 6)
                {
                    this.Style = MetroFramework.MetroColorStyle.Red;
                    labelError.Visible = true;
                    labelError.Text = "¡El nombre de usuario y la contraseña deben tener más de 6 caractéres!";
                }
                else if (tbUsername.Text.Length > 6 && tbPassword.Text.Length > 6)
                {
                    this.Style = MetroFramework.MetroColorStyle.Red;
                    labelError.Visible = true;
                    labelError.Text = "El nombre o la contraseña son incorrectos";
                }
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {
            labelError.Visible = false;
            labelError.Text = "Iniciar Sesión";
        }

        private void tbUsername_TextChanged(object sender, EventArgs e)
        {
            this.Style = MetroFramework.MetroColorStyle.Default;
            labelError.Visible = false;
        }

        private void tbPassword_TextChanged(object sender, EventArgs e)
        {
            this.Style = MetroFramework.MetroColorStyle.Default;
            labelError.Visible = false;
        }
    }
}
