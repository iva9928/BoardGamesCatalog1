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
using System.Xml.Linq;

namespace BoardGamesCatalog.Forms.Creator
{
    public partial class Create_Creator : Form
    {
        private readonly CreatorController _controller;
        public Create_Creator()
        {
            InitializeComponent();
            this.DialogResult = DialogResult.Cancel;

            var options = new DbContextOptionsBuilder<BoardGamesContext>()
                .UseSqlServer(Configurations.ConnectionString)
                .Options;

            var context = new BoardGamesContext(options);
            _controller = new CreatorController(context);

            this.Load += Create_Creator_Load;
        }
        private int creatorId = -1;
        private async void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                var model = new CreatorViewModel
                {
                    Id = creatorId,
                    FirstName = txtFN.Text,
                    LastName = txtLN.Text,
                    Email = txtEmail.Text
                };

                bool success;

                if (creatorId == -1)
                {
                    // Създаване на нов Creator
                    success = await _controller.CreateCreatorAsync(model);
                }
                else
                {
                    // Редактиране на съществуващ Creator
                    success = await _controller.UpdateCreatorAsync(model);
                }

                if (success)
                {
                    MessageBox.Show("Creator saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.DialogResult = DialogResult.OK;
                }
                else
                {
                    MessageBox.Show("Failed to save Creator.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error while saving Creator: {ex.InnerException?.Message ?? ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void Create_Creator_Load(object sender, EventArgs e)
        {

        }
    }
}
