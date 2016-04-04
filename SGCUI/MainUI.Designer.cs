namespace SGCUI
{
    partial class MainUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainUI));
            this.metroTabControl1 = new MetroFramework.Controls.MetroTabControl();
            this.metroTabPage1 = new MetroFramework.Controls.MetroTabPage();
            this.metroTileAbout = new MetroFramework.Controls.MetroTile();
            this.metroTileAdminTools = new MetroFramework.Controls.MetroTile();
            this.metroTileClientes = new MetroFramework.Controls.MetroTile();
            this.metroTileCargas = new MetroFramework.Controls.MetroTile();
            this.metroTileTemp = new MetroFramework.Controls.MetroTile();
            this.metroButtonLogOut = new MetroFramework.Controls.MetroButton();
            this.btUserList = new System.Windows.Forms.Button();
            this.metroTileAgentes = new MetroFramework.Controls.MetroTile();
            this.metroTabControl1.SuspendLayout();
            this.metroTabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroTabControl1
            // 
            this.metroTabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.metroTabControl1.Appearance = System.Windows.Forms.TabAppearance.Buttons;
            this.metroTabControl1.Controls.Add(this.metroTabPage1);
            this.metroTabControl1.Location = new System.Drawing.Point(23, 63);
            this.metroTabControl1.Name = "metroTabControl1";
            this.metroTabControl1.SelectedIndex = 0;
            this.metroTabControl1.Size = new System.Drawing.Size(543, 378);
            this.metroTabControl1.TabIndex = 3;
            // 
            // metroTabPage1
            // 
            this.metroTabPage1.Controls.Add(this.metroTileAgentes);
            this.metroTabPage1.Controls.Add(this.metroTileAbout);
            this.metroTabPage1.Controls.Add(this.metroTileAdminTools);
            this.metroTabPage1.Controls.Add(this.metroTileClientes);
            this.metroTabPage1.Controls.Add(this.metroTileCargas);
            this.metroTabPage1.Controls.Add(this.metroTileTemp);
            this.metroTabPage1.HorizontalScrollbarBarColor = true;
            this.metroTabPage1.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage1.Name = "metroTabPage1";
            this.metroTabPage1.Size = new System.Drawing.Size(535, 336);
            this.metroTabPage1.TabIndex = 0;
            this.metroTabPage1.Text = "INICIO";
            this.metroTabPage1.VerticalScrollbarBarColor = true;
            // 
            // metroTileAbout
            // 
            this.metroTileAbout.Location = new System.Drawing.Point(3, 167);
            this.metroTileAbout.Name = "metroTileAbout";
            this.metroTileAbout.Size = new System.Drawing.Size(172, 158);
            this.metroTileAbout.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTileAbout.TabIndex = 7;
            this.metroTileAbout.Text = "Acerca de";
            this.metroTileAbout.TileImage = global::SGCUI.Properties.Resources.themify_e717_0__1024;
            this.metroTileAbout.TileImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.metroTileAbout.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.metroTileAbout.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.metroTileAbout.UseTileImage = true;
            this.metroTileAbout.Click += new System.EventHandler(this.metroTileAbout_Click);
            // 
            // metroTileAdminTools
            // 
            this.metroTileAdminTools.CustomForeColor = true;
            this.metroTileAdminTools.Location = new System.Drawing.Point(181, 167);
            this.metroTileAdminTools.Name = "metroTileAdminTools";
            this.metroTileAdminTools.Size = new System.Drawing.Size(172, 158);
            this.metroTileAdminTools.Style = MetroFramework.MetroColorStyle.Yellow;
            this.metroTileAdminTools.TabIndex = 0;
            this.metroTileAdminTools.Text = "Admin Tools";
            this.metroTileAdminTools.TileImage = global::SGCUI.Properties.Resources.themify_e60f_0__1024;
            this.metroTileAdminTools.TileImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.metroTileAdminTools.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.metroTileAdminTools.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.metroTileAdminTools.UseTileImage = true;
            this.metroTileAdminTools.Click += new System.EventHandler(this.metroTileAdminTools_Click);
            // 
            // metroTileClientes
            // 
            this.metroTileClientes.Location = new System.Drawing.Point(3, 3);
            this.metroTileClientes.Name = "metroTileClientes";
            this.metroTileClientes.Size = new System.Drawing.Size(172, 158);
            this.metroTileClientes.Style = MetroFramework.MetroColorStyle.Green;
            this.metroTileClientes.TabIndex = 0;
            this.metroTileClientes.Text = "Clientes";
            this.metroTileClientes.TileImage = ((System.Drawing.Image)(resources.GetObject("metroTileClientes.TileImage")));
            this.metroTileClientes.TileImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.metroTileClientes.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.metroTileClientes.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.metroTileClientes.UseTileImage = true;
            this.metroTileClientes.Click += new System.EventHandler(this.metroTileClientes_Click);
            // 
            // metroTileCargas
            // 
            this.metroTileCargas.Location = new System.Drawing.Point(181, 3);
            this.metroTileCargas.Name = "metroTileCargas";
            this.metroTileCargas.Size = new System.Drawing.Size(172, 158);
            this.metroTileCargas.Style = MetroFramework.MetroColorStyle.Red;
            this.metroTileCargas.TabIndex = 6;
            this.metroTileCargas.Text = "Cargas";
            this.metroTileCargas.TileImage = global::SGCUI.Properties.Resources.octicons_f0c4_0__1024;
            this.metroTileCargas.TileImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.metroTileCargas.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.metroTileCargas.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.metroTileCargas.UseTileImage = true;
            this.metroTileCargas.Click += new System.EventHandler(this.metroTileCargas_Click);
            // 
            // metroTileTemp
            // 
            this.metroTileTemp.Location = new System.Drawing.Point(359, 3);
            this.metroTileTemp.Name = "metroTileTemp";
            this.metroTileTemp.Size = new System.Drawing.Size(172, 158);
            this.metroTileTemp.Style = MetroFramework.MetroColorStyle.Orange;
            this.metroTileTemp.TabIndex = 3;
            this.metroTileTemp.Text = "Furgones";
            this.metroTileTemp.TileImage = global::SGCUI.Properties.Resources.themify_e66d_0__1024;
            this.metroTileTemp.TileImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.metroTileTemp.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.metroTileTemp.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.metroTileTemp.UseTileImage = true;
            this.metroTileTemp.Click += new System.EventHandler(this.metroTileTemp_Click);
            // 
            // metroButtonLogOut
            // 
            this.metroButtonLogOut.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.metroButtonLogOut.Location = new System.Drawing.Point(483, 454);
            this.metroButtonLogOut.Name = "metroButtonLogOut";
            this.metroButtonLogOut.Size = new System.Drawing.Size(75, 23);
            this.metroButtonLogOut.TabIndex = 7;
            this.metroButtonLogOut.Text = "Cerrar Sesión";
            this.metroButtonLogOut.Click += new System.EventHandler(this.metroButtonLogOut_Click);
            // 
            // btUserList
            // 
            this.btUserList.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btUserList.AutoSize = true;
            this.btUserList.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btUserList.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btUserList.FlatAppearance.BorderSize = 0;
            this.btUserList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btUserList.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btUserList.Location = new System.Drawing.Point(30, 447);
            this.btUserList.Name = "btUserList";
            this.btUserList.Size = new System.Drawing.Size(137, 31);
            this.btUserList.TabIndex = 8;
            this.btUserList.Text = "Cuenta activa: ---";
            this.btUserList.UseVisualStyleBackColor = false;
            this.btUserList.Click += new System.EventHandler(this.btUserList_Click);
            // 
            // metroTileAgentes
            // 
            this.metroTileAgentes.Location = new System.Drawing.Point(359, 167);
            this.metroTileAgentes.Name = "metroTileAgentes";
            this.metroTileAgentes.Size = new System.Drawing.Size(172, 158);
            this.metroTileAgentes.Style = MetroFramework.MetroColorStyle.Purple;
            this.metroTileAgentes.TabIndex = 8;
            this.metroTileAgentes.Text = "Agentes";
            this.metroTileAgentes.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.metroTileAgentes.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.metroTileAgentes.Click += new System.EventHandler(this.metroTileAgentes_Click);
            // 
            // MainUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = MetroFramework.Drawing.MetroBorderStyle.FixedSingle;
            this.ClientSize = new System.Drawing.Size(589, 500);
            this.Controls.Add(this.btUserList);
            this.Controls.Add(this.metroButtonLogOut);
            this.Controls.Add(this.metroTabControl1);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "MainUI";
            this.Resizable = false;
            this.ShadowType = MetroFramework.Forms.MetroForm.MetroFormShadowType.SystemShadow;
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Style = MetroFramework.MetroColorStyle.Green;
            this.Text = "Syncro Logistics";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainUI_FormClosing);
            this.Load += new System.EventHandler(this.MainUI_Load);
            this.metroTabControl1.ResumeLayout(false);
            this.metroTabPage1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTabControl metroTabControl1;
        private MetroFramework.Controls.MetroTabPage metroTabPage1;
        private MetroFramework.Controls.MetroButton metroButtonLogOut;
        private System.Windows.Forms.Button btUserList;
        private MetroFramework.Controls.MetroTile metroTileTemp;
        private MetroFramework.Controls.MetroTile metroTileCargas;
        private MetroFramework.Controls.MetroTile metroTileClientes;
        private MetroFramework.Controls.MetroTile metroTileAdminTools;
        private MetroFramework.Controls.MetroTile metroTileAbout;
        private MetroFramework.Controls.MetroTile metroTileAgentes;
    }
}

