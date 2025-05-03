namespace BoardGamesCatalog.Forms.Address
{
    partial class Edit_Address
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
            txtBZ = new TextBox();
            txtBC = new TextBox();
            txtBT = new TextBox();
            txtBNumber = new TextBox();
            txtBName = new TextBox();
            label2 = new Label();
            lblZ = new Label();
            lblC = new Label();
            lblT = new Label();
            lblNumber = new Label();
            lblName = new Label();
            lblAId = new Label();
            SuspendLayout();
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(606, 371);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(94, 29);
            btnCancel.TabIndex = 71;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(408, 371);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(94, 29);
            btnSave.TabIndex = 70;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // txtBZ
            // 
            txtBZ.Location = new Point(352, 295);
            txtBZ.Name = "txtBZ";
            txtBZ.Size = new Size(348, 27);
            txtBZ.TabIndex = 69;
            // 
            // txtBC
            // 
            txtBC.Location = new Point(352, 245);
            txtBC.Name = "txtBC";
            txtBC.Size = new Size(348, 27);
            txtBC.TabIndex = 68;
            // 
            // txtBT
            // 
            txtBT.Location = new Point(352, 191);
            txtBT.Name = "txtBT";
            txtBT.Size = new Size(348, 27);
            txtBT.TabIndex = 67;
            // 
            // txtBNumber
            // 
            txtBNumber.Location = new Point(352, 141);
            txtBNumber.Name = "txtBNumber";
            txtBNumber.Size = new Size(348, 27);
            txtBNumber.TabIndex = 66;
            // 
            // txtBName
            // 
            txtBName.Location = new Point(352, 91);
            txtBName.Name = "txtBName";
            txtBName.Size = new Size(348, 27);
            txtBName.TabIndex = 65;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(352, 50);
            label2.Name = "label2";
            label2.Size = new Size(0, 20);
            label2.TabIndex = 64;
            // 
            // lblZ
            // 
            lblZ.AutoSize = true;
            lblZ.Location = new Point(101, 299);
            lblZ.Name = "lblZ";
            lblZ.Size = new Size(30, 20);
            lblZ.TabIndex = 63;
            lblZ.Text = "ZIP";
            // 
            // lblC
            // 
            lblC.AutoSize = true;
            lblC.Location = new Point(100, 247);
            lblC.Name = "lblC";
            lblC.Size = new Size(60, 20);
            lblC.TabIndex = 62;
            lblC.Text = "Country";
            // 
            // lblT
            // 
            lblT.AutoSize = true;
            lblT.Location = new Point(101, 195);
            lblT.Name = "lblT";
            lblT.Size = new Size(44, 20);
            lblT.TabIndex = 61;
            lblT.Text = "Town";
            // 
            // lblNumber
            // 
            lblNumber.AutoSize = true;
            lblNumber.Location = new Point(100, 141);
            lblNumber.Name = "lblNumber";
            lblNumber.Size = new Size(106, 20);
            lblNumber.TabIndex = 60;
            lblNumber.Text = "Street Number";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(100, 91);
            lblName.Name = "lblName";
            lblName.Size = new Size(92, 20);
            lblName.TabIndex = 59;
            lblName.Text = "Street Name";
            // 
            // lblAId
            // 
            lblAId.AutoSize = true;
            lblAId.Location = new Point(100, 50);
            lblAId.Name = "lblAId";
            lblAId.Size = new Size(106, 20);
            lblAId.TabIndex = 58;
            lblAId.Text = "Boardgame ID";
            // 
            // Edit_Address
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MistyRose;
            ClientSize = new Size(800, 450);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(txtBZ);
            Controls.Add(txtBC);
            Controls.Add(txtBT);
            Controls.Add(txtBNumber);
            Controls.Add(txtBName);
            Controls.Add(label2);
            Controls.Add(lblZ);
            Controls.Add(lblC);
            Controls.Add(lblT);
            Controls.Add(lblNumber);
            Controls.Add(lblName);
            Controls.Add(lblAId);
            Name = "Edit_Address";
            Text = "Edit_Address";
            Load += Edit_Address_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCancel;
        private Button btnSave;
        private TextBox txtBZ;
        private TextBox txtBC;
        private TextBox txtBT;
        private TextBox txtBNumber;
        private TextBox txtBName;
        private Label label2;
        private Label lblZ;
        private Label lblC;
        private Label lblT;
        private Label lblNumber;
        private Label lblName;
        private Label lblAId;
    }
}