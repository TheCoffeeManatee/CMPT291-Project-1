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
            this.QueryLbl = new System.Windows.Forms.Label();
            this.student = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Grade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.operation = new System.Windows.Forms.ComboBox();
            this.SGrade = new System.Windows.Forms.TextBox();
            this.Gradelbl = new System.Windows.Forms.Label();
            this.QueryBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.student)).BeginInit();
            this.SuspendLayout();
            // 
            // QueryLbl
            // 
            this.QueryLbl.AutoSize = true;
            this.QueryLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.QueryLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.QueryLbl.Location = new System.Drawing.Point(20, 21);
            this.QueryLbl.Name = "QueryLbl";
            this.QueryLbl.Size = new System.Drawing.Size(100, 33);
            this.QueryLbl.TabIndex = 7;
            this.QueryLbl.Text = "Query";
            // 
            // student
            // 
            this.student.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.student.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.student.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Name,
            this.Grade});
            this.student.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(79)))), ((int)(((byte)(99)))));
            this.student.Location = new System.Drawing.Point(41, 78);
            this.student.Name = "student";
            this.student.RowTemplate.Height = 25;
            this.student.Size = new System.Drawing.Size(345, 259);
            this.student.TabIndex = 8;
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            // 
            // Name
            // 
            this.Name.HeaderText = "Name";
            this.Name.Name = "Name";
            // 
            // Grade
            // 
            this.Grade.HeaderText = "Grade";
            this.Grade.Name = "Grade";
            // 
            // operation
            // 
            this.operation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(79)))), ((int)(((byte)(99)))));
            this.operation.FormattingEnabled = true;
            this.operation.Items.AddRange(new object[] {
            "Show all",
            "Show with starting grade: "});
            this.operation.Location = new System.Drawing.Point(40, 364);
            this.operation.Name = "operation";
            this.operation.Size = new System.Drawing.Size(346, 23);
            this.operation.TabIndex = 9;
            // 
            // SGrade
            // 
            this.SGrade.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(79)))), ((int)(((byte)(99)))));
            this.SGrade.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.SGrade.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SGrade.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.SGrade.Location = new System.Drawing.Point(115, 411);
            this.SGrade.Name = "SGrade";
            this.SGrade.Size = new System.Drawing.Size(115, 22);
            this.SGrade.TabIndex = 14;
            this.SGrade.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Gradelbl
            // 
            this.Gradelbl.AutoSize = true;
            this.Gradelbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Gradelbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.Gradelbl.Location = new System.Drawing.Point(41, 411);
            this.Gradelbl.Name = "Gradelbl";
            this.Gradelbl.Size = new System.Drawing.Size(77, 25);
            this.Gradelbl.TabIndex = 13;
            this.Gradelbl.Text = "Grade:";
            // 
            // QueryBtn
            // 
            this.QueryBtn.FlatAppearance.BorderColor = System.Drawing.SystemColors.ScrollBar;
            this.QueryBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.QueryBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.QueryBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.QueryBtn.Location = new System.Drawing.Point(236, 405);
            this.QueryBtn.Name = "QueryBtn";
            this.QueryBtn.Size = new System.Drawing.Size(148, 38);
            this.QueryBtn.TabIndex = 15;
            this.QueryBtn.Text = "Query";
            this.QueryBtn.UseVisualStyleBackColor = true;
            this.QueryBtn.Click += new System.EventHandler(this.QueryBtn_Click);
            // 
            // QueryFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(664, 492);
            this.Controls.Add(this.QueryBtn);
            this.Controls.Add(this.SGrade);
            this.Controls.Add(this.Gradelbl);
            this.Controls.Add(this.operation);
            this.Controls.Add(this.student);
            this.Controls.Add(this.QueryLbl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QueryFrm";
            this.Load += new System.EventHandler(this.QueryFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.student)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label QueryLbl;
        private DataGridView student;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn Name;
        private DataGridViewTextBoxColumn Grade;
        private ComboBox operation;
        private TextBox SGrade;
        private Label Gradelbl;
        private Button QueryBtn;
    }
}