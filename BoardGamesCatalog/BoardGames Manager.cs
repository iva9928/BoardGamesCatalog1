using BoardGamesCatalog.Data.Models;
using BoardGamesCatalog.Repositories;
using Microsoft.Azure.Cosmos.Linq;
using System.Data;

namespace BoardGamesCatalog
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            ReadBoardGame();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void ReadBoardGame()
        {
            DataTable dt = new DataTable();

            dt.Columns.Add("ID");
            dt.Columns.Add("Name");
            dt.Columns.Add("YearPublished");
            dt.Columns.Add("Rating");
            dt.Columns.Add("CategoryId");
            dt.Columns.Add("PublisherId");
            dt.Columns.Add("PrayerRangeId");

            BoardGamesRepository boardGamesRepository = new BoardGamesRepository();

            List<Boardgame> boardgames = boardGamesRepository.GetBoardGames();

            foreach (var boardgame in boardgames)
            {
                var row = dt.NewRow();
                row["ID"] = boardgame.Id;
                row["Name"] = boardgame.Name;
                row["YearPublished"] = boardgame.YearPublished;
                row["Rating"] = boardgame.Rating;
                row["CategoryId"] = boardgame.CategoryId;
                row["PublisherId"] = boardgame.PublisherId;
                row["PrayerRangeId"] = boardgame.PlayerRangeId;

                dt.Rows.Add(row);
            }

            this.boardgamesTable.DataSource = dt;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Create_BoardGame create_BoardGame = new Create_BoardGame();
            if (create_BoardGame.ShowDialog() == DialogResult.OK)
            {
                ReadBoardGame();
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            //var val = this.boardgamesTable.SelectedRows[0].Cells[0].Value.ToString();

            //if (val == null || val.Length == 0)
            //{
            //    return;
            //}

            //int boardGameId = int.Parse(val);

            //BoardGamesRepository boardGamesRepository = new BoardGamesRepository();
            //var boardGame = boardGamesRepository.GetBoardGame(boardGameId);

            //if (boardGame == null)
            //{
            //    return;
            //}

            //Edit_BoardGame edit_BoardGame = new Edit_BoardGame();
            //edit_BoardGame.EditBoardGame(boardGame);

            //if (edit_BoardGame.ShowDialog() == DialogResult.OK)
            //{
            //    ReadBoardGame();
            //}
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            //var val = this.boardgamesTable.SelectedRows[0].Cells[0].Value.ToString();

            //if (val == null || val.Length == 0)
            //{
            //    return;
            //}

            //int boardGameId = int.Parse(val);

            //DialogResult dialogResult =
            //    MessageBox.Show("Are you sure you want to delete this BoardGame?",
            //    "Delete BoardGame", MessageBoxButtons.YesNo);

            //if (dialogResult == DialogResult.No)
            //{
            //    return;
            //}

            //BoardGamesRepository boardGamesRepository = new BoardGamesRepository();
            //boardGamesRepository.DeleteBoardGame(boardGameId);

            //ReadBoardGame();
        }
    }
}
