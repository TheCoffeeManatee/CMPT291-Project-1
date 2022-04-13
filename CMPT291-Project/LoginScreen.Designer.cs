namespace CMPT291_Project
{
    partial class LoginScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginScreen));
            this.LoginMenuBar = new System.Windows.Forms.Panel();
            this.LoginCloseBtn = new System.Windows.Forms.Button();
            this.LoginMaxBtn = new System.Windows.Forms.Button();
            this.LoginMinBtn = new System.Windows.Forms.Button();
            this.CompanyPicture = new System.Windows.Forms.PictureBox();
            this.LogInLbl = new System.Windows.Forms.Label();
            this.LoginBtn = new System.Windows.Forms.Button();
            this.LoginMenuBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CompanyPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // LoginMenuBar
            // 
            this.LoginMenuBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.LoginMenuBar.Controls.Add(this.LoginCloseBtn);
            this.LoginMenuBar.Controls.Add(this.LoginMaxBtn);
            this.LoginMenuBar.Controls.Add(this.LoginMinBtn);
            this.LoginMenuBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.LoginMenuBar.Location = new System.Drawing.Point(0, 0);
            this.LoginMenuBar.Name = "LoginMenuBar";
            this.LoginMenuBar.Size = new System.Drawing.Size(300, 26);
            this.LoginMenuBar.TabIndex = 2;
            this.LoginMenuBar.Paint += new System.Windows.Forms.PaintEventHandler(this.LoginMenuBar_Paint);
            this.LoginMenuBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.LoginMenuBar_MouseDown);
            this.LoginMenuBar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.LoginMenuBar_MouseMove);
            this.LoginMenuBar.MouseUp += new System.Windows.Forms.MouseEventHandler(this.LoginMenuBar_MouseUp);
            // 
            // LoginCloseBtn
            // 
            this.LoginCloseBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LoginCloseBtn.BackgroundImage = global::CMPT291_Project.Properties.Resources.Cross3;
            this.LoginCloseBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.LoginCloseBtn.FlatAppearance.BorderSize = 0;
            this.LoginCloseBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LoginCloseBtn.Location = new System.Drawing.Point(277, 3);
            this.LoginCloseBtn.Name = "LoginCloseBtn";
            this.LoginCloseBtn.Size = new System.Drawing.Size(20, 20);
            this.LoginCloseBtn.TabIndex = 5;
            this.LoginCloseBtn.UseVisualStyleBackColor = true;
            this.LoginCloseBtn.Click += new System.EventHandler(this.LoginCloseBtn_Click);
            // 
            // LoginMaxBtn
            // 
            this.LoginMaxBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LoginMaxBtn.BackgroundImage = global::CMPT291_Project.Properties.Resources.MAX;
            this.LoginMaxBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.LoginMaxBtn.FlatAppearance.BorderSize = 0;
            this.LoginMaxBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LoginMaxBtn.Location = new System.Drawing.Point(251, 3);
            this.LoginMaxBtn.Name = "LoginMaxBtn";
            this.LoginMaxBtn.Size = new System.Drawing.Size(20, 20);
            this.LoginMaxBtn.TabIndex = 7;
            this.LoginMaxBtn.UseVisualStyleBackColor = true;
            this.LoginMaxBtn.Click += new System.EventHandler(this.LoginMaxBtn_Click);
            // 
            // LoginMinBtn
            // 
            this.LoginMinBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LoginMinBtn.BackgroundImage = global::CMPT291_Project.Properties.Resources.Minus2;
            this.LoginMinBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.LoginMinBtn.FlatAppearance.BorderSize = 0;
            this.LoginMinBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LoginMinBtn.Location = new System.Drawing.Point(225, 3);
            this.LoginMinBtn.Name = "LoginMinBtn";
            this.LoginMinBtn.Size = new System.Drawing.Size(20, 20);
            this.LoginMinBtn.TabIndex = 6;
            this.LoginMinBtn.UseVisualStyleBackColor = true;
            this.LoginMinBtn.Click += new System.EventHandler(this.LoginMinBtn_Click);
            // 
            // CompanyPicture
            // 
            this.CompanyPicture.Image = ((System.Drawing.Image)(resources.GetObject("CompanyPicture.Image")));
            this.CompanyPicture.Location = new System.Drawing.Point(75, 65);
            this.CompanyPicture.Name = "CompanyPicture";
            this.CompanyPicture.Size = new System.Drawing.Size(150, 150);
            this.CompanyPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.CompanyPicture.TabIndex = 3;
            this.CompanyPicture.TabStop = false;
            // 
            // LogInLbl
            // 
            this.LogInLbl.AutoSize = true;
            this.LogInLbl.Font = new System.Drawing.Font("Lucida Bright", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LogInLbl.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.LogInLbl.Location = new System.Drawing.Point(84, 235);
            this.LogInLbl.Name = "LogInLbl";
            this.LogInLbl.Size = new System.Drawing.Size(130, 42);
            this.LogInLbl.TabIndex = 4;
            this.LogInLbl.Text = "Log In";
            // 
            // LoginBtn
            // 
            this.LoginBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.LoginBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LoginBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LoginBtn.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.LoginBtn.Location = new System.Drawing.Point(75, 328);
            this.LoginBtn.Name = "LoginBtn";
            this.LoginBtn.Size = new System.Drawing.Size(150, 41);
            this.LoginBtn.TabIndex = 6;
            this.LoginBtn.Text = "Log In ";
            this.LoginBtn.UseVisualStyleBackColor = false;
            this.LoginBtn.Click += new System.EventHandler(this.LoginBtn_Click);
            // 
            // LoginScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(300, 450);
            this.Controls.Add(this.LoginBtn);
            this.Controls.Add(this.LogInLbl);
            this.Controls.Add(this.CompanyPicture);
            this.Controls.Add(this.LoginMenuBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LoginScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LoginScreen";
            this.LoginMenuBar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.CompanyPicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private bool mouseDown;
        private Point lastLocation;
        private Panel LoginMenuBar;
        private Button LoginCloseBtn;
        private Button LoginMaxBtn;
        private Button LoginMinBtn;
        private PictureBox CompanyPicture;
        private Label LogInLbl;
        private Button LoginBtn;
    }
}