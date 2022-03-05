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
            this.InsertLbl = new System.Windows.Forms.Label();
            this.Name = new System.Windows.Forms.TextBox();
            this.ID = new System.Windows.Forms.TextBox();
            this.Namelbl = new System.Windows.Forms.Label();
            this.IDlbl = new System.Windows.Forms.Label();
            this.Grade = new System.Windows.Forms.TextBox();
            this.Gradelbl = new System.Windows.Forms.Label();
            this.HomeFormPanel1 = new System.Windows.Forms.Panel();
            this.InsertBtn = new System.Windows.Forms.Button();
            this.HomeFormPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // InsertLbl
            // 
            this.InsertLbl.AutoSize = true;
            this.InsertLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.InsertLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.InsertLbl.Location = new System.Drawing.Point(20, 21);
            this.InsertLbl.Name = "InsertLbl";
            this.InsertLbl.Size = new System.Drawing.Size(94, 33);
            this.InsertLbl.TabIndex = 6;
            this.InsertLbl.Text = "Insert";
            // 
            // Name
            // 
            this.Name.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(79)))), ((int)(((byte)(99)))));
            this.Name.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Name.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Name.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.Name.Location = new System.Drawing.Point(112, 66);
            this.Name.Name = "Name";
            this.Name.Size = new System.Drawing.Size(115, 22);
            this.Name.TabIndex = 10;
            this.Name.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ID
            // 
            this.ID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(79)))), ((int)(((byte)(99)))));
            this.ID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ID.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ID.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.ID.Location = new System.Drawing.Point(112, 29);
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(115, 22);
            this.ID.TabIndex = 9;
            this.ID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Namelbl
            // 
            this.Namelbl.AutoSize = true;
            this.Namelbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Namelbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.Namelbl.Location = new System.Drawing.Point(38, 66);
            this.Namelbl.Name = "Namelbl";
            this.Namelbl.Size = new System.Drawing.Size(74, 25);
            this.Namelbl.TabIndex = 8;
            this.Namelbl.Text = "Name:";
            // 
            // IDlbl
            // 
            this.IDlbl.AutoSize = true;
            this.IDlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.IDlbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.IDlbl.Location = new System.Drawing.Point(38, 26);
            this.IDlbl.Name = "IDlbl";
            this.IDlbl.Size = new System.Drawing.Size(38, 25);
            this.IDlbl.TabIndex = 7;
            this.IDlbl.Text = "ID:";
            this.IDlbl.Click += new System.EventHandler(this.label1_Click);
            // 
            // Grade
            // 
            this.Grade.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(79)))), ((int)(((byte)(99)))));
            this.Grade.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Grade.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Grade.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.Grade.Location = new System.Drawing.Point(112, 104);
            this.Grade.Name = "Grade";
            this.Grade.Size = new System.Drawing.Size(115, 22);
            this.Grade.TabIndex = 12;
            this.Grade.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Gradelbl
            // 
            this.Gradelbl.AutoSize = true;
            this.Gradelbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Gradelbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.Gradelbl.Location = new System.Drawing.Point(38, 104);
            this.Gradelbl.Name = "Gradelbl";
            this.Gradelbl.Size = new System.Drawing.Size(77, 25);
            this.Gradelbl.TabIndex = 11;
            this.Gradelbl.Text = "Grade:";
            // 
            // HomeFormPanel1
            // 
            this.HomeFormPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.HomeFormPanel1.Controls.Add(this.InsertBtn);
            this.HomeFormPanel1.Controls.Add(this.ID);
            this.HomeFormPanel1.Controls.Add(this.Grade);
            this.HomeFormPanel1.Controls.Add(this.IDlbl);
            this.HomeFormPanel1.Controls.Add(this.Gradelbl);
            this.HomeFormPanel1.Controls.Add(this.Namelbl);
            this.HomeFormPanel1.Controls.Add(this.Name);
            this.HomeFormPanel1.Location = new System.Drawing.Point(43, 95);
            this.HomeFormPanel1.Name = "HomeFormPanel1";
            this.HomeFormPanel1.Size = new System.Drawing.Size(316, 263);
            this.HomeFormPanel1.TabIndex = 13;
            this.HomeFormPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.HomeFormPanel1_Paint);
            // 
            // InsertBtn
            // 
            this.InsertBtn.FlatAppearance.BorderColor = System.Drawing.SystemColors.ScrollBar;
            this.InsertBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.InsertBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.InsertBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.InsertBtn.Location = new System.Drawing.Point(79, 168);
            this.InsertBtn.Name = "InsertBtn";
            this.InsertBtn.Size = new System.Drawing.Size(148, 38);
            this.InsertBtn.TabIndex = 13;
            this.InsertBtn.Text = "Insert";
            this.InsertBtn.UseVisualStyleBackColor = true;
            this.InsertBtn.Click += new System.EventHandler(this.InsertBtn_Click);
            // 
            // InsertFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(664, 492);
            this.Controls.Add(this.HomeFormPanel1);
            this.Controls.Add(this.InsertLbl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.HomeFormPanel1.ResumeLayout(false);
            this.HomeFormPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label InsertLbl;
        private TextBox Name;
        private TextBox ID;
        private Label Namelbl;
        private Label IDlbl;
        private TextBox Grade;
        private Label Gradelbl;
        private Panel HomeFormPanel1;
        private Button InsertBtn;
    }
}