namespace BoardGamesCatalog.Forms.PlayerRange
{
    partial class Edit_PlayerRange
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
            label1 = new Label();
            btnCancel = new Button();
            btnSave = new Button();
            txtMax = new TextBox();
            txtMin = new TextBox();
            label2 = new Label();
            lblMin = new Label();
            lblPRId = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(102, 225);
            label1.Name = "label1";
            label1.Size = new Size(87, 20);
            label1.TabIndex = 74;
            label1.Text = "Players Max";
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(605, 289);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(94, 29);
            btnCancel.TabIndex = 73;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(447, 289);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(94, 29);
            btnSave.TabIndex = 72;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // txtMax
            // 
            txtMax.Location = new Point(351, 225);
            txtMax.Name = "txtMax";
            txtMax.Size = new Size(348, 27);
            txtMax.TabIndex = 71;
            // 
            // txtMin
            // 
            txtMin.Location = new Point(351, 176);
            txtMin.Name = "txtMin";
            txtMin.Size = new Size(348, 27);
            txtMin.TabIndex = 70;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(367, 132);
            label2.Name = "label2";
            label2.Size = new Size(50, 20);
            label2.TabIndex = 69;
            label2.Text = "label2";
            // 
            // lblMin
            // 
            lblMin.AutoSize = true;
            lblMin.Location = new Point(102, 183);
            lblMin.Name = "lblMin";
            lblMin.Size = new Size(84, 20);
            lblMin.TabIndex = 68;
            lblMin.Text = "Players Min";
            // 
            // lblPRId
            // 
            lblPRId.AutoSize = true;
            lblPRId.Location = new Point(102, 132);
            lblPRId.Name = "lblPRId";
            lblPRId.Size = new Size(77, 20);
            lblPRId.TabIndex = 67;
            lblPRId.Text = "Creator ID";
            // 
            // Edit_PlayerRange
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(752, 380);
            Controls.Add(label1);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(txtMax);
            Controls.Add(txtMin);
            Controls.Add(label2);
            Controls.Add(lblMin);
            Controls.Add(lblPRId);
            Name = "Edit_PlayerRange";
            Text = "Edit_PlayerRange";
            Load += Edit_PlayerRange_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnCancel;
        private Button btnSave;
        private TextBox txtMax;
        private TextBox txtMin;
        private Label label2;
        private Label lblMin;
        private Label lblPRId;
    }
}