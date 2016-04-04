namespace SGCUI
{
    partial class Almacen
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
            this.textBoxDesc = new System.Windows.Forms.TextBox();
            this.labelDesc = new System.Windows.Forms.Label();
            this.metroButtonOK = new MetroFramework.Controls.MetroButton();
            this.metroButtonCancel = new MetroFramework.Controls.MetroButton();
            this.labelError = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxDesc
            // 
            this.textBoxDesc.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBoxDesc.Location = new System.Drawing.Point(132, 81);
            this.textBoxDesc.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxDesc.Multiline = true;
            this.textBoxDesc.Name = "textBoxDesc";
            this.textBoxDesc.Size = new System.Drawing.Size(362, 70);
            this.textBoxDesc.TabIndex = 175;
            // 
            // labelDesc
            // 
            this.labelDesc.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelDesc.AutoSize = true;
            this.labelDesc.Location = new System.Drawing.Point(37, 84);
            this.labelDesc.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelDesc.Name = "labelDesc";
            this.labelDesc.Size = new System.Drawing.Size(87, 21);
            this.labelDesc.TabIndex = 174;
            this.labelDesc.Text = "Descripción";
            // 
            // metroButtonOK
            // 
            this.metroButtonOK.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.metroButtonOK.Location = new System.Drawing.Point(409, 170);
            this.metroButtonOK.Name = "metroButtonOK";
            this.metroButtonOK.Size = new System.Drawing.Size(113, 32);
            this.metroButtonOK.TabIndex = 182;
            this.metroButtonOK.Text = "OK";
            // 
            // metroButtonCancel
            // 
            this.metroButtonCancel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.metroButtonCancel.Location = new System.Drawing.Point(290, 170);
            this.metroButtonCancel.Name = "metroButtonCancel";
            this.metroButtonCancel.Size = new System.Drawing.Size(113, 32);
            this.metroButtonCancel.TabIndex = 181;
            this.metroButtonCancel.Text = "Cancel";
            // 
            // labelError
            // 
            this.labelError.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelError.AutoEllipsis = true;
            this.labelError.Font = new System.Drawing.Font("Segoe UI Light", 14F);
            this.labelError.ForeColor = System.Drawing.Color.Red;
            this.labelError.Location = new System.Drawing.Point(48, 14);
            this.labelError.Name = "labelError";
            this.labelError.Size = new System.Drawing.Size(448, 52);
            this.labelError.TabIndex = 185;
            this.labelError.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Almacen
            // 
            this.AcceptButton = this.metroButtonOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = MetroFramework.Drawing.MetroBorderStyle.FixedSingle;
            this.ClientSize = new System.Drawing.Size(545, 223);
            this.Controls.Add(this.labelError);
            this.Controls.Add(this.metroButtonOK);
            this.Controls.Add(this.metroButtonCancel);
            this.Controls.Add(this.textBoxDesc);
            this.Controls.Add(this.labelDesc);
            this.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Almacen";
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

        private System.Windows.Forms.TextBox textBoxDesc;
        private System.Windows.Forms.Label labelDesc;
        private MetroFramework.Controls.MetroButton metroButtonOK;
        private MetroFramework.Controls.MetroButton metroButtonCancel;
        private System.Windows.Forms.Label labelError;


    }
}