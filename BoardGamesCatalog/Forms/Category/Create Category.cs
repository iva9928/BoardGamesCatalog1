using BoardGamesCatalog.Controllers;
using BoardGamesCatalog.Data;
using BoardGamesCatalog.Data.Models;
using BoardGamesCatalog.Models;
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
    public partial class Create_Category : Form
    {
        private readonly CategoryController _controller;

        public Create_Category()
        {
            InitializeComponent();
            this.DialogResult = DialogResult.Cancel;

            var options = new DbContextOptionsBuilder<BoardGamesContext>()
                .UseSqlServer(Configurations.ConnectionString)
                .Options;

            var context = new BoardGamesContext(options);
            _controller = new CategoryController(context);

            this.Load += Create_Category_Load;
        }

        private void Create_Category_Load(object sender, EventArgs e)
        {

        }
        private int categoryId = -1;
        private async void btnSave_Click(object sender, EventArgs e)
        {

            try
            {
                var model = new CategoryViewModel
                {
                    Id = categoryId,
                    Name = txtName.Text,

                };

                bool updated = await _controller.CreateCategoryAsync(model);

                if (updated)
                {
                    MessageBox.Show("Category updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.DialogResult = DialogResult.OK;
                }
                else
                {
                    MessageBox.Show("Failed to update Category.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error while updating Category: {ex.InnerException?.Message ?? ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
