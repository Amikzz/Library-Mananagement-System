using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Assignmnt
{
    public partial class LogIn : Form
    {
        public LogIn()
        {
            InitializeComponent();
        }

        private void LogIn_Load(object sender, EventArgs e)
        {
            ControlBox = false;
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            try
            {
                string username = usernameText.Text;
                string password = passwdText.Text;

                string connectionString = "Data Source=AMIKZZ;Initial Catalog=project1;Integrated Security=True;Encrypt=False";
                SqlConnection connection = new SqlConnection(connectionString);

                string query = "SELECT * FROM loginTable WHERE userName = '" + username + "' AND passwd = '" + password + "'";
                SqlCommand command = new SqlCommand(query, connection);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable table = new DataTable();
                adapter.Fill(table);

                if (table.Rows.Count <= 0)
                {
                    MessageBox.Show("Username or password is incorrect", "Unsuccessfull", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    usernameText.Text = "";
                    passwdText.Text = "";
                }
                else
                {
                    this.Hide();
                    MessageBox.Show("Login successful", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    Home home = new Home();
                    home.Show();
                }
            }
            catch(FormatException)
            {
                MessageBox.Show("Please enter a valid username and password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
