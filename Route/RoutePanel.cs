using Memoranda.Project;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Memoranda.Route
{
    internal class RoutePanel : Panel
    {
        private RouteListBox listbox;

        private ContextMenuStrip contextMenu;
        private ToolStripMenuItem addItem = new ToolStripMenuItem("Add Route");
        private ToolStripMenuItem editItem = new ToolStripMenuItem("Edit Route");
        private ToolStripMenuItem removeItem = new ToolStripMenuItem("Remove Route");

        public RoutePanel() : base()
        {
            Dock = DockStyle.Fill;

            listbox = new RouteListBox();

            listbox.Dock = DockStyle.Fill;
            listbox.MouseUp += listboxClick;

            refreshListBox();

            Controls.Add(listbox);

            contextMenu = new ContextMenuStrip();
            addItem.Click += toolStripClick;
            editItem.Click += toolStripClick;
            removeItem.Click += toolStripClick;

            contextMenu.Items.Add(addItem);
            contextMenu.Items.Add(editItem);
            contextMenu.Items.Add(removeItem);
        }

        public void refreshListBox()
        {
            listbox.Items.Clear();
            List<Route> routes = CurrentProject.getRouteList().getAllRoutes();
            foreach (Route route in routes)
            {
                listbox.Items.Add(route);
            }
        }

        private void toolStripClick(object sender, EventArgs e)
        {
            if(((ToolStripMenuItem)sender).Equals(addItem))
            {
                RouteDialog dialog = new RouteDialog();
                dialog.ShowDialog();
            }
            else if(((ToolStripMenuItem)sender).Equals(editItem))
            {
                Route route = listbox.getSelectedRoute();
                RouteDialog dialog = new RouteDialog(route.getId());
                dialog.ShowDialog();
            }
            else if(((ToolStripMenuItem)sender).Equals(removeItem))
            {
                RouteDeleteWarning dialog = new RouteDeleteWarning(listbox.getSelectedRoute().getId());
                dialog.ShowDialog();
            }
            refreshListBox();
        }

        private void listboxClick(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Right)
            {
                int itemIndex = listbox.IndexFromPoint(e.Location);
                if(itemIndex >= 0 && itemIndex < listbox.Items.Count)
                {
                    listbox.SelectedIndex = itemIndex;
                    editItem.Enabled = true;
                    removeItem.Enabled = true;
                }
                else
                {
                    listbox.SelectedIndex = -1;
                    editItem.Enabled = false;
                    removeItem.Enabled = false;
                }
                contextMenu.Show(this, e.Location);
            }
        }
    }
}
