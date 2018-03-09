namespace PilotCenterTSZ.AdminUI
{
    partial class PilotListCtrl
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
            this.lstPilots = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader11 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader12 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader13 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader14 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader15 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader16 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.lblActivePilots = new System.Windows.Forms.Label();
            this.lblInactivePilots = new System.Windows.Forms.Label();
            this.lblTotalPilots = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lstPilots
            // 
            this.lstPilots.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader10,
            this.columnHeader15,
            this.columnHeader11,
            this.columnHeader12,
            this.columnHeader13,
            this.columnHeader14,
            this.columnHeader8,
            this.columnHeader9,
            this.columnHeader16});
            this.lstPilots.FullRowSelect = true;
            this.lstPilots.Location = new System.Drawing.Point(3, 46);
            this.lstPilots.MultiSelect = false;
            this.lstPilots.Name = "lstPilots";
            this.lstPilots.Size = new System.Drawing.Size(908, 479);
            this.lstPilots.TabIndex = 0;
            this.lstPilots.UseCompatibleStateImageBehavior = false;
            this.lstPilots.View = System.Windows.Forms.View.Details;
            this.lstPilots.DoubleClick += new System.EventHandler(this.lstPilots_DoubleClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ID";
            this.columnHeader1.Width = 25;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Callsign";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Name";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Email";
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Join Date";
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Last Activity";
            this.columnHeader6.Width = 83;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Rank";
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Staff Level";
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Staff Team";
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "VatsimID";
            // 
            // columnHeader11
            // 
            this.columnHeader11.Text = "Hours";
            // 
            // columnHeader12
            // 
            this.columnHeader12.Text = "Eps";
            // 
            // columnHeader13
            // 
            this.columnHeader13.Text = "Location";
            // 
            // columnHeader14
            // 
            this.columnHeader14.Text = "Hub";
            // 
            // columnHeader15
            // 
            this.columnHeader15.Text = "Vatsim Rating";
            this.columnHeader15.Width = 98;
            // 
            // columnHeader16
            // 
            this.columnHeader16.Text = "Accout Status";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(19, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Pilot List";
            // 
            // lblActivePilots
            // 
            this.lblActivePilots.AutoSize = true;
            this.lblActivePilots.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblActivePilots.ForeColor = System.Drawing.Color.DarkRed;
            this.lblActivePilots.Location = new System.Drawing.Point(529, 15);
            this.lblActivePilots.Name = "lblActivePilots";
            this.lblActivePilots.Size = new System.Drawing.Size(103, 17);
            this.lblActivePilots.TabIndex = 2;
            this.lblActivePilots.Text = "50 Active Pilots";
            // 
            // lblInactivePilots
            // 
            this.lblInactivePilots.AutoSize = true;
            this.lblInactivePilots.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInactivePilots.ForeColor = System.Drawing.Color.ForestGreen;
            this.lblInactivePilots.Location = new System.Drawing.Point(638, 15);
            this.lblInactivePilots.Name = "lblInactivePilots";
            this.lblInactivePilots.Size = new System.Drawing.Size(113, 17);
            this.lblInactivePilots.TabIndex = 3;
            this.lblInactivePilots.Text = "15 Inactive Pilots";
            // 
            // lblTotalPilots
            // 
            this.lblTotalPilots.AutoSize = true;
            this.lblTotalPilots.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalPilots.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblTotalPilots.Location = new System.Drawing.Point(757, 15);
            this.lblTotalPilots.Name = "lblTotalPilots";
            this.lblTotalPilots.Size = new System.Drawing.Size(108, 17);
            this.lblTotalPilots.TabIndex = 4;
            this.lblTotalPilots.Text = "Total Pilots: 105";
            // 
            // PilotListCtrl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblTotalPilots);
            this.Controls.Add(this.lblInactivePilots);
            this.Controls.Add(this.lblActivePilots);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstPilots);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "PilotListCtrl";
            this.Size = new System.Drawing.Size(914, 528);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lstPilots;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.ColumnHeader columnHeader15;
        private System.Windows.Forms.ColumnHeader columnHeader11;
        private System.Windows.Forms.ColumnHeader columnHeader12;
        private System.Windows.Forms.ColumnHeader columnHeader13;
        private System.Windows.Forms.ColumnHeader columnHeader14;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader16;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblActivePilots;
        private System.Windows.Forms.Label lblInactivePilots;
        private System.Windows.Forms.Label lblTotalPilots;
    }
}
