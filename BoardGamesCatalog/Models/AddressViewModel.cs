using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoardGamesCatalog.Models
{
    public class AddressViewModel
    {
        public int Id { get; set; }
        public string StreetName { get; set; }
        public int StreetNumber { get; set; }
        public string Town { get; set; }
        public string Country { get; set; }
        public int ZIP { get; set; }
    }

}
