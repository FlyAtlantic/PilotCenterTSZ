namespace PilotCenterTSZ
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminDash));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pMenuBar = new System.Windows.Forms.Panel();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.lblClock = new System.Windows.Forms.Label();
            this.ClockAdmin = new System.Windows.Forms.Timer(this.components);
            this.btnLogBook = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnAssignFlight = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnPilotList = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnRefresh = new Bunifu.Framework.UI.BunifuTileButton();
            this.btnPilotCenterFrm = new Bunifu.Framework.UI.BunifuTileButton();
            this.btnMinimize = new Bunifu.Framework.UI.BunifuTileButton();
            this.btnExitApp = new Bunifu.Framework.UI.BunifuTileButton();
            this.panel1.SuspendLayout();
            this.pMenuBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.panel1.Controls.Add(this.btnPilotCenterFrm);
            this.panel1.Controls.Add(this.lblTitle);
            this.panel1.Controls.Add(this.btnMinimize);
            this.panel1.Controls.Add(this.btnExitApp);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1149, 77);
            this.panel1.TabIndex = 96;
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
            this.pMenuBar.Controls.Add(this.btnPilotList);
            this.pMenuBar.Controls.Add(this.btnRefresh);
            this.pMenuBar.Dock = System.Windows.Forms.DockStyle.Left;
            this.pMenuBar.Location = new System.Drawing.Point(0, 77);
            this.pMenuBar.Name = "pMenuBar";
            this.pMenuBar.Size = new System.Drawing.Size(211, 579);
            this.pMenuBar.TabIndex = 97;
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
            // lblClock
            // 
            this.lblClock.AutoSize = true;
            this.lblClock.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClock.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblClock.Location = new System.Drawing.Point(961, 86);
            this.lblClock.Name = "lblClock";
            this.lblClock.Size = new System.Drawing.Size(176, 20);
            this.lblClock.TabIndex = 101;
            this.lblClock.Text = "2011-01-07 14:04:25";
            // 
            // ClockAdmin
            // 
            this.ClockAdmin.Interval = 1000;
            this.ClockAdmin.Tick += new System.EventHandler(this.Clock_Tick);
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
            // btnPilotList
            // 
            this.btnPilotList.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(60)))), ((int)(((byte)(100)))));
            this.btnPilotList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.btnPilotList.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPilotList.BorderRadius = 0;
            this.btnPilotList.ButtonText = "Pilot List";
            this.btnPilotList.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPilotList.DisabledColor = System.Drawing.Color.Gray;
            this.btnPilotList.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPilotList.Iconcolor = System.Drawing.Color.Transparent;
            this.btnPilotList.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnPilotList.Iconimage")));
            this.btnPilotList.Iconimage_right = null;
            this.btnPilotList.Iconimage_right_Selected = null;
            this.btnPilotList.Iconimage_Selected = null;
            this.btnPilotList.IconMarginLeft = 0;
            this.btnPilotList.IconMarginRight = 0;
            this.btnPilotList.IconRightVisible = true;
            this.btnPilotList.IconRightZoom = 0D;
            this.btnPilotList.IconVisible = true;
            this.btnPilotList.IconZoom = 90D;
            this.btnPilotList.IsTab = false;
            this.btnPilotList.Location = new System.Drawing.Point(0, 121);
            this.btnPilotList.Name = "btnPilotList";
            this.btnPilotList.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.btnPilotList.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(60)))), ((int)(((byte)(100)))));
            this.btnPilotList.OnHoverTextColor = System.Drawing.Color.White;
            this.btnPilotList.selected = false;
            this.btnPilotList.Size = new System.Drawing.Size(238, 48);
            this.btnPilotList.TabIndex = 3;
            this.btnPilotList.Text = "Pilot List";
            this.btnPilotList.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPilotList.Textcolor = System.Drawing.Color.White;
            this.btnPilotList.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.btnRefresh.color = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.btnRefresh.colorActive = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.btnRefresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRefresh.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.btnRefresh.ForeColor = System.Drawing.Color.White;
            this.btnRefresh.Image = global::PilotCenterTSZ.Properties.Resources.refreshImg;
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
            // btnPilotCenterFrm
            // 
            this.btnPilotCenterFrm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.btnPilotCenterFrm.color = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.btnPilotCenterFrm.colorActive = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.btnPilotCenterFrm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPilotCenterFrm.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.btnPilotCenterFrm.ForeColor = System.Drawing.Color.White;
            this.btnPilotCenterFrm.Image = global::PilotCenterTSZ.Properties.Resources.pilot_resume_256;
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
            // btnMinimize
            // 
            this.btnMinimize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.btnMinimize.color = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.btnMinimize.colorActive = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.btnMinimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMinimize.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.btnMinimize.ForeColor = System.Drawing.Color.White;
            this.btnMinimize.Image = global::PilotCenterTSZ.Properties.Resources.Minimize_Box_Blue;
            this.btnMinimize.ImagePosition = 0;
            this.btnMinimize.ImageZoom = 100;
            this.btnMinimize.LabelPosition = 0;
            this.btnMinimize.LabelText = "";
            this.btnMinimize.Location = new System.Drawing.Point(1046, 5);
            this.btnMinimize.Margin = new System.Windows.Forms.Padding(6);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(40, 40);
            this.btnMinimize.TabIndex = 103;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // btnExitApp
            // 
            this.btnExitApp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.btnExitApp.color = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.btnExitApp.colorActive = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.btnExitApp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExitApp.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.btnExitApp.ForeColor = System.Drawing.Color.White;
            this.btnExitApp.Image = global::PilotCenterTSZ.Properties.Resources._2000px_Oxygen480_actions_system_shutdown_svg;
            this.btnExitApp.ImagePosition = 0;
            this.btnExitApp.ImageZoom = 100;
            this.btnExitApp.LabelPosition = 0;
            this.btnExitApp.LabelText = "";
            this.btnExitApp.Location = new System.Drawing.Point(1094, 6);
            this.btnExitApp.Margin = new System.Windows.Forms.Padding(6);
            this.btnExitApp.Name = "btnExitApp";
            this.btnExitApp.Size = new System.Drawing.Size(40, 40);
            this.btnExitApp.TabIndex = 102;
            this.btnExitApp.Click += new System.EventHandler(this.btnExitApp_Click);
            // 
            // AdminDash
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1149, 656);
            this.Controls.Add(this.lblWelcome);
            this.Controls.Add(this.lblClock);
            this.Controls.Add(this.pMenuBar);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AdminDash";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AdminDash_FormClosed);
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
        private System.Windows.Forms.Label lblClock;
        private Bunifu.Framework.UI.BunifuTileButton btnRefresh;
        private Bunifu.Framework.UI.BunifuFlatButton btnAssignFlight;
        private Bunifu.Framework.UI.BunifuFlatButton btnPilotList;
        private Bunifu.Framework.UI.BunifuFlatButton btnLogBook;
        private Bunifu.Framework.UI.BunifuTileButton btnPilotCenterFrm;
        public Bunifu.Framework.UI.BunifuTileButton btnExitApp;
        public Bunifu.Framework.UI.BunifuTileButton btnMinimize;
        private System.Windows.Forms.Timer ClockAdmin;
    }
}

