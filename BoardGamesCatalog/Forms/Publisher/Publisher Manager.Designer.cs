namespace BoardGamesCatalog.Forms.Publisher
{
    partial class Publisher_Manager
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
            publishersTable = new DataGridView();
            btnDelete = new Button();
            btnEdit = new Button();
            btnAdd = new Button();
            ((System.ComponentModel.ISupportInitialize)publishersTable).BeginInit();
            SuspendLayout();
            // 
            // publishersTable
            // 
            publishersTable.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            publishersTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            publishersTable.Location = new Point(12, 122);
            publishersTable.MultiSelect = false;
            publishersTable.Name = "publishersTable";
            publishersTable.RowHeadersVisible = false;
            publishersTable.RowHeadersWidth = 51;
            publishersTable.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            publishersTable.Size = new Size(1032, 435);
            publishersTable.TabIndex = 5;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(948, 77);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 29);
            btnDelete.TabIndex = 8;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click_1;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(806, 77);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(94, 29);
            btnEdit.TabIndex = 7;
            btnEdit.Text = "Edit ";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click_1;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(12, 77);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(94, 29);
            btnAdd.TabIndex = 6;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click_1;
            // 
            // Publisher_Manager
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1054, 578);
            Controls.Add(btnDelete);
            Controls.Add(btnEdit);
            Controls.Add(btnAdd);
            Controls.Add(publishersTable);
            Name = "Publisher_Manager";
            Text = "Publisher_Manager";
            Load += Publisher_Manager_Load;
            ((System.ComponentModel.ISupportInitialize)publishersTable).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView publishersTable;
        private Button btnDelete;
        private Button btnEdit;
        private Button btnAdd;
    }
}