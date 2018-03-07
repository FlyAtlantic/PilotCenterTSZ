namespace PilotCenterTSZ.AdminUI
{
    partial class ButtonTeamAreaCtrl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ButtonTeamAreaCtrl));
            this.btnTeam = new Bunifu.Framework.UI.BunifuFlatButton();
            this.SuspendLayout();
            // 
            // btnTeam
            // 
            this.btnTeam.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(60)))), ((int)(((byte)(100)))));
            this.btnTeam.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.btnTeam.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnTeam.BorderRadius = 0;
            this.btnTeam.ButtonText = "LogBook";
            this.btnTeam.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTeam.DisabledColor = System.Drawing.Color.Gray;
            this.btnTeam.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTeam.Iconcolor = System.Drawing.Color.Transparent;
            this.btnTeam.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnTeam.Iconimage")));
            this.btnTeam.Iconimage_right = null;
            this.btnTeam.Iconimage_right_Selected = null;
            this.btnTeam.Iconimage_Selected = null;
            this.btnTeam.IconMarginLeft = 0;
            this.btnTeam.IconMarginRight = 0;
            this.btnTeam.IconRightVisible = true;
            this.btnTeam.IconRightZoom = 0D;
            this.btnTeam.IconVisible = true;
            this.btnTeam.IconZoom = 90D;
            this.btnTeam.IsTab = false;
            this.btnTeam.Location = new System.Drawing.Point(0, 0);
            this.btnTeam.Name = "btnTeam";
            this.btnTeam.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.btnTeam.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(60)))), ((int)(((byte)(100)))));
            this.btnTeam.OnHoverTextColor = System.Drawing.Color.White;
            this.btnTeam.selected = false;
            this.btnTeam.Size = new System.Drawing.Size(238, 48);
            this.btnTeam.TabIndex = 6;
            this.btnTeam.Text = "LogBook";
            this.btnTeam.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTeam.Textcolor = System.Drawing.Color.White;
            this.btnTeam.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTeam.Click += new System.EventHandler(this.btnLogBook_Click);
            // 
            // ButtonTeamAreaCtrl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnTeam);
            this.Name = "ButtonTeamAreaCtrl";
            this.Size = new System.Drawing.Size(222, 45);
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuFlatButton btnTeam;
    }
}
