﻿using System;
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
    public partial class ViewBooksForm : Form
    {
        public ViewBooksForm()
        {
            InitializeComponent();
        }

        private void ViewBooksForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'project1DataSet.bookTable' table. You can move, or remove it, as needed.
            this.bookTableTableAdapter.Fill(this.project1DataSet.bookTable);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
