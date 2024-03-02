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
    public partial class DeleteBookForm : Form
    {
        public DeleteBookForm()
        {
            InitializeComponent();
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            try
            {
                int isbn = Convert.ToInt32(isbnText.Text);

                if (isbn == 0)
                {
                    MessageBox.Show("ISBN can't be 0", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    isbnText.Text = "";
                    return;
                }
                else if (isbn < 0)
                {
                    MessageBox.Show("ISBN cannot be negative", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    isbnText.Text = "";
                    return;
                }
                else
                {
                    Book book = new Book();
                    book.setISBN(isbn);

                    book.sqlDelete();

                    isbnText.Text = "";
                    return;
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Please enter valid details", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
