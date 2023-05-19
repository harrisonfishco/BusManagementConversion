using Memoranda.Project;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Memoranda.Tour
{
    internal class TourPanel : Panel
    {
        private TourListBox listbox;

        private ContextMenuStrip contextMenu;
        private ToolStripMenuItem addItem = new ToolStripMenuItem("Add Tour");
        private ToolStripMenuItem editItem = new ToolStripMenuItem("Edit Tour");
        private ToolStripMenuItem removeItem = new ToolStripMenuItem("Remove Tour");

        public TourPanel() : base()
        {
            Dock = DockStyle.Fill;

            listbox = new TourListBox();

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
            List<Tour> tours = CurrentProject.getTourList().getAllTours();
            foreach(Tour tour in tours)
            {
                listbox.Items.Add(tour);
            }
        }

        private void toolStripClick(object sender, EventArgs e)
        {
            if(((ToolStripMenuItem)sender).Equals(addItem))
            {
                TourDialog dialog = new TourDialog();
                dialog.ShowDialog();
            } 
            else if(((ToolStripMenuItem)sender).Equals(editItem))
            {
                Tour tour = listbox.getSelectedTour();
                TourDialog dialog = new TourDialog(tour.getID());
                dialog.Show();
            }
            else if(((ToolStripMenuItem)sender).Equals(removeItem)) {
                TourDeleteWarning dialog = new TourDeleteWarning(listbox.getSelectedTour().getID());
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
