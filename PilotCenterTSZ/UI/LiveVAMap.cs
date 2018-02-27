using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms;
using GMap.NET;
using MySql.Data.MySqlClient;
using ExamCenterTSZ.Functions;
using GMap.NET.WindowsForms.Markers;
using Dapper;

namespace PilotCenterTSZ.UI
{
    public partial class LiveVAMap : UserControl
    {
        public static string IDF
        { get; set; }

        public static int IDP
        { get; set; }

        public int PilotID
        { get; set; }

        public int AssignID
        { get; set; }

        public double LAT
        { get; set; }

        public double LON
        { get; set; }

        public int HDG
        { get; set; }

        public int ALT
        { get; set; }

        public int GS
        { get; set; }

        public int FlightPhaseMap
        { get; set; }

        public LiveVAMap()
        {
            InitializeComponent();
            GetMapInfos();
        }

        //public void GetFlightID(int idp, string idf)
        //{
        //    IDF = idf;

        //    IDP = idp;

        //    GetMapInfos();

        //}
        int test;

        public void GetMapInfos()
        {

        //gMapControl.Overlays.Clear();

        string sqlGetVALiveMapUsers = "SELECT pilotid as PilotID, assignid as AssignID, LAT, LON, HDG, ALT, GS, phase as Phase, last_report FROM flight_on_live having last_report < date_add(last_report, interval 15 minute)";
        MySqlConnection conn = new MySqlConnection(Login.ConnectionString);

        try
        {
            conn.Open();

            MySqlCommand sqlCmd = new MySqlCommand(sqlGetVALiveMapUsers, conn);

            MySqlDataReader sqlCmdRes = sqlCmd.ExecuteReader();
            if (sqlCmdRes.HasRows)
                while (sqlCmdRes.Read())
                {
                    PilotID = (int)sqlCmdRes[0];
                    AssignID = (int)sqlCmdRes[1];
                    LAT = (float)sqlCmdRes[2];
                    LON = (float)sqlCmdRes[3];
                    HDG = (int)sqlCmdRes[4];
                    ALT = (int)sqlCmdRes[5];
                    GS = (int)sqlCmdRes[5];
                    FlightPhaseMap = (int)sqlCmdRes[6];
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

            gMapControl.DragButton = MouseButtons.Left;
            gMapControl.MapProvider = GMapProviders.GoogleSatelliteMap;

            gMapControl.MinZoom = 2;
            gMapControl.MaxZoom = 15;
            gMapControl.Zoom = 2;
          
            GMapOverlay routes = new GMapOverlay("routes");
            List<PointLatLng> points = new List<PointLatLng>();
            GMapRoute route;
            GMarkerGoogle marker;

            foreach (var point in OnLiveMap.Get())
            {
                if (test != point.PirepID) {
                    points = new List<PointLatLng>();                    
                }
                test = point.PirepID;

                points.Add(new PointLatLng(point.LAT, point.LON));

                route = new GMapRoute(points, "A walk in the park");
                route.Stroke = new Pen(Color.Red, 3);
                routes.Routes.Add(route);

            }

            foreach (var point in OnLiveMap.GetAircraft())
            {
                if (point.PirepID != test) {
                    //UserMarkers
                    marker = new GMarkerGoogle(new PointLatLng(point.LiveLAT, point.LiveLON), GMarkerGoogleType.blue);
                    routes.Markers.Add(marker);
                }

                gMapControl.Overlays.Add(routes);
            }
            //UserMarkers

            //GMapOverlay markersOverlay = new GMapOverlay("markers");
            //GMarkerGoogle marker = new GMarkerGoogle(new PointLatLng(LAT, LON),
            //  GMarkerGoogleType.green);
            //markersOverlay.Markers.Add(marker);
            //gMapControl.Overlays.Add(markersOverlay);

        }   

    }
}
