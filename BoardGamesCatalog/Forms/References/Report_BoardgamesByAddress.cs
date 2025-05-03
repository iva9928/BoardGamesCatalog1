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
    public partial class Report_BoardgamesByAddress : Form
    {
        private readonly BoardGamesContext _context;

        public Report_BoardgamesByAddress()
        {
            InitializeComponent();

            var options = new DbContextOptionsBuilder<BoardGamesContext>()
                .UseSqlServer(Configurations.ConnectionString)
                .Options;

            _context = new BoardGamesContext(options);

            this.Load += Report_BoardgamesByAddress_Load;
            btnLoad.Click += btnLoad_Click;
        }


        private async void Report_BoardgamesByAddress_Load(object sender, EventArgs e)
        {
            List<AddressViewModel> addresses = new List<AddressViewModel>();

            try
            {
                addresses = await _context.Addresses
                    .Select(a => new AddressViewModel
                    {
                        Id = a.Id,
                        StreetName = a.StreetName,
                        StreetNumber = a.StreetNumber,
                        Town = a.Town,
                        Country = a.Country,
                        ZIP = a.ZIP
                    }).ToListAsync();
            }
            catch (InvalidOperationException)
            {
                // Optional: Handle error
            }

            cmbAddresses.DisplayMember = "Town";      // показваме града
            cmbAddresses.ValueMember = "Id";
            cmbAddresses.DataSource = addresses;
        }

        private async void btnLoad_Click(object sender, EventArgs e)
        {
            if (cmbAddresses.SelectedItem is AddressViewModel selectedAddress)
            {
                List<BoardgameListViewModel> games = new List<BoardgameListViewModel>();

                try
                {
                    games = await _context.Boardgames
                        .Include(b => b.Publisher)
                        .Where(b => b.Publisher.AddressId == selectedAddress.Id)
                        .Select(b => new BoardgameListViewModel
                        {
                            Id = b.Id,
                            Name = b.Name,
                            YearPublished = b.YearPublished,
                            Rating = b.Rating,
                            PublisherId = b.PublisherId,
                            CategoryId = b.CategoryId,
                            PlayersRangeId = b.PlayersRangeId
                        })
                        .ToListAsync();
                }
                catch (InvalidOperationException)
                {
                    // Optional: log or handle exception
                }

                dgvBoardgames.DataSource = games;
            }
        }

    }
}
