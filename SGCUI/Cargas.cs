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
    public partial class Cargas : MetroFramework.Forms.MetroForm
    {
        I_SGCBLL BLL = SGCBLL.SGCBLL.getUniqueInstance();

        bool bEdit = false;
        public bool EditMode
        {
            get { return bEdit; }
            set { bEdit = value; }
        }

        SGCBLL.Carga bCurrent = null;
        public SGCBLL.Carga Current
        {
            get { return bCurrent; }
            set { bCurrent = value; }
        }

        public Cargas()
        {
            InitializeComponent();
        }

        private void Cargas_Load(object sender, EventArgs e)
        {
            LoadClients();
            LoadAgentes();
            LoadEstado();
            if(EditMode == true)
            {
                this.Text = "Editar carga";
                metroComboBoxCliente.Text = Current.IdCliente.ToString();
                metroComboBoxAgente.Text = Current.IdCliente.ToString();
                metroComboBoxEstado.Text = Current.Estado.ToString();
                textBoxDescription.Text = Current.Descripcion;
                textBoxDestino.Text = Current.Destino;
            }
            else
            {
                this.Text = "Añadir carga";
            }
        }

        void LoadClients()
        {
            if (BLL.getClientes() != null)
            {
                foreach (var ls in BLL.getClientes())
                {
                    metroComboBoxCliente.Items.Add(ls.IdCliente);
                }
            }
        }

        void LoadAgentes()
        {
            if (BLL.getAgentes() != null)
            {
                foreach (var ls in BLL.getAgentes())
                {
                    metroComboBoxAgente.Items.Add(ls.IdAgente);
                }
            }
        }
        void LoadEstado()
        {
            metroComboBoxEstado.Items.Add("Recibido");
            metroComboBoxEstado.Items.Add("Cancelado");
            metroComboBoxEstado.Items.Add("En Tránsito");
            metroComboBoxEstado.Items.Add("Detenido");
        }

        private void metroButtonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void metroButtonOK_Click(object sender, EventArgs e)
        {
            if (metroComboBoxCliente.Text != "" && metroComboBoxAgente.Text != "" && metroComboBoxEstado.Text != "" && textBoxDescription.Text != "" && textBoxDestino.Text != "")
            {
                if (EditMode == false)
                {
                    var temp = new SGCBLL.Carga(((BLL.getFurgones().Count) + 1), textBoxDestino.Text, metroComboBoxEstado.Text, metroComboBoxCliente.Text, textBoxDescription.Text, metroComboBoxAgente.Text);
                    BLL.addCarga(temp);
                    this.Close();
                }
                else
                {
                    var temp = new SGCBLL.Carga(Current.Id, textBoxDestino.Text, metroComboBoxEstado.Text, metroComboBoxCliente.Text, textBoxDescription.Text, metroComboBoxAgente.Text);
                    BLL.updateCarga(temp);
                    this.Close();
                }
            }
            else
            {
                Error_EmptyFields();
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
    }
}
