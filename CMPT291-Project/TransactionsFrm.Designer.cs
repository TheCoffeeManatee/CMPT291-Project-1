namespace CMPT291_Project
{
    partial class TransactionsFrm
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
            this.TransactionsFrmLbl = new System.Windows.Forms.Label();
            this.AddTransBtn = new System.Windows.Forms.Button();
            this.SearchBtn = new System.Windows.Forms.Button();
            this.TransPnl = new System.Windows.Forms.Panel();
            this.TransData = new System.Windows.Forms.DataGridView();
            this.TransPnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TransData)).BeginInit();
            this.SuspendLayout();
            // 
            // TransactionsFrmLbl
            // 
            this.TransactionsFrmLbl.AutoSize = true;
            this.TransactionsFrmLbl.BackColor = System.Drawing.Color.Transparent;
            this.TransactionsFrmLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.TransactionsFrmLbl.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.TransactionsFrmLbl.Location = new System.Drawing.Point(19, 19);
            this.TransactionsFrmLbl.Name = "TransactionsFrmLbl";
            this.TransactionsFrmLbl.Size = new System.Drawing.Size(195, 33);
            this.TransactionsFrmLbl.TabIndex = 5;
            this.TransactionsFrmLbl.Text = "Transactions";
            // 
            // AddTransBtn
            // 
            this.AddTransBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(79)))), ((int)(((byte)(99)))));
            this.AddTransBtn.FlatAppearance.BorderSize = 0;
            this.AddTransBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddTransBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.AddTransBtn.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.AddTransBtn.Location = new System.Drawing.Point(21, 81);
            this.AddTransBtn.Name = "AddTransBtn";
            this.AddTransBtn.Size = new System.Drawing.Size(91, 30);
            this.AddTransBtn.TabIndex = 28;
            this.AddTransBtn.Text = "Manage";
            this.AddTransBtn.UseVisualStyleBackColor = false;
            this.AddTransBtn.Click += new System.EventHandler(this.AddTransBtn_Click);
            // 
            // SearchBtn
            // 
            this.SearchBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(79)))), ((int)(((byte)(99)))));
            this.SearchBtn.FlatAppearance.BorderSize = 0;
            this.SearchBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SearchBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.SearchBtn.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.SearchBtn.Location = new System.Drawing.Point(135, 81);
            this.SearchBtn.Name = "SearchBtn";
            this.SearchBtn.Size = new System.Drawing.Size(91, 30);
            this.SearchBtn.TabIndex = 29;
            this.SearchBtn.Text = "Search";
            this.SearchBtn.UseVisualStyleBackColor = false;
            this.SearchBtn.Click += new System.EventHandler(this.SearchBtn_Click_1);
            // 
            // TransPnl
            // 
            this.TransPnl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.TransPnl.Controls.Add(this.TransData);
            this.TransPnl.Location = new System.Drawing.Point(0, 0);
            this.TransPnl.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.TransPnl.Name = "TransPnl";
            this.TransPnl.Size = new System.Drawing.Size(664, 492);
            this.TransPnl.TabIndex = 6;
            // 
            // TransData
            // 
            this.TransData.AllowUserToAddRows = false;
            this.TransData.AllowUserToDeleteRows = false;
            this.TransData.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.TransData.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(79)))), ((int)(((byte)(99)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ScrollBar;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.TransData.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.TransData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(79)))), ((int)(((byte)(99)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ScrollBar;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.TransData.DefaultCellStyle = dataGridViewCellStyle5;
            this.TransData.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.TransData.Location = new System.Drawing.Point(19, 144);
            this.TransData.Name = "TransData";
            this.TransData.ReadOnly = true;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(79)))), ((int)(((byte)(99)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.TransData.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.TransData.RowHeadersVisible = false;
            this.TransData.RowHeadersWidth = 82;
            this.TransData.RowTemplate.Height = 50;
            this.TransData.Size = new System.Drawing.Size(622, 323);
            this.TransData.TabIndex = 30;
            // 
            // TransactionsFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.ClientSize = new System.Drawing.Size(664, 492);
            this.Controls.Add(this.AddTransBtn);
            this.Controls.Add(this.SearchBtn);
            this.Controls.Add(this.TransactionsFrmLbl);
            this.Controls.Add(this.TransPnl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TransactionsFrm";
            this.Text = "TransactionsFrm";
            this.Load += new System.EventHandler(this.HomeFrm_Load);
            this.TransPnl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.TransData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label TransactionsFrmLbl;
        private Button AddTransBtn;
        private Button SearchBtn;
        private Panel TransPnl;
        private DataGridView TransData;
    }
}