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

namespace Memoranda.Driver
{
    public partial class DriverDialog : Form
    {
        private int editId = -1;
        public DriverDialog()
        {
            InitializeComponent();
        }

        public DriverDialog(int id, string name, string phone)
        {
            InitializeComponent();
            idField.Value = id;
            nameField.Text = name;
            phoneField.Text = phone;

            editId = id;
        }

        public bool validate()
        {
            if(idField.Value < 0)
            {
                idLabel.Text = "ID - Cannot be negative";
                idLabel.ForeColor = Color.Red;
                return false;
            }

            if(nameField.Text == "")
            {
                nameLabel.ForeColor = Color.Red;
                return false;
            }

            if(phoneField.Text == "") 
            {
                phoneLabel.ForeColor = Color.Red;   
            }

            if((int)idField.Value != editId)
            {
                if(CurrentProject.GetDriverList().getDriver((int)idField.Value) != null)
                {
                    idLabel.Text = "ID - already exists";
                    idLabel.ForeColor = Color.Red;
                    return false;
                }
            }

            if(editId == -1)
            {
                CurrentProject.GetDriverList().addDriver((int)idField.Value, nameField.Text, phoneField.Text);
            }
            else
            {
                CurrentProject.GetDriverList().removeDriver(editId);
                CurrentProject.GetDriverList().addDriver((int)idField.Value, nameField.Text, phoneField.Text);
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
