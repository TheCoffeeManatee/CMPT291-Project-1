namespace Lab6_Modern
{
    partial class ReportsFrm
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
            this.ReportsLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ReportsLbl
            // 
            this.ReportsLbl.AutoSize = true;
            this.ReportsLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ReportsLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.ReportsLbl.Location = new System.Drawing.Point(20, 21);
            this.ReportsLbl.Name = "ReportsLbl";
            this.ReportsLbl.Size = new System.Drawing.Size(124, 33);
            this.ReportsLbl.TabIndex = 8;
            this.ReportsLbl.Text = "Reports";
            // 
            // ReportsFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(664, 492);
            this.Controls.Add(this.ReportsLbl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ReportsFrm";
            this.Text = "ReportsFrm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label ReportsLbl;
    }
}