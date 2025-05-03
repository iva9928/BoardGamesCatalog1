namespace BoardGamesCatalog.Forms.Category
{
    partial class Category_Manager
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
            categoryTable = new DataGridView();
            btnEdit = new Button();
            btnDelete = new Button();
            btnAdd = new Button();
            label1 = new Label();
            btnManu = new Button();
            ((System.ComponentModel.ISupportInitialize)categoryTable).BeginInit();
            SuspendLayout();
            // 
            // categoryTable
            // 
            categoryTable.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            categoryTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            categoryTable.Location = new Point(41, 95);
            categoryTable.MultiSelect = false;
            categoryTable.Name = "categoryTable";
            categoryTable.RowHeadersVisible = false;
            categoryTable.RowHeadersWidth = 51;
            categoryTable.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            categoryTable.Size = new Size(1032, 435);
            categoryTable.TabIndex = 5;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(846, 60);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(94, 29);
            btnEdit.TabIndex = 6;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(970, 60);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 29);
            btnDelete.TabIndex = 7;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(41, 60);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(94, 29);
            btnAdd.TabIndex = 8;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Bottom;
            label1.Font = new Font("Showcard Gothic", 12F, FontStyle.Italic);
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(124, 22);
            label1.Name = "label1";
            label1.Size = new Size(768, 25);
            label1.TabIndex = 15;
            label1.Text = "List of Categories";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            label1.Click += label1_Click;
            // 
            // btnManu
            // 
            btnManu.Location = new Point(979, 551);
            btnManu.Name = "btnManu";
            btnManu.Size = new Size(94, 29);
            btnManu.TabIndex = 16;
            btnManu.Text = "Menu";
            btnManu.UseVisualStyleBackColor = true;
            btnManu.Click += btnManu_Click;
            // 
            // Category_Manager
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 224, 192);
            ClientSize = new Size(1119, 592);
            Controls.Add(btnManu);
            Controls.Add(label1);
            Controls.Add(btnAdd);
            Controls.Add(btnDelete);
            Controls.Add(btnEdit);
            Controls.Add(categoryTable);
            Name = "Category_Manager";
            Text = "Category_Manager";
            Load += Category_Manager_Load;
            ((System.ComponentModel.ISupportInitialize)categoryTable).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView categoryTable;
        private Button btnEdit;
        private Button btnDelete;
        private Button btnAdd;
        private Label label1;
        private Button btnManu;
    }
}