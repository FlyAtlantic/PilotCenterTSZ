using System;
using System.Windows.Forms;
using ExamCenterTSZ.Functions;

namespace PilotCenterTSZ
{
    public partial class LoginFrm : Form
    {
        StartImage InitialImg = new StartImage();

        public LoginFrm()
        {
            InitializeComponent();

            this.BringToFront();

            this.AcceptButton = btnLogin;

            ShowInTaskbar = false;

            InitialImg.Show();

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {

                Properties.Settings.Default.Email = txtEmail.Text;
                Properties.Settings.Default.Password = txtPassword.Text;

                Properties.Settings.Default.Save();

                if (Login.ValidateLogin(txtEmail.Text, txtPassword.Text))
                {
                    InitialImg.Hide();
                    Dashboard d = new Dashboard();
                    //login correto
                    d.Show();
                    this.Hide();

                }
                else
                {
                    MessageBox.Show("Login Failed", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            catch (Exception crap)
            {
                MessageBox.Show(crap.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoginFrm_Load(object sender, EventArgs e)
        {
            Properties.Settings.Default.Reload();
            txtEmail.Text = Properties.Settings.Default.Email;
            txtPassword.Text = Properties.Settings.Default.Password;
        }
    }
}
