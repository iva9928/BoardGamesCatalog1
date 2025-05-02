using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoardGamesCatalog.Data.Models
{
    public class Boardgame
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(30)]
        public string Name { get; set; }
        [Required]
        public int YearPublished { get; set; }

        [Required]
        public decimal Rating { get; set; }

        [Required]
        public int CategoryId { get; set; }

        [Required]
        [ForeignKey(nameof(CategoryId))]
        public Category Category { get; set; }

        [Required]
        public int PublisherId { get; set; }

        [Required]
        [ForeignKey(nameof(PublisherId))]
        public Publisher Publisher { get; set; }


        public int PlayersRangeId { get; set; }

        [Required]
        [ForeignKey(nameof(PlayersRangeId))]
        public PlayerRange PlayerRange { get; set; }


        public virtual ICollection<CreatorBoardgame> CreatorsBoardgames { get; set; } = new HashSet<CreatorBoardgame>();
    }
}

