namespace LibrarySystem
{
    partial class AdminBookLog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminBookLog));
            panel1 = new Panel();
            dataGridView1 = new DataGridView();
            BookLog = new DataGridViewTextBoxColumn();
            BookTitle = new DataGridViewTextBoxColumn();
            Author = new DataGridViewTextBoxColumn();
            StudNo = new DataGridViewTextBoxColumn();
            TransacType = new DataGridViewTextBoxColumn();
            DateTime = new DataGridViewTextBoxColumn();
            Status = new DataGridViewTextBoxColumn();
            label1 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.WhiteSmoke;
            panel1.Controls.Add(dataGridView1);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(50, 83);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(702, 467);
            panel1.TabIndex = 60;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.Highlight;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { BookLog, BookTitle, Author, StudNo, TransacType, DateTime, Status });
            dataGridView1.Location = new Point(12, 47);
            dataGridView1.Margin = new Padding(3, 4, 3, 4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(666, 413);
            dataGridView1.TabIndex = 59;
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
            StudNo.HeaderText = "STUDENT NO.";
            StudNo.MinimumWidth = 6;
            StudNo.Name = "StudNo";
            StudNo.Width = 125;
            // 
            // TransacType
            // 
            TransacType.HeaderText = "TRANSACTION TYPE";
            TransacType.MinimumWidth = 6;
            TransacType.Name = "TransacType";
            TransacType.Width = 125;
            // 
            // DateTime
            // 
            DateTime.HeaderText = "DATE/TIME";
            DateTime.MinimumWidth = 6;
            DateTime.Name = "DateTime";
            DateTime.Width = 125;
            // 
            // Status
            // 
            Status.HeaderText = "STATUS";
            Status.MinimumWidth = 6;
            Status.Name = "Status";
            Status.Width = 125;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Microsoft Sans Serif", 17.9999981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(3, 7);
            label1.Name = "label1";
            label1.Size = new Size(177, 36);
            label1.TabIndex = 58;
            label1.Text = "BOOK LOG";
            // 
            // AdminBookLog
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(837, 768);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "AdminBookLog";
            Text = "AdminBookLog";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel1;
        private Label label1;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn BookLog;
        private DataGridViewTextBoxColumn BookTitle;
        private DataGridViewTextBoxColumn Author;
        private DataGridViewTextBoxColumn StudNo;
        private DataGridViewTextBoxColumn TransacType;
        private DataGridViewTextBoxColumn DateTime;
        private DataGridViewTextBoxColumn Status;
    }
}