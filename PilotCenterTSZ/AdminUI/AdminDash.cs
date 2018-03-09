using System;
using System.Windows.Forms;
using ExamCenterTSZ.Functions;
using MySql.Data.MySqlClient;
using PilotCenterTSZ.AdminUI;

namespace PilotCenterTSZ
{
    public partial class AdminDash : Form
    {
        UserInfo a = new UserInfo();

        string Team;

        int TeamTag;

        public AdminDash()
        {
            InitializeComponent();
            lblWelcome.Text = String.Format("Have a nice {0}, {1} {2} {3} your Team is {4}", DateTime.UtcNow.DayOfWeek.ToString(), a.StaffName, a.UserName, a.UserSurname, a.StaffTeam);
            lblClock.Text = DateTime.UtcNow.ToString();
            ClockAdmin.Start();
            AddButton();
            lblTeam.Text = Team;
            
        }

        private void Hides()
        {
            allFlightsCtrl.Hide();
            pilotListCtrl.Hide();

            //buttons Team
            hubManagerCtrl.Hide();
        }

        public void AddButton()
        {

            string sqlStaffTeam = "SELECT stafflevel, adminlevel.name FROM utilizadores left join adminlevel on utilizadores.stafflevel = adminlevel.level where user_email=@Email";
            MySqlConnection conn = new MySqlConnection(Login.ConnectionString);

            try
            {
                conn.Open();

                MySqlCommand sqlCmd = new MySqlCommand(sqlStaffTeam, conn);
                sqlCmd.Parameters.AddWithValue("@Email", Properties.Settings.Default.Email);

                MySqlDataReader sqlCmdRes = sqlCmd.ExecuteReader();
                if (sqlCmdRes.HasRows)
                    while (sqlCmdRes.Read())
                    {
                        Team = (string)sqlCmdRes[1];
                        TeamTag = (int)sqlCmdRes[0];
                        switch ((int)sqlCmdRes[0])
                        {
                            case 1:
                                var ButtonHQ1 = new ButtonTeamAreaCtrl(Team, TeamTag);
                                ButtonHQ1.OnClickButtonTeamAreaCtrl += Button_OnClickButtonTeamAreaCtrlButtonHQ1;

                                var ButtonHQ2 = new ButtonTeamAreaCtrl("Event Team", 2);
                                ButtonHQ2.OnClickButtonTeamAreaCtrl += Button_OnClickButtonTeamAreaCtrlButtonHQ2;

                                var ButtonHQ3 = new ButtonTeamAreaCtrl("Flight Team", 3);
                                ButtonHQ3.OnClickButtonTeamAreaCtrl += Button_OnClickButtonTeamAreaCtrlButtonHQ3;

                                var ButtonHQ4 = new ButtonTeamAreaCtrl("Comunication", 0);
                                ButtonHQ4.OnClickButtonTeamAreaCtrl += Button_OnClickButtonTeamAreaCtrlButtonHQ4;

                                flowTeamArea.Controls.Add(ButtonHQ1);
                                flowTeamArea.Controls.Add(ButtonHQ2);
                                flowTeamArea.Controls.Add(ButtonHQ3);
                                flowTeamArea.Controls.Add(ButtonHQ4);
                                break;

                            case 2:
                                var ButtonET1 = new ButtonTeamAreaCtrl("Event Manager", TeamTag);
                                ButtonET1.OnClickButtonTeamAreaCtrl += Button_OnClickButtonTeamAreaCtrlButtonET1;

                                var ButtonET2 = new ButtonTeamAreaCtrl("Comunication", 0);
                                ButtonET2.OnClickButtonTeamAreaCtrl += Button_OnClickButtonTeamAreaCtrlButtonET2;

                                flowTeamArea.Controls.Add(ButtonET1);
                                flowTeamArea.Controls.Add(ButtonET2);
                                break;

                            case 3:
                                var ButtonFT1 = new ButtonTeamAreaCtrl("Hub Manager", TeamTag);
                                ButtonFT1.OnClickButtonTeamAreaCtrl += Button_OnClickButtonTeamAreaCtrlButtonFT1;

                                var ButtonFT2 = new ButtonTeamAreaCtrl("Comunication", 0);
                                ButtonFT2.OnClickButtonTeamAreaCtrl += Button_OnClickButtonTeamAreaCtrlButtonFT2;

                                flowTeamArea.Controls.Add(ButtonFT1);
                                flowTeamArea.Controls.Add(ButtonFT2);
                                break;

                            default:
                                break;
                        }
                    }
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

        private void Button_OnClickButtonTeamAreaCtrlButtonHQ1()
        {
            Hides();
        }

        private void Button_OnClickButtonTeamAreaCtrlButtonHQ2()
        {
            Hides();
        }

        private void Button_OnClickButtonTeamAreaCtrlButtonHQ3()
        {
            Hides();
        }

        private void Button_OnClickButtonTeamAreaCtrlButtonHQ4()
        {
            Hides();
        }

        private void Button_OnClickButtonTeamAreaCtrlButtonET1()
        {
            Hides();
        }

        private void Button_OnClickButtonTeamAreaCtrlButtonET2()
        {
            Hides();
        }

        private void Button_OnClickButtonTeamAreaCtrlButtonFT1()
        {
            Hides();
            hubManagerCtrl.GetHub(a.Hub);
            hubManagerCtrl.Show();
        }

        private void Button_OnClickButtonTeamAreaCtrlButtonFT2()
        {
            Hides();
        }

        private void btnPilotCenterFrm_Click(object sender, EventArgs e)
        {
            Hide();

            Dashboard d = new Dashboard();

            d.Show();
        }

        private void Clock_Tick(object sender, EventArgs e)
        {
            lblClock.Text = DateTime.UtcNow.ToString();
            lblWelcome.Text = String.Format("Have a nice {0}, {1} {2} {3} your Team is {4}", DateTime.UtcNow.DayOfWeek.ToString(), a.StaffName, a.UserName, a.UserSurname, a.StaffTeam);
        }

        private void AdminDash_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;

        }

        private void btnExitApp_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you really want to close me?",
                    "Are you sure?", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation,
                    MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnPilotList_Click(object sender, EventArgs e)
        {
            Hides();
            pilotListCtrl.Show();
        }

        private void btnAllFlights_Click(object sender, EventArgs e)
        {
            Hides();
            allFlightsCtrl.Show();
        }
    }
}
