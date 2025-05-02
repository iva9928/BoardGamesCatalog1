using BoardGamesCatalog.Controllers;
using BoardGamesCatalog.Data;
using BoardGamesCatalog.Forms.Address;
using BoardGamesCatalog.Forms.Category;
using BoardGamesCatalog.Forms.Creator;
using BoardGamesCatalog.Forms.CreatorBoardgame;
using BoardGamesCatalog.Forms.PlayerRange;
using BoardGamesCatalog.Forms.Publisher;
using BoardGamesCatalog.Forms.References;
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

namespace BoardGamesCatalog.Forms
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {

        }

        private void btnBoardGames_Click(object sender, EventArgs e)
        {
            Form1 createForm = new Form1();
            createForm.Show();

        }

        private void btnCategory_Click(object sender, EventArgs e)
        {
            Category_Manager createForm = new Category_Manager();
            createForm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Creator_Manager createForm = new Creator_Manager();
            createForm.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Publisher_Manager createForm = new Publisher_Manager();
            createForm.Show();
        }

        private void btnAddress_Click(object sender, EventArgs e)
        {
            Address_Manager createForm = new Address_Manager();
            createForm.Show();
        }

        private void btnPlayerRange_Click(object sender, EventArgs e)
        {
            PlayerRange_Manager createForm = new PlayerRange_Manager();
            createForm.Show();
        }

        private void btnCB_Click(object sender, EventArgs e)
        {
            var options = new DbContextOptionsBuilder<BoardGamesContext>()
        .UseSqlServer(Configurations.ConnectionString)
        .Options;

            var context = new BoardGamesContext(options);
            var controller = new CreatorBoardgameController(context);

            Assign_CreatorBoardgames createForm = new Assign_CreatorBoardgames(controller);
            createForm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Report_BoardgamesByPublisher createForm = new Report_BoardgamesByPublisher();
            createForm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Report_BoardgamesByCategory createForm = new Report_BoardgamesByCategory();
            createForm.Show();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            Report_BoardgamesByYear createForm = new Report_BoardgamesByYear();
            createForm.Show();
        }
    }
}
