namespace BoardGamesCatalog.Forms.References
{
    partial class Report_BoardgamesByAddress
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
            cmbAddresses = new ComboBox();
            lblC = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvBoardgames).BeginInit();
            SuspendLayout();
            // 
            // dgvBoardgames
            // 
            dgvBoardgames.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBoardgames.Location = new Point(487, 133);
            dgvBoardgames.Name = "dgvBoardgames";
            dgvBoardgames.RowHeadersWidth = 51;
            dgvBoardgames.Size = new Size(300, 188);
            dgvBoardgames.TabIndex = 100;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(237, 311);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(94, 29);
            btnCancel.TabIndex = 99;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnLoad
            // 
            btnLoad.Location = new Point(93, 311);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new Size(94, 29);
            btnLoad.TabIndex = 98;
            btnLoad.Text = "Load";
            btnLoad.UseVisualStyleBackColor = true;
            btnLoad.Click += btnLoad_Click;
            // 
            // cmbAddresses
            // 
            cmbAddresses.FormattingEnabled = true;
            cmbAddresses.Location = new Point(160, 111);
            cmbAddresses.Name = "cmbAddresses";
            cmbAddresses.Size = new Size(151, 28);
            cmbAddresses.TabIndex = 97;
            // 
            // lblC
            // 
            lblC.AutoSize = true;
            lblC.Location = new Point(14, 114);
            lblC.Name = "lblC";
            lblC.Size = new Size(106, 20);
            lblC.TabIndex = 96;
            lblC.Text = "Select Address";
            // 
            // Report_BoardgamesByAddress
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SeaShell;
            ClientSize = new Size(800, 450);
            Controls.Add(dgvBoardgames);
            Controls.Add(btnCancel);
            Controls.Add(btnLoad);
            Controls.Add(cmbAddresses);
            Controls.Add(lblC);
            Name = "Report_BoardgamesByAddress";
            Text = "Report_BoardgamesByAddress";
            Load += Report_BoardgamesByAddress_Load;
            ((System.ComponentModel.ISupportInitialize)dgvBoardgames).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvBoardgames;
        private Button btnCancel;
        private Button btnLoad;
        private ComboBox cmbAddresses;
        private Label lblC;
    }
}