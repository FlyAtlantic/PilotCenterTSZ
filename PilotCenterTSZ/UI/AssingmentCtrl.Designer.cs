namespace PilotCenterTSZ.UI
{
    partial class AssingmentCtrl
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
            this.btnRequest = new System.Windows.Forms.Button();
            this.lblTime = new System.Windows.Forms.Label();
            this.lblAircraft = new System.Windows.Forms.Label();
            this.cboxTypeRatings = new System.Windows.Forms.ComboBox();
            this.cboxFlightTime = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnRequest
            // 
            this.btnRequest.Location = new System.Drawing.Point(128, 135);
            this.btnRequest.Name = "btnRequest";
            this.btnRequest.Size = new System.Drawing.Size(127, 23);
            this.btnRequest.TabIndex = 9;
            this.btnRequest.Text = "Request";
            this.btnRequest.UseVisualStyleBackColor = true;
            this.btnRequest.Click += new System.EventHandler(this.btnRequest_Click);
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.Location = new System.Drawing.Point(197, 73);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(122, 15);
            this.lblTime.TabIndex = 8;
            this.lblTime.Text = "Flight Time (MAX)";
            // 
            // lblAircraft
            // 
            this.lblAircraft.AutoSize = true;
            this.lblAircraft.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAircraft.Location = new System.Drawing.Point(92, 73);
            this.lblAircraft.Name = "lblAircraft";
            this.lblAircraft.Size = new System.Drawing.Size(79, 15);
            this.lblAircraft.TabIndex = 7;
            this.lblAircraft.Text = "TypeRating";
            // 
            // cboxTypeRatings
            // 
            this.cboxTypeRatings.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboxTypeRatings.FormattingEnabled = true;
            this.cboxTypeRatings.Location = new System.Drawing.Point(93, 101);
            this.cboxTypeRatings.Name = "cboxTypeRatings";
            this.cboxTypeRatings.Size = new System.Drawing.Size(76, 21);
            this.cboxTypeRatings.TabIndex = 5;
            this.cboxTypeRatings.SelectedValueChanged += new System.EventHandler(this.cboxTypeRatings_SelectedValueChanged);
            // 
            // cboxFlightTime
            // 
            this.cboxFlightTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboxFlightTime.FormattingEnabled = true;
            this.cboxFlightTime.Location = new System.Drawing.Point(217, 101);
            this.cboxFlightTime.Name = "cboxFlightTime";
            this.cboxFlightTime.Size = new System.Drawing.Size(76, 21);
            this.cboxFlightTime.TabIndex = 10;
            // 
            // AssingmentCtrl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.cboxFlightTime);
            this.Controls.Add(this.btnRequest);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.lblAircraft);
            this.Controls.Add(this.cboxTypeRatings);
            this.Name = "AssingmentCtrl";
            this.Size = new System.Drawing.Size(420, 243);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRequest;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label lblAircraft;
        private System.Windows.Forms.ComboBox cboxTypeRatings;
        private System.Windows.Forms.ComboBox cboxFlightTime;
    }
}
