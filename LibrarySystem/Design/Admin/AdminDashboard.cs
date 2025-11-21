using LibrarySystem.Design.User;
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
    public partial class AdminDashboard : Form
    {
        public AdminDashboard()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void AdminDashboard_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void book_btn_Click(object sender, EventArgs e)
        {
            FormLoader.LoadFormInPanel(panelContent, new AdminBook());
        }


        private void logout_btn_Click_1(object sender, EventArgs e)
        {
            LibrarySystem.ActiveForm.Close();
            LibrarySystem Log = new LibrarySystem();
            Log.Show();
            this.Close();
        }

        private void category_btn_Click(object sender, EventArgs e)
        {
            FormLoader.LoadFormInPanel(panelContent, new AdminCategory());
        }

        
        private void location_btn_Click(object sender, EventArgs e)
        {
            FormLoader.LoadFormInPanel(panelContent, new AdminLoc());
        }

        private void bookLog_btn_Click(object sender, EventArgs e)
        {
            FormLoader.LoadFormInPanel(panelContent, new AdminBookLog());
        }

        private void manage_btn_Click(object sender, EventArgs e)
        {
            FormLoader.LoadFormInPanel(panelContent, new AdminManage());
        }
    }
}
