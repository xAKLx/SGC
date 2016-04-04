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
    /// Metroform para un cuadro de diálogo que contiene un mensaje y botones Yes y No.
    /// Fue creado manualmente, ya que los Messagebox no seguirían el formato de los metroforms.
    /// </summary>
    public partial class Dialog_Form_Closing : MetroFramework.Forms.MetroForm
    {
        /// <summary>
        /// Atributo que valida el resultado del form.
        /// </summary>
        bool bValid = false;

        public bool Valid_Close
        {
            get { return bValid; }
            set { bValid = value; }
        }

        public Dialog_Form_Closing()
        {
            InitializeComponent();
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            bValid = true;
            Close();
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}