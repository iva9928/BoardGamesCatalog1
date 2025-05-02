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
using System.Xml.Linq;

namespace BoardGamesCatalog.Forms.Publisher
{
    public partial class Create_Publisher : Form
    {

        private readonly PublisherController _controller;
        public Create_Publisher()
        {
            InitializeComponent();
            this.DialogResult = DialogResult.Cancel;

            var options = new DbContextOptionsBuilder<BoardGamesContext>()
                .UseSqlServer(Configurations.ConnectionString)
                .Options;
            var context = new BoardGamesContext(options);
            _controller = new PublisherController(context);
        }


        private async void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                var model = new PublisherViewModel
                {
                    Name = txtBName.Text,
                    AddressId = int.Parse(txtA.Text),
                    Website = txtW.Text,
                    Phone = txtP.Text
                };

                bool created = await _controller.CreatePublisherAsync(model);

                if (created)
                {
                    MessageBox.Show("Publisher created successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.DialogResult = DialogResult.OK;
                }
                else
                {
                    MessageBox.Show("Failed to create Publisher.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error while creating Publisher: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void Create_Publisher_Load(object sender, EventArgs e)
        {

        }
    }
}
