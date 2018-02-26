namespace PilotCenterTSZ
{
    partial class Dashboard
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pBarFlightTimeEnd = new Bunifu.Framework.UI.BunifuProgressBar();
            this.pilotAccountCtrl = new PilotCenterTSZ.UI.PilotAccountCtrl();
            this.btnAdminCenterFrm = new Bunifu.Framework.UI.BunifuTileButton();
            this.lblFlightAlert = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pMenuBar = new System.Windows.Forms.Panel();
            this.btnCarrer = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnLogBook = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnAssignFlight = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnPilotCenter = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnRefresh = new Bunifu.Framework.UI.BunifuTileButton();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.VerifyAndDeleteFlight = new System.Windows.Forms.Timer(this.components);
            this.FlightTimeEndTick = new System.Windows.Forms.Timer(this.components);
            this.myLogBookCtrl = new PilotCenterTSZ.UI.MyLogBookCtrl();
            this.flightAssignmentCtrl = new PilotCenterTSZ.UI.FlightAssignmentCtrl();
            this.pilotCarrer = new PilotCenterTSZ.UI.PilotCarrer();
            this.panel1.SuspendLayout();
            this.pMenuBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pBarFlightTimeEnd);
            this.panel1.Controls.Add(this.btnAdminCenterFrm);
            this.panel1.Controls.Add(this.lblFlightAlert);
            this.panel1.Controls.Add(this.lblTitle);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1149, 77);
            this.panel1.TabIndex = 96;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(631, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 17);
            this.label1.TabIndex = 102;
            this.label1.Text = "Flight Expire:";
            this.label1.Visible = false;
            // 
            // pBarFlightTimeEnd
            // 
            this.pBarFlightTimeEnd.BackColor = System.Drawing.Color.Silver;
            this.pBarFlightTimeEnd.BorderRadius = 5;
            this.pBarFlightTimeEnd.Location = new System.Drawing.Point(727, 21);
            this.pBarFlightTimeEnd.MaximumValue = 100;
            this.pBarFlightTimeEnd.Name = "pBarFlightTimeEnd";
            this.pBarFlightTimeEnd.ProgressColor = System.Drawing.Color.Teal;
            this.pBarFlightTimeEnd.Size = new System.Drawing.Size(410, 21);
            this.pBarFlightTimeEnd.TabIndex = 101;
            this.pBarFlightTimeEnd.Value = 0;
            this.pBarFlightTimeEnd.Visible = false;
            // 
            // btnAdminCenterFrm
            // 
            this.btnAdminCenterFrm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.btnAdminCenterFrm.color = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.btnAdminCenterFrm.colorActive = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.btnAdminCenterFrm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdminCenterFrm.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.btnAdminCenterFrm.ForeColor = System.Drawing.Color.White;
            this.btnAdminCenterFrm.Image = global::PilotCenterTSZ.Properties.Resources.refreshImg;
            this.btnAdminCenterFrm.ImagePosition = 0;
            this.btnAdminCenterFrm.ImageZoom = 95;
            this.btnAdminCenterFrm.LabelPosition = 0;
            this.btnAdminCenterFrm.LabelText = "";
            this.btnAdminCenterFrm.Location = new System.Drawing.Point(510, 18);
            this.btnAdminCenterFrm.Margin = new System.Windows.Forms.Padding(6);
            this.btnAdminCenterFrm.Name = "btnAdminCenterFrm";
            this.btnAdminCenterFrm.Size = new System.Drawing.Size(39, 39);
            this.btnAdminCenterFrm.TabIndex = 6;
            this.btnAdminCenterFrm.Click += new System.EventHandler(this.btnAdminCenterFrm_Click);
            this.btnAdminCenterFrm.Visible = false;
            // 
            // lblFlightAlert
            // 
            this.lblFlightAlert.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFlightAlert.ForeColor = System.Drawing.Color.Red;
            this.lblFlightAlert.Location = new System.Drawing.Point(248, 48);
            this.lblFlightAlert.Name = "lblFlightAlert";
            this.lblFlightAlert.Size = new System.Drawing.Size(889, 29);
            this.lblFlightAlert.TabIndex = 100;
            this.lblFlightAlert.Text = "Welcome";
            this.lblFlightAlert.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.lblFlightAlert.Visible = false;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblTitle.Location = new System.Drawing.Point(19, 18);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(220, 24);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "FlyAtlantic Pilot Center";
            // 
            // pMenuBar
            // 
            this.pMenuBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.pMenuBar.Controls.Add(this.btnCarrer);
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
            // btnCarrer
            // 
            this.btnCarrer.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(60)))), ((int)(((byte)(100)))));
            this.btnCarrer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.btnCarrer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCarrer.BorderRadius = 0;
            this.btnCarrer.ButtonText = "Pilot Carrer";
            this.btnCarrer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCarrer.DisabledColor = System.Drawing.Color.Gray;
            this.btnCarrer.Iconcolor = System.Drawing.Color.Transparent;
            this.btnCarrer.Iconimage = global::PilotCenterTSZ.Properties.Resources.button_ok;
            this.btnCarrer.Iconimage_right = null;
            this.btnCarrer.Iconimage_right_Selected = null;
            this.btnCarrer.Iconimage_Selected = null;
            this.btnCarrer.IconMarginLeft = 0;
            this.btnCarrer.IconMarginRight = 0;
            this.btnCarrer.IconRightVisible = true;
            this.btnCarrer.IconRightZoom = 0D;
            this.btnCarrer.IconVisible = true;
            this.btnCarrer.IconZoom = 90D;
            this.btnCarrer.IsTab = false;
            this.btnCarrer.Location = new System.Drawing.Point(0, 265);
            this.btnCarrer.Name = "btnCarrer";
            this.btnCarrer.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.btnCarrer.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(60)))), ((int)(((byte)(100)))));
            this.btnCarrer.OnHoverTextColor = System.Drawing.Color.White;
            this.btnCarrer.selected = false;
            this.btnCarrer.Size = new System.Drawing.Size(241, 48);
            this.btnCarrer.TabIndex = 9;
            this.btnCarrer.Text = "Pilot Carrer";
            this.btnCarrer.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCarrer.Textcolor = System.Drawing.Color.White;
            this.btnCarrer.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCarrer.Click += new System.EventHandler(this.btnCarrer_Click);
            // 
            // btnLogBook
            // 
            this.btnLogBook.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(60)))), ((int)(((byte)(100)))));
            this.btnLogBook.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.btnLogBook.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLogBook.BorderRadius = 0;
            this.btnLogBook.ButtonText = "Logbook";
            this.btnLogBook.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogBook.DisabledColor = System.Drawing.Color.Gray;
            this.btnLogBook.Iconcolor = System.Drawing.Color.Transparent;
            this.btnLogBook.Iconimage = global::PilotCenterTSZ.Properties.Resources.button_ok;
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
            this.btnLogBook.Location = new System.Drawing.Point(0, 220);
            this.btnLogBook.Name = "btnLogBook";
            this.btnLogBook.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.btnLogBook.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(60)))), ((int)(((byte)(100)))));
            this.btnLogBook.OnHoverTextColor = System.Drawing.Color.White;
            this.btnLogBook.selected = false;
            this.btnLogBook.Size = new System.Drawing.Size(241, 48);
            this.btnLogBook.TabIndex = 8;
            this.btnLogBook.Text = "Logbook";
            this.btnLogBook.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogBook.Textcolor = System.Drawing.Color.White;
            this.btnLogBook.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogBook.Click += new System.EventHandler(this.btnLogBook_Click);
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
            this.btnAssignFlight.Iconcolor = System.Drawing.Color.Transparent;
            this.btnAssignFlight.Iconimage = global::PilotCenterTSZ.Properties.Resources.button_ok;
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
            this.btnAssignFlight.Size = new System.Drawing.Size(241, 48);
            this.btnAssignFlight.TabIndex = 7;
            this.btnAssignFlight.Text = "Flight Assignment";
            this.btnAssignFlight.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAssignFlight.Textcolor = System.Drawing.Color.White;
            this.btnAssignFlight.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAssignFlight.Click += new System.EventHandler(this.btnAssignFlight_Click);
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
            this.btnPilotCenter.Iconcolor = System.Drawing.Color.Transparent;
            this.btnPilotCenter.Iconimage = global::PilotCenterTSZ.Properties.Resources.button_ok;
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
            this.btnPilotCenter.Location = new System.Drawing.Point(0, 130);
            this.btnPilotCenter.Name = "btnPilotCenter";
            this.btnPilotCenter.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.btnPilotCenter.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(60)))), ((int)(((byte)(100)))));
            this.btnPilotCenter.OnHoverTextColor = System.Drawing.Color.White;
            this.btnPilotCenter.selected = false;
            this.btnPilotCenter.Size = new System.Drawing.Size(241, 48);
            this.btnPilotCenter.TabIndex = 6;
            this.btnPilotCenter.Text = "Pilot Center";
            this.btnPilotCenter.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPilotCenter.Textcolor = System.Drawing.Color.White;
            this.btnPilotCenter.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPilotCenter.Click += new System.EventHandler(this.btnPilotCenter_Click);
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
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
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
            // VerifyAndDeleteFlight
            // 
            this.VerifyAndDeleteFlight.Interval = 10000;
            this.VerifyAndDeleteFlight.Tick += new System.EventHandler(this.VerifyAndDeleteFlight_Tick);
            // 
            // FlightTimeEndTick
            // 
            this.FlightTimeEndTick.Interval = 1000;
            this.FlightTimeEndTick.Tick += new System.EventHandler(this.FlightTimeEndTick_Tick);
            // 
            // myLogBookCtrl
            // 
            this.myLogBookCtrl.Location = new System.Drawing.Point(214, 131);
            this.myLogBookCtrl.Name = "myLogBookCtrl";
            this.myLogBookCtrl.Size = new System.Drawing.Size(925, 560);
            this.myLogBookCtrl.TabIndex = 99;
            this.myLogBookCtrl.Visible = false;
            // 
            // flightAssignmentCtrl
            // 
            this.flightAssignmentCtrl.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.flightAssignmentCtrl.Location = new System.Drawing.Point(214, 156);
            this.flightAssignmentCtrl.Name = "flightAssignmentCtrl";
            this.flightAssignmentCtrl.Size = new System.Drawing.Size(935, 500);
            this.flightAssignmentCtrl.TabIndex = 99;
            this.flightAssignmentCtrl.Visible = false;
            // 
            // pilotCarrer
            // 
            this.pilotCarrer.Location = new System.Drawing.Point(214, 116);
            this.pilotCarrer.Name = "pilotCarrer";
            this.pilotCarrer.Size = new System.Drawing.Size(925, 528);
            this.pilotCarrer.TabIndex = 100;
            this.pilotCarrer.Visible = false;
            // 
            // pilotAccountCtrl
            // 
            this.pilotAccountCtrl.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pilotAccountCtrl.Location = new System.Drawing.Point(214, 123);
            this.pilotAccountCtrl.Name = "pilotAccountCtrl1";
            this.pilotAccountCtrl.Size = new System.Drawing.Size(935, 500);
            this.pilotAccountCtrl.TabIndex = 99;
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1149, 656);
            this.Controls.Add(this.pilotCarrer);
            this.Controls.Add(this.myLogBookCtrl);
            this.Controls.Add(this.pilotAccountCtrl);
            this.Controls.Add(this.flightAssignmentCtrl);
            this.Controls.Add(this.lblWelcome);
            this.Controls.Add(this.pMenuBar);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Dashboard_FormClosing);
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
        private UI.PilotAccountCtrl pilotAccountCtrl;
        private Bunifu.Framework.UI.BunifuTileButton btnRefresh;
        private UI.FlightAssignmentCtrl flightAssignmentCtrl;
        private System.Windows.Forms.Timer VerifyAndDeleteFlight;
        public System.Windows.Forms.Label lblFlightAlert;
        private Bunifu.Framework.UI.BunifuProgressBar pBarFlightTimeEnd;
        private System.Windows.Forms.Timer FlightTimeEndTick;
        private System.Windows.Forms.Label label1;
        private UI.MyLogBookCtrl myLogBookCtrl;
        private Bunifu.Framework.UI.BunifuTileButton btnAdminCenterFrm;
        private Bunifu.Framework.UI.BunifuFlatButton btnLogBook;
        private Bunifu.Framework.UI.BunifuFlatButton btnAssignFlight;
        private Bunifu.Framework.UI.BunifuFlatButton btnPilotCenter;
        private Bunifu.Framework.UI.BunifuFlatButton btnCarrer;
        private UI.PilotCarrer pilotCarrer;
    }
}

