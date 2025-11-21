using MySql.Data.MySqlClient;
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
    public partial class AdminManage : Form
    {
        public AdminManage()
        {
            InitializeComponent();
        }

        private void add_btn_Click(object sender, EventArgs e)
        {

        }

        private void archive_btn_Click(object sender, EventArgs e)
        {

        }

        private void refresh_btn_Click(object sender, EventArgs e)
        {
            LoadBooksData();
        }

        private void details_btn_Click(object sender, EventArgs e)
        {

        }

        public void LoadBooksData()
        {
            string connectionString = "server=localhost;user id=root;password=;database=login;";
            using (MySqlConnection con = new MySqlConnection(connectionString))
            {
                try
                {
                    con.Open();
                    string query = "SELECT * FROM books";
                    MySqlDataAdapter da = new MySqlDataAdapter(query, con);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    manage_dataGrid.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}
