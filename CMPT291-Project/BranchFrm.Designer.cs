namespace CMPT291_Project
{
    partial class BranchFrm
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
            this.BranchPanel = new System.Windows.Forms.Panel();
            this.BranchAdd = new System.Windows.Forms.Button();
            this.BranchRm = new System.Windows.Forms.Button();
            this.BranchTable = new System.Windows.Forms.DataGridView();
            this.BID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Desc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AddL1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AddL2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.City = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Province = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Postal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BranchSearchButt = new System.Windows.Forms.Button();
            this.BranchSearch = new System.Windows.Forms.TextBox();
            this.BranchDD = new System.Windows.Forms.ComboBox();
            this.CustomersLbl = new System.Windows.Forms.Label();
            this.BranchPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BranchTable)).BeginInit();
            this.SuspendLayout();
            // 
            // BranchPanel
            // 
            this.BranchPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.BranchPanel.Controls.Add(this.BranchAdd);
            this.BranchPanel.Controls.Add(this.BranchRm);
            this.BranchPanel.Controls.Add(this.BranchTable);
            this.BranchPanel.Controls.Add(this.BranchSearchButt);
            this.BranchPanel.Controls.Add(this.BranchSearch);
            this.BranchPanel.Controls.Add(this.BranchDD);
            this.BranchPanel.Controls.Add(this.CustomersLbl);
            this.BranchPanel.Location = new System.Drawing.Point(0, 0);
            this.BranchPanel.Name = "BranchPanel";
            this.BranchPanel.Size = new System.Drawing.Size(664, 492);
            this.BranchPanel.TabIndex = 13;
            this.BranchPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.HomeFormPanel1_Paint);
            // 
            // BranchAdd
            // 
            this.BranchAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(79)))), ((int)(((byte)(99)))));
            this.BranchAdd.FlatAppearance.BorderSize = 0;
            this.BranchAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BranchAdd.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BranchAdd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.BranchAdd.Location = new System.Drawing.Point(21, 81);
            this.BranchAdd.Name = "BranchAdd";
            this.BranchAdd.Size = new System.Drawing.Size(91, 30);
            this.BranchAdd.TabIndex = 41;
            this.BranchAdd.Text = "Add";
            this.BranchAdd.UseVisualStyleBackColor = false;
            this.BranchAdd.Click += new System.EventHandler(this.BranchAdd_Click);
            // 
            // BranchRm
            // 
            this.BranchRm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(79)))), ((int)(((byte)(99)))));
            this.BranchRm.FlatAppearance.BorderSize = 0;
            this.BranchRm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BranchRm.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BranchRm.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.BranchRm.Location = new System.Drawing.Point(135, 81);
            this.BranchRm.Name = "BranchRm";
            this.BranchRm.Size = new System.Drawing.Size(91, 30);
            this.BranchRm.TabIndex = 40;
            this.BranchRm.Text = "Remove";
            this.BranchRm.UseVisualStyleBackColor = false;
            // 
            // BranchTable
            // 
            this.BranchTable.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.BranchTable.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(79)))), ((int)(((byte)(99)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.BranchTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.BranchTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.BranchTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.BID,
            this.Desc,
            this.AddL1,
            this.AddL2,
            this.City,
            this.Province,
            this.Postal,
            this.Phone});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(79)))), ((int)(((byte)(99)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.BranchTable.DefaultCellStyle = dataGridViewCellStyle2;
            this.BranchTable.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.BranchTable.Location = new System.Drawing.Point(21, 155);
            this.BranchTable.Name = "BranchTable";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(79)))), ((int)(((byte)(99)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.BranchTable.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.BranchTable.RowHeadersVisible = false;
            this.BranchTable.RowTemplate.Height = 25;
            this.BranchTable.Size = new System.Drawing.Size(622, 314);
            this.BranchTable.TabIndex = 39;
            // 
            // BID
            // 
            this.BID.HeaderText = "BID";
            this.BID.Name = "BID";
            // 
            // Desc
            // 
            this.Desc.HeaderText = "Desc";
            this.Desc.Name = "Desc";
            // 
            // AddL1
            // 
            this.AddL1.HeaderText = "Address Line 1";
            this.AddL1.Name = "AddL1";
            this.AddL1.Width = 110;
            // 
            // AddL2
            // 
            this.AddL2.HeaderText = "Address Line 2";
            this.AddL2.Name = "AddL2";
            this.AddL2.Width = 110;
            // 
            // City
            // 
            this.City.HeaderText = "City";
            this.City.Name = "City";
            // 
            // Province
            // 
            this.Province.HeaderText = "Province";
            this.Province.Name = "Province";
            // 
            // Postal
            // 
            this.Postal.HeaderText = "Postal Code";
            this.Postal.Name = "Postal";
            // 
            // Phone
            // 
            this.Phone.HeaderText = "Phone";
            this.Phone.Name = "Phone";
            // 
            // BranchSearchButt
            // 
            this.BranchSearchButt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BranchSearchButt.ForeColor = System.Drawing.Color.White;
            this.BranchSearchButt.Location = new System.Drawing.Point(568, 126);
            this.BranchSearchButt.Name = "BranchSearchButt";
            this.BranchSearchButt.Size = new System.Drawing.Size(75, 23);
            this.BranchSearchButt.TabIndex = 38;
            this.BranchSearchButt.Text = "Search";
            this.BranchSearchButt.UseVisualStyleBackColor = true;
            // 
            // BranchSearch
            // 
            this.BranchSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.BranchSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.BranchSearch.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BranchSearch.Location = new System.Drawing.Point(135, 127);
            this.BranchSearch.Name = "BranchSearch";
            this.BranchSearch.Size = new System.Drawing.Size(427, 22);
            this.BranchSearch.TabIndex = 37;
            // 
            // BranchDD
            // 
            this.BranchDD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.BranchDD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BranchDD.ForeColor = System.Drawing.SystemColors.Window;
            this.BranchDD.FormattingEnabled = true;
            this.BranchDD.Items.AddRange(new object[] {
            "BID",
            "Desc",
            "Address",
            "City",
            "Province",
            "Postal",
            "Phone"});
            this.BranchDD.Location = new System.Drawing.Point(21, 126);
            this.BranchDD.Name = "BranchDD";
            this.BranchDD.Size = new System.Drawing.Size(108, 23);
            this.BranchDD.TabIndex = 36;
            // 
            // CustomersLbl
            // 
            this.CustomersLbl.AutoSize = true;
            this.CustomersLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.CustomersLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.CustomersLbl.Location = new System.Drawing.Point(21, 23);
            this.CustomersLbl.Name = "CustomersLbl";
            this.CustomersLbl.Size = new System.Drawing.Size(113, 33);
            this.CustomersLbl.TabIndex = 35;
            this.CustomersLbl.Text = "Branch";
            this.CustomersLbl.Click += new System.EventHandler(this.CustomersLbl_Click);
            // 
            // BranchFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(664, 492);
            this.Controls.Add(this.BranchPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "BranchFrm";
            this.BranchPanel.ResumeLayout(false);
            this.BranchPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BranchTable)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Panel BranchPanel;
        private Button BranchAdd;
        private Button BranchRm;
        private DataGridView BranchTable;
        private DataGridViewTextBoxColumn BID;
        private DataGridViewTextBoxColumn Desc;
        private DataGridViewTextBoxColumn AddL1;
        private DataGridViewTextBoxColumn AddL2;
        private DataGridViewTextBoxColumn City;
        private DataGridViewTextBoxColumn Province;
        private DataGridViewTextBoxColumn Postal;
        private DataGridViewTextBoxColumn Phone;
        private Button BranchSearchButt;
        private TextBox BranchSearch;
        private ComboBox BranchDD;
        private Label CustomersLbl;
    }
}