using System;
using System.Windows.Forms;

namespace PilotCenterTSZ.UI
{
    public partial class MyLogBookCtrl : UserControl
    {
        public MyLogBookCtrl()
        {
            InitializeComponent();
            GetLogBook();
        }

        public void GetLogBook()
        {
            lstLogBook.Items.Clear();
            foreach (LogBook l in LogBook.Get())
            {
                lstLogBook.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
                lstLogBook.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
                lstLogBook.Items.Add(new ListViewItem(new string[]
                {
                    l.Callsign,
                    l.Departure,
                    l.Arrival,
                    l.Aircraft,
                    TimeSpan.FromMinutes(l.FlightTime).ToString(@"hh\:mm"),
                    l.FtPerMin.ToString(),
                    l.Sum.ToString(),
                    l.Eps.ToString()

                }));
            }
        }

        private void lstLogBook_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            myFlightView.Show();

            lstLogBook.Hide();

            myFlightView.Show();

            if (lstLogBook.SelectedItems.Count == 1)
            {
                myFlightView.GetFlightID(lstLogBook.SelectedItems[0].SubItems[0].Text, lstLogBook.SelectedItems[0].SubItems[1].Text, lstLogBook.SelectedItems[0].SubItems[2].Text, lstLogBook.SelectedItems[0].SubItems[3].Text, lstLogBook.SelectedItems[0].SubItems[4].Text);
            }

            lblDclick.Visible = false;
        }

    }
}
