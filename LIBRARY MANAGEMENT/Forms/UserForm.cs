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
    public partial class UserForm : Form
    {
        private int _id;
        private Manager _user;
        private readonly LibraryDbContext _context;
        public UserForm()
        {

            InitializeComponent();
            _context = new LibraryDbContext();
            FillUsers();

        }

        
        private void FillUsers()
        {
            var ShowUser = _context.Managers.ToList();
            DgvAddUsers.Rows.Clear();
            foreach (var item in ShowUser)
            {
                DgvAddUsers.Rows.Add(item.Id,
                                     item.Status,
                                     item.Fullname,
                                     item.Phone,
                                     item.Email,
                                     item.Password);
            }
        }
        private void Clear()
        {
            TxtFullName.Clear();
            TxtPhone.Clear();
            TxtUserEmail.Clear();
            TxtPassword.Clear();
           
        }
        //Create And Read Method
        private void BtnUserAdd_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(TxtFullName.Text) ||
              !string.IsNullOrEmpty(TxtPhone.Text) ||
              !string.IsNullOrEmpty(TxtUserEmail.Text) ||
              !string.IsNullOrEmpty(TxtPassword.Text))
            {
                Manager user = new Manager//add user to database
                {
                    Fullname = TxtFullName.Text,
                    Phone = TxtPhone.Text,
                    Email = TxtUserEmail.Text,
                    Password =TxtPassword.Text,
                    Level = UserLevel.user,
                    Status = true

                };
                _context.Managers.Add(user);
                _context.SaveChanges();
            }
            else
            {
                MessageBox.Show("doldur");
            }
            DgvAddUsers.Rows.Clear();
            FillUsers();
            Clear();

        }
        //End of Create And Read Method

        //Search Method
        private void BtnUserSearch_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TxtFullName.Text) &&
           string.IsNullOrEmpty(TxtPhone.Text))
            {
                MessageBox.Show("Please Add FullName or Phone ");
                return;
            }
            var user = _context.Managers
                                    .Where(u => u.Status && (TxtFullName.Text != string.Empty ? u.Fullname.Contains(TxtFullName.Text) : false) ||
                                                            (TxtPhone.Text != string.Empty ? u.Phone.Contains(TxtPhone.Text) : false))
                                    .ToList();
            DgvAddUsers.Rows.Clear();

            foreach (var item in user)
            {
                DgvAddUsers.Rows.Add(item.Id,
                                     item.Status,
                                     item.Fullname,
                                     item.Phone,
                                     item.Email,
                                     item.Password);
                Clear();
            }
        } //User search method
        // End of search method
        private void UserForm_Load(object sender, EventArgs e)
        {
            FillUsers();
        }
        //Delete Method
        private void BtnUserDelete_Click(object sender, EventArgs e)
        {
            _context.Managers.Remove(_user);
            _context.SaveChanges();
            FillUsers();
            Clear();
        }
        //End of Delete Method
        private void DgvAddUsers_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            TxtFullName.Text = _user.Fullname;
            TxtPhone.Text = _user.Phone;
            TxtUserEmail.Text = _user.Email;
            TxtPassword.Text = _user.Password;
         
        }

        private void DgvAddUsers_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            _id = (int)DgvAddUsers.Rows[e.RowIndex].Cells[0].Value;
            _user = _context.Managers.Find(_id);
        }
        //Update Method
        private void BtnUserUpdate_Click(object sender, EventArgs e)
        {
            Manager user = _context.Managers.Find(_user.Id);
            user.Fullname = TxtFullName.Text;
            user.Phone = TxtPhone.Text;
            user.Email = TxtUserEmail.Text;
            user.Password= TxtPassword.Text;

            _context.SaveChanges();
            FillUsers();
            Clear();
        }
        //End of Update Method
    }
        }
    

    

