namespace CMPT291_Project
{
    partial class CarEntry
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
            this.CarEntryTitle = new System.Windows.Forms.Label();
            this.VINL = new System.Windows.Forms.Label();
            this.MakeL = new System.Windows.Forms.Label();
            this.modelL = new System.Windows.Forms.Label();
            this.yearL = new System.Windows.Forms.Label();
            this.vinentry = new System.Windows.Forms.TextBox();
            this.makeentry = new System.Windows.Forms.TextBox();
            this.modelentry = new System.Windows.Forms.TextBox();
            this.yearentry = new System.Windows.Forms.TextBox();
            this.seatsentry = new System.Windows.Forms.TextBox();
            this.colourentry = new System.Windows.Forms.TextBox();
            this.insentry = new System.Windows.Forms.TextBox();
            this.mileentry = new System.Windows.Forms.TextBox();
            this.SeatsL = new System.Windows.Forms.Label();
            this.colourL = new System.Windows.Forms.Label();
            this.InsuranceL = new System.Windows.Forms.Label();
            this.MileageL = new System.Windows.Forms.Label();
            this.branchL = new System.Windows.Forms.Label();
            this.cartypeL = new System.Windows.Forms.Label();
            this.carentrryaccept = new System.Windows.Forms.Button();
            this.carentrycancel = new System.Windows.Forms.Button();
            this.FindID = new System.Windows.Forms.Button();
            this.AddRBtn = new System.Windows.Forms.RadioButton();
            this.EditRBtn = new System.Windows.Forms.RadioButton();
            this.RemoveRBtn = new System.Windows.Forms.RadioButton();
            this.CarTypePicker = new System.Windows.Forms.ComboBox();
            this.BranchPicker = new System.Windows.Forms.ComboBox();
            this.currBranch = new System.Windows.Forms.Label();
            this.currCarType = new System.Windows.Forms.Label();
            this.CarEntryPanel = new System.Windows.Forms.Panel();
            this.CarEntryPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // CarEntryTitle
            // 
            this.CarEntryTitle.AutoSize = true;
            this.CarEntryTitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CarEntryTitle.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.CarEntryTitle.Location = new System.Drawing.Point(22, 19);
            this.CarEntryTitle.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.CarEntryTitle.Name = "CarEntryTitle";
            this.CarEntryTitle.Size = new System.Drawing.Size(94, 51);
            this.CarEntryTitle.TabIndex = 87;
            this.CarEntryTitle.Text = "Cars";
            // 
            // VINL
            // 
            this.VINL.AutoSize = true;
            this.VINL.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.VINL.Location = new System.Drawing.Point(30, 90);
            this.VINL.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.VINL.Name = "VINL";
            this.VINL.Size = new System.Drawing.Size(53, 32);
            this.VINL.TabIndex = 88;
            this.VINL.Text = "VIN";
            // 
            // MakeL
            // 
            this.MakeL.AutoSize = true;
            this.MakeL.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.MakeL.Location = new System.Drawing.Point(30, 146);
            this.MakeL.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.MakeL.Name = "MakeL";
            this.MakeL.Size = new System.Drawing.Size(73, 32);
            this.MakeL.TabIndex = 89;
            this.MakeL.Text = "Make";
            // 
            // modelL
            // 
            this.modelL.AutoSize = true;
            this.modelL.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.modelL.Location = new System.Drawing.Point(30, 208);
            this.modelL.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.modelL.Name = "modelL";
            this.modelL.Size = new System.Drawing.Size(83, 32);
            this.modelL.TabIndex = 90;
            this.modelL.Text = "Model";
            // 
            // yearL
            // 
            this.yearL.AutoSize = true;
            this.yearL.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.yearL.Location = new System.Drawing.Point(30, 270);
            this.yearL.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.yearL.Name = "yearL";
            this.yearL.Size = new System.Drawing.Size(58, 32);
            this.yearL.TabIndex = 91;
            this.yearL.Text = "Year";
            // 
            // vinentry
            // 
            this.vinentry.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.vinentry.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.vinentry.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.vinentry.ForeColor = System.Drawing.SystemColors.Window;
            this.vinentry.Location = new System.Drawing.Point(201, 83);
            this.vinentry.Margin = new System.Windows.Forms.Padding(6);
            this.vinentry.Name = "vinentry";
            this.vinentry.Size = new System.Drawing.Size(336, 43);
            this.vinentry.TabIndex = 92;
            // 
            // makeentry
            // 
            this.makeentry.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.makeentry.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.makeentry.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.makeentry.ForeColor = System.Drawing.SystemColors.Window;
            this.makeentry.Location = new System.Drawing.Point(201, 140);
            this.makeentry.Margin = new System.Windows.Forms.Padding(6);
            this.makeentry.Name = "makeentry";
            this.makeentry.Size = new System.Drawing.Size(336, 43);
            this.makeentry.TabIndex = 93;
            // 
            // modelentry
            // 
            this.modelentry.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.modelentry.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.modelentry.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.modelentry.ForeColor = System.Drawing.SystemColors.Window;
            this.modelentry.Location = new System.Drawing.Point(201, 202);
            this.modelentry.Margin = new System.Windows.Forms.Padding(6);
            this.modelentry.Name = "modelentry";
            this.modelentry.Size = new System.Drawing.Size(336, 43);
            this.modelentry.TabIndex = 94;
            // 
            // yearentry
            // 
            this.yearentry.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.yearentry.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.yearentry.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.yearentry.ForeColor = System.Drawing.SystemColors.Window;
            this.yearentry.Location = new System.Drawing.Point(201, 264);
            this.yearentry.Margin = new System.Windows.Forms.Padding(6);
            this.yearentry.Name = "yearentry";
            this.yearentry.Size = new System.Drawing.Size(336, 43);
            this.yearentry.TabIndex = 95;
            // 
            // seatsentry
            // 
            this.seatsentry.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.seatsentry.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.seatsentry.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.seatsentry.ForeColor = System.Drawing.SystemColors.Window;
            this.seatsentry.Location = new System.Drawing.Point(201, 326);
            this.seatsentry.Margin = new System.Windows.Forms.Padding(6);
            this.seatsentry.Name = "seatsentry";
            this.seatsentry.Size = new System.Drawing.Size(336, 43);
            this.seatsentry.TabIndex = 96;
            // 
            // colourentry
            // 
            this.colourentry.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.colourentry.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.colourentry.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.colourentry.ForeColor = System.Drawing.SystemColors.Window;
            this.colourentry.Location = new System.Drawing.Point(201, 388);
            this.colourentry.Margin = new System.Windows.Forms.Padding(6);
            this.colourentry.Name = "colourentry";
            this.colourentry.Size = new System.Drawing.Size(336, 43);
            this.colourentry.TabIndex = 97;
            // 
            // insentry
            // 
            this.insentry.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.insentry.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.insentry.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.insentry.ForeColor = System.Drawing.SystemColors.Window;
            this.insentry.Location = new System.Drawing.Point(201, 449);
            this.insentry.Margin = new System.Windows.Forms.Padding(6);
            this.insentry.Name = "insentry";
            this.insentry.Size = new System.Drawing.Size(336, 43);
            this.insentry.TabIndex = 98;
            // 
            // mileentry
            // 
            this.mileentry.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.mileentry.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mileentry.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.mileentry.ForeColor = System.Drawing.SystemColors.Window;
            this.mileentry.Location = new System.Drawing.Point(201, 511);
            this.mileentry.Margin = new System.Windows.Forms.Padding(6);
            this.mileentry.Name = "mileentry";
            this.mileentry.Size = new System.Drawing.Size(336, 43);
            this.mileentry.TabIndex = 99;
            // 
            // SeatsL
            // 
            this.SeatsL.AutoSize = true;
            this.SeatsL.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.SeatsL.Location = new System.Drawing.Point(30, 332);
            this.SeatsL.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.SeatsL.Name = "SeatsL";
            this.SeatsL.Size = new System.Drawing.Size(70, 32);
            this.SeatsL.TabIndex = 101;
            this.SeatsL.Text = "Seats";
            // 
            // colourL
            // 
            this.colourL.AutoSize = true;
            this.colourL.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.colourL.Location = new System.Drawing.Point(30, 394);
            this.colourL.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.colourL.Name = "colourL";
            this.colourL.Size = new System.Drawing.Size(85, 32);
            this.colourL.TabIndex = 102;
            this.colourL.Text = "Colour";
            // 
            // InsuranceL
            // 
            this.InsuranceL.AutoSize = true;
            this.InsuranceL.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.InsuranceL.Location = new System.Drawing.Point(30, 456);
            this.InsuranceL.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.InsuranceL.Name = "InsuranceL";
            this.InsuranceL.Size = new System.Drawing.Size(116, 32);
            this.InsuranceL.TabIndex = 103;
            this.InsuranceL.Text = "Insurance";
            // 
            // MileageL
            // 
            this.MileageL.AutoSize = true;
            this.MileageL.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.MileageL.Location = new System.Drawing.Point(30, 518);
            this.MileageL.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.MileageL.Name = "MileageL";
            this.MileageL.Size = new System.Drawing.Size(100, 32);
            this.MileageL.TabIndex = 104;
            this.MileageL.Text = "Mileage";
            // 
            // branchL
            // 
            this.branchL.AutoSize = true;
            this.branchL.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.branchL.Location = new System.Drawing.Point(30, 580);
            this.branchL.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.branchL.Name = "branchL";
            this.branchL.Size = new System.Drawing.Size(117, 32);
            this.branchL.TabIndex = 105;
            this.branchL.Text = "Branch ID";
            // 
            // cartypeL
            // 
            this.cartypeL.AutoSize = true;
            this.cartypeL.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.cartypeL.Location = new System.Drawing.Point(30, 640);
            this.cartypeL.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.cartypeL.Name = "cartypeL";
            this.cartypeL.Size = new System.Drawing.Size(107, 32);
            this.cartypeL.TabIndex = 107;
            this.cartypeL.Text = "Car Type";
            // 
            // carentrryaccept
            // 
            this.carentrryaccept.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(79)))), ((int)(((byte)(99)))));
            this.carentrryaccept.FlatAppearance.BorderSize = 0;
            this.carentrryaccept.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.carentrryaccept.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.carentrryaccept.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.carentrryaccept.Location = new System.Drawing.Point(898, 76);
            this.carentrryaccept.Margin = new System.Windows.Forms.Padding(6);
            this.carentrryaccept.Name = "carentrryaccept";
            this.carentrryaccept.Size = new System.Drawing.Size(184, 107);
            this.carentrryaccept.TabIndex = 108;
            this.carentrryaccept.Text = "Accept";
            this.carentrryaccept.UseVisualStyleBackColor = false;
            this.carentrryaccept.Click += new System.EventHandler(this.carentrryaccept_Click);
            // 
            // carentrycancel
            // 
            this.carentrycancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(79)))), ((int)(((byte)(99)))));
            this.carentrycancel.FlatAppearance.BorderSize = 0;
            this.carentrycancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.carentrycancel.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.carentrycancel.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.carentrycancel.Location = new System.Drawing.Point(898, 210);
            this.carentrycancel.Margin = new System.Windows.Forms.Padding(6);
            this.carentrycancel.Name = "carentrycancel";
            this.carentrycancel.Size = new System.Drawing.Size(184, 107);
            this.carentrycancel.TabIndex = 109;
            this.carentrycancel.Text = "Cancel";
            this.carentrycancel.UseVisualStyleBackColor = false;
            this.carentrycancel.Click += new System.EventHandler(this.carentrycancel_Click_1);
            // 
            // FindID
            // 
            this.FindID.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FindID.ForeColor = System.Drawing.Color.White;
            this.FindID.Location = new System.Drawing.Point(399, 22);
            this.FindID.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.FindID.Name = "FindID";
            this.FindID.Size = new System.Drawing.Size(140, 49);
            this.FindID.TabIndex = 111;
            this.FindID.Text = "Find Car";
            this.FindID.UseVisualStyleBackColor = true;
            this.FindID.Visible = false;
            this.FindID.Click += new System.EventHandler(this.FindID_Click);
            // 
            // AddRBtn
            // 
            this.AddRBtn.AutoSize = true;
            this.AddRBtn.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.AddRBtn.Location = new System.Drawing.Point(644, 96);
            this.AddRBtn.Name = "AddRBtn";
            this.AddRBtn.Size = new System.Drawing.Size(88, 36);
            this.AddRBtn.TabIndex = 112;
            this.AddRBtn.TabStop = true;
            this.AddRBtn.Text = "Add";
            this.AddRBtn.UseVisualStyleBackColor = true;
            this.AddRBtn.CheckedChanged += new System.EventHandler(this.AddRBtn_CheckedChanged);
            // 
            // EditRBtn
            // 
            this.EditRBtn.AutoSize = true;
            this.EditRBtn.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.EditRBtn.Location = new System.Drawing.Point(644, 163);
            this.EditRBtn.Name = "EditRBtn";
            this.EditRBtn.Size = new System.Drawing.Size(85, 36);
            this.EditRBtn.TabIndex = 113;
            this.EditRBtn.TabStop = true;
            this.EditRBtn.Text = "Edit";
            this.EditRBtn.UseVisualStyleBackColor = true;
            this.EditRBtn.CheckedChanged += new System.EventHandler(this.EditRBtn_CheckedChanged);
            // 
            // RemoveRBtn
            // 
            this.RemoveRBtn.AutoSize = true;
            this.RemoveRBtn.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.RemoveRBtn.Location = new System.Drawing.Point(644, 225);
            this.RemoveRBtn.Name = "RemoveRBtn";
            this.RemoveRBtn.Size = new System.Drawing.Size(131, 36);
            this.RemoveRBtn.TabIndex = 114;
            this.RemoveRBtn.TabStop = true;
            this.RemoveRBtn.Text = "Remove";
            this.RemoveRBtn.UseVisualStyleBackColor = true;
            this.RemoveRBtn.CheckedChanged += new System.EventHandler(this.RemoveRBtn_CheckedChanged);
            // 
            // CarTypePicker
            // 
            this.CarTypePicker.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.CarTypePicker.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CarTypePicker.FormattingEnabled = true;
            this.CarTypePicker.Location = new System.Drawing.Point(201, 640);
            this.CarTypePicker.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.CarTypePicker.Name = "CarTypePicker";
            this.CarTypePicker.Size = new System.Drawing.Size(338, 40);
            this.CarTypePicker.TabIndex = 115;
            this.CarTypePicker.SelectedIndexChanged += new System.EventHandler(this.CarTypePicker_SelectedIndexChanged);
            // 
            // BranchPicker
            // 
            this.BranchPicker.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.BranchPicker.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.BranchPicker.FormattingEnabled = true;
            this.BranchPicker.Location = new System.Drawing.Point(199, 580);
            this.BranchPicker.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.BranchPicker.Name = "BranchPicker";
            this.BranchPicker.Size = new System.Drawing.Size(338, 40);
            this.BranchPicker.TabIndex = 116;
            this.BranchPicker.SelectedIndexChanged += new System.EventHandler(this.BranchPicker_SelectedIndexChanged);
            // 
            // currBranch
            // 
            this.currBranch.AutoSize = true;
            this.currBranch.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.currBranch.Location = new System.Drawing.Point(577, 588);
            this.currBranch.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.currBranch.Name = "currBranch";
            this.currBranch.Size = new System.Drawing.Size(99, 32);
            this.currBranch.TabIndex = 117;
            this.currBranch.Text = "Current:";
            // 
            // currCarType
            // 
            this.currCarType.AutoSize = true;
            this.currCarType.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.currCarType.Location = new System.Drawing.Point(577, 640);
            this.currCarType.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.currCarType.Name = "currCarType";
            this.currCarType.Size = new System.Drawing.Size(99, 32);
            this.currCarType.TabIndex = 118;
            this.currCarType.Text = "Current:";
            // 
            // CarEntryPanel
            // 
            this.CarEntryPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.CarEntryPanel.Controls.Add(this.currCarType);
            this.CarEntryPanel.Controls.Add(this.currBranch);
            this.CarEntryPanel.Controls.Add(this.BranchPicker);
            this.CarEntryPanel.Controls.Add(this.CarTypePicker);
            this.CarEntryPanel.Controls.Add(this.RemoveRBtn);
            this.CarEntryPanel.Controls.Add(this.EditRBtn);
            this.CarEntryPanel.Controls.Add(this.AddRBtn);
            this.CarEntryPanel.Controls.Add(this.FindID);
            this.CarEntryPanel.Controls.Add(this.carentrycancel);
            this.CarEntryPanel.Controls.Add(this.carentrryaccept);
            this.CarEntryPanel.Controls.Add(this.cartypeL);
            this.CarEntryPanel.Controls.Add(this.branchL);
            this.CarEntryPanel.Controls.Add(this.MileageL);
            this.CarEntryPanel.Controls.Add(this.InsuranceL);
            this.CarEntryPanel.Controls.Add(this.colourL);
            this.CarEntryPanel.Controls.Add(this.SeatsL);
            this.CarEntryPanel.Controls.Add(this.mileentry);
            this.CarEntryPanel.Controls.Add(this.insentry);
            this.CarEntryPanel.Controls.Add(this.colourentry);
            this.CarEntryPanel.Controls.Add(this.seatsentry);
            this.CarEntryPanel.Controls.Add(this.yearentry);
            this.CarEntryPanel.Controls.Add(this.modelentry);
            this.CarEntryPanel.Controls.Add(this.makeentry);
            this.CarEntryPanel.Controls.Add(this.vinentry);
            this.CarEntryPanel.Controls.Add(this.yearL);
            this.CarEntryPanel.Controls.Add(this.modelL);
            this.CarEntryPanel.Controls.Add(this.MakeL);
            this.CarEntryPanel.Controls.Add(this.VINL);
            this.CarEntryPanel.Controls.Add(this.CarEntryTitle);
            this.CarEntryPanel.Location = new System.Drawing.Point(0, 0);
            this.CarEntryPanel.Margin = new System.Windows.Forms.Padding(6);
            this.CarEntryPanel.Name = "CarEntryPanel";
            this.CarEntryPanel.Size = new System.Drawing.Size(1233, 1050);
            this.CarEntryPanel.TabIndex = 0;
            // 
            // CarEntry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.ClientSize = new System.Drawing.Size(1233, 1050);
            this.Controls.Add(this.CarEntryPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "CarEntry";
            this.Text = "CarEntry";
            this.CarEntryPanel.ResumeLayout(false);
            this.CarEntryPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Label CarEntryTitle;
        private Label VINL;
        private Label MakeL;
        private Label modelL;
        private Label yearL;
        private TextBox vinentry;
        private TextBox makeentry;
        private TextBox modelentry;
        private TextBox yearentry;
        private TextBox seatsentry;
        private TextBox colourentry;
        private TextBox insentry;
        private TextBox mileentry;
        private Label SeatsL;
        private Label colourL;
        private Label InsuranceL;
        private Label MileageL;
        private Label branchL;
        private Label cartypeL;
        private Button carentrryaccept;
        private Button carentrycancel;
        private Button FindID;
        private RadioButton AddRBtn;
        private RadioButton EditRBtn;
        private RadioButton RemoveRBtn;
        private ComboBox CarTypePicker;
        private ComboBox BranchPicker;
        private Label currBranch;
        private Label currCarType;
        private Panel CarEntryPanel;
    }
}