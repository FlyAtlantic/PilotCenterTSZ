namespace PilotCenterTSZ.UI
{
    partial class MyFlightView
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.btnBack = new System.Windows.Forms.Button();
            this.gMapControl1 = new GMap.NET.WindowsForms.GMapControl();
            this.chartFlightsClimbGraphic = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartFlightsDescentGraphic = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.lblFlightInfo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chartFlightsClimbGraphic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartFlightsDescentGraphic)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(405, 429);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 0;
            this.btnBack.Text = "<< Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // gMapControl1
            // 
            this.gMapControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gMapControl1.Bearing = 0F;
            this.gMapControl1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.gMapControl1.CanDragMap = true;
            this.gMapControl1.EmptyTileColor = System.Drawing.Color.Navy;
            this.gMapControl1.GrayScaleMode = false;
            this.gMapControl1.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.gMapControl1.LevelsKeepInMemmory = 5;
            this.gMapControl1.Location = new System.Drawing.Point(13, 38);
            this.gMapControl1.MarkersEnabled = true;
            this.gMapControl1.MaxZoom = 2;
            this.gMapControl1.MinZoom = 2;
            this.gMapControl1.MouseWheelZoomEnabled = true;
            this.gMapControl1.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
            this.gMapControl1.Name = "gMapControl1";
            this.gMapControl1.NegativeMode = false;
            this.gMapControl1.PolygonsEnabled = true;
            this.gMapControl1.RetryLoadTile = 0;
            this.gMapControl1.RoutesEnabled = true;
            this.gMapControl1.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Integer;
            this.gMapControl1.SelectedAreaFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
            this.gMapControl1.ShowTileGridLines = false;
            this.gMapControl1.Size = new System.Drawing.Size(467, 286);
            this.gMapControl1.TabIndex = 6;
            this.gMapControl1.Zoom = 0D;
            // 
            // chartFlightsClimbGraphic
            // 
            chartArea3.Name = "ChartArea1";
            this.chartFlightsClimbGraphic.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chartFlightsClimbGraphic.Legends.Add(legend3);
            this.chartFlightsClimbGraphic.Location = new System.Drawing.Point(536, 38);
            this.chartFlightsClimbGraphic.Name = "chartFlightsClimbGraphic";
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            this.chartFlightsClimbGraphic.Series.Add(series3);
            this.chartFlightsClimbGraphic.Size = new System.Drawing.Size(348, 170);
            this.chartFlightsClimbGraphic.TabIndex = 7;
            this.chartFlightsClimbGraphic.Text = "chart1";
            // 
            // chartFlightsDescentGraphic
            // 
            chartArea4.Name = "ChartArea1";
            this.chartFlightsDescentGraphic.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.chartFlightsDescentGraphic.Legends.Add(legend4);
            this.chartFlightsDescentGraphic.Location = new System.Drawing.Point(536, 214);
            this.chartFlightsDescentGraphic.Name = "chartFlightsDescentGraphic";
            series4.ChartArea = "ChartArea1";
            series4.Legend = "Legend1";
            series4.Name = "Series1";
            this.chartFlightsDescentGraphic.Series.Add(series4);
            this.chartFlightsDescentGraphic.Size = new System.Drawing.Size(348, 170);
            this.chartFlightsDescentGraphic.TabIndex = 8;
            this.chartFlightsDescentGraphic.Text = "chart1";
            // 
            // lblFlightInfo
            // 
            this.lblFlightInfo.AutoSize = true;
            this.lblFlightInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFlightInfo.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblFlightInfo.Location = new System.Drawing.Point(13, 1);
            this.lblFlightInfo.Name = "lblFlightInfo";
            this.lblFlightInfo.Size = new System.Drawing.Size(52, 18);
            this.lblFlightInfo.TabIndex = 9;
            this.lblFlightInfo.Text = "label1";
            // 
            // MyFlightView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblFlightInfo);
            this.Controls.Add(this.chartFlightsDescentGraphic);
            this.Controls.Add(this.chartFlightsClimbGraphic);
            this.Controls.Add(this.gMapControl1);
            this.Controls.Add(this.btnBack);
            this.Name = "MyFlightView";
            this.Size = new System.Drawing.Size(887, 500);
            ((System.ComponentModel.ISupportInitialize)(this.chartFlightsClimbGraphic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartFlightsDescentGraphic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBack;
        private GMap.NET.WindowsForms.GMapControl gMapControl1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartFlightsClimbGraphic;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartFlightsDescentGraphic;
        private System.Windows.Forms.Label lblFlightInfo;
    }
}
