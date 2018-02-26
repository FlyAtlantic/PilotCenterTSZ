namespace AdminCenter
{
    partial class AdminDash
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminDash));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnPilotCenterFrm = new Bunifu.Framework.UI.BunifuTileButton();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pMenuBar = new System.Windows.Forms.Panel();
            this.btnLogBook = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnAssignFlight = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnPilotCenter = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnRefresh = new Bunifu.Framework.UI.BunifuTileButton();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.pMenuBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.panel1.Controls.Add(this.btnPilotCenterFrm);
            this.panel1.Controls.Add(this.lblTitle);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1149, 77);
            this.panel1.TabIndex = 96;
            // 
            // btnPilotCenterFrm
            // 
            this.btnPilotCenterFrm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.btnPilotCenterFrm.color = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.btnPilotCenterFrm.colorActive = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.btnPilotCenterFrm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPilotCenterFrm.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.btnPilotCenterFrm.ForeColor = System.Drawing.Color.White;
            this.btnPilotCenterFrm.Image = global::AdminCenter.Properties.Resources.refreshImg;
            this.btnPilotCenterFrm.ImagePosition = 0;
            this.btnPilotCenterFrm.ImageZoom = 95;
            this.btnPilotCenterFrm.LabelPosition = 0;
            this.btnPilotCenterFrm.LabelText = "";
            this.btnPilotCenterFrm.Location = new System.Drawing.Point(510, 18);
            this.btnPilotCenterFrm.Margin = new System.Windows.Forms.Padding(6);
            this.btnPilotCenterFrm.Name = "btnPilotCenterFrm";
            this.btnPilotCenterFrm.Size = new System.Drawing.Size(39, 39);
            this.btnPilotCenterFrm.TabIndex = 6;
            this.btnPilotCenterFrm.Click += new System.EventHandler(this.btnPilotCenterFrm_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblTitle.Location = new System.Drawing.Point(19, 18);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(219, 24);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "FlyAtlantic Staff Center";
            // 
            // pMenuBar
            // 
            this.pMenuBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.pMenuBar.Controls.Add(this.btnLogBook);
            this.pMenuBar.Controls.Add(this.btnAssignFlight);
            this.pMenuBar.Controls.Add(this.btnPilotCenter);
            this.pMenuBar.Controls.Add(this.btnRefresh);
            this.pMenuBar.Dock = System.Windows.Forms.DockStyle.Left;
            this.pMenuBar.Location = new System.Drawing.Point(0, 77);
            this.pMenuBar.Name = "pMenuBar";
            this.pMenuBar.Size = new System.Drawing.Size(211, 579);
            this.pMenuBar.TabIndex = 97;
            // 
            // btnLogBook
            // 
            this.btnLogBook.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(60)))), ((int)(((byte)(100)))));
            this.btnLogBook.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.btnLogBook.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLogBook.BorderRadius = 0;
            this.btnLogBook.ButtonText = "LogBook";
            this.btnLogBook.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogBook.DisabledColor = System.Drawing.Color.Gray;
            this.btnLogBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogBook.Iconcolor = System.Drawing.Color.Transparent;
            this.btnLogBook.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnLogBook.Iconimage")));
            this.btnLogBook.Iconimage_right = null;
            this.btnLogBook.Iconimage_right_Selected = null;
            this.btnLogBook.Iconimage_Selected = null;
            this.btnLogBook.IconMarginLeft = 0;
            this.btnLogBook.IconMarginRight = 0;
            this.btnLogBook.IconRightVisible = true;
            this.btnLogBook.IconRightZoom = 0D;
            this.btnLogBook.IconVisible = true;
            this.btnLogBook.IconZoom = 90D;
            this.btnLogBook.IsTab = false;
            this.btnLogBook.Location = new System.Drawing.Point(0, 229);
            this.btnLogBook.Name = "btnLogBook";
            this.btnLogBook.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.btnLogBook.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(60)))), ((int)(((byte)(100)))));
            this.btnLogBook.OnHoverTextColor = System.Drawing.Color.White;
            this.btnLogBook.selected = false;
            this.btnLogBook.Size = new System.Drawing.Size(238, 48);
            this.btnLogBook.TabIndex = 5;
            this.btnLogBook.Text = "LogBook";
            this.btnLogBook.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogBook.Textcolor = System.Drawing.Color.White;
            this.btnLogBook.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // btnAssignFlight
            // 
            this.btnAssignFlight.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(60)))), ((int)(((byte)(100)))));
            this.btnAssignFlight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.btnAssignFlight.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAssignFlight.BorderRadius = 0;
            this.btnAssignFlight.ButtonText = "Flight Assignment";
            this.btnAssignFlight.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAssignFlight.DisabledColor = System.Drawing.Color.Gray;
            this.btnAssignFlight.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAssignFlight.Iconcolor = System.Drawing.Color.Transparent;
            this.btnAssignFlight.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnAssignFlight.Iconimage")));
            this.btnAssignFlight.Iconimage_right = null;
            this.btnAssignFlight.Iconimage_right_Selected = null;
            this.btnAssignFlight.Iconimage_Selected = null;
            this.btnAssignFlight.IconMarginLeft = 0;
            this.btnAssignFlight.IconMarginRight = 0;
            this.btnAssignFlight.IconRightVisible = true;
            this.btnAssignFlight.IconRightZoom = 0D;
            this.btnAssignFlight.IconVisible = true;
            this.btnAssignFlight.IconZoom = 90D;
            this.btnAssignFlight.IsTab = false;
            this.btnAssignFlight.Location = new System.Drawing.Point(0, 175);
            this.btnAssignFlight.Name = "btnAssignFlight";
            this.btnAssignFlight.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.btnAssignFlight.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(60)))), ((int)(((byte)(100)))));
            this.btnAssignFlight.OnHoverTextColor = System.Drawing.Color.White;
            this.btnAssignFlight.selected = false;
            this.btnAssignFlight.Size = new System.Drawing.Size(238, 48);
            this.btnAssignFlight.TabIndex = 4;
            this.btnAssignFlight.Text = "Flight Assignment";
            this.btnAssignFlight.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAssignFlight.Textcolor = System.Drawing.Color.White;
            this.btnAssignFlight.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // btnPilotCenter
            // 
            this.btnPilotCenter.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(60)))), ((int)(((byte)(100)))));
            this.btnPilotCenter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.btnPilotCenter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPilotCenter.BorderRadius = 0;
            this.btnPilotCenter.ButtonText = "Pilot Center";
            this.btnPilotCenter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPilotCenter.DisabledColor = System.Drawing.Color.Gray;
            this.btnPilotCenter.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPilotCenter.Iconcolor = System.Drawing.Color.Transparent;
            this.btnPilotCenter.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnPilotCenter.Iconimage")));
            this.btnPilotCenter.Iconimage_right = null;
            this.btnPilotCenter.Iconimage_right_Selected = null;
            this.btnPilotCenter.Iconimage_Selected = null;
            this.btnPilotCenter.IconMarginLeft = 0;
            this.btnPilotCenter.IconMarginRight = 0;
            this.btnPilotCenter.IconRightVisible = true;
            this.btnPilotCenter.IconRightZoom = 0D;
            this.btnPilotCenter.IconVisible = true;
            this.btnPilotCenter.IconZoom = 90D;
            this.btnPilotCenter.IsTab = false;
            this.btnPilotCenter.Location = new System.Drawing.Point(0, 121);
            this.btnPilotCenter.Name = "btnPilotCenter";
            this.btnPilotCenter.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.btnPilotCenter.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(60)))), ((int)(((byte)(100)))));
            this.btnPilotCenter.OnHoverTextColor = System.Drawing.Color.White;
            this.btnPilotCenter.selected = false;
            this.btnPilotCenter.Size = new System.Drawing.Size(238, 48);
            this.btnPilotCenter.TabIndex = 3;
            this.btnPilotCenter.Text = "Pilot Center";
            this.btnPilotCenter.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPilotCenter.Textcolor = System.Drawing.Color.White;
            this.btnPilotCenter.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.btnRefresh.color = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.btnRefresh.colorActive = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.btnRefresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRefresh.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.btnRefresh.ForeColor = System.Drawing.Color.White;
            this.btnRefresh.Image = global::AdminCenter.Properties.Resources.refreshImg;
            this.btnRefresh.ImagePosition = 0;
            this.btnRefresh.ImageZoom = 95;
            this.btnRefresh.LabelPosition = 0;
            this.btnRefresh.LabelText = "";
            this.btnRefresh.Location = new System.Drawing.Point(68, 15);
            this.btnRefresh.Margin = new System.Windows.Forms.Padding(6);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(74, 64);
            this.btnRefresh.TabIndex = 2;
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.Location = new System.Drawing.Point(217, 89);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(73, 17);
            this.lblWelcome.TabIndex = 98;
            this.lblWelcome.Text = "Welcome";
            // 
            // AdminDash
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1149, 656);
            this.Controls.Add(this.lblWelcome);
            this.Controls.Add(this.pMenuBar);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AdminDash";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pMenuBar.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel pMenuBar;
        private System.Windows.Forms.Label lblWelcome;
        private Bunifu.Framework.UI.BunifuTileButton btnRefresh;
        private Bunifu.Framework.UI.BunifuFlatButton btnAssignFlight;
        private Bunifu.Framework.UI.BunifuFlatButton btnPilotCenter;
        private Bunifu.Framework.UI.BunifuFlatButton btnLogBook;
        private Bunifu.Framework.UI.BunifuTileButton btnPilotCenterFrm;
    }
}

