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
            this.MenuBar = new System.Windows.Forms.Panel();
            this.ExtBtn = new System.Windows.Forms.Button();
            this.MaxBtn = new System.Windows.Forms.Button();
            this.MinBtn = new System.Windows.Forms.Button();
            this.MenuBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // RemoveRBtn
            // 
            this.RemoveRBtn.AutoSize = true;
            this.RemoveRBtn.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.RemoveRBtn.Location = new System.Drawing.Point(645, 286);
            this.RemoveRBtn.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.RemoveRBtn.Name = "RemoveRBtn";
            this.RemoveRBtn.Size = new System.Drawing.Size(131, 36);
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
            this.EditRBtn.Location = new System.Drawing.Point(645, 224);
            this.EditRBtn.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.EditRBtn.Name = "EditRBtn";
            this.EditRBtn.Size = new System.Drawing.Size(85, 36);
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
            this.AddRBtn.Location = new System.Drawing.Point(645, 156);
            this.AddRBtn.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.AddRBtn.Name = "AddRBtn";
            this.AddRBtn.Size = new System.Drawing.Size(88, 36);
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
            this.FindID.Location = new System.Drawing.Point(322, 90);
            this.FindID.Margin = new System.Windows.Forms.Padding(6);
            this.FindID.Name = "FindID";
            this.FindID.Size = new System.Drawing.Size(139, 49);
            this.FindID.TabIndex = 150;
            this.FindID.Text = "Find ID";
            this.FindID.UseVisualStyleBackColor = true;
            this.FindID.Visible = false;
            this.FindID.Click += new System.EventHandler(this.FindID_Click);
            // 
            // BranchIdBx
            // 
            this.BranchIdBx.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.BranchIdBx.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.BranchIdBx.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BranchIdBx.ForeColor = System.Drawing.SystemColors.Window;
            this.BranchIdBx.Location = new System.Drawing.Point(484, 94);
            this.BranchIdBx.Margin = new System.Windows.Forms.Padding(6);
            this.BranchIdBx.Name = "BranchIdBx";
            this.BranchIdBx.Size = new System.Drawing.Size(84, 43);
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
            this.branchcancel.Location = new System.Drawing.Point(870, 286);
            this.branchcancel.Margin = new System.Windows.Forms.Padding(6);
            this.branchcancel.Name = "branchcancel";
            this.branchcancel.Size = new System.Drawing.Size(184, 107);
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
            this.Branchaccept.Location = new System.Drawing.Point(870, 148);
            this.Branchaccept.Margin = new System.Windows.Forms.Padding(6);
            this.Branchaccept.Name = "Branchaccept";
            this.Branchaccept.Size = new System.Drawing.Size(184, 107);
            this.Branchaccept.TabIndex = 147;
            this.Branchaccept.Text = "Accept";
            this.Branchaccept.UseVisualStyleBackColor = false;
            this.Branchaccept.Click += new System.EventHandler(this.Branchaccept_Click);
            // 
            // phoneL
            // 
            this.phoneL.AutoSize = true;
            this.phoneL.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.phoneL.Location = new System.Drawing.Point(49, 532);
            this.phoneL.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.phoneL.Name = "phoneL";
            this.phoneL.Size = new System.Drawing.Size(177, 32);
            this.phoneL.TabIndex = 146;
            this.phoneL.Text = "Phone Number";
            // 
            // postalL
            // 
            this.postalL.AutoSize = true;
            this.postalL.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.postalL.Location = new System.Drawing.Point(49, 470);
            this.postalL.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.postalL.Name = "postalL";
            this.postalL.Size = new System.Drawing.Size(139, 32);
            this.postalL.TabIndex = 145;
            this.postalL.Text = "Postal Code";
            // 
            // provL
            // 
            this.provL.AutoSize = true;
            this.provL.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.provL.Location = new System.Drawing.Point(49, 408);
            this.provL.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.provL.Name = "provL";
            this.provL.Size = new System.Drawing.Size(105, 32);
            this.provL.TabIndex = 144;
            this.provL.Text = "Province";
            // 
            // phoneentry
            // 
            this.phoneentry.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.phoneentry.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.phoneentry.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.phoneentry.ForeColor = System.Drawing.Color.Black;
            this.phoneentry.Location = new System.Drawing.Point(232, 531);
            this.phoneentry.Margin = new System.Windows.Forms.Padding(6);
            this.phoneentry.Name = "phoneentry";
            this.phoneentry.Size = new System.Drawing.Size(336, 43);
            this.phoneentry.TabIndex = 143;
            // 
            // postalentry
            // 
            this.postalentry.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.postalentry.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.postalentry.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.postalentry.ForeColor = System.Drawing.Color.Black;
            this.postalentry.Location = new System.Drawing.Point(232, 469);
            this.postalentry.Margin = new System.Windows.Forms.Padding(6);
            this.postalentry.Name = "postalentry";
            this.postalentry.Size = new System.Drawing.Size(336, 43);
            this.postalentry.TabIndex = 142;
            // 
            // proventry
            // 
            this.proventry.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.proventry.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.proventry.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.proventry.ForeColor = System.Drawing.Color.Black;
            this.proventry.Location = new System.Drawing.Point(232, 408);
            this.proventry.Margin = new System.Windows.Forms.Padding(6);
            this.proventry.Name = "proventry";
            this.proventry.Size = new System.Drawing.Size(336, 43);
            this.proventry.TabIndex = 141;
            // 
            // cityentry
            // 
            this.cityentry.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.cityentry.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.cityentry.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cityentry.ForeColor = System.Drawing.Color.Black;
            this.cityentry.Location = new System.Drawing.Point(232, 346);
            this.cityentry.Margin = new System.Windows.Forms.Padding(6);
            this.cityentry.Name = "cityentry";
            this.cityentry.Size = new System.Drawing.Size(336, 43);
            this.cityentry.TabIndex = 140;
            // 
            // addL2Entry
            // 
            this.addL2Entry.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.addL2Entry.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.addL2Entry.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.addL2Entry.ForeColor = System.Drawing.Color.Black;
            this.addL2Entry.Location = new System.Drawing.Point(232, 284);
            this.addL2Entry.Margin = new System.Windows.Forms.Padding(6);
            this.addL2Entry.Name = "addL2Entry";
            this.addL2Entry.Size = new System.Drawing.Size(336, 43);
            this.addL2Entry.TabIndex = 139;
            // 
            // addL1entry
            // 
            this.addL1entry.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.addL1entry.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.addL1entry.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.addL1entry.ForeColor = System.Drawing.Color.Black;
            this.addL1entry.Location = new System.Drawing.Point(232, 222);
            this.addL1entry.Margin = new System.Windows.Forms.Padding(6);
            this.addL1entry.Name = "addL1entry";
            this.addL1entry.Size = new System.Drawing.Size(336, 43);
            this.addL1entry.TabIndex = 138;
            // 
            // descentry
            // 
            this.descentry.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.descentry.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.descentry.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.descentry.ForeColor = System.Drawing.Color.Black;
            this.descentry.Location = new System.Drawing.Point(232, 160);
            this.descentry.Margin = new System.Windows.Forms.Padding(6);
            this.descentry.Name = "descentry";
            this.descentry.Size = new System.Drawing.Size(336, 43);
            this.descentry.TabIndex = 137;
            // 
            // CityL
            // 
            this.CityL.AutoSize = true;
            this.CityL.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.CityL.Location = new System.Drawing.Point(49, 346);
            this.CityL.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.CityL.Name = "CityL";
            this.CityL.Size = new System.Drawing.Size(55, 32);
            this.CityL.TabIndex = 136;
            this.CityL.Text = "City";
            // 
            // addL2L
            // 
            this.addL2L.AutoSize = true;
            this.addL2L.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.addL2L.Location = new System.Drawing.Point(49, 284);
            this.addL2L.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.addL2L.Name = "addL2L";
            this.addL2L.Size = new System.Drawing.Size(169, 32);
            this.addL2L.TabIndex = 135;
            this.addL2L.Text = "Address Line 2";
            // 
            // addL1L
            // 
            this.addL1L.AutoSize = true;
            this.addL1L.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.addL1L.Location = new System.Drawing.Point(49, 222);
            this.addL1L.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.addL1L.Name = "addL1L";
            this.addL1L.Size = new System.Drawing.Size(169, 32);
            this.addL1L.TabIndex = 134;
            this.addL1L.Text = "Address Line 1";
            // 
            // descL
            // 
            this.descL.AutoSize = true;
            this.descL.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.descL.Location = new System.Drawing.Point(49, 160);
            this.descL.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.descL.Name = "descL";
            this.descL.Size = new System.Drawing.Size(135, 32);
            this.descL.TabIndex = 133;
            this.descL.Text = "Description";
            // 
            // CarEntryTitle
            // 
            this.CarEntryTitle.AutoSize = true;
            this.CarEntryTitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CarEntryTitle.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.CarEntryTitle.Location = new System.Drawing.Point(42, 90);
            this.CarEntryTitle.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.CarEntryTitle.Name = "CarEntryTitle";
            this.CarEntryTitle.Size = new System.Drawing.Size(138, 51);
            this.CarEntryTitle.TabIndex = 132;
            this.CarEntryTitle.Text = "Branch";
            // 
            // SearchRBtn
            // 
            this.SearchRBtn.AutoSize = true;
            this.SearchRBtn.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.SearchRBtn.Location = new System.Drawing.Point(645, 346);
            this.SearchRBtn.Margin = new System.Windows.Forms.Padding(6);
            this.SearchRBtn.Name = "SearchRBtn";
            this.SearchRBtn.Size = new System.Drawing.Size(116, 36);
            this.SearchRBtn.TabIndex = 154;
            this.SearchRBtn.TabStop = true;
            this.SearchRBtn.Text = "Search";
            this.SearchRBtn.UseVisualStyleBackColor = true;
            this.SearchRBtn.CheckedChanged += new System.EventHandler(this.SearchRBtn_CheckedChanged);
            // 
            // MenuBar
            // 
            this.MenuBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.MenuBar.Controls.Add(this.ExtBtn);
            this.MenuBar.Controls.Add(this.MaxBtn);
            this.MenuBar.Controls.Add(this.MinBtn);
            this.MenuBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.MenuBar.Location = new System.Drawing.Point(0, 0);
            this.MenuBar.Margin = new System.Windows.Forms.Padding(6);
            this.MenuBar.Name = "MenuBar";
            this.MenuBar.Size = new System.Drawing.Size(1102, 55);
            this.MenuBar.TabIndex = 155;
            this.MenuBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MenuBar_MouseDown);
            this.MenuBar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MenuBar_MouseMove);
            this.MenuBar.MouseUp += new System.Windows.Forms.MouseEventHandler(this.MenuBar_MouseUp);
            // 
            // ExtBtn
            // 
            this.ExtBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ExtBtn.BackgroundImage = global::CMPT291_Project.Properties.Resources.Cross3;
            this.ExtBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ExtBtn.FlatAppearance.BorderSize = 0;
            this.ExtBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExtBtn.Location = new System.Drawing.Point(1056, 6);
            this.ExtBtn.Margin = new System.Windows.Forms.Padding(6);
            this.ExtBtn.Name = "ExtBtn";
            this.ExtBtn.Size = new System.Drawing.Size(37, 43);
            this.ExtBtn.TabIndex = 8;
            this.ExtBtn.UseVisualStyleBackColor = true;
            this.ExtBtn.Click += new System.EventHandler(this.ExtBtn_Click);
            // 
            // MaxBtn
            // 
            this.MaxBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.MaxBtn.BackgroundImage = global::CMPT291_Project.Properties.Resources.MAX;
            this.MaxBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.MaxBtn.FlatAppearance.BorderSize = 0;
            this.MaxBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MaxBtn.Location = new System.Drawing.Point(1008, 6);
            this.MaxBtn.Margin = new System.Windows.Forms.Padding(6);
            this.MaxBtn.Name = "MaxBtn";
            this.MaxBtn.Size = new System.Drawing.Size(37, 43);
            this.MaxBtn.TabIndex = 10;
            this.MaxBtn.UseVisualStyleBackColor = true;
            this.MaxBtn.Click += new System.EventHandler(this.MaxBtn_Click);
            // 
            // MinBtn
            // 
            this.MinBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.MinBtn.BackgroundImage = global::CMPT291_Project.Properties.Resources.Minus2;
            this.MinBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.MinBtn.FlatAppearance.BorderSize = 0;
            this.MinBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MinBtn.Location = new System.Drawing.Point(960, 6);
            this.MinBtn.Margin = new System.Windows.Forms.Padding(6);
            this.MinBtn.Name = "MinBtn";
            this.MinBtn.Size = new System.Drawing.Size(37, 43);
            this.MinBtn.TabIndex = 9;
            this.MinBtn.UseVisualStyleBackColor = true;
            this.MinBtn.Click += new System.EventHandler(this.MinBtn_Click);
            // 
            // BranchEntry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(1102, 617);
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
            this.Controls.Add(this.MenuBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "BranchEntry";
            this.Text = "BranchEntry";
            this.MenuBar.ResumeLayout(false);
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
        private Panel MenuBar;
        private Button ExtBtn;
        private Button MaxBtn;
        private Button MinBtn;
    }
}