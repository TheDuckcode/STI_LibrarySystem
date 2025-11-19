using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibrarySystem
{
    internal class Dump_Coding
    {
        

private int GetTableCount(string tableName)
    {
        int count = 0;

        string connectionString = "server=localhost;database=login;uid=root;pwd=;";

        using (MySqlConnection conn = new MySqlConnection(connectionString))
        {
            conn.Open();

            
            string query = $"SELECT COUNT * FROM {tableName}";

            using (MySqlCommand cmd = new MySqlCommand(query, conn))
            {
                count = Convert.ToInt32(cmd.ExecuteScalar());
            }
        }

        return count;
    }



private void RoundPanel(Panel panel, int radius)
    {
        GraphicsPath path = new GraphicsPath();
        path.AddArc(0, 0, radius, radius, 180, 90);
        path.AddArc(panel.Width - radius, 0, radius, radius, 270, 90);
        path.AddArc(panel.Width - radius, panel.Height - radius, radius, radius, 0, 90);
        path.AddArc(0, panel.Height - radius, radius, radius, 90, 90);
        path.CloseFigure();

        panel.Region = new Region(path);
    }
}
}
