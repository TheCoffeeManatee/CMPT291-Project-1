namespace Lab6_Modern
{
    partial class TransactionsFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TransactionsFrm));
            this.HomeFormLabel = new System.Windows.Forms.Label();
            this.AddTransPnl = new System.Windows.Forms.Panel();
            this.DisplayCustID = new System.Windows.Forms.Label();
            this.DisplayName = new System.Windows.Forms.Label();
            this.ChooseCustBtn = new System.Windows.Forms.Button();
            this.CarTypePicker = new System.Windows.Forms.ComboBox();
            this.CarTypelbl = new System.Windows.Forms.Label();
            this.RtnDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.RtnDateTimelbl = new System.Windows.Forms.Label();
            this.RtnBPicker = new System.Windows.Forms.ComboBox();
            this.RtnBlbl = new System.Windows.Forms.Label();
            this.PickDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.PickDateTimelbl = new System.Windows.Forms.Label();
            this.PickBPicker = new System.Windows.Forms.ComboBox();
            this.PickBlbl = new System.Windows.Forms.Label();
            this.SecondNum = new System.Windows.Forms.TextBox();
            this.QueryBtn = new System.Windows.Forms.Button();
            this.NewBtn = new System.Windows.Forms.Button();
            this.TransIDNum = new System.Windows.Forms.Label();
            this.AddTransPnl.SuspendLayout();
            this.SuspendLayout();
            // 
            // HomeFormLabel
            // 
            this.HomeFormLabel.AutoSize = true;
            this.HomeFormLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.HomeFormLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.HomeFormLabel.Location = new System.Drawing.Point(37, 45);
            this.HomeFormLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.HomeFormLabel.Name = "HomeFormLabel";
            this.HomeFormLabel.Size = new System.Drawing.Size(371, 67);
            this.HomeFormLabel.TabIndex = 5;
            this.HomeFormLabel.Text = "Transactions";
            this.HomeFormLabel.Click += new System.EventHandler(this.HomeFormLabel_Click);
            // 
            // AddTransPnl
            // 
            this.AddTransPnl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.AddTransPnl.Controls.Add(this.TransIDNum);
            this.AddTransPnl.Controls.Add(this.DisplayCustID);
            this.AddTransPnl.Controls.Add(this.DisplayName);
            this.AddTransPnl.Controls.Add(this.ChooseCustBtn);
            this.AddTransPnl.Controls.Add(this.CarTypePicker);
            this.AddTransPnl.Controls.Add(this.CarTypelbl);
            this.AddTransPnl.Controls.Add(this.RtnDateTimePicker);
            this.AddTransPnl.Controls.Add(this.RtnDateTimelbl);
            this.AddTransPnl.Controls.Add(this.RtnBPicker);
            this.AddTransPnl.Controls.Add(this.RtnBlbl);
            this.AddTransPnl.Controls.Add(this.PickDateTimePicker);
            this.AddTransPnl.Controls.Add(this.PickDateTimelbl);
            this.AddTransPnl.Controls.Add(this.PickBPicker);
            this.AddTransPnl.Controls.Add(this.PickBlbl);
            this.AddTransPnl.Controls.Add(this.SecondNum);
            this.AddTransPnl.Location = new System.Drawing.Point(0, 150);
            this.AddTransPnl.Margin = new System.Windows.Forms.Padding(6);
            this.AddTransPnl.Name = "AddTransPnl";
            this.AddTransPnl.Size = new System.Drawing.Size(1233, 900);
            this.AddTransPnl.TabIndex = 6;
            // 
            // DisplayCustID
            // 
            this.DisplayCustID.AutoSize = true;
            this.DisplayCustID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.DisplayCustID.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DisplayCustID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.DisplayCustID.Location = new System.Drawing.Point(408, 41);
            this.DisplayCustID.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.DisplayCustID.Name = "DisplayCustID";
            this.DisplayCustID.Size = new System.Drawing.Size(225, 42);
            this.DisplayCustID.TabIndex = 30;
            this.DisplayCustID.Text = "Customer ID";
            // 
            // DisplayName
            // 
            this.DisplayName.AutoSize = true;
            this.DisplayName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.DisplayName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DisplayName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.DisplayName.Location = new System.Drawing.Point(107, 39);
            this.DisplayName.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.DisplayName.Name = "DisplayName";
            this.DisplayName.Size = new System.Drawing.Size(288, 42);
            this.DisplayName.TabIndex = 28;
            this.DisplayName.Text = "Customer Name";
            // 
            // ChooseCustBtn
            // 
            this.ChooseCustBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ChooseCustBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ChooseCustBtn.BackgroundImage")));
            this.ChooseCustBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ChooseCustBtn.FlatAppearance.BorderSize = 0;
            this.ChooseCustBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ChooseCustBtn.Location = new System.Drawing.Point(53, 39);
            this.ChooseCustBtn.Margin = new System.Windows.Forms.Padding(6);
            this.ChooseCustBtn.Name = "ChooseCustBtn";
            this.ChooseCustBtn.Size = new System.Drawing.Size(42, 42);
            this.ChooseCustBtn.TabIndex = 11;
            this.ChooseCustBtn.UseVisualStyleBackColor = true;
            this.ChooseCustBtn.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // CarTypePicker
            // 
            this.CarTypePicker.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(79)))), ((int)(((byte)(99)))));
            this.CarTypePicker.FormattingEnabled = true;
            this.CarTypePicker.Items.AddRange(new object[] {
            "SUV",
            "Luxery",
            "Sport"});
            this.CarTypePicker.Location = new System.Drawing.Point(408, 252);
            this.CarTypePicker.Margin = new System.Windows.Forms.Padding(6);
            this.CarTypePicker.Name = "CarTypePicker";
            this.CarTypePicker.Size = new System.Drawing.Size(268, 40);
            this.CarTypePicker.TabIndex = 26;
            // 
            // CarTypelbl
            // 
            this.CarTypelbl.AutoSize = true;
            this.CarTypelbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CarTypelbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.CarTypelbl.Location = new System.Drawing.Point(196, 250);
            this.CarTypelbl.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.CarTypelbl.Name = "CarTypelbl";
            this.CarTypelbl.Size = new System.Drawing.Size(182, 42);
            this.CarTypelbl.TabIndex = 25;
            this.CarTypelbl.Text = "Car Type:";
            // 
            // RtnDateTimePicker
            // 
            this.RtnDateTimePicker.CalendarMonthBackground = System.Drawing.SystemColors.ScrollBar;
            this.RtnDateTimePicker.Location = new System.Drawing.Point(408, 605);
            this.RtnDateTimePicker.Name = "RtnDateTimePicker";
            this.RtnDateTimePicker.Size = new System.Drawing.Size(268, 39);
            this.RtnDateTimePicker.TabIndex = 24;
            // 
            // RtnDateTimelbl
            // 
            this.RtnDateTimelbl.AutoSize = true;
            this.RtnDateTimelbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.RtnDateTimelbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.RtnDateTimelbl.Location = new System.Drawing.Point(73, 603);
            this.RtnDateTimelbl.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.RtnDateTimelbl.Name = "RtnDateTimelbl";
            this.RtnDateTimelbl.Size = new System.Drawing.Size(321, 42);
            this.RtnDateTimelbl.TabIndex = 23;
            this.RtnDateTimelbl.Text = "Return Date/Time:";
            // 
            // RtnBPicker
            // 
            this.RtnBPicker.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(79)))), ((int)(((byte)(99)))));
            this.RtnBPicker.FormattingEnabled = true;
            this.RtnBPicker.Items.AddRange(new object[] {
            "Branch 1 - Name",
            "Branch 2 - Name"});
            this.RtnBPicker.Location = new System.Drawing.Point(408, 548);
            this.RtnBPicker.Margin = new System.Windows.Forms.Padding(6);
            this.RtnBPicker.Name = "RtnBPicker";
            this.RtnBPicker.Size = new System.Drawing.Size(268, 40);
            this.RtnBPicker.TabIndex = 21;
            // 
            // RtnBlbl
            // 
            this.RtnBlbl.AutoSize = true;
            this.RtnBlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.RtnBlbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.RtnBlbl.Location = new System.Drawing.Point(126, 546);
            this.RtnBlbl.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.RtnBlbl.Name = "RtnBlbl";
            this.RtnBlbl.Size = new System.Drawing.Size(269, 42);
            this.RtnBlbl.TabIndex = 22;
            this.RtnBlbl.Text = "Return Branch:";
            // 
            // PickDateTimePicker
            // 
            this.PickDateTimePicker.CalendarMonthBackground = System.Drawing.SystemColors.ScrollBar;
            this.PickDateTimePicker.Location = new System.Drawing.Point(408, 464);
            this.PickDateTimePicker.Name = "PickDateTimePicker";
            this.PickDateTimePicker.Size = new System.Drawing.Size(268, 39);
            this.PickDateTimePicker.TabIndex = 20;
            // 
            // PickDateTimelbl
            // 
            this.PickDateTimelbl.AutoSize = true;
            this.PickDateTimelbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PickDateTimelbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.PickDateTimelbl.Location = new System.Drawing.Point(72, 464);
            this.PickDateTimelbl.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.PickDateTimelbl.Name = "PickDateTimelbl";
            this.PickDateTimelbl.Size = new System.Drawing.Size(322, 42);
            this.PickDateTimelbl.TabIndex = 19;
            this.PickDateTimelbl.Text = "Pickup Date/Time:";
            // 
            // PickBPicker
            // 
            this.PickBPicker.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(79)))), ((int)(((byte)(99)))));
            this.PickBPicker.FormattingEnabled = true;
            this.PickBPicker.Items.AddRange(new object[] {
            "Branch 1 - Name",
            "Branch 2 - Name"});
            this.PickBPicker.Location = new System.Drawing.Point(408, 406);
            this.PickBPicker.Margin = new System.Windows.Forms.Padding(6);
            this.PickBPicker.Name = "PickBPicker";
            this.PickBPicker.Size = new System.Drawing.Size(268, 40);
            this.PickBPicker.TabIndex = 12;
            // 
            // PickBlbl
            // 
            this.PickBlbl.AutoSize = true;
            this.PickBlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PickBlbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.PickBlbl.Location = new System.Drawing.Point(125, 406);
            this.PickBlbl.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.PickBlbl.Name = "PickBlbl";
            this.PickBlbl.Size = new System.Drawing.Size(270, 42);
            this.PickBlbl.TabIndex = 16;
            this.PickBlbl.Text = "Pickup Branch:";
            this.PickBlbl.Click += new System.EventHandler(this.PickBID_Click);
            // 
            // SecondNum
            // 
            this.SecondNum.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(79)))), ((int)(((byte)(99)))));
            this.SecondNum.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.SecondNum.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SecondNum.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.SecondNum.Location = new System.Drawing.Point(541, 709);
            this.SecondNum.Margin = new System.Windows.Forms.Padding(6);
            this.SecondNum.Name = "SecondNum";
            this.SecondNum.Size = new System.Drawing.Size(247, 43);
            this.SecondNum.TabIndex = 5;
            this.SecondNum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // QueryBtn
            // 
            this.QueryBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.QueryBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("QueryBtn.BackgroundImage")));
            this.QueryBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.QueryBtn.FlatAppearance.BorderSize = 0;
            this.QueryBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.QueryBtn.Location = new System.Drawing.Point(465, 56);
            this.QueryBtn.Margin = new System.Windows.Forms.Padding(6);
            this.QueryBtn.Name = "QueryBtn";
            this.QueryBtn.Size = new System.Drawing.Size(45, 48);
            this.QueryBtn.TabIndex = 10;
            this.QueryBtn.UseVisualStyleBackColor = true;
            this.QueryBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // NewBtn
            // 
            this.NewBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.NewBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("NewBtn.BackgroundImage")));
            this.NewBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.NewBtn.FlatAppearance.BorderSize = 0;
            this.NewBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NewBtn.Location = new System.Drawing.Point(408, 56);
            this.NewBtn.Margin = new System.Windows.Forms.Padding(6);
            this.NewBtn.Name = "NewBtn";
            this.NewBtn.Size = new System.Drawing.Size(45, 48);
            this.NewBtn.TabIndex = 9;
            this.NewBtn.UseVisualStyleBackColor = true;
            this.NewBtn.Click += new System.EventHandler(this.NewBtn_Click);
            // 
            // TransIDNum
            // 
            this.TransIDNum.AutoSize = true;
            this.TransIDNum.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.TransIDNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TransIDNum.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.TransIDNum.Location = new System.Drawing.Point(937, 35);
            this.TransIDNum.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.TransIDNum.Name = "TransIDNum";
            this.TransIDNum.Size = new System.Drawing.Size(248, 42);
            this.TransIDNum.TabIndex = 30;
            this.TransIDNum.Text = "Trans ID Num";
            // 
            // TransactionsFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(1233, 1050);
            this.Controls.Add(this.QueryBtn);
            this.Controls.Add(this.NewBtn);
            this.Controls.Add(this.HomeFormLabel);
            this.Controls.Add(this.AddTransPnl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "TransactionsFrm";
            this.Text = "HomeFrm";
            this.Load += new System.EventHandler(this.HomeFrm_Load);
            this.AddTransPnl.ResumeLayout(false);
            this.AddTransPnl.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label HomeFormLabel;
        private Panel AddTransPnl;
        private TextBox SecondNum;
        private Button QueryBtn;
        private Button NewBtn;
        private Label PickBlbl;
        private ComboBox PickBPicker;
        private DateTimePicker PickDateTimePicker;
        private Label PickDateTimelbl;
        private DateTimePicker RtnDateTimePicker;
        private Label RtnDateTimelbl;
        private ComboBox RtnBPicker;
        private Label RtnBlbl;
        private Button ChooseCustBtn;
        private ComboBox CarTypePicker;
        private Label CarTypelbl;
        private Label DisplayName;
        private Label TransIDNum;
        private Label DisplayCustID;
    }
}