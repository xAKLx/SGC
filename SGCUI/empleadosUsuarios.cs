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
    public partial class empleadosUsuarios : MetroFramework.Forms.MetroForm
    {
        I_SGCBLL BLL = SGCBLL.SGCBLL.getUniqueInstance();

        bool bEdit = false;
        public bool EditUser
        {
            get { return bEdit; }
            set { bEdit = value; }
        }

        EmpleadoUsuario cUser = null;
        public EmpleadoUsuario CurrentUser
        {
            get { return cUser; }
            set { cUser = value; }
        }

        public empleadosUsuarios()
        {
            InitializeComponent();
        }

        private void empleadosUsuarios_Load(object sender, EventArgs e)
        {
            labelError.Visible = false;
            if (EditUser == true && CurrentUser != null)
            {
                labelApellido.Visible = false;
                textBoxLastName.Visible = false;

                labelPass.Enabled = false;
                labelPassConf.Enabled = false;
                textBoxPass.Enabled = false;
                textBoxPassConf.Enabled = false;
                this.Text = "Editar Información del Usuario";
                textBoxLogin.Text = CurrentUser.Usuario;
                textBoxLogin.Enabled = false;
                textBoxCedula.Text = CurrentUser.IdEmpleado;
                textBoxCedula.Enabled = false;
                textBoxName.Text = BLL.getEmpleado(CurrentUser.IdEmpleado).NombreEmpleado;
                textBoxTeléfono.Text = BLL.getEmpleado(CurrentUser.IdEmpleado).Telefono.ToString();
                metroComboBoxType.Text = BLL.getEmpleado(CurrentUser.IdEmpleado).Seccion;
            }
            else
            {
                metroCheckBoxPass.Visible = false;
                this.Text = "Añadir Usuario";
            }
        }

        private void metroButtonOK_Click(object sender, EventArgs e)
        {
            bool Error = false;

            if (EditUser == true && CurrentUser != null)
            {
                if (metroCheckBoxPass.Checked == false)
                {
                    if (textBoxLogin.Text != "" && textBoxName.Text != "" && textBoxCedula.Text != "" &&
                        metroComboBoxType.Text != "" && textBoxTeléfono.Text != "")
                    {
                        Empleado emp = new Empleado(textBoxCedula.Text, textBoxName.Text, metroComboBoxType.Text, Convert.ToInt64(textBoxTeléfono.Text));
                        BLL.updateEmpleado(emp);
                        this.Close();
                    }
                    else
                    {
                        Error_EmptyFields();
                        Error = true;
                    }
                }
                if (metroCheckBoxPass.Checked == true)
                {
                    if (textBoxLogin.Text != "" && textBoxName.Text != "" && textBoxCedula.Text != "" &&
                        textBoxPass.Text != "" && textBoxPassConf.Text != "" &&
                        metroComboBoxType.Text != "" && textBoxTeléfono.Text != "")
                    {
                        if (textBoxPass.Text != textBoxPassConf.Text)
                        {
                            Error_PassMatch();
                            Error = true;
                        }
                        else if (textBoxLogin.Text.Length <= 6 || textBoxPass.Text.Length <= 6)
                        {
                            Error_TooShort();
                            Error = true;
                        }
                        else if (textBoxPass.Text == textBoxPassConf.Text)
                        {
                            if (textBoxLogin.Text.Length > 6 && textBoxPass.Text.Length > 6)
                            {
                                EmpleadoUsuario usr = new EmpleadoUsuario(textBoxCedula.Text, textBoxLogin.Text, textBoxPass.Text);
                                Empleado emp = new Empleado(textBoxCedula.Text, textBoxName.Text, metroComboBoxType.Text, Convert.ToInt64(textBoxTeléfono.Text));
                                BLL.EditUser(usr);
                                BLL.updateEmpleado(emp);
                                this.Close();
                            }
                        }
                    }
                    else
                    {
                        Error_EmptyFields();
                        Error = true;
                    }
                }
            }
            else
            {
                if (textBoxLogin.Text != "" && textBoxName.Text != "" && textBoxLastName.Text != "" &&
                    textBoxCedula.Text != "" && textBoxPass.Text != "" && textBoxPassConf.Text != "" &&
                    metroComboBoxType.Text != "" && textBoxTeléfono.Text != "")
                {
                    if (BLL.getUserByUsuario(textBoxLogin.Text) != null)
                    {
                        if (BLL.getUserByUsuario(textBoxLogin.Text).Usuario == textBoxLogin.Text)
                        {
                            Error_ExistingLogin();
                            Error = true;
                        }
                    }
                    if (BLL.getUserByEmpleado(textBoxCedula.Text) != null)
                    {
                        if (BLL.getUserByEmpleado(textBoxCedula.Text).IdEmpleado == textBoxCedula.Text)
                        {
                            Error_ExistingCedula();
                            Error = true;
                        }
                    }
                    else if (textBoxPass.Text != textBoxPassConf.Text)
                    {
                        Error_PassMatch();
                        Error = true;
                    }
                    else if (textBoxCedula.Text.Contains(" ") == true)
                    {
                        Error_Cedula();
                        Error = true;
                    }
                    else if (textBoxLogin.Text.Length <= 6 || textBoxPass.Text.Length <= 6)
                    {
                        Error_TooShort();
                        Error = true;
                    }
                }
                else
                {
                    Error_EmptyFields();
                    Error = true;
                }

                if (Error == false)
                {
                    EmpleadoUsuario usr = new EmpleadoUsuario(textBoxCedula.Text, textBoxLogin.Text, textBoxPass.Text);
                    Empleado emp = new Empleado(textBoxCedula.Text, textBoxName.Text + " " + textBoxLastName.Text, metroComboBoxType.Text, Convert.ToInt64(textBoxTeléfono.Text));
                    BLL.AddUser(usr);
                    BLL.addEmpleado(emp);
                    this.Close();
                }
            }
        }

        private void metroButtonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void metroCheckBoxPass_CheckedChanged(object sender, EventArgs e)
        {
            if (metroCheckBoxPass.Checked == true)
            {
                labelPass.Enabled = true;
                labelPassConf.Enabled = true;
                textBoxPass.Enabled = true;
                textBoxPassConf.Enabled = true;
            }
            if (metroCheckBoxPass.Checked == false)
            {
                labelPass.Enabled = false;
                labelPassConf.Enabled = false;
                textBoxPass.Enabled = false;
                textBoxPassConf.Enabled = false;
                textBoxPass.Text = "";
                textBoxPassConf.Text = "";
            }
        }

        /// <summary>
        /// Mensaje de error si ya existe el login
        /// </summary>
        private void Error_ExistingLogin()
        {
            this.Style = MetroFramework.MetroColorStyle.Red;
            labelError.Text = "¡Este nombre de usuario ya existe!";
            labelError.Visible = true;
        }

        /// <summary>
        /// Mensaje de error si ya existe el login
        /// </summary>
        private void Error_TooShort()
        {
            this.Style = MetroFramework.MetroColorStyle.Red;
            labelError.Text = "¡El nombre de usuario y la contraseña deben tener más de 6 caractéres!";
            labelError.Visible = true;
        }

        /// <summary>
        /// Mensaje de error si ya existe la cédula
        /// </summary>
        private void Error_ExistingCedula()
        {
            this.Style = MetroFramework.MetroColorStyle.Red;
            labelError.Text = "¡Esta cédula ya existe!";
            labelError.Visible = true;
        }

        /// <summary>
        /// Mensaje de error si los campos estan vacíos
        /// </summary>
        private void Error_EmptyFields()
        {
            this.Style = MetroFramework.MetroColorStyle.Red;
            labelError.Text = "¡Los campos no pueden estar vacíos!";
            labelError.Visible = true;
        }

        /// <summary>
        /// Mensaje de error si la cédula no es correcta
        /// </summary>
        private void Error_Cedula()
        {
            this.Style = MetroFramework.MetroColorStyle.Red;
            labelError.Text = "¡Los valores de la cédula son incorrectos!";
            labelError.Visible = true;
        }

        /// <summary>
        /// Mensaje de error si los passwords son diferentes
        /// </summary>
        private void Error_PassMatch()
        {
            this.Style = MetroFramework.MetroColorStyle.Red;
            labelError.Text = "¡Las contraseñas no coinciden!";
            labelError.Visible = true;
        }
    }
}