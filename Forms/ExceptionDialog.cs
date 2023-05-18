using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Memoranda.Forms
{
    public partial class ExceptionDialog : Form
    {
        public ExceptionDialog()
        {
            InitializeComponent();
            Close();
        }

        public ExceptionDialog(Exception exception)
        {
            InitializeComponent();
            descriptionText.Text = exception.Message;
            stacktraceField.Text = exception.StackTrace;
#if DEBUG
            Console.WriteLine(exception.StackTrace);
#endif
            Show();
        }

        private void closeClick(object sender, EventArgs e)
        {
            Close();
        }
    }
}
