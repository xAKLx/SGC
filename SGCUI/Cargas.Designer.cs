namespace SGCUI
{
    partial class Cargas
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
            this.labelNombre = new System.Windows.Forms.Label();
            this.labelIDAgente = new System.Windows.Forms.Label();
            this.textBoxDescription = new System.Windows.Forms.TextBox();
            this.labelDescription = new System.Windows.Forms.Label();
            this.textBoxDestino = new System.Windows.Forms.TextBox();
            this.labelIDCliente = new System.Windows.Forms.Label();
            this.metroComboBoxAgente = new MetroFramework.Controls.MetroComboBox();
            this.metroButtonOK = new MetroFramework.Controls.MetroButton();
            this.metroButtonCancel = new MetroFramework.Controls.MetroButton();
            this.labelError = new System.Windows.Forms.Label();
            this.metroComboBoxCliente = new MetroFramework.Controls.MetroComboBox();
            this.metroComboBoxEstado = new MetroFramework.Controls.MetroComboBox();
            this.labelDestino = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelNombre
            // 
            this.labelNombre.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelNombre.AutoSize = true;
            this.labelNombre.Location = new System.Drawing.Point(54, 132);
            this.labelNombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelNombre.Name = "labelNombre";
            this.labelNombre.Size = new System.Drawing.Size(55, 21);
            this.labelNombre.TabIndex = 118;
            this.labelNombre.Text = "Estado";
            // 
            // labelIDAgente
            // 
            this.labelIDAgente.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelIDAgente.AutoSize = true;
            this.labelIDAgente.Location = new System.Drawing.Point(255, 90);
            this.labelIDAgente.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelIDAgente.Name = "labelIDAgente";
            this.labelIDAgente.Size = new System.Drawing.Size(78, 21);
            this.labelIDAgente.TabIndex = 119;
            this.labelIDAgente.Text = "ID Agente";
            // 
            // textBoxDescription
            // 
            this.textBoxDescription.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxDescription.Location = new System.Drawing.Point(116, 173);
            this.textBoxDescription.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxDescription.Multiline = true;
            this.textBoxDescription.Name = "textBoxDescription";
            this.textBoxDescription.Size = new System.Drawing.Size(336, 70);
            this.textBoxDescription.TabIndex = 175;
            // 
            // labelDescription
            // 
            this.labelDescription.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelDescription.AutoSize = true;
            this.labelDescription.Location = new System.Drawing.Point(21, 176);
            this.labelDescription.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelDescription.Name = "labelDescription";
            this.labelDescription.Size = new System.Drawing.Size(87, 21);
            this.labelDescription.TabIndex = 174;
            this.labelDescription.Text = "Descripción";
            // 
            // textBoxDestino
            // 
            this.textBoxDestino.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxDestino.Location = new System.Drawing.Point(116, 253);
            this.textBoxDestino.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxDestino.Multiline = true;
            this.textBoxDestino.Name = "textBoxDestino";
            this.textBoxDestino.Size = new System.Drawing.Size(336, 72);
            this.textBoxDestino.TabIndex = 176;
            // 
            // labelIDCliente
            // 
            this.labelIDCliente.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelIDCliente.AutoSize = true;
            this.labelIDCliente.Location = new System.Drawing.Point(34, 90);
            this.labelIDCliente.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelIDCliente.Name = "labelIDCliente";
            this.labelIDCliente.Size = new System.Drawing.Size(75, 21);
            this.labelIDCliente.TabIndex = 179;
            this.labelIDCliente.Text = "ID Cliente";
            // 
            // metroComboBoxAgente
            // 
            this.metroComboBoxAgente.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.metroComboBoxAgente.FormattingEnabled = true;
            this.metroComboBoxAgente.ItemHeight = 23;
            this.metroComboBoxAgente.Location = new System.Drawing.Point(339, 87);
            this.metroComboBoxAgente.Name = "metroComboBoxAgente";
            this.metroComboBoxAgente.Size = new System.Drawing.Size(113, 29);
            this.metroComboBoxAgente.TabIndex = 180;
            // 
            // metroButtonOK
            // 
            this.metroButtonOK.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.metroButtonOK.Location = new System.Drawing.Point(339, 345);
            this.metroButtonOK.Name = "metroButtonOK";
            this.metroButtonOK.Size = new System.Drawing.Size(113, 32);
            this.metroButtonOK.TabIndex = 182;
            this.metroButtonOK.Text = "OK";
            this.metroButtonOK.Click += new System.EventHandler(this.metroButtonOK_Click);
            // 
            // metroButtonCancel
            // 
            this.metroButtonCancel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.metroButtonCancel.Location = new System.Drawing.Point(220, 345);
            this.metroButtonCancel.Name = "metroButtonCancel";
            this.metroButtonCancel.Size = new System.Drawing.Size(113, 32);
            this.metroButtonCancel.TabIndex = 181;
            this.metroButtonCancel.Text = "Cancel";
            this.metroButtonCancel.Click += new System.EventHandler(this.metroButtonCancel_Click);
            // 
            // labelError
            // 
            this.labelError.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelError.AutoEllipsis = true;
            this.labelError.Font = new System.Drawing.Font("Segoe UI Light", 14F);
            this.labelError.ForeColor = System.Drawing.Color.Red;
            this.labelError.Location = new System.Drawing.Point(23, 14);
            this.labelError.Name = "labelError";
            this.labelError.Size = new System.Drawing.Size(429, 52);
            this.labelError.TabIndex = 185;
            this.labelError.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // metroComboBoxCliente
            // 
            this.metroComboBoxCliente.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.metroComboBoxCliente.FormattingEnabled = true;
            this.metroComboBoxCliente.ItemHeight = 23;
            this.metroComboBoxCliente.Location = new System.Drawing.Point(116, 87);
            this.metroComboBoxCliente.Name = "metroComboBoxCliente";
            this.metroComboBoxCliente.Size = new System.Drawing.Size(115, 29);
            this.metroComboBoxCliente.TabIndex = 186;
            // 
            // metroComboBoxEstado
            // 
            this.metroComboBoxEstado.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.metroComboBoxEstado.FormattingEnabled = true;
            this.metroComboBoxEstado.ItemHeight = 23;
            this.metroComboBoxEstado.Location = new System.Drawing.Point(116, 129);
            this.metroComboBoxEstado.Name = "metroComboBoxEstado";
            this.metroComboBoxEstado.Size = new System.Drawing.Size(115, 29);
            this.metroComboBoxEstado.TabIndex = 187;
            // 
            // labelDestino
            // 
            this.labelDestino.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelDestino.AutoSize = true;
            this.labelDestino.Location = new System.Drawing.Point(47, 256);
            this.labelDestino.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelDestino.Name = "labelDestino";
            this.labelDestino.Size = new System.Drawing.Size(61, 21);
            this.labelDestino.TabIndex = 188;
            this.labelDestino.Text = "Destino";
            // 
            // Cargas
            // 
            this.AcceptButton = this.metroButtonOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = MetroFramework.Drawing.MetroBorderStyle.FixedSingle;
            this.ClientSize = new System.Drawing.Size(475, 398);
            this.Controls.Add(this.labelDestino);
            this.Controls.Add(this.metroComboBoxEstado);
            this.Controls.Add(this.metroComboBoxCliente);
            this.Controls.Add(this.labelError);
            this.Controls.Add(this.metroButtonOK);
            this.Controls.Add(this.metroButtonCancel);
            this.Controls.Add(this.metroComboBoxAgente);
            this.Controls.Add(this.labelIDCliente);
            this.Controls.Add(this.textBoxDestino);
            this.Controls.Add(this.textBoxDescription);
            this.Controls.Add(this.labelDescription);
            this.Controls.Add(this.labelIDAgente);
            this.Controls.Add(this.labelNombre);
            this.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Cargas";
            this.Resizable = false;
            this.ShadowType = MetroFramework.Forms.MetroForm.MetroFormShadowType.SystemShadow;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Add user info";
            this.TextAlign = System.Windows.Forms.VisualStyles.HorizontalAlign.Center;
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Cargas_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelNombre;
        private System.Windows.Forms.Label labelIDAgente;
        private System.Windows.Forms.TextBox textBoxDescription;
        private System.Windows.Forms.Label labelDescription;
        private System.Windows.Forms.TextBox textBoxDestino;
        private System.Windows.Forms.Label labelIDCliente;
        private MetroFramework.Controls.MetroComboBox metroComboBoxAgente;
        private MetroFramework.Controls.MetroButton metroButtonOK;
        private MetroFramework.Controls.MetroButton metroButtonCancel;
        private System.Windows.Forms.Label labelError;
        private MetroFramework.Controls.MetroComboBox metroComboBoxCliente;
        private MetroFramework.Controls.MetroComboBox metroComboBoxEstado;
        private System.Windows.Forms.Label labelDestino;


    }
}