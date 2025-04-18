using Microsoft.Azure.Cosmos;
using Microsoft.Azure.Documents;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Security.Cryptography.Xml;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using Index = Microsoft.Azure.Documents.Index;

namespace BoardGamesCatalog.Data.Models
{
    public class Publisher
    {

        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(30)]
        public string Name { get; set; }
        
        [Required]
        public int AddressId { get; set; }

        [ForeignKey(nameof(AddressId))]
        public Address Address { get; set; }


        [MaxLength(40)]
        public string Website { get; set; }
        
        [MaxLength(20)]
        public string Phone { get; set; }

       
    }
}
