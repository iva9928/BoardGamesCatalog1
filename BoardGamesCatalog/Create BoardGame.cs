using BoardGamesCatalog.Data.Models;
using BoardGamesCatalog.Repositories;
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
    public partial class Create_BoardGame : Form
    {
        public Create_BoardGame()
        {
            InitializeComponent();
            this.DialogResult = DialogResult.Cancel;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Boardgame boardgame = new Boardgame(); 
            boardgame.Name = this.txtBName.Text;
            boardgame.YearPublished = int.Parse(txtBYear.Text);
            boardgame.Rating = decimal.Parse(txtBRating.Text);
            boardgame.CategoryId = int.Parse(txtBCategId.Text);
            boardgame.PublisherId = int.Parse(txtBPublishId.Text);
            boardgame.PlayerRangeId = int.Parse(txtBPRId.Text);

            var repo = new BoardGamesRepository();
            repo.CreateBoardGame(boardgame);
            this.DialogResult = DialogResult.OK;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;

        }

        private void Create_BoardGame_Load(object sender, EventArgs e)
        {

        }
    }
}
