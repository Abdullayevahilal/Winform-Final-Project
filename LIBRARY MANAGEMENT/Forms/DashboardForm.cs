﻿using LIBRARY_MANAGEMENT.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LIBRARY_MANAGEMENT.Forms
{
    public partial class DashboardForm : Form

        
    {private readonly LibraryDbContext _context;
        public DashboardForm()
        {
            InitializeComponent();
        _context = new LibraryDbContext();
    }

         //Open BookForm
        private void BtnBook_Click(object sender, EventArgs e)
        { 
            BookForm book = new BookForm();
            book.ShowDialog();
        }
        //Open UserForm
        private void BtnUser_Click(object sender, EventArgs e)
        {
            UserForm user = new UserForm();
            user.ShowDialog();
        }
        //Open CustomerForm
        private void BtnCustomer_Click(object sender, EventArgs e)
        {
            CustomerForm Customer = new CustomerForm();
            Customer.ShowDialog();
        }

        private void BtnOrder_Click(object sender, EventArgs e)
        {
            OrderForm Order = new OrderForm();
            Order.ShowDialog();
        }

        private void BtnReturnBook_Click(object sender, EventArgs e)
        {
            ReturnOrderBookForm Return = new ReturnOrderBookForm();
            Return.ShowDialog();
        }

        private void DashboardForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
