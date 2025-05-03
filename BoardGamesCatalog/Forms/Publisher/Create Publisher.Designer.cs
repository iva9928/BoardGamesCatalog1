namespace BoardGamesCatalog.Forms.Publisher
{
    partial class Create_Publisher
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
            txtP = new TextBox();
            txtW = new TextBox();
            txtA = new TextBox();
            txtBName = new TextBox();
            label2 = new Label();
            lblAId = new Label();
            lblP = new Label();
            lblW = new Label();
            lblName = new Label();
            lblPId = new Label();
            SuspendLayout();
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(613, 336);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(94, 29);
            btnCancel.TabIndex = 53;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(359, 336);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(94, 29);
            btnSave.TabIndex = 52;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // txtP
            // 
            txtP.Location = new Point(359, 264);
            txtP.Name = "txtP";
            txtP.Size = new Size(348, 27);
            txtP.TabIndex = 51;
            // 
            // txtW
            // 
            txtW.Location = new Point(359, 217);
            txtW.Name = "txtW";
            txtW.Size = new Size(348, 27);
            txtW.TabIndex = 50;
            // 
            // txtA
            // 
            txtA.Location = new Point(359, 171);
            txtA.Name = "txtA";
            txtA.Size = new Size(348, 27);
            txtA.TabIndex = 49;
            // 
            // txtBName
            // 
            txtBName.Location = new Point(359, 127);
            txtBName.Name = "txtBName";
            txtBName.Size = new Size(348, 27);
            txtBName.TabIndex = 48;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(359, 85);
            label2.Name = "label2";
            label2.Size = new Size(50, 20);
            label2.TabIndex = 47;
            label2.Text = "label2";
            // 
            // lblAId
            // 
            lblAId.AutoSize = true;
            lblAId.Location = new Point(94, 171);
            lblAId.Name = "lblAId";
            lblAId.Size = new Size(81, 20);
            lblAId.TabIndex = 46;
            lblAId.Text = "Address ID";
            // 
            // lblP
            // 
            lblP.AutoSize = true;
            lblP.Location = new Point(94, 267);
            lblP.Name = "lblP";
            lblP.Size = new Size(50, 20);
            lblP.TabIndex = 45;
            lblP.Text = "Phone";
            // 
            // lblW
            // 
            lblW.AutoSize = true;
            lblW.Location = new Point(94, 217);
            lblW.Name = "lblW";
            lblW.Size = new Size(62, 20);
            lblW.TabIndex = 44;
            lblW.Text = "Website";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(94, 129);
            lblName.Name = "lblName";
            lblName.Size = new Size(49, 20);
            lblName.TabIndex = 43;
            lblName.Text = "Name";
            // 
            // lblPId
            // 
            lblPId.AutoSize = true;
            lblPId.Location = new Point(94, 85);
            lblPId.Name = "lblPId";
            lblPId.Size = new Size(88, 20);
            lblPId.TabIndex = 42;
            lblPId.Text = "Publisher ID";
            // 
            // Create_Publisher
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Tan;
            ClientSize = new Size(800, 450);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(txtP);
            Controls.Add(txtW);
            Controls.Add(txtA);
            Controls.Add(txtBName);
            Controls.Add(label2);
            Controls.Add(lblAId);
            Controls.Add(lblP);
            Controls.Add(lblW);
            Controls.Add(lblName);
            Controls.Add(lblPId);
            Name = "Create_Publisher";
            Text = "Create_Publisher";
            Load += Create_Publisher_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCancel;
        private Button btnSave;
        private TextBox txtP;
        private TextBox txtW;
        private TextBox txtA;
        private TextBox txtBName;
        private Label label2;
        private Label lblAId;
        private Label lblP;
        private Label lblW;
        private Label lblName;
        private Label lblPId;
    }
}