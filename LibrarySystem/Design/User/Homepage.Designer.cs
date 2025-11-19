namespace LibrarySystem
{
    partial class Homepage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Homepage));
            panel3 = new Panel();
            logout_btn = new Button();
            Home_btn = new Button();
            Profile_btn = new Button();
            Reserve_btn = new Button();
            pictureBox1 = new PictureBox();
            Borrow_btn = new Button();
            panelContent = new Panel();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.GradientInactiveCaption;
            panel3.Controls.Add(logout_btn);
            panel3.Controls.Add(Home_btn);
            panel3.Controls.Add(Profile_btn);
            panel3.Controls.Add(Reserve_btn);
            panel3.Controls.Add(pictureBox1);
            panel3.Controls.Add(Borrow_btn);
            panel3.Location = new Point(0, 0);
            panel3.Margin = new Padding(3, 4, 3, 4);
            panel3.Name = "panel3";
            panel3.Size = new Size(188, 768);
            panel3.TabIndex = 21;
            // 
            // logout_btn
            // 
            logout_btn.BackColor = SystemColors.GradientActiveCaption;
            logout_btn.FlatAppearance.BorderSize = 0;
            logout_btn.FlatAppearance.MouseDownBackColor = SystemColors.GradientInactiveCaption;
            logout_btn.FlatAppearance.MouseOverBackColor = SystemColors.Info;
            logout_btn.FlatStyle = FlatStyle.Flat;
            logout_btn.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            logout_btn.ForeColor = SystemColors.Highlight;
            logout_btn.Location = new Point(-1, 724);
            logout_btn.Margin = new Padding(3, 4, 3, 4);
            logout_btn.Name = "logout_btn";
            logout_btn.Size = new Size(189, 44);
            logout_btn.TabIndex = 33;
            logout_btn.Text = "LOGOUT";
            logout_btn.UseVisualStyleBackColor = false;
            logout_btn.Click += logout_btn_Click;
            // 
            // Home_btn
            // 
            Home_btn.BackColor = SystemColors.GradientActiveCaption;
            Home_btn.BackgroundImageLayout = ImageLayout.None;
            Home_btn.FlatAppearance.BorderSize = 0;
            Home_btn.FlatStyle = FlatStyle.Flat;
            Home_btn.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            Home_btn.ForeColor = SystemColors.HotTrack;
            Home_btn.Location = new Point(0, 136);
            Home_btn.Margin = new Padding(3, 4, 3, 4);
            Home_btn.Name = "Home_btn";
            Home_btn.Size = new Size(188, 44);
            Home_btn.TabIndex = 23;
            Home_btn.Text = "Home";
            Home_btn.UseVisualStyleBackColor = false;
            Home_btn.Click += Home_btn_Click;
            // 
            // Profile_btn
            // 
            Profile_btn.BackColor = SystemColors.GradientActiveCaption;
            Profile_btn.BackgroundImageLayout = ImageLayout.None;
            Profile_btn.FlatAppearance.BorderSize = 0;
            Profile_btn.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 255, 192);
            Profile_btn.FlatAppearance.MouseOverBackColor = SystemColors.ActiveCaption;
            Profile_btn.FlatStyle = FlatStyle.Flat;
            Profile_btn.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            Profile_btn.ForeColor = SystemColors.HotTrack;
            Profile_btn.Location = new Point(0, 292);
            Profile_btn.Margin = new Padding(3, 4, 3, 4);
            Profile_btn.Name = "Profile_btn";
            Profile_btn.Size = new Size(188, 44);
            Profile_btn.TabIndex = 2;
            Profile_btn.Text = "Profile";
            Profile_btn.UseVisualStyleBackColor = false;
            Profile_btn.Click += Stud_Prof_Click;
            // 
            // Reserve_btn
            // 
            Reserve_btn.BackColor = SystemColors.GradientActiveCaption;
            Reserve_btn.BackgroundImageLayout = ImageLayout.None;
            Reserve_btn.FlatAppearance.BorderSize = 0;
            Reserve_btn.FlatAppearance.MouseOverBackColor = SystemColors.GradientInactiveCaption;
            Reserve_btn.FlatStyle = FlatStyle.Flat;
            Reserve_btn.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            Reserve_btn.ForeColor = SystemColors.HotTrack;
            Reserve_btn.ImageAlign = ContentAlignment.TopCenter;
            Reserve_btn.Location = new Point(0, 240);
            Reserve_btn.Margin = new Padding(3, 4, 3, 4);
            Reserve_btn.Name = "Reserve_btn";
            Reserve_btn.Size = new Size(188, 44);
            Reserve_btn.TabIndex = 1;
            Reserve_btn.Text = "Reserve";
            Reserve_btn.UseVisualStyleBackColor = false;
            Reserve_btn.Click += Reserve_btn_Click_1;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(46, 22);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(99, 56);
            pictureBox1.TabIndex = 22;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // Borrow_btn
            // 
            Borrow_btn.BackColor = SystemColors.GradientActiveCaption;
            Borrow_btn.BackgroundImageLayout = ImageLayout.None;
            Borrow_btn.FlatAppearance.BorderSize = 0;
            Borrow_btn.FlatStyle = FlatStyle.Flat;
            Borrow_btn.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            Borrow_btn.ForeColor = SystemColors.HotTrack;
            Borrow_btn.Location = new Point(0, 188);
            Borrow_btn.Margin = new Padding(3, 4, 3, 4);
            Borrow_btn.Name = "Borrow_btn";
            Borrow_btn.Size = new Size(188, 44);
            Borrow_btn.TabIndex = 0;
            Borrow_btn.Text = "Borrow";
            Borrow_btn.UseVisualStyleBackColor = false;
            Borrow_btn.Click += Borrow_btn_Click;
            // 
            // panelContent
            // 
            panelContent.Location = new Point(187, 0);
            panelContent.Name = "panelContent";
            panelContent.Size = new Size(837, 768);
            panelContent.TabIndex = 26;
            // 
            // Homepage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 255, 192);
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1024, 768);
            Controls.Add(panelContent);
            Controls.Add(panel3);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "Homepage";
            Text = "Homepage";
            Load += Homepage_Load;
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel3;
        private Button Borrow_btn;
        private Button Reserve_btn;
        private Button Profile_btn;
        private PictureBox pictureBox1;
        private Panel panelContent;
        private Button Home_btn;
        private Button logout_btn;
    }
}