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
    public partial class BusDialog : Form
    {

        private int editId = -1;

        public BusDialog()
        {
            InitializeComponent();
        }

        public BusDialog(int id, int seats)
        {
            InitializeComponent();

            idField.Value = id;
            seatsField.Value = seats;

            editId = id;
        }

        public int getId()
        {
            return (int)idField.Value;
        }

        public int getSeats()
        {
            return (int)seatsField.Value;
        }

        public bool validate()
        {
            if(idField.Value < 0) 
            {
                idLabel.Text = "ID - Cannot be negative";
                idLabel.ForeColor = Color.Red;
                return false;
            }

            if(seatsField.Value < 1)
            {
                seatsLabel.Text = "Invalid Seats";
                seatsLabel.ForeColor = Color.Red;
                return false;
            }

            if((int)idField.Value != editId)
            {
                if(CurrentProject.getBusList().getBus((int)idField.Value) != null)
                {
                    idLabel.Text = "ID - already exists";
                    idLabel.ForeColor = Color.Red;
                    return false;
                }
            }

            if(editId == -1)
            {
                CurrentProject.getBusList().addBus((int)idField.Value, (int)seatsField.Value);
            } 
            else
            {
                CurrentProject.getBusList().removeBus(editId);
                CurrentProject.getBusList().addBus((int)idField.Value, (int)seatsField.Value);
            }

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
