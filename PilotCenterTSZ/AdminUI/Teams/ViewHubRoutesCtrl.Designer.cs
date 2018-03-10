namespace PilotCenterTSZ.AdminUI.Teams
{
    partial class ViewHubRoutesCtrl
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
            this.btnBack = new System.Windows.Forms.Button();
            this.cboxTyperatings = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lstFlights
            // 
            this.lstFlights.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader9,
            this.columnHeader10,
            this.columnHeader11});
            this.lstFlights.FullRowSelect = true;
            this.lstFlights.Location = new System.Drawing.Point(12, 63);
            this.lstFlights.MultiSelect = false;
            this.lstFlights.Name = "lstFlights";
            this.lstFlights.Size = new System.Drawing.Size(732, 316);
            this.lstFlights.TabIndex = 0;
            this.lstFlights.UseCompatibleStateImageBehavior = false;
            this.lstFlights.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Callsign";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Aircraft";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Departure";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Arrival";
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Alternate";
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Route";
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Altitude";
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Flight Time";
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Briefing";
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "Qualification";
            // 
            // columnHeader11
            // 
            this.columnHeader11.Text = "HUB";
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(669, 385);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 1;
            this.btnBack.Text = "<< Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // cboxTyperatings
            // 
            this.cboxTyperatings.FormattingEnabled = true;
            this.cboxTyperatings.Location = new System.Drawing.Point(92, 18);
            this.cboxTyperatings.Name = "cboxTyperatings";
            this.cboxTyperatings.Size = new System.Drawing.Size(121, 21);
            this.cboxTyperatings.TabIndex = 11;
            this.cboxTyperatings.SelectedIndexChanged += new System.EventHandler(this.cboxTyperatings_SelectedIndexChanged);
            // 
            // ViewHubRoutesCtrl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.cboxTyperatings);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.lstFlights);
            this.Name = "ViewHubRoutesCtrl";
            this.Size = new System.Drawing.Size(908, 479);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lstFlights;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.ColumnHeader columnHeader11;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.ComboBox cboxTyperatings;
    }
}
