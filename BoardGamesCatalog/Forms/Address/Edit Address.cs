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

namespace BoardGamesCatalog.Forms.Address
{
    public partial class Edit_Address : Form
    {
        private readonly AddressController _controller;
        private int _addressId = -1;

        public Edit_Address(AddressController controller)
        {
            InitializeComponent();
            _controller = controller;
            this.DialogResult = DialogResult.Cancel;
        }

        public void LoadAddress(AddressViewModel address)
        {
            _addressId = address.Id;
            txtBName.Text = address.StreetName;
            txtBNumber.Text = address.StreetNumber.ToString();
            txtBT.Text = address.Town;
            txtBC.Text = address.Country;
            txtBZ.Text = address.ZIP.ToString();
        }



        private async void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                var model = new AddressViewModel
                {
                    Id = _addressId,
                    StreetName = txtBName.Text,
                    StreetNumber = int.Parse(txtBNumber.Text),
                    Town = txtBT.Text,
                    Country = txtBC.Text,
                    ZIP = int.Parse(txtBZ.Text)
                };

                bool updated = await _controller.UpdateAddressAsync(model);

                if (updated)
                {
                    MessageBox.Show("Address updated successfully!", "Success");
                    this.DialogResult = DialogResult.OK;
                }
                else
                {
                    MessageBox.Show("Failed to update address.", "Error");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Exception");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {

        }

        private void Edit_Address_Load(object sender, EventArgs e)
        {

        }
    }
}
