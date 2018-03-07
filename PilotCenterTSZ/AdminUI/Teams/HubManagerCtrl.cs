using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PilotCenterTSZ.AdminUI.Teams
{
    public partial class HubManagerCtrl : UserControl
    {
        public HubManagerCtrl()
        {
            InitializeComponent();
        }

        public void GetHub(string hub)
        {
            lblHubInfo.Text = String.Format("Hub ({0}) Manager", hub);
        }
    }
}
