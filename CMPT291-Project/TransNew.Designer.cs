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
            this.selCarInfo = new System.Windows.Forms.Label();
            this.CarLbl = new System.Windows.Forms.Label();
            this.LateCheck = new System.Windows.Forms.CheckBox();
            this.completeRBtn = new System.Windows.Forms.RadioButton();
            this.RemoveRBtn = new System.Windows.Forms.RadioButton();
            this.EditRBtn = new System.Windows.Forms.RadioButton();
            this.AddRBtn = new System.Windows.Forms.RadioButton();
            this.FindTransBtn = new System.Windows.Forms.Button();
            this.TransIdBx = new System.Windows.Forms.TextBox();
            this.TransLbl = new System.Windows.Forms.Label();
            this.level = new System.Windows.Forms.Label();
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
            this.CarTypePicker.Location = new System.Drawing.Point(355, 188);
            this.CarTypePicker.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.CarTypePicker.Name = "CarTypePicker";
            this.CarTypePicker.Size = new System.Drawing.Size(156, 23);
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
            this.CarTable.Location = new System.Drawing.Point(24, 217);
            this.CarTable.MultiSelect = false;
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
            this.CarTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.CarTable.Size = new System.Drawing.Size(622, 175);
            this.CarTable.TabIndex = 103;
            this.CarTable.SelectionChanged += new System.EventHandler(this.CarTable_SelectionChanged);
            // 
            // RtnDate
            // 
            this.RtnDate.CalendarMonthBackground = System.Drawing.SystemColors.ScrollBar;
            this.RtnDate.Location = new System.Drawing.Point(118, 188);
            this.RtnDate.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.RtnDate.Name = "RtnDate";
            this.RtnDate.Size = new System.Drawing.Size(210, 23);
            this.RtnDate.TabIndex = 102;
            this.RtnDate.ValueChanged += new System.EventHandler(this.RtnDate_ValueChanged);
            // 
            // RtnBranch
            // 
            this.RtnBranch.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.RtnBranch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.RtnBranch.FormattingEnabled = true;
            this.RtnBranch.Location = new System.Drawing.Point(118, 162);
            this.RtnBranch.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.RtnBranch.Name = "RtnBranch";
            this.RtnBranch.Size = new System.Drawing.Size(210, 23);
            this.RtnBranch.TabIndex = 101;
            this.RtnBranch.SelectedIndexChanged += new System.EventHandler(this.RtnBranch_SelectedIndexChanged);
            // 
            // RtnLbl
            // 
            this.RtnLbl.AutoSize = true;
            this.RtnLbl.Font = new System.Drawing.Font("Segoe UI", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.RtnLbl.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.RtnLbl.Location = new System.Drawing.Point(24, 172);
            this.RtnLbl.Name = "RtnLbl";
            this.RtnLbl.Size = new System.Drawing.Size(67, 25);
            this.RtnLbl.TabIndex = 100;
            this.RtnLbl.Text = "Return";
            // 
            // PickDate
            // 
            this.PickDate.CalendarMonthBackground = System.Drawing.SystemColors.ScrollBar;
            this.PickDate.Location = new System.Drawing.Point(118, 123);
            this.PickDate.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.PickDate.Name = "PickDate";
            this.PickDate.Size = new System.Drawing.Size(210, 23);
            this.PickDate.TabIndex = 99;
            this.PickDate.ValueChanged += new System.EventHandler(this.PickDate_ValueChanged);
            // 
            // PickupBranchID
            // 
            this.PickupBranchID.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.PickupBranchID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.PickupBranchID.FormattingEnabled = true;
            this.PickupBranchID.Location = new System.Drawing.Point(118, 99);
            this.PickupBranchID.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.PickupBranchID.Name = "PickupBranchID";
            this.PickupBranchID.Size = new System.Drawing.Size(210, 23);
            this.PickupBranchID.TabIndex = 98;
            this.PickupBranchID.SelectedIndexChanged += new System.EventHandler(this.PickupBranchID_SelectedIndexChanged);
            // 
            // PickupLbl
            // 
            this.PickupLbl.AutoSize = true;
            this.PickupLbl.Font = new System.Drawing.Font("Segoe UI", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PickupLbl.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.PickupLbl.Location = new System.Drawing.Point(24, 111);
            this.PickupLbl.Name = "PickupLbl";
            this.PickupLbl.Size = new System.Drawing.Size(68, 25);
            this.PickupLbl.TabIndex = 97;
            this.PickupLbl.Text = "Pickup";
            // 
            // FindID
            // 
            this.FindID.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FindID.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.FindID.Location = new System.Drawing.Point(492, 15);
            this.FindID.Name = "FindID";
            this.FindID.Size = new System.Drawing.Size(75, 23);
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
            this.CustIdBx.Location = new System.Drawing.Point(573, 18);
            this.CustIdBx.Name = "CustIdBx";
            this.CustIdBx.Size = new System.Drawing.Size(72, 22);
            this.CustIdBx.TabIndex = 116;
            // 
            // CustLbl
            // 
            this.CustLbl.AutoSize = true;
            this.CustLbl.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CustLbl.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.CustLbl.Location = new System.Drawing.Point(355, 15);
            this.CustLbl.Name = "CustLbl";
            this.CustLbl.Size = new System.Drawing.Size(93, 25);
            this.CustLbl.TabIndex = 119;
            this.CustLbl.Text = "Customer";
            // 
            // FullName
            // 
            this.FullName.AutoSize = true;
            this.FullName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FullName.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.FullName.Location = new System.Drawing.Point(355, 52);
            this.FullName.Name = "FullName";
            this.FullName.Size = new System.Drawing.Size(52, 21);
            this.FullName.TabIndex = 126;
            this.FullName.Text = "Name";
            this.FullName.Visible = false;
            // 
            // Add1
            // 
            this.Add1.AutoSize = true;
            this.Add1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Add1.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.Add1.Location = new System.Drawing.Point(355, 73);
            this.Add1.Name = "Add1";
            this.Add1.Size = new System.Drawing.Size(112, 21);
            this.Add1.TabIndex = 127;
            this.Add1.Text = "Address Line 1";
            this.Add1.Visible = false;
            // 
            // Add2
            // 
            this.Add2.AutoSize = true;
            this.Add2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Add2.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.Add2.Location = new System.Drawing.Point(355, 94);
            this.Add2.Name = "Add2";
            this.Add2.Size = new System.Drawing.Size(112, 21);
            this.Add2.TabIndex = 128;
            this.Add2.Text = "Address Line 2";
            this.Add2.Visible = false;
            // 
            // CP
            // 
            this.CP.AutoSize = true;
            this.CP.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CP.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.CP.Location = new System.Drawing.Point(355, 115);
            this.CP.Name = "CP";
            this.CP.Size = new System.Drawing.Size(101, 21);
            this.CP.TabIndex = 129;
            this.CP.Text = "City Province";
            this.CP.Visible = false;
            // 
            // Phone
            // 
            this.Phone.AutoSize = true;
            this.Phone.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Phone.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.Phone.Location = new System.Drawing.Point(355, 158);
            this.Phone.Name = "Phone";
            this.Phone.Size = new System.Drawing.Size(54, 21);
            this.Phone.TabIndex = 130;
            this.Phone.Text = "Phone";
            this.Phone.Visible = false;
            // 
            // Mbrship
            // 
            this.Mbrship.AutoSize = true;
            this.Mbrship.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Mbrship.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.Mbrship.Location = new System.Drawing.Point(538, 155);
            this.Mbrship.Name = "Mbrship";
            this.Mbrship.Size = new System.Drawing.Size(98, 21);
            this.Mbrship.TabIndex = 131;
            this.Mbrship.Text = "Membership";
            this.Mbrship.Visible = false;
            // 
            // Postal
            // 
            this.Postal.AutoSize = true;
            this.Postal.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Postal.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.Postal.Location = new System.Drawing.Point(355, 136);
            this.Postal.Name = "Postal";
            this.Postal.Size = new System.Drawing.Size(91, 21);
            this.Postal.TabIndex = 132;
            this.Postal.Text = "Postal Code";
            this.Postal.Visible = false;
            // 
            // FindCarsBtn
            // 
            this.FindCarsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FindCarsBtn.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.FindCarsBtn.Location = new System.Drawing.Point(563, 184);
            this.FindCarsBtn.Name = "FindCarsBtn";
            this.FindCarsBtn.Size = new System.Drawing.Size(75, 23);
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
            this.carentrycancel.Location = new System.Drawing.Point(24, 434);
            this.carentrycancel.Name = "carentrycancel";
            this.carentrycancel.Size = new System.Drawing.Size(99, 50);
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
            this.carentrryaccept.Location = new System.Drawing.Point(547, 434);
            this.carentrryaccept.Name = "carentrryaccept";
            this.carentrryaccept.Size = new System.Drawing.Size(99, 50);
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
            this.priceBx.Location = new System.Drawing.Point(375, 445);
            this.priceBx.Name = "priceBx";
            this.priceBx.Size = new System.Drawing.Size(25, 30);
            this.priceBx.TabIndex = 137;
            this.priceBx.Text = "0";
            this.priceBx.Visible = false;
            // 
            // NewTransPnl
            // 
            this.NewTransPnl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.NewTransPnl.Controls.Add(this.selCarInfo);
            this.NewTransPnl.Controls.Add(this.CarLbl);
            this.NewTransPnl.Controls.Add(this.LateCheck);
            this.NewTransPnl.Controls.Add(this.completeRBtn);
            this.NewTransPnl.Controls.Add(this.RemoveRBtn);
            this.NewTransPnl.Controls.Add(this.EditRBtn);
            this.NewTransPnl.Controls.Add(this.AddRBtn);
            this.NewTransPnl.Controls.Add(this.FindTransBtn);
            this.NewTransPnl.Controls.Add(this.TransIdBx);
            this.NewTransPnl.Controls.Add(this.TransLbl);
            this.NewTransPnl.Controls.Add(this.level);
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
            this.NewTransPnl.Location = new System.Drawing.Point(0, 0);
            this.NewTransPnl.Name = "NewTransPnl";
            this.NewTransPnl.Size = new System.Drawing.Size(664, 492);
            this.NewTransPnl.TabIndex = 138;
            // 
            // selCarInfo
            // 
            this.selCarInfo.AutoSize = true;
            this.selCarInfo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.selCarInfo.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.selCarInfo.Location = new System.Drawing.Point(136, 401);
            this.selCarInfo.Name = "selCarInfo";
            this.selCarInfo.Size = new System.Drawing.Size(37, 21);
            this.selCarInfo.TabIndex = 149;
            this.selCarInfo.Text = "Info";
            // 
            // CarLbl
            // 
            this.CarLbl.AutoSize = true;
            this.CarLbl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CarLbl.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.CarLbl.Location = new System.Drawing.Point(24, 401);
            this.CarLbl.Name = "CarLbl";
            this.CarLbl.Size = new System.Drawing.Size(99, 21);
            this.CarLbl.TabIndex = 148;
            this.CarLbl.Text = "Selected Car:";
            // 
            // LateCheck
            // 
            this.LateCheck.AutoSize = true;
            this.LateCheck.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.LateCheck.Location = new System.Drawing.Point(226, 69);
            this.LateCheck.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.LateCheck.Name = "LateCheck";
            this.LateCheck.Size = new System.Drawing.Size(48, 19);
            this.LateCheck.TabIndex = 147;
            this.LateCheck.Text = "Late";
            this.LateCheck.UseVisualStyleBackColor = true;
            this.LateCheck.CheckedChanged += new System.EventHandler(this.LateCheck_CheckedChanged);
            // 
            // completeRBtn
            // 
            this.completeRBtn.AutoSize = true;
            this.completeRBtn.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.completeRBtn.Location = new System.Drawing.Point(118, 69);
            this.completeRBtn.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.completeRBtn.Name = "completeRBtn";
            this.completeRBtn.Size = new System.Drawing.Size(77, 19);
            this.completeRBtn.TabIndex = 146;
            this.completeRBtn.TabStop = true;
            this.completeRBtn.Text = "Complete";
            this.completeRBtn.UseVisualStyleBackColor = true;
            this.completeRBtn.CheckedChanged += new System.EventHandler(this.completeRBtn_CheckedChanged);
            // 
            // RemoveRBtn
            // 
            this.RemoveRBtn.AutoSize = true;
            this.RemoveRBtn.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.RemoveRBtn.Location = new System.Drawing.Point(118, 50);
            this.RemoveRBtn.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.RemoveRBtn.Name = "RemoveRBtn";
            this.RemoveRBtn.Size = new System.Drawing.Size(68, 19);
            this.RemoveRBtn.TabIndex = 145;
            this.RemoveRBtn.TabStop = true;
            this.RemoveRBtn.Text = "Remove";
            this.RemoveRBtn.UseVisualStyleBackColor = true;
            this.RemoveRBtn.CheckedChanged += new System.EventHandler(this.RemoveRBtn_CheckedChanged);
            // 
            // EditRBtn
            // 
            this.EditRBtn.AutoSize = true;
            this.EditRBtn.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.EditRBtn.Location = new System.Drawing.Point(30, 69);
            this.EditRBtn.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.EditRBtn.Name = "EditRBtn";
            this.EditRBtn.Size = new System.Drawing.Size(45, 19);
            this.EditRBtn.TabIndex = 144;
            this.EditRBtn.TabStop = true;
            this.EditRBtn.Text = "Edit";
            this.EditRBtn.UseVisualStyleBackColor = true;
            this.EditRBtn.CheckedChanged += new System.EventHandler(this.EditRBtn_CheckedChanged);
            // 
            // AddRBtn
            // 
            this.AddRBtn.AutoSize = true;
            this.AddRBtn.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.AddRBtn.Location = new System.Drawing.Point(30, 50);
            this.AddRBtn.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.AddRBtn.Name = "AddRBtn";
            this.AddRBtn.Size = new System.Drawing.Size(47, 19);
            this.AddRBtn.TabIndex = 143;
            this.AddRBtn.TabStop = true;
            this.AddRBtn.Text = "Add";
            this.AddRBtn.UseVisualStyleBackColor = true;
            this.AddRBtn.CheckedChanged += new System.EventHandler(this.AddRBtn_CheckedChanged);
            // 
            // FindTransBtn
            // 
            this.FindTransBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FindTransBtn.ForeColor = System.Drawing.Color.White;
            this.FindTransBtn.Location = new System.Drawing.Point(171, 15);
            this.FindTransBtn.Name = "FindTransBtn";
            this.FindTransBtn.Size = new System.Drawing.Size(75, 23);
            this.FindTransBtn.TabIndex = 142;
            this.FindTransBtn.Text = "Find ID";
            this.FindTransBtn.UseVisualStyleBackColor = true;
            this.FindTransBtn.Visible = false;
            this.FindTransBtn.Click += new System.EventHandler(this.FindTransBtn_Click);
            // 
            // TransIdBx
            // 
            this.TransIdBx.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.TransIdBx.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TransIdBx.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TransIdBx.ForeColor = System.Drawing.SystemColors.Window;
            this.TransIdBx.Location = new System.Drawing.Point(253, 18);
            this.TransIdBx.Name = "TransIdBx";
            this.TransIdBx.Size = new System.Drawing.Size(72, 22);
            this.TransIdBx.TabIndex = 141;
            this.TransIdBx.Visible = false;
            // 
            // TransLbl
            // 
            this.TransLbl.AutoSize = true;
            this.TransLbl.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TransLbl.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.TransLbl.Location = new System.Drawing.Point(15, 9);
            this.TransLbl.Name = "TransLbl";
            this.TransLbl.Size = new System.Drawing.Size(134, 32);
            this.TransLbl.TabIndex = 140;
            this.TransLbl.Text = "Transaction";
            // 
            // level
            // 
            this.level.AutoSize = true;
            this.level.Font = new System.Drawing.Font("Segoe UI", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.level.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.level.Location = new System.Drawing.Point(515, 187);
            this.level.Name = "level";
            this.level.Size = new System.Drawing.Size(40, 19);
            this.level.TabIndex = 139;
            this.level.Text = "Level";
            // 
            // calcPriceBtn
            // 
            this.calcPriceBtn.AutoSize = true;
            this.calcPriceBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.calcPriceBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.calcPriceBtn.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.calcPriceBtn.Location = new System.Drawing.Point(226, 450);
            this.calcPriceBtn.Name = "calcPriceBtn";
            this.calcPriceBtn.Size = new System.Drawing.Size(68, 27);
            this.calcPriceBtn.TabIndex = 138;
            this.calcPriceBtn.Text = "Calculate";
            this.calcPriceBtn.UseVisualStyleBackColor = true;
            this.calcPriceBtn.Click += new System.EventHandler(this.calcPriceBtn_Click);
            // 
            // TransNew
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.ClientSize = new System.Drawing.Size(664, 492);
            this.Controls.Add(this.NewTransPnl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
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
        public Label order;
        public Label level;
        private Button FindTransBtn;
        private TextBox TransIdBx;
        private Label TransLbl;
        private CheckBox LateCheck;
        private RadioButton completeRBtn;
        private RadioButton RemoveRBtn;
        private RadioButton EditRBtn;
        private RadioButton AddRBtn;
        public Label selCarInfo;
        public Label CarLbl;
    }
}