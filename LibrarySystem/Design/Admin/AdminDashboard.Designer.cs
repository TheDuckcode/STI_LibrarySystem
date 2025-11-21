namespace LibrarySystem
{
    partial class AdminDashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminDashboard));
            panel2 = new Panel();
            logout_btn = new Button();
            manage_btn = new Button();
            pictureBox1 = new PictureBox();
            bookLog_btn = new Button();
            location_btn = new Button();
            book_btn = new Button();
            category_btn = new Button();
            panelContent = new Panel();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.LemonChiffon;
            panel2.Controls.Add(logout_btn);
            panel2.Controls.Add(manage_btn);
            panel2.Controls.Add(pictureBox1);
            panel2.Controls.Add(bookLog_btn);
            panel2.Controls.Add(location_btn);
            panel2.Controls.Add(book_btn);
            panel2.Controls.Add(category_btn);
            panel2.Location = new Point(0, 0);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(190, 770);
            panel2.TabIndex = 35;
            // 
            // logout_btn
            // 
            logout_btn.BackColor = Color.PaleGoldenrod;
            logout_btn.FlatAppearance.BorderSize = 0;
            logout_btn.FlatAppearance.MouseDownBackColor = SystemColors.GradientActiveCaption;
            logout_btn.FlatAppearance.MouseOverBackColor = Color.LightYellow;
            logout_btn.FlatStyle = FlatStyle.Flat;
            logout_btn.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            logout_btn.ForeColor = SystemColors.Highlight;
            logout_btn.Location = new Point(1, 725);
            logout_btn.Margin = new Padding(3, 4, 3, 4);
            logout_btn.Name = "logout_btn";
            logout_btn.Size = new Size(189, 44);
            logout_btn.TabIndex = 32;
            logout_btn.Text = "LOGOUT";
            logout_btn.UseVisualStyleBackColor = false;
            logout_btn.Click += logout_btn_Click_1;
            // 
            // manage_btn
            // 
            manage_btn.BackColor = Color.PaleGoldenrod;
            manage_btn.FlatAppearance.BorderSize = 0;
            manage_btn.FlatAppearance.MouseDownBackColor = SystemColors.GradientActiveCaption;
            manage_btn.FlatAppearance.MouseOverBackColor = Color.LightYellow;
            manage_btn.FlatStyle = FlatStyle.Flat;
            manage_btn.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            manage_btn.ForeColor = SystemColors.Highlight;
            manage_btn.Location = new Point(1, 306);
            manage_btn.Margin = new Padding(3, 4, 3, 4);
            manage_btn.Name = "manage_btn";
            manage_btn.Size = new Size(189, 44);
            manage_btn.TabIndex = 31;
            manage_btn.Text = "MANAGE";
            manage_btn.UseVisualStyleBackColor = false;
            manage_btn.Click += manage_btn_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(47, 20);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(90, 43);
            pictureBox1.TabIndex = 31;
            pictureBox1.TabStop = false;
            // 
            // bookLog_btn
            // 
            bookLog_btn.BackColor = Color.PaleGoldenrod;
            bookLog_btn.FlatAppearance.BorderSize = 0;
            bookLog_btn.FlatAppearance.MouseDownBackColor = SystemColors.GradientActiveCaption;
            bookLog_btn.FlatAppearance.MouseOverBackColor = Color.LightYellow;
            bookLog_btn.FlatStyle = FlatStyle.Flat;
            bookLog_btn.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            bookLog_btn.ForeColor = SystemColors.Highlight;
            bookLog_btn.Location = new Point(1, 256);
            bookLog_btn.Margin = new Padding(3, 4, 3, 4);
            bookLog_btn.Name = "bookLog_btn";
            bookLog_btn.Size = new Size(189, 46);
            bookLog_btn.TabIndex = 30;
            bookLog_btn.Text = "BOOK LOG";
            bookLog_btn.UseVisualStyleBackColor = false;
            bookLog_btn.Click += bookLog_btn_Click;
            // 
            // location_btn
            // 
            location_btn.BackColor = Color.PaleGoldenrod;
            location_btn.FlatAppearance.BorderSize = 0;
            location_btn.FlatAppearance.MouseDownBackColor = SystemColors.GradientActiveCaption;
            location_btn.FlatAppearance.MouseOverBackColor = Color.LightYellow;
            location_btn.FlatStyle = FlatStyle.Flat;
            location_btn.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            location_btn.ForeColor = SystemColors.Highlight;
            location_btn.Location = new Point(1, 206);
            location_btn.Margin = new Padding(3, 4, 3, 4);
            location_btn.Name = "location_btn";
            location_btn.Size = new Size(189, 46);
            location_btn.TabIndex = 30;
            location_btn.Text = "AISLE/LOCATION";
            location_btn.UseVisualStyleBackColor = false;
            location_btn.Click += location_btn_Click;
            // 
            // book_btn
            // 
            book_btn.BackColor = Color.PaleGoldenrod;
            book_btn.FlatAppearance.BorderSize = 0;
            book_btn.FlatAppearance.MouseDownBackColor = SystemColors.GradientActiveCaption;
            book_btn.FlatAppearance.MouseOverBackColor = Color.LightYellow;
            book_btn.FlatStyle = FlatStyle.Flat;
            book_btn.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            book_btn.ForeColor = SystemColors.Highlight;
            book_btn.Location = new Point(1, 94);
            book_btn.Margin = new Padding(3, 4, 3, 4);
            book_btn.Name = "book_btn";
            book_btn.Size = new Size(189, 52);
            book_btn.TabIndex = 30;
            book_btn.Text = "BOOK";
            book_btn.UseVisualStyleBackColor = false;
            book_btn.Click += book_btn_Click;
            // 
            // category_btn
            // 
            category_btn.BackColor = Color.PaleGoldenrod;
            category_btn.FlatAppearance.BorderSize = 0;
            category_btn.FlatAppearance.MouseDownBackColor = SystemColors.GradientActiveCaption;
            category_btn.FlatAppearance.MouseOverBackColor = Color.LightYellow;
            category_btn.FlatStyle = FlatStyle.Flat;
            category_btn.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            category_btn.ForeColor = SystemColors.Highlight;
            category_btn.Location = new Point(1, 150);
            category_btn.Margin = new Padding(3, 4, 3, 4);
            category_btn.Name = "category_btn";
            category_btn.Size = new Size(189, 52);
            category_btn.TabIndex = 30;
            category_btn.Text = "CATEGORY";
            category_btn.UseVisualStyleBackColor = false;
            category_btn.Click += category_btn_Click;
            // 
            // panelContent
            // 
            panelContent.BackColor = SystemColors.GradientActiveCaption;
            panelContent.Location = new Point(190, 0);
            panelContent.Margin = new Padding(3, 4, 3, 4);
            panelContent.Name = "panelContent";
            panelContent.Size = new Size(838, 768);
            panelContent.TabIndex = 34;
            // 
            // AdminDashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1024, 768);
            Controls.Add(panel2);
            Controls.Add(panelContent);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "AdminDashboard";
            Text = "AdminDashboard";
            Load += AdminDashboard_Load;
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel2;
        private Button manage_btn;
        private Button bookLog_btn;
        private Button location_btn;
        private Button book_btn;
        private Button category_btn;
        private Panel panelContent;
        private PictureBox pictureBox1;
        private Button logout_btn;
    }
}