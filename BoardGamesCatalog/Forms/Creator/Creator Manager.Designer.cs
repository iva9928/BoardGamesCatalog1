namespace BoardGamesCatalog.Forms.Creator
{
    partial class Creator_Manager
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
            creatorTable = new DataGridView();
            btnAdd = new Button();
            btnEdit = new Button();
            btnDelete = new Button();
            ((System.ComponentModel.ISupportInitialize)creatorTable).BeginInit();
            SuspendLayout();
            // 
            // creatorTable
            // 
            creatorTable.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            creatorTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            creatorTable.Location = new Point(31, 109);
            creatorTable.MultiSelect = false;
            creatorTable.Name = "creatorTable";
            creatorTable.RowHeadersVisible = false;
            creatorTable.RowHeadersWidth = 51;
            creatorTable.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            creatorTable.Size = new Size(1032, 435);
            creatorTable.TabIndex = 6;
            creatorTable.CellContentClick += creatorTable_CellContentClick;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(43, 57);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(94, 29);
            btnAdd.TabIndex = 7;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(763, 74);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(94, 29);
            btnEdit.TabIndex = 8;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(892, 74);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 29);
            btnDelete.TabIndex = 9;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // Creator_Manager
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1099, 556);
            Controls.Add(btnDelete);
            Controls.Add(btnEdit);
            Controls.Add(btnAdd);
            Controls.Add(creatorTable);
            Name = "Creator_Manager";
            Text = "Creator_Manager";
            Load += Creator_Manager_Load;
            ((System.ComponentModel.ISupportInitialize)creatorTable).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView creatorTable;
        private Button btnAdd;
        private Button btnEdit;
        private Button btnDelete;
    }
}