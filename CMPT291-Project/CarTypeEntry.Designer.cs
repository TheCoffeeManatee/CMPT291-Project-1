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
            this.label1 = new System.Windows.Forms.Label();
            this.LevelBx = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // FindID
            // 
            this.FindID.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FindID.ForeColor = System.Drawing.Color.White;
            this.FindID.Location = new System.Drawing.Point(170, 17);
            this.FindID.Name = "FindID";
            this.FindID.Size = new System.Drawing.Size(75, 23);
            this.FindID.TabIndex = 120;
            this.FindID.Text = "Find ID";
            this.FindID.UseVisualStyleBackColor = true;
            this.FindID.Visible = false;
            this.FindID.Click += new System.EventHandler(this.FindID_Click_1);
            // 
            // RemoveRBtn
            // 
            this.RemoveRBtn.AutoSize = true;
            this.RemoveRBtn.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.RemoveRBtn.Location = new System.Drawing.Point(365, 109);
            this.RemoveRBtn.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.RemoveRBtn.Name = "RemoveRBtn";
            this.RemoveRBtn.Size = new System.Drawing.Size(68, 19);
            this.RemoveRBtn.TabIndex = 119;
            this.RemoveRBtn.TabStop = true;
            this.RemoveRBtn.Text = "Remove";
            this.RemoveRBtn.UseVisualStyleBackColor = true;
            this.RemoveRBtn.CheckedChanged += new System.EventHandler(this.RemoveRBtn_CheckedChanged_1);
            // 
            // EditRBtn
            // 
            this.EditRBtn.AutoSize = true;
            this.EditRBtn.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.EditRBtn.Location = new System.Drawing.Point(365, 80);
            this.EditRBtn.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.EditRBtn.Name = "EditRBtn";
            this.EditRBtn.Size = new System.Drawing.Size(45, 19);
            this.EditRBtn.TabIndex = 118;
            this.EditRBtn.TabStop = true;
            this.EditRBtn.Text = "Edit";
            this.EditRBtn.UseVisualStyleBackColor = true;
            this.EditRBtn.CheckedChanged += new System.EventHandler(this.EditRBtn_CheckedChanged_1);
            // 
            // AddRBtn
            // 
            this.AddRBtn.AutoSize = true;
            this.AddRBtn.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.AddRBtn.Location = new System.Drawing.Point(365, 48);
            this.AddRBtn.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.AddRBtn.Name = "AddRBtn";
            this.AddRBtn.Size = new System.Drawing.Size(47, 19);
            this.AddRBtn.TabIndex = 117;
            this.AddRBtn.TabStop = true;
            this.AddRBtn.Text = "Add";
            this.AddRBtn.UseVisualStyleBackColor = true;
            this.AddRBtn.CheckedChanged += new System.EventHandler(this.AddRBtn_CheckedChanged_1);
            // 
            // CarTypeIdBx
            // 
            this.CarTypeIdBx.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.CarTypeIdBx.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CarTypeIdBx.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CarTypeIdBx.ForeColor = System.Drawing.SystemColors.Window;
            this.CarTypeIdBx.Location = new System.Drawing.Point(251, 19);
            this.CarTypeIdBx.Name = "CarTypeIdBx";
            this.CarTypeIdBx.Size = new System.Drawing.Size(45, 22);
            this.CarTypeIdBx.TabIndex = 116;
            this.CarTypeIdBx.Visible = false;
            // 
            // ctentrycancel
            // 
            this.ctentrycancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(79)))), ((int)(((byte)(99)))));
            this.ctentrycancel.FlatAppearance.BorderSize = 0;
            this.ctentrycancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ctentrycancel.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ctentrycancel.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.ctentrycancel.Location = new System.Drawing.Point(500, 102);
            this.ctentrycancel.Name = "ctentrycancel";
            this.ctentrycancel.Size = new System.Drawing.Size(99, 50);
            this.ctentrycancel.TabIndex = 115;
            this.ctentrycancel.Text = "Cancel";
            this.ctentrycancel.UseVisualStyleBackColor = false;
            this.ctentrycancel.Click += new System.EventHandler(this.ctentrycancel_Click_1);
            // 
            // ctentryacc
            // 
            this.ctentryacc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(79)))), ((int)(((byte)(99)))));
            this.ctentryacc.FlatAppearance.BorderSize = 0;
            this.ctentryacc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ctentryacc.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ctentryacc.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.ctentryacc.Location = new System.Drawing.Point(500, 44);
            this.ctentryacc.Name = "ctentryacc";
            this.ctentryacc.Size = new System.Drawing.Size(99, 50);
            this.ctentryacc.TabIndex = 114;
            this.ctentryacc.Text = "Accept";
            this.ctentryacc.UseVisualStyleBackColor = false;
            this.ctentryacc.Click += new System.EventHandler(this.ctentryacc_Click_1);
            // 
            // mrateentry
            // 
            this.mrateentry.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.mrateentry.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mrateentry.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.mrateentry.ForeColor = System.Drawing.SystemColors.Window;
            this.mrateentry.Location = new System.Drawing.Point(115, 134);
            this.mrateentry.Name = "mrateentry";
            this.mrateentry.Size = new System.Drawing.Size(181, 22);
            this.mrateentry.TabIndex = 113;
            // 
            // wrateentry
            // 
            this.wrateentry.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.wrateentry.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.wrateentry.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.wrateentry.ForeColor = System.Drawing.SystemColors.Window;
            this.wrateentry.Location = new System.Drawing.Point(115, 105);
            this.wrateentry.Name = "wrateentry";
            this.wrateentry.Size = new System.Drawing.Size(181, 22);
            this.wrateentry.TabIndex = 112;
            // 
            // drateentry
            // 
            this.drateentry.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.drateentry.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.drateentry.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.drateentry.ForeColor = System.Drawing.SystemColors.Window;
            this.drateentry.Location = new System.Drawing.Point(115, 76);
            this.drateentry.Name = "drateentry";
            this.drateentry.Size = new System.Drawing.Size(181, 22);
            this.drateentry.TabIndex = 111;
            // 
            // descentry
            // 
            this.descentry.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.descentry.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.descentry.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.descentry.ForeColor = System.Drawing.SystemColors.Window;
            this.descentry.Location = new System.Drawing.Point(115, 47);
            this.descentry.Name = "descentry";
            this.descentry.Size = new System.Drawing.Size(181, 22);
            this.descentry.TabIndex = 110;
            // 
            // mrateL
            // 
            this.mrateL.AutoSize = true;
            this.mrateL.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.mrateL.Location = new System.Drawing.Point(23, 137);
            this.mrateL.Name = "mrateL";
            this.mrateL.Size = new System.Drawing.Size(78, 15);
            this.mrateL.TabIndex = 109;
            this.mrateL.Text = "Monthly Rate";
            // 
            // wrateL
            // 
            this.wrateL.AutoSize = true;
            this.wrateL.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.wrateL.Location = new System.Drawing.Point(23, 108);
            this.wrateL.Name = "wrateL";
            this.wrateL.Size = new System.Drawing.Size(71, 15);
            this.wrateL.TabIndex = 108;
            this.wrateL.Text = "Weekly Rate";
            // 
            // drateL
            // 
            this.drateL.AutoSize = true;
            this.drateL.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.drateL.Location = new System.Drawing.Point(23, 79);
            this.drateL.Name = "drateL";
            this.drateL.Size = new System.Drawing.Size(59, 15);
            this.drateL.TabIndex = 107;
            this.drateL.Text = "Daily Rate";
            // 
            // descriptionL
            // 
            this.descriptionL.AutoSize = true;
            this.descriptionL.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.descriptionL.Location = new System.Drawing.Point(23, 50);
            this.descriptionL.Name = "descriptionL";
            this.descriptionL.Size = new System.Drawing.Size(67, 15);
            this.descriptionL.TabIndex = 106;
            this.descriptionL.Text = "Description";
            // 
            // cartypeentrytitle
            // 
            this.cartypeentrytitle.AutoSize = true;
            this.cartypeentrytitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cartypeentrytitle.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.cartypeentrytitle.Location = new System.Drawing.Point(19, 17);
            this.cartypeentrytitle.Name = "cartypeentrytitle";
            this.cartypeentrytitle.Size = new System.Drawing.Size(85, 25);
            this.cartypeentrytitle.TabIndex = 105;
            this.cartypeentrytitle.Text = "Car Type";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.label1.Location = new System.Drawing.Point(23, 167);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 15);
            this.label1.TabIndex = 121;
            this.label1.Text = "LevelLbl";
            // 
            // LevelBx
            // 
            this.LevelBx.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.LevelBx.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.LevelBx.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LevelBx.ForeColor = System.Drawing.SystemColors.Window;
            this.LevelBx.Location = new System.Drawing.Point(115, 164);
            this.LevelBx.Name = "LevelBx";
            this.LevelBx.Size = new System.Drawing.Size(181, 22);
            this.LevelBx.TabIndex = 122;
            // 
            // CarTypeEntry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.ClientSize = new System.Drawing.Size(664, 492);
            this.Controls.Add(this.LevelBx);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.FindID);
            this.Controls.Add(this.RemoveRBtn);
            this.Controls.Add(this.EditRBtn);
            this.Controls.Add(this.AddRBtn);
            this.Controls.Add(this.CarTypeIdBx);
            this.Controls.Add(this.ctentrycancel);
            this.Controls.Add(this.ctentryacc);
            this.Controls.Add(this.mrateentry);
            this.Controls.Add(this.wrateentry);
            this.Controls.Add(this.drateentry);
            this.Controls.Add(this.descentry);
            this.Controls.Add(this.mrateL);
            this.Controls.Add(this.wrateL);
            this.Controls.Add(this.drateL);
            this.Controls.Add(this.descriptionL);
            this.Controls.Add(this.cartypeentrytitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CarTypeEntry";
            this.Text = "CarTypeEntry";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button FindID;
        private RadioButton RemoveRBtn;
        private RadioButton EditRBtn;
        private RadioButton AddRBtn;
        private TextBox CarTypeIdBx;
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
        private Label label1;
        private TextBox LevelBx;
    }
}