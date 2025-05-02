namespace BoardGamesCatalog.Forms.PlayerRange
{
    partial class PlayerRange_Manager
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
            btnEdit = new Button();
            btnAdd = new Button();
            playerRTable = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)playerRTable).BeginInit();
            SuspendLayout();
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(917, 72);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 29);
            btnDelete.TabIndex = 13;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(788, 72);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(94, 29);
            btnEdit.TabIndex = 12;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(68, 55);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(94, 29);
            btnAdd.TabIndex = 11;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // playerRTable
            // 
            playerRTable.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            playerRTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            playerRTable.Location = new Point(56, 107);
            playerRTable.MultiSelect = false;
            playerRTable.Name = "playerRTable";
            playerRTable.RowHeadersVisible = false;
            playerRTable.RowHeadersWidth = 51;
            playerRTable.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            playerRTable.Size = new Size(1032, 435);
            playerRTable.TabIndex = 10;
            // 
            // PlayerRange_Manager
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1145, 597);
            Controls.Add(btnDelete);
            Controls.Add(btnEdit);
            Controls.Add(btnAdd);
            Controls.Add(playerRTable);
            Name = "PlayerRange_Manager";
            Text = "PlayerRange_Manager";
            Load += PlayerRange_Manager_Load;
            ((System.ComponentModel.ISupportInitialize)playerRTable).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnDelete;
        private Button btnEdit;
        private Button btnAdd;
        private DataGridView playerRTable;
    }
}