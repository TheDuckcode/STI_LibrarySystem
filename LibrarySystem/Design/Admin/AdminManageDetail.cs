using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibrarySystem
{
    public partial class AdminManageDetail : Form
    {
        string bookTitle, bookCategory, author, aisle, coverImage;

        public AdminManageDetail(string title, string category, string authorName, string aisleLoc, string imgPath)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterParent;

            bookTitle = title;
            bookCategory = category;
            this.author = authorName;
            aisle = aisleLoc;
            coverImage = imgPath;
        }

        private void AdminManageDetail_Load(object sender, EventArgs e)
        {
            textBox1.Text = bookTitle;
            textBox3.Text = bookCategory;
            textBox4.Text = author;
            textBox5.Text = aisle;

            if (!string.IsNullOrEmpty(coverImage) && File.Exists(coverImage))
            {
                details_picBox.Image = Image.FromFile(coverImage);
            }
        }

        private void x_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
