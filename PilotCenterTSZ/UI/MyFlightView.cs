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

        public static int IDP
        { get; set; }

        public void GetFlightID(int idp, string idf, string dep, string arr, string aircraft, string time)
        {
            IDF = idf;

            IDP = idp;

            lblFlightInfo.Text = String.Format("{0} {1}-{2} {3}   FlightTime: {4}", idf, dep, arr, aircraft, time);

            FlightMap();

            Penalizations();
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
            a.lblDclick.Visible = true;

        }

        public void FlightMap()
        {
            gMapControl1.Overlays.Clear();
            string sqlGetMapCenterPosition = "SELECT AVG(LAT), AVG(LON), max(pireps.flighttime) FROM flightLog left join flight_phases on flightLog.phase = flight_phases.code left join pireps on flightLog.pirepid = pireps.id left join flights on pireps.flightid = flights.idf left join utilizadores on pireps.pilotid= utilizadores.user_id where flights.callsign=@Callsign and user_email = @Email and pireps.id = @FlightID order by IDL asc";
            MySqlConnection conn = new MySqlConnection(Login.ConnectionString);

            try
            {
                conn.Open();

                MySqlCommand sqlCmd = new MySqlCommand(sqlGetMapCenterPosition, conn);
                sqlCmd.Parameters.AddWithValue("@Callsign", IDF);
                sqlCmd.Parameters.AddWithValue("@Email", Properties.Settings.Default.Email);
                sqlCmd.Parameters.AddWithValue("@FlightID", IDP);

                MySqlDataReader sqlCmdRes = sqlCmd.ExecuteReader();
                if (sqlCmdRes.HasRows)
                    while (sqlCmdRes.Read())
                    {
                        MapPositionLat = (double)sqlCmdRes[0];
                        MapPositionLong = (double)sqlCmdRes[1];
                        FlightTime = TimeSpan.FromMinutes((int)sqlCmdRes[2]);
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

            gMapControl1.MinZoom = 1;
            gMapControl1.MaxZoom = 15;
            if (FlightTime < TimeSpan.FromMinutes(180))
            {
                gMapControl1.Zoom = 5;
            }
            else if (FlightTime > TimeSpan.FromMinutes(180) && FlightTime < TimeSpan.FromMinutes(600))
            {
                gMapControl1.Zoom = 3;
            }
            else if (FlightTime > TimeSpan.FromMinutes(600))
            {
                gMapControl1.Zoom = 2;
            }

            GMapOverlay polyOverlay = new GMapOverlay("polygons");
            GMapRoute polygon = new GMapRoute(getPointsFromSql(), "mypolygon");
            //polygon.Fill = new SolidBrush(Color.FromArgb(50, Color.Red));
            polygon.Stroke = new Pen(Color.Red, 2);
            polyOverlay.Routes.Add(polygon);
            gMapControl1.Overlays.Add(polyOverlay);
            gMapControl1.Position = new PointLatLng(MapPositionLat, MapPositionLong);
        }

        static List<GMap.NET.PointLatLng> getPointsFromSql()
        {
            return (List<GMap.NET.PointLatLng>)new MySqlConnection(Login.ConnectionString).Query<GMap.NET.PointLatLng>(
                @"SELECT DISTINCT LAT as Lat, LON as Lng FROM flightLog left join flight_phases on flightLog.phase = flight_phases.code left join pireps on flightLog.pirepid = pireps.id left join flights on pireps.flightid = flights.idf left join utilizadores on pireps.pilotid= utilizadores.user_id where flights.callsign=@Callsign and user_email = @Email and pireps.id = @IDP order by IDL asc",
                new
                {
                    Callsign = IDF,
                    Email = Properties.Settings.Default.Email,
                    IDP = IDP
                });
        }

        public void Penalizations()
        {
            foreach (AdminAllFlights p in AdminAllFlights.GetPenalizations(IDP))
            {
                lstPenalizations.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
                lstPenalizations.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
                lstPenalizations.Items.Add(new ListViewItem(new string[] {
                    p.TimePenalization.ToString(),
                    p.CodePenalization,
                    p.DiscriptionPenalization,
                    p.DiscountPenalization.ToString()
                }));
            }
        }

        private void lstPenalizations_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstPenalizations.SelectedItems.Count > 0) {
                switch (lstPenalizations.SelectedItems[0].SubItems[1].Text)
                {
                    case "2A":
                        label1.Text = "The event occurs when the aircraft makes a return of more than 30 degrees";
                        break;

                    case "3A":
                        label1.Text = "The event occurs when the landing lights are on above 10,000 feet";
                        break;

                    case "3B":
                        label1.Text = "The event occurs when the landing lights are off on approach phase";
                        break;

                    case "3C":
                        label1.Text = "The event occurs when the aircraft maintains an indicated speed greater than 250 knots below 10,000 feet";
                        break;

                    case "3D":
                        label1.Text = "The event occurs when the aircraft maintains an ground speed greater than 25 knots on taxi for departure";
                        break;

                    case "3E":
                        label1.Text = "The event occurs when the aircraft maintains an ground speed greater than 25 knots on taxi to gate";
                        break;

                    case "4A":
                        label1.Text = "The event occurs when the aircraft maintains an indicated speed greater than 250 knots with landing lights on";
                        break;

                    case "4B":
                        label1.Text = "The event occurs when the aircraft keeps the landing lights off during take-off";
                        break;

                    case "4C":
                        label1.Text = "The event occurs when the aircraft maintains an incline greater than 20 degrees below 1500 feet (Radio Altimeter)";
                        break;

                    case "4D":
                        label1.Text = "The event occurs when the aircraft keeps the landing gear down at a speed exceeding 250 knots indicated";
                        break;

                    case "5A":
                        label1.Text = "The event occurs when the pilot makes his flight disconnected from the VATSIM network";
                        break;

                    case "5C":
                        label1.Text = "The event occurs when the aircraft effects a touchdown of less than -400 ft per minute";
                        break;

                    case "6A":
                        label1.Text = "The event occurs when the aircraft takes off with a weight greater than its maximum take-off weight";
                        break;

                    case "6B":
                        label1.Text = "The event occurs when the aircraft lands at a weight greater than its maximum landing weight";
                        break;

                    case "6C":
                        label1.Text = "The event occurs when the aircraft is flying at an altitude above its maximum service ceiling";
                        break;

                    case "6D":
                        label1.Text = "The event occurs when the aircraft is flying at a speed greater than its maximum flap speed";
                        break;

                    case "7B":
                        label1.Text = "The event occurs when the aircraft is flying with a pitch greater than 30 degrees";
                        break;

                    default:
                        break;

                }
            }
        }
    }
}
