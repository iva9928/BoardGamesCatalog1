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

namespace BoardGamesCatalog.Forms.PlayerRange
{
    public partial class Create_PlayerRange : Form
    {
        private readonly PlayerRangeController _controller;

        public Create_PlayerRange()
        {
            InitializeComponent();
            this.DialogResult = DialogResult.Cancel;

            var options = new DbContextOptionsBuilder<BoardGamesContext>()
                .UseSqlServer(Configurations.ConnectionString)
                .Options;

            var context = new BoardGamesContext(options);
            _controller = new PlayerRangeController(context);
        }


        private void lblAId_Click(object sender, EventArgs e)
        {

        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                var model = new PlayerRangeViewModel
                {
                    PlayersMin = int.Parse(txtMin.Text),
                    PlayersMax = int.Parse(txtMax.Text)
                };

                bool result = await _controller.CreateAsync(model);

                if (result)
                {
                    MessageBox.Show("Player range added successfully!", "Success");
                    this.DialogResult = DialogResult.OK;
                }
                else
                {
                    MessageBox.Show("Failed to add player range.", "Error");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Exception");
            }
        }

        private async void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private async void Create_PlayerRange_Load(object sender, EventArgs e)
        {
            
        }
    }
}
