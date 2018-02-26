namespace PilotCenterTSZ.UI
{
    partial class PilotAccountCtrl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PilotAccountCtrl));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.gBoxProfile = new System.Windows.Forms.GroupBox();
            this.imgRank = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lblEps = new System.Windows.Forms.Label();
            this.lblLocation = new System.Windows.Forms.Label();
            this.lblHub = new System.Windows.Forms.Label();
            this.lblLastFlightDate = new System.Windows.Forms.Label();
            this.lblFlightHours = new System.Windows.Forms.Label();
            this.lblRatingVacc = new System.Windows.Forms.Label();
            this.lblCallsign = new System.Windows.Forms.Label();
            this.lblRank = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gBoxTypeRatings = new System.Windows.Forms.GroupBox();
            this.listTyperatings = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.gBoxQualifications = new System.Windows.Forms.GroupBox();
            this.listQualifications = new System.Windows.Forms.ListView();
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lblOverall = new System.Windows.Forms.Label();
            this.lblHourAward = new System.Windows.Forms.Label();
            this.cProgressHourAward = new Bunifu.Framework.UI.BunifuCircleProgressbar();
            this.cProgressBarOverall = new Bunifu.Framework.UI.BunifuCircleProgressbar();
            this.awardHourReceive = new PilotCenterTSZ.UI.AwardHourReceive();
            this.chartFlightsDay = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.gBoxProfile.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgRank)).BeginInit();
            this.gBoxTypeRatings.SuspendLayout();
            this.gBoxQualifications.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartFlightsDay)).BeginInit();
            this.SuspendLayout();
            // 
            // gBoxProfile
            // 
            this.gBoxProfile.Controls.Add(this.imgRank);
            this.gBoxProfile.Controls.Add(this.label4);
            this.gBoxProfile.Controls.Add(this.lblEps);
            this.gBoxProfile.Controls.Add(this.lblLocation);
            this.gBoxProfile.Controls.Add(this.lblHub);
            this.gBoxProfile.Controls.Add(this.lblLastFlightDate);
            this.gBoxProfile.Controls.Add(this.lblFlightHours);
            this.gBoxProfile.Controls.Add(this.lblRatingVacc);
            this.gBoxProfile.Controls.Add(this.lblCallsign);
            this.gBoxProfile.Controls.Add(this.lblRank);
            this.gBoxProfile.Controls.Add(this.lblName);
            this.gBoxProfile.Controls.Add(this.label9);
            this.gBoxProfile.Controls.Add(this.label8);
            this.gBoxProfile.Controls.Add(this.label7);
            this.gBoxProfile.Controls.Add(this.label6);
            this.gBoxProfile.Controls.Add(this.label5);
            this.gBoxProfile.Controls.Add(this.label3);
            this.gBoxProfile.Controls.Add(this.label2);
            this.gBoxProfile.Controls.Add(this.label1);
            this.gBoxProfile.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gBoxProfile.Location = new System.Drawing.Point(14, 23);
            this.gBoxProfile.Name = "gBoxProfile";
            this.gBoxProfile.Size = new System.Drawing.Size(253, 303);
            this.gBoxProfile.TabIndex = 0;
            this.gBoxProfile.TabStop = false;
            this.gBoxProfile.Text = "Profile";
            // 
            // imgRank
            // 
            this.imgRank.Location = new System.Drawing.Point(78, 26);
            this.imgRank.Name = "imgRank";
            this.imgRank.Size = new System.Drawing.Size(100, 30);
            this.imgRank.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgRank.TabIndex = 19;
            this.imgRank.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label4.Location = new System.Drawing.Point(6, 149);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(147, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Portugal VACC Rating:";
            // 
            // lblEps
            // 
            this.lblEps.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblEps.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEps.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblEps.Location = new System.Drawing.Point(111, 268);
            this.lblEps.Name = "lblEps";
            this.lblEps.Size = new System.Drawing.Size(136, 17);
            this.lblEps.TabIndex = 17;
            this.lblEps.Text = "label18";
            this.lblEps.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblLocation
            // 
            this.lblLocation.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblLocation.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLocation.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblLocation.Location = new System.Drawing.Point(111, 244);
            this.lblLocation.Name = "lblLocation";
            this.lblLocation.Size = new System.Drawing.Size(136, 17);
            this.lblLocation.TabIndex = 16;
            this.lblLocation.Text = "label17";
            this.lblLocation.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblHub
            // 
            this.lblHub.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblHub.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHub.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblHub.Location = new System.Drawing.Point(111, 220);
            this.lblHub.Name = "lblHub";
            this.lblHub.Size = new System.Drawing.Size(136, 17);
            this.lblHub.TabIndex = 15;
            this.lblHub.Text = "label16";
            this.lblHub.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblLastFlightDate
            // 
            this.lblLastFlightDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblLastFlightDate.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLastFlightDate.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblLastFlightDate.Location = new System.Drawing.Point(111, 197);
            this.lblLastFlightDate.Name = "lblLastFlightDate";
            this.lblLastFlightDate.Size = new System.Drawing.Size(136, 17);
            this.lblLastFlightDate.TabIndex = 14;
            this.lblLastFlightDate.Text = "label15";
            this.lblLastFlightDate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblFlightHours
            // 
            this.lblFlightHours.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFlightHours.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFlightHours.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblFlightHours.Location = new System.Drawing.Point(111, 173);
            this.lblFlightHours.Name = "lblFlightHours";
            this.lblFlightHours.Size = new System.Drawing.Size(136, 17);
            this.lblFlightHours.TabIndex = 13;
            this.lblFlightHours.Text = "label14";
            this.lblFlightHours.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblRatingVacc
            // 
            this.lblRatingVacc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblRatingVacc.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRatingVacc.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblRatingVacc.Location = new System.Drawing.Point(111, 149);
            this.lblRatingVacc.Name = "lblRatingVacc";
            this.lblRatingVacc.Size = new System.Drawing.Size(136, 17);
            this.lblRatingVacc.TabIndex = 12;
            this.lblRatingVacc.Text = "label13";
            this.lblRatingVacc.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblCallsign
            // 
            this.lblCallsign.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCallsign.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCallsign.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblCallsign.Location = new System.Drawing.Point(111, 125);
            this.lblCallsign.Name = "lblCallsign";
            this.lblCallsign.Size = new System.Drawing.Size(136, 17);
            this.lblCallsign.TabIndex = 11;
            this.lblCallsign.Text = "label12";
            this.lblCallsign.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblRank
            // 
            this.lblRank.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblRank.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRank.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblRank.Location = new System.Drawing.Point(111, 101);
            this.lblRank.Name = "lblRank";
            this.lblRank.Size = new System.Drawing.Size(136, 17);
            this.lblRank.TabIndex = 10;
            this.lblRank.Text = "label11";
            this.lblRank.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblName
            // 
            this.lblName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblName.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblName.Location = new System.Drawing.Point(114, 77);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(133, 17);
            this.lblName.TabIndex = 9;
            this.lblName.Text = "label10";
            this.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.label9.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label9.Location = new System.Drawing.Point(6, 268);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(114, 17);
            this.label9.TabIndex = 8;
            this.label9.Text = "Efficiency Points:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.label8.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label8.Location = new System.Drawing.Point(6, 244);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(115, 17);
            this.label8.TabIndex = 7;
            this.label8.Text = "Current Location:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label7.Location = new System.Drawing.Point(6, 220);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 17);
            this.label7.TabIndex = 6;
            this.label7.Text = "Your HUB:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label6.Location = new System.Drawing.Point(6, 197);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(110, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "Last Flight Date:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label5.Location = new System.Drawing.Point(6, 173);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Flight Hours:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label3.Location = new System.Drawing.Point(6, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Callsign:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label2.Location = new System.Drawing.Point(6, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ranking:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(6, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name:";
            // 
            // gBoxTypeRatings
            // 
            this.gBoxTypeRatings.Controls.Add(this.listTyperatings);
            this.gBoxTypeRatings.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gBoxTypeRatings.Location = new System.Drawing.Point(293, 23);
            this.gBoxTypeRatings.Name = "gBoxTypeRatings";
            this.gBoxTypeRatings.Size = new System.Drawing.Size(307, 303);
            this.gBoxTypeRatings.TabIndex = 18;
            this.gBoxTypeRatings.TabStop = false;
            this.gBoxTypeRatings.Text = "TypeRatings";
            // 
            // listTyperatings
            // 
            this.listTyperatings.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.listTyperatings.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listTyperatings.FullRowSelect = true;
            this.listTyperatings.Location = new System.Drawing.Point(6, 34);
            this.listTyperatings.MultiSelect = false;
            this.listTyperatings.Name = "listTyperatings";
            this.listTyperatings.Scrollable = false;
            this.listTyperatings.Size = new System.Drawing.Size(295, 263);
            this.listTyperatings.TabIndex = 0;
            this.listTyperatings.UseCompatibleStateImageBehavior = false;
            this.listTyperatings.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "TypeRating";
            this.columnHeader1.Width = 130;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Validation";
            this.columnHeader2.Width = 76;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Expiration";
            this.columnHeader3.Width = 86;
            // 
            // gBoxQualifications
            // 
            this.gBoxQualifications.Controls.Add(this.listQualifications);
            this.gBoxQualifications.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gBoxQualifications.Location = new System.Drawing.Point(606, 23);
            this.gBoxQualifications.Name = "gBoxQualifications";
            this.gBoxQualifications.Size = new System.Drawing.Size(307, 303);
            this.gBoxQualifications.TabIndex = 19;
            this.gBoxQualifications.TabStop = false;
            this.gBoxQualifications.Text = "Qualifications";
            // 
            // listQualifications
            // 
            this.listQualifications.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.listQualifications.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listQualifications.FullRowSelect = true;
            this.listQualifications.Location = new System.Drawing.Point(6, 34);
            this.listQualifications.MultiSelect = false;
            this.listQualifications.Name = "listQualifications";
            this.listQualifications.Scrollable = false;
            this.listQualifications.Size = new System.Drawing.Size(295, 263);
            this.listQualifications.TabIndex = 0;
            this.listQualifications.UseCompatibleStateImageBehavior = false;
            this.listQualifications.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Qualification";
            this.columnHeader4.Width = 130;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Validation";
            this.columnHeader5.Width = 76;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Expiration";
            this.columnHeader6.Width = 86;
            // 
            // lblOverall
            // 
            this.lblOverall.AutoSize = true;
            this.lblOverall.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOverall.ForeColor = System.Drawing.Color.Chocolate;
            this.lblOverall.Location = new System.Drawing.Point(26, 346);
            this.lblOverall.Name = "lblOverall";
            this.lblOverall.Size = new System.Drawing.Size(104, 15);
            this.lblOverall.TabIndex = 103;
            this.lblOverall.Text = "Overall Efficiency";
            // 
            // lblHourAward
            // 
            this.lblHourAward.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHourAward.ForeColor = System.Drawing.Color.Chocolate;
            this.lblHourAward.Location = new System.Drawing.Point(152, 344);
            this.lblHourAward.Name = "lblHourAward";
            this.lblHourAward.Size = new System.Drawing.Size(132, 15);
            this.lblHourAward.TabIndex = 105;
            this.lblHourAward.Text = "XX Hour Award";
            this.lblHourAward.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cProgressHourAward
            // 
            this.cProgressHourAward.animated = false;
            this.cProgressHourAward.animationIterval = 5;
            this.cProgressHourAward.animationSpeed = 300;
            this.cProgressHourAward.BackColor = System.Drawing.Color.Transparent;
            this.cProgressHourAward.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cProgressHourAward.BackgroundImage")));
            this.cProgressHourAward.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cProgressHourAward.ForeColor = System.Drawing.Color.SeaGreen;
            this.cProgressHourAward.LabelVisible = true;
            this.cProgressHourAward.LineProgressThickness = 8;
            this.cProgressHourAward.LineThickness = 5;
            this.cProgressHourAward.Location = new System.Drawing.Point(155, 365);
            this.cProgressHourAward.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.cProgressHourAward.MaxValue = 100;
            this.cProgressHourAward.Name = "cProgressHourAward";
            this.cProgressHourAward.ProgressBackColor = System.Drawing.Color.Gainsboro;
            this.cProgressHourAward.ProgressColor = System.Drawing.Color.SeaGreen;
            this.cProgressHourAward.Size = new System.Drawing.Size(129, 129);
            this.cProgressHourAward.TabIndex = 104;
            this.cProgressHourAward.Value = 0;
            // 
            // cProgressBarOverall
            // 
            this.cProgressBarOverall.animated = false;
            this.cProgressBarOverall.animationIterval = 5;
            this.cProgressBarOverall.animationSpeed = 300;
            this.cProgressBarOverall.BackColor = System.Drawing.Color.Transparent;
            this.cProgressBarOverall.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cProgressBarOverall.BackgroundImage")));
            this.cProgressBarOverall.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cProgressBarOverall.ForeColor = System.Drawing.Color.SeaGreen;
            this.cProgressBarOverall.LabelVisible = true;
            this.cProgressBarOverall.LineProgressThickness = 8;
            this.cProgressBarOverall.LineThickness = 5;
            this.cProgressBarOverall.Location = new System.Drawing.Point(14, 365);
            this.cProgressBarOverall.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.cProgressBarOverall.MaxValue = 100;
            this.cProgressBarOverall.Name = "cProgressBarOverall";
            this.cProgressBarOverall.ProgressBackColor = System.Drawing.Color.Gainsboro;
            this.cProgressBarOverall.ProgressColor = System.Drawing.Color.SeaGreen;
            this.cProgressBarOverall.Size = new System.Drawing.Size(129, 129);
            this.cProgressBarOverall.TabIndex = 102;
            this.cProgressBarOverall.Value = 0;
            // 
            // awardHourReceive
            // 
            this.awardHourReceive.AwardEps = 0;
            this.awardHourReceive.AwardID = 0;
            this.awardHourReceive.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.awardHourReceive.Location = new System.Drawing.Point(144, 87);
            this.awardHourReceive.Name = "awardHourReceive";
            this.awardHourReceive.Size = new System.Drawing.Size(646, 325);
            this.awardHourReceive.TabIndex = 106;
            this.awardHourReceive.Visible = false;
            // 
            // chartFlightsDay
            // 
            chartArea1.Name = "ChartArea1";
            this.chartFlightsDay.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartFlightsDay.Legends.Add(legend1);
            this.chartFlightsDay.Location = new System.Drawing.Point(293, 332);
            this.chartFlightsDay.Name = "chartFlightsDay";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartFlightsDay.Series.Add(series1);
            this.chartFlightsDay.Size = new System.Drawing.Size(620, 162);
            this.chartFlightsDay.TabIndex = 107;
            this.chartFlightsDay.Text = "chart1";
            // 
            // PilotAccountCtrl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.awardHourReceive);
            this.Controls.Add(this.chartFlightsDay);
            this.Controls.Add(this.lblHourAward);
            this.Controls.Add(this.cProgressHourAward);
            this.Controls.Add(this.lblOverall);
            this.Controls.Add(this.gBoxQualifications);
            this.Controls.Add(this.cProgressBarOverall);
            this.Controls.Add(this.gBoxTypeRatings);
            this.Controls.Add(this.gBoxProfile);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "PilotAccountCtrl";
            this.Size = new System.Drawing.Size(935, 500);
            this.gBoxProfile.ResumeLayout(false);
            this.gBoxProfile.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgRank)).EndInit();
            this.gBoxTypeRatings.ResumeLayout(false);
            this.gBoxQualifications.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartFlightsDay)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gBoxProfile;
        private System.Windows.Forms.Label lblEps;
        private System.Windows.Forms.Label lblLocation;
        private System.Windows.Forms.Label lblHub;
        private System.Windows.Forms.Label lblLastFlightDate;
        private System.Windows.Forms.Label lblFlightHours;
        private System.Windows.Forms.Label lblRatingVacc;
        private System.Windows.Forms.Label lblCallsign;
        private System.Windows.Forms.Label lblRank;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gBoxTypeRatings;
        private System.Windows.Forms.ListView listTyperatings;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.PictureBox imgRank;
        private System.Windows.Forms.GroupBox gBoxQualifications;
        private System.Windows.Forms.ListView listQualifications;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.Label lblOverall;
        private Bunifu.Framework.UI.BunifuCircleProgressbar cProgressBarOverall;
        private System.Windows.Forms.Label lblHourAward;
        private Bunifu.Framework.UI.BunifuCircleProgressbar cProgressHourAward;
        private AwardHourReceive awardHourReceive;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartFlightsDay;
    }
}
