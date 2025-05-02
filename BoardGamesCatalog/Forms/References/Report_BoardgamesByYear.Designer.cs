namespace BoardGamesCatalog.Forms.References
{
    partial class Report_BoardgamesByYear
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
            cmbYears = new ComboBox();
            lblC = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvBoardgames).BeginInit();
            SuspendLayout();
            // 
            // dgvBoardgames
            // 
            dgvBoardgames.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBoardgames.Location = new Point(502, 142);
            dgvBoardgames.Name = "dgvBoardgames";
            dgvBoardgames.RowHeadersWidth = 51;
            dgvBoardgames.Size = new Size(300, 188);
            dgvBoardgames.TabIndex = 100;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(252, 320);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(94, 29);
            btnCancel.TabIndex = 99;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnLoad
            // 
            btnLoad.Location = new Point(108, 320);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new Size(94, 29);
            btnLoad.TabIndex = 98;
            btnLoad.Text = "Load";
            btnLoad.UseVisualStyleBackColor = true;
            btnLoad.Click += btnLoad_Click;
            // 
            // cmbYears
            // 
            cmbYears.FormattingEnabled = true;
            cmbYears.Location = new Point(195, 120);
            cmbYears.Name = "cmbYears";
            cmbYears.Size = new Size(151, 28);
            cmbYears.TabIndex = 97;
            // 
            // lblC
            // 
            lblC.AutoSize = true;
            lblC.Location = new Point(29, 123);
            lblC.Name = "lblC";
            lblC.Size = new Size(145, 20);
            lblC.TabIndex = 96;
            lblC.Text = "Select YearPublished";
            // 
            // Report_BoardgamesByYear
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(831, 468);
            Controls.Add(dgvBoardgames);
            Controls.Add(btnCancel);
            Controls.Add(btnLoad);
            Controls.Add(cmbYears);
            Controls.Add(lblC);
            Name = "Report_BoardgamesByYear";
            Text = "Report_BoardgamesByYear";
            Load += Report_BoardgamesByYear_Load;
            ((System.ComponentModel.ISupportInitialize)dgvBoardgames).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvBoardgames;
        private Button btnCancel;
        private Button btnLoad;
        private ComboBox cmbYears;
        private Label lblC;
    }
}