namespace BoardGamesCatalog.Forms.Creator
{
    partial class Create_Creator
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
            lblID = new Label();
            lblFN = new Label();
            lblLN = new Label();
            lblEmail = new Label();
            label5 = new Label();
            txtFN = new TextBox();
            txtEmail = new TextBox();
            txtLN = new TextBox();
            btnCancel = new Button();
            btnSave = new Button();
            SuspendLayout();
            // 
            // lblID
            // 
            lblID.AutoSize = true;
            lblID.Location = new Point(63, 114);
            lblID.Name = "lblID";
            lblID.Size = new Size(77, 20);
            lblID.TabIndex = 3;
            lblID.Text = "Creator ID";
            // 
            // lblFN
            // 
            lblFN.AutoSize = true;
            lblFN.Location = new Point(64, 175);
            lblFN.Name = "lblFN";
            lblFN.Size = new Size(76, 20);
            lblFN.TabIndex = 4;
            lblFN.Text = "FirstName";
            // 
            // lblLN
            // 
            lblLN.AutoSize = true;
            lblLN.Location = new Point(63, 240);
            lblLN.Name = "lblLN";
            lblLN.Size = new Size(75, 20);
            lblLN.TabIndex = 5;
            lblLN.Text = "LastName";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(64, 303);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(46, 20);
            lblEmail.TabIndex = 6;
            lblEmail.Text = "Email";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(305, 114);
            label5.Name = "label5";
            label5.Size = new Size(50, 20);
            label5.TabIndex = 7;
            label5.Text = "label5";
            // 
            // txtFN
            // 
            txtFN.Location = new Point(305, 175);
            txtFN.Name = "txtFN";
            txtFN.Size = new Size(125, 27);
            txtFN.TabIndex = 8;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(305, 296);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(125, 27);
            txtEmail.TabIndex = 11;
            // 
            // txtLN
            // 
            txtLN.Location = new Point(305, 233);
            txtLN.Name = "txtLN";
            txtLN.Size = new Size(125, 27);
            txtLN.TabIndex = 10;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(186, 367);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(94, 29);
            btnCancel.TabIndex = 13;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(336, 367);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(94, 29);
            btnSave.TabIndex = 12;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // Create_Creator
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(495, 461);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(txtEmail);
            Controls.Add(txtLN);
            Controls.Add(txtFN);
            Controls.Add(label5);
            Controls.Add(lblEmail);
            Controls.Add(lblLN);
            Controls.Add(lblFN);
            Controls.Add(lblID);
            Name = "Create_Creator";
            Text = "Create_Creator";
            Load += Create_Creator_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblID;
        private Label lblFN;
        private Label lblLN;
        private Label lblEmail;
        private Label label5;
        private TextBox txtFN;
        private TextBox txtEmail;
        private TextBox txtLN;
        private Button btnCancel;
        private Button btnSave;
    }
}