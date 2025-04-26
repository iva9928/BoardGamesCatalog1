using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace BoardGamesCatalog.Data.Models
{
    public class PlayerRange
    {
        [Key]
        public int Id { get; set; }


        public int PlayersMin { get; set; }
        
       
        public int PlayersMax{ get; set; }
        public virtual ICollection<Boardgame> Boardgames { get; set; } = new HashSet<Boardgame>();
    }
}
