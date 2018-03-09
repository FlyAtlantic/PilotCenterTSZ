namespace PilotCenterTSZ.AdminUI
{
    partial class AllFlightsCtrl
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
            this.lstFlights = new System.Windows.Forms.ListView();
            this.columnHeader17 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader18 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader19 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader20 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader21 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader22 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader23 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader24 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader25 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader26 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader27 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.lblTotalFlights = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lstFlights
            // 
            this.lstFlights.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader17,
            this.columnHeader18,
            this.columnHeader19,
            this.columnHeader20,
            this.columnHeader21,
            this.columnHeader22,
            this.columnHeader23,
            this.columnHeader24,
            this.columnHeader25,
            this.columnHeader26,
            this.columnHeader27});
            this.lstFlights.FullRowSelect = true;
            this.lstFlights.Location = new System.Drawing.Point(3, 46);
            this.lstFlights.MultiSelect = false;
            this.lstFlights.Name = "lstFlights";
            this.lstFlights.Size = new System.Drawing.Size(908, 479);
            this.lstFlights.TabIndex = 1;
            this.lstFlights.UseCompatibleStateImageBehavior = false;
            this.lstFlights.View = System.Windows.Forms.View.Details;
            this.lstFlights.SelectedIndexChanged += new System.EventHandler(this.lstFlights_SelectedIndexChanged);
            // 
            // columnHeader17
            // 
            this.columnHeader17.Text = "ID";
            // 
            // columnHeader18
            // 
            this.columnHeader18.Text = "Date";
            // 
            // columnHeader19
            // 
            this.columnHeader19.Text = "User";
            // 
            // columnHeader20
            // 
            this.columnHeader20.Text = "Callsign";
            // 
            // columnHeader21
            // 
            this.columnHeader21.Text = "Dep";
            // 
            // columnHeader22
            // 
            this.columnHeader22.Text = "Arr";
            // 
            // columnHeader23
            // 
            this.columnHeader23.Text = "Aircraft";
            // 
            // columnHeader24
            // 
            this.columnHeader24.Text = "Touch";
            // 
            // columnHeader25
            // 
            this.columnHeader25.Text = "Sum";
            // 
            // columnHeader26
            // 
            this.columnHeader26.Text = "Eps";
            // 
            // columnHeader27
            // 
            this.columnHeader27.Text = "Obs";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(19, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "All Flights";
            // 
            // lblTotalFlights
            // 
            this.lblTotalFlights.AutoSize = true;
            this.lblTotalFlights.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalFlights.ForeColor = System.Drawing.Color.DarkRed;
            this.lblTotalFlights.Location = new System.Drawing.Point(777, 15);
            this.lblTotalFlights.Name = "lblTotalFlights";
            this.lblTotalFlights.Size = new System.Drawing.Size(122, 17);
            this.lblTotalFlights.TabIndex = 3;
            this.lblTotalFlights.Text = "Total Flights: 1000";
            // 
            // AllFlightsCtrl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblTotalFlights);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstFlights);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Name = "AllFlightsCtrl";
            this.Size = new System.Drawing.Size(914, 528);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lstFlights;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ColumnHeader columnHeader17;
        private System.Windows.Forms.ColumnHeader columnHeader18;
        private System.Windows.Forms.ColumnHeader columnHeader19;
        private System.Windows.Forms.ColumnHeader columnHeader20;
        private System.Windows.Forms.ColumnHeader columnHeader21;
        private System.Windows.Forms.ColumnHeader columnHeader22;
        private System.Windows.Forms.ColumnHeader columnHeader23;
        private System.Windows.Forms.ColumnHeader columnHeader24;
        private System.Windows.Forms.ColumnHeader columnHeader25;
        private System.Windows.Forms.ColumnHeader columnHeader26;
        private System.Windows.Forms.ColumnHeader columnHeader27;
        private System.Windows.Forms.Label lblTotalFlights;
    }
}
