namespace BoardGamesCatalog.Forms.CreatorBoardgame
{
    partial class Assign_CreatorBoardgames
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
            lblC = new Label();
            lblB = new Label();
            cmbCreators = new ComboBox();
            clbBoardgames = new CheckedListBox();
            btnCancel = new Button();
            btnSave = new Button();
            SuspendLayout();
            // 
            // lblC
            // 
            lblC.AutoSize = true;
            lblC.Location = new Point(147, 58);
            lblC.Name = "lblC";
            lblC.Size = new Size(102, 20);
            lblC.TabIndex = 0;
            lblC.Text = "Select Creator";
            // 
            // lblB
            // 
            lblB.AutoSize = true;
            lblB.Location = new Point(147, 218);
            lblB.Name = "lblB";
            lblB.Size = new Size(137, 20);
            lblB.TabIndex = 1;
            lblB.Text = "Select Boardgames";
            // 
            // cmbCreators
            // 
            cmbCreators.FormattingEnabled = true;
            cmbCreators.Location = new Point(437, 58);
            cmbCreators.Name = "cmbCreators";
            cmbCreators.Size = new Size(151, 28);
            cmbCreators.TabIndex = 2;
            // 
            // clbBoardgames
            // 
            clbBoardgames.FormattingEnabled = true;
            clbBoardgames.Location = new Point(449, 197);
            clbBoardgames.Name = "clbBoardgames";
            clbBoardgames.Size = new Size(150, 114);
            clbBoardgames.TabIndex = 3;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(494, 359);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(94, 29);
            btnCancel.TabIndex = 83;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(317, 359);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(94, 29);
            btnSave.TabIndex = 82;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // Assign_CreatorBoardgames
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 192, 255);
            ClientSize = new Size(723, 465);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(clbBoardgames);
            Controls.Add(cmbCreators);
            Controls.Add(lblB);
            Controls.Add(lblC);
            Name = "Assign_CreatorBoardgames";
            Text = "Assign_CreatorBoardgames";
            Load += Assign_CreatorBoardgames_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblC;
        private Label lblB;
        private ComboBox cmbCreators;
        private CheckedListBox clbBoardgames;
        private Button btnCancel;
        private Button btnSave;
    }
}