using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.IO;

namespace Books_Recommendation
{
    public class userDb 
    {

        private static string path = System.IO.Path.GetFullPath(Environment.CurrentDirectory);
        private static string dataBaseName = "Database.mdf";
        private static string ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + path + @"\" + dataBaseName + ";Integrated Security=True";
        public SqlConnection con = new SqlConnection(ConnectionString); public  bool add(string username, string email, string password)
        {
            SqlCommand command = new SqlCommand("INSERT INTO [user] VALUES(@username,@password, @email)", con);
            command.CommandType = CommandType.Text;
            command.Parameters.AddWithValue("@username", username);
            command.Parameters.AddWithValue("@password", password);
            command.Parameters.AddWithValue("@email", email);
            con.Open();
            command.ExecuteNonQuery();
            con.Close();
            return true;
        }

        public  void delete()
        {
            throw new System.NotImplementedException();
        }

        public bool get(string username, string password)
        {
            if (username == "admin")
            {
                SqlCommand command = new SqlCommand("SELECT * FROM [admin] WHERE password = @password", con);
                command.Parameters.AddWithValue("@password", password);
                con.Open();
                SqlDataReader admin = command.ExecuteReader();
                if (admin.Read())
                {
                    return true;
                }
                else
                {
                    return false;
                }
                con.Close();
            }
            else
            {
                SqlCommand command = new SqlCommand("SELECT * FROM [user] WHERE username = @username AND password = @password", con);
                command.Parameters.AddWithValue("@username", username);
                command.Parameters.AddWithValue("@password", password);
                con.Open();
                SqlDataReader user = command.ExecuteReader();
                if (user.Read())
                {
                    return true;
                }
                else
                {
                    return false;
                }
                con.Close();
            }
        }

        public  void update()
        {
            throw new System.NotImplementedException();
        }
    }
}