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
    public partial class TourDeleteWarning : Form
    {
        private int tourToDelete;

        public TourDeleteWarning()
        {
            InitializeComponent();
            throw new Exception("NEED TO DEFINE TOUR");
        }

        public TourDeleteWarning(int tour)
        {
            InitializeComponent();
            if(CurrentProject.getTourList().getTour(tour) != null)
            {
                tourToDelete = tour;
            } 
            else
            {
                Close();
            }
        }

        private void cancel(object sender, EventArgs e)
        {
            Close();
        }

        private void ok(object sender, EventArgs e)
        {
            CurrentProject.getTourList().removeTour(tourToDelete);
            Close();
        }
    }
}
