namespace BoardGamesCatalog.Forms.CreatorBoardgame
{
    partial class CreatorBoardgame_Manager
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnAdd = new Button();
            creatorBoardgameTable = new DataGridView();
            btnManu = new Button();
            ((System.ComponentModel.ISupportInitialize)creatorBoardgameTable).BeginInit();
            SuspendLayout();
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(509, 60);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(94, 29);
            btnAdd.TabIndex = 15;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // creatorBoardgameTable
            // 
            creatorBoardgameTable.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            creatorBoardgameTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            creatorBoardgameTable.Location = new Point(31, 108);
            creatorBoardgameTable.MultiSelect = false;
            creatorBoardgameTable.Name = "creatorBoardgameTable";
            creatorBoardgameTable.RowHeadersVisible = false;
            creatorBoardgameTable.RowHeadersWidth = 51;
            creatorBoardgameTable.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            creatorBoardgameTable.Size = new Size(1032, 435);
            creatorBoardgameTable.TabIndex = 14;
            creatorBoardgameTable.CellContentClick += creatorBoardgameTable_CellContentClick;
            // 
            // btnManu
            // 
            btnManu.Location = new Point(969, 560);
            btnManu.Name = "btnManu";
            btnManu.Size = new Size(94, 29);
            btnManu.TabIndex = 16;
            btnManu.Text = "Menu";
            btnManu.UseVisualStyleBackColor = true;
            btnManu.Click += btnManu_Click;
            // 
            // CreatorBoardgame_Manager
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 192, 255);
            ClientSize = new Size(1105, 611);
            Controls.Add(btnManu);
            Controls.Add(btnAdd);
            Controls.Add(creatorBoardgameTable);
            Name = "CreatorBoardgame_Manager";
            Text = "CreatorBoardgame_Manager";
            Load += CreatorBoardgame_Manager_Load;
            ((System.ComponentModel.ISupportInitialize)creatorBoardgameTable).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Button btnAdd;
        private DataGridView creatorBoardgameTable;
        private Button btnManu;
    }
}