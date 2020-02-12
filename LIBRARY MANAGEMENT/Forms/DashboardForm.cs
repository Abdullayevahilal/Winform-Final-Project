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

      

        private void BtnBook_Click(object sender, EventArgs e)
        { BookForm book = new BookForm();
            book.ShowDialog();

            this.Close();
            return;

        }

        private void BtnUser_Click(object sender, EventArgs e)
        {
            UserForm user = new UserForm();
            user.ShowDialog();

            this.Close();
            return;
        }
    }
}
