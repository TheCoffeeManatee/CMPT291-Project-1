namespace CMPT291_Project
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
            this.Reports = new System.Windows.Forms.TabControl();
            this.Report1 = new System.Windows.Forms.TabPage();
            this.Date2 = new System.Windows.Forms.Label();
            this.Date1 = new System.Windows.Forms.Label();
            this.ReportUpdate1 = new System.Windows.Forms.Button();
            this.DatePick1 = new System.Windows.Forms.DateTimePicker();
            this.DatePick2 = new System.Windows.Forms.DateTimePicker();
            this.Report2 = new System.Windows.Forms.TabPage();
            this.UpdateReport2 = new System.Windows.Forms.Button();
            this.DatePick4 = new System.Windows.Forms.DateTimePicker();
            this.DatePick3 = new System.Windows.Forms.DateTimePicker();
            this.Report3 = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.BranchBox3 = new System.Windows.Forms.ComboBox();
            this.Report4 = new System.Windows.Forms.TabPage();
            this.Report5 = new System.Windows.Forms.TabPage();
            this.Date3 = new System.Windows.Forms.Label();
            this.Date4 = new System.Windows.Forms.Label();
            this.Reports.SuspendLayout();
            this.Report1.SuspendLayout();
            this.Report2.SuspendLayout();
            this.Report3.SuspendLayout();
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
            // Reports
            // 
            this.Reports.Controls.Add(this.Report1);
            this.Reports.Controls.Add(this.Report2);
            this.Reports.Controls.Add(this.Report3);
            this.Reports.Controls.Add(this.Report4);
            this.Reports.Controls.Add(this.Report5);
            this.Reports.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Reports.Location = new System.Drawing.Point(20, 57);
            this.Reports.Name = "Reports";
            this.Reports.SelectedIndex = 0;
            this.Reports.Size = new System.Drawing.Size(632, 423);
            this.Reports.TabIndex = 9;
            // 
            // Report1
            // 
            this.Report1.BackColor = System.Drawing.Color.DimGray;
            this.Report1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Report1.Controls.Add(this.Date2);
            this.Report1.Controls.Add(this.Date1);
            this.Report1.Controls.Add(this.ReportUpdate1);
            this.Report1.Controls.Add(this.DatePick1);
            this.Report1.Controls.Add(this.DatePick2);
            this.Report1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Report1.Location = new System.Drawing.Point(4, 25);
            this.Report1.Name = "Report1";
            this.Report1.Padding = new System.Windows.Forms.Padding(3);
            this.Report1.Size = new System.Drawing.Size(624, 394);
            this.Report1.TabIndex = 0;
            this.Report1.Text = "Report 1";
            // 
            // Date2
            // 
            this.Date2.AutoSize = true;
            this.Date2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Date2.ForeColor = System.Drawing.Color.Red;
            this.Date2.Location = new System.Drawing.Point(267, 340);
            this.Date2.Name = "Date2";
            this.Date2.Size = new System.Drawing.Size(70, 25);
            this.Date2.TabIndex = 4;
            this.Date2.Text = "label2";
            this.Date2.Visible = false;
            // 
            // Date1
            // 
            this.Date1.AutoSize = true;
            this.Date1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Date1.ForeColor = System.Drawing.Color.Red;
            this.Date1.Location = new System.Drawing.Point(49, 340);
            this.Date1.Name = "Date1";
            this.Date1.Size = new System.Drawing.Size(70, 25);
            this.Date1.TabIndex = 3;
            this.Date1.Text = "label1";
            this.Date1.Visible = false;
            // 
            // ReportUpdate1
            // 
            this.ReportUpdate1.Location = new System.Drawing.Point(414, 358);
            this.ReportUpdate1.Name = "ReportUpdate1";
            this.ReportUpdate1.Size = new System.Drawing.Size(106, 32);
            this.ReportUpdate1.TabIndex = 2;
            this.ReportUpdate1.Text = "Update Report";
            this.ReportUpdate1.UseVisualStyleBackColor = true;
            this.ReportUpdate1.Click += new System.EventHandler(this.ReportUpdate1_Click);
            // 
            // DatePick1
            // 
            this.DatePick1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DatePick1.Location = new System.Drawing.Point(2, 368);
            this.DatePick1.Name = "DatePick1";
            this.DatePick1.Size = new System.Drawing.Size(200, 22);
            this.DatePick1.TabIndex = 1;
            // 
            // DatePick2
            // 
            this.DatePick2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DatePick2.Location = new System.Drawing.Point(208, 368);
            this.DatePick2.Name = "DatePick2";
            this.DatePick2.Size = new System.Drawing.Size(200, 22);
            this.DatePick2.TabIndex = 0;
            // 
            // Report2
            // 
            this.Report2.BackColor = System.Drawing.Color.DimGray;
            this.Report2.Controls.Add(this.Date4);
            this.Report2.Controls.Add(this.Date3);
            this.Report2.Controls.Add(this.UpdateReport2);
            this.Report2.Controls.Add(this.DatePick4);
            this.Report2.Controls.Add(this.DatePick3);
            this.Report2.Location = new System.Drawing.Point(4, 25);
            this.Report2.Name = "Report2";
            this.Report2.Padding = new System.Windows.Forms.Padding(3);
            this.Report2.Size = new System.Drawing.Size(624, 394);
            this.Report2.TabIndex = 1;
            this.Report2.Text = "Report 2";
            // 
            // UpdateReport2
            // 
            this.UpdateReport2.BackColor = System.Drawing.Color.Silver;
            this.UpdateReport2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.UpdateReport2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.UpdateReport2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.UpdateReport2.Location = new System.Drawing.Point(415, 359);
            this.UpdateReport2.Name = "UpdateReport2";
            this.UpdateReport2.Size = new System.Drawing.Size(106, 32);
            this.UpdateReport2.TabIndex = 2;
            this.UpdateReport2.Text = "Update Report";
            this.UpdateReport2.UseVisualStyleBackColor = false;
            this.UpdateReport2.Click += new System.EventHandler(this.UpdateReport2_Click);
            // 
            // DatePick4
            // 
            this.DatePick4.CalendarMonthBackground = System.Drawing.SystemColors.ControlDarkDark;
            this.DatePick4.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DatePick4.Location = new System.Drawing.Point(209, 369);
            this.DatePick4.Name = "DatePick4";
            this.DatePick4.Size = new System.Drawing.Size(200, 22);
            this.DatePick4.TabIndex = 1;
            // 
            // DatePick3
            // 
            this.DatePick3.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DatePick3.Location = new System.Drawing.Point(3, 369);
            this.DatePick3.Name = "DatePick3";
            this.DatePick3.Size = new System.Drawing.Size(200, 22);
            this.DatePick3.TabIndex = 0;
            // 
            // Report3
            // 
            this.Report3.BackColor = System.Drawing.Color.DimGray;
            this.Report3.Controls.Add(this.button1);
            this.Report3.Controls.Add(this.BranchBox3);
            this.Report3.Location = new System.Drawing.Point(4, 25);
            this.Report3.Name = "Report3";
            this.Report3.Padding = new System.Windows.Forms.Padding(3);
            this.Report3.Size = new System.Drawing.Size(624, 394);
            this.Report3.TabIndex = 2;
            this.Report3.Text = "Report 3";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(177, 356);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(106, 32);
            this.button1.TabIndex = 1;
            this.button1.Text = "Update Report";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // BranchBox3
            // 
            this.BranchBox3.FormattingEnabled = true;
            this.BranchBox3.Location = new System.Drawing.Point(6, 364);
            this.BranchBox3.Name = "BranchBox3";
            this.BranchBox3.Size = new System.Drawing.Size(165, 24);
            this.BranchBox3.TabIndex = 0;
            // 
            // Report4
            // 
            this.Report4.BackColor = System.Drawing.Color.DimGray;
            this.Report4.Location = new System.Drawing.Point(4, 25);
            this.Report4.Name = "Report4";
            this.Report4.Padding = new System.Windows.Forms.Padding(3);
            this.Report4.Size = new System.Drawing.Size(624, 394);
            this.Report4.TabIndex = 3;
            this.Report4.Text = "Report 4";
            // 
            // Report5
            // 
            this.Report5.BackColor = System.Drawing.Color.DimGray;
            this.Report5.Location = new System.Drawing.Point(4, 25);
            this.Report5.Name = "Report5";
            this.Report5.Padding = new System.Windows.Forms.Padding(3);
            this.Report5.Size = new System.Drawing.Size(624, 394);
            this.Report5.TabIndex = 4;
            this.Report5.Text = "Report 5";
            // 
            // Date3
            // 
            this.Date3.AutoSize = true;
            this.Date3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Date3.ForeColor = System.Drawing.Color.Red;
            this.Date3.Location = new System.Drawing.Point(50, 332);
            this.Date3.Name = "Date3";
            this.Date3.Size = new System.Drawing.Size(70, 25);
            this.Date3.TabIndex = 3;
            this.Date3.Text = "label1";
            this.Date3.Visible = false;
            // 
            // Date4
            // 
            this.Date4.AutoSize = true;
            this.Date4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Date4.ForeColor = System.Drawing.Color.Red;
            this.Date4.Location = new System.Drawing.Point(270, 332);
            this.Date4.Name = "Date4";
            this.Date4.Size = new System.Drawing.Size(70, 25);
            this.Date4.TabIndex = 4;
            this.Date4.Text = "label2";
            this.Date4.Visible = false;
            // 
            // ReportsFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(664, 492);
            this.Controls.Add(this.Reports);
            this.Controls.Add(this.ReportsLbl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ReportsFrm";
            this.Text = "ReportsFrm";
            this.Reports.ResumeLayout(false);
            this.Report1.ResumeLayout(false);
            this.Report1.PerformLayout();
            this.Report2.ResumeLayout(false);
            this.Report2.PerformLayout();
            this.Report3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label ReportsLbl;
        private TabControl Reports;
        private TabPage Report1;
        private TabPage Report2;
        private TabPage Report3;
        private TabPage Report4;
        private TabPage Report5;
        private Button ReportUpdate1;
        private DateTimePicker DatePick1;
        private DateTimePicker DatePick2;
        private DateTimePicker DatePick3;
        private DateTimePicker DatePick4;
        private Button UpdateReport2;
        private Button button1;
        private ComboBox BranchBox3;
        private Label Date2;
        private Label Date1;
        private Label Date4;
        private Label Date3;
    }
}