namespace BoardGamesCatalog
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            btnAdd = new Button();
            btnEdit = new Button();
            btnDelete = new Button();
            boardgamesTable = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)boardgamesTable).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Bottom;
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(113, 19);
            label1.Name = "label1";
            label1.Size = new Size(672, 19);
            label1.TabIndex = 0;
            label1.Text = "List of BoardGames";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            label1.Click += label1_Click;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(10, 64);
            btnAdd.Margin = new Padding(3, 2, 3, 2);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(82, 22);
            btnAdd.TabIndex = 1;
            btnAdd.Text = "Add Game";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(744, 64);
            btnEdit.Margin = new Padding(3, 2, 3, 2);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(82, 22);
            btnEdit.TabIndex = 2;
            btnEdit.Text = "Edit Game";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(831, 64);
            btnDelete.Margin = new Padding(3, 2, 3, 2);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(82, 22);
            btnDelete.TabIndex = 3;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // boardgamesTable
            // 
            boardgamesTable.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            boardgamesTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            boardgamesTable.Location = new Point(10, 101);
            boardgamesTable.Margin = new Padding(3, 2, 3, 2);
            boardgamesTable.MultiSelect = false;
            boardgamesTable.Name = "boardgamesTable";
            boardgamesTable.RowHeadersVisible = false;
            boardgamesTable.RowHeadersWidth = 51;
            boardgamesTable.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            boardgamesTable.Size = new Size(903, 326);
            boardgamesTable.TabIndex = 4;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.Center;
            ClientSize = new Size(924, 442);
            Controls.Add(boardgamesTable);
            Controls.Add(btnDelete);
            Controls.Add(btnEdit);
            Controls.Add(btnAdd);
            Controls.Add(label1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form1";
            Text = "BoardGames Manager";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)boardgamesTable).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Button btnAdd;
        private Button btnEdit;
        private Button btnDelete;
        private DataGridView boardgamesTable;
    }
}
