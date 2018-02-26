using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
 
namespace AdminCenter
{
    public partial class AdminDash : Form
    {
        public AdminDash()
        {
            InitializeComponent();
        }

        private void btnPilotCenterFrm_Click(object sender, EventArgs e)
        {
            Hide();

            //PilotCenterTSZ p = new PilotCenterTSZ();
        }

        private void AdminDash_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
