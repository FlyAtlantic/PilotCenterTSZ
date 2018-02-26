using System;
using System.Windows.Forms;
using AdminCenter;
using ExamCenterTSZ.Functions;
using MySql.Data.MySqlClient;

namespace PilotCenterTSZ
{
    public partial class Dashboard : Form
    {
        UserInfo a = new UserInfo();

        public static int FlightID
        { get; set; }

        public static string FlightCallsign
        { get; set; }

        public static string UserDeparture
        { get; set; }

        public static string UserArrival
        { get; set; }

        public static string UserAircraft
        { get; set; }

        int s;
        int sBar;


        public void AllHides()
        {
            flightAssignmentCtrl.Hide();
            pilotAccountCtrl.Hide();
            myLogBookCtrl.Hide();
            pilotCarrer.Hide();
        }

        public static void GetFlightInfosToDash(int flightID, string flightCallsign, string userDeparture, string userArrival, string userAircraft)
        {
            FlightID = flightID;
            FlightCallsign = flightCallsign;
            UserDeparture = userDeparture;
            UserArrival = userArrival;
            UserAircraft = userAircraft;
        }

        public void AlertFlight()
        {
            if (FlightID != 0)
            {
                lblFlightAlert.Text = String.Format("Alert!! You have one flight with callsign {0}, from {1} to {2} with {3}", FlightCallsign, UserDeparture, UserArrival, UserAircraft);
                lblFlightAlert.Visible = true;
                GetInfosForTick();
                label1.Visible = true;
                pBarFlightTimeEnd.Visible = true;
                GetInfosForTick();
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

            lblWelcome.Text = String.Format("Have a nice {0}, {1} {2} {3}", DateTime.UtcNow.DayOfWeek.ToString(), a.Rank, a.UserName, a.UserSurname);

            VerifyAndDeleteFlight.Start();

            AssignFlight.VerifyFlightTimeOut();

            flightAssignmentCtrl.Actions();

            flightAssignmentCtrl.flightAssignedCtrl.UpdateInfos();

            myLogBookCtrl.GetLogBook();

            AlertFlight();

            if (a.LevelID <= 2)
            {
                btnAdminCenterFrm.Visible = true;
            }

        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            pilotAccountCtrl.Actions();
            flightAssignmentCtrl.Actions();
            flightAssignmentCtrl.flightAssignedCtrl.UpdateInfos();
            myLogBookCtrl.GetLogBook();
            AlertFlight();
            pilotCarrer.Actions();
        }

        private void btnAssignFlight_Click(object sender, EventArgs e)
        {
            AllHides();
            flightAssignmentCtrl.Show();
        }

        private void VerifyAndDeleteFlight_Tick(object sender, EventArgs e)
        {

            AssignFlight.VerifyFlightTimeOut();

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
                FlightTimeEndTick.Start();
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

        private void Dashboard_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void btnCarrer_Click(object sender, EventArgs e)
        {
            AllHides();
            pilotCarrer.Show();
        }

    }
}
