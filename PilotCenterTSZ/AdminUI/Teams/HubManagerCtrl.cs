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
    public partial class HubManagerCtrl : UserControl
    {
        string Hub;

        public HubManagerCtrl()
        {
            InitializeComponent();
        }

        public void GetHub(string hub)
        {
            Hub = hub;

            lblHubInfo.Text = String.Format("Hub ({0}) Manager", hub);
        }

        private void btnViewRoutes_Click(object sender, EventArgs e)
        {
            viewHubRoutesCtrl1.GetRoutes(Hub);
            viewHubRoutesCtrl1.Show();
        }
    }
}
