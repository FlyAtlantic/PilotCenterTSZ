namespace PilotCenterTSZ.UI
{
    partial class FlightAssignmentCtrl
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
            this.assingmentCtrl = new PilotCenterTSZ.UI.AssingmentCtrl();
            this.flightAssignedCtrl = new PilotCenterTSZ.UI.FlightAssignedCtrl();
            this.SuspendLayout();
            // 
            // assingmentCtrl
            // 
            this.assingmentCtrl.Location = new System.Drawing.Point(213, 35);
            this.assingmentCtrl.Name = "assingmentCtrl";
            this.assingmentCtrl.Size = new System.Drawing.Size(496, 267);
            this.assingmentCtrl.TabIndex = 0;
            this.assingmentCtrl.Visible = false;
            // 
            // flightAssignedCtrl
            // 
            this.flightAssignedCtrl.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.flightAssignedCtrl.Location = new System.Drawing.Point(237, 59);
            this.flightAssignedCtrl.Name = "flightAssignedCtrl";
            this.flightAssignedCtrl.Size = new System.Drawing.Size(420, 243);
            this.flightAssignedCtrl.TabIndex = 1;
            // 
            // FlightAssignmentCtrl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.flightAssignedCtrl);
            this.Controls.Add(this.assingmentCtrl);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "FlightAssignmentCtrl";
            this.Size = new System.Drawing.Size(935, 500);
            this.ResumeLayout(false);

        }

        #endregion
        public AssingmentCtrl assingmentCtrl;
        public FlightAssignedCtrl flightAssignedCtrl;
    }
}
