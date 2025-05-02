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

namespace BoardGamesCatalog.Forms.Address
{
    public partial class Create_Address : Form
    {
        private readonly AddressController _controller;

        public Create_Address()
        {
            InitializeComponent();
            this.DialogResult = DialogResult.Cancel;

            var options = new DbContextOptionsBuilder<BoardGamesContext>()
                .UseSqlServer(Configurations.ConnectionString)
                .Options;

            var context = new BoardGamesContext(options);
            _controller = new AddressController(context);
        }

        private void Create_Address_Load(object sender, EventArgs e)
        {

        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                var model = new AddressViewModel
                {
                    StreetName = txtBName.Text,
                    StreetNumber = int.Parse(txtBNumber.Text),
                    Town = txtBT.Text,
                    Country = txtBC.Text,
                    ZIP = int.Parse(txtBZ.Text)
                };

                bool result = await _controller.CreateAddressAsync(model);

                if (result)
                {
                    MessageBox.Show("Address added successfully!", "Success");
                    this.DialogResult = DialogResult.OK;
                }
                else
                {
                    MessageBox.Show("Failed to add address.", "Error");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Exception");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
