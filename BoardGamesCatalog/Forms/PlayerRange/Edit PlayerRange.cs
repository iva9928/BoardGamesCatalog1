using BoardGamesCatalog.Controllers;
using BoardGamesCatalog.Models;
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
    public partial class Edit_PlayerRange : Form
    {
        private readonly PlayerRangeController _controller;
        private int _rangeId = -1;

        public Edit_PlayerRange(PlayerRangeController controller)
        {
            InitializeComponent();
            _controller = controller;
            this.DialogResult = DialogResult.Cancel;
        }

        public void LoadPlayerRange(PlayerRangeViewModel range)
        {
            _rangeId = range.Id;
            txtMin.Text = range.PlayersMin.ToString();
            txtMax.Text = range.PlayersMax.ToString();
        }
        private async void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                var model = new PlayerRangeViewModel
                {
                    Id = _rangeId,
                    PlayersMin = int.Parse(txtMin.Text),
                    PlayersMax = int.Parse(txtMax.Text)
                };

                bool updated = await _controller.UpdateAsync(model);

                if (updated)
                {
                    MessageBox.Show("Player range updated successfully!", "Success");
                    this.DialogResult = DialogResult.OK;
                }
                else
                {
                    MessageBox.Show("Failed to update player range.", "Error");
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

        private void Edit_PlayerRange_Load(object sender, EventArgs e)
        {

        }
    }
}
