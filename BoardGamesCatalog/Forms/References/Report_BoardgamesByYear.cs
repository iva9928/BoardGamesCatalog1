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

namespace BoardGamesCatalog.Forms.References
{
    public partial class Report_BoardgamesByYear : Form
    {
        private readonly BoardGamesContext _context;
        private readonly BoardGamesController _controller;

        public Report_BoardgamesByYear()
        {
            InitializeComponent();

            var options = new DbContextOptionsBuilder<BoardGamesContext>()
                .UseSqlServer(Configurations.ConnectionString)
                .Options;

            _context = new BoardGamesContext(options);
            _controller = new BoardGamesController(_context);

            this.Load += Report_BoardgamesByYear_Load;
            btnLoad.Click += btnLoad_Click;
            btnCancel.Click += (s, e) => this.Close();
        }

        private async void Report_BoardgamesByYear_Load(object sender, EventArgs e)
        {
            var years = await _context.Boardgames
                .Select(b => b.YearPublished)
                .Distinct()
                .OrderBy(y => y)
                .ToListAsync();

            cmbYears.DataSource = years;
        }



        private async void btnLoad_Click(object sender, EventArgs e)
        {
            if (cmbYears.SelectedItem is null) return;

            int selectedYear = (int)cmbYears.SelectedItem;
            var boardgames = await _controller.GetBoardgamesByYearAsync(selectedYear);
            dgvBoardgames.DataSource = boardgames;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {

        }
    }
}
