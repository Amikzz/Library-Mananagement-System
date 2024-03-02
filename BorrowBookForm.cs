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
    public partial class BorrowBookForm : Form
    {
        public BorrowBookForm()
        {
            InitializeComponent();
        }

        private void borrowButton_Click(object sender, EventArgs e)
        {
            try
            {
                string bookName = bookNameText.Text;
                int isbn = Convert.ToInt32(isbnText.Text);
                int memberID = Convert.ToInt32(memberIDInput.Text);

                if (bookName == "" || isbn == 0 || memberID == 0)
                {
                    MessageBox.Show("Please fill all the fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    bookNameText.Text = "";
                    isbnText.Text = "";
                    memberIDInput.Text = "";
                    return;
                }
                else if (isbn < 0 || memberID < 0)
                {
                    MessageBox.Show("ISBN and Member ID cannot be negative", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    bookNameText.Text = "";
                    isbnText.Text = "";
                    memberIDInput.Text = "";
                    return;
                }
                else
                {
                    Book book = new Book();
                    book.setISBN(isbn);
                    book.sqlBorrow(memberID);

                    bookNameText.Text = "";
                    isbnText.Text = "";
                    memberIDInput.Text = "";
                    return;
                }
            } 
            catch (FormatException)
            {
                MessageBox.Show("Please enter a valid number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                bookNameText.Text = "";
                isbnText.Text = "";
                memberIDInput.Text = "";
                return;
            } 
            catch (Exception)
            {
                MessageBox.Show("An error occured", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                bookNameText.Text = "";
                isbnText.Text = "";
                memberIDInput.Text = "";
                return;
            }
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
