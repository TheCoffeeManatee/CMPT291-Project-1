namespace Lab6_Modern
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TransNew));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.MemStatus = new System.Windows.Forms.Label();
            this.CID = new System.Windows.Forms.Label();
            this.CustPhone = new System.Windows.Forms.Label();
            this.Province = new System.Windows.Forms.Label();
            this.CustCity = new System.Windows.Forms.Label();
            this.CustAdd2 = new System.Windows.Forms.Label();
            this.CustAdd1 = new System.Windows.Forms.Label();
            this.CustName = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.FindCars = new System.Windows.Forms.Button();
            this.PriceLbl = new System.Windows.Forms.Label();
            this.CarTypePicker = new System.Windows.Forms.ComboBox();
            this.AddCustBtn = new System.Windows.Forms.Button();
            this.CarTable = new System.Windows.Forms.DataGridView();
            this.CarType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Make = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Model = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Year = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Seats = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VIN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RtnDateTime = new System.Windows.Forms.DateTimePicker();
            this.RtnBranchLbl = new System.Windows.Forms.ComboBox();
            this.RtnLbl = new System.Windows.Forms.Label();
            this.PickDateTime = new System.Windows.Forms.DateTimePicker();
            this.PickupBranchID = new System.Windows.Forms.ComboBox();
            this.PickupLbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.CarTable)).BeginInit();
            this.SuspendLayout();
            // 
            // MemStatus
            // 
            this.MemStatus.AutoSize = true;
            this.MemStatus.Font = new System.Drawing.Font("Segoe UI", 14.14286F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MemStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.MemStatus.Location = new System.Drawing.Point(886, 279);
            this.MemStatus.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.MemStatus.Name = "MemStatus";
            this.MemStatus.Size = new System.Drawing.Size(209, 46);
            this.MemStatus.TabIndex = 115;
            this.MemStatus.Text = "Membership";
            this.MemStatus.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.MemStatus.Visible = false;
            // 
            // CID
            // 
            this.CID.AutoSize = true;
            this.CID.Font = new System.Drawing.Font("Segoe UI", 14.14286F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.CID.Location = new System.Drawing.Point(552, 279);
            this.CID.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.CID.Name = "CID";
            this.CID.Size = new System.Drawing.Size(53, 46);
            this.CID.TabIndex = 114;
            this.CID.Text = "ID";
            this.CID.Visible = false;
            // 
            // CustPhone
            // 
            this.CustPhone.AutoSize = true;
            this.CustPhone.Font = new System.Drawing.Font("Segoe UI", 14.14286F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CustPhone.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.CustPhone.Location = new System.Drawing.Point(552, 234);
            this.CustPhone.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.CustPhone.Name = "CustPhone";
            this.CustPhone.Size = new System.Drawing.Size(223, 46);
            this.CustPhone.TabIndex = 113;
            this.CustPhone.Text = "(xxx) xxx-xxxx";
            this.CustPhone.Visible = false;
            // 
            // Province
            // 
            this.Province.AutoSize = true;
            this.Province.Font = new System.Drawing.Font("Segoe UI", 14.14286F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Province.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.Province.Location = new System.Drawing.Point(640, 184);
            this.Province.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.Province.Name = "Province";
            this.Province.Size = new System.Drawing.Size(148, 46);
            this.Province.TabIndex = 112;
            this.Province.Text = "Province";
            this.Province.Visible = false;
            // 
            // CustCity
            // 
            this.CustCity.AutoSize = true;
            this.CustCity.Font = new System.Drawing.Font("Segoe UI", 14.14286F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CustCity.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.CustCity.Location = new System.Drawing.Point(552, 184);
            this.CustCity.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.CustCity.Name = "CustCity";
            this.CustCity.Size = new System.Drawing.Size(77, 46);
            this.CustCity.TabIndex = 111;
            this.CustCity.Text = "City";
            this.CustCity.Visible = false;
            // 
            // CustAdd2
            // 
            this.CustAdd2.AutoSize = true;
            this.CustAdd2.Font = new System.Drawing.Font("Segoe UI", 14.14286F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CustAdd2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.CustAdd2.Location = new System.Drawing.Point(552, 139);
            this.CustAdd2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.CustAdd2.Name = "CustAdd2";
            this.CustAdd2.Size = new System.Drawing.Size(237, 46);
            this.CustAdd2.TabIndex = 110;
            this.CustAdd2.Text = "Address Line 2";
            this.CustAdd2.Visible = false;
            // 
            // CustAdd1
            // 
            this.CustAdd1.AutoSize = true;
            this.CustAdd1.Font = new System.Drawing.Font("Segoe UI", 14.14286F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CustAdd1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.CustAdd1.Location = new System.Drawing.Point(552, 94);
            this.CustAdd1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.CustAdd1.Name = "CustAdd1";
            this.CustAdd1.Size = new System.Drawing.Size(237, 46);
            this.CustAdd1.TabIndex = 109;
            this.CustAdd1.Text = "Address Line 1";
            this.CustAdd1.Visible = false;
            // 
            // CustName
            // 
            this.CustName.AutoSize = true;
            this.CustName.Font = new System.Drawing.Font("Segoe UI", 14.14286F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CustName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.CustName.Location = new System.Drawing.Point(552, 40);
            this.CustName.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.CustName.Name = "CustName";
            this.CustName.Size = new System.Drawing.Size(263, 46);
            this.CustName.TabIndex = 108;
            this.CustName.Text = "Customer Name";
            this.CustName.Visible = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.button1.Location = new System.Drawing.Point(940, 750);
            this.button1.Margin = new System.Windows.Forms.Padding(6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(148, 76);
            this.button1.TabIndex = 107;
            this.button1.Text = "Submit";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // FindCars
            // 
            this.FindCars.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.FindCars.FlatAppearance.BorderSize = 0;
            this.FindCars.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FindCars.Font = new System.Drawing.Font("Segoe UI", 9.857143F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FindCars.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.FindCars.Location = new System.Drawing.Point(951, 366);
            this.FindCars.Margin = new System.Windows.Forms.Padding(6);
            this.FindCars.Name = "FindCars";
            this.FindCars.Size = new System.Drawing.Size(137, 40);
            this.FindCars.TabIndex = 106;
            this.FindCars.Text = "Find Cars";
            this.FindCars.UseVisualStyleBackColor = false;
            this.FindCars.Click += new System.EventHandler(this.FindCars_Click);
            // 
            // PriceLbl
            // 
            this.PriceLbl.AutoSize = true;
            this.PriceLbl.Font = new System.Drawing.Font("Segoe UI", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PriceLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.PriceLbl.Location = new System.Drawing.Point(21, 771);
            this.PriceLbl.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.PriceLbl.Name = "PriceLbl";
            this.PriceLbl.Size = new System.Drawing.Size(103, 51);
            this.PriceLbl.TabIndex = 105;
            this.PriceLbl.Text = "Price";
            this.PriceLbl.Visible = false;
            // 
            // CarTypePicker
            // 
            this.CarTypePicker.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.CarTypePicker.FormattingEnabled = true;
            this.CarTypePicker.Items.AddRange(new object[] {
            "SUV",
            "Luxery",
            "Sport"});
            this.CarTypePicker.Location = new System.Drawing.Point(552, 365);
            this.CarTypePicker.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.CarTypePicker.Name = "CarTypePicker";
            this.CarTypePicker.Size = new System.Drawing.Size(370, 38);
            this.CarTypePicker.TabIndex = 104;
            this.CarTypePicker.Text = "Car Type";
            // 
            // AddCustBtn
            // 
            this.AddCustBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.AddCustBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("AddCustBtn.BackgroundImage")));
            this.AddCustBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.AddCustBtn.FlatAppearance.BorderSize = 0;
            this.AddCustBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddCustBtn.Location = new System.Drawing.Point(1073, 40);
            this.AddCustBtn.Margin = new System.Windows.Forms.Padding(6);
            this.AddCustBtn.Name = "AddCustBtn";
            this.AddCustBtn.Size = new System.Drawing.Size(38, 38);
            this.AddCustBtn.TabIndex = 96;
            this.AddCustBtn.UseVisualStyleBackColor = true;
            this.AddCustBtn.Click += new System.EventHandler(this.AddCustBtn_Click);
            // 
            // CarTable
            // 
            this.CarTable.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.CarTable.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(79)))), ((int)(((byte)(99)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.CarTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.CarTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CarTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CarType,
            this.Make,
            this.Model,
            this.Year,
            this.Seats,
            this.VIN});
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(79)))), ((int)(((byte)(99)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.CarTable.DefaultCellStyle = dataGridViewCellStyle8;
            this.CarTable.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.CarTable.Location = new System.Drawing.Point(21, 436);
            this.CarTable.Margin = new System.Windows.Forms.Padding(6);
            this.CarTable.Name = "CarTable";
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(79)))), ((int)(((byte)(99)))));
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.CarTable.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.CarTable.RowHeadersVisible = false;
            this.CarTable.RowHeadersWidth = 82;
            this.CarTable.RowTemplate.Height = 25;
            this.CarTable.Size = new System.Drawing.Size(1066, 292);
            this.CarTable.TabIndex = 103;
            // 
            // CarType
            // 
            this.CarType.HeaderText = "CarType";
            this.CarType.MinimumWidth = 10;
            this.CarType.Name = "CarType";
            this.CarType.Width = 200;
            // 
            // Make
            // 
            this.Make.HeaderText = "Make";
            this.Make.MinimumWidth = 10;
            this.Make.Name = "Make";
            this.Make.Width = 200;
            // 
            // Model
            // 
            this.Model.HeaderText = "Model";
            this.Model.MinimumWidth = 10;
            this.Model.Name = "Model";
            this.Model.Width = 200;
            // 
            // Year
            // 
            this.Year.HeaderText = "Year";
            this.Year.MinimumWidth = 10;
            this.Year.Name = "Year";
            this.Year.Width = 200;
            // 
            // Seats
            // 
            this.Seats.HeaderText = "Seats";
            this.Seats.MinimumWidth = 10;
            this.Seats.Name = "Seats";
            this.Seats.Width = 200;
            // 
            // VIN
            // 
            this.VIN.HeaderText = "VIN";
            this.VIN.MinimumWidth = 10;
            this.VIN.Name = "VIN";
            this.VIN.Width = 200;
            // 
            // RtnDateTime
            // 
            this.RtnDateTime.CalendarMonthBackground = System.Drawing.SystemColors.ScrollBar;
            this.RtnDateTime.Location = new System.Drawing.Point(21, 366);
            this.RtnDateTime.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.RtnDateTime.Name = "RtnDateTime";
            this.RtnDateTime.Size = new System.Drawing.Size(370, 35);
            this.RtnDateTime.TabIndex = 102;
            // 
            // RtnBranchLbl
            // 
            this.RtnBranchLbl.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.RtnBranchLbl.FormattingEnabled = true;
            this.RtnBranchLbl.Items.AddRange(new object[] {
            "Branch 1",
            "Branch 2",
            "Branch 3",
            "Branch 4"});
            this.RtnBranchLbl.Location = new System.Drawing.Point(21, 302);
            this.RtnBranchLbl.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.RtnBranchLbl.Name = "RtnBranchLbl";
            this.RtnBranchLbl.Size = new System.Drawing.Size(370, 38);
            this.RtnBranchLbl.TabIndex = 101;
            this.RtnBranchLbl.Text = "Branch 1";
            // 
            // RtnLbl
            // 
            this.RtnLbl.AutoSize = true;
            this.RtnLbl.Font = new System.Drawing.Font("Segoe UI", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.RtnLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.RtnLbl.Location = new System.Drawing.Point(136, 228);
            this.RtnLbl.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.RtnLbl.Name = "RtnLbl";
            this.RtnLbl.Size = new System.Drawing.Size(134, 51);
            this.RtnLbl.TabIndex = 100;
            this.RtnLbl.Text = "Return";
            // 
            // PickDateTime
            // 
            this.PickDateTime.CalendarMonthBackground = System.Drawing.SystemColors.ScrollBar;
            this.PickDateTime.Location = new System.Drawing.Point(21, 165);
            this.PickDateTime.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.PickDateTime.Name = "PickDateTime";
            this.PickDateTime.Size = new System.Drawing.Size(370, 35);
            this.PickDateTime.TabIndex = 99;
            // 
            // PickupBranchID
            // 
            this.PickupBranchID.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.PickupBranchID.FormattingEnabled = true;
            this.PickupBranchID.Items.AddRange(new object[] {
            "Branch 1",
            "Branch 2",
            "Branch 3",
            "Branch 4"});
            this.PickupBranchID.Location = new System.Drawing.Point(21, 101);
            this.PickupBranchID.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.PickupBranchID.Name = "PickupBranchID";
            this.PickupBranchID.Size = new System.Drawing.Size(370, 38);
            this.PickupBranchID.TabIndex = 98;
            this.PickupBranchID.Text = "Branch 1";
            // 
            // PickupLbl
            // 
            this.PickupLbl.AutoSize = true;
            this.PickupLbl.Font = new System.Drawing.Font("Segoe UI", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PickupLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.PickupLbl.Location = new System.Drawing.Point(126, 27);
            this.PickupLbl.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.PickupLbl.Name = "PickupLbl";
            this.PickupLbl.Size = new System.Drawing.Size(133, 51);
            this.PickupLbl.TabIndex = 97;
            this.PickupLbl.Text = "Pickup";
            // 
            // TransNew
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(1138, 844);
            this.Controls.Add(this.MemStatus);
            this.Controls.Add(this.CID);
            this.Controls.Add(this.CustPhone);
            this.Controls.Add(this.Province);
            this.Controls.Add(this.CustCity);
            this.Controls.Add(this.CustAdd2);
            this.Controls.Add(this.CustAdd1);
            this.Controls.Add(this.CustName);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.FindCars);
            this.Controls.Add(this.PriceLbl);
            this.Controls.Add(this.CarTypePicker);
            this.Controls.Add(this.AddCustBtn);
            this.Controls.Add(this.CarTable);
            this.Controls.Add(this.RtnDateTime);
            this.Controls.Add(this.RtnBranchLbl);
            this.Controls.Add(this.RtnLbl);
            this.Controls.Add(this.PickDateTime);
            this.Controls.Add(this.PickupBranchID);
            this.Controls.Add(this.PickupLbl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TransNew";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.CarTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label MemStatus;
        private Label CID;
        private Label CustPhone;
        private Label Province;
        private Label CustCity;
        private Label CustAdd2;
        private Label CustAdd1;
        private Label CustName;
        private Button button1;
        private Button FindCars;
        public Label PriceLbl;
        private ComboBox CarTypePicker;
        private Button AddCustBtn;
        private DataGridView CarTable;
        private DataGridViewTextBoxColumn CarType;
        private DataGridViewTextBoxColumn Make;
        private DataGridViewTextBoxColumn Model;
        private DataGridViewTextBoxColumn Year;
        private DataGridViewTextBoxColumn Seats;
        private DataGridViewTextBoxColumn VIN;
        private DateTimePicker RtnDateTime;
        private ComboBox RtnBranchLbl;
        private Label RtnLbl;
        private DateTimePicker PickDateTime;
        private ComboBox PickupBranchID;
        private Label PickupLbl;
    }
}