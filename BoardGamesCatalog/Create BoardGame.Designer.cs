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
            lblId = new Label();
            lblName = new Label();
            lblYear = new Label();
            txtBName = new TextBox();
            txtBYear = new TextBox();
            txtBRating = new TextBox();
            txtBCategId = new TextBox();
            txtBPublishId = new TextBox();
            txtBPRId = new TextBox();
            lblRating = new Label();
            lblCategoryId = new Label();
            lblPublisherId = new Label();
            lblPlayerRId = new Label();
            btnSave = new Button();
            btnCancel = new Button();
            SuspendLayout();
            // 
            // lblBG
            // 
            lblBG.AutoSize = true;
            lblBG.Location = new Point(72, 76);
            lblBG.Name = "lblBG";
            lblBG.Size = new Size(106, 20);
            lblBG.TabIndex = 0;
            lblBG.Text = "Boardgame ID";
            lblBG.Click += this.label1_Click;
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Location = new Point(292, 93);
            lblId.Name = "lblId";
            lblId.Size = new Size(0, 20);
            lblId.TabIndex = 1;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(72, 116);
            lblName.Name = "lblName";
            lblName.Size = new Size(49, 20);
            lblName.TabIndex = 2;
            lblName.Text = "Name";
            // 
            // lblYear
            // 
            lblYear.AutoSize = true;
            lblYear.Location = new Point(72, 157);
            lblYear.Name = "lblYear";
            lblYear.Size = new Size(105, 20);
            lblYear.TabIndex = 3;
            lblYear.Text = "Year Published";
            lblYear.Click += this.lblYear_Click;
            // 
            // txtBName
            // 
            txtBName.Location = new Point(325, 116);
            txtBName.Name = "txtBName";
            txtBName.Size = new Size(375, 27);
            txtBName.TabIndex = 4;
            // 
            // txtBYear
            // 
            txtBYear.Location = new Point(325, 157);
            txtBYear.Name = "txtBYear";
            txtBYear.Size = new Size(375, 27);
            txtBYear.TabIndex = 5;
            // 
            // txtBRating
            // 
            txtBRating.Location = new Point(325, 198);
            txtBRating.Name = "txtBRating";
            txtBRating.Size = new Size(375, 27);
            txtBRating.TabIndex = 6;
            // 
            // txtBCategId
            // 
            txtBCategId.Location = new Point(325, 240);
            txtBCategId.Name = "txtBCategId";
            txtBCategId.Size = new Size(375, 27);
            txtBCategId.TabIndex = 7;
            txtBCategId.TextChanged += this.textBox2_TextChanged;
            // 
            // txtBPublishId
            // 
            txtBPublishId.Location = new Point(325, 284);
            txtBPublishId.Name = "txtBPublishId";
            txtBPublishId.Size = new Size(375, 27);
            txtBPublishId.TabIndex = 8;
            txtBPublishId.TextChanged += this.textBox3_TextChanged;
            // 
            // txtBPRId
            // 
            txtBPRId.Location = new Point(325, 327);
            txtBPRId.Name = "txtBPRId";
            txtBPRId.Size = new Size(375, 27);
            txtBPRId.TabIndex = 9;
            // 
            // lblRating
            // 
            lblRating.AutoSize = true;
            lblRating.Location = new Point(72, 198);
            lblRating.Name = "lblRating";
            lblRating.Size = new Size(52, 20);
            lblRating.TabIndex = 12;
            lblRating.Text = "Rating";
            // 
            // lblCategoryId
            // 
            lblCategoryId.AutoSize = true;
            lblCategoryId.Location = new Point(72, 240);
            lblCategoryId.Name = "lblCategoryId";
            lblCategoryId.Size = new Size(88, 20);
            lblCategoryId.TabIndex = 13;
            lblCategoryId.Text = "Category ID";
            lblCategoryId.Click += this.lblCategoryId_Click;
            // 
            // lblPublisherId
            // 
            lblPublisherId.AutoSize = true;
            lblPublisherId.Location = new Point(72, 284);
            lblPublisherId.Name = "lblPublisherId";
            lblPublisherId.Size = new Size(88, 20);
            lblPublisherId.TabIndex = 14;
            lblPublisherId.Text = "Publisher ID";
            lblPublisherId.Click += label4_Click;
            // 
            // lblPlayerRId
            // 
            lblPlayerRId.AutoSize = true;
            lblPlayerRId.Location = new Point(72, 334);
            lblPlayerRId.Name = "lblPlayerRId";
            lblPlayerRId.Size = new Size(120, 20);
            lblPlayerRId.TabIndex = 15;
            lblPlayerRId.Text = "Players Range ID";
            lblPlayerRId.Click += this.label5_Click;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(473, 384);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(94, 29);
            btnSave.TabIndex = 16;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(606, 384);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(94, 29);
            btnCancel.TabIndex = 17;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // Create_BoardGame
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.Center;
            ClientSize = new Size(800, 526);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(lblPlayerRId);
            Controls.Add(lblPublisherId);
            Controls.Add(lblCategoryId);
            Controls.Add(lblRating);
            Controls.Add(txtBPRId);
            Controls.Add(txtBPublishId);
            Controls.Add(txtBCategId);
            Controls.Add(txtBRating);
            Controls.Add(txtBYear);
            Controls.Add(txtBName);
            Controls.Add(lblYear);
            Controls.Add(lblName);
            Controls.Add(lblId);
            Controls.Add(lblBG);
            Name = "Create_BoardGame";
            Text = "Create_BoardGame";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblBG;
        private Label lblId;
        private Label lblName;
        private Label lblYear;
        private TextBox txtBName;
        private TextBox txtBYear;
        private TextBox txtBRating;
        private TextBox txtBCategId;
        private TextBox txtBPublishId;
        private TextBox txtBPRId;
        private Label lblRating;
        private Label lblCategoryId;
        private Label lblPublisherId;
        private Label lblPlayerRId;
        private Button btnSave;
        private Button btnCancel;
    }
}