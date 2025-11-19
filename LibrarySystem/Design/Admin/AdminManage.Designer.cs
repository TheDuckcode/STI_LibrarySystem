namespace LibrarySystem
{
    partial class AdminManage
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
            panel1 = new Panel();
            dataGridView1 = new DataGridView();
            BookLog = new DataGridViewTextBoxColumn();
            BookTitle = new DataGridViewTextBoxColumn();
            Author = new DataGridViewTextBoxColumn();
            StudNo = new DataGridViewTextBoxColumn();
            Status = new DataGridViewTextBoxColumn();
            button4 = new Button();
            button11 = new Button();
            label2 = new Label();
            button10 = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.WhiteSmoke;
            panel1.Controls.Add(dataGridView1);
            panel1.Controls.Add(button4);
            panel1.Controls.Add(button11);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(button10);
            panel1.Location = new Point(63, 83);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(702, 467);
            panel1.TabIndex = 57;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.Highlight;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { BookLog, BookTitle, Author, StudNo, Status });
            dataGridView1.Location = new Point(18, 27);
            dataGridView1.Margin = new Padding(3, 4, 3, 4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(666, 325);
            dataGridView1.TabIndex = 68;
            // 
            // BookLog
            // 
            BookLog.HeaderText = "BOOK LOG ID";
            BookLog.MinimumWidth = 6;
            BookLog.Name = "BookLog";
            BookLog.Width = 125;
            // 
            // BookTitle
            // 
            BookTitle.HeaderText = "BOOK TITLE";
            BookTitle.MinimumWidth = 6;
            BookTitle.Name = "BookTitle";
            BookTitle.Width = 125;
            // 
            // Author
            // 
            Author.HeaderText = "AUTHOR";
            Author.MinimumWidth = 6;
            Author.Name = "Author";
            Author.Width = 125;
            // 
            // StudNo
            // 
            StudNo.HeaderText = "Book Type";
            StudNo.MinimumWidth = 6;
            StudNo.Name = "StudNo";
            StudNo.Width = 125;
            // 
            // Status
            // 
            Status.HeaderText = "STATUS";
            Status.MinimumWidth = 6;
            Status.Name = "Status";
            Status.Width = 125;
            // 
            // button4
            // 
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button4.ImageAlign = ContentAlignment.TopCenter;
            button4.Location = new Point(19, 391);
            button4.Margin = new Padding(3, 4, 3, 4);
            button4.Name = "button4";
            button4.Size = new Size(166, 60);
            button4.TabIndex = 67;
            button4.Text = "Book Detail";
            button4.UseVisualStyleBackColor = true;
            // 
            // button11
            // 
            button11.FlatStyle = FlatStyle.Flat;
            button11.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button11.ImageAlign = ContentAlignment.TopCenter;
            button11.Location = new Point(333, 391);
            button11.Margin = new Padding(3, 4, 3, 4);
            button11.Name = "button11";
            button11.Size = new Size(177, 60);
            button11.TabIndex = 61;
            button11.Text = "ARCHIVE BOOK";
            button11.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Microsoft Sans Serif", 15.7499981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ActiveCaptionText;
            label2.Location = new Point(19, 245);
            label2.Name = "label2";
            label2.Size = new Size(0, 31);
            label2.TabIndex = 60;
            // 
            // button10
            // 
            button10.FlatStyle = FlatStyle.Flat;
            button10.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button10.ImageAlign = ContentAlignment.TopCenter;
            button10.Location = new Point(517, 391);
            button10.Margin = new Padding(3, 4, 3, 4);
            button10.Name = "button10";
            button10.Size = new Size(166, 60);
            button10.TabIndex = 59;
            button10.Text = "ADD BOOK";
            button10.UseVisualStyleBackColor = true;
            // 
            // AdminManage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(837, 768);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "AdminManage";
            Text = "AdminManage";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel1;
        private Button button10;
        private Button button11;
        private Label label2;
        private Button button4;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn BookLog;
        private DataGridViewTextBoxColumn BookTitle;
        private DataGridViewTextBoxColumn Author;
        private DataGridViewTextBoxColumn StudNo;
        private DataGridViewTextBoxColumn Status;
    }
}