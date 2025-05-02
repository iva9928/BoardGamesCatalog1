using BoardGamesCatalog.Data;
using BoardGamesCatalog.Data.Models;
using BoardGamesCatalog.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace BoardGamesCatalog.Controllers
{
    /// <summary>
    /// Controller for managing category-related operations.
    /// </summary>
    public class CategoryController
    {
        private readonly BoardGamesContext _context;

        /// <summary>
        /// Initializes a new instance of the <see cref="CategoryController"/> class.
        /// </summary>
        /// <param name="context">The database context.</param>
        public CategoryController(BoardGamesContext context)
        {
            _context = context;
        }

        /// <summary>
        /// Creates a new category based on the provided model.
        /// </summary>
        /// <param name="model">The view model containing the category data.</param>
        /// <returns>True if the category was created successfully.</returns>
        public async Task<bool> CreateCategoryAsync(CategoryViewModel model)
        {
            var category = new Data.Models.Category
            {
                Name = model.Name
            };

            _context.Categories.Add(category);
            await _context.SaveChangesAsync();
            return true;
        }

        /// <summary>
        /// Retrieves all categories from the database.
        /// </summary>
        /// <returns>A list of <see cref="CategoryViewModel"/> representing all categories.</returns>
        public async Task<List<CategoryViewModel>> GetAllCategoryAsync()
        {
            return await _context.Categories
                .Select(c => new CategoryViewModel
                {
                    Id = c.Id,
                    Name = c.Name
                })
                .ToListAsync();
        }

        /// <summary>
        /// Updates an existing category.
        /// </summary>
        /// <param name="model">The view model containing updated data.</param>
        /// <returns>True if the category was updated successfully, false if not found.</returns>
        public async Task<bool> UpdateCategoryAsync(CategoryViewModel model)
        {
            var category = await _context.Categories.FindAsync(model.Id);
            if (category == null) return false;

            category.Name = model.Name;
            _context.Categories.Update(category);
            await _context.SaveChangesAsync();
            return true;
        }

        /// <summary>
        /// Deletes a category by its ID.
        /// </summary>
        /// <param name="id">The ID of the category to delete.</param>
        /// <returns>True if the category was deleted successfully, false if not found.</returns>
        public async Task<bool> DeleteCategoryAsync(int id)
        {
            var category = await _context.Categories.FindAsync(id);
            if (category == null) return false;

            _context.Categories.Remove(category);
            await _context.SaveChangesAsync();
            return true;
        }

        /// <summary>
        /// Retrieves a category by its ID.
        /// </summary>
        /// <param name="id">The ID of the category.</param>
        /// <returns>A <see cref="CategoryViewModel"/> representing the category, or null if not found.</returns>
        public async Task<CategoryViewModel> GetByIdCategoryAsync(int id)
        {
            var category = await _context.Categories.FindAsync(id);
            if (category == null) return null;

            return new CategoryViewModel
            {
                Id = category.Id,
                Name = category.Name
            };
        }
    }
}
