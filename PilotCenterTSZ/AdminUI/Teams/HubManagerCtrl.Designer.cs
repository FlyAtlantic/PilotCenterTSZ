namespace PilotCenterTSZ.AdminUI.Teams
{
    partial class HubManagerCtrl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HubManagerCtrl));
            this.lblHubInfo = new System.Windows.Forms.Label();
            this.btnViewRoutes = new Bunifu.Framework.UI.BunifuFlatButton();
            this.viewHubRoutesCtrl1 = new PilotCenterTSZ.AdminUI.Teams.ViewHubRoutesCtrl();
            this.SuspendLayout();
            // 
            // lblHubInfo
            // 
            this.lblHubInfo.AutoSize = true;
            this.lblHubInfo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHubInfo.ForeColor = System.Drawing.Color.DarkRed;
            this.lblHubInfo.Location = new System.Drawing.Point(18, 12);
            this.lblHubInfo.Name = "lblHubInfo";
            this.lblHubInfo.Size = new System.Drawing.Size(73, 21);
            this.lblHubInfo.TabIndex = 8;
            this.lblHubInfo.Text = "HubInfo";
            // 
            // btnViewRoutes
            // 
            this.btnViewRoutes.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(60)))), ((int)(((byte)(100)))));
            this.btnViewRoutes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.btnViewRoutes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnViewRoutes.BorderRadius = 0;
            this.btnViewRoutes.ButtonText = "View Routes";
            this.btnViewRoutes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnViewRoutes.DisabledColor = System.Drawing.Color.Gray;
            this.btnViewRoutes.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewRoutes.Iconcolor = System.Drawing.Color.Transparent;
            this.btnViewRoutes.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnViewRoutes.Iconimage")));
            this.btnViewRoutes.Iconimage_right = null;
            this.btnViewRoutes.Iconimage_right_Selected = null;
            this.btnViewRoutes.Iconimage_Selected = null;
            this.btnViewRoutes.IconMarginLeft = 0;
            this.btnViewRoutes.IconMarginRight = 0;
            this.btnViewRoutes.IconRightVisible = true;
            this.btnViewRoutes.IconRightZoom = 0D;
            this.btnViewRoutes.IconVisible = true;
            this.btnViewRoutes.IconZoom = 90D;
            this.btnViewRoutes.IsTab = false;
            this.btnViewRoutes.Location = new System.Drawing.Point(22, 53);
            this.btnViewRoutes.Name = "btnViewRoutes";
            this.btnViewRoutes.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.btnViewRoutes.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(60)))), ((int)(((byte)(100)))));
            this.btnViewRoutes.OnHoverTextColor = System.Drawing.Color.White;
            this.btnViewRoutes.selected = false;
            this.btnViewRoutes.Size = new System.Drawing.Size(238, 48);
            this.btnViewRoutes.TabIndex = 7;
            this.btnViewRoutes.Text = "View Routes";
            this.btnViewRoutes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnViewRoutes.Textcolor = System.Drawing.Color.White;
            this.btnViewRoutes.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewRoutes.Click += new System.EventHandler(this.btnViewRoutes_Click);
            // 
            // viewHubRoutesCtrl1
            // 
            this.viewHubRoutesCtrl1.Location = new System.Drawing.Point(-3, 0);
            this.viewHubRoutesCtrl1.Name = "viewHubRoutesCtrl1";
            this.viewHubRoutesCtrl1.Size = new System.Drawing.Size(908, 500);
            this.viewHubRoutesCtrl1.TabIndex = 9;
            this.viewHubRoutesCtrl1.Visible = false;
            // 
            // HubManagerCtrl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.viewHubRoutesCtrl1);
            this.Controls.Add(this.lblHubInfo);
            this.Controls.Add(this.btnViewRoutes);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Name = "HubManagerCtrl";
            this.Size = new System.Drawing.Size(908, 479);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuFlatButton btnViewRoutes;
        private System.Windows.Forms.Label lblHubInfo;
        public ViewHubRoutesCtrl viewHubRoutesCtrl1;
    }
}
