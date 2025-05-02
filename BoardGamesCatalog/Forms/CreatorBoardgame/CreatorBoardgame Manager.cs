using BoardGamesCatalog.Controllers;
using BoardGamesCatalog.Data;
using BoardGamesCatalog.Models;
using Microsoft.AspNetCore.Mvc;
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
    public partial class CreatorBoardgame_Manager : Form
    {
        private readonly CreatorBoardgameController _controller;
        private readonly int? _creatorId;

        public CreatorBoardgame_Manager(CreatorBoardgameController controller, int? creatorId = null)
        {
            InitializeComponent();
            _controller = controller;
            _creatorId = creatorId;
            _ = LoadDataAsync();
        }
        private async Task LoadDataAsync()
        {
            List<CreatorBoardgameViewModel> data;

            if (_creatorId.HasValue)
            {
                data = await _controller.GetByCreatorIdAsync(_creatorId.Value);
            }
            else
            {
                data = await _controller.GetAllCreatorBoardgamesAsync();
            }

            var dt = new DataTable();
            dt.Columns.Add("Creator");
            dt.Columns.Add("Boardgame");

            foreach (var item in data)
            {
                var row = dt.NewRow();
                row["Creator"] = item.CreatorName;
                row["Boardgame"] = item.BoardgameName;
                dt.Rows.Add(row);
            }

            creatorBoardgameTable.DataSource = dt;
        }
        

        private async void btnAdd_Click(object sender, EventArgs e)
        {
            var assignForm = new Assign_CreatorBoardgames(_controller);
            if (assignForm.ShowDialog() == DialogResult.OK)
            {
                await LoadDataAsync();
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {

        }

        private void CreatorBoardgame_Manager_Load(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }

        private void creatorBoardgameTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
