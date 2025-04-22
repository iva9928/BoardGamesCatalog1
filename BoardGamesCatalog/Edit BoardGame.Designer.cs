namespace BoardGamesCatalog
{
    partial class Edit_BoardGame
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
            lblPublisherId = new Label();
            lblPlayerRId = new Label();
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
            lblBG.Location = new Point(57, 73);
            lblBG.Name = "lblBG";
            lblBG.Size = new Size(82, 15);
            lblBG.TabIndex = 1;
            lblBG.Text = "Boardgame ID";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(57, 106);
            lblName.Name = "lblName";
            lblName.Size = new Size(39, 15);
            lblName.TabIndex = 3;
            lblName.Text = "Name";
            // 
            // lblYear
            // 
            lblYear.AutoSize = true;
            lblYear.Location = new Point(57, 140);
            lblYear.Name = "lblYear";
            lblYear.Size = new Size(84, 15);
            lblYear.TabIndex = 4;
            lblYear.Text = "Year Published";
            // 
            // lblRating
            // 
            lblRating.AutoSize = true;
            lblRating.Location = new Point(57, 175);
            lblRating.Name = "lblRating";
            lblRating.Size = new Size(41, 15);
            lblRating.TabIndex = 13;
            lblRating.Text = "Rating";
            // 
            // lblCategoryId
            // 
            lblCategoryId.AutoSize = true;
            lblCategoryId.Location = new Point(57, 212);
            lblCategoryId.Name = "lblCategoryId";
            lblCategoryId.Size = new Size(69, 15);
            lblCategoryId.TabIndex = 14;
            lblCategoryId.Text = "Category ID";
            // 
            // lblPublisherId
            // 
            lblPublisherId.AutoSize = true;
            lblPublisherId.Location = new Point(57, 250);
            lblPublisherId.Name = "lblPublisherId";
            lblPublisherId.Size = new Size(70, 15);
            lblPublisherId.TabIndex = 15;
            lblPublisherId.Text = "Publisher ID";
            lblPublisherId.Click += lblPublisherId_Click;
            // 
            // lblPlayerRId
            // 
            lblPlayerRId.AutoSize = true;
            lblPlayerRId.Location = new Point(57, 286);
            lblPlayerRId.Name = "lblPlayerRId";
            lblPlayerRId.Size = new Size(94, 15);
            lblPlayerRId.TabIndex = 16;
            lblPlayerRId.Text = "Players Range ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(345, 73);
            label2.Name = "label2";
            label2.Size = new Size(38, 15);
            label2.TabIndex = 17;
            label2.Text = "label2";
            // 
            // txtBName
            // 
            txtBName.Location = new Point(289, 104);
            txtBName.Margin = new Padding(3, 2, 3, 2);
            txtBName.Name = "txtBName";
            txtBName.Size = new Size(305, 23);
            txtBName.TabIndex = 18;
            // 
            // txtBYear
            // 
            txtBYear.Location = new Point(289, 137);
            txtBYear.Margin = new Padding(3, 2, 3, 2);
            txtBYear.Name = "txtBYear";
            txtBYear.Size = new Size(305, 23);
            txtBYear.TabIndex = 19;
            // 
            // txtBRating
            // 
            txtBRating.Location = new Point(289, 172);
            txtBRating.Margin = new Padding(3, 2, 3, 2);
            txtBRating.Name = "txtBRating";
            txtBRating.Size = new Size(305, 23);
            txtBRating.TabIndex = 20;
            txtBRating.TextChanged += textBox3_TextChanged;
            // 
            // txtBCategId
            // 
            txtBCategId.Location = new Point(289, 207);
            txtBCategId.Margin = new Padding(3, 2, 3, 2);
            txtBCategId.Name = "txtBCategId";
            txtBCategId.Size = new Size(305, 23);
            txtBCategId.TabIndex = 21;
            // 
            // txtBPublishId
            // 
            txtBPublishId.Location = new Point(289, 245);
            txtBPublishId.Margin = new Padding(3, 2, 3, 2);
            txtBPublishId.Name = "txtBPublishId";
            txtBPublishId.Size = new Size(305, 23);
            txtBPublishId.TabIndex = 22;
            // 
            // txtBPRId
            // 
            txtBPRId.Location = new Point(289, 281);
            txtBPRId.Margin = new Padding(3, 2, 3, 2);
            txtBPRId.Name = "txtBPRId";
            txtBPRId.Size = new Size(305, 23);
            txtBPRId.TabIndex = 23;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(371, 316);
            btnSave.Margin = new Padding(3, 2, 3, 2);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(82, 22);
            btnSave.TabIndex = 24;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(511, 316);
            btnCancel.Margin = new Padding(3, 2, 3, 2);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(82, 22);
            btnCancel.TabIndex = 25;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // Edit_BoardGame
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 347);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(txtBPRId);
            Controls.Add(txtBPublishId);
            Controls.Add(txtBCategId);
            Controls.Add(txtBRating);
            Controls.Add(txtBYear);
            Controls.Add(txtBName);
            Controls.Add(label2);
            Controls.Add(lblPlayerRId);
            Controls.Add(lblPublisherId);
            Controls.Add(lblCategoryId);
            Controls.Add(lblRating);
            Controls.Add(lblYear);
            Controls.Add(lblName);
            Controls.Add(lblBG);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Edit_BoardGame";
            Text = "Edit_BoardGame";
            Load += Edit_BoardGame_Load_1;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblBG;
        private Label lblName;
        private Label lblYear;
        private Label lblRating;
        private Label lblCategoryId;
        private Label lblPublisherId;
        private Label lblPlayerRId;
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