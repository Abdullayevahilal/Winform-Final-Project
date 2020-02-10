using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace LIBRARY_MANAGEMENT.Models
{
  public  class OrderBook
    {
        public int Id { get; set; }
        [ForeignKey("Book")  ]      
        public int? BookId { get; set; }
        [ForeignKey("Order")]
        public int? OrdersId { get; set; }
        public Book Book { get; set; }
        public Order Order { get; set; }
    }
}
