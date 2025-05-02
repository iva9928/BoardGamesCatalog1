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
    /// Controller class for managing Publisher entities.
    /// </summary>
    public class PublisherController
    {
        private readonly BoardGamesContext _context;

        /// <summary>
        /// Initializes a new instance of the <see cref="PublisherController"/> class.
        /// </summary>
        /// <param name="context">The database context.</param>
        public PublisherController(BoardGamesContext context)
        {
            _context = context;
        }

        /// <summary>
        /// Creates a new Publisher.
        /// </summary>
        /// <param name="model">The publisher view model to create.</param>
        /// <returns>True if the publisher was created successfully.</returns>
        public async Task<bool> CreatePublisherAsync(PublisherViewModel model)
        {
            var publisher = new Publisher
            {
                Name = model.Name,
                AddressId = model.AddressId,
                Website = model.Website,
                Phone = model.Phone
            };

            _context.Publishers.Add(publisher);
            await _context.SaveChangesAsync();
            return true;
        }

        /// <summary>
        /// Retrieves all publishers from the database.
        /// </summary>
        /// <returns>A list of <see cref="PublisherViewModel"/>.</returns>
        public async Task<List<PublisherViewModel>> GetAllPublishersAsync()
        {
            return await _context.Publishers
                .Select(p => new PublisherViewModel
                {
                    Id = p.Id,
                    Name = p.Name,
                    AddressId = p.AddressId,
                    Website = p.Website,
                    Phone = p.Phone
                })
                .ToListAsync();
        }

        /// <summary>
        /// Retrieves a single publisher by its ID.
        /// </summary>
        /// <param name="id">The ID of the publisher.</param>
        /// <returns>A <see cref="PublisherViewModel"/> if found; otherwise, null.</returns>
        public async Task<PublisherViewModel> GetByIdPublisherAsync(int id)
        {
            var publisher = await _context.Publishers.FindAsync(id);
            if (publisher == null) return null;

            return new PublisherViewModel
            {
                Id = publisher.Id,
                Name = publisher.Name,
                AddressId = publisher.AddressId,
                Website = publisher.Website,
                Phone = publisher.Phone
            };
        }

        /// <summary>
        /// Updates an existing publisher in the database.
        /// </summary>
        /// <param name="model">The updated publisher view model.</param>
        /// <returns>True if the update was successful; otherwise, false.</returns>
        public async Task<bool> UpdatePublisherAsync(PublisherViewModel model)
        {
            var publisher = await _context.Publishers.FindAsync(model.Id);
            if (publisher == null) return false;

            publisher.Name = model.Name;
            publisher.AddressId = model.AddressId;
            publisher.Website = model.Website;
            publisher.Phone = model.Phone;

            _context.Publishers.Update(publisher);
            await _context.SaveChangesAsync();
            return true;
        }

        /// <summary>
        /// Deletes a publisher by its ID.
        /// </summary>
        /// <param name="id">The ID of the publisher to delete.</param>
        /// <returns>True if the publisher was deleted; otherwise, false.</returns>
        public async Task<bool> DeletePublisherAsync(int id)
        {
            var publisher = await _context.Publishers.FindAsync(id);
            if (publisher == null) return false;

            _context.Publishers.Remove(publisher);
            await _context.SaveChangesAsync();
            return true;
        }
    }
}
