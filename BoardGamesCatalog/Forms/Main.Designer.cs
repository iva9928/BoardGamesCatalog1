namespace BoardGamesCatalog.Forms
{
    partial class Main
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
            btnBoardGames = new Button();
            btnCategory = new Button();
            btnCreator = new Button();
            btnPublisher = new Button();
            btnAddress = new Button();
            btnPlayerRange = new Button();
            btnCB = new Button();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // btnBoardGames
            // 
            btnBoardGames.Location = new Point(31, 124);
            btnBoardGames.Name = "btnBoardGames";
            btnBoardGames.Size = new Size(267, 29);
            btnBoardGames.TabIndex = 0;
            btnBoardGames.Text = "BoardGames";
            btnBoardGames.UseVisualStyleBackColor = true;
            btnBoardGames.Click += btnBoardGames_Click;
            // 
            // btnCategory
            // 
            btnCategory.Location = new Point(31, 182);
            btnCategory.Name = "btnCategory";
            btnCategory.Size = new Size(267, 29);
            btnCategory.TabIndex = 1;
            btnCategory.Text = "Category";
            btnCategory.UseVisualStyleBackColor = true;
            btnCategory.Click += btnCategory_Click;
            // 
            // btnCreator
            // 
            btnCreator.Location = new Point(31, 243);
            btnCreator.Name = "btnCreator";
            btnCreator.Size = new Size(267, 29);
            btnCreator.TabIndex = 2;
            btnCreator.Text = "Creator";
            btnCreator.UseVisualStyleBackColor = true;
            btnCreator.Click += button3_Click;
            // 
            // btnPublisher
            // 
            btnPublisher.Location = new Point(31, 301);
            btnPublisher.Name = "btnPublisher";
            btnPublisher.Size = new Size(267, 29);
            btnPublisher.TabIndex = 3;
            btnPublisher.Text = "Publisher";
            btnPublisher.UseVisualStyleBackColor = true;
            btnPublisher.Click += button4_Click;
            // 
            // btnAddress
            // 
            btnAddress.Location = new Point(31, 365);
            btnAddress.Name = "btnAddress";
            btnAddress.Size = new Size(267, 29);
            btnAddress.TabIndex = 4;
            btnAddress.Text = "Address";
            btnAddress.UseVisualStyleBackColor = true;
            btnAddress.Click += btnAddress_Click;
            // 
            // btnPlayerRange
            // 
            btnPlayerRange.Location = new Point(31, 423);
            btnPlayerRange.Name = "btnPlayerRange";
            btnPlayerRange.Size = new Size(267, 29);
            btnPlayerRange.TabIndex = 5;
            btnPlayerRange.Text = "PlayerRange";
            btnPlayerRange.UseCompatibleTextRendering = true;
            btnPlayerRange.UseVisualStyleBackColor = true;
            btnPlayerRange.Click += btnPlayerRange_Click;
            // 
            // btnCB
            // 
            btnCB.Location = new Point(31, 487);
            btnCB.Name = "btnCB";
            btnCB.Size = new Size(267, 29);
            btnCB.TabIndex = 6;
            btnCB.Text = "CreatorBoardgame";
            btnCB.UseVisualStyleBackColor = true;
            btnCB.Click += btnCB_Click;
            // 
            // button1
            // 
            button1.Location = new Point(479, 264);
            button1.Name = "button1";
            button1.Size = new Size(216, 29);
            button1.TabIndex = 7;
            button1.Text = "BoardgamesByPublisher";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(479, 335);
            button2.Name = "button2";
            button2.Size = new Size(216, 29);
            button2.TabIndex = 8;
            button2.Text = "BoardgamesByCategories";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(479, 403);
            button3.Name = "button3";
            button3.Size = new Size(216, 29);
            button3.TabIndex = 9;
            button3.Text = "BoardgamesByAddress";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click_1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Showcard Gothic", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(72, 66);
            label1.Name = "label1";
            label1.Size = new Size(172, 26);
            label1.TabIndex = 10;
            label1.Text = "Chose a model:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Showcard Gothic", 12F, FontStyle.Italic);
            label2.Location = new Point(479, 195);
            label2.Name = "label2";
            label2.Size = new Size(211, 26);
            label2.TabIndex = 11;
            label2.Text = "Chose a reference:";
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Ivory;
            ClientSize = new Size(744, 569);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(btnCB);
            Controls.Add(btnPlayerRange);
            Controls.Add(btnAddress);
            Controls.Add(btnPublisher);
            Controls.Add(btnCreator);
            Controls.Add(btnCategory);
            Controls.Add(btnBoardGames);
            Name = "Main";
            Text = "Main";
            Load += Main_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnBoardGames;
        private Button btnCategory;
        private Button btnCreator;
        private Button btnPublisher;
        private Button btnAddress;
        private Button btnPlayerRange;
        private Button btnCB;
        private Button button1;
        private Button button2;
        private Button button3;
        private Label label1;
        private Label label2;
    }
}