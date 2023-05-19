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

namespace Memoranda.Route
{
    public partial class RouteDeleteWarning : Form
    {
        private int routeToDelete;

        public RouteDeleteWarning()
        {
            InitializeComponent();
            throw new Exception("NEED TO DEFINE ROUTE");
        }

        public RouteDeleteWarning(int route)
        {
            InitializeComponent();
            if(CurrentProject.getRouteList().getRoute(route) != null)
            {
                routeToDelete = route;
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
            CurrentProject.getRouteList().removeRoute(routeToDelete);
            Close();
        }
    }
}
