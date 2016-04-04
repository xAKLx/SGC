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
    public partial class Almacen : MetroFramework.Forms.MetroForm
    {
        I_SGCBLL BLL = SGCBLL.SGCBLL.getUniqueInstance();

        SGCBLL.Almacen bCurrent = null;
        public SGCBLL.Almacen Current
        {
            get { return bCurrent; }
            set { bCurrent = value; }
        }

        bool bEdit = false;
        public bool EditMode
        {
            get { return bEdit; }
            set { bEdit = value; }
        }

        public Almacen()
        {
            InitializeComponent();
        }

        private void metroButtonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void metroButtonOK_Click(object sender, EventArgs e)
        {
            if (textBoxDesc.Text != "")
            {
                if (EditMode == false)
                {
                    var temp = new SGCBLL.Almacen(((BLL.getAlmacenes().Count) + 1), textBoxDesc.Text);
                    BLL.addAlmacen(temp);
                    this.Close();
                }
                else
                {
                    var temp = new SGCBLL.Almacen(Current.Id, textBoxDesc.Text);
                    BLL.updateAlmacen(temp);
                    this.Close();
                }
            }
            else
            {
                this.Style = MetroFramework.MetroColorStyle.Red;
                labelError.Text = "¡Los campos no pueden estar vacíos!";
                labelError.Visible = true;
            }
        }

        private void Furgon_Load(object sender, EventArgs e)
        {
            labelError.Visible = false;
            if (EditMode == true)
            {
                textBoxDesc.Text = Current.Descripcion;
            }
        }
    }
}
