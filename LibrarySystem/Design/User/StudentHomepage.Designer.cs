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
            label1 = new Label();
            label2 = new Label();
            stud_homePage_panel.SuspendLayout();
            SuspendLayout();
            // 
            // stud_homePage_panel
            // 
            stud_homePage_panel.BackColor = SystemColors.Info;
            stud_homePage_panel.Controls.Add(label2);
            stud_homePage_panel.Controls.Add(label1);
            stud_homePage_panel.Location = new Point(0, 0);
            stud_homePage_panel.Name = "stud_homePage_panel";
            stud_homePage_panel.Size = new Size(837, 768);
            stud_homePage_panel.TabIndex = 27;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.Highlight;
            label1.Font = new Font("Segoe UI Black", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Yellow;
            label1.Location = new Point(12, 69);
            label1.Name = "label1";
            label1.Size = new Size(243, 41);
            label1.TabIndex = 30;
            label1.Text = "NEWLY ADDED";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.Highlight;
            label2.Font = new Font("Segoe UI Black", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Yellow;
            label2.Location = new Point(12, 333);
            label2.Name = "label2";
            label2.Size = new Size(339, 41);
            label2.TabIndex = 31;
            label2.Text = "RECENTLY RETURNED";
            // 
            // StudentHomepage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(837, 768);
            Controls.Add(stud_homePage_panel);
            FormBorderStyle = FormBorderStyle.None;
            Name = "StudentHomepage";
            stud_homePage_panel.ResumeLayout(false);
            stud_homePage_panel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel stud_homePage_panel;
        private Label label2;
        private Label label1;
    }
}