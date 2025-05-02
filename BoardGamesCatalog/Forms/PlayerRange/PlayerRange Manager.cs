using BoardGamesCatalog.Controllers;
using BoardGamesCatalog.Data;
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

namespace BoardGamesCatalog.Forms.PlayerRange
{
    public partial class PlayerRange_Manager : Form
    {
        private readonly PlayerRangeController _controller;

        public PlayerRange_Manager()
        {
            InitializeComponent();

            var options = new DbContextOptionsBuilder<BoardGamesContext>()
                .UseSqlServer(Configurations.ConnectionString)
                .Options;

            var context = new BoardGamesContext(options);
            _controller = new PlayerRangeController(context);

            this.Load += async (s, e) => await LoadPlayerRangesAsync();
        }

        private async Task LoadPlayerRangesAsync()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("ID");
            dt.Columns.Add("Players Min");
            dt.Columns.Add("Players Max");

            var ranges = await _controller.GetAllAsync();
            foreach (var r in ranges)
            {
                var row = dt.NewRow();
                row["ID"] = r.Id;
                row["Players Min"] = r.PlayersMin;
                row["Players Max"] = r.PlayersMax;
                dt.Rows.Add(row);
            }

            playerRTable.DataSource = dt;
        }
        private async void btnAdd_Click(object sender, EventArgs e)
        {
            var form = new Create_PlayerRange();
            if (form.ShowDialog() == DialogResult.OK)
                await LoadPlayerRangesAsync();
        }

        private async void btnEdit_Click(object sender, EventArgs e)
        {
            if (playerRTable.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a row.");
                return;
            }

            var val = playerRTable.SelectedRows[0].Cells[0].Value?.ToString();

            if (string.IsNullOrWhiteSpace(val) || !int.TryParse(val, out int rangeId))
            {
                MessageBox.Show("Invalid selection.");
                return;
            }

            var playerRange = await _controller.GetByIdAsync(rangeId);
            if (playerRange == null)
            {
                MessageBox.Show("Player range not found.");
                return;
            }

            var editForm = new Edit_PlayerRange(_controller);
            editForm.LoadPlayerRange(playerRange);

            if (editForm.ShowDialog() == DialogResult.OK)
            {
                await LoadPlayerRangesAsync();
            }
        }

        private async void  btnDelete_Click(object sender, EventArgs e)
        {
            if (playerRTable.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a player range to delete.");
                return;
            }

            var val = playerRTable.SelectedRows[0].Cells[0].Value?.ToString();
            if (!int.TryParse(val, out int id)) return;

            var confirm = MessageBox.Show("Are you sure you want to delete this range?", "Confirm", MessageBoxButtons.YesNo);
            if (confirm != DialogResult.Yes)
                return;

            bool deleted = await _controller.DeleteAsync(id);
            if (deleted)
            {
                MessageBox.Show("Range deleted.");
                await LoadPlayerRangesAsync();
            }
            else
            {
                MessageBox.Show("Failed to delete range.");
            }
        }

        private void PlayerRange_Manager_Load(object sender, EventArgs e)
        {

        }
    }
}
