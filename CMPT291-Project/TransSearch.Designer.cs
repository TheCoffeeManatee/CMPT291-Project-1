namespace CMPT291_Project
{
    partial class Form1
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.SearchFor = new System.Windows.Forms.TextBox();
            this.TSearchBy = new System.Windows.Forms.ComboBox();
            this.SearchBtn = new System.Windows.Forms.Button();
            this.TransactionID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PickBranch = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PickDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ReturnBranch = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ReturnDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VIN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustomerID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
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
            this.TransactionID,
            this.PickBranch,
            this.PickDate,
            this.ReturnBranch,
            this.ReturnDate,
            this.VIN,
            this.CustomerID});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(79)))), ((int)(((byte)(99)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.dataGridView1.Location = new System.Drawing.Point(33, 134);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
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
            this.dataGridView1.RowHeadersWidth = 72;
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(1066, 628);
            this.dataGridView1.TabIndex = 22;
            // 
            // SearchFor
            // 
            this.SearchFor.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.SearchFor.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.SearchFor.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SearchFor.Location = new System.Drawing.Point(228, 78);
            this.SearchFor.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.SearchFor.Name = "SearchFor";
            this.SearchFor.Size = new System.Drawing.Size(732, 38);
            this.SearchFor.TabIndex = 20;
            // 
            // TSearchBy
            // 
            this.TSearchBy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.TSearchBy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TSearchBy.ForeColor = System.Drawing.SystemColors.Window;
            this.TSearchBy.FormattingEnabled = true;
            this.TSearchBy.Items.AddRange(new object[] {
            "Transaction ID",
            "PickUp Branch",
            "PickUp Date",
            "Return Branch",
            "Return Date",
            "VIN",
            "Customer ID"});
            this.TSearchBy.Location = new System.Drawing.Point(33, 76);
            this.TSearchBy.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.TSearchBy.Name = "TSearchBy";
            this.TSearchBy.Size = new System.Drawing.Size(182, 38);
            this.TSearchBy.TabIndex = 19;
            // 
            // SearchBtn
            // 
            this.SearchBtn.AllowDrop = true;
            this.SearchBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SearchBtn.ForeColor = System.Drawing.Color.White;
            this.SearchBtn.Location = new System.Drawing.Point(971, 76);
            this.SearchBtn.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.SearchBtn.Name = "SearchBtn";
            this.SearchBtn.Size = new System.Drawing.Size(129, 46);
            this.SearchBtn.TabIndex = 21;
            this.SearchBtn.Text = "Search";
            this.SearchBtn.UseVisualStyleBackColor = true;
            // 
            // TransactionID
            // 
            this.TransactionID.HeaderText = "Transaction ID";
            this.TransactionID.MinimumWidth = 9;
            this.TransactionID.Name = "TransactionID";
            this.TransactionID.Width = 175;
            // 
            // PickBranch
            // 
            this.PickBranch.HeaderText = "Pickup Branch";
            this.PickBranch.MinimumWidth = 9;
            this.PickBranch.Name = "PickBranch";
            this.PickBranch.Width = 175;
            // 
            // PickDate
            // 
            this.PickDate.HeaderText = "Pickup Date";
            this.PickDate.MinimumWidth = 9;
            this.PickDate.Name = "PickDate";
            this.PickDate.Width = 175;
            // 
            // ReturnBranch
            // 
            this.ReturnBranch.HeaderText = "Return Branch";
            this.ReturnBranch.MinimumWidth = 9;
            this.ReturnBranch.Name = "ReturnBranch";
            this.ReturnBranch.Width = 175;
            // 
            // ReturnDate
            // 
            this.ReturnDate.HeaderText = "Return Date";
            this.ReturnDate.MinimumWidth = 9;
            this.ReturnDate.Name = "ReturnDate";
            this.ReturnDate.Width = 175;
            // 
            // VIN
            // 
            this.VIN.HeaderText = "VIN";
            this.VIN.MinimumWidth = 9;
            this.VIN.Name = "VIN";
            this.VIN.Width = 175;
            // 
            // CustomerID
            // 
            this.CustomerID.HeaderText = "Customer ID";
            this.CustomerID.MinimumWidth = 9;
            this.CustomerID.Name = "CustomerID";
            this.CustomerID.Width = 175;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(1138, 844);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.SearchBtn);
            this.Controls.Add(this.SearchFor);
            this.Controls.Add(this.TSearchBy);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dataGridView1;
        private TextBox SearchFor;
        private ComboBox TSearchBy;
        private Button SearchBtn;
        private DataGridViewTextBoxColumn TransactionID;
        private DataGridViewTextBoxColumn PickBranch;
        private DataGridViewTextBoxColumn PickDate;
        private DataGridViewTextBoxColumn ReturnBranch;
        private DataGridViewTextBoxColumn ReturnDate;
        private DataGridViewTextBoxColumn VIN;
        private DataGridViewTextBoxColumn CustomerID;
    }
}