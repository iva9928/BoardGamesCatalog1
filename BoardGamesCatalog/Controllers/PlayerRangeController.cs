using BoardGamesCatalog.Data;
using BoardGamesCatalog.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoardGamesCatalog.Controllers
{
    /// <summary>
    /// Controller for managing player ranges in the board games catalog.
    /// </summary>
    public class PlayerRangeController
    {
        private readonly BoardGamesContext _context;

        /// <summary>
        /// Initializes a new instance of the <see cref="PlayerRangeController"/> class.
        /// </summary>
        /// <param name="context">The database context to use.</param>
        public PlayerRangeController(BoardGamesContext context)
        {
            _context = context;
        }

        /// <summary>
        /// Creates a new player range in the database.
        /// </summary>
        /// <param name="model">The player range view model containing minimum and maximum players.</param>
        /// <returns>True if creation was successful.</returns>
        public async Task<bool> CreateAsync(PlayerRangeViewModel model)
        {
            var range = new Data.Models.PlayerRange
            {
                PlayersMin = model.PlayersMin,
                PlayersMax = model.PlayersMax
            };

            _context.PlayersRanges.Add(range);
            await _context.SaveChangesAsync();
            return true;
        }

        /// <summary>
        /// Retrieves all player ranges from the database.
        /// </summary>
        /// <returns>A list of all player ranges.</returns>
        public async Task<List<PlayerRangeViewModel>> GetAllAsync()
        {
            return await _context.PlayersRanges
                .Select(r => new PlayerRangeViewModel
                {
                    Id = r.Id,
                    PlayersMin = r.PlayersMin,
                    PlayersMax = r.PlayersMax
                })
                .ToListAsync();
        }

        /// <summary>
        /// Retrieves a player range by its ID.
        /// </summary>
        /// <param name="id">The ID of the player range.</param>
        /// <returns>The player range if found; otherwise, null.</returns>
        public async Task<PlayerRangeViewModel> GetByIdAsync(int id)
        {
            var range = await _context.PlayersRanges.FindAsync(id);
            if (range == null) return null;

            return new PlayerRangeViewModel
            {
                Id = range.Id,
                PlayersMin = range.PlayersMin,
                PlayersMax = range.PlayersMax
            };
        }

        /// <summary>
        /// Updates an existing player range in the database.
        /// </summary>
        /// <param name="model">The updated player range view model.</param>
        /// <returns>True if the update was successful; otherwise, false.</returns>
        public async Task<bool> UpdateAsync(PlayerRangeViewModel model)
        {
            var range = await _context.PlayersRanges.FindAsync(model.Id);
            if (range == null) return false;

            range.PlayersMin = model.PlayersMin;
            range.PlayersMax = model.PlayersMax;

            _context.PlayersRanges.Update(range);
            await _context.SaveChangesAsync();
            return true;
        }

        /// <summary>
        /// Deletes a player range from the database by its ID.
        /// </summary>
        /// <param name="id">The ID of the player range to delete.</param>
        /// <returns>True if the deletion was successful; otherwise, false.</returns>
        public async Task<bool> DeleteAsync(int id)
        {
            var range = await _context.PlayersRanges.FindAsync(id);
            if (range == null) return false;

            _context.PlayersRanges.Remove(range);
            await _context.SaveChangesAsync();
            return true;
        }
    }
}
