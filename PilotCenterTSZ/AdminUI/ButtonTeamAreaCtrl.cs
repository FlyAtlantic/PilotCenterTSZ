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
    public partial class ButtonTeamAreaCtrl : UserControl
    {
        public ButtonTeamAreaCtrl(string name, int tag)
        {
            InitializeComponent();

            btnTeam.Text = name;
            btnTeam.Tag = tag;
        }

        private void btnLogBook_Click(object sender, EventArgs e)
        {
            OnClickButtonTeamAreaCtrl();
        }

        public delegate void ClickButtonTeamAreaCtrl();
        public event ClickButtonTeamAreaCtrl OnClickButtonTeamAreaCtrl;
    }
}
