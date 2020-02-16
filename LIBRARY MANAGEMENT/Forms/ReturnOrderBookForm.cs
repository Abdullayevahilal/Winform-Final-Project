using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LIBRARY_MANAGEMENT.Data;
using LIBRARY_MANAGEMENT.Models;

namespace LIBRARY_MANAGEMENT.Forms
{
    public partial class ReturnOrderBookForm : Form
    {
        private readonly LibraryDbContext _context;
        private Order _selectedOrder;
        public ReturnOrderBookForm()
        {
            _context = new LibraryDbContext();
            InitializeComponent();
            FillOrder();
        }
        private void FillOrder()
        {

            var Orders = _context.Orders
                                       .Include("Customers")
                                        .Include("Books")
                                        .Where(o => o.Status != true)
                                        .ToList();
            DgvReturnOrderBook.Rows.Clear();
            foreach (var item in Orders)
            {
                DgvReturnOrderBook.Rows.Add(item.Id,
                                  item.Customers.Name,
                                  item.Customers.Surname,
                                  item.Books.Name,
                                  item.BookCount,
                                  item.OrderTime.ToString("dd.MM.yyyy"),
                                  item.DeadLine.ToString("dd.MM.yyyy"),
                                 item.BookPrice);
            }

        }

        private void BtnCustomerSearch_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(TxtReturnBookCustomer.Text))
            {
                //    MessageBox.Show("Please,Add Customer Name");
                //return;

                var customer = _context.Orders.Where(c => (TxtReturnBookCustomer.Text != string.Empty ? c.Customers.Name.Contains(TxtReturnBookCustomer.Text) : false))
                                               .ToList();

                DgvReturnOrderBook.Rows.Clear();

                foreach (var item in customer)
                {
                    DgvReturnOrderBook.Rows.Add(item.Id,
                                      item.Customers.Name,
                                      item.Customers.Surname,
                                      item.Books.Name,
                                      item.BookCount,
                                      item.OrderTime,
                                      item.DeadLine,
                                     item.BookPrice);
                }
            }

        }
    }
}
