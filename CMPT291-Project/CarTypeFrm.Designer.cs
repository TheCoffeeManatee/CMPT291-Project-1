namespace CMPT291_Project
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Search = new System.Windows.Forms.Button();
            this.CarTypeAdd = new System.Windows.Forms.Button();
            this.CarTypeData = new System.Windows.Forms.DataGridView();
            this.CarTypeLbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.CarTypeData)).BeginInit();
            this.SuspendLayout();
            // 
            // Search
            // 
            this.Search.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(79)))), ((int)(((byte)(99)))));
            this.Search.FlatAppearance.BorderSize = 0;
            this.Search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Search.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Search.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.Search.Location = new System.Drawing.Point(127, 81);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(91, 30);
            this.Search.TabIndex = 33;
            this.Search.Text = "Search";
            this.Search.UseVisualStyleBackColor = false;
            // 
            // CarTypeAdd
            // 
            this.CarTypeAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(79)))), ((int)(((byte)(99)))));
            this.CarTypeAdd.FlatAppearance.BorderSize = 0;
            this.CarTypeAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CarTypeAdd.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.CarTypeAdd.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.CarTypeAdd.Location = new System.Drawing.Point(21, 81);
            this.CarTypeAdd.Name = "CarTypeAdd";
            this.CarTypeAdd.Size = new System.Drawing.Size(91, 30);
            this.CarTypeAdd.TabIndex = 32;
            this.CarTypeAdd.Text = "Manage";
            this.CarTypeAdd.UseVisualStyleBackColor = false;
            this.CarTypeAdd.Click += new System.EventHandler(this.CarTypeAdd_Click_1);
            // 
            // CarTypeData
            // 
            this.CarTypeData.AllowUserToAddRows = false;
            this.CarTypeData.AllowUserToDeleteRows = false;
            this.CarTypeData.AllowUserToOrderColumns = true;
            this.CarTypeData.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.CarTypeData.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(79)))), ((int)(((byte)(99)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ScrollBar;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.CarTypeData.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.CarTypeData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(79)))), ((int)(((byte)(99)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ScrollBar;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.CarTypeData.DefaultCellStyle = dataGridViewCellStyle5;
            this.CarTypeData.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.CarTypeData.Location = new System.Drawing.Point(21, 146);
            this.CarTypeData.Name = "CarTypeData";
            this.CarTypeData.ReadOnly = true;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(79)))), ((int)(((byte)(99)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.CarTypeData.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.CarTypeData.RowHeadersVisible = false;
            this.CarTypeData.RowHeadersWidth = 82;
            this.CarTypeData.RowTemplate.Height = 50;
            this.CarTypeData.Size = new System.Drawing.Size(622, 323);
            this.CarTypeData.TabIndex = 31;
            // 
            // CarTypeLbl
            // 
            this.CarTypeLbl.AutoSize = true;
            this.CarTypeLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.CarTypeLbl.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.CarTypeLbl.Location = new System.Drawing.Point(21, 23);
            this.CarTypeLbl.Name = "CarTypeLbl";
            this.CarTypeLbl.Size = new System.Drawing.Size(143, 33);
            this.CarTypeLbl.TabIndex = 30;
            this.CarTypeLbl.Text = "Car Type";
            // 
            // CarTypeFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.ClientSize = new System.Drawing.Size(664, 492);
            this.Controls.Add(this.Search);
            this.Controls.Add(this.CarTypeAdd);
            this.Controls.Add(this.CarTypeData);
            this.Controls.Add(this.CarTypeLbl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CarTypeFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QueryFrm";
            this.Load += new System.EventHandler(this.QueryFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CarTypeData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button Search;
        private Button CarTypeAdd;
        private DataGridView CarTypeData;
        private Label CarTypeLbl;
    }
}