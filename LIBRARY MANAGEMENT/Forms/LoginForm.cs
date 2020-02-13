using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CryptoHelper;
using LIBRARY_MANAGEMENT.Data;
using LIBRARY_MANAGEMENT.Models;
using LIBRARY_MANAGEMENT.Forms;

namespace LIBRARY_MANAGEMENT.Forms
{
    public partial class LoginForm : Form

    {
        private readonly LibraryDbContext _context;
        public LoginForm()
        {
            _context = new LibraryDbContext();
            InitializeComponent();
        }

        private void BtnEnter_Click(object sender, EventArgs e)
        {
            //TxtEmail.Text = (Crypto.HashPassword("4202084"));
            //MessageBox.Show(Crypto.HashPassword("4202084"));
            if (string.IsNullOrEmpty(TxtEmail.Text))
            {
                MessageBox.Show("E-Poçt Yazın");
                return;

            }
            if (string.IsNullOrEmpty(TxtPassword.Text))
            {
                MessageBox.Show("Şifrə yazın");
                return;
            }

            Manager manager = _context.Managers.FirstOrDefault
                (m => m.Status && m.Email == TxtEmail.Text);
            
            if (manager != null && Crypto.VerifyHashedPassword(manager.Password,TxtPassword.Text))
            {
                DashboardForm dashboard = new DashboardForm();
               
                dashboard.ShowDialog();

                this.Hide();
                return;
            }

            MessageBox.Show("E-poçt və ya şifrə yalnışdır");


        }

        
    }
    }

