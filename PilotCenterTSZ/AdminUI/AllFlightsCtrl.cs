using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PilotCenterTSZ.AdminUI
{
    public partial class AllFlightsCtrl : UserControl
    {
        public AllFlightsCtrl()
        {
            InitializeComponent();

            ShowFlights();

            foreach (AdminAllFlights p in AdminAllFlights.GetTotalFlights())
            {
                lblTotalFlights.Text = "Total Flights: " + p.TotalFlights.ToString();
            }
        }


        public void ShowFlights()
        {
            foreach (AdminAllFlights p in AdminAllFlights.GetAdminAllFlights())
            {

                lstFlights.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
                lstFlights.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
                lstFlights.Items.Add(new ListViewItem(new string[]
                {
                    p.PirepID.ToString(),
                    p.PirepDate.Date.ToString(@"dd-MM-yyyy"),
                    TimeSpan.FromMinutes(p.FlightTime).ToString(@"hh\:mm"),
                    p.UserName + ' ' + p.UserSurname,
                    p.Callsign,
                    p.Departure,
                    p.Arrival,
                    p.Aircraft,
                    p.Touch.ToString() + String.Format(" ft/pm"),
                    p.Sum.ToString() + String.Format(" %"),
                    p.Eps.ToString(),
                    p.Obs,
                    
                }));

                lstFlights.Tag = p.PirepID;
            }
        }

        private void lstFlights_SelectedIndexChanged(object sender, EventArgs e)
        {
            // show flight profile
        }

        private void lstFlights_DoubleClick(object sender, EventArgs e)
        {

            lstFlights.Hide();

            flightViewCtrl.Show();

            if (lstFlights.SelectedItems.Count == 1)
            {
                flightViewCtrl.GetFlightID(Convert.ToInt32(lstFlights.SelectedItems[0].SubItems[0].Text), lstFlights.SelectedItems[0].SubItems[4].Text, lstFlights.SelectedItems[0].SubItems[5].Text, lstFlights.SelectedItems[0].SubItems[6].Text, lstFlights.SelectedItems[0].SubItems[7].Text, lstFlights.SelectedItems[0].SubItems[2].Text);
            }

        }
    }
}
