using SGCBLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SGCUI
{
    public partial class Furgon : MetroFramework.Forms.MetroForm
    {
        I_SGCBLL BLL = SGCBLL.SGCBLL.getUniqueInstance();

        SGCBLL.Furgon bCurrent = null;
        public SGCBLL.Furgon Current
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

        public Furgon()
        {
            InitializeComponent();
        }

        private void metroButtonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void metroButtonOK_Click(object sender, EventArgs e)
        {
            if (textBoxCapacidad.Text != "")
            {
                if (EditMode == false)
                {
                    var temp = new SGCBLL.Furgon(((BLL.getFurgones().Count) + 1), float.Parse(textBoxCapacidad.Text, CultureInfo.InvariantCulture.NumberFormat));
                    BLL.addFurgon(temp);
                    this.Close();
                }
                else
                {
                    var temp = new SGCBLL.Furgon(Current.Id, float.Parse(textBoxCapacidad.Text, CultureInfo.InvariantCulture.NumberFormat));
                    BLL.updateFurgon(temp);
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
                textBoxCapacidad.Text = Current.Capacidad.ToString();
            }
        }
    }
}
