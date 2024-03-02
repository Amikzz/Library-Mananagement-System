using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignmnt
{
    public partial class LogViewForm : Form
    {
        public LogViewForm()
        {
            InitializeComponent();
        }

        private void LogvView_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'project1DataSet1.logTable' table. You can move, or remove it, as needed.
            this.logTableTableAdapter.Fill(this.project1DataSet1.logTable);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
