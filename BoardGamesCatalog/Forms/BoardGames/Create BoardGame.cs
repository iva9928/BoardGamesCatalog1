using BoardGamesCatalog.Controllers;
using BoardGamesCatalog.Data;
using BoardGamesCatalog.Models;
using Microsoft.EntityFrameworkCore;

namespace BoardGamesCatalog
{
    public partial class Create_BoardGame : Form
    {
        private readonly BoardGamesController _controller;

        public Create_BoardGame()
        {
            InitializeComponent();
            this.DialogResult = DialogResult.Cancel;

            var options = new DbContextOptionsBuilder<BoardGamesContext>()
                .UseSqlServer(Configurations.ConnectionString)
                .Options;

            var context = new BoardGamesContext(options);
            _controller = new BoardGamesController(context);

            this.Load += Create_BoardGame_Load;
        }

        private void Create_BoardGame_Load(object sender, EventArgs e)
        {
            
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                var model = new BoardgameAddViewModel
                {
                    Name = txtBName.Text,
                    YearPublished = int.Parse(txtBYear.Text),
                    Rating = decimal.Parse(txtBRating.Text),
                    CategoryId = int.Parse(txtBCategId.Text),
                    PublisherId = int.Parse(txtBPublishId.Text),
                    PlayersRangeId = int.Parse(txtBPRId.Text)
                };

                bool created = await _controller.CreateAsync(model);

                if (created)
                {
                    MessageBox.Show("BoardGame created successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.DialogResult = DialogResult.OK;
                }
                else
                {
                    MessageBox.Show("Failed to create BoardGame.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error while creating BoardGame: {ex.InnerException?.Message ?? ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
