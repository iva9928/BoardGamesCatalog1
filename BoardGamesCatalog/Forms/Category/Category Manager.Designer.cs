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
            // Category_Manager
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1119, 542);
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
    }
}