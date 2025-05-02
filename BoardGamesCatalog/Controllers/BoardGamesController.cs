using BoardGamesCatalog.Data;
using BoardGamesCatalog.Data.Models;
using BoardGamesCatalog.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BoardGamesCatalog.Controllers
{
    /// <summary>
    /// Controller responsible for managing Boardgame entities and related operations.
    /// </summary>
    public class BoardGamesController
    {
        private readonly BoardGamesContext _context;

        /// <summary>
        /// Initializes a new instance of the <see cref="BoardGamesController"/> class.
        /// </summary>
        /// <param name="context">The database context.</param>
        public BoardGamesController(BoardGamesContext context)
        {
            _context = context;
        }

        /// <summary>
        /// Creates a new board game in the database.
        /// </summary>
        /// <param name="model">The board game model to create.</param>
        /// <returns>True if creation is successful.</returns>
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

        /// <summary>
        /// Retrieves all board games with related category and publisher information.
        /// </summary>
        /// <returns>List of board game view models.</returns>
        public async Task<List<BoardgameListViewModel>> GetAllAsync()
        {
            return await _context.Boardgames
                .Include(b => b.Category)
                .Include(b => b.Publisher)
                //.Include(b => b.PlayerRange)
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

        /// <summary>
        /// Updates an existing board game.
        /// </summary>
        /// <param name="model">Updated board game view model.</param>
        /// <returns>True if update is successful.</returns>
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

        /// <summary>
        /// Deletes a board game by ID.
        /// </summary>
        /// <param name="id">Board game ID.</param>
        /// <returns>True if deleted successfully.</returns>
        public async Task<bool> DeleteAsync(int id)
        {
            var b = await _context.Boardgames.FindAsync(id);
            if (b == null) return false;

            _context.Boardgames.Remove(b);
            await _context.SaveChangesAsync();
            return true;
        }

        /// <summary>
        /// Retrieves a board game by ID including related entities.
        /// </summary>
        /// <param name="boardGameId">The ID of the board game.</param>
        /// <returns>The board game view model or null.</returns>
        public async Task<BoardgameListViewModel> GetByIdAsync(int boardGameId)
        {
            var boardgame = await _context.Boardgames
                .Include(b => b.Category)
                .Include(b => b.Publisher)
                .Include(b => b.PlayerRange)
                .FirstOrDefaultAsync(b => b.Id == boardGameId);

            if (boardgame == null)
                return null;

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

        /// <summary>
        /// Retrieves all publishers (used for dropdowns or filtering).
        /// </summary>
        /// <returns>List of publisher view models.</returns>
        public async Task<List<PublisherViewModel>> GetAllPublishersAsync()
        {
            return await _context.Boardgames
                .Select(p => new PublisherViewModel
                {
                    Id = p.Id,
                    Name = p.Name
                }).ToListAsync();
        }

        /// <summary>
        /// Gets all board games assigned to a specific publisher.
        /// </summary>
        /// <param name="publisherId">Publisher ID.</param>
        /// <returns>List of board games.</returns>
        public async Task<List<BoardgameListViewModel>> GetBoardgamesByPublisherAsync(int publisherId)
        {
            return await _context.Boardgames
                .Where(b => b.PublisherId == publisherId)
                .Select(b => new BoardgameListViewModel
                {
                    Id = b.Id,
                    Name = b.Name,
                    YearPublished = b.YearPublished,
                    Rating = b.Rating,
                    CategoryId = b.CategoryId,
                    PublisherId = b.PublisherId,
                    PlayersRangeId = b.PlayersRangeId
                }).ToListAsync();
        }

        /// <summary>
        /// Gets all board games belonging to a specific category.
        /// </summary>
        /// <param name="categoryId">Category ID.</param>
        /// <returns>List of board games.</returns>
        public async Task<List<BoardgameListViewModel>> GetBoardgamesByCategoryAsync(int categoryId)
        {
            return await _context.Boardgames
                .Where(b => b.CategoryId == categoryId)
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

        /// <summary>
        /// Gets all board games published in a specific year.
        /// </summary>
        /// <param name="year">Year of publication.</param>
        /// <returns>List of board games.</returns>
        public async Task<List<BoardgameListViewModel>> GetBoardgamesByYearAsync(int year)
        {
            return await _context.Boardgames
                .Where(b => b.YearPublished == year)
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
    }
}
