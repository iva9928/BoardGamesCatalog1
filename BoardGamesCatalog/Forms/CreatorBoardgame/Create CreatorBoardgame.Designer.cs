namespace BoardGamesCatalog.Forms.CreatorBoardgame
{
    partial class Create_CreatorBoardgame
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
            btnSave = new Button();
            txtCId = new TextBox();
            txtBGId = new TextBox();
            lb = new Label();
            lblPRId = new Label();
            SuspendLayout();
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(605, 271);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(94, 29);
            btnCancel.TabIndex = 87;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(442, 271);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(94, 29);
            btnSave.TabIndex = 86;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // txtCId
            // 
            txtCId.Location = new Point(351, 151);
            txtCId.Name = "txtCId";
            txtCId.Size = new Size(348, 27);
            txtCId.TabIndex = 85;
            // 
            // txtBGId
            // 
            txtBGId.Location = new Point(351, 195);
            txtBGId.Name = "txtBGId";
            txtBGId.Size = new Size(348, 27);
            txtBGId.TabIndex = 84;
            // 
            // lb
            // 
            lb.AutoSize = true;
            lb.Location = new Point(102, 202);
            lb.Name = "lb";
            lb.Size = new Size(106, 20);
            lb.TabIndex = 83;
            lb.Text = "Boardgame ID";
            // 
            // lblPRId
            // 
            lblPRId.AutoSize = true;
            lblPRId.Location = new Point(102, 151);
            lblPRId.Name = "lblPRId";
            lblPRId.Size = new Size(77, 20);
            lblPRId.TabIndex = 82;
            lblPRId.Text = "Creator ID";
            // 
            // Create_CreatorBoardgame
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(771, 372);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(txtCId);
            Controls.Add(txtBGId);
            Controls.Add(lb);
            Controls.Add(lblPRId);
            Name = "Create_CreatorBoardgame";
            Text = "Create_CreatorBoardgame";
            Load += Create_CreatorBoardgame_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCancel;
        private Button btnSave;
        private TextBox txtCId;
        private TextBox txtBGId;
        private Label lb;
        private Label lblPRId;
    }
}