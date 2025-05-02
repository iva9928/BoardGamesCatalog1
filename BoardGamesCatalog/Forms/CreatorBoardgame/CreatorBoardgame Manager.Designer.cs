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
            btnDelete = new Button();
            btnAdd = new Button();
            creatorBoardgameTable = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)creatorBoardgameTable).BeginInit();
            SuspendLayout();
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(897, 52);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 29);
            btnDelete.TabIndex = 17;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(48, 35);
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
            creatorBoardgameTable.Location = new Point(36, 87);
            creatorBoardgameTable.MultiSelect = false;
            creatorBoardgameTable.Name = "creatorBoardgameTable";
            creatorBoardgameTable.RowHeadersVisible = false;
            creatorBoardgameTable.RowHeadersWidth = 51;
            creatorBoardgameTable.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            creatorBoardgameTable.Size = new Size(1032, 435);
            creatorBoardgameTable.TabIndex = 14;
            creatorBoardgameTable.CellContentClick += creatorBoardgameTable_CellContentClick;
            // 
            // CreatorBoardgame_Manager
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1105, 556);
            Controls.Add(btnDelete);
            Controls.Add(btnAdd);
            Controls.Add(creatorBoardgameTable);
            Name = "CreatorBoardgame_Manager";
            Text = "CreatorBoardgame_Manager";
            Load += CreatorBoardgame_Manager_Load;
            ((System.ComponentModel.ISupportInitialize)creatorBoardgameTable).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnDelete;
        private Button btnAdd;
        private DataGridView creatorBoardgameTable;
    }
}