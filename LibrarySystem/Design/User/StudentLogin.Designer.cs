namespace LibrarySystem
{
    partial class StudentLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StudentLogin));
            label4 = new Label();
            userLogIn_tbox = new TextBox();
            label5 = new Label();
            userPass_tbox = new TextBox();
            userLog_btn = new Button();
            label3 = new Label();
            panel2 = new Panel();
            label1 = new Label();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            X = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Location = new Point(126, 279);
            label4.Name = "label4";
            label4.Size = new Size(46, 20);
            label4.TabIndex = 4;
            label4.Text = "Email";
            // 
            // userLogIn_tbox
            // 
            userLogIn_tbox.BackColor = Color.Gainsboro;
            userLogIn_tbox.Location = new Point(126, 303);
            userLogIn_tbox.Margin = new Padding(3, 4, 3, 4);
            userLogIn_tbox.Multiline = true;
            userLogIn_tbox.Name = "userLogIn_tbox";
            userLogIn_tbox.Size = new Size(348, 27);
            userLogIn_tbox.TabIndex = 5;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Location = new Point(126, 362);
            label5.Name = "label5";
            label5.Size = new Size(70, 20);
            label5.TabIndex = 6;
            label5.Text = "Password";
            // 
            // userPass_tbox
            // 
            userPass_tbox.BackColor = Color.Gainsboro;
            userPass_tbox.Location = new Point(126, 386);
            userPass_tbox.Margin = new Padding(3, 4, 3, 4);
            userPass_tbox.Name = "userPass_tbox";
            userPass_tbox.PasswordChar = 'x';
            userPass_tbox.Size = new Size(348, 27);
            userPass_tbox.TabIndex = 7;
            userPass_tbox.UseSystemPasswordChar = true;
            // 
            // userLog_btn
            // 
            userLog_btn.BackColor = SystemColors.Highlight;
            userLog_btn.FlatStyle = FlatStyle.Flat;
            userLog_btn.Font = new Font("Segoe UI Black", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            userLog_btn.ForeColor = Color.Yellow;
            userLog_btn.Location = new Point(200, 465);
            userLog_btn.Margin = new Padding(3, 4, 3, 4);
            userLog_btn.Name = "userLog_btn";
            userLog_btn.Size = new Size(162, 51);
            userLog_btn.TabIndex = 8;
            userLog_btn.Text = "LOGIN";
            userLog_btn.UseVisualStyleBackColor = false;
            userLog_btn.Click += userLog_btn_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.FlatStyle = FlatStyle.Flat;
            label3.Font = new Font("Segoe UI Black", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.HotTrack;
            label3.Location = new Point(164, 193);
            label3.Name = "label3";
            label3.Size = new Size(262, 41);
            label3.TabIndex = 9;
            label3.Text = "STUDENT LOGIN";
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ActiveCaption;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(95, 560);
            panel2.TabIndex = 23;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(125, 107);
            label1.Name = "label1";
            label1.Size = new Size(340, 32);
            label1.TabIndex = 26;
            label1.Text = "Library Management System";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.FlatStyle = FlatStyle.Flat;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ControlDarkDark;
            label2.Location = new Point(198, 140);
            label2.Name = "label2";
            label2.Size = new Size(184, 20);
            label2.TabIndex = 25;
            label2.Text = "STI College Ortigas-Cainta";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(253, 31);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(83, 55);
            pictureBox1.TabIndex = 24;
            pictureBox1.TabStop = false;
            // 
            // X
            // 
            X.AutoSize = true;
            X.BackColor = Color.Transparent;
            X.FlatStyle = FlatStyle.Flat;
            X.Font = new Font("Segoe UI Black", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            X.ForeColor = SystemColors.HotTrack;
            X.Location = new Point(511, 0);
            X.Name = "X";
            X.Size = new Size(39, 41);
            X.TabIndex = 27;
            X.Text = "X";
            X.Click += X_Click_1;
            // 
            // StudentLogin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(548, 557);
            Controls.Add(X);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(pictureBox1);
            Controls.Add(panel2);
            Controls.Add(label3);
            Controls.Add(userLog_btn);
            Controls.Add(userPass_tbox);
            Controls.Add(label5);
            Controls.Add(userLogIn_tbox);
            Controls.Add(label4);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "StudentLogin";
            Text = "StudentLogin";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label4;
        private TextBox userLogIn_tbox;
        private Label label5;
        private TextBox userPass_tbox;
        private Button userLog_btn;
        private Label label3;
        private Panel panel2;
        private Label label1;
        private Label label2;
        private PictureBox pictureBox1;
        private Label X;
    }
}