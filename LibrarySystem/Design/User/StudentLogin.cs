using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibrarySystem
{

    public partial class StudentLogin : Form
    {
        public StudentLogin()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }
        private void X_Click(object sender, EventArgs e)
        {
            LibrarySystem.ActiveForm.Close();
            LibrarySystem Log = new LibrarySystem();
            Log.Show();
            this.Close();
        }

        private void userLog_btn_Click(object sender, EventArgs e)
        {
            string connectionString = "server=localhost;user id=root;password=;database=login;";
            string usernameInput = userLogIn_tbox.Text.Trim().ToLower();
            string passwordInput = userPass_tbox.Text.Trim();

            if (string.IsNullOrEmpty(usernameInput) || string.IsNullOrEmpty(passwordInput))
            {
                MessageBox.Show("Please enter both username and password.");
                return;
            }

            try
            {

                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();

                    string query = @"SELECT * FROM students 
                             WHERE (student_id = @username OR email = @username) 
                             AND password = @password";

                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@username", usernameInput);
                    cmd.Parameters.AddWithValue("@password", passwordInput);

                    MySqlDataReader reader = cmd.ExecuteReader();

                    if (reader.HasRows)
                    {
                        MessageBox.Show("Login Success!");
                        Homepage main = new Homepage();
                        main.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Invalid username or password!");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }


        private void X_Click_1(object sender, EventArgs e)
        {
            LibrarySystem Log = new LibrarySystem();
            Log.Location = this.Location;
            Log.Show();
            this.Close();
        }

    }
}

