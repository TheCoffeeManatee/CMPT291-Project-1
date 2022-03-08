namespace Lab6_Modern
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TransactionsFrm));
            this.TransactionsFrmLbl = new System.Windows.Forms.Label();
            this.TransPnl = new System.Windows.Forms.Panel();
            this.SearchBtn = new System.Windows.Forms.Button();
            this.NewTransBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TransactionsFrmLbl
            // 
            this.TransactionsFrmLbl.AutoSize = true;
            this.TransactionsFrmLbl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.TransactionsFrmLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.TransactionsFrmLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.TransactionsFrmLbl.Location = new System.Drawing.Point(32, 38);
            this.TransactionsFrmLbl.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.TransactionsFrmLbl.Name = "TransactionsFrmLbl";
            this.TransactionsFrmLbl.Size = new System.Drawing.Size(328, 59);
            this.TransactionsFrmLbl.TabIndex = 5;
            this.TransactionsFrmLbl.Text = "Transactions";
            // 
            // TransPnl
            // 
            this.TransPnl.Location = new System.Drawing.Point(0, 140);
            this.TransPnl.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.TransPnl.Name = "TransPnl";
            this.TransPnl.Size = new System.Drawing.Size(1138, 844);
            this.TransPnl.TabIndex = 6;
            // 
            // SearchBtn
            // 
            this.SearchBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SearchBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("SearchBtn.BackgroundImage")));
            this.SearchBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.SearchBtn.FlatAppearance.BorderSize = 0;
            this.SearchBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SearchBtn.Location = new System.Drawing.Point(436, 50);
            this.SearchBtn.Margin = new System.Windows.Forms.Padding(6);
            this.SearchBtn.Name = "SearchBtn";
            this.SearchBtn.Size = new System.Drawing.Size(38, 38);
            this.SearchBtn.TabIndex = 33;
            this.SearchBtn.UseVisualStyleBackColor = true;
            this.SearchBtn.Click += new System.EventHandler(this.SearchBtn_Click);
            // 
            // NewTransBtn
            // 
            this.NewTransBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.NewTransBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("NewTransBtn.BackgroundImage")));
            this.NewTransBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.NewTransBtn.FlatAppearance.BorderSize = 0;
            this.NewTransBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NewTransBtn.Location = new System.Drawing.Point(388, 50);
            this.NewTransBtn.Margin = new System.Windows.Forms.Padding(6);
            this.NewTransBtn.Name = "NewTransBtn";
            this.NewTransBtn.Size = new System.Drawing.Size(38, 38);
            this.NewTransBtn.TabIndex = 32;
            this.NewTransBtn.UseVisualStyleBackColor = true;
            this.NewTransBtn.Click += new System.EventHandler(this.NewTransBtn_Click);
            // 
            // TransactionsFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(1138, 984);
            this.Controls.Add(this.SearchBtn);
            this.Controls.Add(this.NewTransBtn);
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
        private Button SearchBtn;
        private Button NewTransBtn;
    }
}