using BoardGamesCatalog.Business;
using BoardGamesCatalog.Data.Models;
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
        public Edit_BoardGame()
        {
            InitializeComponent();
            this.DialogResult = DialogResult.Cancel;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private int boardGameId = -1;

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

        private void btnSave_Click_1(object sender, EventArgs e)
        {
            Boardgame boardgame = new Boardgame();
            boardgame.Id = this.boardGameId;
            boardgame.Name = this.txtBName.Text;
            boardgame.YearPublished = int.Parse(txtBYear.Text);
            boardgame.Rating = decimal.Parse(txtBRating.Text);
            boardgame.CategoryId = int.Parse(txtBCategId.Text);
            boardgame.PublisherId = int.Parse(txtBPublishId.Text);
            boardgame.PlayersRangeId = int.Parse(txtBPRId.Text);

            BoardGameBusiness boardGameBusiness = new BoardGameBusiness();

            if (boardgame.Id == -1)
            {
                boardGameBusiness.Add(boardgame);
            }
            else
            {
                boardGameBusiness.Update(boardgame);
            }
                
            this.DialogResult = DialogResult.OK;
        }

        private void Edit_BoardGame_Load_1(object sender, EventArgs e)
        {

        }
    }
}
