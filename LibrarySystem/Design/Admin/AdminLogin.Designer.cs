namespace LibrarySystem
{
    partial class AdminLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminLogin));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            AdLogin_btn = new Button();
            adminPass_tbox = new TextBox();
            label5 = new Label();
            AdminLogIn_tbox = new TextBox();
            label4 = new Label();
            pictureBox1 = new PictureBox();
            X = new Label();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(126, 107);
            label1.Name = "label1";
            label1.Size = new Size(340, 32);
            label1.TabIndex = 20;
            label1.Text = "Library Management System";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.FlatStyle = FlatStyle.Flat;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ControlDarkDark;
            label2.Location = new Point(199, 140);
            label2.Name = "label2";
            label2.Size = new Size(184, 20);
            label2.TabIndex = 19;
            label2.Text = "STI College Ortigas-Cainta";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.FlatStyle = FlatStyle.Flat;
            label3.Font = new Font("Segoe UI Black", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.HotTrack;
            label3.Location = new Point(185, 193);
            label3.Name = "label3";
            label3.Size = new Size(231, 41);
            label3.TabIndex = 18;
            label3.Text = "ADMIN LOGIN";
            // 
            // AdLogin_btn
            // 
            AdLogin_btn.BackColor = SystemColors.Highlight;
            AdLogin_btn.FlatStyle = FlatStyle.Flat;
            AdLogin_btn.Font = new Font("Segoe UI Black", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            AdLogin_btn.ForeColor = Color.Yellow;
            AdLogin_btn.Location = new Point(199, 466);
            AdLogin_btn.Margin = new Padding(3, 4, 3, 4);
            AdLogin_btn.Name = "AdLogin_btn";
            AdLogin_btn.Size = new Size(162, 51);
            AdLogin_btn.TabIndex = 17;
            AdLogin_btn.Text = "LOGIN";
            AdLogin_btn.UseVisualStyleBackColor = false;
            AdLogin_btn.Click += AdLogin_btn_Click;
            // 
            // adminPass_tbox
            // 
            adminPass_tbox.BackColor = Color.Gainsboro;
            adminPass_tbox.Location = new Point(126, 386);
            adminPass_tbox.Margin = new Padding(3, 4, 3, 4);
            adminPass_tbox.Name = "adminPass_tbox";
            adminPass_tbox.PasswordChar = 'X';
            adminPass_tbox.Size = new Size(348, 27);
            adminPass_tbox.TabIndex = 16;
            adminPass_tbox.UseSystemPasswordChar = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Location = new Point(126, 362);
            label5.Name = "label5";
            label5.Size = new Size(70, 20);
            label5.TabIndex = 15;
            label5.Text = "Password";
            // 
            // AdminLogIn_tbox
            // 
            AdminLogIn_tbox.BackColor = Color.Gainsboro;
            AdminLogIn_tbox.Location = new Point(126, 303);
            AdminLogIn_tbox.Margin = new Padding(3, 4, 3, 4);
            AdminLogIn_tbox.Name = "AdminLogIn_tbox";
            AdminLogIn_tbox.Size = new Size(348, 27);
            AdminLogIn_tbox.TabIndex = 14;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Location = new Point(126, 279);
            label4.Name = "label4";
            label4.Size = new Size(46, 20);
            label4.TabIndex = 13;
            label4.Text = "Email";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(254, 31);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(83, 55);
            pictureBox1.TabIndex = 12;
            pictureBox1.TabStop = false;
            // 
            // X
            // 
            X.AutoSize = true;
            X.BackColor = Color.Transparent;
            X.FlatStyle = FlatStyle.Flat;
            X.Font = new Font("Segoe UI Black", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            X.ForeColor = SystemColors.HotTrack;
            X.Location = new Point(510, 0);
            X.Name = "X";
            X.Size = new Size(39, 41);
            X.TabIndex = 21;
            X.Text = "X";
            X.Click += X_Click;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(95, 560);
            panel1.TabIndex = 22;
            // 
            // AdminLogin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(548, 557);
            Controls.Add(panel1);
            Controls.Add(X);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(label3);
            Controls.Add(AdLogin_btn);
            Controls.Add(adminPass_tbox);
            Controls.Add(label5);
            Controls.Add(AdminLogIn_tbox);
            Controls.Add(label4);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "AdminLogin";
            Text = "AdminLogin";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Button AdLogin_btn;
        private TextBox adminPass_tbox;
        private Label label5;
        private TextBox AdminLogIn_tbox;
        private Label label4;
        private PictureBox pictureBox1;
        private Label X;
        private Panel panel1;
    }
}