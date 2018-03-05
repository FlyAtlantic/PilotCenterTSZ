using System;
using System.Windows.Forms;

namespace PilotCenterTSZ
{
    public partial class AdminDash : Form
    {
        UserInfo a = new UserInfo();

        public AdminDash()
        {
            InitializeComponent();

            ClockAdmin.Start();
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
            lblWelcome.Text = String.Format("Have a nice {0}, {1} {2} {3}", DateTime.UtcNow.DayOfWeek.ToString(), a.Rank, a.UserName, a.UserSurname);
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
    }
}
