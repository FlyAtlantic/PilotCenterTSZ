using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using Dapper;
using ExamCenterTSZ.Functions;
using GMap.NET;
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms;
using MySql.Data.MySqlClient;

namespace PilotCenterTSZ.UI
{
    public partial class MyFlightView : UserControl
    {
        double MapPositionLat;
        double MapPositionLong;
        TimeSpan FlightTime;

        public static string IDF
        { get; set; }

        public void GetFlightID(string idf, string dep, string arr, string aircraft, string time)
        {
            IDF = idf;

            FlightsClimbGraphic();

            FlightsDescentGraphic();

            lblFlightInfo.Text = String.Format("{0} {1}-{2} {3}   FlightTime: {4}", idf, dep, arr, aircraft, time);

            FlightMap();
        }

        public MyFlightView()
        {
            InitializeComponent();

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Hide();

            var a = this.Parent as MyLogBookCtrl;

            a.lstLogBook.Show();


        }

        public void FlightMap()
        {

            string sqlGetMapCenterPosition = "SELECT AVG(LAT), AVG(LON), flights.flighttime FROM flightLog left join flight_phases on flightLog.phase = flight_phases.code left join pireps on flightLog.pirepid = pireps.id left join flights on pireps.flightid = flights.idf where callsign=@Callsign order by IDL asc";
            MySqlConnection conn = new MySqlConnection(Login.ConnectionString);

            try
            {
                conn.Open();

                MySqlCommand sqlCmd = new MySqlCommand(sqlGetMapCenterPosition, conn);
                sqlCmd.Parameters.AddWithValue("@Callsign", IDF);

                MySqlDataReader sqlCmdRes = sqlCmd.ExecuteReader();
                if (sqlCmdRes.HasRows)
                    while (sqlCmdRes.Read())
                    {
                        MapPositionLat = (double)sqlCmdRes[0];
                        MapPositionLong = (double)sqlCmdRes[1];
                        FlightTime = (TimeSpan)sqlCmdRes[2];
                    }

            }
            catch (Exception crap)
            {
                throw new ApplicationException("Failed to load exam @sqlGetMapCenterPosition()", crap);
            }
            finally
            {
                conn.Close();
            }


            gMapControl1.DragButton = MouseButtons.Left;
            gMapControl1.MapProvider = GMapProviders.GoogleSatelliteMap;

            gMapControl1.MinZoom = 2;
            gMapControl1.MaxZoom = 100;
            if (FlightTime > TimeSpan.FromMinutes(180))
            {
                gMapControl1.Zoom = 3;
            }
            else
                gMapControl1.Zoom = 4;

            GMapOverlay polyOverlay = new GMapOverlay("polygons");
            GMapRoute polygon = new GMapRoute(getPointsFromSql(), "mypolygon");
            //polygon.Fill = new SolidBrush(Color.FromArgb(50, Color.Red));
            polygon.Stroke = new Pen(Color.Red, 1);
            polyOverlay.Routes.Add(polygon);
            gMapControl1.Overlays.Add(polyOverlay);
            gMapControl1.Position = new PointLatLng(MapPositionLat, MapPositionLong);
        }

        static List<GMap.NET.PointLatLng> getPointsFromSql()
        {
            return (List<GMap.NET.PointLatLng>)new MySqlConnection(Login.ConnectionString).Query<GMap.NET.PointLatLng>(
                @"SELECT DISTINCT LAT as Lat, LON as Lng FROM flightLog left join flight_phases on flightLog.phase = flight_phases.code left join pireps on flightLog.pirepid = pireps.id left join flights on pireps.flightid = flights.idf where callsign=@Callsign order by IDL asc",
                new
                {
                    Callsign = IDF
                });
        }

        public void FlightsClimbGraphic()
        {
            var chart = chartFlightsClimbGraphic.ChartAreas[0];
            chart.AxisX.IntervalType = DateTimeIntervalType.Number;

            chart.AxisX.LabelStyle.Format = "";
            chart.AxisY.LabelStyle.Format = "";
            chart.AxisY.LabelStyle.IsEndLabelVisible = true;

            chart.AxisX.Minimum = 0;
            chart.AxisX.Maximum = 60;
            chart.AxisX.Interval = 5;

            chart.AxisY.Minimum = 0;
            chart.AxisY.Maximum = 10000;
            chart.AxisY.Interval = 2000;

            chartFlightsClimbGraphic.Series.Clear();
            chartFlightsClimbGraphic.Series.Add("# chartFlightsClimbGraphic");
            chartFlightsClimbGraphic.Series["# chartFlightsClimbGraphic"].ChartType = SeriesChartType.FastLine;
            chartFlightsClimbGraphic.Series["# chartFlightsClimbGraphic"].Color = Color.MediumBlue;
            chartFlightsClimbGraphic.Series[0].IsVisibleInLegend = false;

            int i = 1;
            int min = 0;
            int temp = 0;
            int diff = 0;

            foreach (FlightLog l in FlightLog.GetClimb(IDF))
            {
                if (l.Time.Minute != temp)
                {
                    if (temp != 0)
                        if (temp > l.Time.Minute)
                            diff = (l.Time.Minute - temp) + 60;
                        else
                            diff = l.Time.Minute - temp;
                    else
                        min = 1;

                    int total = min + diff;

                    if (total > l.Time.Minute)
                        temp = l.Time.Minute + 60;
                    else
                        temp = l.Time.Minute;

                    min = total;

                    chartFlightsClimbGraphic.Series["# chartFlightsClimbGraphic"].Points.AddXY(total, l.Alt);

                }

            }

        }

        public void FlightsDescentGraphic()
        {
            var chart = chartFlightsDescentGraphic.ChartAreas[0];
            chart.AxisX.IntervalType = DateTimeIntervalType.Number;

            chart.AxisX.LabelStyle.Format = "";
            chart.AxisY.LabelStyle.Format = "";
            chart.AxisY.LabelStyle.IsEndLabelVisible = true;

            chart.AxisX.Minimum = 0;
            chart.AxisX.Maximum = 60;
            chart.AxisX.Interval = 5;

            chart.AxisY.Minimum = 0;
            chart.AxisY.Maximum = 10000;
            chart.AxisY.Interval = 2000;

            chartFlightsDescentGraphic.Series.Clear();
            chartFlightsDescentGraphic.Series.Add("# chartFlightsDescentGraphic");
            chartFlightsDescentGraphic.Series["# chartFlightsDescentGraphic"].ChartType = SeriesChartType.FastLine;
            chartFlightsDescentGraphic.Series["# chartFlightsDescentGraphic"].Color = Color.MediumBlue;
            chartFlightsDescentGraphic.Series[0].IsVisibleInLegend = false;

            int i = 1;
            int min = 0;
            int temp = 0;
            int diff = 0;

            foreach (FlightLog l in FlightLog.GetDescent(IDF))
            {
                if (l.Time.Minute != temp)
                {
                    if (temp != 0)
                        if (temp > l.Time.Minute)
                            diff = (l.Time.Minute - temp) + 60;
                        else
                            diff = l.Time.Minute - temp;
                    else
                        min = 1;

                    int total = min + diff;

                    if (total > l.Time.Minute)
                        temp = l.Time.Minute + 60;
                    else
                        temp = l.Time.Minute;

                    min = total;

                    chartFlightsDescentGraphic.Series["# chartFlightsDescentGraphic"].Points.AddXY(total, l.Alt);

                }

            }

        }
    }
}
