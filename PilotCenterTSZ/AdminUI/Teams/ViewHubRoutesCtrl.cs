using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using ExamCenterTSZ.Functions;

namespace PilotCenterTSZ.AdminUI.Teams
{
    public partial class ViewHubRoutesCtrl : UserControl
    {
        string HUB;

        public ViewHubRoutesCtrl()
        {
            InitializeComponent();

        }

        public void GetRoutes(string Hub)
        {
            comboTypeRatings(Hub);

            foreach (AdminHubRoutes r in AdminHubRoutes.GetHubRoutes(Hub))
            {
                lstFlights.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
                lstFlights.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
                lstFlights.Items.Add(new ListViewItem(new string[]{
                    r.Callsign,
                    r.Aircraft,
                    r.Departure,
                    r.Arrival,
                    r.Alternate,
                    r.Route,
                    r.Altitude,
                    r.FlightTime.ToString(),
                    r.Briefing,
                    r.Qualification,
                    r.Hub
                }));
            }

            HUB = Hub;
        }

        private void comboTypeRatings(string HUB)
        {

            MySqlConnection conn = new MySqlConnection(Login.ConnectionString);

            try
            {
                conn.Open();

                string sqlTypeRatings = "select typeratingsname.name as name from typeratingsname left join flights on typeratingsname.name = flights.aircraft left join hubs on flights.hub = hubs.id where hubs.icao = @HUB group by typeratingsname.name order by typeratingsname.id";

                MySqlCommand sqlCmd = new MySqlCommand(sqlTypeRatings, conn);
                sqlCmd.Parameters.AddWithValue("@HUB", HUB);

                MySqlDataAdapter mysqlDs = new MySqlDataAdapter(sqlCmd);
                DataSet ds = new DataSet();
                mysqlDs.Fill(ds);
                cboxTyperatings.DataSource = ds.Tables[0];
                cboxTyperatings.ValueMember = "name";
                cboxTyperatings.DisplayMember = "name";
            }
            catch (Exception crap)
            {
                MessageBox.Show(crap.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
            }
        }

        private void cboxTyperatings_SelectedIndexChanged(object sender, EventArgs e)
        {
            lstFlights.Items.Clear();

            foreach (AdminHubRoutes r in AdminHubRoutes.GetHubRoutesByAircraft(HUB, cboxTyperatings.SelectedValue.ToString()))
            {
                
                lstFlights.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
                lstFlights.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
                lstFlights.Items.Add(new ListViewItem(new string[]{
                    r.Callsign,
                    r.Aircraft,
                    r.Departure,
                    r.Arrival,
                    r.Alternate,
                    r.Route,
                    r.Altitude,
                    r.FlightTime.ToString(),
                    r.Briefing,
                    r.Qualification,
                    r.Hub
                }));
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Hide();
        }
    }
}
