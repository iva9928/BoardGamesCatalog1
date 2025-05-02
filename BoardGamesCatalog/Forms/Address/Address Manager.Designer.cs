namespace BoardGamesCatalog.Forms.Address
{
    partial class Address_Manager
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
            btnDelete = new Button();
            btnEdit = new Button();
            addressTable = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)addressTable).BeginInit();
            SuspendLayout();
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(67, 75);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(94, 29);
            btnAdd.TabIndex = 12;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(996, 75);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 29);
            btnDelete.TabIndex = 11;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(872, 75);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(94, 29);
            btnEdit.TabIndex = 10;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // addressTable
            // 
            addressTable.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            addressTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            addressTable.Location = new Point(67, 110);
            addressTable.MultiSelect = false;
            addressTable.Name = "addressTable";
            addressTable.RowHeadersVisible = false;
            addressTable.RowHeadersWidth = 51;
            addressTable.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            addressTable.Size = new Size(1032, 435);
            addressTable.TabIndex = 9;
            // 
            // Address_Manager
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1139, 565);
            Controls.Add(btnAdd);
            Controls.Add(btnDelete);
            Controls.Add(btnEdit);
            Controls.Add(addressTable);
            Name = "Address_Manager";
            Text = "Address_Manager";
            Load += Address_Manager_Load;
            ((System.ComponentModel.ISupportInitialize)addressTable).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnAdd;
        private Button btnDelete;
        private Button btnEdit;
        private DataGridView addressTable;
    }
}