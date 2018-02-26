using System;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace PilotCenterTSZ.UI
{
    public partial class PilotAccountCtrl : UserControl
    {

        public PilotAccountCtrl()
        {
            InitializeComponent();
            PilotInfos();
            Typeratings();
            Qualifications();
            Efficiency();
            AwardHour();
            FlightsOnDayGraphic();
        }

        public void Actions()
        {
            PilotInfos();
            Typeratings();
            Qualifications();
            Efficiency();
            AwardHour();
            FlightsOnDayGraphic();
        }

        public void PilotInfos()
        {
            UserInfo a = new UserInfo();

            double flightHours = Convert.ToDouble(a.PilotHours.TotalHours.ToString());
            double flightMinutes = Convert.ToDouble(a.PilotHours.Minutes);

            lblName.Text = a.UserName + ' ' + a.UserSurname;
            lblRank.Text = a.Rank;
            lblRatingVacc.Text = a.Rate;
            lblCallsign.Text = "TSZ" + a.Callsign;
            lblFlightHours.Text = Math.Truncate(flightHours).ToString() + ':' + Math.Truncate(flightMinutes).ToString();
            lblLastFlightDate.Text = a.LastFlight.ToString(@"dd-MM-yyyy");
            lblHub.Text = a.Hub;
            lblLocation.Text = a.Location;
            lblEps.Text = a.Eps.ToString();

            switch (a.RankID)
            {
                case 1:
                    imgRank.Image = Properties.Resources.student;
                    break;
                case 2:
                    imgRank.Image = Properties.Resources.seniorstudent;
                    break;
                case 3:
                    imgRank.Image = Properties.Resources.secondofficer;
                    break;
                case 4:
                    imgRank.Image = Properties.Resources.firstofficer;
                    break;
                case 5:
                    imgRank.Image = Properties.Resources.captain;
                    break;
                case 6:
                    imgRank.Image = Properties.Resources.seniorcaptain;
                    break;
                case 7:
                    imgRank.Image = Properties.Resources.flightinstructor;
                    break;

                default:
                    break;
            }
        }

        public void Typeratings()
        {
            listTyperatings.Items.Clear();
            foreach (TypeRating t in TypeRating.Get())
            {
                listTyperatings.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
                listTyperatings.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
                listTyperatings.Items.Add(new ListViewItem(new string[]
                {
                    t.TypeRatingName,
                    t.Validity.ToString(@"dd-MM-yyyy"),
                    t.Expiration.ToString(@"dd-MM-yyyy")

                }));

            }
        }

        public void Qualifications()
        {
            listQualifications.Items.Clear();
            foreach (Qualification t in Qualification.Get())
            {
                listQualifications.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
                listQualifications.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
                listQualifications.Items.Add(new ListViewItem(new string[]
                {
                    t.QualificationName,
                    t.Validity.ToString(@"dd-MM-yyyy"),
                    t.Expiration.ToString(@"dd-MM-yyyy")

                }));

            }
        }

        public void Efficiency()
        {
            UserOverallEfficiency h = new UserOverallEfficiency();

            cProgressBarOverall.Value = h.Efficiency;

            if (h.Efficiency < 25)
            {
                cProgressBarOverall.ForeColor = Color.Firebrick;
                cProgressBarOverall.ProgressColor = Color.Firebrick;
            }
            if (h.Efficiency < 50 && h.Efficiency >= 25)
            {
                cProgressBarOverall.ForeColor = Color.Chocolate;
                cProgressBarOverall.ProgressColor = Color.Chocolate;
            }
            if (h.Efficiency < 75 && h.Efficiency >= 50)
            {
                cProgressBarOverall.ForeColor = Color.Goldenrod;
                cProgressBarOverall.ProgressColor = Color.Goldenrod;
            }
            if (h.Efficiency < 100 && h.Efficiency >= 75)
            {
                cProgressBarOverall.ForeColor = Color.ForestGreen;
                cProgressBarOverall.ProgressColor = Color.ForestGreen;
            }
        }

        public void AwardHour()
        {
            UserInfo a = new UserInfo();
            UserHourAward h = new UserHourAward();

            double flightHours = Convert.ToDouble(a.PilotHours.TotalHours.ToString());
            int progressValue = (Convert.ToInt32(Math.Truncate(flightHours)) * 100) / h.AwardMinHours;

            lblHourAward.Text = String.Format("{0} Hour Award", h.AwardEps);

            if (progressValue >= 100)
            {
                cProgressHourAward.Value = 100;
                awardHourReceive.GetAwardInformations(h.AwardEps, h.AwardMinHours, h.AwardID);
                awardHourReceive.Show();
            }
            else
                cProgressHourAward.Value = progressValue;


        }

        public void FlightsOnDayGraphic()
        {
            var chart = chartFlightsDay.ChartAreas[0];
            chart.AxisX.IntervalType = DateTimeIntervalType.Number;

            chart.AxisX.LabelStyle.Format = "";
            chart.AxisY.LabelStyle.Format = "";
            chart.AxisY.LabelStyle.IsEndLabelVisible = true;

            chart.AxisX.Minimum = 1;
            chart.AxisX.Maximum = 31;
            chart.AxisX.Interval = 2;

            chartFlightsDay.Series.Clear();
            chartFlightsDay.Series.Add("# Flights per day");
            chartFlightsDay.Series["# Flights per day"].ChartType = SeriesChartType.RangeColumn;
            chartFlightsDay.Series["# Flights per day"].Color = Color.MediumBlue;
            chartFlightsDay.Series[0].IsVisibleInLegend = false;

            foreach (UserStatistics s in UserStatistics.Get())
            {
                chartFlightsDay.Series["# Flights per day"].Points.AddXY(s.Day, s.NumFlights);

                if (s.NumFlights < 5)
                {
                    chart.AxisY.Minimum = 0;
                    chart.AxisY.Maximum = 5;
                    chart.AxisY.Interval = 1;
                }
                else if (s.NumFlights >= 5 && s.NumFlights < 10)
                {
                    chart.AxisY.Minimum = 0;
                    chart.AxisY.Maximum = 10;
                    chart.AxisY.Interval = 1;
                }
                else if (s.NumFlights >= 10 && s.NumFlights < 20)
                {
                    chart.AxisY.Minimum = 0;
                    chart.AxisY.Maximum = 20;
                    chart.AxisY.Interval = 2;
                }
            }

        }
    }
}
