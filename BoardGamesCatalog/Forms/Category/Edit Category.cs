using BoardGamesCatalog.Controllers;
using BoardGamesCatalog.Data.Models;
using BoardGamesCatalog.Models;
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
    public partial class Edit_Category : Form
    {
        private readonly CategoryController _controller;
        public Edit_Category(CategoryController controller)
        {
            InitializeComponent();
            _controller = controller;
            this.DialogResult = DialogResult.Cancel;
        }
        private int categoryId = -1;
        public void LoadCategory(CategoryViewModel category)
        {
            if (category == null) return;

            categoryId = category.Id;
            txtName.Text = category.Name;

        }
        //public void EditCategory(Category category)
        //{
        //    label1.Text = "" + category.Id;
        //    txtName.Text = category.Name;


        //    this.categoryId = category.Id;
        //}
        private async void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                var model = new CategoryViewModel
                {
                    Id = categoryId,
                    Name = txtName.Text,

                };

                bool updated = await _controller.UpdateCategoryAsync(model);

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

        private void Edit_Category_Load(object sender, EventArgs e)
        {

        }
    }
}
