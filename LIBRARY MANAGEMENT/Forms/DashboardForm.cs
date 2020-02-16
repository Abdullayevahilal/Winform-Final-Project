using LIBRARY_MANAGEMENT.Data;
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

        private void DashboardForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
        private void BtnCustomer_Click_1(object sender, EventArgs e)
        {
            CustomerForm Customer = new CustomerForm();
            Customer.ShowDialog();
        }

        private void BtnOrder_Click_1(object sender, EventArgs e)
        {
            OrderForm Order = new OrderForm();
            Order.ShowDialog();
        }

        private void BtnReturn_Click(object sender, EventArgs e)
        {
            ReturnOrderBookForm Return = new ReturnOrderBookForm();
            Return.ShowDialog();
        }

        private void BtnBook_Click_1(object sender, EventArgs e)
        {
            BookForm book = new BookForm();
            book.ShowDialog();
        }

        private void BtnUser_Click_1(object sender, EventArgs e)
        {
            UserForm user = new UserForm();
            user.ShowDialog();
        }

        private void BtnReport_Click_1(object sender, EventArgs e)
        {
            ReportForm Report = new ReportForm();
            Report.Show();
        }
    }
}
