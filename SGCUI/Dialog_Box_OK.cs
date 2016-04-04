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
    /// <summary>
    /// Metroform para un cuadro de diálogo que contiene un mensaje y un butón OK.
    /// Fue creado manualmente, ya que los Messagebox no seguirían el formato de los metroforms.
    /// </summary>
    public partial class Dialog_Box_OK : MetroFramework.Forms.MetroForm
    {
        public String lsText { get; set; }

        public Dialog_Box_OK()
        {
            InitializeComponent();
        }

        private void metroButtonOK_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Dialog_Box_OK_Load(object sender, EventArgs e)
        {
            labelText.Text = lsText;
        }
    }
}
