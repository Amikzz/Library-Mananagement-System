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
    public partial class cliguiForm : Form
    {
        public cliguiForm()
        {
            InitializeComponent();
            ControlBox = false;
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonCMD_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(@"C:\Users\Lenovo\source\repos\CLI Assignment LBS\bin\Debug\net8.0\CLI Assignment LBS.exe");
        }

        private void buttonGUI_Click(object sender, EventArgs e)
        {
            LogIn logIn = new LogIn();
            logIn.Show();
            this.Hide();
        }
    }
}
