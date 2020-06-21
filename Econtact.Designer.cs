namespace E_Contact
{
    partial class txtBoxFirstName
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(txtBoxFirstName));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblContactID = new System.Windows.Forms.Label();
            this.TBoxContactID = new System.Windows.Forms.TextBox();
            this.lblFistName = new System.Windows.Forms.Label();
            this.TBoxFirstName = new System.Windows.Forms.TextBox();
            this.lblLastName = new System.Windows.Forms.Label();
            this.TBoxLastName = new System.Windows.Forms.TextBox();
            this.lblGender = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.TBoxAddress = new System.Windows.Forms.TextBox();
            this.cmbGEnder = new System.Windows.Forms.ComboBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnclear = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lblSearch = new System.Windows.Forms.Label();
            this.TBoxSearch = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(482, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(264, 73);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // lblContactID
            // 
            this.lblContactID.AutoSize = true;
            this.lblContactID.BackColor = System.Drawing.Color.Transparent;
            this.lblContactID.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContactID.Location = new System.Drawing.Point(93, 143);
            this.lblContactID.Name = "lblContactID";
            this.lblContactID.Size = new System.Drawing.Size(95, 24);
            this.lblContactID.TabIndex = 1;
            this.lblContactID.Text = "Contact ID";
            // 
            // TBoxContactID
            // 
            this.TBoxContactID.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBoxContactID.Location = new System.Drawing.Point(245, 140);
            this.TBoxContactID.Name = "TBoxContactID";
            this.TBoxContactID.Size = new System.Drawing.Size(475, 29);
            this.TBoxContactID.TabIndex = 2;
            this.TBoxContactID.TextChanged += new System.EventHandler(this.TxtBoxContctID_TextChanged);
            // 
            // lblFistName
            // 
            this.lblFistName.AutoSize = true;
            this.lblFistName.BackColor = System.Drawing.Color.Transparent;
            this.lblFistName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFistName.Location = new System.Drawing.Point(93, 186);
            this.lblFistName.Name = "lblFistName";
            this.lblFistName.Size = new System.Drawing.Size(101, 24);
            this.lblFistName.TabIndex = 1;
            this.lblFistName.Text = "First Name";
            this.lblFistName.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // TBoxFirstName
            // 
            this.TBoxFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBoxFirstName.Location = new System.Drawing.Point(245, 183);
            this.TBoxFirstName.Name = "TBoxFirstName";
            this.TBoxFirstName.Size = new System.Drawing.Size(475, 29);
            this.TBoxFirstName.TabIndex = 2;
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.BackColor = System.Drawing.Color.Transparent;
            this.lblLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLastName.Location = new System.Drawing.Point(95, 231);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(99, 24);
            this.lblLastName.TabIndex = 1;
            this.lblLastName.Text = "Last Name";
            this.lblLastName.Click += new System.EventHandler(this.label2_Click);
            // 
            // TBoxLastName
            // 
            this.TBoxLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBoxLastName.Location = new System.Drawing.Point(245, 228);
            this.TBoxLastName.Name = "TBoxLastName";
            this.TBoxLastName.Size = new System.Drawing.Size(475, 29);
            this.TBoxLastName.TabIndex = 2;
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.BackColor = System.Drawing.Color.Transparent;
            this.lblGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGender.Location = new System.Drawing.Point(95, 434);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(74, 24);
            this.lblGender.TabIndex = 1;
            this.lblGender.Text = "Gender";
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.BackColor = System.Drawing.Color.Transparent;
            this.lblAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddress.Location = new System.Drawing.Point(95, 318);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(80, 24);
            this.lblAddress.TabIndex = 1;
            this.lblAddress.Text = "Address";
            this.lblAddress.Click += new System.EventHandler(this.label1_Click_2);
            // 
            // TBoxAddress
            // 
            this.TBoxAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBoxAddress.Location = new System.Drawing.Point(245, 315);
            this.TBoxAddress.Multiline = true;
            this.TBoxAddress.Name = "TBoxAddress";
            this.TBoxAddress.Size = new System.Drawing.Size(475, 98);
            this.TBoxAddress.TabIndex = 2;
            this.TBoxAddress.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // cmbGEnder
            // 
            this.cmbGEnder.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbGEnder.FormattingEnabled = true;
            this.cmbGEnder.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.cmbGEnder.Location = new System.Drawing.Point(245, 434);
            this.cmbGEnder.Name = "cmbGEnder";
            this.cmbGEnder.Size = new System.Drawing.Size(475, 32);
            this.cmbGEnder.TabIndex = 3;
            this.cmbGEnder.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.ForestGreen;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(97, 591);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(176, 46);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.DarkCyan;
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.Location = new System.Drawing.Point(312, 591);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(176, 46);
            this.btnUpdate.TabIndex = 4;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Red;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(544, 591);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(176, 46);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            // 
            // btnclear
            // 
            this.btnclear.BackColor = System.Drawing.Color.Yellow;
            this.btnclear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclear.Location = new System.Drawing.Point(765, 591);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(176, 46);
            this.btnclear.TabIndex = 4;
            this.btnclear.Text = "Clear";
            this.btnclear.UseVisualStyleBackColor = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(765, 140);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(400, 369);
            this.dataGridView1.TabIndex = 5;
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearch.Location = new System.Drawing.Point(761, 103);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(60, 20);
            this.lblSearch.TabIndex = 6;
            this.lblSearch.Text = "Search";
            // 
            // TBoxSearch
            // 
            this.TBoxSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBoxSearch.Location = new System.Drawing.Point(839, 100);
            this.TBoxSearch.Name = "TBoxSearch";
            this.TBoxSearch.Size = new System.Drawing.Size(326, 26);
            this.TBoxSearch.TabIndex = 7;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(1135, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(30, 38);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 8;
            this.pictureBox2.TabStop = false;
            // 
            // txtBoxFirstName
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1177, 663);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.TBoxSearch);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnclear);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.cmbGEnder);
            this.Controls.Add(this.TBoxAddress);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.lblGender);
            this.Controls.Add(this.TBoxLastName);
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.TBoxFirstName);
            this.Controls.Add(this.lblFistName);
            this.Controls.Add(this.TBoxContactID);
            this.Controls.Add(this.lblContactID);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "txtBoxFirstName";
            this.Text = "E Contact";
            this.Load += new System.EventHandler(this.Econtact_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblContactID;
        private System.Windows.Forms.TextBox TBoxContactID;
        private System.Windows.Forms.Label lblFistName;
        private System.Windows.Forms.TextBox TBoxFirstName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.TextBox TBoxLastName;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.TextBox TBoxAddress;
        private System.Windows.Forms.ComboBox cmbGEnder;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnclear;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.TextBox TBoxSearch;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

