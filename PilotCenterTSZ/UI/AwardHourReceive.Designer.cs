namespace PilotCenterTSZ.UI
{
    partial class AwardHourReceive
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AwardHourReceive));
            this.lblAwardInfo = new System.Windows.Forms.Label();
            this.btnReceive = new Bunifu.Framework.UI.BunifuThinButton2();
            this.SuspendLayout();
            // 
            // lblAwardInfo
            // 
            this.lblAwardInfo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAwardInfo.Location = new System.Drawing.Point(3, 105);
            this.lblAwardInfo.Name = "lblAwardInfo";
            this.lblAwardInfo.Size = new System.Drawing.Size(547, 23);
            this.lblAwardInfo.TabIndex = 0;
            this.lblAwardInfo.Text = "You have XX ep\'s to receive for the XX hour prize";
            this.lblAwardInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnReceive
            // 
            this.btnReceive.ActiveBorderThickness = 1;
            this.btnReceive.ActiveCornerRadius = 20;
            this.btnReceive.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.btnReceive.ActiveForecolor = System.Drawing.Color.White;
            this.btnReceive.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btnReceive.BackColor = System.Drawing.SystemColors.Control;
            this.btnReceive.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnReceive.BackgroundImage")));
            this.btnReceive.ButtonText = "Receive";
            this.btnReceive.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReceive.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReceive.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnReceive.IdleBorderThickness = 1;
            this.btnReceive.IdleCornerRadius = 20;
            this.btnReceive.IdleFillColor = System.Drawing.Color.White;
            this.btnReceive.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.btnReceive.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btnReceive.Location = new System.Drawing.Point(186, 157);
            this.btnReceive.Margin = new System.Windows.Forms.Padding(5);
            this.btnReceive.Name = "btnReceive";
            this.btnReceive.Size = new System.Drawing.Size(181, 41);
            this.btnReceive.TabIndex = 3;
            this.btnReceive.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnReceive.Click += new System.EventHandler(this.btnReceive_Click);
            // 
            // AwardHourReceive
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnReceive);
            this.Controls.Add(this.lblAwardInfo);
            this.Name = "AwardHourReceive";
            this.Size = new System.Drawing.Size(550, 300);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblAwardInfo;
        private Bunifu.Framework.UI.BunifuThinButton2 btnReceive;
    }
}
