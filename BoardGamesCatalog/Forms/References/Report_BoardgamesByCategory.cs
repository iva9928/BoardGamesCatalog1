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
    public partial class Report_BoardgamesByCategory : Form
    {
        private readonly BoardGamesContext _context;
        private readonly BoardGamesController _controller;

        public Report_BoardgamesByCategory()
        {
            InitializeComponent();

            var options = new DbContextOptionsBuilder<BoardGamesContext>()
                .UseSqlServer(Configurations.ConnectionString)
                .Options;

            _context = new BoardGamesContext(options);
            _controller = new BoardGamesController(_context);

            this.Load += Report_BoardgamesByCategory_Load;
            btnLoad.Click += btnLoad_Click;
            btnCancel.Click += (s, e) => this.Close();
        }
        private async void Report_BoardgamesByCategory_Load(object sender, EventArgs e)
        {
            List<CategoryViewModel> categories = new List<CategoryViewModel>();

            try
            {
                categories = await _context.Categories
                    .Select(c => new CategoryViewModel
                    {
                        Id = c.Id,
                        Name = c.Name
                    }).ToListAsync();
            }
            catch (InvalidOperationException)
            {
                
            }

            cmbCategories.DisplayMember = "Name";
            cmbCategories.ValueMember = "Id";
            cmbCategories.DataSource = categories;
        }


        private async void btnLoad_Click(object sender, EventArgs e)
        {
            if (cmbCategories.SelectedItem is CategoryViewModel selectedCategory)
            {
                List<BoardgameListViewModel> games = new List<BoardgameListViewModel>();

                try
                {
                    games = await _controller.GetBoardgamesByCategoryAsync(selectedCategory.Id);
                }
                catch (InvalidOperationException)
                {
                    
                }

                dgvBoardgames.DataSource = games;
            }
        }


        private void btnCancel_Click(object sender, EventArgs e)
        {

        }

        private void dgvBoardgames_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
