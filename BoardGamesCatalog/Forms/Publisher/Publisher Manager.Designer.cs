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
            label1 = new Label();
            btnManu = new Button();
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
            // label1
            // 
            label1.Anchor = AnchorStyles.Bottom;
            label1.Font = new Font("Showcard Gothic", 12F, FontStyle.Italic);
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(61, 49);
            label1.Name = "label1";
            label1.Size = new Size(768, 25);
            label1.TabIndex = 16;
            label1.Text = "List of Publishers";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnManu
            // 
            btnManu.Location = new Point(948, 574);
            btnManu.Name = "btnManu";
            btnManu.Size = new Size(94, 29);
            btnManu.TabIndex = 17;
            btnManu.Text = "Menu";
            btnManu.UseVisualStyleBackColor = true;
            btnManu.Click += btnManu_Click;
            // 
            // Publisher_Manager
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Tan;
            ClientSize = new Size(1054, 625);
            Controls.Add(btnManu);
            Controls.Add(label1);
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
        private Label label1;
        private Button btnManu;
    }
}