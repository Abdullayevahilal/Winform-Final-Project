using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using LIBRARY_MANAGEMENT.Models;

namespace LIBRARY_MANAGEMENT.Data
{
   public class LibraryDbContext: DbContext
    {
        public LibraryDbContext() :base ("LibraryDbContext")
        {

        }

        
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Manager> Managers { get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<Genre> Genres { get; set; }
        public DbSet<Order> Orders { get; set; }

       

    }
}
