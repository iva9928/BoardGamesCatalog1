using BoardGamesCatalog.Data;
using BoardGamesCatalog.Data.Models;
using BoardGamesCatalog.Models;
using Microsoft.EntityFrameworkCore;

namespace BoardGamesCatalog.Controllers
{
    public class BoardGamesController
    {
        private readonly BoardGamesContext _context;

        public BoardGamesController(BoardGamesContext context)
        {
            _context = context;
        }

        public async Task<bool> CreateAsync(BoardgameAddViewModel model)
        {
            var boardgame = new Boardgame
            {
                Name = model.Name,
                YearPublished = model.YearPublished,
                Rating = model.Rating,
                CategoryId = model.CategoryId,
                PublisherId = model.PublisherId,
                PlayersRangeId = model.PlayersRangeId
            };

            _context.Boardgames.Add(boardgame);
            await _context.SaveChangesAsync();
            return true;
        }

        public async Task<List<BoardgameListViewModel>> GetAllAsync()
        {
            return await _context.Boardgames
         .Include(b => b.Category)
         .Include(b => b.Publisher)
         .Select(b => new BoardgameListViewModel
         {
             Id = b.Id,
             Name = b.Name,
             YearPublished = b.YearPublished,
             Rating = b.Rating,
             CategoryId = b.CategoryId,
             PublisherId = b.PublisherId,
             PlayersRangeId = b.PlayersRangeId
         })
         .ToListAsync();
        }


        public async Task<bool> UpdateAsync(BoardgameEditViewModel model)
        {
            var b = await _context.Boardgames.FindAsync(model.Id);
            if (b == null) return false;

            b.Name = model.Name;
            b.YearPublished = model.YearPublished;
            b.Rating = model.Rating;
            b.CategoryId = model.CategoryId;
            b.PublisherId = model.PublisherId;
            b.PlayersRangeId = model.PlayersRangeId;

            _context.Boardgames.Update(b);
            await _context.SaveChangesAsync();
            return true;
        }
        public async Task<bool> DeleteAsync(int id)
        {
            var b = await _context.Boardgames.FindAsync(id);
            if (b == null) return false;

            _context.Boardgames.Remove(b);
            await _context.SaveChangesAsync();
            return true;
        }

        public async Task<BoardgameListViewModel> GetByIdAsync(int boardGameId)
        {
            var boardgame = await _context.Boardgames
                .Include(b => b.Category)
                .Include(b => b.Publisher)
                .FirstOrDefaultAsync(b => b.Id == boardGameId);

            if (boardgame == null)
            {
                return null;
            }

            return new BoardgameListViewModel
            {
                Id = boardgame.Id,
                Name = boardgame.Name,
                YearPublished = boardgame.YearPublished,
                Rating = boardgame.Rating,
                CategoryId = boardgame.CategoryId,
                PublisherId = boardgame.PublisherId,
                PlayersRangeId = boardgame.PlayersRangeId
            };
        }
    }
}
