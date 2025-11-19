namespace LibrarySystem.Design.User
{
    partial class StudentHomepage
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
            stud_homePage_panel = new Panel();
            SuspendLayout();
            // 
            // stud_homePage_panel
            // 
            stud_homePage_panel.BackColor = SystemColors.Info;
            stud_homePage_panel.Location = new Point(0, 0);
            stud_homePage_panel.Name = "stud_homePage_panel";
            stud_homePage_panel.Size = new Size(837, 768);
            stud_homePage_panel.TabIndex = 27;
            // 
            // StudentHomepage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(837, 768);
            Controls.Add(stud_homePage_panel);
            FormBorderStyle = FormBorderStyle.None;
            Name = "StudentHomepage";
            ResumeLayout(false);
        }

        #endregion

        private Panel stud_homePage_panel;
    }
}