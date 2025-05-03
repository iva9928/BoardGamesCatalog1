namespace BoardGamesCatalog.Forms.References
{
    partial class Report_BoardgamesByPublisher
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
            btnCancel = new Button();
            btnLoad = new Button();
            cmbPublishers = new ComboBox();
            lblC = new Label();
            dgvBoardgames = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvBoardgames).BeginInit();
            SuspendLayout();
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(286, 303);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(94, 29);
            btnCancel.TabIndex = 89;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnLoad
            // 
            btnLoad.Location = new Point(142, 303);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new Size(94, 29);
            btnLoad.TabIndex = 88;
            btnLoad.Text = "Load";
            btnLoad.UseVisualStyleBackColor = true;
            btnLoad.Click += btnLoad_Click;
            // 
            // cmbPublishers
            // 
            cmbPublishers.FormattingEnabled = true;
            cmbPublishers.Location = new Point(209, 103);
            cmbPublishers.Name = "cmbPublishers";
            cmbPublishers.Size = new Size(151, 28);
            cmbPublishers.TabIndex = 86;
            // 
            // lblC
            // 
            lblC.AutoSize = true;
            lblC.Location = new Point(63, 106);
            lblC.Name = "lblC";
            lblC.Size = new Size(113, 20);
            lblC.TabIndex = 84;
            lblC.Text = "Select Publisher";
            // 
            // dgvBoardgames
            // 
            dgvBoardgames.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBoardgames.Location = new Point(573, 191);
            dgvBoardgames.Name = "dgvBoardgames";
            dgvBoardgames.RowHeadersWidth = 51;
            dgvBoardgames.Size = new Size(300, 188);
            dgvBoardgames.TabIndex = 90;
            dgvBoardgames.CellContentClick += dgvBoardgames_CellContentClick;
            // 
            // Report_BoardgamesByPublisher
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 192, 255);
            ClientSize = new Size(973, 531);
            Controls.Add(dgvBoardgames);
            Controls.Add(btnCancel);
            Controls.Add(btnLoad);
            Controls.Add(cmbPublishers);
            Controls.Add(lblC);
            Name = "Report_BoardgamesByPublisher";
            Text = "Report_BoardgamesByPublisher";
            Load += Report_BoardgamesByPublisher_Load;
            ((System.ComponentModel.ISupportInitialize)dgvBoardgames).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCancel;
        private Button btnLoad;
        private ComboBox cmbPublishers;
        private Label lblC;
        private DataGridView dgvBoardgames;
    }
}