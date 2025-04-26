using BoardGamesCatalog.Controllers;
using BoardGamesCatalog.Data;
using BoardGamesCatalog.Data.Models;
using BoardGamesCatalog.Repositories;
using Microsoft.Azure.Cosmos.Linq;
using Microsoft.EntityFrameworkCore;
using System.Data;

namespace BoardGamesCatalog
{
    public partial class Form1 : Form
    {
        private readonly BoardGamesController _controller;
        public Form1()
        {
            InitializeComponent();

            var options = new DbContextOptionsBuilder<BoardGamesContext>()
                .UseSqlServer(Configurations.ConnectionString)
                .Options;

            var context = new BoardGamesContext(options);
            _controller = new BoardGamesController(context);

            // Стартираме асинхронното зареждане правилно
            _ = LoadDataAsync();
        }
        private async Task LoadDataAsync()
        {
            await ReadBoardGame();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private async Task ReadBoardGame()
        {
            DataTable dt = new DataTable();

            dt.Columns.Add("ID");
            dt.Columns.Add("Name");
            dt.Columns.Add("YearPublished");
            dt.Columns.Add("Rating");
            dt.Columns.Add("CategoryId");
            dt.Columns.Add("PublisherId");
            dt.Columns.Add("PlayersRangeId"); 

            var boardgames = await _controller.GetAllAsync(); 

            foreach (var boardgame in boardgames)
            {
                var row = dt.NewRow();
                row["ID"] = boardgame.Id;
                row["Name"] = boardgame.Name;
                row["YearPublished"] = boardgame.YearPublished;
                row["Rating"] = boardgame.Rating;
                row["CategoryId"] = boardgame.CategoryId;
                row["PublisherId"] = boardgame.PublisherId;
                row["PlayersRangeId"] = boardgame.PlayersRangeId; 
                dt.Rows.Add(row);
            }

            boardgamesTable.DataSource = dt;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Create_BoardGame createForm = new Create_BoardGame();
            if (createForm.ShowDialog() == DialogResult.OK)
            {
                ReadBoardGame();
            }
        }

        private async void btnEdit_Click(object sender, EventArgs e)
        {
            if (boardgamesTable.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a board game to edit.");
                return;
            }

            var val = boardgamesTable.SelectedRows[0].Cells[0].Value?.ToString();
            if (string.IsNullOrWhiteSpace(val)) return;

            int boardGameId = int.Parse(val);

            var boardGame = await _controller.GetByIdAsync(boardGameId);
            if (boardGame == null)
            {
                MessageBox.Show("Board game not found.");
                return;
            }

            var editForm = new Edit_BoardGame(_controller);
            editForm.LoadBoardgame(boardGame);

            if (editForm.ShowDialog() == DialogResult.OK)
            {
                ReadBoardGame();
            }
        }

        private async void btnDelete_Click(object sender, EventArgs e)
        {
            if (boardgamesTable.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a board game to delete.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var val = boardgamesTable.SelectedRows[0].Cells[0].Value?.ToString();
            if (string.IsNullOrWhiteSpace(val))
            {
                MessageBox.Show("Invalid selection.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!int.TryParse(val, out int boardGameId))
            {
                MessageBox.Show("Invalid board game ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var confirm = MessageBox.Show("Are you sure you want to delete this board game?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirm != DialogResult.Yes)
            {
                return;
            }

            try
            {
                bool success = await _controller.DeleteAsync(boardGameId);
                if (success)
                {
                    MessageBox.Show("Board game deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Board game not found or could not be deleted.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while deleting the board game.\nDetails: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            ReadBoardGame();
        }
    }
}
