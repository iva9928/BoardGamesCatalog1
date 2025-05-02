using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoardGamesCatalog.Models
{
    public class CreatorBoardgameViewModel
    {
        public int CreatorId { get; set; }
        public int BoardgameId { get; set; }

        public string CreatorName { get; set; }
        public string BoardgameName { get; set; }

        public List<int> BoardgameIds { get; set; } = new List<int>();
    }

}
