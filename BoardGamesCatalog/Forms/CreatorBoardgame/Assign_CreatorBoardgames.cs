using BoardGamesCatalog.Controllers;
using BoardGamesCatalog.Data;
using BoardGamesCatalog.Data.Models;
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

namespace BoardGamesCatalog.Forms.CreatorBoardgame
{
    public partial class Assign_CreatorBoardgames : Form
    {
        private readonly CreatorBoardgameController _controller;
        private readonly BoardGamesContext _context;

        public Assign_CreatorBoardgames(CreatorBoardgameController controller)
        {
            InitializeComponent();

            var options = new DbContextOptionsBuilder<BoardGamesContext>()
                .UseSqlServer(Configurations.ConnectionString)
                .Options;

            _context = new BoardGamesContext(options);
            _controller = controller;

            this.Load += Assign_CreatorBoardgames_Load;
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            var selectedCreator = (Data.Models.Creator)cmbCreators.SelectedItem;
            var selectedBoardgames = clbBoardgames.CheckedItems.Cast<Boardgame>().Select(bg => bg.Id).ToList();

            var model = new CreatorBoardgameViewModel
            {
                CreatorId = selectedCreator.Id,
                BoardgameIds = selectedBoardgames
            };

            await _controller.AssignBoardgamesToCreatorAsync(model);

            MessageBox.Show("Boardgames assigned to creator successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            var managerForm = new CreatorBoardgame_Manager(_controller, model.CreatorId);
            managerForm.Show();

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private async void Assign_CreatorBoardgames_Load(object sender, EventArgs e)
        {
            var creators = await _context.Creators.ToListAsync();
            cmbCreators.DataSource = creators;
            cmbCreators.DisplayMember = "FirstName";
            cmbCreators.ValueMember = "Id";

            var boardgames = await _controller.GetAllBoardgamesAsync();
            clbBoardgames.DataSource = boardgames;
            clbBoardgames.DisplayMember = "Name";
            clbBoardgames.ValueMember = "Id";
        }
    }
}
