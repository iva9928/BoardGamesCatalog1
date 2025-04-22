namespace BoardGamesCatalog
{
    partial class Create_BoardGame
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
            lblBG = new Label();
            lblName = new Label();
            lblYear = new Label();
            lblRating = new Label();
            lblCategoryId = new Label();
            lblPlayerRId = new Label();
            lblPublisherId = new Label();
            label2 = new Label();
            txtBName = new TextBox();
            txtBYear = new TextBox();
            txtBRating = new TextBox();
            txtBCategId = new TextBox();
            txtBPublishId = new TextBox();
            txtBPRId = new TextBox();
            btnSave = new Button();
            btnCancel = new Button();
            SuspendLayout();
            // 
            // lblBG
            // 
            lblBG.AutoSize = true;
            lblBG.Location = new Point(63, 104);
            lblBG.Name = "lblBG";
            lblBG.Size = new Size(106, 20);
            lblBG.TabIndex = 2;
            lblBG.Text = "Boardgame ID";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(63, 145);
            lblName.Name = "lblName";
            lblName.Size = new Size(49, 20);
            lblName.TabIndex = 4;
            lblName.Text = "Name";
            // 
            // lblYear
            // 
            lblYear.AutoSize = true;
            lblYear.Location = new Point(63, 194);
            lblYear.Name = "lblYear";
            lblYear.Size = new Size(105, 20);
            lblYear.TabIndex = 5;
            lblYear.Text = "Year Published";
            // 
            // lblRating
            // 
            lblRating.AutoSize = true;
            lblRating.Location = new Point(64, 249);
            lblRating.Name = "lblRating";
            lblRating.Size = new Size(52, 20);
            lblRating.TabIndex = 14;
            lblRating.Text = "Rating";
            // 
            // lblCategoryId
            // 
            lblCategoryId.AutoSize = true;
            lblCategoryId.Location = new Point(63, 302);
            lblCategoryId.Name = "lblCategoryId";
            lblCategoryId.Size = new Size(88, 20);
            lblCategoryId.TabIndex = 15;
            lblCategoryId.Text = "Category ID";
            // 
            // lblPlayerRId
            // 
            lblPlayerRId.AutoSize = true;
            lblPlayerRId.Location = new Point(64, 395);
            lblPlayerRId.Name = "lblPlayerRId";
            lblPlayerRId.Size = new Size(120, 20);
            lblPlayerRId.TabIndex = 17;
            lblPlayerRId.Text = "Players Range ID";
            // 
            // lblPublisherId
            // 
            lblPublisherId.AutoSize = true;
            lblPublisherId.Location = new Point(64, 353);
            lblPublisherId.Name = "lblPublisherId";
            lblPublisherId.Size = new Size(88, 20);
            lblPublisherId.TabIndex = 18;
            lblPublisherId.Text = "Publisher ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(316, 104);
            label2.Name = "label2";
            label2.Size = new Size(0, 20);
            label2.TabIndex = 19;
            // 
            // txtBName
            // 
            txtBName.Location = new Point(316, 145);
            txtBName.Name = "txtBName";
            txtBName.Size = new Size(348, 27);
            txtBName.TabIndex = 20;
            // 
            // txtBYear
            // 
            txtBYear.Location = new Point(316, 194);
            txtBYear.Name = "txtBYear";
            txtBYear.Size = new Size(348, 27);
            txtBYear.TabIndex = 21;
            // 
            // txtBRating
            // 
            txtBRating.Location = new Point(316, 246);
            txtBRating.Name = "txtBRating";
            txtBRating.Size = new Size(348, 27);
            txtBRating.TabIndex = 22;
            // 
            // txtBCategId
            // 
            txtBCategId.Location = new Point(316, 299);
            txtBCategId.Name = "txtBCategId";
            txtBCategId.Size = new Size(348, 27);
            txtBCategId.TabIndex = 23;
            // 
            // txtBPublishId
            // 
            txtBPublishId.Location = new Point(316, 350);
            txtBPublishId.Name = "txtBPublishId";
            txtBPublishId.Size = new Size(348, 27);
            txtBPublishId.TabIndex = 24;
            // 
            // txtBPRId
            // 
            txtBPRId.Location = new Point(316, 395);
            txtBPRId.Name = "txtBPRId";
            txtBPRId.Size = new Size(348, 27);
            txtBPRId.TabIndex = 25;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(371, 447);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(94, 29);
            btnSave.TabIndex = 26;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(570, 447);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(94, 29);
            btnCancel.TabIndex = 27;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // Create_BoardGame
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 488);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(txtBPRId);
            Controls.Add(txtBPublishId);
            Controls.Add(txtBCategId);
            Controls.Add(txtBRating);
            Controls.Add(txtBYear);
            Controls.Add(txtBName);
            Controls.Add(label2);
            Controls.Add(lblPublisherId);
            Controls.Add(lblPlayerRId);
            Controls.Add(lblCategoryId);
            Controls.Add(lblRating);
            Controls.Add(lblYear);
            Controls.Add(lblName);
            Controls.Add(lblBG);
            Name = "Create_BoardGame";
            Text = "Create_BoardGame";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblBG;
        private Label lblName;
        private Label lblYear;
        private Label lblRating;
        private Label lblCategoryId;
        private Label lblPlayerRId;
        private Label lblPublisherId;
        private Label label2;
        private TextBox txtBName;
        private TextBox txtBYear;
        private TextBox txtBRating;
        private TextBox txtBCategId;
        private TextBox txtBPublishId;
        private TextBox txtBPRId;
        private Button btnSave;
        private Button btnCancel;
    }
}