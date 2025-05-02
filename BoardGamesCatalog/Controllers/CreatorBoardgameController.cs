using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoardGamesCatalog.Controllers
{
    using BoardGamesCatalog.Data;
    using BoardGamesCatalog.Data.Models;
    using BoardGamesCatalog.Models;
    using Microsoft.EntityFrameworkCore;

    /// <summary>
    /// Controller for managing many-to-many assignments between Creators and Boardgames.
    /// </summary>
    public class CreatorBoardgameController
    {
        private readonly BoardGamesContext _context;

        /// <summary>
        /// Initializes a new instance of the <see cref="CreatorBoardgameController"/> class.
        /// </summary>
        /// <param name="context">The database context to use.</param>
        public CreatorBoardgameController(BoardGamesContext context)
        {
            _context = context;
        }

        /// <summary>
        /// Assigns a list of boardgames to a creator, replacing any existing assignments.
        /// </summary>
        /// <param name="model">The assignment model containing creator ID and selected boardgame IDs.</param>
        /// <returns>True if operation completes successfully.</returns>
        public async Task<bool> AssignBoardgamesToCreatorAsync(CreatorBoardgameViewModel model)
        {
            var existing = _context.CreatorsBoardgames.Where(cb => cb.CreatorId == model.CreatorId);
            _context.CreatorsBoardgames.RemoveRange(existing);

            foreach (var bgId in model.BoardgameIds)
            {
                _context.CreatorsBoardgames.Add(new CreatorBoardgame
                {
                    CreatorId = model.CreatorId,
                    BoardgameId = bgId
                });
            }

            await _context.SaveChangesAsync();
            return true;
        }

        /// <summary>
        /// Gets a list of boardgame IDs assigned to a specific creator.
        /// </summary>
        /// <param name="creatorId">The ID of the creator.</param>
        /// <returns>List of boardgame IDs.</returns>
        public async Task<List<int>> GetBoardgamesForCreatorAsync(int creatorId)
        {
            return await _context.CreatorsBoardgames
                .Where(cb => cb.CreatorId == creatorId)
                .Select(cb => cb.BoardgameId)
                .ToListAsync();
        }

        /// <summary>
        /// Retrieves all boardgames from the database.
        /// </summary>
        /// <returns>List of all boardgames.</returns>
        public async Task<List<Boardgame>> GetAllBoardgamesAsync()
        {
            return await _context.Boardgames.ToListAsync();
        }

        /// <summary>
        /// Retrieves all CreatorBoardgame relationships including related names.
        /// </summary>
        /// <returns>List of view models with Creator and Boardgame info.</returns>
        public async Task<List<CreatorBoardgameViewModel>> GetAllCreatorBoardgamesAsync()
        {
            return await _context.CreatorsBoardgames
                .Include(cb => cb.Creator)
                .Include(cb => cb.Boardgame)
                .Select(cb => new CreatorBoardgameViewModel
                {
                    CreatorId = cb.CreatorId,
                    BoardgameId = cb.BoardgameId,
                    CreatorName = cb.Creator.FirstName + " " + cb.Creator.LastName,
                    BoardgameName = cb.Boardgame.Name
                }).ToListAsync();
        }

        /// <summary>
        /// Gets all boardgames assigned to a specific creator.
        /// </summary>
        /// <param name="creatorId">The ID of the creator.</param>
        /// <returns>List of assignments as view models.</returns>
        public async Task<List<CreatorBoardgameViewModel>> GetByCreatorIdAsync(int creatorId)
        {
            return await _context.CreatorsBoardgames
                .Where(cb => cb.CreatorId == creatorId)
                .Select(cb => new CreatorBoardgameViewModel
                {
                    CreatorId = cb.CreatorId,
                    BoardgameId = cb.BoardgameId,
                    CreatorName = cb.Creator.FirstName + " " + cb.Creator.LastName,
                    BoardgameName = cb.Boardgame.Name
                })
                .ToListAsync();
        }
    }
}
