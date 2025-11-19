using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace LibrarySystem
{
    public partial class LibrarySystem : Form
    {
        public LibrarySystem()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Load += LibrarySystem_Load;

        }


        private void ApplyRoundedCorners(int radius)
    {
        GraphicsPath path = new GraphicsPath();
        int diameter = radius * 2;

        path.StartFigure();

        path.AddArc(0, 0, diameter, diameter, 180, 90);
        path.AddArc(this.Width - diameter, 0, diameter, diameter, 270, 90);
        path.AddArc(this.Width - diameter, this.Height - diameter, diameter, diameter, 0, 90);
        path.AddArc(0, this.Height - diameter, diameter, diameter, 90, 90);

        path.CloseFigure();
        this.Region = new Region(path);
    }
    private void LoginUser_Click(object sender, EventArgs e)
        {
            StudentLogin Stud_login = new StudentLogin();
            Stud_login.Location = this.Location;
            Stud_login.Show();
            this.Hide();
        }

        private void AdminLogin_Click(object sender, EventArgs e)
        {
            AdminLogin Admin_login = new AdminLogin();
            Admin_login.Location = this.Location;
            Admin_login.Show();
            this.Hide();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void LibrarySystem_Load(object sender, EventArgs e)
        {
            ApplyRoundedCorners(20);
        }

        protected override void OnMouseDown(MouseEventArgs e)
        {
            base.OnMouseDown(e);
            if (e.Button == MouseButtons.Left)
            {
                Capture = false;
                Message m = Message.Create(Handle, 0xA1, new IntPtr(2), IntPtr.Zero);
                WndProc(ref m);
            }
        }
    }
}

