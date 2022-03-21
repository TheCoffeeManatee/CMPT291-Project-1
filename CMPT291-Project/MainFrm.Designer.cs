namespace CMPT291_Project
{
    partial class MainFrm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainFrm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.ReportsBtn = new System.Windows.Forms.Button();
            this.CustomerBtn = new System.Windows.Forms.Button();
            this.SettingsBtn = new System.Windows.Forms.Button();
            this.CarTypeBtn = new System.Windows.Forms.Button();
            this.CarsBtn = new System.Windows.Forms.Button();
            this.BranchBtn = new System.Windows.Forms.Button();
            this.TransactionsBtn = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.ProfilePicture = new System.Windows.Forms.PictureBox();
            this.UserNameLbl = new System.Windows.Forms.Label();
            this.MenuBar = new System.Windows.Forms.Panel();
            this.ExitBtn = new System.Windows.Forms.Button();
            this.ResizeBtn = new System.Windows.Forms.Button();
            this.MinBtn = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.HomePnl = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProfilePicture)).BeginInit();
            this.MenuBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.panel1.Controls.Add(this.ReportsBtn);
            this.panel1.Controls.Add(this.CustomerBtn);
            this.panel1.Controls.Add(this.SettingsBtn);
            this.panel1.Controls.Add(this.CarTypeBtn);
            this.panel1.Controls.Add(this.CarsBtn);
            this.panel1.Controls.Add(this.BranchBtn);
            this.panel1.Controls.Add(this.TransactionsBtn);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(358, 1111);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // ReportsBtn
            // 
            this.ReportsBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.ReportsBtn.FlatAppearance.BorderSize = 0;
            this.ReportsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ReportsBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ReportsBtn.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.ReportsBtn.Location = new System.Drawing.Point(0, 804);
            this.ReportsBtn.Margin = new System.Windows.Forms.Padding(6);
            this.ReportsBtn.Name = "ReportsBtn";
            this.ReportsBtn.Size = new System.Drawing.Size(358, 90);
            this.ReportsBtn.TabIndex = 7;
            this.ReportsBtn.Text = "Reports";
            this.ReportsBtn.UseVisualStyleBackColor = true;
            this.ReportsBtn.Click += new System.EventHandler(this.ReportsBtn_Click);
            // 
            // CustomerBtn
            // 
            this.CustomerBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.CustomerBtn.FlatAppearance.BorderSize = 0;
            this.CustomerBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CustomerBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CustomerBtn.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.CustomerBtn.Location = new System.Drawing.Point(0, 714);
            this.CustomerBtn.Margin = new System.Windows.Forms.Padding(6);
            this.CustomerBtn.Name = "CustomerBtn";
            this.CustomerBtn.Size = new System.Drawing.Size(358, 90);
            this.CustomerBtn.TabIndex = 6;
            this.CustomerBtn.Text = "Customers";
            this.CustomerBtn.UseVisualStyleBackColor = true;
            this.CustomerBtn.Click += new System.EventHandler(this.CustomerBtn_Click);
            // 
            // SettingsBtn
            // 
            this.SettingsBtn.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.SettingsBtn.FlatAppearance.BorderSize = 0;
            this.SettingsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SettingsBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SettingsBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.SettingsBtn.Location = new System.Drawing.Point(0, 1021);
            this.SettingsBtn.Margin = new System.Windows.Forms.Padding(6);
            this.SettingsBtn.Name = "SettingsBtn";
            this.SettingsBtn.Size = new System.Drawing.Size(358, 90);
            this.SettingsBtn.TabIndex = 5;
            this.SettingsBtn.Text = "Settings";
            this.SettingsBtn.UseVisualStyleBackColor = true;
            // 
            // CarTypeBtn
            // 
            this.CarTypeBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.CarTypeBtn.FlatAppearance.BorderSize = 0;
            this.CarTypeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CarTypeBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CarTypeBtn.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.CarTypeBtn.Location = new System.Drawing.Point(0, 624);
            this.CarTypeBtn.Margin = new System.Windows.Forms.Padding(6);
            this.CarTypeBtn.Name = "CarTypeBtn";
            this.CarTypeBtn.Size = new System.Drawing.Size(358, 90);
            this.CarTypeBtn.TabIndex = 4;
            this.CarTypeBtn.Text = "Car Type";
            this.CarTypeBtn.UseVisualStyleBackColor = true;
            this.CarTypeBtn.Click += new System.EventHandler(this.CarTypeBtn_Click);
            // 
            // CarsBtn
            // 
            this.CarsBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.CarsBtn.FlatAppearance.BorderSize = 0;
            this.CarsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CarsBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CarsBtn.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.CarsBtn.Location = new System.Drawing.Point(0, 534);
            this.CarsBtn.Margin = new System.Windows.Forms.Padding(6);
            this.CarsBtn.Name = "CarsBtn";
            this.CarsBtn.Size = new System.Drawing.Size(358, 90);
            this.CarsBtn.TabIndex = 3;
            this.CarsBtn.Text = "Cars";
            this.CarsBtn.UseVisualStyleBackColor = true;
            this.CarsBtn.Click += new System.EventHandler(this.CarsBtn_Click);
            // 
            // BranchBtn
            // 
            this.BranchBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.BranchBtn.FlatAppearance.BorderSize = 0;
            this.BranchBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BranchBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BranchBtn.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.BranchBtn.Location = new System.Drawing.Point(0, 444);
            this.BranchBtn.Margin = new System.Windows.Forms.Padding(6);
            this.BranchBtn.Name = "BranchBtn";
            this.BranchBtn.Size = new System.Drawing.Size(358, 90);
            this.BranchBtn.TabIndex = 2;
            this.BranchBtn.Text = "Branch";
            this.BranchBtn.UseVisualStyleBackColor = true;
            this.BranchBtn.Click += new System.EventHandler(this.BranchBtn_Click);
            // 
            // TransactionsBtn
            // 
            this.TransactionsBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.TransactionsBtn.FlatAppearance.BorderSize = 0;
            this.TransactionsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TransactionsBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TransactionsBtn.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.TransactionsBtn.Location = new System.Drawing.Point(0, 354);
            this.TransactionsBtn.Margin = new System.Windows.Forms.Padding(6);
            this.TransactionsBtn.Name = "TransactionsBtn";
            this.TransactionsBtn.Size = new System.Drawing.Size(358, 90);
            this.TransactionsBtn.TabIndex = 1;
            this.TransactionsBtn.Text = "Transactions";
            this.TransactionsBtn.UseVisualStyleBackColor = true;
            this.TransactionsBtn.Click += new System.EventHandler(this.TransactionBtn_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.ProfilePicture);
            this.panel2.Controls.Add(this.UserNameLbl);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(6);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(358, 354);
            this.panel2.TabIndex = 0;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // ProfilePicture
            // 
            this.ProfilePicture.Image = ((System.Drawing.Image)(resources.GetObject("ProfilePicture.Image")));
            this.ProfilePicture.Location = new System.Drawing.Point(123, 66);
            this.ProfilePicture.Margin = new System.Windows.Forms.Padding(6);
            this.ProfilePicture.Name = "ProfilePicture";
            this.ProfilePicture.Size = new System.Drawing.Size(93, 107);
            this.ProfilePicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ProfilePicture.TabIndex = 0;
            this.ProfilePicture.TabStop = false;
            // 
            // UserNameLbl
            // 
            this.UserNameLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.UserNameLbl.AutoSize = true;
            this.UserNameLbl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.UserNameLbl.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.UserNameLbl.Location = new System.Drawing.Point(87, 177);
            this.UserNameLbl.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.UserNameLbl.Name = "UserNameLbl";
            this.UserNameLbl.Size = new System.Drawing.Size(178, 45);
            this.UserNameLbl.TabIndex = 1;
            this.UserNameLbl.Text = "User Name";
            this.UserNameLbl.Click += new System.EventHandler(this.label1_Click);
            // 
            // MenuBar
            // 
            this.MenuBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.MenuBar.Controls.Add(this.ExitBtn);
            this.MenuBar.Controls.Add(this.ResizeBtn);
            this.MenuBar.Controls.Add(this.MinBtn);
            this.MenuBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.MenuBar.Location = new System.Drawing.Point(358, 0);
            this.MenuBar.Margin = new System.Windows.Forms.Padding(6);
            this.MenuBar.Name = "MenuBar";
            this.MenuBar.Size = new System.Drawing.Size(1234, 55);
            this.MenuBar.TabIndex = 1;
            this.MenuBar.Paint += new System.Windows.Forms.PaintEventHandler(this.MenuBar_Paint);
            this.MenuBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MenuBar_MouseDown);
            this.MenuBar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MenuBar_MouseMove);
            this.MenuBar.MouseUp += new System.Windows.Forms.MouseEventHandler(this.MenuBar_MouseUp);
            // 
            // ExitBtn
            // 
            this.ExitBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ExitBtn.BackgroundImage = global::CMPT291_Project.Properties.Resources.Cross3;
            this.ExitBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ExitBtn.FlatAppearance.BorderSize = 0;
            this.ExitBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExitBtn.Location = new System.Drawing.Point(1191, 6);
            this.ExitBtn.Margin = new System.Windows.Forms.Padding(6);
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.Size = new System.Drawing.Size(37, 43);
            this.ExitBtn.TabIndex = 2;
            this.ExitBtn.UseVisualStyleBackColor = true;
            this.ExitBtn.Click += new System.EventHandler(this.ExitBtn_Click);
            // 
            // ResizeBtn
            // 
            this.ResizeBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ResizeBtn.BackgroundImage = global::CMPT291_Project.Properties.Resources.Query2;
            this.ResizeBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ResizeBtn.FlatAppearance.BorderSize = 0;
            this.ResizeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ResizeBtn.Location = new System.Drawing.Point(1143, 6);
            this.ResizeBtn.Margin = new System.Windows.Forms.Padding(6);
            this.ResizeBtn.Name = "ResizeBtn";
            this.ResizeBtn.Size = new System.Drawing.Size(37, 43);
            this.ResizeBtn.TabIndex = 4;
            this.ResizeBtn.UseVisualStyleBackColor = true;
            this.ResizeBtn.Click += new System.EventHandler(this.ResizeBtn_Click);
            // 
            // MinBtn
            // 
            this.MinBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.MinBtn.BackgroundImage = global::CMPT291_Project.Properties.Resources.Minus2;
            this.MinBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.MinBtn.FlatAppearance.BorderSize = 0;
            this.MinBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MinBtn.Location = new System.Drawing.Point(1095, 6);
            this.MinBtn.Margin = new System.Windows.Forms.Padding(6);
            this.MinBtn.Name = "MinBtn";
            this.MinBtn.Size = new System.Drawing.Size(37, 43);
            this.MinBtn.TabIndex = 3;
            this.MinBtn.UseVisualStyleBackColor = true;
            this.MinBtn.Click += new System.EventHandler(this.MinBtn_Click);
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            // 
            // HomePnl
            // 
            this.HomePnl.Dock = System.Windows.Forms.DockStyle.Top;
            this.HomePnl.Location = new System.Drawing.Point(358, 55);
            this.HomePnl.Margin = new System.Windows.Forms.Padding(6);
            this.HomePnl.Name = "HomePnl";
            this.HomePnl.Size = new System.Drawing.Size(1234, 1050);
            this.HomePnl.TabIndex = 2;
            // 
            // MainFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(1592, 1111);
            this.Controls.Add(this.HomePnl);
            this.Controls.Add(this.MenuBar);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "MainFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "`";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProfilePicture)).EndInit();
            this.MenuBar.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private bool mouseDown;
        private Point lastLocation;
        private Panel panel1;
        private Label UserNameLbl;
        private Panel panel2;
        private PictureBox ProfilePicture;
        private Button TransactionsBtn;
        private Button CarsBtn;
        private Button BranchBtn;
        private Button SettingsBtn;
        private Button CarTypeBtn;
        private Panel MenuBar;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Button ExitBtn;
        private Button ResizeBtn;
        private Button MinBtn;
        private Panel HomePnl;
        private Button ReportsBtn;
        private Button CustomerBtn;
    }
}