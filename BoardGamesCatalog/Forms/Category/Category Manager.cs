using BoardGamesCatalog.Controllers;
using BoardGamesCatalog.Data;
using BoardGamesCatalog.Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BoardGamesCatalog.Forms.Category
{
    public partial class Category_Manager : Form
    {
        private readonly CategoryController _controller;
        public Category_Manager()
        {
            InitializeComponent();

            var options = new DbContextOptionsBuilder<BoardGamesContext>()
            .UseSqlServer(Configurations.ConnectionString)
            .Options;

            var context = new BoardGamesContext(options);
            _controller = new CategoryController(context);

            // Стартираме асинхронното зареждане правилно
            _ = LoadDataAsync();
        }
        private async Task LoadDataAsync()
        {
            await ReadCategory();
        }

        private async Task ReadCategory()
        {
            DataTable dt = new DataTable();

            dt.Columns.Add("ID");
            dt.Columns.Add("Name");

            var categories = await _controller.GetAllCategoryAsync();

            foreach (var category in categories)
            {
                var row = dt.NewRow();
                row["ID"] = category.Id;
                row["Name"] = category.Name;

                dt.Rows.Add(row);
            }

            categoryTable.DataSource = dt;

        }

        private void Category_Manager_Load(object sender, EventArgs e)
        {

        }

        private async void btnAdd_Click(object sender, EventArgs e)
        {
            var createForm = new Create_Category();
            if (createForm.ShowDialog() == DialogResult.OK)
            {
                await ReadCategory();
            }
        }

        private async void btnEdit_Click(object sender, EventArgs e)
        {
            if (categoryTable.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a category to edit.");
                return;
            }

            var val = categoryTable.SelectedRows[0].Cells[0].Value?.ToString();
            if (string.IsNullOrWhiteSpace(val)) return;

            int categoryId = int.Parse(val);
            var category = await _controller.GetByIdCategoryAsync(categoryId);

            if (category == null)
            {
                MessageBox.Show("Category not found.");
                return;
            }

            var editForm = new Edit_Category(_controller);
            editForm.LoadCategory(category);

            if (editForm.ShowDialog() == DialogResult.OK)
            {
                await ReadCategory();
            }
        }

        private async void btnDelete_Click(object sender, EventArgs e)
        {

            var val = categoryTable.SelectedRows[0].Cells[0].Value?.ToString();
            if (string.IsNullOrWhiteSpace(val))
            {
                MessageBox.Show("Invalid selection.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!int.TryParse(val, out int categoryId))
            {
                MessageBox.Show("Invalid category ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var confirm = MessageBox.Show("Are you sure you want to delete this category?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirm != DialogResult.Yes)
            {
                return;
            }

            try
            {
                bool success = await _controller.DeleteCategoryAsync(categoryId);
                if (success)
                {
                    MessageBox.Show("Category deleted successfully.");
                }
                else
                {
                    MessageBox.Show("Category not found or could not be deleted.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while deleting the category:\n{ex.Message}");
            }

            await ReadCategory();
        }

        private void btnManu_Click(object sender, EventArgs e)
        {
            Main menu = new Main();
            menu.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
