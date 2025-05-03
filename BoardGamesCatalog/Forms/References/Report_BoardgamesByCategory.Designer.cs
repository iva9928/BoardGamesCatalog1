namespace BoardGamesCatalog.Forms.References
{
    partial class Report_BoardgamesByCategory
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
            dgvBoardgames = new DataGridView();
            btnCancel = new Button();
            btnLoad = new Button();
            cmbCategories = new ComboBox();
            lblC = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvBoardgames).BeginInit();
            SuspendLayout();
            // 
            // dgvBoardgames
            // 
            dgvBoardgames.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBoardgames.Location = new Point(500, 132);
            dgvBoardgames.Name = "dgvBoardgames";
            dgvBoardgames.RowHeadersWidth = 51;
            dgvBoardgames.Size = new Size(300, 188);
            dgvBoardgames.TabIndex = 95;
            dgvBoardgames.CellContentClick += dgvBoardgames_CellContentClick;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(250, 310);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(94, 29);
            btnCancel.TabIndex = 94;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnLoad
            // 
            btnLoad.Location = new Point(106, 310);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new Size(94, 29);
            btnLoad.TabIndex = 93;
            btnLoad.Text = "Load";
            btnLoad.UseVisualStyleBackColor = true;
            btnLoad.Click += btnLoad_Click;
            // 
            // cmbCategories
            // 
            cmbCategories.FormattingEnabled = true;
            cmbCategories.Location = new Point(173, 110);
            cmbCategories.Name = "cmbCategories";
            cmbCategories.Size = new Size(151, 28);
            cmbCategories.TabIndex = 92;
            // 
            // lblC
            // 
            lblC.AutoSize = true;
            lblC.Location = new Point(27, 113);
            lblC.Name = "lblC";
            lblC.Size = new Size(113, 20);
            lblC.TabIndex = 91;
            lblC.Text = "Select Category";
            // 
            // Report_BoardgamesByCategory
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LavenderBlush;
            ClientSize = new Size(865, 496);
            Controls.Add(dgvBoardgames);
            Controls.Add(btnCancel);
            Controls.Add(btnLoad);
            Controls.Add(cmbCategories);
            Controls.Add(lblC);
            Name = "Report_BoardgamesByCategory";
            Text = "Report_BoardgamesByCategory";
            Load += Report_BoardgamesByCategory_Load;
            ((System.ComponentModel.ISupportInitialize)dgvBoardgames).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvBoardgames;
        private Button btnCancel;
        private Button btnLoad;
        private ComboBox cmbCategories;
        private Label lblC;
    }
}