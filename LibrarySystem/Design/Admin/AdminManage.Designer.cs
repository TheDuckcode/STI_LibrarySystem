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
            refresh_btn = new Button();
            details_btn = new Button();
            manage_dataGrid = new DataGridView();
            archive_btn = new Button();
            label2 = new Label();
            add_btn = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)manage_dataGrid).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Info;
            panel1.Controls.Add(refresh_btn);
            panel1.Controls.Add(details_btn);
            panel1.Controls.Add(manage_dataGrid);
            panel1.Controls.Add(archive_btn);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(add_btn);
            panel1.Location = new Point(12, 13);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(813, 543);
            panel1.TabIndex = 57;
            // 
            // refresh_btn
            // 
            refresh_btn.AutoSize = true;
            refresh_btn.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            refresh_btn.FlatStyle = FlatStyle.Flat;
            refresh_btn.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            refresh_btn.ImageAlign = ContentAlignment.TopCenter;
            refresh_btn.Location = new Point(168, 485);
            refresh_btn.Margin = new Padding(3, 4, 3, 4);
            refresh_btn.Name = "refresh_btn";
            refresh_btn.Size = new Size(94, 35);
            refresh_btn.TabIndex = 69;
            refresh_btn.Text = "REFRESH";
            refresh_btn.UseVisualStyleBackColor = true;
            refresh_btn.Click += refresh_btn_Click;
            // 
            // details_btn
            // 
            details_btn.AutoSize = true;
            details_btn.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            details_btn.FlatStyle = FlatStyle.Flat;
            details_btn.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            details_btn.ImageAlign = ContentAlignment.TopCenter;
            details_btn.Location = new Point(20, 485);
            details_btn.Margin = new Padding(3, 4, 3, 4);
            details_btn.Name = "details_btn";
            details_btn.Size = new Size(142, 35);
            details_btn.TabIndex = 67;
            details_btn.Text = "BOOK DETAILS";
            details_btn.UseVisualStyleBackColor = true;
            details_btn.Click += details_btn_Click;
            // 
            // manage_dataGrid
            // 
            manage_dataGrid.BackgroundColor = SystemColors.Highlight;
            manage_dataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            manage_dataGrid.Location = new Point(18, 27);
            manage_dataGrid.Margin = new Padding(3, 4, 3, 4);
            manage_dataGrid.Name = "manage_dataGrid";
            manage_dataGrid.RowHeadersWidth = 51;
            manage_dataGrid.Size = new Size(775, 428);
            manage_dataGrid.TabIndex = 68;
            // 
            // archive_btn
            // 
            archive_btn.AutoSize = true;
            archive_btn.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            archive_btn.FlatStyle = FlatStyle.Flat;
            archive_btn.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            archive_btn.ImageAlign = ContentAlignment.TopCenter;
            archive_btn.Location = new Point(528, 485);
            archive_btn.Margin = new Padding(3, 4, 3, 4);
            archive_btn.Name = "archive_btn";
            archive_btn.Size = new Size(147, 35);
            archive_btn.TabIndex = 61;
            archive_btn.Text = "ARCHIVE BOOK";
            archive_btn.UseVisualStyleBackColor = true;
            archive_btn.Click += archive_btn_Click;
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
            // add_btn
            // 
            add_btn.AutoSize = true;
            add_btn.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            add_btn.FlatStyle = FlatStyle.Flat;
            add_btn.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            add_btn.ImageAlign = ContentAlignment.TopCenter;
            add_btn.Location = new Point(681, 485);
            add_btn.Margin = new Padding(3, 4, 3, 4);
            add_btn.Name = "add_btn";
            add_btn.Size = new Size(113, 35);
            add_btn.TabIndex = 59;
            add_btn.Text = "ADD BOOK";
            add_btn.UseVisualStyleBackColor = true;
            add_btn.Click += add_btn_Click;
            // 
            // AdminManage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(837, 768);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "AdminManage";
            Text = "AdminManage";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)manage_dataGrid).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel1;
        private Button details_btn;
        private Button archive_btn;
        private Label label2;
        private Button add_btn;
        private DataGridView manage_dataGrid;
        private Button refresh_btn;
    }
}