using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Net;
using System.Windows.Forms;
using Microsoft.Win32;

namespace PilotCenterTSZ.UI
{
    public partial class FlightAssignedCtrl : UserControl
    {
        string briefing;

        public FlightAssignedCtrl()
        {
            InitializeComponent();
            UpdateInfos();

        }

        public void UpdateInfos()
        {

            AssignFlight f = new AssignFlight();

            f.VerifyFlightAssign();

            txtCallsign.Text = f.FlightCallsign;
            txtDep.Text = f.UserDeparture;
            txtArr.Text = f.UserArrival;
            txtAircraft.Text = f.UserAircraft;
            txtAssigned.Text = f.UserDateAssign.ToString(@"dd-MM-yyyy");
            briefing = f.FlightBriefing;

        }

        private void btnGenerate_Click(object sender, System.EventArgs e)
        {

            string url = @"http://flyatlantic-va.com/site/"+ briefing;
            // Create an instance of WebClient
            WebClient client = new WebClient();
            // Hookup DownloadFileCompleted Event
            client.DownloadFileCompleted += new AsyncCompletedEventHandler(client_DownloadFileCompleted);

            // Start the download and copy the file to c:\temp
            client.DownloadFileAsync(new Uri(url), Environment.CurrentDirectory+@"/"+briefing);
        }

        void client_DownloadFileCompleted(object sender, AsyncCompletedEventArgs e)
        {
            Process.Start(Environment.CurrentDirectory + @"/" + briefing);
        }

    }
}
