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
            this.Info1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.VIN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DailyRate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PricePerWeek = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MonthlyRate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ReportUpdate1 = new System.Windows.Forms.Button();
            this.DatePick1 = new System.Windows.Forms.DateTimePicker();
            this.DatePick2 = new System.Windows.Forms.DateTimePicker();
            this.Report2 = new System.Windows.Forms.TabPage();
            this.Info2 = new System.Windows.Forms.Button();
            this.YearBox2 = new System.Windows.Forms.ComboBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.BranchID2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BranchName2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalRentYear = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalMoney = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UpdateReport2 = new System.Windows.Forms.Button();
            this.Report3 = new System.Windows.Forms.TabPage();
            this.info3 = new System.Windows.Forms.Button();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.BranchID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BranchName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.YearBox1 = new System.Windows.Forms.ComboBox();
            this.UpdateButton3 = new System.Windows.Forms.Button();
            this.MonthBox3 = new System.Windows.Forms.ComboBox();
            this.Report4 = new System.Windows.Forms.TabPage();
            this.info4 = new System.Windows.Forms.Button();
            this.UpdateButton4 = new System.Windows.Forms.Button();
            this.dataGridView4 = new System.Windows.Forms.DataGridView();
            this.CustomerID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MiddleName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NumberOfRentals = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Report5 = new System.Windows.Forms.TabPage();
            this.info5 = new System.Windows.Forms.Button();
            this.UpdateReport5 = new System.Windows.Forms.Button();
            this.dataGridView5 = new System.Windows.Forms.DataGridView();
            this.VINReport5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CarModelReprot5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CarTypeReport5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.InsuranceReport5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalMoneyReport5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VIN5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CarModel5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CarType5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CarInsurance5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Reports.SuspendLayout();
            this.Report1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.Report2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.Report3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.Report4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).BeginInit();
            this.Report5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView5)).BeginInit();
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
            this.Report1.Controls.Add(this.Info1);
            this.Report1.Controls.Add(this.dataGridView1);
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
            // Info1
            // 
            this.Info1.Location = new System.Drawing.Point(526, 358);
            this.Info1.Name = "Info1";
            this.Info1.Size = new System.Drawing.Size(90, 32);
            this.Info1.TabIndex = 6;
            this.Info1.Text = "Info";
            this.Info1.UseVisualStyleBackColor = true;
            this.Info1.Click += new System.EventHandler(this.Info1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.VIN,
            this.Description,
            this.DailyRate,
            this.PricePerWeek,
            this.MonthlyRate,
            this.Price});
            this.dataGridView1.Location = new System.Drawing.Point(2, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(614, 335);
            this.dataGridView1.TabIndex = 5;
            // 
            // VIN
            // 
            this.VIN.HeaderText = "VIN";
            this.VIN.Name = "VIN";
            this.VIN.ReadOnly = true;
            this.VIN.Width = 55;
            // 
            // Description
            // 
            this.Description.HeaderText = "CarType";
            this.Description.Name = "Description";
            this.Description.ReadOnly = true;
            // 
            // DailyRate
            // 
            this.DailyRate.HeaderText = "PricePerDay";
            this.DailyRate.Name = "DailyRate";
            this.DailyRate.ReadOnly = true;
            // 
            // PricePerWeek
            // 
            this.PricePerWeek.HeaderText = "PricePerWeek";
            this.PricePerWeek.Name = "PricePerWeek";
            this.PricePerWeek.ReadOnly = true;
            // 
            // MonthlyRate
            // 
            this.MonthlyRate.HeaderText = "PricePerMonth";
            this.MonthlyRate.Name = "MonthlyRate";
            this.MonthlyRate.ReadOnly = true;
            // 
            // Price
            // 
            this.Price.HeaderText = "TotalAmount";
            this.Price.Name = "Price";
            this.Price.ReadOnly = true;
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
            this.Report2.Controls.Add(this.Info2);
            this.Report2.Controls.Add(this.YearBox2);
            this.Report2.Controls.Add(this.dataGridView2);
            this.Report2.Controls.Add(this.UpdateReport2);
            this.Report2.Location = new System.Drawing.Point(4, 25);
            this.Report2.Name = "Report2";
            this.Report2.Padding = new System.Windows.Forms.Padding(3);
            this.Report2.Size = new System.Drawing.Size(624, 394);
            this.Report2.TabIndex = 1;
            this.Report2.Text = "Report 2";
            // 
            // Info2
            // 
            this.Info2.Location = new System.Drawing.Point(526, 358);
            this.Info2.Name = "Info2";
            this.Info2.Size = new System.Drawing.Size(90, 32);
            this.Info2.TabIndex = 10;
            this.Info2.Text = "Info";
            this.Info2.UseVisualStyleBackColor = true;
            this.Info2.Click += new System.EventHandler(this.Info2_Click);
            // 
            // YearBox2
            // 
            this.YearBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.YearBox2.FormattingEnabled = true;
            this.YearBox2.Items.AddRange(new object[] {
            "2000",
            "2001",
            "2002",
            "2003",
            "2004",
            "2005",
            "2006",
            "2007",
            "2008",
            "2009",
            "2010",
            "2011",
            "2012",
            "2013",
            "2014",
            "2015",
            "2016",
            "2017",
            "2018",
            "2019",
            "2020",
            "2021",
            "2022",
            "2023",
            "2024",
            "2025",
            "2026",
            "2027",
            "2028",
            "2029",
            "2030",
            "2031",
            "2032",
            "2033",
            "2034",
            "2035"});
            this.YearBox2.Location = new System.Drawing.Point(6, 359);
            this.YearBox2.Name = "YearBox2";
            this.YearBox2.Size = new System.Drawing.Size(165, 24);
            this.YearBox2.TabIndex = 9;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.BranchID2,
            this.BranchName2,
            this.TotalRentYear,
            this.TotalMoney});
            this.dataGridView2.Location = new System.Drawing.Point(3, 3);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowTemplate.Height = 25;
            this.dataGridView2.Size = new System.Drawing.Size(614, 335);
            this.dataGridView2.TabIndex = 6;
            // 
            // BranchID2
            // 
            this.BranchID2.HeaderText = "Branch ID";
            this.BranchID2.Name = "BranchID2";
            this.BranchID2.ReadOnly = true;
            // 
            // BranchName2
            // 
            this.BranchName2.HeaderText = "Branch Name";
            this.BranchName2.Name = "BranchName2";
            this.BranchName2.ReadOnly = true;
            this.BranchName2.Width = 125;
            // 
            // TotalRentYear
            // 
            this.TotalRentYear.HeaderText = "Amount Of Rents";
            this.TotalRentYear.Name = "TotalRentYear";
            this.TotalRentYear.ReadOnly = true;
            this.TotalRentYear.Width = 135;
            // 
            // TotalMoney
            // 
            this.TotalMoney.HeaderText = "Total Money Made";
            this.TotalMoney.Name = "TotalMoney";
            this.TotalMoney.ReadOnly = true;
            this.TotalMoney.Width = 150;
            // 
            // UpdateReport2
            // 
            this.UpdateReport2.BackColor = System.Drawing.Color.Silver;
            this.UpdateReport2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.UpdateReport2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.UpdateReport2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.UpdateReport2.Location = new System.Drawing.Point(177, 354);
            this.UpdateReport2.Name = "UpdateReport2";
            this.UpdateReport2.Size = new System.Drawing.Size(106, 32);
            this.UpdateReport2.TabIndex = 2;
            this.UpdateReport2.Text = "Update Report";
            this.UpdateReport2.UseVisualStyleBackColor = false;
            this.UpdateReport2.Click += new System.EventHandler(this.UpdateReport2_Click);
            // 
            // Report3
            // 
            this.Report3.BackColor = System.Drawing.Color.DimGray;
            this.Report3.Controls.Add(this.info3);
            this.Report3.Controls.Add(this.dataGridView3);
            this.Report3.Controls.Add(this.YearBox1);
            this.Report3.Controls.Add(this.UpdateButton3);
            this.Report3.Controls.Add(this.MonthBox3);
            this.Report3.Location = new System.Drawing.Point(4, 25);
            this.Report3.Name = "Report3";
            this.Report3.Padding = new System.Windows.Forms.Padding(3);
            this.Report3.Size = new System.Drawing.Size(624, 394);
            this.Report3.TabIndex = 2;
            this.Report3.Text = "Report 3";
            // 
            // info3
            // 
            this.info3.Location = new System.Drawing.Point(526, 358);
            this.info3.Name = "info3";
            this.info3.Size = new System.Drawing.Size(90, 32);
            this.info3.TabIndex = 11;
            this.info3.Text = "Info";
            this.info3.UseVisualStyleBackColor = true;
            this.info3.Click += new System.EventHandler(this.info3_Click);
            // 
            // dataGridView3
            // 
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.BranchID,
            this.BranchName});
            this.dataGridView3.Location = new System.Drawing.Point(4, 3);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.ReadOnly = true;
            this.dataGridView3.RowTemplate.Height = 25;
            this.dataGridView3.Size = new System.Drawing.Size(614, 335);
            this.dataGridView3.TabIndex = 9;
            // 
            // BranchID
            // 
            this.BranchID.HeaderText = "Branch ID";
            this.BranchID.Name = "BranchID";
            this.BranchID.ReadOnly = true;
            this.BranchID.Width = 70;
            // 
            // BranchName
            // 
            this.BranchName.HeaderText = "Branch Name";
            this.BranchName.Name = "BranchName";
            this.BranchName.ReadOnly = true;
            this.BranchName.Width = 200;
            // 
            // YearBox1
            // 
            this.YearBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.YearBox1.FormattingEnabled = true;
            this.YearBox1.Items.AddRange(new object[] {
            "2000",
            "2001",
            "2002",
            "2003",
            "2004",
            "2005",
            "2006",
            "2007",
            "2008",
            "2009",
            "2010",
            "2011",
            "2012",
            "2013",
            "2014",
            "2015",
            "2016",
            "2017",
            "2018",
            "2019",
            "2020",
            "2021",
            "2022",
            "2023",
            "2024",
            "2025",
            "2026",
            "2027",
            "2028",
            "2029",
            "2030",
            "2031",
            "2032",
            "2033",
            "2034",
            "2035"});
            this.YearBox1.Location = new System.Drawing.Point(177, 364);
            this.YearBox1.Name = "YearBox1";
            this.YearBox1.Size = new System.Drawing.Size(165, 24);
            this.YearBox1.TabIndex = 8;
            // 
            // UpdateButton3
            // 
            this.UpdateButton3.Location = new System.Drawing.Point(348, 356);
            this.UpdateButton3.Name = "UpdateButton3";
            this.UpdateButton3.Size = new System.Drawing.Size(106, 32);
            this.UpdateButton3.TabIndex = 1;
            this.UpdateButton3.Text = "Update Report";
            this.UpdateButton3.UseVisualStyleBackColor = true;
            this.UpdateButton3.Click += new System.EventHandler(this.UpdateButton3_Click);
            // 
            // MonthBox3
            // 
            this.MonthBox3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.MonthBox3.FormattingEnabled = true;
            this.MonthBox3.Items.AddRange(new object[] {
            "January",
            "February",
            "March",
            "April",
            "May",
            "June",
            "July",
            "August",
            "September",
            "October",
            "November",
            "December"});
            this.MonthBox3.Location = new System.Drawing.Point(6, 364);
            this.MonthBox3.Name = "MonthBox3";
            this.MonthBox3.Size = new System.Drawing.Size(165, 24);
            this.MonthBox3.TabIndex = 0;
            // 
            // Report4
            // 
            this.Report4.BackColor = System.Drawing.Color.DimGray;
            this.Report4.Controls.Add(this.info4);
            this.Report4.Controls.Add(this.UpdateButton4);
            this.Report4.Controls.Add(this.dataGridView4);
            this.Report4.Location = new System.Drawing.Point(4, 25);
            this.Report4.Name = "Report4";
            this.Report4.Padding = new System.Windows.Forms.Padding(3);
            this.Report4.Size = new System.Drawing.Size(624, 394);
            this.Report4.TabIndex = 3;
            this.Report4.Text = "Report 4";
            // 
            // info4
            // 
            this.info4.Location = new System.Drawing.Point(6, 344);
            this.info4.Name = "info4";
            this.info4.Size = new System.Drawing.Size(98, 44);
            this.info4.TabIndex = 12;
            this.info4.Text = "Info";
            this.info4.UseVisualStyleBackColor = true;
            this.info4.Click += new System.EventHandler(this.info4_Click);
            // 
            // UpdateButton4
            // 
            this.UpdateButton4.BackColor = System.Drawing.Color.Silver;
            this.UpdateButton4.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.UpdateButton4.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.UpdateButton4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.UpdateButton4.Location = new System.Drawing.Point(396, 344);
            this.UpdateButton4.Name = "UpdateButton4";
            this.UpdateButton4.Size = new System.Drawing.Size(221, 44);
            this.UpdateButton4.TabIndex = 8;
            this.UpdateButton4.Text = "Update Report";
            this.UpdateButton4.UseVisualStyleBackColor = false;
            this.UpdateButton4.Click += new System.EventHandler(this.UpdateButton4_Click);
            // 
            // dataGridView4
            // 
            this.dataGridView4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView4.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CustomerID,
            this.FirstName,
            this.MiddleName,
            this.LastName,
            this.NumberOfRentals});
            this.dataGridView4.Location = new System.Drawing.Point(3, 3);
            this.dataGridView4.Name = "dataGridView4";
            this.dataGridView4.ReadOnly = true;
            this.dataGridView4.RowTemplate.Height = 25;
            this.dataGridView4.Size = new System.Drawing.Size(614, 335);
            this.dataGridView4.TabIndex = 7;
            // 
            // CustomerID
            // 
            this.CustomerID.HeaderText = "Customer ID";
            this.CustomerID.Name = "CustomerID";
            this.CustomerID.ReadOnly = true;
            // 
            // FirstName
            // 
            this.FirstName.HeaderText = "First Name";
            this.FirstName.Name = "FirstName";
            this.FirstName.ReadOnly = true;
            // 
            // MiddleName
            // 
            this.MiddleName.HeaderText = "Middle Name";
            this.MiddleName.Name = "MiddleName";
            this.MiddleName.ReadOnly = true;
            // 
            // LastName
            // 
            this.LastName.HeaderText = "Last Name";
            this.LastName.Name = "LastName";
            this.LastName.ReadOnly = true;
            // 
            // NumberOfRentals
            // 
            this.NumberOfRentals.HeaderText = "Number Of Rentals";
            this.NumberOfRentals.Name = "NumberOfRentals";
            this.NumberOfRentals.ReadOnly = true;
            // 
            // Report5
            // 
            this.Report5.BackColor = System.Drawing.Color.DimGray;
            this.Report5.Controls.Add(this.info5);
            this.Report5.Controls.Add(this.UpdateReport5);
            this.Report5.Controls.Add(this.dataGridView5);
            this.Report5.Location = new System.Drawing.Point(4, 25);
            this.Report5.Name = "Report5";
            this.Report5.Padding = new System.Windows.Forms.Padding(3);
            this.Report5.Size = new System.Drawing.Size(624, 394);
            this.Report5.TabIndex = 4;
            this.Report5.Text = "Report 5";
            // 
            // info5
            // 
            this.info5.Location = new System.Drawing.Point(6, 344);
            this.info5.Name = "info5";
            this.info5.Size = new System.Drawing.Size(98, 44);
            this.info5.TabIndex = 13;
            this.info5.Text = "Info";
            this.info5.UseVisualStyleBackColor = true;
            this.info5.Click += new System.EventHandler(this.info5_Click);
            // 
            // UpdateReport5
            // 
            this.UpdateReport5.BackColor = System.Drawing.Color.Silver;
            this.UpdateReport5.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.UpdateReport5.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.UpdateReport5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.UpdateReport5.Location = new System.Drawing.Point(396, 344);
            this.UpdateReport5.Name = "UpdateReport5";
            this.UpdateReport5.Size = new System.Drawing.Size(221, 44);
            this.UpdateReport5.TabIndex = 9;
            this.UpdateReport5.Text = "Update Report";
            this.UpdateReport5.UseVisualStyleBackColor = false;
            this.UpdateReport5.Click += new System.EventHandler(this.UpdateReport5_Click);
            // 
            // dataGridView5
            // 
            this.dataGridView5.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView5.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.VINReport5,
            this.CarModelReprot5,
            this.CarTypeReport5,
            this.InsuranceReport5,
            this.TotalMoneyReport5});
            this.dataGridView5.Location = new System.Drawing.Point(3, 3);
            this.dataGridView5.Name = "dataGridView5";
            this.dataGridView5.ReadOnly = true;
            this.dataGridView5.RowTemplate.Height = 25;
            this.dataGridView5.Size = new System.Drawing.Size(614, 335);
            this.dataGridView5.TabIndex = 8;
            // 
            // VINReport5
            // 
            this.VINReport5.HeaderText = "VIN";
            this.VINReport5.Name = "VINReport5";
            this.VINReport5.ReadOnly = true;
            // 
            // CarModelReprot5
            // 
            this.CarModelReprot5.HeaderText = "Car Model";
            this.CarModelReprot5.Name = "CarModelReprot5";
            this.CarModelReprot5.ReadOnly = true;
            // 
            // CarTypeReport5
            // 
            this.CarTypeReport5.HeaderText = "Car Type";
            this.CarTypeReport5.Name = "CarTypeReport5";
            this.CarTypeReport5.ReadOnly = true;
            // 
            // InsuranceReport5
            // 
            this.InsuranceReport5.HeaderText = "Car Odometer";
            this.InsuranceReport5.Name = "InsuranceReport5";
            this.InsuranceReport5.ReadOnly = true;
            // 
            // TotalMoneyReport5
            // 
            this.TotalMoneyReport5.HeaderText = "All Time Money Made";
            this.TotalMoneyReport5.Name = "TotalMoneyReport5";
            this.TotalMoneyReport5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.HeaderText = "TotalAmount";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.HeaderText = "PricePerMonth";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.HeaderText = "PricePerDay";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.HeaderText = "CarType";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.HeaderText = "VIN";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // VIN5
            // 
            this.VIN5.HeaderText = "VIN";
            this.VIN5.Name = "VIN5";
            // 
            // CarModel5
            // 
            this.CarModel5.HeaderText = "Car Model";
            this.CarModel5.Name = "CarModel5";
            this.CarModel5.Width = 125;
            // 
            // CarType5
            // 
            this.CarType5.HeaderText = "Car Type";
            this.CarType5.Name = "CarType5";
            this.CarType5.Width = 135;
            // 
            // CarInsurance5
            // 
            this.CarInsurance5.HeaderText = "Car Insurance";
            this.CarInsurance5.Name = "CarInsurance5";
            this.CarInsurance5.Width = 150;
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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.Report2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.Report3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.Report4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).EndInit();
            this.Report5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label ReportsLbl;
        private TabControl Reports;
        private TabPage Report1;
        private TabPage Report2;
        private TabPage Report4;
        private TabPage Report5;
        private Button ReportUpdate1;
        private DateTimePicker DatePick1;
        private DateTimePicker DatePick2;
        private Button UpdateReport2;
        private DataGridView dataGridView1;
        private DataGridView dataGridView2;
        private DataGridViewTextBoxColumn VIN;
        private DataGridViewTextBoxColumn Description;
        private DataGridViewTextBoxColumn DailyRate;
        private DataGridViewTextBoxColumn PricePerWeek;
        private DataGridViewTextBoxColumn MonthlyRate;
        private DataGridViewTextBoxColumn Price;
        private DataGridView dataGridView4;
        private Button UpdateButton4;
        private DataGridViewTextBoxColumn CustomerID;
        private DataGridViewTextBoxColumn FirstName;
        private DataGridViewTextBoxColumn MiddleName;
        private DataGridViewTextBoxColumn LastName;
        private DataGridViewTextBoxColumn NumberOfRentals;
        private TabPage Report3;
        private ComboBox YearBox1;
        private Button UpdateButton3;
        private ComboBox MonthBox3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private DataGridView dataGridView3;
        private DataGridViewTextBoxColumn BranchID;
        private DataGridViewTextBoxColumn BranchName;
        private ComboBox YearBox2;
        private DataGridViewTextBoxColumn BranchID2;
        private DataGridViewTextBoxColumn BranchName2;
        private DataGridViewTextBoxColumn TotalRentYear;
        private DataGridViewTextBoxColumn TotalMoney;
        private DataGridViewTextBoxColumn VIN5;
        private DataGridViewTextBoxColumn CarModel5;
        private DataGridViewTextBoxColumn CarType5;
        private DataGridViewTextBoxColumn CarInsurance5;
        private Button UpdateReport5;
        private DataGridView dataGridView5;
        private Button Info1;
        private Button Info2;
        private Button info3;
        private Button info4;
        private Button info5;
        private DataGridViewTextBoxColumn VINReport5;
        private DataGridViewTextBoxColumn CarModelReprot5;
        private DataGridViewTextBoxColumn CarTypeReport5;
        private DataGridViewTextBoxColumn InsuranceReport5;
        private DataGridViewTextBoxColumn TotalMoneyReport5;
    }
}