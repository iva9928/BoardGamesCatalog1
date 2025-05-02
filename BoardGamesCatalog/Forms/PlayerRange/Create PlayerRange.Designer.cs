namespace BoardGamesCatalog.Forms.PlayerRange
{
    partial class Create_PlayerRange
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
            txtMax = new TextBox();
            txtMin = new TextBox();
            label2 = new Label();
            lblMin = new Label();
            lblPRId = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(597, 242);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(94, 29);
            btnCancel.TabIndex = 65;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(439, 242);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(94, 29);
            btnSave.TabIndex = 64;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // txtMax
            // 
            txtMax.Location = new Point(343, 178);
            txtMax.Name = "txtMax";
            txtMax.Size = new Size(348, 27);
            txtMax.TabIndex = 62;
            // 
            // txtMin
            // 
            txtMin.Location = new Point(343, 129);
            txtMin.Name = "txtMin";
            txtMin.Size = new Size(348, 27);
            txtMin.TabIndex = 61;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(359, 85);
            label2.Name = "label2";
            label2.Size = new Size(50, 20);
            label2.TabIndex = 59;
            label2.Text = "label2";
            // 
            // lblMin
            // 
            lblMin.AutoSize = true;
            lblMin.Location = new Point(94, 136);
            lblMin.Name = "lblMin";
            lblMin.Size = new Size(84, 20);
            lblMin.TabIndex = 58;
            lblMin.Text = "Players Min";
            // 
            // lblPRId
            // 
            lblPRId.AutoSize = true;
            lblPRId.Location = new Point(94, 85);
            lblPRId.Name = "lblPRId";
            lblPRId.Size = new Size(77, 20);
            lblPRId.TabIndex = 54;
            lblPRId.Text = "Creator ID";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(94, 178);
            label1.Name = "label1";
            label1.Size = new Size(87, 20);
            label1.TabIndex = 66;
            label1.Text = "Players Max";
            // 
            // Create_PlayerRange
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(733, 327);
            Controls.Add(label1);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(txtMax);
            Controls.Add(txtMin);
            Controls.Add(label2);
            Controls.Add(lblMin);
            Controls.Add(lblPRId);
            Name = "Create_PlayerRange";
            Text = "Create_PlayerRange";
            Load += Create_PlayerRange_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCancel;
        private Button btnSave;
        private TextBox txtMax;
        private TextBox txtMin;
        private Label label2;
        private Label lblMin;
        private Label lblPRId;
        private Label label1;
    }
}