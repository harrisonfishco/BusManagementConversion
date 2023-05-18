using Memoranda.Project;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Memoranda.Driver
{
    public partial class DriverDeleteWarning : Form
    {
        private int driverToDelete;
        public DriverDeleteWarning()
        {
            InitializeComponent();
            throw new Exception("NEED TO DEFINE DRIVER");
        }

        public DriverDeleteWarning(int driver)
        {
            InitializeComponent();
            if(CurrentProject.GetDriverList().getDriver(driver) != null)
            {
                driverToDelete = driver;
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
            CurrentProject.GetDriverList().removeDriver(driverToDelete);
            Close();
        }
    }
}
