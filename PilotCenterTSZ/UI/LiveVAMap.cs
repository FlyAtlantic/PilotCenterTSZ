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
using GMap.NET.WindowsForms.ToolTips;

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

        public int test
        { get; set; }

        public int markerTag
        { get; set; }

        bool toolTypeVisible;

        GMapOverlay routes = new GMapOverlay("routes");
        List<PointLatLng> points;
        GMapRoute route;
        GMarkerGoogle marker;

        public LiveVAMap()
        {
            InitializeComponent();

            gMapControl.DragButton = MouseButtons.Left;
            gMapControl.MapProvider = GMapProviders.GoogleSatelliteMap;

            gMapControl.MinZoom = 2;
            gMapControl.MaxZoom = 15;
            gMapControl.Zoom = 2;

            GetMapAircrafts();            

            gMapControl.Click += GMapControl_Click;

            gMapControl.OnMarkerClick += GMapControl_OnMarkerClick;

            foreach (var numberPilots in OnLiveMap.GetNumberPilotsOnline())
            {
                if (numberPilots.NumberOnlinePilots <= 2)
                    gMapControl.Zoom = 4;
                else if (numberPilots.NumberOnlinePilots <= 5)
                    gMapControl.Zoom = 3;
            }
        }

        private void GMapControl_Click(object sender, EventArgs e)
        {
            routes.Routes.Clear();
            marker.ToolTipMode = MarkerTooltipMode.OnMouseOver;
        }

        private void GMapControl_OnMarkerClick(GMapMarker item, MouseEventArgs e)
        {

            gMapControl.Overlays.Clear();

            GetMapAircrafts();

            GetUserRoute(markerTag);

            gMapControl.Zoom = 6;
            marker.ToolTipMode = MarkerTooltipMode.OnMouseOver;
            marker.ToolTipMode = MarkerTooltipMode.Always;
        }

      
        public void GetMapAircrafts()
        {
            gMapControl.Overlays.Clear();

            foreach (var point in OnLiveMap.GetAircraft())
            {
                if (point.PirepID != test)
                {
                    //UserMarkers
                    marker = new GMarkerGoogle(new PointLatLng(point.LiveLAT, point.LiveLON), GMarkerGoogleType.blue);

                    marker.Tag = markerTag = point.PirepID;

                    marker.ToolTipText = "" + point.LiveCallsign + "\n" +
                        point.DEP + " - " + point.ARR + "\n" +
                        "HDG:" + point.HDG + " º\n" +
                        "ALT:" + point.ALT + " ft\n" +
                        "GS:" + point.GS + " kt\n" +
                         point.Phase
                        ;
                    //marker.ToolTip.Fill = Brushes.White;
                    //marker.ToolTip.Foreground = Brushes.Black;
                    //marker.ToolTip.Stroke = Pens.Black;
                    //marker.ToolTip.TextPadding = new Size(20, 20);
                    //marker.ToolTipMode = MarkerTooltipMode.OnMouseOver;
                    marker.ToolTip.Format.Alignment = StringAlignment.Near;

                    
                    routes.Markers.Add(marker);

                }
                else
                {
                    toolTypeVisible = false;

                    if (marker.ToolTipMode == MarkerTooltipMode.Always)
                    {
                        GetUserRoute(markerTag);

                        toolTypeVisible = true;
                    }

                    routes.Markers.Remove(marker);
                    marker = new GMarkerGoogle(new PointLatLng(point.LiveLAT, point.LiveLON), GMarkerGoogleType.blue);
                    marker.Tag = markerTag = point.PirepID;

                    marker.ToolTipText = "" + point.LiveCallsign + "\n" +
                        point.DEP + " - " + point.ARR + "\n" +
                        "HDG:" + point.HDG + " º\n" +
                        "ALT:" + point.ALT + " ft\n" +
                        "GS:" + point.GS + " kt\n" +
                         point.Phase
                        ;
                    //marker.ToolTip.Fill = Brushes.White;
                    //marker.ToolTip.Foreground = Brushes.Black;
                    //marker.ToolTip.Stroke = Pens.Black;
                    //marker.ToolTip.TextPadding = new Size(20, 20);

                    marker.ToolTip.Format.Alignment = StringAlignment.Near;

                    routes.Markers.Add(marker);

                    if (toolTypeVisible)
                    {
                        gMapControl.Position = new GMap.NET.PointLatLng(point.LiveLAT, point.LiveLON);
                    }
                    else
                    {
                        foreach (var position in OnLiveMap.GetCenterMap())
                        {
                            gMapControl.Position = new GMap.NET.PointLatLng(position.CenterMapLAT, position.CenterMapLON);
                        }
                    }
                }

                test = point.PirepID;
                
                gMapControl.Overlays.Add(routes);

                if (toolTypeVisible)
                {
                    marker.ToolTipMode = MarkerTooltipMode.Always;
                }
            }

        }
        
        public void GetUserRoute(int tag)
        {

            points = new List<PointLatLng>();

            foreach (var point in OnLiveMap.Get(tag))
            {
                if (test != point.PirepID)
                {
                    points = new List<PointLatLng>();
                }
                test = point.PirepID;

                points.Add(new PointLatLng(point.LAT, point.LON));

                route = new GMapRoute(points, "A walk in the park");
                route.Stroke = new Pen(Color.Red, 2);
                routes.Routes.Add(route);

            }
                gMapControl.Overlays.Add(routes);

        }


    }

}

