using BoardGamesCatalog.Data;
using BoardGamesCatalog.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BoardGamesCatalog.Controllers
{
    /// <summary>
    /// Controller responsible for CRUD operations related to Address entities.
    /// </summary>
    public class AddressController
    {
        private readonly BoardGamesContext _context;

        /// <summary>
        /// Initializes a new instance of the <see cref="AddressController"/> class.
        /// </summary>
        /// <param name="context">The database context.</param>
        public AddressController(BoardGamesContext context)
        {
            _context = context;
        }

        /// <summary>
        /// Creates a new address and saves it to the database.
        /// </summary>
        /// <param name="model">The address view model containing data to save.</param>
        /// <returns>True if the operation was successful.</returns>
        public async Task<bool> CreateAddressAsync(AddressViewModel model)
        {
            var address = new Data.Models.Address
            {
                StreetName = model.StreetName,
                StreetNumber = model.StreetNumber,
                Town = model.Town,
                Country = model.Country,
                ZIP = model.ZIP
            };

            _context.Addresses.Add(address);
            await _context.SaveChangesAsync();
            return true;
        }

        /// <summary>
        /// Retrieves all addresses from the database.
        /// </summary>
        /// <returns>A list of address view models.</returns>
        public async Task<List<AddressViewModel>> GetAllAddressesAsync()
        {
            return await _context.Addresses
                .Select(a => new AddressViewModel
                {
                    Id = a.Id,
                    StreetName = a.StreetName,
                    StreetNumber = a.StreetNumber,
                    Town = a.Town,
                    Country = a.Country,
                    ZIP = a.ZIP
                })
                .ToListAsync();
        }

        /// <summary>
        /// Retrieves an address by its ID.
        /// </summary>
        /// <param name="id">The ID of the address to retrieve.</param>
        /// <returns>The corresponding <see cref="AddressViewModel"/> or null if not found.</returns>
        public async Task<AddressViewModel> GetByIdAddressAsync(int id)
        {
            var a = await _context.Addresses.FindAsync(id);
            if (a == null) return null;

            return new AddressViewModel
            {
                Id = a.Id,
                StreetName = a.StreetName,
                StreetNumber = a.StreetNumber,
                Town = a.Town,
                Country = a.Country,
                ZIP = a.ZIP
            };
        }

        /// <summary>
        /// Updates an existing address in the database.
        /// </summary>
        /// <param name="model">The updated address view model.</param>
        /// <returns>True if the update was successful, false otherwise.</returns>
        public async Task<bool> UpdateAddressAsync(AddressViewModel model)
        {
            var a = await _context.Addresses.FindAsync(model.Id);
            if (a == null) return false;

            a.StreetName = model.StreetName;
            a.StreetNumber = model.StreetNumber;
            a.Town = model.Town;
            a.Country = model.Country;
            a.ZIP = model.ZIP;

            _context.Addresses.Update(a);
            await _context.SaveChangesAsync();
            return true;
        }

        /// <summary>
        /// Deletes an address by its ID.
        /// </summary>
        /// <param name="id">The ID of the address to delete.</param>
        /// <returns>True if the deletion was successful, false otherwise.</returns>
        public async Task<bool> DeleteAddressAsync(int id)
        {
            var a = await _context.Addresses.FindAsync(id);
            if (a == null) return false;

            _context.Addresses.Remove(a);
            await _context.SaveChangesAsync();
            return true;
        }
    }
}
