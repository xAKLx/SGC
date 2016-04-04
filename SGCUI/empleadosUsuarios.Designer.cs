namespace SGCUI
{
    partial class empleadosUsuarios
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
            this.labelApellido = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxLastName = new System.Windows.Forms.TextBox();
            this.textBoxPass = new System.Windows.Forms.TextBox();
            this.labelPass = new System.Windows.Forms.Label();
            this.textBoxPassConf = new System.Windows.Forms.TextBox();
            this.labelPassConf = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxLogin = new System.Windows.Forms.TextBox();
            this.metroComboBoxType = new MetroFramework.Controls.MetroComboBox();
            this.metroButtonOK = new MetroFramework.Controls.MetroButton();
            this.metroButtonCancel = new MetroFramework.Controls.MetroButton();
            this.textBoxCedula = new System.Windows.Forms.MaskedTextBox();
            this.labelCedula = new System.Windows.Forms.Label();
            this.labelError = new System.Windows.Forms.Label();
            this.metroCheckBoxPass = new MetroFramework.Controls.MetroCheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxTeléfono = new System.Windows.Forms.MaskedTextBox();
            this.labelTelefono = new System.Windows.Forms.Label();
            this.labelType = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelNombre
            // 
            this.labelNombre.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.labelNombre.AutoSize = true;
            this.labelNombre.Location = new System.Drawing.Point(35, 160);
            this.labelNombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelNombre.Name = "labelNombre";
            this.labelNombre.Size = new System.Drawing.Size(65, 21);
            this.labelNombre.TabIndex = 118;
            this.labelNombre.Text = "Nombre";
            // 
            // labelApellido
            // 
            this.labelApellido.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.labelApellido.AutoSize = true;
            this.labelApellido.Location = new System.Drawing.Point(36, 196);
            this.labelApellido.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelApellido.Name = "labelApellido";
            this.labelApellido.Size = new System.Drawing.Size(64, 21);
            this.labelApellido.TabIndex = 119;
            this.labelApellido.Text = "Apellido";
            // 
            // textBoxName
            // 
            this.textBoxName.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.textBoxName.Location = new System.Drawing.Point(108, 157);
            this.textBoxName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(296, 29);
            this.textBoxName.TabIndex = 121;
            // 
            // textBoxLastName
            // 
            this.textBoxLastName.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.textBoxLastName.Location = new System.Drawing.Point(108, 196);
            this.textBoxLastName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxLastName.Name = "textBoxLastName";
            this.textBoxLastName.Size = new System.Drawing.Size(296, 29);
            this.textBoxLastName.TabIndex = 122;
            // 
            // textBoxPass
            // 
            this.textBoxPass.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.textBoxPass.Location = new System.Drawing.Point(109, 362);
            this.textBoxPass.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxPass.Name = "textBoxPass";
            this.textBoxPass.Size = new System.Drawing.Size(295, 29);
            this.textBoxPass.TabIndex = 175;
            this.textBoxPass.UseSystemPasswordChar = true;
            // 
            // labelPass
            // 
            this.labelPass.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.labelPass.AutoSize = true;
            this.labelPass.Location = new System.Drawing.Point(14, 365);
            this.labelPass.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelPass.Name = "labelPass";
            this.labelPass.Size = new System.Drawing.Size(87, 21);
            this.labelPass.TabIndex = 174;
            this.labelPass.Text = "Contraseña";
            // 
            // textBoxPassConf
            // 
            this.textBoxPassConf.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.textBoxPassConf.Location = new System.Drawing.Point(109, 401);
            this.textBoxPassConf.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxPassConf.Name = "textBoxPassConf";
            this.textBoxPassConf.Size = new System.Drawing.Size(295, 29);
            this.textBoxPassConf.TabIndex = 176;
            this.textBoxPassConf.UseSystemPasswordChar = true;
            // 
            // labelPassConf
            // 
            this.labelPassConf.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.labelPassConf.AutoEllipsis = true;
            this.labelPassConf.Location = new System.Drawing.Point(12, 390);
            this.labelPassConf.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelPassConf.Name = "labelPassConf";
            this.labelPassConf.Size = new System.Drawing.Size(89, 49);
            this.labelPassConf.TabIndex = 177;
            this.labelPassConf.Text = "Confirmar contraseña";
            this.labelPassConf.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label1.Location = new System.Drawing.Point(23, 68);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 48);
            this.label1.TabIndex = 118;
            this.label1.Text = "Nombre de usuario";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxLogin
            // 
            this.textBoxLogin.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.textBoxLogin.Location = new System.Drawing.Point(120, 82);
            this.textBoxLogin.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxLogin.Name = "textBoxLogin";
            this.textBoxLogin.Size = new System.Drawing.Size(284, 29);
            this.textBoxLogin.TabIndex = 121;
            // 
            // metroComboBoxType
            // 
            this.metroComboBoxType.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.metroComboBoxType.FormattingEnabled = true;
            this.metroComboBoxType.ItemHeight = 23;
            this.metroComboBoxType.Items.AddRange(new object[] {
            "ADM",
            "REHU",
            "TRANS"});
            this.metroComboBoxType.Location = new System.Drawing.Point(108, 271);
            this.metroComboBoxType.Name = "metroComboBoxType";
            this.metroComboBoxType.Size = new System.Drawing.Size(115, 29);
            this.metroComboBoxType.TabIndex = 180;
            // 
            // metroButtonOK
            // 
            this.metroButtonOK.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.metroButtonOK.Location = new System.Drawing.Point(300, 449);
            this.metroButtonOK.Name = "metroButtonOK";
            this.metroButtonOK.Size = new System.Drawing.Size(113, 32);
            this.metroButtonOK.TabIndex = 0;
            this.metroButtonOK.Text = "Aceptar";
            this.metroButtonOK.Click += new System.EventHandler(this.metroButtonOK_Click);
            // 
            // metroButtonCancel
            // 
            this.metroButtonCancel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.metroButtonCancel.Location = new System.Drawing.Point(181, 449);
            this.metroButtonCancel.Name = "metroButtonCancel";
            this.metroButtonCancel.Size = new System.Drawing.Size(113, 32);
            this.metroButtonCancel.TabIndex = 181;
            this.metroButtonCancel.Text = "Cancelar";
            this.metroButtonCancel.Click += new System.EventHandler(this.metroButtonCancel_Click);
            // 
            // textBoxCedula
            // 
            this.textBoxCedula.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.textBoxCedula.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.textBoxCedula.Location = new System.Drawing.Point(294, 233);
            this.textBoxCedula.Mask = "000-0000000-0";
            this.textBoxCedula.Name = "textBoxCedula";
            this.textBoxCedula.Size = new System.Drawing.Size(110, 29);
            this.textBoxCedula.TabIndex = 183;
            this.textBoxCedula.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxCedula.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // labelCedula
            // 
            this.labelCedula.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.labelCedula.AutoSize = true;
            this.labelCedula.Location = new System.Drawing.Point(230, 236);
            this.labelCedula.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelCedula.Name = "labelCedula";
            this.labelCedula.Size = new System.Drawing.Size(57, 21);
            this.labelCedula.TabIndex = 184;
            this.labelCedula.Text = "Cédula";
            // 
            // labelError
            // 
            this.labelError.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelError.AutoEllipsis = true;
            this.labelError.Font = new System.Drawing.Font("Segoe UI Light", 14F);
            this.labelError.ForeColor = System.Drawing.Color.Red;
            this.labelError.Location = new System.Drawing.Point(23, 14);
            this.labelError.Name = "labelError";
            this.labelError.Size = new System.Drawing.Size(390, 54);
            this.labelError.TabIndex = 185;
            this.labelError.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // metroCheckBoxPass
            // 
            this.metroCheckBoxPass.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.metroCheckBoxPass.AutoSize = true;
            this.metroCheckBoxPass.Location = new System.Drawing.Point(102, 339);
            this.metroCheckBoxPass.Name = "metroCheckBoxPass";
            this.metroCheckBoxPass.Size = new System.Drawing.Size(129, 15);
            this.metroCheckBoxPass.TabIndex = 186;
            this.metroCheckBoxPass.Text = "Cambiar contraseña";
            this.metroCheckBoxPass.UseVisualStyleBackColor = true;
            this.metroCheckBoxPass.CheckedChanged += new System.EventHandler(this.metroCheckBoxPass_CheckedChanged);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Location = new System.Drawing.Point(32, 303);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(381, 21);
            this.label2.TabIndex = 187;
            this.label2.Text = "_____________________________________________________";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label3.Location = new System.Drawing.Point(32, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(381, 21);
            this.label3.TabIndex = 188;
            this.label3.Text = "_____________________________________________________";
            // 
            // textBoxTeléfono
            // 
            this.textBoxTeléfono.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.textBoxTeléfono.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.textBoxTeléfono.Location = new System.Drawing.Point(108, 233);
            this.textBoxTeléfono.Mask = "(999) 000-0000";
            this.textBoxTeléfono.Name = "textBoxTeléfono";
            this.textBoxTeléfono.Size = new System.Drawing.Size(115, 29);
            this.textBoxTeléfono.TabIndex = 189;
            this.textBoxTeléfono.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxTeléfono.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // labelTelefono
            // 
            this.labelTelefono.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.labelTelefono.AutoSize = true;
            this.labelTelefono.Location = new System.Drawing.Point(36, 236);
            this.labelTelefono.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTelefono.Name = "labelTelefono";
            this.labelTelefono.Size = new System.Drawing.Size(65, 21);
            this.labelTelefono.TabIndex = 190;
            this.labelTelefono.Text = "Teléfono";
            // 
            // labelType
            // 
            this.labelType.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.labelType.AutoSize = true;
            this.labelType.Location = new System.Drawing.Point(40, 274);
            this.labelType.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelType.Name = "labelType";
            this.labelType.Size = new System.Drawing.Size(61, 21);
            this.labelType.TabIndex = 191;
            this.labelType.Text = "Sección";
            // 
            // empleadosUsuarios
            // 
            this.AcceptButton = this.metroButtonOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = MetroFramework.Drawing.MetroBorderStyle.FixedSingle;
            this.ClientSize = new System.Drawing.Size(436, 502);
            this.Controls.Add(this.labelType);
            this.Controls.Add(this.labelTelefono);
            this.Controls.Add(this.textBoxTeléfono);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.metroCheckBoxPass);
            this.Controls.Add(this.labelError);
            this.Controls.Add(this.labelCedula);
            this.Controls.Add(this.textBoxCedula);
            this.Controls.Add(this.metroButtonOK);
            this.Controls.Add(this.metroButtonCancel);
            this.Controls.Add(this.metroComboBoxType);
            this.Controls.Add(this.labelPassConf);
            this.Controls.Add(this.textBoxPassConf);
            this.Controls.Add(this.textBoxPass);
            this.Controls.Add(this.labelPass);
            this.Controls.Add(this.textBoxLastName);
            this.Controls.Add(this.textBoxLogin);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelApellido);
            this.Controls.Add(this.labelNombre);
            this.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "empleadosUsuarios";
            this.Resizable = false;
            this.ShadowType = MetroFramework.Forms.MetroForm.MetroFormShadowType.SystemShadow;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Edit user info";
            this.TextAlign = System.Windows.Forms.VisualStyles.HorizontalAlign.Center;
            this.TopMost = true;
            this.Load += new System.EventHandler(this.empleadosUsuarios_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelNombre;
        private System.Windows.Forms.Label labelApellido;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxLastName;
        private System.Windows.Forms.TextBox textBoxPass;
        private System.Windows.Forms.Label labelPass;
        private System.Windows.Forms.TextBox textBoxPassConf;
        private System.Windows.Forms.Label labelPassConf;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxLogin;
        private MetroFramework.Controls.MetroComboBox metroComboBoxType;
        private MetroFramework.Controls.MetroButton metroButtonOK;
        private MetroFramework.Controls.MetroButton metroButtonCancel;
        private System.Windows.Forms.MaskedTextBox textBoxCedula;
        private System.Windows.Forms.Label labelCedula;
        private System.Windows.Forms.Label labelError;
        private MetroFramework.Controls.MetroCheckBox metroCheckBoxPass;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox textBoxTeléfono;
        private System.Windows.Forms.Label labelTelefono;
        private System.Windows.Forms.Label labelType;


    }
}