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
using System.Xml.Linq;

namespace BoardGamesCatalog.Forms.Publisher
{
    public partial class Edit_Publisher : Form
    {
        private readonly PublisherController _controller;
        private int _publisherId = -1;

        public Edit_Publisher(PublisherController controller)
        {
            InitializeComponent();
            _controller = controller;
            this.DialogResult = DialogResult.Cancel;
        }

        public void LoadPublisher(PublisherViewModel publisher)
        {
            _publisherId = publisher.Id;
            txtBName.Text = publisher.Name;
            txtA.Text = publisher.AddressId.ToString();
            txtW.Text = publisher.Website;
            txtP.Text = publisher.Phone;
        }

       

       
        private void Edit_Publisher_Load(object sender, EventArgs e)
        {

        }

        private async void btnSave_Click_1(object sender, EventArgs e)
        {
            try
            {
                var model = new PublisherViewModel
                {
                    Id = _publisherId,
                    Name = txtBName.Text,
                    AddressId = int.Parse(txtA.Text),
                    Website = txtW.Text,
                    Phone = txtP.Text
                };

                bool result = await _controller.UpdatePublisherAsync(model);

                if (result)
                {
                    MessageBox.Show("Publisher updated successfully!", "Success");
                    this.DialogResult = DialogResult.OK;
                }
                else
                {
                    MessageBox.Show("Failed to update publisher.", "Error");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Exception");
            }
        }

        private void btnCancel_Click_1(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
