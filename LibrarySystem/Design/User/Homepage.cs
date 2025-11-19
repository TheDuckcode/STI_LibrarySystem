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
    public partial class Homepage : Form
    {
        public Homepage()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }


        private void Homepage_Load(object sender, EventArgs e)
        {
            FormLoader.LoadFormInPanel(panelContent, new StudentHomepage());
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Stud_Prof_Click(object sender, EventArgs e)
        {
            FormLoader.LoadFormInPanel(panelContent, new StudentProfile());
        }

        private void Reserve_btn_Click_1(object sender, EventArgs e)
        {
            FormLoader.LoadFormInPanel(panelContent, new Reservation());
        }

        private void Borrow_btn_Click(object sender, EventArgs e)
        {
            FormLoader.LoadFormInPanel(panelContent, new Borrow());
        }

        private void Home_btn_Click(object sender, EventArgs e)
        {
            FormLoader.LoadFormInPanel(panelContent, new StudentHomepage());
        }

        private void logout_btn_Click(object sender, EventArgs e)
        {
            LibrarySystem.ActiveForm.Close();
            LibrarySystem Log = new LibrarySystem();
            Log.Show();
            this.Close();
        }
    }
}
