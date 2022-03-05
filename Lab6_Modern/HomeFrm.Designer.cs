namespace Lab6_Modern
{
    partial class HomeFrm
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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.Answer = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.HomeFormLabel = new System.Windows.Forms.Label();
            this.HomeFormPanel1 = new System.Windows.Forms.Panel();
            this.CalcBtn = new System.Windows.Forms.Button();
            this.MulBtn = new System.Windows.Forms.RadioButton();
            this.SubBtn = new System.Windows.Forms.RadioButton();
            this.AddBtn = new System.Windows.Forms.RadioButton();
            this.SecondNum = new System.Windows.Forms.TextBox();
            this.FirstNum = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.CalcLabel = new System.Windows.Forms.Label();
            this.panel3.SuspendLayout();
            this.HomeFormPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.flowLayoutPanel1.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(393, 95);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(248, 376);
            this.flowLayoutPanel1.TabIndex = 8;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.panel3.Controls.Add(this.Answer);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Location = new System.Drawing.Point(43, 349);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(327, 122);
            this.panel3.TabIndex = 7;
            // 
            // Answer
            // 
            this.Answer.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Answer.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Answer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.Answer.Location = new System.Drawing.Point(0, 54);
            this.Answer.Name = "Answer";
            this.Answer.Size = new System.Drawing.Size(327, 68);
            this.Answer.TabIndex = 3;
            this.Answer.Text = "Answer";
            this.Answer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Answer.Visible = false;
            // 
            // label3
            // 
            this.label3.Dock = System.Windows.Forms.DockStyle.Top;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(327, 54);
            this.label3.TabIndex = 2;
            this.label3.Text = "Result";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // HomeFormLabel
            // 
            this.HomeFormLabel.AutoSize = true;
            this.HomeFormLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.HomeFormLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.HomeFormLabel.Location = new System.Drawing.Point(20, 21);
            this.HomeFormLabel.Name = "HomeFormLabel";
            this.HomeFormLabel.Size = new System.Drawing.Size(97, 33);
            this.HomeFormLabel.TabIndex = 5;
            this.HomeFormLabel.Text = "Home";
            // 
            // HomeFormPanel1
            // 
            this.HomeFormPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.HomeFormPanel1.Controls.Add(this.CalcBtn);
            this.HomeFormPanel1.Controls.Add(this.MulBtn);
            this.HomeFormPanel1.Controls.Add(this.SubBtn);
            this.HomeFormPanel1.Controls.Add(this.AddBtn);
            this.HomeFormPanel1.Controls.Add(this.SecondNum);
            this.HomeFormPanel1.Controls.Add(this.FirstNum);
            this.HomeFormPanel1.Controls.Add(this.label2);
            this.HomeFormPanel1.Controls.Add(this.label1);
            this.HomeFormPanel1.Controls.Add(this.CalcLabel);
            this.HomeFormPanel1.Location = new System.Drawing.Point(43, 95);
            this.HomeFormPanel1.Name = "HomeFormPanel1";
            this.HomeFormPanel1.Size = new System.Drawing.Size(327, 231);
            this.HomeFormPanel1.TabIndex = 6;
            // 
            // CalcBtn
            // 
            this.CalcBtn.FlatAppearance.BorderColor = System.Drawing.SystemColors.ScrollBar;
            this.CalcBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CalcBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CalcBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.CalcBtn.Location = new System.Drawing.Point(84, 180);
            this.CalcBtn.Name = "CalcBtn";
            this.CalcBtn.Size = new System.Drawing.Size(148, 38);
            this.CalcBtn.TabIndex = 8;
            this.CalcBtn.Text = "Calculate";
            this.CalcBtn.UseVisualStyleBackColor = true;
            this.CalcBtn.Click += new System.EventHandler(this.CalcBtn_Click);
            // 
            // MulBtn
            // 
            this.MulBtn.AutoSize = true;
            this.MulBtn.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MulBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.MulBtn.Location = new System.Drawing.Point(203, 143);
            this.MulBtn.Name = "MulBtn";
            this.MulBtn.Size = new System.Drawing.Size(77, 23);
            this.MulBtn.TabIndex = 7;
            this.MulBtn.Text = "Multiply";
            this.MulBtn.UseVisualStyleBackColor = true;
            // 
            // SubBtn
            // 
            this.SubBtn.AutoSize = true;
            this.SubBtn.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SubBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.SubBtn.Location = new System.Drawing.Point(103, 143);
            this.SubBtn.Name = "SubBtn";
            this.SubBtn.Size = new System.Drawing.Size(78, 23);
            this.SubBtn.TabIndex = 6;
            this.SubBtn.Text = "Subtract";
            this.SubBtn.UseVisualStyleBackColor = true;
            // 
            // AddBtn
            // 
            this.AddBtn.AutoSize = true;
            this.AddBtn.Checked = true;
            this.AddBtn.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AddBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.AddBtn.Location = new System.Drawing.Point(27, 143);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(52, 23);
            this.AddBtn.TabIndex = 3;
            this.AddBtn.TabStop = true;
            this.AddBtn.Text = "Add";
            this.AddBtn.UseVisualStyleBackColor = true;
            // 
            // SecondNum
            // 
            this.SecondNum.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(79)))), ((int)(((byte)(99)))));
            this.SecondNum.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.SecondNum.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SecondNum.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.SecondNum.Location = new System.Drawing.Point(192, 104);
            this.SecondNum.Name = "SecondNum";
            this.SecondNum.Size = new System.Drawing.Size(115, 22);
            this.SecondNum.TabIndex = 5;
            this.SecondNum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // FirstNum
            // 
            this.FirstNum.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(79)))), ((int)(((byte)(99)))));
            this.FirstNum.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.FirstNum.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FirstNum.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.FirstNum.Location = new System.Drawing.Point(192, 67);
            this.FirstNum.Name = "FirstNum";
            this.FirstNum.Size = new System.Drawing.Size(115, 22);
            this.FirstNum.TabIndex = 4;
            this.FirstNum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.label2.Location = new System.Drawing.Point(14, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(172, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Second Number:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.label1.Location = new System.Drawing.Point(14, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "First Number:";
            // 
            // CalcLabel
            // 
            this.CalcLabel.AutoSize = true;
            this.CalcLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.CalcLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.CalcLabel.Location = new System.Drawing.Point(87, 12);
            this.CalcLabel.Name = "CalcLabel";
            this.CalcLabel.Size = new System.Drawing.Size(157, 33);
            this.CalcLabel.TabIndex = 1;
            this.CalcLabel.Text = "Calculator";
            // 
            // HomeFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(664, 492);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.HomeFormLabel);
            this.Controls.Add(this.HomeFormPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "HomeFrm";
            this.Text = "HomeFrm";
            this.Load += new System.EventHandler(this.HomeFrm_Load);
            this.panel3.ResumeLayout(false);
            this.HomeFormPanel1.ResumeLayout(false);
            this.HomeFormPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FlowLayoutPanel flowLayoutPanel1;
        private Panel panel3;
        private Label Answer;
        private Label label3;
        private Label HomeFormLabel;
        private Panel HomeFormPanel1;
        private Button CalcBtn;
        private RadioButton MulBtn;
        private RadioButton SubBtn;
        private RadioButton AddBtn;
        private TextBox SecondNum;
        private TextBox FirstNum;
        private Label label2;
        private Label label1;
        private Label CalcLabel;
    }
}