using System.Windows.Forms;

namespace PilotCenterTSZ.UI
{
    public partial class FlightAssignmentCtrl : UserControl
    {
        public FlightAssignmentCtrl()
        {
            InitializeComponent();
            UpdateFlightInfo();

        }

        public void Actions()
        {
            UpdateFlightInfo();
        }

        public void UpdateFlightInfo()
        {

            AssignFlight f = new AssignFlight();

            f.VerifyFlightAssign();

            if (f.FlightID != 0)
            {
                flightAssignedCtrl.Show();
                assingmentCtrl.Hide();
            }
            else
            {
                flightAssignedCtrl.Hide();
                assingmentCtrl.Show();
            }
        }

        public void AlertFlight()
        {
            var b = this.Parent as Dashboard;

            b.AlertFlight();
        }

    }
}
