namespace CMPT291_Project
{
    partial class CarTypeEntry
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
            this.CTEntryPanel = new System.Windows.Forms.Panel();
            this.LevelBx = new System.Windows.Forms.TextBox();
            this.LevelLbl = new System.Windows.Forms.Label();
            this.FindID = new System.Windows.Forms.Button();
            this.RemoveRBtn = new System.Windows.Forms.RadioButton();
            this.EditRBtn = new System.Windows.Forms.RadioButton();
            this.AddRBtn = new System.Windows.Forms.RadioButton();
            this.CarTypeIdBx = new System.Windows.Forms.TextBox();
            this.ctentrycancel = new System.Windows.Forms.Button();
            this.ctentryacc = new System.Windows.Forms.Button();
            this.mrateentry = new System.Windows.Forms.TextBox();
            this.wrateentry = new System.Windows.Forms.TextBox();
            this.drateentry = new System.Windows.Forms.TextBox();
            this.descentry = new System.Windows.Forms.TextBox();
            this.mrateL = new System.Windows.Forms.Label();
            this.wrateL = new System.Windows.Forms.Label();
            this.drateL = new System.Windows.Forms.Label();
            this.descriptionL = new System.Windows.Forms.Label();
            this.cartypeentrytitle = new System.Windows.Forms.Label();
            this.CTEntryPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // CTEntryPanel
            // 
            this.CTEntryPanel.Controls.Add(this.LevelBx);
            this.CTEntryPanel.Controls.Add(this.LevelLbl);
            this.CTEntryPanel.Controls.Add(this.FindID);
            this.CTEntryPanel.Controls.Add(this.RemoveRBtn);
            this.CTEntryPanel.Controls.Add(this.EditRBtn);
            this.CTEntryPanel.Controls.Add(this.AddRBtn);
            this.CTEntryPanel.Controls.Add(this.CarTypeIdBx);
            this.CTEntryPanel.Controls.Add(this.ctentrycancel);
            this.CTEntryPanel.Controls.Add(this.ctentryacc);
            this.CTEntryPanel.Controls.Add(this.mrateentry);
            this.CTEntryPanel.Controls.Add(this.wrateentry);
            this.CTEntryPanel.Controls.Add(this.drateentry);
            this.CTEntryPanel.Controls.Add(this.descentry);
            this.CTEntryPanel.Controls.Add(this.mrateL);
            this.CTEntryPanel.Controls.Add(this.wrateL);
            this.CTEntryPanel.Controls.Add(this.drateL);
            this.CTEntryPanel.Controls.Add(this.descriptionL);
            this.CTEntryPanel.Controls.Add(this.cartypeentrytitle);
            this.CTEntryPanel.Location = new System.Drawing.Point(0, 0);
            this.CTEntryPanel.Margin = new System.Windows.Forms.Padding(6);
            this.CTEntryPanel.Name = "CTEntryPanel";
            this.CTEntryPanel.Size = new System.Drawing.Size(1233, 1050);
            this.CTEntryPanel.TabIndex = 0;
            // 
            // LevelBx
            // 
            this.LevelBx.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.LevelBx.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.LevelBx.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LevelBx.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.LevelBx.Location = new System.Drawing.Point(201, 329);
            this.LevelBx.Margin = new System.Windows.Forms.Padding(6);
            this.LevelBx.Name = "LevelBx";
            this.LevelBx.Size = new System.Drawing.Size(336, 43);
            this.LevelBx.TabIndex = 106;
            // 
            // LevelLbl
            // 
            this.LevelLbl.AutoSize = true;
            this.LevelLbl.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.LevelLbl.Location = new System.Drawing.Point(30, 335);
            this.LevelLbl.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.LevelLbl.Name = "LevelLbl";
            this.LevelLbl.Size = new System.Drawing.Size(69, 32);
            this.LevelLbl.TabIndex = 105;
            this.LevelLbl.Text = "Level";
            // 
            // FindID
            // 
            this.FindID.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FindID.ForeColor = System.Drawing.Color.White;
            this.FindID.Location = new System.Drawing.Point(303, 19);
            this.FindID.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.FindID.Name = "FindID";
            this.FindID.Size = new System.Drawing.Size(140, 49);
            this.FindID.TabIndex = 104;
            this.FindID.Text = "Find ID";
            this.FindID.UseVisualStyleBackColor = true;
            this.FindID.Visible = false;
            this.FindID.Click += new System.EventHandler(this.FindID_Click);
            // 
            // RemoveRBtn
            // 
            this.RemoveRBtn.AutoSize = true;
            this.RemoveRBtn.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.RemoveRBtn.Location = new System.Drawing.Point(664, 215);
            this.RemoveRBtn.Name = "RemoveRBtn";
            this.RemoveRBtn.Size = new System.Drawing.Size(131, 36);
            this.RemoveRBtn.TabIndex = 103;
            this.RemoveRBtn.TabStop = true;
            this.RemoveRBtn.Text = "Remove";
            this.RemoveRBtn.UseVisualStyleBackColor = true;
            this.RemoveRBtn.CheckedChanged += new System.EventHandler(this.RemoveRBtn_CheckedChanged);
            // 
            // EditRBtn
            // 
            this.EditRBtn.AutoSize = true;
            this.EditRBtn.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.EditRBtn.Location = new System.Drawing.Point(664, 153);
            this.EditRBtn.Name = "EditRBtn";
            this.EditRBtn.Size = new System.Drawing.Size(85, 36);
            this.EditRBtn.TabIndex = 102;
            this.EditRBtn.TabStop = true;
            this.EditRBtn.Text = "Edit";
            this.EditRBtn.UseVisualStyleBackColor = true;
            this.EditRBtn.CheckedChanged += new System.EventHandler(this.EditRBtn_CheckedChanged);
            // 
            // AddRBtn
            // 
            this.AddRBtn.AutoSize = true;
            this.AddRBtn.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.AddRBtn.Location = new System.Drawing.Point(664, 86);
            this.AddRBtn.Name = "AddRBtn";
            this.AddRBtn.Size = new System.Drawing.Size(88, 36);
            this.AddRBtn.TabIndex = 101;
            this.AddRBtn.TabStop = true;
            this.AddRBtn.Text = "Add";
            this.AddRBtn.UseVisualStyleBackColor = true;
            this.AddRBtn.CheckedChanged += new System.EventHandler(this.AddRBtn_CheckedChanged);
            // 
            // CarTypeIdBx
            // 
            this.CarTypeIdBx.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.CarTypeIdBx.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CarTypeIdBx.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CarTypeIdBx.ForeColor = System.Drawing.SystemColors.Window;
            this.CarTypeIdBx.Location = new System.Drawing.Point(454, 23);
            this.CarTypeIdBx.Margin = new System.Windows.Forms.Padding(6);
            this.CarTypeIdBx.Name = "CarTypeIdBx";
            this.CarTypeIdBx.Size = new System.Drawing.Size(83, 43);
            this.CarTypeIdBx.TabIndex = 100;
            this.CarTypeIdBx.Visible = false;
            // 
            // ctentrycancel
            // 
            this.ctentrycancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(79)))), ((int)(((byte)(99)))));
            this.ctentrycancel.FlatAppearance.BorderSize = 0;
            this.ctentrycancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ctentrycancel.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ctentrycancel.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.ctentrycancel.Location = new System.Drawing.Point(916, 200);
            this.ctentrycancel.Margin = new System.Windows.Forms.Padding(6);
            this.ctentrycancel.Name = "ctentrycancel";
            this.ctentrycancel.Size = new System.Drawing.Size(184, 107);
            this.ctentrycancel.TabIndex = 97;
            this.ctentrycancel.Text = "Cancel";
            this.ctentrycancel.UseVisualStyleBackColor = false;
            this.ctentrycancel.Click += new System.EventHandler(this.ctentrycancel_Click);
            // 
            // ctentryacc
            // 
            this.ctentryacc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(79)))), ((int)(((byte)(99)))));
            this.ctentryacc.FlatAppearance.BorderSize = 0;
            this.ctentryacc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ctentryacc.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ctentryacc.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.ctentryacc.Location = new System.Drawing.Point(916, 76);
            this.ctentryacc.Margin = new System.Windows.Forms.Padding(6);
            this.ctentryacc.Name = "ctentryacc";
            this.ctentryacc.Size = new System.Drawing.Size(184, 107);
            this.ctentryacc.TabIndex = 96;
            this.ctentryacc.Text = "Accept";
            this.ctentryacc.UseVisualStyleBackColor = false;
            this.ctentryacc.Click += new System.EventHandler(this.ctentryacc_Click);
            // 
            // mrateentry
            // 
            this.mrateentry.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.mrateentry.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mrateentry.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.mrateentry.ForeColor = System.Drawing.SystemColors.Window;
            this.mrateentry.Location = new System.Drawing.Point(201, 269);
            this.mrateentry.Margin = new System.Windows.Forms.Padding(6);
            this.mrateentry.Name = "mrateentry";
            this.mrateentry.Size = new System.Drawing.Size(336, 43);
            this.mrateentry.TabIndex = 95;
            // 
            // wrateentry
            // 
            this.wrateentry.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.wrateentry.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.wrateentry.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.wrateentry.ForeColor = System.Drawing.SystemColors.Window;
            this.wrateentry.Location = new System.Drawing.Point(201, 207);
            this.wrateentry.Margin = new System.Windows.Forms.Padding(6);
            this.wrateentry.Name = "wrateentry";
            this.wrateentry.Size = new System.Drawing.Size(336, 43);
            this.wrateentry.TabIndex = 94;
            // 
            // drateentry
            // 
            this.drateentry.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.drateentry.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.drateentry.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.drateentry.ForeColor = System.Drawing.SystemColors.Window;
            this.drateentry.Location = new System.Drawing.Point(201, 145);
            this.drateentry.Margin = new System.Windows.Forms.Padding(6);
            this.drateentry.Name = "drateentry";
            this.drateentry.Size = new System.Drawing.Size(336, 43);
            this.drateentry.TabIndex = 93;
            // 
            // descentry
            // 
            this.descentry.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.descentry.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.descentry.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.descentry.ForeColor = System.Drawing.SystemColors.Window;
            this.descentry.Location = new System.Drawing.Point(201, 83);
            this.descentry.Margin = new System.Windows.Forms.Padding(6);
            this.descentry.Name = "descentry";
            this.descentry.Size = new System.Drawing.Size(336, 43);
            this.descentry.TabIndex = 92;
            // 
            // mrateL
            // 
            this.mrateL.AutoSize = true;
            this.mrateL.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.mrateL.Location = new System.Drawing.Point(30, 275);
            this.mrateL.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.mrateL.Name = "mrateL";
            this.mrateL.Size = new System.Drawing.Size(158, 32);
            this.mrateL.TabIndex = 91;
            this.mrateL.Text = "Monthly Rate";
            // 
            // wrateL
            // 
            this.wrateL.AutoSize = true;
            this.wrateL.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.wrateL.Location = new System.Drawing.Point(30, 213);
            this.wrateL.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.wrateL.Name = "wrateL";
            this.wrateL.Size = new System.Drawing.Size(145, 32);
            this.wrateL.TabIndex = 90;
            this.wrateL.Text = "Weekly Rate";
            // 
            // drateL
            // 
            this.drateL.AutoSize = true;
            this.drateL.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.drateL.Location = new System.Drawing.Point(30, 151);
            this.drateL.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.drateL.Name = "drateL";
            this.drateL.Size = new System.Drawing.Size(121, 32);
            this.drateL.TabIndex = 89;
            this.drateL.Text = "Daily Rate";
            // 
            // descriptionL
            // 
            this.descriptionL.AutoSize = true;
            this.descriptionL.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.descriptionL.Location = new System.Drawing.Point(30, 90);
            this.descriptionL.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.descriptionL.Name = "descriptionL";
            this.descriptionL.Size = new System.Drawing.Size(135, 32);
            this.descriptionL.TabIndex = 88;
            this.descriptionL.Text = "Description";
            // 
            // cartypeentrytitle
            // 
            this.cartypeentrytitle.AutoSize = true;
            this.cartypeentrytitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cartypeentrytitle.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.cartypeentrytitle.Location = new System.Drawing.Point(22, 19);
            this.cartypeentrytitle.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.cartypeentrytitle.Name = "cartypeentrytitle";
            this.cartypeentrytitle.Size = new System.Drawing.Size(166, 51);
            this.cartypeentrytitle.TabIndex = 87;
            this.cartypeentrytitle.Text = "Car Type";
            // 
            // CarTypeEntry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.ClientSize = new System.Drawing.Size(1233, 1050);
            this.Controls.Add(this.CTEntryPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "CarTypeEntry";
            this.Text = "CarTypeEntry";
            this.CTEntryPanel.ResumeLayout(false);
            this.CTEntryPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel CTEntryPanel;
        private Button ctentrycancel;
        private Button ctentryacc;
        private TextBox mrateentry;
        private TextBox wrateentry;
        private TextBox drateentry;
        private TextBox descentry;
        private Label mrateL;
        private Label wrateL;
        private Label drateL;
        private Label descriptionL;
        private Label cartypeentrytitle;
        private TextBox CarTypeIdBx;
        private RadioButton RemoveRBtn;
        private RadioButton EditRBtn;
        private RadioButton AddRBtn;
        private Button FindID;
        private TextBox LevelBx;
        private Label LevelLbl;
    }
}