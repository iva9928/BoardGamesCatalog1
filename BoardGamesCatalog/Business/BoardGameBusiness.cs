using BoardGamesCatalog.Data;
using BoardGamesCatalog.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoardGamesCatalog.Business
{
    public class BoardGameBusiness
    {
        private BoardGamesContext context;

        public List<Boardgame> GetAll()
        {
            using(context =  new BoardGamesContext())
            {
                return context.Boardgames.ToList();
            }
        }

        public Boardgame Get(int id)
        {
            using (context = new BoardGamesContext())
            {
                return context.Boardgames.Find(id); 
            }
        }

        public void Add (Boardgame boardgame)
        {
            using (context = new BoardGamesContext())
            {
                context.Boardgames.Add(boardgame);
                context.SaveChanges();
            }
        }

        public void Update(Boardgame boardgame)
        {
            using (context = new BoardGamesContext())
            {
                var item = context.Boardgames.Find(boardgame.Id);
                if (item != null)
                {
                    context.Entry(item).CurrentValues.SetValues(boardgame);
                    context.SaveChanges();
                }
            }
        }

        public void Delete(int id)
        {
            using (context = new BoardGamesContext())
            {
                var boardGame = context.Boardgames.Find(id);
                if (boardGame != null)
                {
                    context.Boardgames.Remove(boardGame);
                    context.SaveChanges();
                }
            }
        }
    }
}
