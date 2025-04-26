using BoardGamesCatalog.Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.Entity;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;


namespace BoardGamesCatalog.Data
{
    public class BoardGamesContext : System.Data.Entity.DbContext
    {
        public BoardGamesContext()
            : base(Configurations.ConnectionString)
        {

        }

        public System.Data.Entity.DbSet<Boardgame> Boardgames { get; set; }
    }
}
