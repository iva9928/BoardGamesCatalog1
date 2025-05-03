namespace BoardGamesCatalog.Forms.Creator
{
    partial class Edit_Creator
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
            btnSave = new Button();
            btnCancel = new Button();
            lblID = new Label();
            lblFN = new Label();
            lblLN = new Label();
            lblEmail = new Label();
            label5 = new Label();
            txtFN = new TextBox();
            txtLN = new TextBox();
            txtEmail = new TextBox();
            SuspendLayout();
            // 
            // btnSave
            // 
            btnSave.Location = new Point(181, 328);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(94, 29);
            btnSave.TabIndex = 0;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(339, 328);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(94, 29);
            btnCancel.TabIndex = 1;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // lblID
            // 
            lblID.AutoSize = true;
            lblID.Location = new Point(56, 116);
            lblID.Name = "lblID";
            lblID.Size = new Size(77, 20);
            lblID.TabIndex = 2;
            lblID.Text = "Creator ID";
            // 
            // lblFN
            // 
            lblFN.AutoSize = true;
            lblFN.Location = new Point(57, 160);
            lblFN.Name = "lblFN";
            lblFN.Size = new Size(76, 20);
            lblFN.TabIndex = 3;
            lblFN.Text = "FirstName";
            // 
            // lblLN
            // 
            lblLN.AutoSize = true;
            lblLN.Location = new Point(58, 212);
            lblLN.Name = "lblLN";
            lblLN.Size = new Size(75, 20);
            lblLN.TabIndex = 4;
            lblLN.Text = "LastName";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(58, 268);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(46, 20);
            lblEmail.TabIndex = 5;
            lblEmail.Text = "Email";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(308, 116);
            label5.Name = "label5";
            label5.Size = new Size(50, 20);
            label5.TabIndex = 6;
            label5.Text = "label5";
            // 
            // txtFN
            // 
            txtFN.Location = new Point(308, 160);
            txtFN.Name = "txtFN";
            txtFN.Size = new Size(125, 27);
            txtFN.TabIndex = 7;
            // 
            // txtLN
            // 
            txtLN.Location = new Point(308, 209);
            txtLN.Name = "txtLN";
            txtLN.Size = new Size(125, 27);
            txtLN.TabIndex = 8;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(308, 261);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(125, 27);
            txtEmail.TabIndex = 9;
            // 
            // Edit_Creator
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 255, 192);
            ClientSize = new Size(501, 450);
            Controls.Add(txtEmail);
            Controls.Add(txtLN);
            Controls.Add(txtFN);
            Controls.Add(label5);
            Controls.Add(lblEmail);
            Controls.Add(lblLN);
            Controls.Add(lblFN);
            Controls.Add(lblID);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Name = "Edit_Creator";
            Text = "Edit_Creator";
            Load += Edit_Creator_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSave;
        private Button btnCancel;
        private Label lblID;
        private Label lblFN;
        private Label lblLN;
        private Label lblEmail;
        private Label label5;
        private TextBox txtFN;
        private TextBox txtLN;
        private TextBox txtEmail;
    }
}