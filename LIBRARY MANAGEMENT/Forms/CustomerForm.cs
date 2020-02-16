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
    public partial class CustomerForm : Form
    {
        private int _id;
        private Customer _customer;
        private readonly LibraryDbContext _context;
        public CustomerForm()
        {
            InitializeComponent();
            _context = new LibraryDbContext();
            FillCustomers();
        }

        private void CustomerForm_Load(object sender, EventArgs e)
        {
            FillCustomers();
        }
        //Fill Customers to DataGridView
        private void FillCustomers()
        {
            var ShowUser = _context.Customers.ToList();
            DgvAddCustomer.Rows.Clear();
            foreach (var item in ShowUser)
            {
                DgvAddCustomer.Rows.Add(item.Id,
                                     item.Name,
                                     item.Surname,
                                     item.Phone,
                                     item.Email,
                                     item.IdentifyNumber);
            }
        }
        private void Clear()
        {
            TxtCustomerName.Clear();
            TxtCustomerSurname.Clear();
            TxtCustomerPhone.Clear();
            TxtCustomerEmail.Clear();
            TxtCustomerIdNumber.Clear();


        }
        //Create and Read Method
        private void BtnCustomerAdd_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("Are you Sure?", "Yes", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (r == DialogResult.Yes)
            {
                if (!string.IsNullOrEmpty(TxtCustomerName.Text) ||
                 !string.IsNullOrEmpty(TxtCustomerSurname.Text) ||
                 !string.IsNullOrEmpty(TxtCustomerPhone.Text) ||
                 !string.IsNullOrEmpty(TxtCustomerEmail.Text) ||
                 !string.IsNullOrEmpty(TxtCustomerIdNumber.Text))
                {
                    Customer customer = new Customer//add user to database
                    {
                        Name = TxtCustomerName.Text,
                        Surname = TxtCustomerSurname.Text,
                        Phone = TxtCustomerPhone.Text,
                        Email = TxtCustomerEmail.Text,
                        IdentifyNumber = TxtCustomerIdNumber.Text,


                    };
                    _context.Customers.Add(customer);
                    _context.SaveChanges();
                }
                else
                {
                    MessageBox.Show("Please");
                }
                DgvAddCustomer.Rows.Clear();
                FillCustomers();
                Clear();
            }
                if (r == DialogResult.No)
                {
                    Clear();
                }           
        }
        //Update Method
        private void BtnCustomerUpdate_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("Are you Sure?", "Yes", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (r == DialogResult.Yes)
            {
                Customer customer = _context.Customers.Find(_customer.Id);
                customer.Name = TxtCustomerName.Text;
                customer.Surname = TxtCustomerSurname.Text;
                customer.Phone = TxtCustomerPhone.Text;
                customer.Email = TxtCustomerEmail.Text;
                customer.IdentifyNumber = TxtCustomerIdNumber.Text;

                _context.SaveChanges();
                FillCustomers();
                Clear();
            }
                if (r == DialogResult.No)
                {
                    Clear();
                }
            }
        // Delete Method
        private void BtnCustomerDelete_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("Are you Sure?", "Yes", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (r == DialogResult.Yes)
            {
                _context.Customers.Remove(_customer);
                _context.SaveChanges();
                DgvAddCustomer.Rows.Clear();
                FillCustomers();
                Clear();
            }

        }

         private void DgvAddCustomer_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            TxtCustomerName.Text = _customer.Name;
            TxtCustomerSurname.Text = _customer.Surname;
            TxtCustomerPhone.Text = _customer.Phone;
            TxtCustomerEmail.Text = _customer.Email;
            TxtCustomerIdNumber.Text = _customer.IdentifyNumber;
        }

        private void DgvAddCustomer_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            _id = (int)DgvAddCustomer.Rows[e.RowIndex].Cells[0].Value;
            _customer = _context.Customers.Find(_id);
        }
        //Search Method
        private void BtnCustomerSearch_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TxtCustomerName.Text) &&
           string.IsNullOrEmpty(TxtCustomerSurname.Text) &&
          string.IsNullOrEmpty(TxtCustomerIdNumber.Text))


            {
                MessageBox.Show("Please Add Name, Surname or ID Number ");
                return;
            }
            var customer = _context.Customers
                                    .Where(c => (TxtCustomerName.Text != string.Empty ? c.Name.Contains(TxtCustomerName.Text) : false) ||
                                                            (TxtCustomerSurname.Text != string.Empty ? c.Surname.Contains(TxtCustomerSurname.Text) : false) ||
                                                            (TxtCustomerIdNumber.Text != string.Empty ? c.IdentifyNumber.Contains(TxtCustomerIdNumber.Text) : false))
                                    .ToList();
            DgvAddCustomer.Rows.Clear();

            foreach (var item in customer)
            {
                DgvAddCustomer.Rows.Add(item.Id,
                                     item.Name,
                                     item.Surname,
                                     item.Phone,
                                     item.Email,
                                     item.IdentifyNumber);

                Clear();
            }
        }
    }
}
