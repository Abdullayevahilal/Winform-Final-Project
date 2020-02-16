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
using LIBRARY_MANAGEMENT.Forms;

namespace LIBRARY_MANAGEMENT.Forms
{
    public partial class OrderForm : Form
    {
        private readonly LibraryDbContext _context;
        private Book _selectedBook;
        private Customer _selectedCustomer;
        //private Manager _selectedManager;
        private Order _selectedOrder;


        public OrderForm()
        {
            _context = new LibraryDbContext();
            InitializeComponent();
            FillBooks();
            FillCustomers();
            FillOrder();

        }
        //Books
        private void FillBooks()
        {
            var ShowBook = _context.Books
                                         .Include("Genre")
                                         .Where(b=>b.Count!=0)
                                         .ToList();
            DgvFindBook.Rows.Clear();
            foreach (var item in ShowBook)
            {
                DgvFindBook.Rows.Add(item.Id,
                                     item.Name,
                                     item.Author,
                                    item.Genre.Name,
                                     item.RentalPrice,
                                     item.Count);
            }
            
        }
        //Customers
        private void FillCustomers()
        {
            var ShowUser = _context.Customers.ToList();
            DgvFindCustomer.Rows.Clear();
            foreach (var item in ShowUser)
            {
                DgvFindCustomer.Rows.Add(item.Id,
                                     item.Name,
                                     item.Surname,
                                     item.IdentifyNumber);
            }
        }
        //Order
        private void FillOrder()
        {

            var Orders = _context.Orders.Include("Customers").Include("Books").OrderByDescending(r=>r.Id).ToList();
            DgvOrder.Rows.Clear();
            foreach (var item in Orders)
            {
                DgvOrder.Rows.Add(item.Id,
                                  item.Customers.Name,
                                  item.Customers.Surname,
                                  item.Books.Name,
                                  item.OrderTime.ToString("dd.MM.yyyy"),
                                  item.DeadLine.ToString("dd.MM.yyyy"),
                                  item.BookCount,
                                  item.Books.RentalPrice* item.BookCount);
            }
          
        }
        //Customer Search
        private void BtnCustomerSearch_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(TxtFindCustomer.Text)) 
            {
                var customer = _context.Customers.Where(c => TxtFindCustomer.Text != string.Empty ? c.Name.Contains(TxtFindCustomer.Text) : false)
                                        .ToList();

                DgvFindCustomer.Rows.Clear();

                foreach (var item in customer)
                {
                    DgvFindCustomer.Rows.Add(item.Id, item.Name,
                                       item.Surname,
                                       item.IdentifyNumber);
                }
                //Reset();
            }
            else
            {
                MessageBox.Show("Add");
                return;

            }
            Reset();
            

        }
        //Book Search
        private void BtnBookSearc_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TxtFindBook.Text))
            {
                MessageBox.Show("Please, add Book Name");
                return;
            }

            var book = _context.Books
                                     .Where(b => (TxtFindBook.Text != string.Empty ? b.Name.Contains(TxtFindBook.Text) : false))
                                    .ToList();
            //DgvFindBook.Clear();
            DgvFindBook.Rows.Clear();

            foreach (var item in book)
            {
                DgvFindBook.Rows.Add(item.Id,
                                  item.Name,
                                  item.Author,
                                  item.Genre,
                                  item.RentalPrice,
                                  item.Count);
            }
            //Reset();


        }
        private void Reset()
        {
            _selectedCustomer = null;
            _selectedBook = null;
            DtpDeadline.Text = "";
            TxtFindBook.Text = "";
            TxtFindCustomer.Text = "";
            TxtOrderBookCount.Text = "";
        }

        private void DgvFindCustomer_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {


            int id = Convert.ToInt32(DgvFindCustomer.Rows[e.RowIndex].Cells[0].Value.ToString());

            _selectedCustomer = _context.Customers.Find(id);
        }

        private void DgvFindBook_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int id = Convert.ToInt32(DgvFindBook.Rows[e.RowIndex].Cells[0].Value.ToString());

            _selectedBook = _context.Books.Find(id);
        }
      //Create Order Method
        private void BtnOrderAdd_Click(object sender, EventArgs e)
        {
            
            if (DtpOrderTime.Value != DateTime.Now)
            {
                   Order orders = new Order
                {
                    CustomerId = _selectedCustomer.Id,
                    BookId = _selectedBook.Id,
                    OrderTime= DateTime.Now,
                    DeadLine = DtpDeadline.Value,
                    
                    BookCount = Convert.ToInt32(TxtOrderBookCount.Text),
                    
                };

                _context.Orders.Add(orders);
                _selectedBook.Count -= Convert.ToInt32(TxtOrderBookCount.Text);
                _context.SaveChanges();
               // DgvOrder.Rows.Clear();
               //DgvFindBook.Rows.Clear();
                //MessageBox.Show("Are you Sure?","Yes",MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                FillBooks();
               FillOrder();
            }
            else
            {
                MessageBox.Show("qaqa nagarasan");
                return;
            }
           
                
           

        }
        //Delete Order Method
        private void BtnDeleteOrder_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("Are you Sure?", "Yes", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (r == DialogResult.Yes)
            {
                _context.Orders.Remove(_selectedOrder);
                _context.SaveChanges();
                DgvOrder.Rows.Clear();
                DgvFindBook.Rows.Clear();
                FillBooks();
                FillOrder();
            }
            Reset();
           
        }

        private void DgvOrder_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int id = Convert.ToInt32(DgvOrder.Rows[e.RowIndex].Cells[0].Value.ToString());

            _selectedOrder = _context.Orders.Find(id);
        }

        
    }
}