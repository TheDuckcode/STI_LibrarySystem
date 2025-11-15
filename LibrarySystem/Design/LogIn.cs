namespace LibrarySystem
{
    public partial class LibrarySystem : Form
    {
        public LibrarySystem()
        {
            InitializeComponent();
        }

        private void LoginUser_Click(object sender, EventArgs e)
        {
            StudentLogin Stud_login = new StudentLogin();
            Stud_login.ShowDialog();
            this.Hide(); ;
        }

        private void AdminLogin_Click(object sender, EventArgs e)
        {
            AdminLogin Admin_login = new AdminLogin();
            Admin_login.ShowDialog();
            this.Hide();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

