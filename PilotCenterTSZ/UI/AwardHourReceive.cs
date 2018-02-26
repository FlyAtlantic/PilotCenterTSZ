using System;
using System.Windows.Forms;
using Bunifu;

namespace PilotCenterTSZ.UI
{
    public partial class AwardHourReceive : UserControl
    {
        public int AwardEps
        { get; set; }

        public int AwardID
        { get; set; }

        public AwardHourReceive()
        {
            InitializeComponent();
        }

        public void GetAwardInformations(int awardEps, int awardMinHours, int awardID)
        {
            AwardID = awardID;
            AwardEps = awardEps;

            lblAwardInfo.Text = String.Format("You have {0} ep's to receive for the {1} hour prize", awardEps, awardMinHours);
        }

        private void btnReceive_Click(object sender, EventArgs e)
        {
            UserHourAward.SendAwardEps(AwardID, AwardEps);

            var d = this.Parent as PilotAccountCtrl;

            d.Actions();

            Hide();
        }
    }
}
