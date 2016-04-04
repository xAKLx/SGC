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
    public partial class FurgonCarga : MetroFramework.Forms.MetroForm
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

        public FurgonCarga()
        {
            InitializeComponent();
        }

        void LoadAlmacenes()
        {
            if (BLL.getAgentes() != null)
            {
                foreach (var ls in BLL.getFurgones())
                {
                    metroComboBoxFurgon.Items.Add(ls.Id);
                }
            }
        }

        void LoadCargas()
        {
            if (BLL.getCargas() != null)
            {
                foreach (var ls in BLL.getCargas())
                {
                    metroComboBoxCarga.Items.Add(ls.Id);
                }
            }
        }

        private void AlmacenCarga_Load(object sender, EventArgs e)
        {
            LoadAlmacenes();
            LoadCargas();
        }

        private void metroButtonOK_Click(object sender, EventArgs e)
        {
            var temp = new SGCBLL.AlmacenCarga(int.Parse(metroComboBoxFurgon.Text), int.Parse(metroComboBoxCarga.Text), dateTimePicker1.Value, dateTimePicker2.Value);
            BLL.addAlmacenCarga(temp);
            this.Close();
        }

        private void metroButtonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}