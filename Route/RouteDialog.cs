using GMap.NET;
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms;
using Memoranda.Forms;
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
    public partial class RouteDialog : Form
    {
        private int editId = -1;
        private Route route = null;

        private List<PointLatLng> nodes = new List<PointLatLng>();

        private PointLatLng? start = null;
        private PointLatLng? end = null;

        private GMapControl mapControl;
        private GMapOverlay mapOverlay;

        public RouteDialog()
        {
            InitializeComponent();
            setupMap();
        }

        public RouteDialog(int route)
        {
            InitializeComponent();
            setupMap();

            editId = route;
            this.route = CurrentProject.getRouteList().getRoute(route);
            this.nodes = this.route.getNodes();

            paintRoute(this.route.getNodes());
        }

        public bool validate()
        {
            if(nameField.Text == "")
            {
                nameLabel.ForeColor = Color.Red;
                return false;
            }

            if(nodes.Count == 0)
            {
                if(start == null)
                {
                    mapLabel.ForeColor = Color.Red;
                    mapLabel.Text = "Map - Select Two Points";
                } 
                else if(end == null)
                {
                    mapLabel.ForeColor = Color.Red;
                    mapLabel.Text = "Map - Select Destination Point";
                }
                return false;
            }

            if (route == null)
            {
                CurrentProject.getRouteList().addRoute(Util.Util.generateRouteId(), nameField.Text, nodes, float.Parse(distanceField.Text), int.Parse(durationField.Text));
            } 
            else
            {
                CurrentProject.getRouteList().removeRoute(editId);
                CurrentProject.getRouteList().addRoute(editId, nameField.Text, nodes, float.Parse(distanceField.Text), int.Parse(durationField.Text));
            }

            return true;
        }

        private void setupMap()
        {
            mapControl = new GMapControl();
            mapControl.Dock = DockStyle.Fill;
            mapPanel.Controls.Add(mapControl);

            GMap.NET.GMaps.Instance.Mode = GMap.NET.AccessMode.ServerOnly;
            mapOverlay = new GMapOverlay("Route");

            mapControl.MapProvider = GMap.NET.MapProviders.GMapProviders.OpenStreetMapGraphHopper;
            mapControl.Position = new GMap.NET.PointLatLng((double)33.30723, (double)-111.67653);
            mapControl.Overlays.Add(mapOverlay);
            mapControl.MinZoom = 16;
            mapControl.MaxZoom = 20;
            mapControl.Zoom = 16;
            mapControl.MouseDown += mapClick;
        }

        private void paintRoute(List<PointLatLng> points)
        {
            mapOverlay.Clear();
            GMapRoute route = new GMapRoute(points, "Route");

            route.Stroke = new Pen(Color.Red, 3);

            mapOverlay.Routes.Add(route);

            mapControl.Refresh();
            mapControl.UpdateRouteLocalPosition(route);
        }

        private void RouteDialog_Load(object sender, EventArgs e)
        {
            mapControl.CanDragMap = false;
            mapControl.ShowCenter = false;
            mapControl.MouseWheelZoomEnabled = false;
#if DEBUG
            mapControl.OnPositionChanged += onPointChange;
            mapControl.CanDragMap = true;
            mapControl.ShowCenter = true;
            mapControl.MouseWheelZoomEnabled = true;
            mapControl.MouseWheelZoomType = MouseWheelZoomType.ViewCenter;
#endif
        }

        private void mapClick(object sender, MouseEventArgs e)
        {
            PointLatLng loc = mapControl.FromLocalToLatLng(e.X, e.Y);
            if (!start.HasValue)
            {
                start = loc;
            }
            else if (!end.HasValue)
            {
                end = loc;
                nodes.Clear();
                List<PointLatLng> newRoute = Util.GraphHopper.calculateRoute(start.Value, end.Value, distanceField, durationField);
                if (newRoute != null)
                {
                    nodes.AddRange(newRoute);
                    paintRoute(nodes);
                }
            }
            else
            {
                start = end = null;
                durationField.Text = "";
                distanceField.Text = "";
                nodes.Clear();
                paintRoute(nodes);
            }
        }

#if DEBUG
        private void onPointChange(PointLatLng point)
        {
            Console.WriteLine(point.Lat.ToString() + " - " + point.Lng.ToString());
        }
#endif
        private void ok(object sender, EventArgs e)
        {
            if(validate())
            {
                Close();
            }
        }

        private void cancel(object sender, EventArgs e)
        {
            Close();
        }
    }
}
