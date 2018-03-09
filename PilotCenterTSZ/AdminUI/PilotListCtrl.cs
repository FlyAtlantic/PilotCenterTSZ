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
    public partial class PilotListCtrl : UserControl
    {
        string Active;

        public PilotListCtrl()
        {
            InitializeComponent();

            ShowPilots();

            foreach (AdminPilotList p in AdminPilotList.GetNumberPilots())
            {
                lblActivePilots.Text = "Total Pilots: " +  p.TotalPilots.ToString();
            }
            foreach (AdminPilotList p in AdminPilotList.GetNumberActivePilots())
            {
                lblInactivePilots.Text = "Inactive Pilots: " + p.TotalActivePilots.ToString();
            }
            foreach (AdminPilotList p in AdminPilotList.GetNumberInactivePilots())
            {
                lblTotalPilots.Text = "Active Pilots: " + p.TotalInactivePilots.ToString();
            }
        }

        public void ShowPilots()
        {
            foreach (AdminPilotList p in AdminPilotList.Get())
            {
                double flightHours = Convert.ToDouble(TimeSpan.FromMinutes(p.UserHours).TotalHours.ToString());
                double flightMinutes = Convert.ToDouble(TimeSpan.FromMinutes(p.UserHours).Minutes.ToString());
                string TotalHours;

                if (flightMinutes <= 9)
                {
                    TotalHours = Math.Truncate(flightHours).ToString() + ':' + '0' + Math.Truncate(flightMinutes).ToString();
                }
                else
                {
                   TotalHours = Math.Truncate(flightHours).ToString() + ':' + Math.Truncate(flightMinutes).ToString();
                }

                if(p.AccountStatus == 1)
                {
                    Active = String.Format("Active");
                }
                else if (p.AccountStatus == 0)
                {
                    Active = String.Format("Inactive");
                }

                lstPilots.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
                lstPilots.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
                lstPilots.Items.Add(new ListViewItem(new string[]
                {
                    p.UserID.ToString(),
                    String.Format("TSZ") + p.Callsign.ToString(),
                    p.UserName + ' ' + p.UserSurname,
                    p.UserEmail,
                    p.JoinDate.ToString(@"dd-MM-yyyy"),
                    p.LastActivity.ToString(),
                    p.UserRank,
                    p.VatsimID.ToString(),
                    p.VatsimRating,
                    TotalHours,
                    p.UserEps.ToString(),
                    p.UserLocation,
                    p.UserHub,
                    p.Level,
                    p.StaffTeam,
                    Active,
                }));

                lstPilots.Tag = p.UserID;
            }
        }

        private void lstPilots_DoubleClick(object sender, EventArgs e)
        {
            //Show Pilot profile to edit
        }
    }
}
