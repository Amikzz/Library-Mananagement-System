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
    public partial class AddBookForm : Form
    {
        public AddBookForm()
        {
            InitializeComponent();
        }

        private void AddBookForm_Load(object sender, EventArgs e)
        {
            ControlBox = false;
        }

        private void addButton_Click(object sender, EventArgs e)
        {

            try
            {
                string title = bookNameText.Text;
                string author = authorText.Text;
                int isbn = Convert.ToInt32(isbnText.Text);

                if (title == "" || author == "" || isbn == 0)
                {
                    MessageBox.Show("Please fill all the fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    bookNameText.Text = "";
                    authorText.Text = "";
                    isbnText.Text = "";
                    return;
                }
                else if (isbn < 0)
                {
                    MessageBox.Show("ISBN cannot be negative", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    bookNameText.Text = "";
                    authorText.Text = "";
                    isbnText.Text = "";
                    return;
                }
                else
                {
                    Book book = new Book(title, author, isbn, true);

                    book.sqlInsert();

                    bookNameText.Text = "";
                    authorText.Text = "";
                    isbnText.Text = "";
                    return;
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Please enter valid details", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
