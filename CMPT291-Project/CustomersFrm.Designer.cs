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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.CustomerPanel = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.CustData = new System.Windows.Forms.DataGridView();
            this.CustomersLbl = new System.Windows.Forms.Label();
            this.CustomerPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CustData)).BeginInit();
            this.SuspendLayout();
            // 
            // CustomerPanel
            // 
            this.CustomerPanel.Controls.Add(this.button3);
            this.CustomerPanel.Controls.Add(this.button2);
            this.CustomerPanel.Controls.Add(this.CustData);
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
            this.button3.Text = "Manage";
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
            this.button2.Text = "Search";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // CustData
            // 
            this.CustData.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.CustData.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(79)))), ((int)(((byte)(99)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ScrollBar;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.CustData.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.CustData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(79)))), ((int)(((byte)(99)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ScrollBar;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.CustData.DefaultCellStyle = dataGridViewCellStyle5;
            this.CustData.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.CustData.Location = new System.Drawing.Point(39, 312);
            this.CustData.Margin = new System.Windows.Forms.Padding(6);
            this.CustData.Name = "CustData";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(79)))), ((int)(((byte)(99)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.CustData.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.CustData.RowHeadersVisible = false;
            this.CustData.RowHeadersWidth = 82;
            this.CustData.RowTemplate.Height = 50;
            this.CustData.Size = new System.Drawing.Size(1155, 690);
            this.CustData.TabIndex = 18;
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
            ((System.ComponentModel.ISupportInitialize)(this.CustData)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel CustomerPanel;
        private Button button3;
        private Button button2;
        private DataGridView CustData;
        private Label CustomersLbl;
    }
}