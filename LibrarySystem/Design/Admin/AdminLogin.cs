using Microsoft.VisualBasic.Logging;
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
    public partial class AdminLogin : Form
    {
        public AdminLogin()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void X_Click(object sender, EventArgs e)
        {
            LibrarySystem Log = new LibrarySystem();
            Log.Location = this.Location;
            Log.Show();
            this.Close();
        }
        private void AdLogin_btn_Click(object sender, EventArgs e)
        {
            string connectionString = "server=localhost;user id=root;password=;database=login;";
            string adminUser = AdminLogIn_tbox.Text.Trim().ToLower();
            string adminPass = adminPass_tbox.Text.Trim();

            if (adminUser == "" || adminPass == "")
            {
                MessageBox.Show("Please enter both username and password.");
                return;
            }

            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();

                    string query = "SELECT * FROM admin WHERE LOWER(userAdmin) = @userAdmin AND password = @adminPass";
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@userAdmin", adminUser);
                        cmd.Parameters.AddWithValue("@adminPass", adminPass);

                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {
                                MessageBox.Show("Admin Login Successful!");
                                AdminDashboard admin = new AdminDashboard();
                                admin.Show();
                                this.Hide();
                            }
                            else
                            {
                                MessageBox.Show("Invalid admin login!");
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        
    }
}
