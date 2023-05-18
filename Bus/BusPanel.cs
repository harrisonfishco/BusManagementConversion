using Memoranda.Project;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Memoranda.Bus
{
    internal class BusPanel : Panel
    {
        private BusListBox listbox;

        private ContextMenuStrip contextMenu;
        private ToolStripMenuItem addItem = new ToolStripMenuItem("Add Bus");
        private ToolStripMenuItem editItem = new ToolStripMenuItem("Edit Bus");
        private ToolStripMenuItem removeItem = new ToolStripMenuItem("Remove Bus");

        public BusPanel() : base()
        {
            Dock = DockStyle.Fill;

            listbox = new BusListBox();

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
            List<Bus> buses = CurrentProject.getBusList().getAllBuses();
            foreach (Bus bus in buses)
            {
                listbox.Items.Add(bus);
            }
        }

        private void toolStripClick(object sender, EventArgs e)
        {
            if(((ToolStripMenuItem)sender).Equals(addItem))
            {
                BusDialog busDialog = new BusDialog();
                busDialog.ShowDialog();
            } else if(((ToolStripMenuItem)sender).Equals(editItem))
            {
                Bus bus = listbox.getSelectedBus();
                BusDialog busDialog = new BusDialog(bus.getId(), bus.getSeats());
                busDialog.ShowDialog();
            } else if(((ToolStripMenuItem)sender).Equals(removeItem))
            {
                int busId = listbox.getSelectedBus().getId();
                BusDeleteWarning busDeleteWarning = new BusDeleteWarning(busId);
                busDeleteWarning.ShowDialog();
            }
            refreshListBox();
        }

        private void listboxClick(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Right) {
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
