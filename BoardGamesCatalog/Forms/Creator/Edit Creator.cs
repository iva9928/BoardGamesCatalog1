using BoardGamesCatalog.Controllers;
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
using System.Xml.Linq;

namespace BoardGamesCatalog.Forms.Creator
{
    public partial class Edit_Creator : Form
    {
        private readonly CreatorController _controller;
        public Edit_Creator(CreatorController controller)
        {
            InitializeComponent();
            _controller = controller;
            this.DialogResult = DialogResult.Cancel;
        }
        private int creatorId = -1;

        public void LoadCreator(CreatorViewModel creator)
        {
            if (creator == null) return;

            creatorId = creator.Id;
            txtFN.Text = creator.FirstName;
            txtLN.Text = creator.LastName;
            txtEmail.Text = creator.Email;


        }
        private void Edit_Creator_Load(object sender, EventArgs e)
        {

        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                var model = new CreatorViewModel
                {
                    Id = creatorId,
                    FirstName = txtFN.Text,
                    LastName = txtLN.Text,
                    Email = txtEmail.Text,

                };

                bool updated = await _controller.UpdateCreatorAsync(model);

                if (updated)
                {
                    MessageBox.Show("Creator updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.DialogResult = DialogResult.OK;
                }
                else
                {
                    MessageBox.Show("Failed to update Creator.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error while updating Creator: {ex.InnerException?.Message ?? ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
