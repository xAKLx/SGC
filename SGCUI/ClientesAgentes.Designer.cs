namespace SGCUI
{
    partial class ClientesAgentes
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
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.metroButtonOK = new MetroFramework.Controls.MetroButton();
            this.metroButtonCancel = new MetroFramework.Controls.MetroButton();
            this.textBoxCedula = new System.Windows.Forms.MaskedTextBox();
            this.labelCedula = new System.Windows.Forms.Label();
            this.labelError = new System.Windows.Forms.Label();
            this.textBoxTeléfono = new System.Windows.Forms.MaskedTextBox();
            this.labelTelefono = new System.Windows.Forms.Label();
            this.labelAddress = new System.Windows.Forms.Label();
            this.tbDirection = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // labelNombre
            // 
            this.labelNombre.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelNombre.AutoSize = true;
            this.labelNombre.Location = new System.Drawing.Point(35, 84);
            this.labelNombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelNombre.Name = "labelNombre";
            this.labelNombre.Size = new System.Drawing.Size(65, 21);
            this.labelNombre.TabIndex = 118;
            this.labelNombre.Text = "Nombre";
            // 
            // textBoxName
            // 
            this.textBoxName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxName.Location = new System.Drawing.Point(108, 81);
            this.textBoxName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(296, 29);
            this.textBoxName.TabIndex = 121;
            // 
            // metroButtonOK
            // 
            this.metroButtonOK.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.metroButtonOK.Location = new System.Drawing.Point(300, 282);
            this.metroButtonOK.Name = "metroButtonOK";
            this.metroButtonOK.Size = new System.Drawing.Size(113, 32);
            this.metroButtonOK.TabIndex = 0;
            this.metroButtonOK.Text = "Aceptar";
            this.metroButtonOK.Click += new System.EventHandler(this.metroButtonOK_Click);
            // 
            // metroButtonCancel
            // 
            this.metroButtonCancel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.metroButtonCancel.Location = new System.Drawing.Point(181, 282);
            this.metroButtonCancel.Name = "metroButtonCancel";
            this.metroButtonCancel.Size = new System.Drawing.Size(113, 32);
            this.metroButtonCancel.TabIndex = 181;
            this.metroButtonCancel.Text = "Cancelar";
            this.metroButtonCancel.Click += new System.EventHandler(this.metroButtonCancel_Click);
            // 
            // textBoxCedula
            // 
            this.textBoxCedula.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxCedula.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.textBoxCedula.Location = new System.Drawing.Point(294, 119);
            this.textBoxCedula.Mask = "000-0000000-0";
            this.textBoxCedula.Name = "textBoxCedula";
            this.textBoxCedula.Size = new System.Drawing.Size(110, 29);
            this.textBoxCedula.TabIndex = 183;
            this.textBoxCedula.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxCedula.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // labelCedula
            // 
            this.labelCedula.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelCedula.AutoSize = true;
            this.labelCedula.Location = new System.Drawing.Point(230, 122);
            this.labelCedula.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelCedula.Name = "labelCedula";
            this.labelCedula.Size = new System.Drawing.Size(57, 21);
            this.labelCedula.TabIndex = 184;
            this.labelCedula.Text = "Cédula";
            // 
            // labelError
            // 
            this.labelError.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelError.AutoEllipsis = true;
            this.labelError.Font = new System.Drawing.Font("Segoe UI Light", 14F);
            this.labelError.ForeColor = System.Drawing.Color.Red;
            this.labelError.Location = new System.Drawing.Point(23, 14);
            this.labelError.Name = "labelError";
            this.labelError.Size = new System.Drawing.Size(390, 54);
            this.labelError.TabIndex = 185;
            this.labelError.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxTeléfono
            // 
            this.textBoxTeléfono.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxTeléfono.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.textBoxTeléfono.Location = new System.Drawing.Point(108, 119);
            this.textBoxTeléfono.Mask = "(999) 000-0000";
            this.textBoxTeléfono.Name = "textBoxTeléfono";
            this.textBoxTeléfono.Size = new System.Drawing.Size(115, 29);
            this.textBoxTeléfono.TabIndex = 189;
            this.textBoxTeléfono.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxTeléfono.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // labelTelefono
            // 
            this.labelTelefono.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelTelefono.AutoSize = true;
            this.labelTelefono.Location = new System.Drawing.Point(36, 122);
            this.labelTelefono.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTelefono.Name = "labelTelefono";
            this.labelTelefono.Size = new System.Drawing.Size(65, 21);
            this.labelTelefono.TabIndex = 190;
            this.labelTelefono.Text = "Teléfono";
            // 
            // labelAddress
            // 
            this.labelAddress.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelAddress.AutoSize = true;
            this.labelAddress.Location = new System.Drawing.Point(28, 159);
            this.labelAddress.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelAddress.Name = "labelAddress";
            this.labelAddress.Size = new System.Drawing.Size(72, 21);
            this.labelAddress.TabIndex = 191;
            this.labelAddress.Text = "Dirección";
            // 
            // tbDirection
            // 
            this.tbDirection.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbDirection.Location = new System.Drawing.Point(108, 156);
            this.tbDirection.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbDirection.Multiline = true;
            this.tbDirection.Name = "tbDirection";
            this.tbDirection.Size = new System.Drawing.Size(296, 104);
            this.tbDirection.TabIndex = 192;
            // 
            // ClientesAgentes
            // 
            this.AcceptButton = this.metroButtonOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = MetroFramework.Drawing.MetroBorderStyle.FixedSingle;
            this.ClientSize = new System.Drawing.Size(436, 335);
            this.Controls.Add(this.tbDirection);
            this.Controls.Add(this.labelAddress);
            this.Controls.Add(this.labelTelefono);
            this.Controls.Add(this.textBoxTeléfono);
            this.Controls.Add(this.labelError);
            this.Controls.Add(this.labelCedula);
            this.Controls.Add(this.textBoxCedula);
            this.Controls.Add(this.metroButtonOK);
            this.Controls.Add(this.metroButtonCancel);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.labelNombre);
            this.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ClientesAgentes";
            this.Resizable = false;
            this.ShadowType = MetroFramework.Forms.MetroForm.MetroFormShadowType.SystemShadow;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "AgenteCliente";
            this.TextAlign = System.Windows.Forms.VisualStyles.HorizontalAlign.Center;
            this.TopMost = true;
            this.Load += new System.EventHandler(this.ClientesAgentes_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelNombre;
        private System.Windows.Forms.TextBox textBoxName;
        private MetroFramework.Controls.MetroButton metroButtonOK;
        private MetroFramework.Controls.MetroButton metroButtonCancel;
        private System.Windows.Forms.MaskedTextBox textBoxCedula;
        private System.Windows.Forms.Label labelCedula;
        private System.Windows.Forms.Label labelError;
        private System.Windows.Forms.MaskedTextBox textBoxTeléfono;
        private System.Windows.Forms.Label labelTelefono;
        private System.Windows.Forms.Label labelAddress;
        private System.Windows.Forms.TextBox tbDirection;


    }
}