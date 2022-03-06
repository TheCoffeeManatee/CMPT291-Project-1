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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.TransactionsFrmLbl = new System.Windows.Forms.Label();
            this.HomeFormPanel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.flowLayoutPanel1.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(393, 95);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(248, 376);
            this.flowLayoutPanel1.TabIndex = 8;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.panel3.Location = new System.Drawing.Point(43, 349);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(327, 122);
            this.panel3.TabIndex = 7;
            // 
            // TransactionsFrmLbl
            // 
            this.TransactionsFrmLbl.AutoSize = true;
            this.TransactionsFrmLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.TransactionsFrmLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.TransactionsFrmLbl.Location = new System.Drawing.Point(20, 21);
            this.TransactionsFrmLbl.Name = "TransactionsFrmLbl";
            this.TransactionsFrmLbl.Size = new System.Drawing.Size(195, 33);
            this.TransactionsFrmLbl.TabIndex = 5;
            this.TransactionsFrmLbl.Text = "Transactions";
            // 
            // HomeFormPanel1
            // 
            this.HomeFormPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.HomeFormPanel1.Location = new System.Drawing.Point(43, 95);
            this.HomeFormPanel1.Name = "HomeFormPanel1";
            this.HomeFormPanel1.Size = new System.Drawing.Size(327, 231);
            this.HomeFormPanel1.TabIndex = 6;
            // 
            // TransactionsFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(664, 492);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.TransactionsFrmLbl);
            this.Controls.Add(this.HomeFormPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TransactionsFrm";
            this.Text = "HomeFrm";
            this.Load += new System.EventHandler(this.HomeFrm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FlowLayoutPanel flowLayoutPanel1;
        private Panel panel3;
        private Label TransactionsFrmLbl;
        private Panel HomeFormPanel1;
    }
}