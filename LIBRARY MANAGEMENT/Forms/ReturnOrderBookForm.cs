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
                                  item.Books.RentalPrice);
            }

        }

        private void DgvReturnOrderBook_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            var id = Convert.ToInt32(DgvReturnOrderBook.Rows[e.RowIndex].Cells[0].Value.ToString());
            _selectedOrder = _context.Orders.Find(id);
        }

        private void BtnCustomerSearch_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(TxtReturnBookCustomer.Text))
            {
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
                                      item.Books.RentalPrice);
                }
            }

        }

        private void BtnReturnBook_Click(object sender, EventArgs e)
        {
            _selectedOrder.Status = true;
            _context.Orders.FirstOrDefault(s => s.Id == _selectedOrder.Id).Status = _selectedOrder.Status;
            _context.SaveChanges();
            DgvReturnOrderBook.Rows.Clear();
            FillOrder();

        }

       
    }
}
