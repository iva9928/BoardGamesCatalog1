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
            lblBG.Location = new Point(65, 97);
            lblBG.Name = "lblBG";
            lblBG.Size = new Size(106, 20);
            lblBG.TabIndex = 1;
            lblBG.Text = "Boardgame ID";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(65, 141);
            lblName.Name = "lblName";
            lblName.Size = new Size(49, 20);
            lblName.TabIndex = 3;
            lblName.Text = "Name";
            // 
            // lblYear
            // 
            lblYear.AutoSize = true;
            lblYear.Location = new Point(65, 187);
            lblYear.Name = "lblYear";
            lblYear.Size = new Size(105, 20);
            lblYear.TabIndex = 4;
            lblYear.Text = "Year Published";
            // 
            // lblRating
            // 
            lblRating.AutoSize = true;
            lblRating.Location = new Point(65, 233);
            lblRating.Name = "lblRating";
            lblRating.Size = new Size(52, 20);
            lblRating.TabIndex = 13;
            lblRating.Text = "Rating";
            // 
            // lblCategoryId
            // 
            lblCategoryId.AutoSize = true;
            lblCategoryId.Location = new Point(65, 283);
            lblCategoryId.Name = "lblCategoryId";
            lblCategoryId.Size = new Size(88, 20);
            lblCategoryId.TabIndex = 14;
            lblCategoryId.Text = "Category ID";
            // 
            // lblPublisherId
            // 
            lblPublisherId.AutoSize = true;
            lblPublisherId.Location = new Point(65, 333);
            lblPublisherId.Name = "lblPublisherId";
            lblPublisherId.Size = new Size(88, 20);
            lblPublisherId.TabIndex = 15;
            lblPublisherId.Text = "Publisher ID";
            lblPublisherId.Click += lblPublisherId_Click;
            // 
            // lblPlayerRId
            // 
            lblPlayerRId.AutoSize = true;
            lblPlayerRId.Location = new Point(65, 381);
            lblPlayerRId.Name = "lblPlayerRId";
            lblPlayerRId.Size = new Size(120, 20);
            lblPlayerRId.TabIndex = 16;
            lblPlayerRId.Text = "Players Range ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(330, 97);
            label2.Name = "label2";
            label2.Size = new Size(50, 20);
            label2.TabIndex = 17;
            label2.Text = "label2";
            label2.Click += label2_Click;
            // 
            // txtBName
            // 
            txtBName.Location = new Point(330, 139);
            txtBName.Name = "txtBName";
            txtBName.Size = new Size(348, 27);
            txtBName.TabIndex = 18;
            // 
            // txtBYear
            // 
            txtBYear.Location = new Point(330, 183);
            txtBYear.Name = "txtBYear";
            txtBYear.Size = new Size(348, 27);
            txtBYear.TabIndex = 19;
            // 
            // txtBRating
            // 
            txtBRating.Location = new Point(330, 229);
            txtBRating.Name = "txtBRating";
            txtBRating.Size = new Size(348, 27);
            txtBRating.TabIndex = 20;
            txtBRating.TextChanged += textBox3_TextChanged;
            // 
            // txtBCategId
            // 
            txtBCategId.Location = new Point(330, 276);
            txtBCategId.Name = "txtBCategId";
            txtBCategId.Size = new Size(348, 27);
            txtBCategId.TabIndex = 21;
            // 
            // txtBPublishId
            // 
            txtBPublishId.Location = new Point(330, 327);
            txtBPublishId.Name = "txtBPublishId";
            txtBPublishId.Size = new Size(348, 27);
            txtBPublishId.TabIndex = 22;
            // 
            // txtBPRId
            // 
            txtBPRId.Location = new Point(330, 375);
            txtBPRId.Name = "txtBPRId";
            txtBPRId.Size = new Size(348, 27);
            txtBPRId.TabIndex = 23;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(424, 421);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(94, 29);
            btnSave.TabIndex = 24;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click_1;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(584, 421);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(94, 29);
            btnCancel.TabIndex = 25;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // Edit_BoardGame
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.InactiveCaption;
            ClientSize = new Size(800, 463);
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