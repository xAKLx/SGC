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
    public partial class ClientesAgentes : MetroFramework.Forms.MetroForm
    {
        I_SGCBLL BLL = SGCBLL.SGCBLL.getUniqueInstance();

        Cliente cCliente = null;
        public Cliente CurrentClient
        {
            get { return cCliente; }
            set { cCliente = value; }
        }

        Agente cAgente = null;
        public Agente CurrentAgent
        {
            get { return cAgente; }
            set { cAgente = value; }
        }

        bool bEdit = false;
        public bool EditMode
        {
            get { return bEdit; }
            set { bEdit = value; }
        }

        listType bLoad;
        public listType lsLoad
        {
            get { return bLoad; }
            set { bLoad = value; }
        }

        public enum listType
        {
            Clientes = 2,
            Agentes,
        }

        public ClientesAgentes()
        {
            InitializeComponent();
        }

        private void ClientesAgentes_Load(object sender, EventArgs e)
        {
            labelError.Visible = false;
            if (EditMode == false)
            {
                if (lsLoad == listType.Clientes)
                {
                    this.Text = "Añadir cliente";
                }
                if (lsLoad == listType.Agentes)
                {
                    this.Text = "Añadir agente";
                }
            }
            else
            {
                if (lsLoad == listType.Clientes)
                {
                    this.Text = "Editar cliente";
                    textBoxName.Text = CurrentClient.NombreCliente;
                    textBoxTeléfono.Text = CurrentClient.Telefono.ToString();
                    tbDirection.Text = CurrentClient.Direccion;
                    textBoxCedula.Enabled = false;
                    textBoxCedula.Text = CurrentClient.IdCliente;
                }
                if (lsLoad == listType.Agentes)
                {
                    this.Text = "Editar agente";
                    textBoxTeléfono.Text = CurrentAgent.Telefono.ToString();
                    tbDirection.Text = CurrentAgent.Direccion;
                    textBoxCedula.Enabled = false;
                    textBoxCedula.Text = CurrentAgent.IdAgente;
                }
            }
        }

        private void metroButtonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void metroButtonOK_Click(object sender, EventArgs e)
        {
            if (EditMode == false)
            {
                if (textBoxCedula.Text != "" && tbDirection.Text != "" && textBoxName.Text != "" && textBoxTeléfono.Text != "")
                {
                    if (lsLoad == listType.Clientes)
                    {
                        var temp = new Cliente(textBoxCedula.Text, tbDirection.Text, textBoxName.Text, Convert.ToInt64(textBoxTeléfono.Text));
                        BLL.addCliente(temp);
                        this.Close();
                    }
                    else if (lsLoad == listType.Agentes)
                    {
                        var temp = new Agente(textBoxCedula.Text, tbDirection.Text, Convert.ToInt64(textBoxTeléfono.Text));
                        BLL.addAgente(temp);
                        this.Close();
                    }
                }
                else
                {
                    Error_EmptyFields();
                }
            }
            else
            {

                if (lsLoad == listType.Clientes)
                {
                    if (textBoxCedula.Text != "" && tbDirection.Text != "" && textBoxName.Text != "" && textBoxTeléfono.Text != "")
                    {
                        var temp = new Cliente(CurrentClient.IdCliente, tbDirection.Text, textBoxName.Text, Convert.ToInt64(textBoxTeléfono.Text));
                        BLL.updateCliente(temp);
                        this.Close();
                    }
                    else
                    {
                        Error_EmptyFields();
                    }
                }
                else if (lsLoad == listType.Agentes)
                {
                    if (textBoxCedula.Text != "" && tbDirection.Text != "" && textBoxTeléfono.Text != "")
                    {
                        var temp = new Agente(CurrentClient.IdCliente, tbDirection.Text, Convert.ToInt64(textBoxTeléfono.Text));
                        BLL.updateAgente(temp);
                        this.Close();
                    }
                    else
                    {
                        Error_EmptyFields();
                    }

                }
            }
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
        /// Mensaje de error si ya existe la cédula
        /// </summary>
        private void Error_ExistingCedula()
        {
            this.Style = MetroFramework.MetroColorStyle.Red;
            labelError.Text = "¡Esta cédula ya existe!";
            labelError.Visible = true;
        }

    }
}
