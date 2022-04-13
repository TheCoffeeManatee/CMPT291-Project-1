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
            this.BranchManage = new System.Windows.Forms.Button();
            this.BranchTable = new System.Windows.Forms.DataGridView();
            this.CustomersLbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.BranchTable)).BeginInit();
            this.SuspendLayout();
            // 
            // BranchManage
            // 
            this.BranchManage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(79)))), ((int)(((byte)(99)))));
            this.BranchManage.FlatAppearance.BorderSize = 0;
            this.BranchManage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BranchManage.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BranchManage.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.BranchManage.Location = new System.Drawing.Point(39, 173);
            this.BranchManage.Margin = new System.Windows.Forms.Padding(6);
            this.BranchManage.Name = "BranchManage";
            this.BranchManage.Size = new System.Drawing.Size(169, 64);
            this.BranchManage.TabIndex = 45;
            this.BranchManage.Text = "Manage";
            this.BranchManage.UseVisualStyleBackColor = false;
            this.BranchManage.Click += new System.EventHandler(this.BranchManage_Click);
            // 
            // BranchTable
            // 
            this.BranchTable.AllowUserToAddRows = false;
            this.BranchTable.AllowUserToDeleteRows = false;
            this.BranchTable.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(59)))), ((int)(((byte)(79)))));
            this.BranchTable.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(79)))), ((int)(((byte)(99)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ScrollBar;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.BranchTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.BranchTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(79)))), ((int)(((byte)(99)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ScrollBar;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.BranchTable.DefaultCellStyle = dataGridViewCellStyle2;
            this.BranchTable.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.BranchTable.Location = new System.Drawing.Point(39, 311);
            this.BranchTable.Margin = new System.Windows.Forms.Padding(6);
            this.BranchTable.Name = "BranchTable";
            this.BranchTable.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(79)))), ((int)(((byte)(99)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.BranchTable.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.BranchTable.RowHeadersVisible = false;
            this.BranchTable.RowHeadersWidth = 82;
            this.BranchTable.RowTemplate.Height = 50;
            this.BranchTable.Size = new System.Drawing.Size(1155, 689);
            this.BranchTable.TabIndex = 42;
            // 
            // CustomersLbl
            // 
            this.CustomersLbl.AutoSize = true;
            this.CustomersLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.CustomersLbl.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.CustomersLbl.Location = new System.Drawing.Point(39, 49);
            this.CustomersLbl.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.CustomersLbl.Name = "CustomersLbl";
            this.CustomersLbl.Size = new System.Drawing.Size(218, 67);
            this.CustomersLbl.TabIndex = 43;
            this.CustomersLbl.Text = "Branch";
            // 
            // BranchFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(1233, 1050);
            this.Controls.Add(this.BranchManage);
            this.Controls.Add(this.BranchTable);
            this.Controls.Add(this.CustomersLbl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "BranchFrm";
            ((System.ComponentModel.ISupportInitialize)(this.BranchTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button BranchManage;
        private DataGridView BranchTable;
        private Label CustomersLbl;
    }
}