using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoardGamesCatalog.Models
{
    public class BoardgameAddViewModel
    {
        public string Name { get; set; }
        public int YearPublished { get; set; }
        public decimal Rating { get; set; }

        public int CategoryId { get; set; }
        public int PublisherId { get; set; }
        public int PlayersRangeId { get; set; }
    }
}
