using BoardGamesCatalog.Controllers;
using BoardGamesCatalog.Data;
using BoardGamesCatalog.Data.Models;
using BoardGamesCatalog.Forms.Category;
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

namespace BoardGamesCatalog.Forms.Creator
{
    public partial class Creator_Manager : Form
    {
        private readonly CreatorController _controller;

        public Creator_Manager()
        {
            InitializeComponent();

            var options = new DbContextOptionsBuilder<BoardGamesContext>()
                .UseSqlServer(Configurations.ConnectionString)
                .Options;

            var context = new BoardGamesContext(options);
            _controller = new CreatorController(context);

            this.Load += Creator_Manager_Load;
        }

        private async void Creator_Manager_Load(object sender, EventArgs e)
        {
            await ReadCreator();
        }

        private async Task ReadCreator()
        {
            DataTable dt = new DataTable();

            dt.Columns.Add("ID");
            dt.Columns.Add("First Name");
            dt.Columns.Add("Last Name");
            dt.Columns.Add("Email");

            var creators = await _controller.GetAllCreatorsAsync();

            foreach (var creator in creators)
            {
                var row = dt.NewRow();
                row["ID"] = creator.Id;
                row["First Name"] = creator.FirstName;
                row["Last Name"] = creator.LastName;
                row["Email"] = creator.Email;

                dt.Rows.Add(row);
            }

            creatorTable.DataSource = dt;
        }

        private async void btnAdd_Click(object sender, EventArgs e)
        {
            var createForm = new Create_Creator();
            if (createForm.ShowDialog() == DialogResult.OK)
            {
                await ReadCreator();
            }
        }

        private async void btnEdit_Click(object sender, EventArgs e)
        {
            if (creatorTable.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a creator to edit.");
                return;
            }

            var val = creatorTable.SelectedRows[0].Cells[0].Value?.ToString();
            if (string.IsNullOrWhiteSpace(val)) return;

            int creatorId = int.Parse(val);
            var creator = await _controller.GetByIdCreatorAsync(creatorId);

            if (creator == null)
            {
                MessageBox.Show("Creator not found.");
                return;
            }

            var editForm = new Edit_Creator(_controller);
            editForm.LoadCreator(creator);

            if (editForm.ShowDialog() == DialogResult.OK)
            {
                await ReadCreator();
            }
        }

        private async void btnDelete_Click(object sender, EventArgs e)
        {
            var val = creatorTable.SelectedRows[0].Cells[0].Value?.ToString();
            if (string.IsNullOrWhiteSpace(val))
            {
                MessageBox.Show("Invalid selection.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!int.TryParse(val, out int creatorId))
            {
                MessageBox.Show("Invalid creator ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var confirm = MessageBox.Show("Are you sure you want to delete this creator?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirm != DialogResult.Yes)
            {
                return;
            }

            try
            {
                bool success = await _controller.DeleteCreatorAsync(creatorId);
                if (success)
                {
                    MessageBox.Show("Creator deleted successfully.");
                }
                else
                {
                    MessageBox.Show("Creator not found or could not be deleted.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while deleting the creator:\n{ex.Message}");
            }

            await ReadCreator();
        }

        private void creatorTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Optional: handle clicks on the grid if needed
        }
    }
}
