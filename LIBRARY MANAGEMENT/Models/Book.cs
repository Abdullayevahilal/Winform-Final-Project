using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace LIBRARY_MANAGEMENT.Models
{
    public class Book
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(50)]
        public string  Name { get; set; }
        [Required]
        [MaxLength(50)]
        public string Author { get; set; }

        [ForeignKey("Genre")]
        public int GenreId { get; set; }
      
        public double RentalPrice { get; set; }        
        public int Count { get; set; }
        public Genre Genre { get; set; }
        public List<Order> Orders { get; set; }



    }
}
