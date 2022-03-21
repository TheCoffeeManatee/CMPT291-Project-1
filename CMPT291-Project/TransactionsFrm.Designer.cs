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
            this.TransactionsFrmLbl = new System.Windows.Forms.Label();
            this.TransPnl = new System.Windows.Forms.Panel();
            this.AddTransBtn = new System.Windows.Forms.Button();
            this.SearchBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TransactionsFrmLbl
            // 
            this.TransactionsFrmLbl.AutoSize = true;
            this.TransactionsFrmLbl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.TransactionsFrmLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.TransactionsFrmLbl.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.TransactionsFrmLbl.Location = new System.Drawing.Point(35, 41);
            this.TransactionsFrmLbl.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.TransactionsFrmLbl.Name = "TransactionsFrmLbl";
            this.TransactionsFrmLbl.Size = new System.Drawing.Size(371, 67);
            this.TransactionsFrmLbl.TabIndex = 5;
            this.TransactionsFrmLbl.Text = "Transactions";
            // 
            // TransPnl
            // 
            this.TransPnl.Location = new System.Drawing.Point(0, 149);
            this.TransPnl.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.TransPnl.Name = "TransPnl";
            this.TransPnl.Size = new System.Drawing.Size(1233, 900);
            this.TransPnl.TabIndex = 6;
            // 
            // AddTransBtn
            // 
            this.AddTransBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(79)))), ((int)(((byte)(99)))));
            this.AddTransBtn.FlatAppearance.BorderSize = 0;
            this.AddTransBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddTransBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.AddTransBtn.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.AddTransBtn.Location = new System.Drawing.Point(418, 41);
            this.AddTransBtn.Margin = new System.Windows.Forms.Padding(6);
            this.AddTransBtn.Name = "AddTransBtn";
            this.AddTransBtn.Size = new System.Drawing.Size(169, 64);
            this.AddTransBtn.TabIndex = 28;
            this.AddTransBtn.Text = "Add";
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
            this.SearchBtn.Location = new System.Drawing.Point(599, 41);
            this.SearchBtn.Margin = new System.Windows.Forms.Padding(6);
            this.SearchBtn.Name = "SearchBtn";
            this.SearchBtn.Size = new System.Drawing.Size(169, 64);
            this.SearchBtn.TabIndex = 29;
            this.SearchBtn.Text = "Search";
            this.SearchBtn.UseVisualStyleBackColor = false;
            this.SearchBtn.Click += new System.EventHandler(this.SearchBtn_Click_1);
            // 
            // TransactionsFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(1233, 1050);
            this.Controls.Add(this.AddTransBtn);
            this.Controls.Add(this.SearchBtn);
            this.Controls.Add(this.TransPnl);
            this.Controls.Add(this.TransactionsFrmLbl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "TransactionsFrm";
            this.Text = "TransactionsFrm";
            this.Load += new System.EventHandler(this.HomeFrm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label TransactionsFrmLbl;
        private Panel TransPnl;
        private Button AddTransBtn;
        private Button SearchBtn;
    }
}