using System.Windows.Forms;

namespace PilotCenterTSZ.UI
{
    public partial class FlightAssignedCtrl : UserControl
    {
        public FlightAssignedCtrl()
        {
            InitializeComponent();
            UpdateInfos();

        }

        public void UpdateInfos()
        {

            AssignFlight f = new AssignFlight();

            f.VerifyFlightAssign();

            txtCallsign.Text = f.FlightCallsign;
            txtDep.Text = f.UserDeparture;
            txtArr.Text = f.UserArrival;
            txtAircraft.Text = f.UserAircraft;
            txtAssigned.Text = f.UserDateAssign.ToString(@"dd-MM-yyyy");

        }
    }
}
