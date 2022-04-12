namespace CMPT291_Project
{
    partial class BranchEntry
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
            this.RemoveRBtn = new System.Windows.Forms.RadioButton();
            this.EditRBtn = new System.Windows.Forms.RadioButton();
            this.AddRBtn = new System.Windows.Forms.RadioButton();
            this.FindID = new System.Windows.Forms.Button();
            this.BranchIdBx = new System.Windows.Forms.TextBox();
            this.branchcancel = new System.Windows.Forms.Button();
            this.Branchaccept = new System.Windows.Forms.Button();
            this.phoneL = new System.Windows.Forms.Label();
            this.postalL = new System.Windows.Forms.Label();
            this.provL = new System.Windows.Forms.Label();
            this.phoneentry = new System.Windows.Forms.TextBox();
            this.postalentry = new System.Windows.Forms.TextBox();
            this.proventry = new System.Windows.Forms.TextBox();
            this.cityentry = new System.Windows.Forms.TextBox();
            this.addL2Entry = new System.Windows.Forms.TextBox();
            this.addL1entry = new System.Windows.Forms.TextBox();
            this.descentry = new System.Windows.Forms.TextBox();
            this.CityL = new System.Windows.Forms.Label();
            this.addL2L = new System.Windows.Forms.Label();
            this.addL1L = new System.Windows.Forms.Label();
            this.descL = new System.Windows.Forms.Label();
            this.CarEntryTitle = new System.Windows.Forms.Label();
            this.SearchRBtn = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // RemoveRBtn
            // 
            this.RemoveRBtn.AutoSize = true;
            this.RemoveRBtn.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.RemoveRBtn.Location = new System.Drawing.Point(334, 100);
            this.RemoveRBtn.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.RemoveRBtn.Name = "RemoveRBtn";
            this.RemoveRBtn.Size = new System.Drawing.Size(68, 19);
            this.RemoveRBtn.TabIndex = 153;
            this.RemoveRBtn.TabStop = true;
            this.RemoveRBtn.Text = "Remove";
            this.RemoveRBtn.UseVisualStyleBackColor = true;
            this.RemoveRBtn.CheckedChanged += new System.EventHandler(this.RemoveRBtn_CheckedChanged);
            // 
            // EditRBtn
            // 
            this.EditRBtn.AutoSize = true;
            this.EditRBtn.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.EditRBtn.Location = new System.Drawing.Point(334, 71);
            this.EditRBtn.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.EditRBtn.Name = "EditRBtn";
            this.EditRBtn.Size = new System.Drawing.Size(45, 19);
            this.EditRBtn.TabIndex = 152;
            this.EditRBtn.TabStop = true;
            this.EditRBtn.Text = "Edit";
            this.EditRBtn.UseVisualStyleBackColor = true;
            this.EditRBtn.CheckedChanged += new System.EventHandler(this.EditRBtn_CheckedChanged_1);
            // 
            // AddRBtn
            // 
            this.AddRBtn.AutoSize = true;
            this.AddRBtn.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.AddRBtn.Location = new System.Drawing.Point(334, 39);
            this.AddRBtn.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.AddRBtn.Name = "AddRBtn";
            this.AddRBtn.Size = new System.Drawing.Size(47, 19);
            this.AddRBtn.TabIndex = 151;
            this.AddRBtn.TabStop = true;
            this.AddRBtn.Text = "Add";
            this.AddRBtn.UseVisualStyleBackColor = true;
            this.AddRBtn.CheckedChanged += new System.EventHandler(this.AddRBtn_CheckedChanged);
            // 
            // FindID
            // 
            this.FindID.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FindID.ForeColor = System.Drawing.Color.White;
            this.FindID.Location = new System.Drawing.Point(160, 8);
            this.FindID.Name = "FindID";
            this.FindID.Size = new System.Drawing.Size(75, 23);
            this.FindID.TabIndex = 150;
            this.FindID.Text = "Find ID";
            this.FindID.UseVisualStyleBackColor = true;
            this.FindID.Visible = false;
            this.FindID.Click += new System.EventHandler(this.FindID_Click);
            // 
            // BranchIdBx
            // 
            this.BranchIdBx.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.BranchIdBx.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.BranchIdBx.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BranchIdBx.ForeColor = System.Drawing.SystemColors.Window;
            this.BranchIdBx.Location = new System.Drawing.Point(241, 10);
            this.BranchIdBx.Name = "BranchIdBx";
            this.BranchIdBx.Size = new System.Drawing.Size(45, 22);
            this.BranchIdBx.TabIndex = 149;
            this.BranchIdBx.Visible = false;
            // 
            // branchcancel
            // 
            this.branchcancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(79)))), ((int)(((byte)(99)))));
            this.branchcancel.FlatAppearance.BorderSize = 0;
            this.branchcancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.branchcancel.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.branchcancel.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.branchcancel.Location = new System.Drawing.Point(455, 100);
            this.branchcancel.Name = "branchcancel";
            this.branchcancel.Size = new System.Drawing.Size(99, 50);
            this.branchcancel.TabIndex = 148;
            this.branchcancel.Text = "Cancel";
            this.branchcancel.UseVisualStyleBackColor = false;
            this.branchcancel.Click += new System.EventHandler(this.branchcancel_Click_1);
            // 
            // Branchaccept
            // 
            this.Branchaccept.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(79)))), ((int)(((byte)(99)))));
            this.Branchaccept.FlatAppearance.BorderSize = 0;
            this.Branchaccept.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Branchaccept.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Branchaccept.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.Branchaccept.Location = new System.Drawing.Point(455, 35);
            this.Branchaccept.Name = "Branchaccept";
            this.Branchaccept.Size = new System.Drawing.Size(99, 50);
            this.Branchaccept.TabIndex = 147;
            this.Branchaccept.Text = "Accept";
            this.Branchaccept.UseVisualStyleBackColor = false;
            this.Branchaccept.Click += new System.EventHandler(this.Branchaccept_Click);
            // 
            // phoneL
            // 
            this.phoneL.AutoSize = true;
            this.phoneL.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.phoneL.Location = new System.Drawing.Point(13, 215);
            this.phoneL.Name = "phoneL";
            this.phoneL.Size = new System.Drawing.Size(88, 15);
            this.phoneL.TabIndex = 146;
            this.phoneL.Text = "Phone Number";
            // 
            // postalL
            // 
            this.postalL.AutoSize = true;
            this.postalL.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.postalL.Location = new System.Drawing.Point(13, 186);
            this.postalL.Name = "postalL";
            this.postalL.Size = new System.Drawing.Size(70, 15);
            this.postalL.TabIndex = 145;
            this.postalL.Text = "Postal Code";
            // 
            // provL
            // 
            this.provL.AutoSize = true;
            this.provL.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.provL.Location = new System.Drawing.Point(13, 157);
            this.provL.Name = "provL";
            this.provL.Size = new System.Drawing.Size(53, 15);
            this.provL.TabIndex = 144;
            this.provL.Text = "Province";
            // 
            // phoneentry
            // 
            this.phoneentry.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.phoneentry.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.phoneentry.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.phoneentry.ForeColor = System.Drawing.SystemColors.Window;
            this.phoneentry.Location = new System.Drawing.Point(105, 212);
            this.phoneentry.Name = "phoneentry";
            this.phoneentry.Size = new System.Drawing.Size(181, 22);
            this.phoneentry.TabIndex = 143;
            // 
            // postalentry
            // 
            this.postalentry.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.postalentry.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.postalentry.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.postalentry.ForeColor = System.Drawing.SystemColors.Window;
            this.postalentry.Location = new System.Drawing.Point(105, 183);
            this.postalentry.Name = "postalentry";
            this.postalentry.Size = new System.Drawing.Size(181, 22);
            this.postalentry.TabIndex = 142;
            // 
            // proventry
            // 
            this.proventry.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.proventry.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.proventry.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.proventry.ForeColor = System.Drawing.SystemColors.Window;
            this.proventry.Location = new System.Drawing.Point(105, 154);
            this.proventry.Name = "proventry";
            this.proventry.Size = new System.Drawing.Size(181, 22);
            this.proventry.TabIndex = 141;
            // 
            // cityentry
            // 
            this.cityentry.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.cityentry.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.cityentry.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cityentry.ForeColor = System.Drawing.SystemColors.Window;
            this.cityentry.Location = new System.Drawing.Point(105, 125);
            this.cityentry.Name = "cityentry";
            this.cityentry.Size = new System.Drawing.Size(181, 22);
            this.cityentry.TabIndex = 140;
            // 
            // addL2Entry
            // 
            this.addL2Entry.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.addL2Entry.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.addL2Entry.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.addL2Entry.ForeColor = System.Drawing.SystemColors.Window;
            this.addL2Entry.Location = new System.Drawing.Point(105, 96);
            this.addL2Entry.Name = "addL2Entry";
            this.addL2Entry.Size = new System.Drawing.Size(181, 22);
            this.addL2Entry.TabIndex = 139;
            // 
            // addL1entry
            // 
            this.addL1entry.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.addL1entry.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.addL1entry.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.addL1entry.ForeColor = System.Drawing.SystemColors.Window;
            this.addL1entry.Location = new System.Drawing.Point(105, 67);
            this.addL1entry.Name = "addL1entry";
            this.addL1entry.Size = new System.Drawing.Size(181, 22);
            this.addL1entry.TabIndex = 138;
            // 
            // descentry
            // 
            this.descentry.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.descentry.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.descentry.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.descentry.ForeColor = System.Drawing.SystemColors.Window;
            this.descentry.Location = new System.Drawing.Point(105, 38);
            this.descentry.Name = "descentry";
            this.descentry.Size = new System.Drawing.Size(181, 22);
            this.descentry.TabIndex = 137;
            // 
            // CityL
            // 
            this.CityL.AutoSize = true;
            this.CityL.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.CityL.Location = new System.Drawing.Point(13, 128);
            this.CityL.Name = "CityL";
            this.CityL.Size = new System.Drawing.Size(28, 15);
            this.CityL.TabIndex = 136;
            this.CityL.Text = "City";
            // 
            // addL2L
            // 
            this.addL2L.AutoSize = true;
            this.addL2L.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.addL2L.Location = new System.Drawing.Point(13, 99);
            this.addL2L.Name = "addL2L";
            this.addL2L.Size = new System.Drawing.Size(83, 15);
            this.addL2L.TabIndex = 135;
            this.addL2L.Text = "Address Line 2";
            // 
            // addL1L
            // 
            this.addL1L.AutoSize = true;
            this.addL1L.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.addL1L.Location = new System.Drawing.Point(13, 70);
            this.addL1L.Name = "addL1L";
            this.addL1L.Size = new System.Drawing.Size(83, 15);
            this.addL1L.TabIndex = 134;
            this.addL1L.Text = "Address Line 1";
            // 
            // descL
            // 
            this.descL.AutoSize = true;
            this.descL.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.descL.Location = new System.Drawing.Point(13, 41);
            this.descL.Name = "descL";
            this.descL.Size = new System.Drawing.Size(67, 15);
            this.descL.TabIndex = 133;
            this.descL.Text = "Description";
            // 
            // CarEntryTitle
            // 
            this.CarEntryTitle.AutoSize = true;
            this.CarEntryTitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CarEntryTitle.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.CarEntryTitle.Location = new System.Drawing.Point(9, 8);
            this.CarEntryTitle.Name = "CarEntryTitle";
            this.CarEntryTitle.Size = new System.Drawing.Size(71, 25);
            this.CarEntryTitle.TabIndex = 132;
            this.CarEntryTitle.Text = "Branch";
            // 
            // SearchRBtn
            // 
            this.SearchRBtn.AutoSize = true;
            this.SearchRBtn.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.SearchRBtn.Location = new System.Drawing.Point(334, 128);
            this.SearchRBtn.Name = "SearchRBtn";
            this.SearchRBtn.Size = new System.Drawing.Size(60, 19);
            this.SearchRBtn.TabIndex = 154;
            this.SearchRBtn.TabStop = true;
            this.SearchRBtn.Text = "Search";
            this.SearchRBtn.UseVisualStyleBackColor = true;
            this.SearchRBtn.CheckedChanged += new System.EventHandler(this.SearchRBtn_CheckedChanged);
            // 
            // BranchEntry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.ClientSize = new System.Drawing.Size(664, 492);
            this.Controls.Add(this.SearchRBtn);
            this.Controls.Add(this.RemoveRBtn);
            this.Controls.Add(this.EditRBtn);
            this.Controls.Add(this.AddRBtn);
            this.Controls.Add(this.FindID);
            this.Controls.Add(this.BranchIdBx);
            this.Controls.Add(this.branchcancel);
            this.Controls.Add(this.Branchaccept);
            this.Controls.Add(this.phoneL);
            this.Controls.Add(this.postalL);
            this.Controls.Add(this.provL);
            this.Controls.Add(this.phoneentry);
            this.Controls.Add(this.postalentry);
            this.Controls.Add(this.proventry);
            this.Controls.Add(this.cityentry);
            this.Controls.Add(this.addL2Entry);
            this.Controls.Add(this.addL1entry);
            this.Controls.Add(this.descentry);
            this.Controls.Add(this.CityL);
            this.Controls.Add(this.addL2L);
            this.Controls.Add(this.addL1L);
            this.Controls.Add(this.descL);
            this.Controls.Add(this.CarEntryTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "BranchEntry";
            this.Text = "BranchEntry";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private RadioButton RemoveRBtn;
        private RadioButton EditRBtn;
        private RadioButton AddRBtn;
        private Button FindID;
        private TextBox BranchIdBx;
        private Button branchcancel;
        private Button Branchaccept;
        private Label phoneL;
        private Label postalL;
        private Label provL;
        private TextBox phoneentry;
        private TextBox postalentry;
        private TextBox proventry;
        private TextBox cityentry;
        private TextBox addL2Entry;
        private TextBox addL1entry;
        private TextBox descentry;
        private Label CityL;
        private Label addL2L;
        private Label addL1L;
        private Label descL;
        private Label CarEntryTitle;
        private RadioButton SearchRBtn;
    }
}