namespace CMPT291_Project
{
    partial class CustomersFrm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.CustomerPanel = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.CustomerID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MiddleName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AddressL1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AddressL2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.City = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Province = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PostCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DOB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Insurance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DriversLicense = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MemberStat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.CustomersLbl = new System.Windows.Forms.Label();
            this.CustomerPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // CustomerPanel
            // 
            this.CustomerPanel.Controls.Add(this.button3);
            this.CustomerPanel.Controls.Add(this.button2);
            this.CustomerPanel.Controls.Add(this.dataGridView1);
            this.CustomerPanel.Controls.Add(this.button1);
            this.CustomerPanel.Controls.Add(this.textBox1);
            this.CustomerPanel.Controls.Add(this.comboBox1);
            this.CustomerPanel.Controls.Add(this.CustomersLbl);
            this.CustomerPanel.Location = new System.Drawing.Point(0, 0);
            this.CustomerPanel.Margin = new System.Windows.Forms.Padding(6);
            this.CustomerPanel.Name = "CustomerPanel";
            this.CustomerPanel.Size = new System.Drawing.Size(1233, 1050);
            this.CustomerPanel.TabIndex = 0;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(79)))), ((int)(((byte)(99)))));
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button3.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.button3.Location = new System.Drawing.Point(39, 173);
            this.button3.Margin = new System.Windows.Forms.Padding(6);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(169, 64);
            this.button3.TabIndex = 20;
            this.button3.Text = "Add";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(79)))), ((int)(((byte)(99)))));
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button2.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.button2.Location = new System.Drawing.Point(251, 173);
            this.button2.Margin = new System.Windows.Forms.Padding(6);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(169, 64);
            this.button2.TabIndex = 19;
            this.button2.Text = "Remove";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(79)))), ((int)(((byte)(99)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CustomerID,
            this.FirstName,
            this.MiddleName,
            this.LastName,
            this.AddressL1,
            this.AddressL2,
            this.City,
            this.Province,
            this.PostCode,
            this.DOB,
            this.Phone,
            this.Insurance,
            this.DriversLicense,
            this.MemberStat});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(79)))), ((int)(((byte)(99)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.dataGridView1.Location = new System.Drawing.Point(39, 331);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(6);
            this.dataGridView1.Name = "dataGridView1";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(79)))), ((int)(((byte)(99)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 82;
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(1155, 670);
            this.dataGridView1.TabIndex = 18;
            // 
            // CustomerID
            // 
            this.CustomerID.HeaderText = "CID";
            this.CustomerID.MinimumWidth = 10;
            this.CustomerID.Name = "CustomerID";
            this.CustomerID.Width = 70;
            // 
            // FirstName
            // 
            this.FirstName.HeaderText = "First";
            this.FirstName.MinimumWidth = 10;
            this.FirstName.Name = "FirstName";
            this.FirstName.Width = 200;
            // 
            // MiddleName
            // 
            this.MiddleName.HeaderText = "Middle";
            this.MiddleName.MinimumWidth = 10;
            this.MiddleName.Name = "MiddleName";
            this.MiddleName.Width = 200;
            // 
            // LastName
            // 
            this.LastName.HeaderText = "Last";
            this.LastName.MinimumWidth = 10;
            this.LastName.Name = "LastName";
            this.LastName.Width = 200;
            // 
            // AddressL1
            // 
            this.AddressL1.HeaderText = "Address 1";
            this.AddressL1.MinimumWidth = 10;
            this.AddressL1.Name = "AddressL1";
            this.AddressL1.Width = 200;
            // 
            // AddressL2
            // 
            this.AddressL2.HeaderText = "Address 2";
            this.AddressL2.MinimumWidth = 10;
            this.AddressL2.Name = "AddressL2";
            this.AddressL2.Width = 200;
            // 
            // City
            // 
            this.City.HeaderText = "City";
            this.City.MinimumWidth = 10;
            this.City.Name = "City";
            this.City.Width = 200;
            // 
            // Province
            // 
            this.Province.HeaderText = "Prov";
            this.Province.MinimumWidth = 10;
            this.Province.Name = "Province";
            this.Province.Width = 200;
            // 
            // PostCode
            // 
            this.PostCode.HeaderText = "Postal Code";
            this.PostCode.MinimumWidth = 10;
            this.PostCode.Name = "PostCode";
            this.PostCode.Width = 200;
            // 
            // DOB
            // 
            this.DOB.HeaderText = "DOB";
            this.DOB.MinimumWidth = 10;
            this.DOB.Name = "DOB";
            this.DOB.Width = 200;
            // 
            // Phone
            // 
            this.Phone.HeaderText = "Phone #";
            this.Phone.MinimumWidth = 10;
            this.Phone.Name = "Phone";
            this.Phone.Width = 200;
            // 
            // Insurance
            // 
            this.Insurance.HeaderText = "Insurance";
            this.Insurance.MinimumWidth = 10;
            this.Insurance.Name = "Insurance";
            this.Insurance.Width = 200;
            // 
            // DriversLicense
            // 
            this.DriversLicense.HeaderText = "License";
            this.DriversLicense.MinimumWidth = 10;
            this.DriversLicense.Name = "DriversLicense";
            this.DriversLicense.Width = 200;
            // 
            // MemberStat
            // 
            this.MemberStat.HeaderText = "Member";
            this.MemberStat.MinimumWidth = 10;
            this.MemberStat.Name = "MemberStat";
            this.MemberStat.Width = 200;
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(1055, 269);
            this.button1.Margin = new System.Windows.Forms.Padding(6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(139, 49);
            this.button1.TabIndex = 17;
            this.button1.Text = "Search";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox1.Location = new System.Drawing.Point(251, 271);
            this.textBox1.Margin = new System.Windows.Forms.Padding(6);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(793, 43);
            this.textBox1.TabIndex = 16;
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.comboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox1.ForeColor = System.Drawing.SystemColors.Window;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "CID",
            "FName",
            "MName",
            "LName",
            "Address",
            "City",
            "Province",
            "Postal",
            "DOB",
            "Phone",
            "Ins",
            "Drivers",
            "Member"});
            this.comboBox1.Location = new System.Drawing.Point(39, 269);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(6);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(197, 40);
            this.comboBox1.TabIndex = 15;
            // 
            // CustomersLbl
            // 
            this.CustomersLbl.AutoSize = true;
            this.CustomersLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.CustomersLbl.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.CustomersLbl.Location = new System.Drawing.Point(39, 49);
            this.CustomersLbl.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.CustomersLbl.Name = "CustomersLbl";
            this.CustomersLbl.Size = new System.Drawing.Size(317, 67);
            this.CustomersLbl.TabIndex = 14;
            this.CustomersLbl.Text = "Customers";
            // 
            // CustomersFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.ClientSize = new System.Drawing.Size(1233, 1050);
            this.Controls.Add(this.CustomerPanel);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "CustomersFrm";
            this.Text = "Customers";
            this.CustomerPanel.ResumeLayout(false);
            this.CustomerPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel CustomerPanel;
        private Button button3;
        private Button button2;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn CustomerID;
        private DataGridViewTextBoxColumn FirstName;
        private DataGridViewTextBoxColumn MiddleName;
        private DataGridViewTextBoxColumn LastName;
        private DataGridViewTextBoxColumn AddressL1;
        private DataGridViewTextBoxColumn AddressL2;
        private DataGridViewTextBoxColumn City;
        private DataGridViewTextBoxColumn Province;
        private DataGridViewTextBoxColumn PostCode;
        private DataGridViewTextBoxColumn DOB;
        private DataGridViewTextBoxColumn Phone;
        private DataGridViewTextBoxColumn Insurance;
        private DataGridViewTextBoxColumn DriversLicense;
        private DataGridViewTextBoxColumn MemberStat;
        private Button button1;
        private TextBox textBox1;
        private ComboBox comboBox1;
        private Label CustomersLbl;
    }
}