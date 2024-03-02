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
    public partial class Home : Form
    {
        Library library = new Library();

        public Home()
        {
            InitializeComponent();
        }

        private void Home_Load(object sender, EventArgs e)
        {
            ControlBox = false; 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void addBookButton_Click(object sender, EventArgs e)
        {
            AddBookForm addBookForm = new AddBookForm();
            addBookForm.Show();
        }

        private void removeBookButton_Click(object sender, EventArgs e)
        {
            DeleteBookForm deleteBookForm = new DeleteBookForm();
            deleteBookForm.Show();
        }

        private void borrowButton_Click(object sender, EventArgs e)
        {
            BorrowBookForm borrowBookForm = new BorrowBookForm();
            borrowBookForm.Show();
        }

        private void returnButton_Click(object sender, EventArgs e)
        {
            ReturnBookForm returnBookForm = new ReturnBookForm();   
            returnBookForm.Show();
        }

        private void viewBooksButton_Click(object sender, EventArgs e)
        {
            ViewBooksForm viewBooksForm = new ViewBooksForm();
            viewBooksForm.Show();
        }

        private void viewLogButton_Click(object sender, EventArgs e)
        {
            LogViewForm logViewForm = new LogViewForm();    
            logViewForm.Show();
        }
    }
}
