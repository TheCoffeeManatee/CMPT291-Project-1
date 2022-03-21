namespace CMPT291_Project
{
    partial class CarTypeFrm
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
            this.CarTypePanel = new System.Windows.Forms.Panel();
            this.CarTypeAdd = new System.Windows.Forms.Button();
            this.CarTypeRm = new System.Windows.Forms.Button();
            this.CarTypeTable = new System.Windows.Forms.DataGridView();
            this.TypeID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dRate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.wRate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mRate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CarTypeSearchButt = new System.Windows.Forms.Button();
            this.CarTypeSearch = new System.Windows.Forms.TextBox();
            this.CarTypeDD = new System.Windows.Forms.ComboBox();
            this.CarTypeLbl = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.CarTypePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CarTypeTable)).BeginInit();
            this.SuspendLayout();
            // 
            // CarTypePanel
            // 
            this.CarTypePanel.Controls.Add(this.button1);
            this.CarTypePanel.Controls.Add(this.CarTypeAdd);
            this.CarTypePanel.Controls.Add(this.CarTypeRm);
            this.CarTypePanel.Controls.Add(this.CarTypeTable);
            this.CarTypePanel.Controls.Add(this.CarTypeSearchButt);
            this.CarTypePanel.Controls.Add(this.CarTypeSearch);
            this.CarTypePanel.Controls.Add(this.CarTypeDD);
            this.CarTypePanel.Controls.Add(this.CarTypeLbl);
            this.CarTypePanel.Location = new System.Drawing.Point(0, 0);
            this.CarTypePanel.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.CarTypePanel.Name = "CarTypePanel";
            this.CarTypePanel.Size = new System.Drawing.Size(1233, 1050);
            this.CarTypePanel.TabIndex = 0;
            // 
            // CarTypeAdd
            // 
            this.CarTypeAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(79)))), ((int)(((byte)(99)))));
            this.CarTypeAdd.FlatAppearance.BorderSize = 0;
            this.CarTypeAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CarTypeAdd.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CarTypeAdd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.CarTypeAdd.Location = new System.Drawing.Point(39, 173);
            this.CarTypeAdd.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.CarTypeAdd.Name = "CarTypeAdd";
            this.CarTypeAdd.Size = new System.Drawing.Size(169, 64);
            this.CarTypeAdd.TabIndex = 27;
            this.CarTypeAdd.Text = "Add";
            this.CarTypeAdd.UseVisualStyleBackColor = false;
            this.CarTypeAdd.Click += new System.EventHandler(this.CarTypeAdd_Click);
            // 
            // CarTypeRm
            // 
            this.CarTypeRm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(79)))), ((int)(((byte)(99)))));
            this.CarTypeRm.FlatAppearance.BorderSize = 0;
            this.CarTypeRm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CarTypeRm.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CarTypeRm.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.CarTypeRm.Location = new System.Drawing.Point(251, 173);
            this.CarTypeRm.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.CarTypeRm.Name = "CarTypeRm";
            this.CarTypeRm.Size = new System.Drawing.Size(169, 64);
            this.CarTypeRm.TabIndex = 26;
            this.CarTypeRm.Text = "Remove";
            this.CarTypeRm.UseVisualStyleBackColor = false;
            // 
            // CarTypeTable
            // 
            this.CarTypeTable.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.CarTypeTable.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(79)))), ((int)(((byte)(99)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.CarTypeTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.CarTypeTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CarTypeTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TypeID,
            this.Description,
            this.dRate,
            this.wRate,
            this.mRate});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(79)))), ((int)(((byte)(99)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.CarTypeTable.DefaultCellStyle = dataGridViewCellStyle2;
            this.CarTypeTable.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.CarTypeTable.Location = new System.Drawing.Point(39, 331);
            this.CarTypeTable.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.CarTypeTable.Name = "CarTypeTable";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(79)))), ((int)(((byte)(99)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.CarTypeTable.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.CarTypeTable.RowHeadersVisible = false;
            this.CarTypeTable.RowHeadersWidth = 82;
            this.CarTypeTable.RowTemplate.Height = 25;
            this.CarTypeTable.Size = new System.Drawing.Size(1155, 670);
            this.CarTypeTable.TabIndex = 25;
            // 
            // TypeID
            // 
            this.TypeID.HeaderText = "Car Type ID";
            this.TypeID.MinimumWidth = 10;
            this.TypeID.Name = "TypeID";
            this.TypeID.Width = 200;
            // 
            // Description
            // 
            this.Description.HeaderText = "Description";
            this.Description.MinimumWidth = 10;
            this.Description.Name = "Description";
            this.Description.Width = 150;
            // 
            // dRate
            // 
            this.dRate.HeaderText = "Daily Rate";
            this.dRate.MinimumWidth = 10;
            this.dRate.Name = "dRate";
            this.dRate.Width = 200;
            // 
            // wRate
            // 
            this.wRate.HeaderText = "Weekly Rate";
            this.wRate.MinimumWidth = 10;
            this.wRate.Name = "wRate";
            this.wRate.Width = 200;
            // 
            // mRate
            // 
            this.mRate.HeaderText = "Monthly Rate";
            this.mRate.MinimumWidth = 10;
            this.mRate.Name = "mRate";
            this.mRate.Width = 170;
            // 
            // CarTypeSearchButt
            // 
            this.CarTypeSearchButt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CarTypeSearchButt.ForeColor = System.Drawing.Color.White;
            this.CarTypeSearchButt.Location = new System.Drawing.Point(1055, 269);
            this.CarTypeSearchButt.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.CarTypeSearchButt.Name = "CarTypeSearchButt";
            this.CarTypeSearchButt.Size = new System.Drawing.Size(139, 49);
            this.CarTypeSearchButt.TabIndex = 24;
            this.CarTypeSearchButt.Text = "Search";
            this.CarTypeSearchButt.UseVisualStyleBackColor = true;
            // 
            // CarTypeSearch
            // 
            this.CarTypeSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.CarTypeSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CarTypeSearch.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CarTypeSearch.Location = new System.Drawing.Point(251, 271);
            this.CarTypeSearch.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.CarTypeSearch.Name = "CarTypeSearch";
            this.CarTypeSearch.Size = new System.Drawing.Size(793, 43);
            this.CarTypeSearch.TabIndex = 23;
            // 
            // CarTypeDD
            // 
            this.CarTypeDD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.CarTypeDD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CarTypeDD.ForeColor = System.Drawing.SystemColors.Window;
            this.CarTypeDD.FormattingEnabled = true;
            this.CarTypeDD.Items.AddRange(new object[] {
            "Type ID",
            "Description",
            "Daily",
            "Weekly",
            "Monthly"});
            this.CarTypeDD.Location = new System.Drawing.Point(39, 269);
            this.CarTypeDD.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.CarTypeDD.Name = "CarTypeDD";
            this.CarTypeDD.Size = new System.Drawing.Size(197, 40);
            this.CarTypeDD.TabIndex = 22;
            // 
            // CarTypeLbl
            // 
            this.CarTypeLbl.AutoSize = true;
            this.CarTypeLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.CarTypeLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.CarTypeLbl.Location = new System.Drawing.Point(39, 49);
            this.CarTypeLbl.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.CarTypeLbl.Name = "CarTypeLbl";
            this.CarTypeLbl.Size = new System.Drawing.Size(273, 67);
            this.CarTypeLbl.TabIndex = 21;
            this.CarTypeLbl.Text = "Car Type";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(79)))), ((int)(((byte)(99)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.button1.Location = new System.Drawing.Point(456, 173);
            this.button1.Margin = new System.Windows.Forms.Padding(6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(169, 64);
            this.button1.TabIndex = 28;
            this.button1.Text = "Edit";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // CarTypeFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.ClientSize = new System.Drawing.Size(1233, 1050);
            this.Controls.Add(this.CarTypePanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "CarTypeFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QueryFrm";
            this.Load += new System.EventHandler(this.QueryFrm_Load);
            this.CarTypePanel.ResumeLayout(false);
            this.CarTypePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CarTypeTable)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel CarTypePanel;
        private Button CarTypeAdd;
        private Button CarTypeRm;
        private DataGridView CarTypeTable;
        private DataGridViewTextBoxColumn TypeID;
        private DataGridViewTextBoxColumn Description;
        private DataGridViewTextBoxColumn dRate;
        private DataGridViewTextBoxColumn wRate;
        private DataGridViewTextBoxColumn mRate;
        private Button CarTypeSearchButt;
        private TextBox CarTypeSearch;
        private ComboBox CarTypeDD;
        private Label CarTypeLbl;
        private Button button1;
    }
}