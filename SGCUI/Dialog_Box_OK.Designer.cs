namespace SGCUI
{
    partial class Dialog_Box_OK
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
            this.labelText = new System.Windows.Forms.Label();
            this.metroButtonOK = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // labelText
            // 
            this.labelText.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.labelText.Font = new System.Drawing.Font("Segoe UI Light", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelText.Location = new System.Drawing.Point(12, 16);
            this.labelText.Name = "labelText";
            this.labelText.Size = new System.Drawing.Size(232, 76);
            this.labelText.TabIndex = 16;
            this.labelText.Text = "Text";
            this.labelText.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // metroButtonOK
            // 
            this.metroButtonOK.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.metroButtonOK.Location = new System.Drawing.Point(131, 99);
            this.metroButtonOK.Name = "metroButtonOK";
            this.metroButtonOK.Size = new System.Drawing.Size(113, 32);
            this.metroButtonOK.TabIndex = 18;
            this.metroButtonOK.Text = "OK";
            this.metroButtonOK.Click += new System.EventHandler(this.metroButtonOK_Click);
            // 
            // Dialog_Box_OK
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = MetroFramework.Drawing.MetroBorderStyle.FixedSingle;
            this.ClientSize = new System.Drawing.Size(256, 143);
            this.ControlBox = false;
            this.Controls.Add(this.metroButtonOK);
            this.Controls.Add(this.labelText);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Dialog_Box_OK";
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Style = MetroFramework.MetroColorStyle.Yellow;
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Dialog_Box_OK_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelText;
        private MetroFramework.Controls.MetroButton metroButtonOK;


    }
}