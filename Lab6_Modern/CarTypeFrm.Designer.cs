namespace Lab6_Modern
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
            this.CarTypeLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CarTypeLbl
            // 
            this.CarTypeLbl.AutoSize = true;
            this.CarTypeLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.CarTypeLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.CarTypeLbl.Location = new System.Drawing.Point(20, 21);
            this.CarTypeLbl.Name = "CarTypeLbl";
            this.CarTypeLbl.Size = new System.Drawing.Size(143, 33);
            this.CarTypeLbl.TabIndex = 7;
            this.CarTypeLbl.Text = "Car Type";
            this.CarTypeLbl.Click += new System.EventHandler(this.QueryLbl_Click);
            // 
            // CarTypeFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(664, 492);
            this.Controls.Add(this.CarTypeLbl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CarTypeFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QueryFrm";
            this.Load += new System.EventHandler(this.QueryFrm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label CarTypeLbl;
    }
}