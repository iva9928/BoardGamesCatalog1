using BoardGamesCatalog.Controllers;
using BoardGamesCatalog.Data;
using BoardGamesCatalog.Data.Models;
using BoardGamesCatalog.Models;
using BoardGamesCatalog.Repositories;
using Microsoft.AspNetCore.Mvc;
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

namespace BoardGamesCatalog
{
    public partial class Edit_BoardGame : Form
    {
        private readonly BoardGamesController _controller;

        public Edit_BoardGame(BoardGamesController controller)
        {
            InitializeComponent();
            _controller = controller;
            this.DialogResult = DialogResult.Cancel;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private int boardGameId = -1;
        public void LoadBoardgame(BoardgameListViewModel boardgame)
        {
            if (boardgame == null) return;

            boardGameId = boardgame.Id;
            txtBName.Text = boardgame.Name;
            txtBYear.Text = boardgame.YearPublished.ToString();
            txtBRating.Text = boardgame.Rating.ToString();
            txtBCategId.Text = boardgame.CategoryId.ToString();
            txtBPublishId.Text = boardgame.PublisherId.ToString();
            txtBPRId.Text = boardgame.PlayersRangeId.ToString();
        }
        public void EditBoardGame(Boardgame boardgame)
        {
            label2.Text = "" + boardgame.Id;
            txtBName.Text = boardgame.Name;
            txtBYear.Text = boardgame.YearPublished.ToString();
            txtBRating.Text = boardgame.Rating.ToString();
            txtBCategId.Text = boardgame.CategoryId.ToString();
            txtBPublishId.Text = boardgame.PublisherId.ToString();
            txtBPRId.Text = boardgame.PlayersRangeId.ToString();

            this.boardGameId = boardgame.Id;
        }

        private void Edit_BoardGame_Load(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {

        }

        private void lblPublisherId_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private async void btnSave_Click_1(object sender, EventArgs e)
        {
            try
            {
                var model = new BoardgameEditViewModel
                {
                    Id = boardGameId,
                    Name = txtBName.Text,
                    YearPublished = int.Parse(txtBYear.Text),
                    Rating = decimal.Parse(txtBRating.Text),
                    CategoryId = int.Parse(txtBCategId.Text),
                    PublisherId = int.Parse(txtBPublishId.Text),
                    PlayersRangeId = int.Parse(txtBPRId.Text)
                };

                bool updated = await _controller.UpdateAsync(model);

                if (updated)
                {
                    MessageBox.Show("BoardGame updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.DialogResult = DialogResult.OK;
                }
                else
                {
                    MessageBox.Show("Failed to update BoardGame.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error while updating BoardGame: {ex.InnerException?.Message ?? ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Edit_BoardGame_Load_1(object sender, EventArgs e)
        {

        }
    }
}
