namespace LibrarySystem
{
    partial class LibrarySystem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LibrarySystem));
            label1 = new Label();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            AdminLogin = new Button();
            LoginUser = new Button();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.FlatStyle = FlatStyle.Flat;
            label1.Font = new Font("Microsoft Sans Serif", 26.2499962F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(406, 68);
            label1.Name = "label1";
            label1.Size = new Size(332, 52);
            label1.TabIndex = 0;
            label1.Text = "WELCOME TO";
            label1.UseWaitCursor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Microsoft Sans Serif", 26.2499962F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(332, 146);
            label2.Name = "label2";
            label2.Size = new Size(499, 52);
            label2.TabIndex = 4;
            label2.Text = "STI LIBRARY SYSTEM";
            label2.UseWaitCursor = true;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(269, 256);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(217, 140);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            pictureBox1.UseWaitCursor = true;
            // 
            // AdminLogin
            // 
            AdminLogin.BackColor = SystemColors.Highlight;
            AdminLogin.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            AdminLogin.ForeColor = Color.Yellow;
            AdminLogin.Location = new Point(542, 319);
            AdminLogin.Margin = new Padding(3, 4, 3, 4);
            AdminLogin.Name = "AdminLogin";
            AdminLogin.Size = new Size(309, 55);
            AdminLogin.TabIndex = 6;
            AdminLogin.Text = "ADMIN LOGIN";
            AdminLogin.UseVisualStyleBackColor = false;
            AdminLogin.UseWaitCursor = true;
            AdminLogin.Click += AdminLogin_Click;
            // 
            // LoginUser
            // 
            LoginUser.BackColor = Color.Yellow;
            LoginUser.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LoginUser.ForeColor = SystemColors.Highlight;
            LoginUser.Location = new Point(542, 256);
            LoginUser.Margin = new Padding(3, 4, 3, 4);
            LoginUser.Name = "LoginUser";
            LoginUser.Size = new Size(309, 55);
            LoginUser.TabIndex = 7;
            LoginUser.Text = "LOGIN with Microsoft Office";
            LoginUser.UseVisualStyleBackColor = false;
            LoginUser.UseWaitCursor = true;
            LoginUser.Click += LoginUser_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ControlText;
            label3.Location = new Point(887, 2);
            label3.Name = "label3";
            label3.RightToLeft = RightToLeft.No;
            label3.Size = new Size(25, 28);
            label3.TabIndex = 8;
            label3.Text = "X";
            label3.UseWaitCursor = true;
            label3.Click += label3_Click;
            // 
            // LibrarySystem
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(914, 600);
            Controls.Add(label3);
            Controls.Add(LoginUser);
            Controls.Add(AdminLogin);
            Controls.Add(pictureBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "LibrarySystem";
            UseWaitCursor = true;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private PictureBox pictureBox1;
        private Button AdminLogin;
        private Button LoginUser;
        private Label label3;
    }
}
