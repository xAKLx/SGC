namespace SGCUI
{
    partial class FurgonCarga
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelIDCarga = new System.Windows.Forms.Label();
            this.labelFechaIngreso = new System.Windows.Forms.Label();
            this.labelIDFurgon = new System.Windows.Forms.Label();
            this.metroComboBoxCarga = new MetroFramework.Controls.MetroComboBox();
            this.metroButtonOK = new MetroFramework.Controls.MetroButton();
            this.metroButtonCancel = new MetroFramework.Controls.MetroButton();
            this.labelError = new System.Windows.Forms.Label();
            this.metroComboBoxFurgon = new MetroFramework.Controls.MetroComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.labelFechaSalida = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelIDCarga
            // 
            this.labelIDCarga.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.labelIDCarga.AutoSize = true;
            this.labelIDCarga.Location = new System.Drawing.Point(71, 116);
            this.labelIDCarga.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelIDCarga.Name = "labelIDCarga";
            this.labelIDCarga.Size = new System.Drawing.Size(69, 21);
            this.labelIDCarga.TabIndex = 119;
            this.labelIDCarga.Text = "ID Carga";
            // 
            // labelFechaIngreso
            // 
            this.labelFechaIngreso.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.labelFechaIngreso.AutoSize = true;
            this.labelFechaIngreso.Location = new System.Drawing.Point(16, 154);
            this.labelFechaIngreso.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelFechaIngreso.Name = "labelFechaIngreso";
            this.labelFechaIngreso.Size = new System.Drawing.Size(124, 21);
            this.labelFechaIngreso.TabIndex = 174;
            this.labelFechaIngreso.Text = "Fecha de Ingreso";
            // 
            // labelIDFurgon
            // 
            this.labelIDFurgon.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.labelIDFurgon.AutoSize = true;
            this.labelIDFurgon.Location = new System.Drawing.Point(63, 81);
            this.labelIDFurgon.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelIDFurgon.Name = "labelIDFurgon";
            this.labelIDFurgon.Size = new System.Drawing.Size(77, 21);
            this.labelIDFurgon.TabIndex = 179;
            this.labelIDFurgon.Text = "ID Furgón";
            // 
            // metroComboBoxCarga
            // 
            this.metroComboBoxCarga.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.metroComboBoxCarga.FormattingEnabled = true;
            this.metroComboBoxCarga.ItemHeight = 23;
            this.metroComboBoxCarga.Location = new System.Drawing.Point(147, 113);
            this.metroComboBoxCarga.Name = "metroComboBoxCarga";
            this.metroComboBoxCarga.Size = new System.Drawing.Size(115, 29);
            this.metroComboBoxCarga.TabIndex = 180;
            // 
            // metroButtonOK
            // 
            this.metroButtonOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.metroButtonOK.Location = new System.Drawing.Point(235, 233);
            this.metroButtonOK.Name = "metroButtonOK";
            this.metroButtonOK.Size = new System.Drawing.Size(113, 32);
            this.metroButtonOK.TabIndex = 182;
            this.metroButtonOK.Text = "OK";
            this.metroButtonOK.Click += new System.EventHandler(this.metroButtonOK_Click);
            // 
            // metroButtonCancel
            // 
            this.metroButtonCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.metroButtonCancel.Location = new System.Drawing.Point(116, 233);
            this.metroButtonCancel.Name = "metroButtonCancel";
            this.metroButtonCancel.Size = new System.Drawing.Size(113, 32);
            this.metroButtonCancel.TabIndex = 181;
            this.metroButtonCancel.Text = "Cancel";
            this.metroButtonCancel.Click += new System.EventHandler(this.metroButtonCancel_Click);
            // 
            // labelError
            // 
            this.labelError.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelError.AutoEllipsis = true;
            this.labelError.Font = new System.Drawing.Font("Segoe UI Light", 14F);
            this.labelError.ForeColor = System.Drawing.Color.Red;
            this.labelError.Location = new System.Drawing.Point(23, 14);
            this.labelError.Name = "labelError";
            this.labelError.Size = new System.Drawing.Size(325, 52);
            this.labelError.TabIndex = 185;
            this.labelError.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // metroComboBoxFurgon
            // 
            this.metroComboBoxFurgon.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.metroComboBoxFurgon.FormattingEnabled = true;
            this.metroComboBoxFurgon.ItemHeight = 23;
            this.metroComboBoxFurgon.Location = new System.Drawing.Point(147, 78);
            this.metroComboBoxFurgon.Name = "metroComboBoxFurgon";
            this.metroComboBoxFurgon.Size = new System.Drawing.Size(115, 29);
            this.metroComboBoxFurgon.TabIndex = 186;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePicker1.Location = new System.Drawing.Point(147, 148);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(201, 29);
            this.dateTimePicker1.TabIndex = 187;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePicker2.Location = new System.Drawing.Point(147, 183);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(201, 29);
            this.dateTimePicker2.TabIndex = 188;
            // 
            // labelFechaSalida
            // 
            this.labelFechaSalida.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.labelFechaSalida.AutoSize = true;
            this.labelFechaSalida.Location = new System.Drawing.Point(27, 189);
            this.labelFechaSalida.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelFechaSalida.Name = "labelFechaSalida";
            this.labelFechaSalida.Size = new System.Drawing.Size(113, 21);
            this.labelFechaSalida.TabIndex = 189;
            this.labelFechaSalida.Text = "Fecha de Salida";
            // 
            // FurgonCarga
            // 
            this.AcceptButton = this.metroButtonOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = MetroFramework.Drawing.MetroBorderStyle.FixedSingle;
            this.ClientSize = new System.Drawing.Size(371, 286);
            this.Controls.Add(this.labelFechaSalida);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.metroComboBoxFurgon);
            this.Controls.Add(this.labelError);
            this.Controls.Add(this.metroButtonOK);
            this.Controls.Add(this.metroButtonCancel);
            this.Controls.Add(this.metroComboBoxCarga);
            this.Controls.Add(this.labelIDFurgon);
            this.Controls.Add(this.labelFechaIngreso);
            this.Controls.Add(this.labelIDCarga);
            this.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FurgonCarga";
            this.Resizable = false;
            this.ShadowType = MetroFramework.Forms.MetroForm.MetroFormShadowType.SystemShadow;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Add user info";
            this.TextAlign = System.Windows.Forms.VisualStyles.HorizontalAlign.Center;
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelIDCarga;
        private System.Windows.Forms.Label labelFechaIngreso;
        private System.Windows.Forms.Label labelIDFurgon;
        private MetroFramework.Controls.MetroComboBox metroComboBoxCarga;
        private MetroFramework.Controls.MetroButton metroButtonOK;
        private MetroFramework.Controls.MetroButton metroButtonCancel;
        private System.Windows.Forms.Label labelError;
        private MetroFramework.Controls.MetroComboBox metroComboBoxFurgon;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label labelFechaSalida;


    }
}