namespace CMPT291_Project
{
    partial class CustEntry
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
            this.mementry = new System.Windows.Forms.CheckBox();
            this.DOBEntry = new System.Windows.Forms.DateTimePicker();
            this.FindID = new System.Windows.Forms.Button();
            this.CustIdBx = new System.Windows.Forms.TextBox();
            this.RemoveRBtn = new System.Windows.Forms.RadioButton();
            this.EditRBtn = new System.Windows.Forms.RadioButton();
            this.AddRBtn = new System.Windows.Forms.RadioButton();
            this.custentrycancel = new System.Windows.Forms.Button();
            this.custentryacc = new System.Windows.Forms.Button();
            this.cmemL = new System.Windows.Forms.Label();
            this.dlL = new System.Windows.Forms.Label();
            this.cinsL = new System.Windows.Forms.Label();
            this.phoneL = new System.Windows.Forms.Label();
            this.dlentry = new System.Windows.Forms.TextBox();
            this.cinsentry = new System.Windows.Forms.TextBox();
            this.phoneentry = new System.Windows.Forms.TextBox();
            this.dobL = new System.Windows.Forms.Label();
            this.postalL = new System.Windows.Forms.Label();
            this.provL = new System.Windows.Forms.Label();
            this.cityL = new System.Windows.Forms.Label();
            this.add2L = new System.Windows.Forms.Label();
            this.postalentry = new System.Windows.Forms.TextBox();
            this.proventry = new System.Windows.Forms.TextBox();
            this.cityentry = new System.Windows.Forms.TextBox();
            this.add2entry = new System.Windows.Forms.TextBox();
            this.add1entry = new System.Windows.Forms.TextBox();
            this.lnameentry = new System.Windows.Forms.TextBox();
            this.mnameentry = new System.Windows.Forms.TextBox();
            this.fnameentry = new System.Windows.Forms.TextBox();
            this.add1L = new System.Windows.Forms.Label();
            this.lnameL = new System.Windows.Forms.Label();
            this.mnameL = new System.Windows.Forms.Label();
            this.fnameL = new System.Windows.Forms.Label();
            this.custentrytitle = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // mementry
            // 
            this.mementry.AutoSize = true;
            this.mementry.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.mementry.Location = new System.Drawing.Point(418, 130);
            this.mementry.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.mementry.Name = "mementry";
            this.mementry.Size = new System.Drawing.Size(51, 19);
            this.mementry.TabIndex = 145;
            this.mementry.Text = "Gold";
            this.mementry.UseVisualStyleBackColor = true;
            this.mementry.CheckedChanged += new System.EventHandler(this.mementry_CheckedChanged_1);
            // 
            // DOBEntry
            // 
            this.DOBEntry.CalendarMonthBackground = System.Drawing.SystemColors.ScrollBar;
            this.DOBEntry.Location = new System.Drawing.Point(108, 272);
            this.DOBEntry.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.DOBEntry.Name = "DOBEntry";
            this.DOBEntry.Size = new System.Drawing.Size(183, 23);
            this.DOBEntry.TabIndex = 144;
            // 
            // FindID
            // 
            this.FindID.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FindID.ForeColor = System.Drawing.Color.White;
            this.FindID.Location = new System.Drawing.Point(164, 9);
            this.FindID.Name = "FindID";
            this.FindID.Size = new System.Drawing.Size(75, 23);
            this.FindID.TabIndex = 143;
            this.FindID.Text = "Find ID";
            this.FindID.UseVisualStyleBackColor = true;
            this.FindID.Visible = false;
            this.FindID.Click += new System.EventHandler(this.FindID_Click_1);
            // 
            // CustIdBx
            // 
            this.CustIdBx.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.CustIdBx.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CustIdBx.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CustIdBx.ForeColor = System.Drawing.SystemColors.Window;
            this.CustIdBx.Location = new System.Drawing.Point(245, 11);
            this.CustIdBx.Name = "CustIdBx";
            this.CustIdBx.Size = new System.Drawing.Size(45, 22);
            this.CustIdBx.TabIndex = 142;
            this.CustIdBx.Visible = false;
            // 
            // RemoveRBtn
            // 
            this.RemoveRBtn.AutoSize = true;
            this.RemoveRBtn.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.RemoveRBtn.Location = new System.Drawing.Point(337, 247);
            this.RemoveRBtn.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.RemoveRBtn.Name = "RemoveRBtn";
            this.RemoveRBtn.Size = new System.Drawing.Size(68, 19);
            this.RemoveRBtn.TabIndex = 141;
            this.RemoveRBtn.TabStop = true;
            this.RemoveRBtn.Text = "Remove";
            this.RemoveRBtn.UseVisualStyleBackColor = true;
            this.RemoveRBtn.CheckedChanged += new System.EventHandler(this.RemoveRBtn_CheckedChanged_1);
            // 
            // EditRBtn
            // 
            this.EditRBtn.AutoSize = true;
            this.EditRBtn.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.EditRBtn.Location = new System.Drawing.Point(337, 218);
            this.EditRBtn.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.EditRBtn.Name = "EditRBtn";
            this.EditRBtn.Size = new System.Drawing.Size(45, 19);
            this.EditRBtn.TabIndex = 140;
            this.EditRBtn.TabStop = true;
            this.EditRBtn.Text = "Edit";
            this.EditRBtn.UseVisualStyleBackColor = true;
            this.EditRBtn.CheckedChanged += new System.EventHandler(this.EditRBtn_CheckedChanged_1);
            // 
            // AddRBtn
            // 
            this.AddRBtn.AutoSize = true;
            this.AddRBtn.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.AddRBtn.Location = new System.Drawing.Point(337, 186);
            this.AddRBtn.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.AddRBtn.Name = "AddRBtn";
            this.AddRBtn.Size = new System.Drawing.Size(47, 19);
            this.AddRBtn.TabIndex = 139;
            this.AddRBtn.TabStop = true;
            this.AddRBtn.Text = "Add";
            this.AddRBtn.UseVisualStyleBackColor = true;
            this.AddRBtn.CheckedChanged += new System.EventHandler(this.AddRBtn_CheckedChanged_1);
            // 
            // custentrycancel
            // 
            this.custentrycancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(79)))), ((int)(((byte)(99)))));
            this.custentrycancel.FlatAppearance.BorderSize = 0;
            this.custentrycancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.custentrycancel.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.custentrycancel.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.custentrycancel.Location = new System.Drawing.Point(464, 232);
            this.custentrycancel.Name = "custentrycancel";
            this.custentrycancel.Size = new System.Drawing.Size(99, 50);
            this.custentrycancel.TabIndex = 138;
            this.custentrycancel.Text = "Cancel";
            this.custentrycancel.UseVisualStyleBackColor = false;
            this.custentrycancel.Click += new System.EventHandler(this.custentrycancel_Click_1);
            // 
            // custentryacc
            // 
            this.custentryacc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(79)))), ((int)(((byte)(99)))));
            this.custentryacc.FlatAppearance.BorderSize = 0;
            this.custentryacc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.custentryacc.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.custentryacc.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.custentryacc.Location = new System.Drawing.Point(464, 176);
            this.custentryacc.Name = "custentryacc";
            this.custentryacc.Size = new System.Drawing.Size(99, 50);
            this.custentryacc.TabIndex = 137;
            this.custentryacc.Text = "Accept";
            this.custentryacc.UseVisualStyleBackColor = false;
            this.custentryacc.Click += new System.EventHandler(this.custentryacc_Click_1);
            // 
            // cmemL
            // 
            this.cmemL.AutoSize = true;
            this.cmemL.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.cmemL.Location = new System.Drawing.Point(309, 129);
            this.cmemL.Name = "cmemL";
            this.cmemL.Size = new System.Drawing.Size(87, 15);
            this.cmemL.TabIndex = 136;
            this.cmemL.Text = "Member Status";
            // 
            // dlL
            // 
            this.dlL.AutoSize = true;
            this.dlL.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.dlL.Location = new System.Drawing.Point(309, 100);
            this.dlL.Name = "dlL";
            this.dlL.Size = new System.Drawing.Size(88, 15);
            this.dlL.TabIndex = 135;
            this.dlL.Text = "Driver\'s License";
            // 
            // cinsL
            // 
            this.cinsL.AutoSize = true;
            this.cinsL.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.cinsL.Location = new System.Drawing.Point(309, 71);
            this.cinsL.Name = "cinsL";
            this.cinsL.Size = new System.Drawing.Size(58, 15);
            this.cinsL.TabIndex = 134;
            this.cinsL.Text = "Insurance";
            // 
            // phoneL
            // 
            this.phoneL.AutoSize = true;
            this.phoneL.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.phoneL.Location = new System.Drawing.Point(309, 42);
            this.phoneL.Name = "phoneL";
            this.phoneL.Size = new System.Drawing.Size(88, 15);
            this.phoneL.TabIndex = 133;
            this.phoneL.Text = "Phone Number";
            // 
            // dlentry
            // 
            this.dlentry.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.dlentry.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dlentry.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dlentry.ForeColor = System.Drawing.SystemColors.Window;
            this.dlentry.Location = new System.Drawing.Point(418, 97);
            this.dlentry.Name = "dlentry";
            this.dlentry.Size = new System.Drawing.Size(182, 22);
            this.dlentry.TabIndex = 132;
            // 
            // cinsentry
            // 
            this.cinsentry.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.cinsentry.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.cinsentry.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cinsentry.ForeColor = System.Drawing.SystemColors.Window;
            this.cinsentry.Location = new System.Drawing.Point(418, 68);
            this.cinsentry.Name = "cinsentry";
            this.cinsentry.Size = new System.Drawing.Size(182, 22);
            this.cinsentry.TabIndex = 131;
            // 
            // phoneentry
            // 
            this.phoneentry.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.phoneentry.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.phoneentry.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.phoneentry.ForeColor = System.Drawing.SystemColors.Window;
            this.phoneentry.Location = new System.Drawing.Point(418, 39);
            this.phoneentry.Name = "phoneentry";
            this.phoneentry.Size = new System.Drawing.Size(182, 22);
            this.phoneentry.TabIndex = 130;
            // 
            // dobL
            // 
            this.dobL.AutoSize = true;
            this.dobL.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.dobL.Location = new System.Drawing.Point(16, 274);
            this.dobL.Name = "dobL";
            this.dobL.Size = new System.Drawing.Size(73, 15);
            this.dobL.TabIndex = 129;
            this.dobL.Text = "Date of Birth";
            // 
            // postalL
            // 
            this.postalL.AutoSize = true;
            this.postalL.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.postalL.Location = new System.Drawing.Point(16, 245);
            this.postalL.Name = "postalL";
            this.postalL.Size = new System.Drawing.Size(70, 15);
            this.postalL.TabIndex = 128;
            this.postalL.Text = "Postal Code";
            // 
            // provL
            // 
            this.provL.AutoSize = true;
            this.provL.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.provL.Location = new System.Drawing.Point(16, 216);
            this.provL.Name = "provL";
            this.provL.Size = new System.Drawing.Size(53, 15);
            this.provL.TabIndex = 127;
            this.provL.Text = "Province";
            // 
            // cityL
            // 
            this.cityL.AutoSize = true;
            this.cityL.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.cityL.Location = new System.Drawing.Point(16, 187);
            this.cityL.Name = "cityL";
            this.cityL.Size = new System.Drawing.Size(28, 15);
            this.cityL.TabIndex = 126;
            this.cityL.Text = "City";
            // 
            // add2L
            // 
            this.add2L.AutoSize = true;
            this.add2L.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.add2L.Location = new System.Drawing.Point(16, 158);
            this.add2L.Name = "add2L";
            this.add2L.Size = new System.Drawing.Size(83, 15);
            this.add2L.TabIndex = 125;
            this.add2L.Text = "Address Line 2";
            // 
            // postalentry
            // 
            this.postalentry.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.postalentry.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.postalentry.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.postalentry.ForeColor = System.Drawing.SystemColors.Window;
            this.postalentry.Location = new System.Drawing.Point(108, 242);
            this.postalentry.Name = "postalentry";
            this.postalentry.Size = new System.Drawing.Size(181, 22);
            this.postalentry.TabIndex = 124;
            // 
            // proventry
            // 
            this.proventry.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.proventry.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.proventry.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.proventry.ForeColor = System.Drawing.SystemColors.Window;
            this.proventry.Location = new System.Drawing.Point(108, 213);
            this.proventry.Name = "proventry";
            this.proventry.Size = new System.Drawing.Size(181, 22);
            this.proventry.TabIndex = 123;
            // 
            // cityentry
            // 
            this.cityentry.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.cityentry.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.cityentry.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cityentry.ForeColor = System.Drawing.SystemColors.Window;
            this.cityentry.Location = new System.Drawing.Point(108, 184);
            this.cityentry.Name = "cityentry";
            this.cityentry.Size = new System.Drawing.Size(181, 22);
            this.cityentry.TabIndex = 122;
            // 
            // add2entry
            // 
            this.add2entry.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.add2entry.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.add2entry.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.add2entry.ForeColor = System.Drawing.SystemColors.Window;
            this.add2entry.Location = new System.Drawing.Point(108, 155);
            this.add2entry.Name = "add2entry";
            this.add2entry.Size = new System.Drawing.Size(181, 22);
            this.add2entry.TabIndex = 121;
            // 
            // add1entry
            // 
            this.add1entry.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.add1entry.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.add1entry.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.add1entry.ForeColor = System.Drawing.SystemColors.Window;
            this.add1entry.Location = new System.Drawing.Point(108, 126);
            this.add1entry.Name = "add1entry";
            this.add1entry.Size = new System.Drawing.Size(181, 22);
            this.add1entry.TabIndex = 120;
            // 
            // lnameentry
            // 
            this.lnameentry.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.lnameentry.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lnameentry.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lnameentry.ForeColor = System.Drawing.SystemColors.Window;
            this.lnameentry.Location = new System.Drawing.Point(108, 97);
            this.lnameentry.Name = "lnameentry";
            this.lnameentry.Size = new System.Drawing.Size(181, 22);
            this.lnameentry.TabIndex = 119;
            // 
            // mnameentry
            // 
            this.mnameentry.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.mnameentry.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mnameentry.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.mnameentry.ForeColor = System.Drawing.SystemColors.Window;
            this.mnameentry.Location = new System.Drawing.Point(108, 68);
            this.mnameentry.Name = "mnameentry";
            this.mnameentry.Size = new System.Drawing.Size(181, 22);
            this.mnameentry.TabIndex = 118;
            // 
            // fnameentry
            // 
            this.fnameentry.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.fnameentry.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.fnameentry.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.fnameentry.ForeColor = System.Drawing.SystemColors.Window;
            this.fnameentry.Location = new System.Drawing.Point(108, 39);
            this.fnameentry.Name = "fnameentry";
            this.fnameentry.Size = new System.Drawing.Size(181, 22);
            this.fnameentry.TabIndex = 117;
            // 
            // add1L
            // 
            this.add1L.AutoSize = true;
            this.add1L.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.add1L.Location = new System.Drawing.Point(16, 129);
            this.add1L.Name = "add1L";
            this.add1L.Size = new System.Drawing.Size(83, 15);
            this.add1L.TabIndex = 116;
            this.add1L.Text = "Address Line 1";
            // 
            // lnameL
            // 
            this.lnameL.AutoSize = true;
            this.lnameL.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.lnameL.Location = new System.Drawing.Point(16, 100);
            this.lnameL.Name = "lnameL";
            this.lnameL.Size = new System.Drawing.Size(63, 15);
            this.lnameL.TabIndex = 115;
            this.lnameL.Text = "Last Name";
            // 
            // mnameL
            // 
            this.mnameL.AutoSize = true;
            this.mnameL.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.mnameL.Location = new System.Drawing.Point(16, 71);
            this.mnameL.Name = "mnameL";
            this.mnameL.Size = new System.Drawing.Size(79, 15);
            this.mnameL.TabIndex = 114;
            this.mnameL.Text = "Middle Name";
            // 
            // fnameL
            // 
            this.fnameL.AutoSize = true;
            this.fnameL.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.fnameL.Location = new System.Drawing.Point(16, 42);
            this.fnameL.Name = "fnameL";
            this.fnameL.Size = new System.Drawing.Size(64, 15);
            this.fnameL.TabIndex = 113;
            this.fnameL.Text = "First Name";
            // 
            // custentrytitle
            // 
            this.custentrytitle.AutoSize = true;
            this.custentrytitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.custentrytitle.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.custentrytitle.Location = new System.Drawing.Point(12, 9);
            this.custentrytitle.Name = "custentrytitle";
            this.custentrytitle.Size = new System.Drawing.Size(93, 25);
            this.custentrytitle.TabIndex = 112;
            this.custentrytitle.Text = "Customer";
            // 
            // CustEntry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.ClientSize = new System.Drawing.Size(664, 492);
            this.Controls.Add(this.mementry);
            this.Controls.Add(this.DOBEntry);
            this.Controls.Add(this.FindID);
            this.Controls.Add(this.CustIdBx);
            this.Controls.Add(this.RemoveRBtn);
            this.Controls.Add(this.EditRBtn);
            this.Controls.Add(this.AddRBtn);
            this.Controls.Add(this.custentrycancel);
            this.Controls.Add(this.custentryacc);
            this.Controls.Add(this.cmemL);
            this.Controls.Add(this.dlL);
            this.Controls.Add(this.cinsL);
            this.Controls.Add(this.phoneL);
            this.Controls.Add(this.dlentry);
            this.Controls.Add(this.cinsentry);
            this.Controls.Add(this.phoneentry);
            this.Controls.Add(this.dobL);
            this.Controls.Add(this.postalL);
            this.Controls.Add(this.provL);
            this.Controls.Add(this.cityL);
            this.Controls.Add(this.add2L);
            this.Controls.Add(this.postalentry);
            this.Controls.Add(this.proventry);
            this.Controls.Add(this.cityentry);
            this.Controls.Add(this.add2entry);
            this.Controls.Add(this.add1entry);
            this.Controls.Add(this.lnameentry);
            this.Controls.Add(this.mnameentry);
            this.Controls.Add(this.fnameentry);
            this.Controls.Add(this.add1L);
            this.Controls.Add(this.lnameL);
            this.Controls.Add(this.mnameL);
            this.Controls.Add(this.fnameL);
            this.Controls.Add(this.custentrytitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CustEntry";
            this.Text = "CustEntry";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CheckBox mementry;
        private DateTimePicker DOBEntry;
        private Button FindID;
        private TextBox CustIdBx;
        private RadioButton RemoveRBtn;
        private RadioButton EditRBtn;
        private RadioButton AddRBtn;
        private Button custentrycancel;
        private Button custentryacc;
        private Label cmemL;
        private Label dlL;
        private Label cinsL;
        private Label phoneL;
        private TextBox dlentry;
        private TextBox cinsentry;
        private TextBox phoneentry;
        private Label dobL;
        private Label postalL;
        private Label provL;
        private Label cityL;
        private Label add2L;
        private TextBox postalentry;
        private TextBox proventry;
        private TextBox cityentry;
        private TextBox add2entry;
        private TextBox add1entry;
        private TextBox lnameentry;
        private TextBox mnameentry;
        private TextBox fnameentry;
        private Label add1L;
        private Label lnameL;
        private Label mnameL;
        private Label fnameL;
        private Label custentrytitle;
    }
}