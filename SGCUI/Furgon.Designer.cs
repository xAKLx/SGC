namespace SGCUI
{
    partial class Furgon
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
            this.labelCapacidad = new System.Windows.Forms.Label();
            this.metroButtonOK = new MetroFramework.Controls.MetroButton();
            this.metroButtonCancel = new MetroFramework.Controls.MetroButton();
            this.labelError = new System.Windows.Forms.Label();
            this.textBoxCapacidad = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // labelCapacidad
            // 
            this.labelCapacidad.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.labelCapacidad.AutoSize = true;
            this.labelCapacidad.Location = new System.Drawing.Point(9, 84);
            this.labelCapacidad.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelCapacidad.Name = "labelCapacidad";
            this.labelCapacidad.Size = new System.Drawing.Size(81, 21);
            this.labelCapacidad.TabIndex = 174;
            this.labelCapacidad.Text = "Capacidad";
            // 
            // metroButtonOK
            // 
            this.metroButtonOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.metroButtonOK.Location = new System.Drawing.Point(217, 129);
            this.metroButtonOK.Name = "metroButtonOK";
            this.metroButtonOK.Size = new System.Drawing.Size(113, 32);
            this.metroButtonOK.TabIndex = 182;
            this.metroButtonOK.Text = "OK";
            this.metroButtonOK.Click += new System.EventHandler(this.metroButtonOK_Click);
            // 
            // metroButtonCancel
            // 
            this.metroButtonCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.metroButtonCancel.Location = new System.Drawing.Point(98, 129);
            this.metroButtonCancel.Name = "metroButtonCancel";
            this.metroButtonCancel.Size = new System.Drawing.Size(113, 32);
            this.metroButtonCancel.TabIndex = 181;
            this.metroButtonCancel.Text = "Cancel";
            this.metroButtonCancel.Click += new System.EventHandler(this.metroButtonCancel_Click);
            // 
            // labelError
            // 
            this.labelError.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelError.AutoEllipsis = true;
            this.labelError.Font = new System.Drawing.Font("Segoe UI Light", 14F);
            this.labelError.ForeColor = System.Drawing.Color.Red;
            this.labelError.Location = new System.Drawing.Point(23, 14);
            this.labelError.Name = "labelError";
            this.labelError.Size = new System.Drawing.Size(298, 52);
            this.labelError.TabIndex = 185;
            this.labelError.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxCapacidad
            // 
            this.textBoxCapacidad.Location = new System.Drawing.Point(98, 81);
            this.textBoxCapacidad.Name = "textBoxCapacidad";
            this.textBoxCapacidad.Size = new System.Drawing.Size(232, 29);
            this.textBoxCapacidad.TabIndex = 187;
            // 
            // Furgon
            // 
            this.AcceptButton = this.metroButtonOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = MetroFramework.Drawing.MetroBorderStyle.FixedSingle;
            this.ClientSize = new System.Drawing.Size(344, 182);
            this.Controls.Add(this.textBoxCapacidad);
            this.Controls.Add(this.labelError);
            this.Controls.Add(this.metroButtonOK);
            this.Controls.Add(this.metroButtonCancel);
            this.Controls.Add(this.labelCapacidad);
            this.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Furgon";
            this.Resizable = false;
            this.ShadowType = MetroFramework.Forms.MetroForm.MetroFormShadowType.SystemShadow;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Add user info";
            this.TextAlign = System.Windows.Forms.VisualStyles.HorizontalAlign.Center;
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Furgon_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelCapacidad;
        private MetroFramework.Controls.MetroButton metroButtonOK;
        private MetroFramework.Controls.MetroButton metroButtonCancel;
        private System.Windows.Forms.Label labelError;
        private System.Windows.Forms.TextBox textBoxCapacidad;


    }
}