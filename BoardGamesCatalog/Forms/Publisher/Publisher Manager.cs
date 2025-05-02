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

namespace BoardGamesCatalog.Forms.Publisher
{
    public partial class Publisher_Manager : Form
    {
        private readonly PublisherController _controller;

        public Publisher_Manager()
        {
            InitializeComponent();

            var options = new DbContextOptionsBuilder<BoardGamesContext>()
                .UseSqlServer(Configurations.ConnectionString)
                .Options;

            var context = new BoardGamesContext(options);
            _controller = new PublisherController(context);

            this.Load += async (s, e) => await LoadPublishersAsync();
        }

        private async Task LoadPublishersAsync()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("ID");
            dt.Columns.Add("Name");
            dt.Columns.Add("Website");
            dt.Columns.Add("Phone");

            var publishers = await _controller.GetAllPublishersAsync();
            foreach (var pub in publishers)
            {
                var row = dt.NewRow();
                row["ID"] = pub.Id;
                row["Name"] = pub.Name;
                row["Website"] = pub.Website;
                row["Phone"] = pub.Phone;
                dt.Rows.Add(row);
            }

            publishersTable.DataSource = dt;
        }

        private async void btnAdd_Click(object sender, EventArgs e)
        {
            var form = new Create_Publisher();
            if (form.ShowDialog() == DialogResult.OK)
                await LoadPublishersAsync();
        }

        
        
        private void Publisher_Manager_Load(object sender, EventArgs e)
        {

        }

        private async void btnAdd_Click_1(object sender, EventArgs e)
        {
            var form = new Create_Publisher();
            if (form.ShowDialog() == DialogResult.OK)
                await LoadPublishersAsync();
        }

        private async void btnEdit_Click_1(object sender, EventArgs e)
        {
            if (publishersTable.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a publisher to edit.");
                return;
            }

            var val = publishersTable.SelectedRows[0].Cells[0].Value?.ToString();
            if (!int.TryParse(val, out int id)) return;

            var publisher = await _controller.GetByIdPublisherAsync(id);
            if (publisher == null)
            {
                MessageBox.Show("Publisher not found.");
                return;
            }

            var form = new Edit_Publisher(_controller);
            form.LoadPublisher(publisher);
            if (form.ShowDialog() == DialogResult.OK)
                await LoadPublishersAsync();
        }

        private async void btnDelete_Click_1(object sender, EventArgs e)
        {
            if (publishersTable.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a publisher to delete.");
                return;
            }

            var val = publishersTable.SelectedRows[0].Cells[0].Value?.ToString();
            if (!int.TryParse(val, out int id)) return;

            if (MessageBox.Show("Confirm delete?", "Confirm", MessageBoxButtons.YesNo) != DialogResult.Yes)
                return;

            var result = await _controller.DeletePublisherAsync(id);
            if (result)
            {
                MessageBox.Show("Deleted.");
                await LoadPublishersAsync();
            }
            else
            {
                MessageBox.Show("Could not delete publisher.");
            }
        }
    }
}
