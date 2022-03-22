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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.CarTypePanel = new System.Windows.Forms.Panel();
            this.Search = new System.Windows.Forms.Button();
            this.CarTypeAdd = new System.Windows.Forms.Button();
            this.CarTypeData = new System.Windows.Forms.DataGridView();
            this.CarTypeLbl = new System.Windows.Forms.Label();
            this.CarTypePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CarTypeData)).BeginInit();
            this.SuspendLayout();
            // 
            // CarTypePanel
            // 
            this.CarTypePanel.Controls.Add(this.Search);
            this.CarTypePanel.Controls.Add(this.CarTypeAdd);
            this.CarTypePanel.Controls.Add(this.CarTypeData);
            this.CarTypePanel.Controls.Add(this.CarTypeLbl);
            this.CarTypePanel.Location = new System.Drawing.Point(0, 0);
            this.CarTypePanel.Margin = new System.Windows.Forms.Padding(6);
            this.CarTypePanel.Name = "CarTypePanel";
            this.CarTypePanel.Size = new System.Drawing.Size(1233, 1050);
            this.CarTypePanel.TabIndex = 0;
            // 
            // Search
            // 
            this.Search.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(79)))), ((int)(((byte)(99)))));
            this.Search.FlatAppearance.BorderSize = 0;
            this.Search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Search.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Search.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.Search.Location = new System.Drawing.Point(235, 173);
            this.Search.Margin = new System.Windows.Forms.Padding(6);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(169, 64);
            this.Search.TabIndex = 29;
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
            this.CarTypeAdd.Location = new System.Drawing.Point(39, 173);
            this.CarTypeAdd.Margin = new System.Windows.Forms.Padding(6);
            this.CarTypeAdd.Name = "CarTypeAdd";
            this.CarTypeAdd.Size = new System.Drawing.Size(169, 64);
            this.CarTypeAdd.TabIndex = 27;
            this.CarTypeAdd.Text = "Manage";
            this.CarTypeAdd.UseVisualStyleBackColor = false;
            this.CarTypeAdd.Click += new System.EventHandler(this.CarTypeAdd_Click);
            // 
            // CarTypeData
            // 
            this.CarTypeData.AllowUserToOrderColumns = true;
            this.CarTypeData.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.CarTypeData.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(79)))), ((int)(((byte)(99)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ScrollBar;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.CarTypeData.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.CarTypeData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(79)))), ((int)(((byte)(99)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ScrollBar;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.CarTypeData.DefaultCellStyle = dataGridViewCellStyle2;
            this.CarTypeData.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.CarTypeData.Location = new System.Drawing.Point(39, 312);
            this.CarTypeData.Margin = new System.Windows.Forms.Padding(6);
            this.CarTypeData.Name = "CarTypeData";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(79)))), ((int)(((byte)(99)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.CarTypeData.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.CarTypeData.RowHeadersVisible = false;
            this.CarTypeData.RowHeadersWidth = 82;
            this.CarTypeData.RowTemplate.Height = 50;
            this.CarTypeData.Size = new System.Drawing.Size(1155, 690);
            this.CarTypeData.TabIndex = 25;
            // 
            // CarTypeLbl
            // 
            this.CarTypeLbl.AutoSize = true;
            this.CarTypeLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.CarTypeLbl.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.CarTypeLbl.Location = new System.Drawing.Point(39, 49);
            this.CarTypeLbl.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.CarTypeLbl.Name = "CarTypeLbl";
            this.CarTypeLbl.Size = new System.Drawing.Size(273, 67);
            this.CarTypeLbl.TabIndex = 21;
            this.CarTypeLbl.Text = "Car Type";
            // 
            // CarTypeFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.ClientSize = new System.Drawing.Size(1233, 1050);
            this.Controls.Add(this.CarTypePanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "CarTypeFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QueryFrm";
            this.Load += new System.EventHandler(this.QueryFrm_Load);
            this.CarTypePanel.ResumeLayout(false);
            this.CarTypePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CarTypeData)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel CarTypePanel;
        private Button CarTypeAdd;
        private Label CarTypeLbl;
        private DataGridView CarTypeData;
        private Button Search;
    }
}