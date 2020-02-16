using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;


namespace LIBRARY_MANAGEMENT.Models
{
    
    public class Order
    {
        public int Id { get; set; }
       
        [Column(TypeName ="bit")]
        public bool Status { get; set; }
        [Column(TypeName = "date")]
        public DateTime OrderTime { get; set; }
        [Column(TypeName = "date")]
        public DateTime DeadLine { get; set; }
        [Column(TypeName = "date")]
        public DateTime ReturnTime { get; set; }
        public int? BookCount { get; set; }
        public double BookPrice { get; set; }
        public double TotalPrice { get; set; }

        [ForeignKey("Managers")]
        public int? ManagerId { get; set; }
        [ForeignKey("Customers")]
        public int? CustomerId { get; set; }
        public Manager Managers { get; set; }
        public Customer Customers { get; set; }
        [ForeignKey("Books")]
        public int BookId { get; set; }

        public Book Books { get; set; }
        

    }


}
