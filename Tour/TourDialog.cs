using Memoranda.Project;
using Memoranda.Util;
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

            idField.Text = editId.ToString();
            dateField.SelectionStart = this.tour.getStartDate().toDateTime();
            timeField.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, this.tour.getStartTime().Hours, this.tour.getStartTime().Minutes, 0);

            driverField.SelectedItem = this.tour.getDriver();
            busField.SelectedItem = this.tour.getBus();
            routeField.SelectedItem = this.tour.getRoute();
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

        public bool validate()
        {
            if(idField.Value < 0)
            {
                idLabel.Text = "ID - Cannot be negative";
                idLabel.ForeColor = Color.Red;
                return false;
            }

            Console.WriteLine(driverField.SelectedIndex);

            if (driverField.SelectedIndex == -1)
            {
                driverLabel.ForeColor = Color.Red;
                return false;
            }

            if(busField.SelectedIndex == -1)
            {
                busLabel.ForeColor = Color.Red;
                return false;
            }

            if(routeField.SelectedIndex == -1)
            {
                routeLabel.ForeColor = Color.Red;
                return false;
            }

            if(editId != -1)
            {
                CurrentProject.getTourList().removeTour(editId);
            }
            CurrentProject.getTourList().addTour((int)idField.Value, 
                new CalendarDate(dateField.SelectionStart), 
                new TimeSpan(0, timeField.Value.Hour, timeField.Value.Minute), 
                driverField.SelectedItem as Driver.Driver, 
                busField.SelectedItem as Bus.Bus, 
                routeField.SelectedItem as Route.Route
            );

            return true;
        }

        private void cancel(object sender, EventArgs e)
        {
            Close();
        }

        private void ok(object sender, EventArgs e)
        {
            if(validate())
            {
                Close();
            }
        }
    }
}
