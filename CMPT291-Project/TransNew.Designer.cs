namespace CMPT291_Project
{
    partial class TransNew
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
            this.CarTypePicker = new System.Windows.Forms.ComboBox();
            this.CarTable = new System.Windows.Forms.DataGridView();
            this.RtnDate = new System.Windows.Forms.DateTimePicker();
            this.RtnBranch = new System.Windows.Forms.ComboBox();
            this.RtnLbl = new System.Windows.Forms.Label();
            this.PickDate = new System.Windows.Forms.DateTimePicker();
            this.PickupBranchID = new System.Windows.Forms.ComboBox();
            this.PickupLbl = new System.Windows.Forms.Label();
            this.FindID = new System.Windows.Forms.Button();
            this.CustIdBx = new System.Windows.Forms.TextBox();
            this.CustLbl = new System.Windows.Forms.Label();
            this.FullName = new System.Windows.Forms.Label();
            this.Add1 = new System.Windows.Forms.Label();
            this.Add2 = new System.Windows.Forms.Label();
            this.CP = new System.Windows.Forms.Label();
            this.Phone = new System.Windows.Forms.Label();
            this.Mbrship = new System.Windows.Forms.Label();
            this.Postal = new System.Windows.Forms.Label();
            this.FindCarsBtn = new System.Windows.Forms.Button();
            this.carentrycancel = new System.Windows.Forms.Button();
            this.carentrryaccept = new System.Windows.Forms.Button();
            this.priceBx = new System.Windows.Forms.Label();
            this.NewTransPnl = new System.Windows.Forms.Panel();
            this.PriceLbl = new System.Windows.Forms.Label();
            this.calcPriceBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.CarTable)).BeginInit();
            this.NewTransPnl.SuspendLayout();
            this.SuspendLayout();
            // 
            // CarTypePicker
            // 
            this.CarTypePicker.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.CarTypePicker.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CarTypePicker.FormattingEnabled = true;
            this.CarTypePicker.Items.AddRange(new object[] {
            "All Car Types"});
            this.CarTypePicker.Location = new System.Drawing.Point(624, 387);
            this.CarTypePicker.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.CarTypePicker.Name = "CarTypePicker";
            this.CarTypePicker.Size = new System.Drawing.Size(400, 40);
            this.CarTypePicker.TabIndex = 104;
            this.CarTypePicker.SelectedIndexChanged += new System.EventHandler(this.CarTypePicker_SelectedIndexChanged);
            // 
            // CarTable
            // 
            this.CarTable.AllowUserToAddRows = false;
            this.CarTable.AllowUserToDeleteRows = false;
            this.CarTable.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.CarTable.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(79)))), ((int)(((byte)(99)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ScrollBar;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.CarTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.CarTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(79)))), ((int)(((byte)(99)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ScrollBar;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.CarTable.DefaultCellStyle = dataGridViewCellStyle2;
            this.CarTable.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.CarTable.Location = new System.Drawing.Point(44, 463);
            this.CarTable.Margin = new System.Windows.Forms.Padding(6);
            this.CarTable.Name = "CarTable";
            this.CarTable.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(79)))), ((int)(((byte)(99)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.CarTable.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.CarTable.RowHeadersVisible = false;
            this.CarTable.RowHeadersWidth = 82;
            this.CarTable.RowTemplate.Height = 50;
            this.CarTable.Size = new System.Drawing.Size(1155, 450);
            this.CarTable.TabIndex = 103;
            // 
            // RtnDate
            // 
            this.RtnDate.CalendarMonthBackground = System.Drawing.SystemColors.ScrollBar;
            this.RtnDate.Location = new System.Drawing.Point(44, 388);
            this.RtnDate.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.RtnDate.Name = "RtnDate";
            this.RtnDate.Size = new System.Drawing.Size(400, 39);
            this.RtnDate.TabIndex = 102;
            // 
            // RtnBranch
            // 
            this.RtnBranch.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.RtnBranch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.RtnBranch.FormattingEnabled = true;
            this.RtnBranch.Location = new System.Drawing.Point(44, 320);
            this.RtnBranch.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.RtnBranch.Name = "RtnBranch";
            this.RtnBranch.Size = new System.Drawing.Size(400, 40);
            this.RtnBranch.TabIndex = 101;
            this.RtnBranch.SelectedIndexChanged += new System.EventHandler(this.RtnBranch_SelectedIndexChanged);
            // 
            // RtnLbl
            // 
            this.RtnLbl.AutoSize = true;
            this.RtnLbl.Font = new System.Drawing.Font("Segoe UI", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.RtnLbl.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.RtnLbl.Location = new System.Drawing.Point(168, 241);
            this.RtnLbl.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.RtnLbl.Name = "RtnLbl";
            this.RtnLbl.Size = new System.Drawing.Size(150, 59);
            this.RtnLbl.TabIndex = 100;
            this.RtnLbl.Text = "Return";
            // 
            // PickDate
            // 
            this.PickDate.CalendarMonthBackground = System.Drawing.SystemColors.ScrollBar;
            this.PickDate.Location = new System.Drawing.Point(44, 174);
            this.PickDate.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.PickDate.Name = "PickDate";
            this.PickDate.Size = new System.Drawing.Size(400, 39);
            this.PickDate.TabIndex = 99;
            // 
            // PickupBranchID
            // 
            this.PickupBranchID.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.PickupBranchID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.PickupBranchID.FormattingEnabled = true;
            this.PickupBranchID.Location = new System.Drawing.Point(44, 106);
            this.PickupBranchID.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.PickupBranchID.Name = "PickupBranchID";
            this.PickupBranchID.Size = new System.Drawing.Size(400, 40);
            this.PickupBranchID.TabIndex = 98;
            this.PickupBranchID.SelectedIndexChanged += new System.EventHandler(this.PickupBranchID_SelectedIndexChanged);
            // 
            // PickupLbl
            // 
            this.PickupLbl.AutoSize = true;
            this.PickupLbl.Font = new System.Drawing.Font("Segoe UI", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PickupLbl.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.PickupLbl.Location = new System.Drawing.Point(157, 27);
            this.PickupLbl.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.PickupLbl.Name = "PickupLbl";
            this.PickupLbl.Size = new System.Drawing.Size(149, 59);
            this.PickupLbl.TabIndex = 97;
            this.PickupLbl.Text = "Pickup";
            // 
            // FindID
            // 
            this.FindID.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FindID.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.FindID.Location = new System.Drawing.Point(965, 33);
            this.FindID.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.FindID.Name = "FindID";
            this.FindID.Size = new System.Drawing.Size(140, 49);
            this.FindID.TabIndex = 117;
            this.FindID.Text = "Find ID";
            this.FindID.UseVisualStyleBackColor = true;
            this.FindID.Click += new System.EventHandler(this.FindID_Click);
            // 
            // CustIdBx
            // 
            this.CustIdBx.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.CustIdBx.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CustIdBx.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CustIdBx.ForeColor = System.Drawing.SystemColors.Window;
            this.CustIdBx.Location = new System.Drawing.Point(1116, 38);
            this.CustIdBx.Margin = new System.Windows.Forms.Padding(6);
            this.CustIdBx.Name = "CustIdBx";
            this.CustIdBx.Size = new System.Drawing.Size(83, 43);
            this.CustIdBx.TabIndex = 116;
            // 
            // CustLbl
            // 
            this.CustLbl.AutoSize = true;
            this.CustLbl.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CustLbl.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.CustLbl.Location = new System.Drawing.Point(619, 31);
            this.CustLbl.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.CustLbl.Name = "CustLbl";
            this.CustLbl.Size = new System.Drawing.Size(185, 51);
            this.CustLbl.TabIndex = 119;
            this.CustLbl.Text = "Customer";
            // 
            // FullName
            // 
            this.FullName.AutoSize = true;
            this.FullName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FullName.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.FullName.Location = new System.Drawing.Point(624, 106);
            this.FullName.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.FullName.Name = "FullName";
            this.FullName.Size = new System.Drawing.Size(105, 45);
            this.FullName.TabIndex = 126;
            this.FullName.Text = "Name";
            this.FullName.Visible = false;
            // 
            // Add1
            // 
            this.Add1.AutoSize = true;
            this.Add1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Add1.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.Add1.Location = new System.Drawing.Point(624, 151);
            this.Add1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.Add1.Name = "Add1";
            this.Add1.Size = new System.Drawing.Size(228, 45);
            this.Add1.TabIndex = 127;
            this.Add1.Text = "Address Line 1";
            this.Add1.Visible = false;
            // 
            // Add2
            // 
            this.Add2.AutoSize = true;
            this.Add2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Add2.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.Add2.Location = new System.Drawing.Point(624, 196);
            this.Add2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.Add2.Name = "Add2";
            this.Add2.Size = new System.Drawing.Size(228, 45);
            this.Add2.TabIndex = 128;
            this.Add2.Text = "Address Line 2";
            this.Add2.Visible = false;
            // 
            // CP
            // 
            this.CP.AutoSize = true;
            this.CP.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CP.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.CP.Location = new System.Drawing.Point(624, 241);
            this.CP.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.CP.Name = "CP";
            this.CP.Size = new System.Drawing.Size(204, 45);
            this.CP.TabIndex = 129;
            this.CP.Text = "City Province";
            this.CP.Visible = false;
            // 
            // Phone
            // 
            this.Phone.AutoSize = true;
            this.Phone.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Phone.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.Phone.Location = new System.Drawing.Point(624, 331);
            this.Phone.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.Phone.Name = "Phone";
            this.Phone.Size = new System.Drawing.Size(110, 45);
            this.Phone.TabIndex = 130;
            this.Phone.Text = "Phone";
            this.Phone.Visible = false;
            // 
            // Mbrship
            // 
            this.Mbrship.AutoSize = true;
            this.Mbrship.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Mbrship.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.Mbrship.Location = new System.Drawing.Point(999, 331);
            this.Mbrship.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.Mbrship.Name = "Mbrship";
            this.Mbrship.Size = new System.Drawing.Size(200, 45);
            this.Mbrship.TabIndex = 131;
            this.Mbrship.Text = "Membership";
            this.Mbrship.Visible = false;
            // 
            // Postal
            // 
            this.Postal.AutoSize = true;
            this.Postal.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Postal.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.Postal.Location = new System.Drawing.Point(624, 286);
            this.Postal.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.Postal.Name = "Postal";
            this.Postal.Size = new System.Drawing.Size(189, 45);
            this.Postal.TabIndex = 132;
            this.Postal.Text = "Postal Code";
            this.Postal.Visible = false;
            // 
            // FindCarsBtn
            // 
            this.FindCarsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FindCarsBtn.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.FindCarsBtn.Location = new System.Drawing.Point(1045, 382);
            this.FindCarsBtn.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.FindCarsBtn.Name = "FindCarsBtn";
            this.FindCarsBtn.Size = new System.Drawing.Size(140, 49);
            this.FindCarsBtn.TabIndex = 134;
            this.FindCarsBtn.Text = "Find Cars";
            this.FindCarsBtn.UseVisualStyleBackColor = true;
            this.FindCarsBtn.Click += new System.EventHandler(this.FindCarsBtn_Click);
            // 
            // carentrycancel
            // 
            this.carentrycancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(79)))), ((int)(((byte)(99)))));
            this.carentrycancel.FlatAppearance.BorderSize = 0;
            this.carentrycancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.carentrycancel.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.carentrycancel.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.carentrycancel.Location = new System.Drawing.Point(44, 926);
            this.carentrycancel.Margin = new System.Windows.Forms.Padding(6);
            this.carentrycancel.Name = "carentrycancel";
            this.carentrycancel.Size = new System.Drawing.Size(184, 107);
            this.carentrycancel.TabIndex = 135;
            this.carentrycancel.Text = "Cancel";
            this.carentrycancel.UseVisualStyleBackColor = false;
            this.carentrycancel.Click += new System.EventHandler(this.carentrycancel_Click);
            // 
            // carentrryaccept
            // 
            this.carentrryaccept.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(79)))), ((int)(((byte)(99)))));
            this.carentrryaccept.FlatAppearance.BorderSize = 0;
            this.carentrryaccept.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.carentrryaccept.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.carentrryaccept.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.carentrryaccept.Location = new System.Drawing.Point(1015, 926);
            this.carentrryaccept.Margin = new System.Windows.Forms.Padding(6);
            this.carentrryaccept.Name = "carentrryaccept";
            this.carentrryaccept.Size = new System.Drawing.Size(184, 107);
            this.carentrryaccept.TabIndex = 136;
            this.carentrryaccept.Text = "Accept";
            this.carentrryaccept.UseVisualStyleBackColor = false;
            this.carentrryaccept.Click += new System.EventHandler(this.carentrryaccept_Click);
            // 
            // priceBx
            // 
            this.priceBx.AutoSize = true;
            this.priceBx.Font = new System.Drawing.Font("Segoe UI", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.priceBx.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.priceBx.Location = new System.Drawing.Point(938, 946);
            this.priceBx.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.priceBx.Name = "priceBx";
            this.priceBx.Size = new System.Drawing.Size(48, 59);
            this.priceBx.TabIndex = 137;
            this.priceBx.Text = "0";
            this.priceBx.Visible = false;
            // 
            // NewTransPnl
            // 
            this.NewTransPnl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.NewTransPnl.Controls.Add(this.calcPriceBtn);
            this.NewTransPnl.Controls.Add(this.priceBx);
            this.NewTransPnl.Controls.Add(this.PickupLbl);
            this.NewTransPnl.Controls.Add(this.carentrryaccept);
            this.NewTransPnl.Controls.Add(this.PickupBranchID);
            this.NewTransPnl.Controls.Add(this.carentrycancel);
            this.NewTransPnl.Controls.Add(this.PickDate);
            this.NewTransPnl.Controls.Add(this.FindCarsBtn);
            this.NewTransPnl.Controls.Add(this.RtnLbl);
            this.NewTransPnl.Controls.Add(this.Postal);
            this.NewTransPnl.Controls.Add(this.RtnBranch);
            this.NewTransPnl.Controls.Add(this.Mbrship);
            this.NewTransPnl.Controls.Add(this.RtnDate);
            this.NewTransPnl.Controls.Add(this.Phone);
            this.NewTransPnl.Controls.Add(this.CarTable);
            this.NewTransPnl.Controls.Add(this.CP);
            this.NewTransPnl.Controls.Add(this.CarTypePicker);
            this.NewTransPnl.Controls.Add(this.Add2);
            this.NewTransPnl.Controls.Add(this.CustIdBx);
            this.NewTransPnl.Controls.Add(this.Add1);
            this.NewTransPnl.Controls.Add(this.FindID);
            this.NewTransPnl.Controls.Add(this.FullName);
            this.NewTransPnl.Controls.Add(this.CustLbl);
            this.NewTransPnl.Controls.Add(this.PriceLbl);
            this.NewTransPnl.Location = new System.Drawing.Point(0, 0);
            this.NewTransPnl.Margin = new System.Windows.Forms.Padding(6);
            this.NewTransPnl.Name = "NewTransPnl";
            this.NewTransPnl.Size = new System.Drawing.Size(1233, 1050);
            this.NewTransPnl.TabIndex = 138;
            // 
            // PriceLbl
            // 
            this.PriceLbl.AutoSize = true;
            this.PriceLbl.Font = new System.Drawing.Font("Segoe UI", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PriceLbl.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.PriceLbl.Location = new System.Drawing.Point(727, 946);
            this.PriceLbl.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.PriceLbl.Name = "PriceLbl";
            this.PriceLbl.Size = new System.Drawing.Size(125, 59);
            this.PriceLbl.TabIndex = 125;
            this.PriceLbl.Text = "Price:";
            // 
            // calcPriceBtn
            // 
            this.calcPriceBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.calcPriceBtn.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.calcPriceBtn.Location = new System.Drawing.Point(546, 956);
            this.calcPriceBtn.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.calcPriceBtn.Name = "calcPriceBtn";
            this.calcPriceBtn.Size = new System.Drawing.Size(140, 49);
            this.calcPriceBtn.TabIndex = 138;
            this.calcPriceBtn.Text = "Caluclate";
            this.calcPriceBtn.UseVisualStyleBackColor = true;
            this.calcPriceBtn.Click += new System.EventHandler(this.calcPriceBtn_Click);
            // 
            // TransNew
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.ClientSize = new System.Drawing.Size(1233, 1050);
            this.Controls.Add(this.NewTransPnl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TransNew";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.CarTable)).EndInit();
            this.NewTransPnl.ResumeLayout(false);
            this.NewTransPnl.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private ComboBox CarTypePicker;
        private DataGridView CarTable;
        private DateTimePicker RtnDate;
        private ComboBox RtnBranch;
        private Label RtnLbl;
        private DateTimePicker PickDate;
        private ComboBox PickupBranchID;
        private Label PickupLbl;
        private Button FindID;
        private TextBox CustIdBx;
        private Label CustLbl;
        public Label FullName;
        public Label Add1;
        public Label Add2;
        public Label CP;
        public Label Phone;
        public Label Mbrship;
        public Label Postal;
        private Button FindCarsBtn;
        private Button carentrycancel;
        private Button carentrryaccept;
        public Label priceBx;
        private Panel NewTransPnl;
        private Button calcPriceBtn;
        public Label PriceLbl;
    }
}