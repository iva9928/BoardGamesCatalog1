using BoardGamesCatalog.Controllers;
using BoardGamesCatalog.Data;
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

namespace BoardGamesCatalog.Forms.References
{
    public partial class Report_BoardgamesByPublisher : Form
    {
        private readonly BoardGamesController _controller;

        public Report_BoardgamesByPublisher()
        {
            InitializeComponent();

            var options = new DbContextOptionsBuilder<BoardGamesContext>()
                .UseSqlServer(Configurations.ConnectionString)
                .Options;

            var context = new BoardGamesContext(options);
            _controller = new BoardGamesController(context);

            this.Load += Report_BoardgamesByPublisher_Load;
            btnLoad.Click += btnLoad_Click;
        }
        private async void btnLoad_Click(object sender, EventArgs e)
        {
            if (cmbPublishers.SelectedItem is PublisherViewModel selectedPublisher)
            {
                List<BoardgameListViewModel> games = new List<BoardgameListViewModel>();

                try
                {
                    games = await _controller.GetBoardgamesByPublisherAsync(selectedPublisher.Id);
                }
                catch (InvalidOperationException)
                {


                }
                dgvBoardgames.DataSource = games;
            }
        }

        private void dgvBoardgames_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private async void Report_BoardgamesByPublisher_Load(object sender, EventArgs e)
        { 
            List<PublisherViewModel> publishers= new List<PublisherViewModel>();

            try
            {
                publishers = await _controller.GetAllPublishersAsync();
            }
            catch (InvalidOperationException)
            {

                
            }
           
            cmbPublishers.DisplayMember = "Name";
            cmbPublishers.ValueMember = "Id";
            cmbPublishers.DataSource = publishers;
        }
    }
}
