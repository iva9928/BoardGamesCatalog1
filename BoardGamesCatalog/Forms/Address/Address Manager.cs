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

namespace BoardGamesCatalog.Forms.Address
{
    public partial class Address_Manager : Form
    {
        private readonly AddressController _controller;

        public Address_Manager()
        {
            InitializeComponent();

            var options = new DbContextOptionsBuilder<BoardGamesContext>()
                .UseSqlServer(Configurations.ConnectionString)
                .Options;

            var context = new BoardGamesContext(options);
            _controller = new AddressController(context);

            this.Load += async (s, e) => await LoadAddressesAsync();
        }

        private async Task LoadAddressesAsync()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("ID");
            dt.Columns.Add("Street Name");
            dt.Columns.Add("Street Number");
            dt.Columns.Add("Town");
            dt.Columns.Add("Country");
            dt.Columns.Add("ZIP");

            var addresses = await _controller.GetAllAddressesAsync();
            foreach (var a in addresses)
            {
                var row = dt.NewRow();
                row["ID"] = a.Id;
                row["Street Name"] = a.StreetName;
                row["Street Number"] = a.StreetNumber;
                row["Town"] = a.Town;
                row["Country"] = a.Country;
                row["ZIP"] = a.ZIP;

                dt.Rows.Add(row);
            }

            addressTable.DataSource = dt;
        }


        private async void btnAdd_Click(object sender, EventArgs e)
        {
            var form = new Create_Address();
            if (form.ShowDialog() == DialogResult.OK)
                await LoadAddressesAsync();
        }

        private async void btnEdit_Click(object sender, EventArgs e)
        {
            if (addressTable.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select an address to edit.");
                return;
            }

            var val = addressTable.SelectedRows[0].Cells[0].Value?.ToString();
            if (!int.TryParse(val, out int id)) return;

            var address = await _controller.GetByIdAddressAsync(id);    
            if (address == null)
            {
                MessageBox.Show("Address not found.");
                return;
            }

            var form = new Edit_Address(_controller);
            form.LoadAddress(address);

            if (form.ShowDialog() == DialogResult.OK)
                await LoadAddressesAsync();
        }

        private async void btnDelete_Click(object sender, EventArgs e)
        {
            if (addressTable.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select an address to delete.");
                return;
            }

            var val = addressTable.SelectedRows[0].Cells[0].Value?.ToString();
            if (!int.TryParse(val, out int id)) return;

            var confirm = MessageBox.Show("Are you sure you want to delete this address?", "Confirm", MessageBoxButtons.YesNo);
            if (confirm != DialogResult.Yes)
                return;

            bool deleted = await _controller.DeleteAddressAsync(id);
            if (deleted)
            {
                MessageBox.Show("Address deleted.");
                await LoadAddressesAsync();
            }
            else
            {
                MessageBox.Show("Failed to delete address.");
            }
        }

        private void Address_Manager_Load(object sender, EventArgs e)
        {

        }
    }
}
