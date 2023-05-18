using Memoranda.Bus;
using Memoranda.Driver;
using Memoranda.Project;
using Memoranda.Route;
using Memoranda.Tour;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Memoranda
{
    public partial class Main : Form
    {
        private TourPanel tourPanel;
        private RoutePanel routePanel;
        private DriverPanel driverPanel;
        private BusPanel busPanel;

        private Panel currentPanel;

        private About aboutForm;

        public Main()
        {
            InitializeComponent();

            tourPanel = new TourPanel();
            routePanel = new RoutePanel();
            busPanel = new BusPanel();
            driverPanel = new DriverPanel();

            currentPanel = tourPanel;
        }

        private void SplitterPaint(object sender, PaintEventArgs e)
        {
            SplitContainer s = sender as SplitContainer;
            if(s != null)
            {
                e.Graphics.FillRectangle(Brushes.LightGray, s.SplitterRectangle);
            }
        }

        private void Main_Load(object sender, EventArgs e)
        {
            mainContainer.Panel2.Controls.Add(currentPanel);
            toolStripVersionNumber.Text = Constants.VERSION;
        }

        private void selectTab(object sender, EventArgs e)
        {
            mainContainer.Panel2.Controls.Clear();
            if(sender.Equals(TourButton))
            {
                currentPanel = tourPanel;
            }
            else if(sender.Equals(RoutesButton))
            {
                currentPanel = routePanel;
            }
            else if(sender.Equals(DriversButton)) 
            {
                currentPanel = driverPanel;
            } 
            else if(sender.Equals(BusesButton))
            {
                currentPanel = busPanel;
            }
            mainContainer.Panel2.Controls.Add(currentPanel);
        }

        private void FormResize(object sender, EventArgs e)
        {
            mainContainer.Refresh();
        }

        private void aboutProjectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            aboutForm = new About();
            aboutForm.ShowDialog();
        }

        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            CurrentProject.save();
            Console.WriteLine("Saved Project");
        }

        private void quitProgram(object sender, EventArgs e)
        {
            Close();
        }
    }
}
