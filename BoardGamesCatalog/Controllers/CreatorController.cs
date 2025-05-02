using BoardGamesCatalog.Data;
using BoardGamesCatalog.Data.Models;
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
    /// Controller responsible for CRUD operations related to Creators.
    /// </summary>
    public class CreatorController
    {
        private readonly BoardGamesContext _context;

        /// <summary>
        /// Initializes a new instance of the <see cref="CreatorController"/> class.
        /// </summary>
        /// <param name="context">The database context.</param>
        public CreatorController(BoardGamesContext context)
        {
            _context = context;
        }

        /// <summary>
        /// Creates a new creator record.
        /// </summary>
        /// <param name="model">The creator view model containing the data to save.</param>
        /// <returns>True if creation is successful; otherwise false.</returns>
        public async Task<bool> CreateCreatorAsync(CreatorViewModel model)
        {
            var creator = new Data.Models.Creator
            {
                FirstName = model.FirstName,
                LastName = model.LastName,
                Email = model.Email
            };

            _context.Creators.Add(creator);
            await _context.SaveChangesAsync();
            return true;
        }

        /// <summary>
        /// Retrieves a list of all creators.
        /// </summary>
        /// <returns>A list of creator view models.</returns>
        public async Task<List<CreatorViewModel>> GetAllCreatorsAsync()
        {
            return await _context.Creators
                .Select(c => new CreatorViewModel
                {
                    Id = c.Id,
                    FirstName = c.FirstName,
                    LastName = c.LastName,
                    Email = c.Email
                })
                .ToListAsync();
        }

        /// <summary>
        /// Gets a creator by ID.
        /// </summary>
        /// <param name="id">The ID of the creator.</param>
        /// <returns>The creator view model, or null if not found.</returns>
        public async Task<CreatorViewModel> GetByIdCreatorAsync(int id)
        {
            var creator = await _context.Creators.FindAsync(id);
            if (creator == null) return null;

            return new CreatorViewModel
            {
                Id = creator.Id,
                FirstName = creator.FirstName,
                LastName = creator.LastName,
                Email = creator.Email
            };
        }

        /// <summary>
        /// Updates an existing creator record.
        /// </summary>
        /// <param name="model">The creator view model containing updated data.</param>
        /// <returns>True if the update is successful; otherwise false.</returns>
        public async Task<bool> UpdateCreatorAsync(CreatorViewModel model)
        {
            var creator = await _context.Creators.FindAsync(model.Id);
            if (creator == null) return false;

            creator.FirstName = model.FirstName;
            creator.LastName = model.LastName;
            creator.Email = model.Email;

            _context.Creators.Update(creator);
            await _context.SaveChangesAsync();
            return true;
        }

        /// <summary>
        /// Deletes a creator by ID.
        /// </summary>
        /// <param name="id">The ID of the creator to delete.</param>
        /// <returns>True if the deletion is successful; otherwise false.</returns>
        public async Task<bool> DeleteCreatorAsync(int id)
        {
            var creator = await _context.Creators.FindAsync(id);
            if (creator == null) return false;

            _context.Creators.Remove(creator);
            await _context.SaveChangesAsync();
            return true;
        }
    }
}
