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

namespace Memoranda.Bus
{
    public partial class BusDeleteWarning : Form
    {
        private int busToDelete;
        public BusDeleteWarning()
        {
            InitializeComponent();
            throw new Exception("NEED TO DEFINE BUS");
        }

        public BusDeleteWarning(int bus)
        {
            InitializeComponent();
            if(CurrentProject.getBusList().getBus(bus) != null)
            {
                busToDelete = bus;
            } else
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
            CurrentProject.getBusList().removeBus(busToDelete);
            Close();
        }
    }
}
