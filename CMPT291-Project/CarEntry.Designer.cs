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
            this.currCarType = new System.Windows.Forms.Label();
            this.currBranch = new System.Windows.Forms.Label();
            this.BranchPicker = new System.Windows.Forms.ComboBox();
            this.CarTypePicker = new System.Windows.Forms.ComboBox();
            this.RemoveRBtn = new System.Windows.Forms.RadioButton();
            this.EditRBtn = new System.Windows.Forms.RadioButton();
            this.AddRBtn = new System.Windows.Forms.RadioButton();
            this.FindID = new System.Windows.Forms.Button();
            this.carentrycancel = new System.Windows.Forms.Button();
            this.carentrryaccept = new System.Windows.Forms.Button();
            this.cartypeL = new System.Windows.Forms.Label();
            this.branchL = new System.Windows.Forms.Label();
            this.MileageL = new System.Windows.Forms.Label();
            this.InsuranceL = new System.Windows.Forms.Label();
            this.colourL = new System.Windows.Forms.Label();
            this.SeatsL = new System.Windows.Forms.Label();
            this.mileentry = new System.Windows.Forms.TextBox();
            this.insentry = new System.Windows.Forms.TextBox();
            this.colourentry = new System.Windows.Forms.TextBox();
            this.seatsentry = new System.Windows.Forms.TextBox();
            this.yearentry = new System.Windows.Forms.TextBox();
            this.modelentry = new System.Windows.Forms.TextBox();
            this.makeentry = new System.Windows.Forms.TextBox();
            this.vinentry = new System.Windows.Forms.TextBox();
            this.yearL = new System.Windows.Forms.Label();
            this.modelL = new System.Windows.Forms.Label();
            this.MakeL = new System.Windows.Forms.Label();
            this.VINL = new System.Windows.Forms.Label();
            this.CarEntryTitle = new System.Windows.Forms.Label();
            this.SearchRBtn = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // currCarType
            // 
            this.currCarType.AutoSize = true;
            this.currCarType.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.currCarType.Location = new System.Drawing.Point(318, 307);
            this.currCarType.Name = "currCarType";
            this.currCarType.Size = new System.Drawing.Size(50, 15);
            this.currCarType.TabIndex = 147;
            this.currCarType.Text = "Current:";
            // 
            // currBranch
            // 
            this.currBranch.AutoSize = true;
            this.currBranch.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.currBranch.Location = new System.Drawing.Point(318, 283);
            this.currBranch.Name = "currBranch";
            this.currBranch.Size = new System.Drawing.Size(50, 15);
            this.currBranch.TabIndex = 146;
            this.currBranch.Text = "Current:";
            // 
            // BranchPicker
            // 
            this.BranchPicker.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.BranchPicker.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.BranchPicker.FormattingEnabled = true;
            this.BranchPicker.Location = new System.Drawing.Point(114, 279);
            this.BranchPicker.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.BranchPicker.Name = "BranchPicker";
            this.BranchPicker.Size = new System.Drawing.Size(184, 23);
            this.BranchPicker.TabIndex = 145;
            this.BranchPicker.SelectedIndexChanged += new System.EventHandler(this.BranchPicker_SelectedIndexChanged_1);
            // 
            // CarTypePicker
            // 
            this.CarTypePicker.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.CarTypePicker.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CarTypePicker.FormattingEnabled = true;
            this.CarTypePicker.Location = new System.Drawing.Point(115, 307);
            this.CarTypePicker.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.CarTypePicker.Name = "CarTypePicker";
            this.CarTypePicker.Size = new System.Drawing.Size(184, 23);
            this.CarTypePicker.TabIndex = 144;
            this.CarTypePicker.SelectedIndexChanged += new System.EventHandler(this.CarTypePicker_SelectedIndexChanged_1);
            // 
            // RemoveRBtn
            // 
            this.RemoveRBtn.AutoSize = true;
            this.RemoveRBtn.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.RemoveRBtn.Location = new System.Drawing.Point(354, 112);
            this.RemoveRBtn.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.RemoveRBtn.Name = "RemoveRBtn";
            this.RemoveRBtn.Size = new System.Drawing.Size(68, 19);
            this.RemoveRBtn.TabIndex = 143;
            this.RemoveRBtn.TabStop = true;
            this.RemoveRBtn.Text = "Remove";
            this.RemoveRBtn.UseVisualStyleBackColor = true;
            this.RemoveRBtn.CheckedChanged += new System.EventHandler(this.RemoveRBtn_CheckedChanged_1);
            // 
            // EditRBtn
            // 
            this.EditRBtn.AutoSize = true;
            this.EditRBtn.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.EditRBtn.Location = new System.Drawing.Point(354, 83);
            this.EditRBtn.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.EditRBtn.Name = "EditRBtn";
            this.EditRBtn.Size = new System.Drawing.Size(45, 19);
            this.EditRBtn.TabIndex = 142;
            this.EditRBtn.TabStop = true;
            this.EditRBtn.Text = "Edit";
            this.EditRBtn.UseVisualStyleBackColor = true;
            this.EditRBtn.CheckedChanged += new System.EventHandler(this.EditRBtn_CheckedChanged_1);
            // 
            // AddRBtn
            // 
            this.AddRBtn.AutoSize = true;
            this.AddRBtn.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.AddRBtn.Location = new System.Drawing.Point(354, 52);
            this.AddRBtn.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.AddRBtn.Name = "AddRBtn";
            this.AddRBtn.Size = new System.Drawing.Size(47, 19);
            this.AddRBtn.TabIndex = 141;
            this.AddRBtn.TabStop = true;
            this.AddRBtn.Text = "Add";
            this.AddRBtn.UseVisualStyleBackColor = true;
            this.AddRBtn.CheckedChanged += new System.EventHandler(this.AddRBtn_CheckedChanged_1);
            // 
            // FindID
            // 
            this.FindID.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FindID.ForeColor = System.Drawing.Color.White;
            this.FindID.Location = new System.Drawing.Point(222, 17);
            this.FindID.Name = "FindID";
            this.FindID.Size = new System.Drawing.Size(75, 23);
            this.FindID.TabIndex = 140;
            this.FindID.Text = "Find Car";
            this.FindID.UseVisualStyleBackColor = true;
            this.FindID.Visible = false;
            this.FindID.Click += new System.EventHandler(this.FindID_Click_1);
            // 
            // carentrycancel
            // 
            this.carentrycancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(79)))), ((int)(((byte)(99)))));
            this.carentrycancel.FlatAppearance.BorderSize = 0;
            this.carentrycancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.carentrycancel.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.carentrycancel.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.carentrycancel.Location = new System.Drawing.Point(491, 105);
            this.carentrycancel.Name = "carentrycancel";
            this.carentrycancel.Size = new System.Drawing.Size(99, 50);
            this.carentrycancel.TabIndex = 139;
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
            this.carentrryaccept.Location = new System.Drawing.Point(491, 43);
            this.carentrryaccept.Name = "carentrryaccept";
            this.carentrryaccept.Size = new System.Drawing.Size(99, 50);
            this.carentrryaccept.TabIndex = 138;
            this.carentrryaccept.Text = "Accept";
            this.carentrryaccept.UseVisualStyleBackColor = false;
            this.carentrryaccept.Click += new System.EventHandler(this.carentrryaccept_Click_1);
            // 
            // cartypeL
            // 
            this.cartypeL.AutoSize = true;
            this.cartypeL.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.cartypeL.Location = new System.Drawing.Point(23, 307);
            this.cartypeL.Name = "cartypeL";
            this.cartypeL.Size = new System.Drawing.Size(52, 15);
            this.cartypeL.TabIndex = 137;
            this.cartypeL.Text = "Car Type";
            // 
            // branchL
            // 
            this.branchL.AutoSize = true;
            this.branchL.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.branchL.Location = new System.Drawing.Point(23, 279);
            this.branchL.Name = "branchL";
            this.branchL.Size = new System.Drawing.Size(58, 15);
            this.branchL.TabIndex = 136;
            this.branchL.Text = "Branch ID";
            // 
            // MileageL
            // 
            this.MileageL.AutoSize = true;
            this.MileageL.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.MileageL.Location = new System.Drawing.Point(23, 250);
            this.MileageL.Name = "MileageL";
            this.MileageL.Size = new System.Drawing.Size(49, 15);
            this.MileageL.TabIndex = 135;
            this.MileageL.Text = "Mileage";
            // 
            // InsuranceL
            // 
            this.InsuranceL.AutoSize = true;
            this.InsuranceL.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.InsuranceL.Location = new System.Drawing.Point(23, 221);
            this.InsuranceL.Name = "InsuranceL";
            this.InsuranceL.Size = new System.Drawing.Size(58, 15);
            this.InsuranceL.TabIndex = 134;
            this.InsuranceL.Text = "Insurance";
            // 
            // colourL
            // 
            this.colourL.AutoSize = true;
            this.colourL.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.colourL.Location = new System.Drawing.Point(23, 192);
            this.colourL.Name = "colourL";
            this.colourL.Size = new System.Drawing.Size(43, 15);
            this.colourL.TabIndex = 133;
            this.colourL.Text = "Colour";
            // 
            // SeatsL
            // 
            this.SeatsL.AutoSize = true;
            this.SeatsL.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.SeatsL.Location = new System.Drawing.Point(23, 163);
            this.SeatsL.Name = "SeatsL";
            this.SeatsL.Size = new System.Drawing.Size(34, 15);
            this.SeatsL.TabIndex = 132;
            this.SeatsL.Text = "Seats";
            // 
            // mileentry
            // 
            this.mileentry.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.mileentry.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mileentry.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.mileentry.ForeColor = System.Drawing.SystemColors.Window;
            this.mileentry.Location = new System.Drawing.Point(115, 247);
            this.mileentry.Name = "mileentry";
            this.mileentry.Size = new System.Drawing.Size(181, 22);
            this.mileentry.TabIndex = 131;
            // 
            // insentry
            // 
            this.insentry.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.insentry.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.insentry.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.insentry.ForeColor = System.Drawing.SystemColors.Window;
            this.insentry.Location = new System.Drawing.Point(115, 217);
            this.insentry.Name = "insentry";
            this.insentry.Size = new System.Drawing.Size(181, 22);
            this.insentry.TabIndex = 130;
            // 
            // colourentry
            // 
            this.colourentry.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.colourentry.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.colourentry.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.colourentry.ForeColor = System.Drawing.SystemColors.Window;
            this.colourentry.Location = new System.Drawing.Point(115, 189);
            this.colourentry.Name = "colourentry";
            this.colourentry.Size = new System.Drawing.Size(181, 22);
            this.colourentry.TabIndex = 129;
            // 
            // seatsentry
            // 
            this.seatsentry.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.seatsentry.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.seatsentry.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.seatsentry.ForeColor = System.Drawing.SystemColors.Window;
            this.seatsentry.Location = new System.Drawing.Point(115, 160);
            this.seatsentry.Name = "seatsentry";
            this.seatsentry.Size = new System.Drawing.Size(181, 22);
            this.seatsentry.TabIndex = 128;
            // 
            // yearentry
            // 
            this.yearentry.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.yearentry.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.yearentry.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.yearentry.ForeColor = System.Drawing.SystemColors.Window;
            this.yearentry.Location = new System.Drawing.Point(115, 131);
            this.yearentry.Name = "yearentry";
            this.yearentry.Size = new System.Drawing.Size(181, 22);
            this.yearentry.TabIndex = 127;
            // 
            // modelentry
            // 
            this.modelentry.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.modelentry.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.modelentry.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.modelentry.ForeColor = System.Drawing.SystemColors.Window;
            this.modelentry.Location = new System.Drawing.Point(115, 102);
            this.modelentry.Name = "modelentry";
            this.modelentry.Size = new System.Drawing.Size(181, 22);
            this.modelentry.TabIndex = 126;
            // 
            // makeentry
            // 
            this.makeentry.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.makeentry.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.makeentry.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.makeentry.ForeColor = System.Drawing.SystemColors.Window;
            this.makeentry.Location = new System.Drawing.Point(115, 73);
            this.makeentry.Name = "makeentry";
            this.makeentry.Size = new System.Drawing.Size(181, 22);
            this.makeentry.TabIndex = 125;
            // 
            // vinentry
            // 
            this.vinentry.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.vinentry.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.vinentry.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.vinentry.ForeColor = System.Drawing.SystemColors.Window;
            this.vinentry.Location = new System.Drawing.Point(115, 46);
            this.vinentry.Name = "vinentry";
            this.vinentry.Size = new System.Drawing.Size(181, 22);
            this.vinentry.TabIndex = 124;
            // 
            // yearL
            // 
            this.yearL.AutoSize = true;
            this.yearL.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.yearL.Location = new System.Drawing.Point(23, 134);
            this.yearL.Name = "yearL";
            this.yearL.Size = new System.Drawing.Size(29, 15);
            this.yearL.TabIndex = 123;
            this.yearL.Text = "Year";
            // 
            // modelL
            // 
            this.modelL.AutoSize = true;
            this.modelL.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.modelL.Location = new System.Drawing.Point(23, 105);
            this.modelL.Name = "modelL";
            this.modelL.Size = new System.Drawing.Size(41, 15);
            this.modelL.TabIndex = 122;
            this.modelL.Text = "Model";
            // 
            // MakeL
            // 
            this.MakeL.AutoSize = true;
            this.MakeL.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.MakeL.Location = new System.Drawing.Point(23, 75);
            this.MakeL.Name = "MakeL";
            this.MakeL.Size = new System.Drawing.Size(36, 15);
            this.MakeL.TabIndex = 121;
            this.MakeL.Text = "Make";
            // 
            // VINL
            // 
            this.VINL.AutoSize = true;
            this.VINL.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.VINL.Location = new System.Drawing.Point(23, 49);
            this.VINL.Name = "VINL";
            this.VINL.Size = new System.Drawing.Size(26, 15);
            this.VINL.TabIndex = 120;
            this.VINL.Text = "VIN";
            // 
            // CarEntryTitle
            // 
            this.CarEntryTitle.AutoSize = true;
            this.CarEntryTitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CarEntryTitle.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.CarEntryTitle.Location = new System.Drawing.Point(19, 16);
            this.CarEntryTitle.Name = "CarEntryTitle";
            this.CarEntryTitle.Size = new System.Drawing.Size(49, 25);
            this.CarEntryTitle.TabIndex = 119;
            this.CarEntryTitle.Text = "Cars";
            // 
            // SearchRBtn
            // 
            this.SearchRBtn.AutoSize = true;
            this.SearchRBtn.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.SearchRBtn.Location = new System.Drawing.Point(354, 136);
            this.SearchRBtn.Name = "SearchRBtn";
            this.SearchRBtn.Size = new System.Drawing.Size(60, 19);
            this.SearchRBtn.TabIndex = 148;
            this.SearchRBtn.TabStop = true;
            this.SearchRBtn.Text = "Search";
            this.SearchRBtn.UseVisualStyleBackColor = true;
            this.SearchRBtn.CheckedChanged += new System.EventHandler(this.SearchRBtn_CheckedChanged);
            // 
            // CarEntry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.ClientSize = new System.Drawing.Size(620, 356);
            this.Controls.Add(this.SearchRBtn);
            this.Controls.Add(this.currCarType);
            this.Controls.Add(this.currBranch);
            this.Controls.Add(this.BranchPicker);
            this.Controls.Add(this.CarTypePicker);
            this.Controls.Add(this.RemoveRBtn);
            this.Controls.Add(this.EditRBtn);
            this.Controls.Add(this.AddRBtn);
            this.Controls.Add(this.FindID);
            this.Controls.Add(this.carentrycancel);
            this.Controls.Add(this.carentrryaccept);
            this.Controls.Add(this.cartypeL);
            this.Controls.Add(this.branchL);
            this.Controls.Add(this.MileageL);
            this.Controls.Add(this.InsuranceL);
            this.Controls.Add(this.colourL);
            this.Controls.Add(this.SeatsL);
            this.Controls.Add(this.mileentry);
            this.Controls.Add(this.insentry);
            this.Controls.Add(this.colourentry);
            this.Controls.Add(this.seatsentry);
            this.Controls.Add(this.yearentry);
            this.Controls.Add(this.modelentry);
            this.Controls.Add(this.makeentry);
            this.Controls.Add(this.vinentry);
            this.Controls.Add(this.yearL);
            this.Controls.Add(this.modelL);
            this.Controls.Add(this.MakeL);
            this.Controls.Add(this.VINL);
            this.Controls.Add(this.CarEntryTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CarEntry";
            this.Text = "CarEntry";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label currCarType;
        private Label currBranch;
        private ComboBox BranchPicker;
        private ComboBox CarTypePicker;
        private RadioButton RemoveRBtn;
        private RadioButton EditRBtn;
        private RadioButton AddRBtn;
        private Button FindID;
        private Button carentrycancel;
        private Button carentrryaccept;
        private Label cartypeL;
        private Label branchL;
        private Label MileageL;
        private Label InsuranceL;
        private Label colourL;
        private Label SeatsL;
        private TextBox mileentry;
        private TextBox insentry;
        private TextBox colourentry;
        private TextBox seatsentry;
        private TextBox yearentry;
        private TextBox modelentry;
        private TextBox makeentry;
        private TextBox vinentry;
        private Label yearL;
        private Label modelL;
        private Label MakeL;
        private Label VINL;
        private Label CarEntryTitle;
        private RadioButton SearchRBtn;
    }
}