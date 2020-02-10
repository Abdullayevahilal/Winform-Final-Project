using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;



namespace LIBRARY_MANAGEMENT.Models
{
    public enum UserLevel
    {
        admin,
        user
    }
    public class Manager
    {
        public int Id { get; set; }   
        [Column(TypeName ="bit")]
        public bool Status { get; set; }
        [Required]
        [MaxLength(50)]
        public string Fullname { get; set; }
        [Required]
        [MaxLength(50)]
        public string Phone { get; set; }
        [Required]
        [MaxLength(50)]
        public string Email { get; set; }
        [Required]
        [MaxLength(100)]
        public string Password { get; set; }
        public UserLevel Level { get; set; }

    }
}
