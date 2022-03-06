namespace Lab6_Modern
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
            this.BranchLbl = new System.Windows.Forms.Label();
            this.HomeFormPanel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // BranchLbl
            // 
            this.BranchLbl.AutoSize = true;
            this.BranchLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BranchLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.BranchLbl.Location = new System.Drawing.Point(20, 21);
            this.BranchLbl.Name = "BranchLbl";
            this.BranchLbl.Size = new System.Drawing.Size(113, 33);
            this.BranchLbl.TabIndex = 6;
            this.BranchLbl.Text = "Branch";
            // 
            // HomeFormPanel1
            // 
            this.HomeFormPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.HomeFormPanel1.Location = new System.Drawing.Point(43, 95);
            this.HomeFormPanel1.Name = "HomeFormPanel1";
            this.HomeFormPanel1.Size = new System.Drawing.Size(316, 263);
            this.HomeFormPanel1.TabIndex = 13;
            this.HomeFormPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.HomeFormPanel1_Paint);
            // 
            // BranchFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(664, 492);
            this.Controls.Add(this.HomeFormPanel1);
            this.Controls.Add(this.BranchLbl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "BranchFrm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label BranchLbl;
        private Panel HomeFormPanel1;
    }
}