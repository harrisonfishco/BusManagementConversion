using Memoranda.Project;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Memoranda.Tour
{
    public partial class TourDialog : Form
    {
        private int editId = -1;
        private Tour tour = null;

        public TourDialog()
        {
            InitializeComponent();

            setUpComboBoxes();
        }


        public TourDialog(int tour)
        {
            InitializeComponent();

            editId = tour;
            this.tour = CurrentProject.getTourList().getTour(tour);

            setUpComboBoxes();
        }

        private void setUpComboBoxes()
        {
            foreach (Driver.Driver driver in CurrentProject.GetDriverList().GetAllDrivers())
            {
                driverField.Items.Add(driver);
            }

            foreach(Bus.Bus bus in CurrentProject.getBusList().getAllBuses())
            {
                busField.Items.Add(bus);
            }

            foreach (Route.Route route in CurrentProject.getRouteList().getAllRoutes())
            {
                routeField.Items.Add(route);
            }
        }
    }
}
