using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoardGamesCatalog.Data.Models
{
    public class Address
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(100)]
        public string StreetName { get; set; }
        [Required]
        public int StreetNumber { get; set; }

        [Required]
        [MaxLength(30)]
        public string Town { get; set; }

        [Required]
        [MaxLength(50)]
        public string Country { get; set; }

        [Required]
        public int ZIP { get; set; }

    }
}
