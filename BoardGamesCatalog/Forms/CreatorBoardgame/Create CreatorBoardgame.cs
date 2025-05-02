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

namespace BoardGamesCatalog.Forms.CreatorBoardgame
{
    public partial class Create_CreatorBoardgame : Form
    {
        private readonly BoardGamesController _controller;

        public Create_CreatorBoardgame()
        {
            InitializeComponent();

            var options = new DbContextOptionsBuilder<BoardGamesContext>()
                .UseSqlServer(Configurations.ConnectionString)
                .Options;

            var context = new BoardGamesContext(options);
            _controller = new BoardGamesController(context);

            Load += Create_CreatorBoardgame_Load;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {

        }

        private void Create_CreatorBoardgame_Load(object sender, EventArgs e)
        {

        }
    }
}
