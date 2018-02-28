using System;
using System.Drawing;
using System.Windows.Forms;
using AdminCenter;
using ExamCenterTSZ.Functions;
using MySql.Data.MySqlClient;

namespace PilotCenterTSZ
{
    public partial class Dashboard : Form
    {
        UserInfo a = new UserInfo();

        LogBook l = new LogBook();

        AssignFlight f = new AssignFlight();


        public static int Flightid
        { get; set; }

        public static string FlightCallsign
        { get; set; }

        public static string UserDeparture
        { get; set; }

        public static string UserArrival
        { get; set; }

        public static string UserAircraft
        { get; set; }

        public static int idp
        { get; set; }

        public static string idf
        { get; set; }

        int s;
        int sBar;

        public DateTime OnFlight
        { get; set; }


        public void AllHides()
        {
            flightAssignmentCtrl.Hide();
            pilotAccountCtrl.Hide();
            myLogBookCtrl.Hide();
            pilotCarrer.Hide();
            liveVAMap.Hide();
        }

        public static void GetFlightInfosToDash(int flightID, string flightCallsign, string userDeparture, string userArrival, string userAircraft)
        {
            Flightid = flightID;
            FlightCallsign = flightCallsign;
            UserDeparture = userDeparture;
            UserArrival = userArrival;
            UserAircraft = userAircraft;

        }

        public void AlertFlight()
        {
            if (Flightid != 0)
            {
                if (f.OnFlight != 1)
                {
                    lblFlightAlert.Text = String.Format("Alert!! You have one flight with callsign {0}, from {1} to {2} with {3}", FlightCallsign, UserDeparture, UserArrival, UserAircraft);
                    lblFlightAlert.Visible = true;
                    label1.Visible = true;
                    pBarFlightTimeEnd.Visible = true;
                    FlightTimeEndTick.Start();
                }
                else {
                    lblFlightAlert.Text = String.Format("On Flying!! -> {0}, from {1} to {2} with {3}", FlightCallsign, UserDeparture, UserArrival, UserAircraft);
                    lblFlightAlert.ForeColor = Color.ForestGreen;
                    lblFlightAlert.Visible = true;
                    label1.Visible = true;
                    pBarFlightTimeEnd.Visible = false;
                    FlightTimeEndTick.Stop();
                }
            }
            else
            {
                lblFlightAlert.Visible = false;
                label1.Visible = false;
                pBarFlightTimeEnd.Visible = false;
                FlightTimeEndTick.Stop();
            }
        }      

        public Dashboard()
        {

            InitializeComponent();

            Clock.Start();

            lblWelcome.Text = String.Format("Have a nice {0}, {1} {2} {3}", DateTime.UtcNow.DayOfWeek.ToString(), a.Rank, a.UserName, a.UserSurname);

            VerifyAndDeleteFlight.Start();

            f.VerifyFlightTimeOut();

            flightAssignmentCtrl.Actions();

            flightAssignmentCtrl.flightAssignedCtrl.UpdateInfos();

            myLogBookCtrl.GetLogBook();

            AlertFlight();

            if (a.LevelID <= 2)
            {
                btnAdminCenterFrm.Visible = true;
            }

            PilotCarrerTick.Start();
            liveVAMap.GetMapAircrafts();

            LiveMapTick.Start();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            pilotAccountCtrl.Actions();
            flightAssignmentCtrl.Actions();
            flightAssignmentCtrl.flightAssignedCtrl.UpdateInfos();
            myLogBookCtrl.GetLogBook();
            AlertFlight();
            pilotCarrer.Actions();
            liveVAMap.GetMapAircrafts();
        }

        private void btnAssignFlight_Click(object sender, EventArgs e)
        {
            AllHides();
            flightAssignmentCtrl.Show();
        }

        private void VerifyAndDeleteFlight_Tick(object sender, EventArgs e)
        {

            f.VerifyFlightTimeOut();

            flightAssignmentCtrl.Actions();

            flightAssignmentCtrl.flightAssignedCtrl.UpdateInfos();

            AlertFlight();
        }

        private void btnPilotCenter_Click(object sender, EventArgs e)
        {
            AllHides();
            pilotAccountCtrl.Show();
        }

        private void GetInfosForTick()
        {
            string sqlTimeToEndFlight = "select date_assigned, TIME_TO_SEC(DATE_ADD(date_assigned, INTERVAL 30 MINUTE))-TIME_TO_SEC(NOW()) FROM pilotassignments WHERE pilot=@UserID and NOW() <=  DATE_ADD(date_assigned, INTERVAL 30 MINUTE) LIMIT 1";
            MySqlConnection conn = new MySqlConnection(Login.ConnectionString);

            try
            {
                conn.Open();

                MySqlCommand sqlCmd = new MySqlCommand(sqlTimeToEndFlight, conn);
                sqlCmd.Parameters.AddWithValue("@UserID", a.UserID);

                MySqlDataReader sqlCmdRes = sqlCmd.ExecuteReader();
                if (sqlCmdRes.HasRows)
                    while (sqlCmdRes.Read())
                    {
                        s = Convert.ToInt32(sqlCmdRes[1]);
                        sBar = 1800 - Convert.ToInt32(sqlCmdRes[1]);

                    }

            }
            catch (Exception crap)
            {
               throw new ApplicationException("Failed to load exam @UserInfoDash()", crap);
            }
            finally
            {
                conn.Close();
            }
        }

        private void FlightTimeEndTick_Tick(object sender, EventArgs e)
        {
            GetInfosForTick();

            s = s - 1;

            sBar = sBar + 1;

            if (s == 0)
            {
                FlightTimeEndTick.Stop();

                //END of Time               


            }

            string ss = Convert.ToString(s);
            int ssBar = (sBar * 100) / 1800;

            pBarFlightTimeEnd.Value = ssBar;
        }

        private void btnLogBook_Click(object sender, EventArgs e)
        {
            AllHides();
            myLogBookCtrl.Show();
        }

        private void btnAdminCenterFrm_Click(object sender, EventArgs e)
        {
            AdminDash adminDash = new AdminDash();

            Hide();

            adminDash.Show();
        }


        private void btnCarrer_Click(object sender, EventArgs e)
        {
            AllHides();
            pilotCarrer.Show();
        }

        private void PilotCarrerTick_Tick(object sender, EventArgs e)
        {
            pilotCarrer.Actions();
        }

        private void Clock_Tick(object sender, EventArgs e)
        {
            lblClock.Text = DateTime.UtcNow.ToString();
            lblWelcome.Text = String.Format("Have a nice {0}, {1} {2} {3}", DateTime.UtcNow.DayOfWeek.ToString(), a.Rank, a.UserName, a.UserSurname);

        }

        private void btnExitApp_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you really want to close me?",
                    "Are you sure?", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation,
                    MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnLiveVaMap_Click(object sender, EventArgs e)
        {
            AllHides();

            liveVAMap.Show();
        }

        private void LiveMapTick_Tick(object sender, EventArgs e)
        {
            liveVAMap.GetMapAircrafts();
        }

        private void Dashboard_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
