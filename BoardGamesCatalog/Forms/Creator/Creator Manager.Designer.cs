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
            label1 = new Label();
            bntMenu = new Button();
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
            btnAdd.Location = new Point(31, 74);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(94, 29);
            btnAdd.TabIndex = 7;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(853, 74);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(94, 29);
            btnEdit.TabIndex = 8;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(969, 74);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 29);
            btnDelete.TabIndex = 9;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Bottom;
            label1.Font = new Font("Showcard Gothic", 12F, FontStyle.Italic);
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(117, 29);
            label1.Name = "label1";
            label1.Size = new Size(768, 25);
            label1.TabIndex = 16;
            label1.Text = "List of Creators";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            label1.Click += label1_Click;
            // 
            // bntMenu
            // 
            bntMenu.Location = new Point(969, 560);
            bntMenu.Name = "bntMenu";
            bntMenu.Size = new Size(94, 29);
            bntMenu.TabIndex = 17;
            bntMenu.Text = "Menu";
            bntMenu.UseVisualStyleBackColor = true;
            bntMenu.Click += bntMenu_Click;
            // 
            // Creator_Manager
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 255, 192);
            ClientSize = new Size(1099, 601);
            Controls.Add(bntMenu);
            Controls.Add(label1);
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
        private Label label1;
        private Button bntMenu;
    }
}