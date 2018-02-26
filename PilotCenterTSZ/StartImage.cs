using System;
using System.Drawing;
using System.Reflection;
using System.Windows.Forms;
using ExamCenterUpdate;

namespace PilotCenterTSZ
{
    public partial class StartImage : Form, ExamCenterUpdatable
    {
        private ExamCenterUpdater updater;

        public StartImage()
        {
            ShowInTaskbar = false;

            InitializeComponent();

            label1.Text = String.Format("Version: {0}", this.ApplicationAssembly.GetName().Version.ToString());
            updater = new ExamCenterUpdater(this);

            updater.DoUpdate();
        }

        public string ApplicationName
        {
            get { return "PilotCenterTSZ"; }
        }

        public string ApplicationID
        {
            get { return "PilotCenterTSZ"; }
        }

        public Assembly ApplicationAssembly
        {
            get { return Assembly.GetExecutingAssembly(); }
        }

        public Icon ApplicationIcon
        {
            get { return this.Icon; }
        }

        public Uri UpdateXmlLocation
        {
            get { return new Uri("http://flyatlantic-va.com/site/programsC/complete/updatePilotCenter.xml"); }
        }

        public Form Context
        {
            get { return this; }
        }

    }
}
