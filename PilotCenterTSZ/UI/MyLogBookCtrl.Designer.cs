namespace PilotCenterTSZ.UI
{
    partial class MyLogBookCtrl
    {
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
        private void InitializeComponent()
        {
            this.lstLogBook = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.myFlightView = new PilotCenterTSZ.UI.MyFlightView();
            this.lblDclick = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lstLogBook
            // 
            this.lstLogBook.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8});
            this.lstLogBook.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstLogBook.FullRowSelect = true;
            this.lstLogBook.Location = new System.Drawing.Point(214, 3);
            this.lstLogBook.MultiSelect = false;
            this.lstLogBook.Name = "lstLogBook";
            this.lstLogBook.Size = new System.Drawing.Size(506, 460);
            this.lstLogBook.TabIndex = 0;
            this.lstLogBook.UseCompatibleStateImageBehavior = false;
            this.lstLogBook.View = System.Windows.Forms.View.Details;
            this.lstLogBook.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lstLogBook_MouseDoubleClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Callsign";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Departure";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Arrival";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Aircraft";
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "FlightTime";
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Ldg. Rate";
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Overall";
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Ep\'s";
            // 
            // myFlightView
            // 
            this.myFlightView.Location = new System.Drawing.Point(0, 16);
            this.myFlightView.Name = "myFlightView";
            this.myFlightView.Size = new System.Drawing.Size(930, 560);
            this.myFlightView.TabIndex = 1;
            this.myFlightView.Visible = false;
            // 
            // lblDclick
            // 
            this.lblDclick.AutoSize = true;
            this.lblDclick.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDclick.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblDclick.Location = new System.Drawing.Point(365, 481);
            this.lblDclick.Name = "lblDclick";
            this.lblDclick.Size = new System.Drawing.Size(205, 17);
            this.lblDclick.TabIndex = 2;
            this.lblDclick.Text = "Double-Click for Flight Preview.";
            // 
            // MyLogBookCtrl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblDclick);
            this.Controls.Add(this.myFlightView);
            this.Controls.Add(this.lstLogBook);
            this.Name = "MyLogBookCtrl";
            this.Size = new System.Drawing.Size(925, 560);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion
        public System.Windows.Forms.ListView lstLogBook;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private MyFlightView myFlightView;
        public System.Windows.Forms.Label lblDclick;
    }
}