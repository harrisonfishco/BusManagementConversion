using Memoranda.Project;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Memoranda.Driver
{
    internal class DriverPanel : Panel
    {
        private DriverListBox listbox;

        private ContextMenuStrip contextMenu;
        private ToolStripMenuItem addItem = new ToolStripMenuItem("Add Driver");
        private ToolStripMenuItem editItem = new ToolStripMenuItem("Edit Driver");
        private ToolStripMenuItem removeItem = new ToolStripMenuItem("Remove Driver");

        public DriverPanel() : base()
        {
            Dock = DockStyle.Fill;

            listbox = new DriverListBox();

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
            List<Driver> drivers = CurrentProject.GetDriverList().GetAllDrivers();
            foreach(Driver driver in drivers)
            {
                listbox.Items.Add(driver);
            }
        }

        private void toolStripClick(object sender, EventArgs e)
        {
            if(((ToolStripMenuItem)sender).Equals(addItem))
            {
                DriverDialog driverDialog = new DriverDialog();
                driverDialog.ShowDialog();
            } else if(((ToolStripMenuItem)sender).Equals(editItem))
            {
                Driver driver = listbox.getSelectedDriver();
                DriverDialog driverDialog = new DriverDialog(driver.getID(), driver.getName(), driver.getPhone());
                driverDialog.ShowDialog();
            } else if(((ToolStripMenuItem)sender).Equals(removeItem))
            {
                int driverId = listbox.getSelectedDriver().getID();
                new DriverDeleteWarning(driverId).ShowDialog();
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
