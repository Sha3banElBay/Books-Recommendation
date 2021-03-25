using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.IO;
namespace Books_Recommendation
{
    public class bookDb
    {
        // Setting up the Connection String
        private static string path = System.IO.Path.GetFullPath(Environment.CurrentDirectory);
        private static string dataBaseName = "Database.mdf";
        private static string ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + path + @"\" + dataBaseName + ";Integrated Security=True";
        public SqlConnection con = new SqlConnection(ConnectionString);
        public bool add(string name, string author, string category, byte[] picture)
        {
            SqlCommand command = new SqlCommand("INSERT INTO [book] VALUES(@author,@category, @name, @picture)", con);
            command.CommandType = CommandType.Text;
            command.Parameters.AddWithValue("@author", author);
            command.Parameters.AddWithValue("@category", category);
            command.Parameters.AddWithValue("@name", name);
            command.Parameters.AddWithValue("@picture", picture);
            con.Open();
            command.ExecuteNonQuery();
            con.Close();
            return true;
        }

        public  void delete()
        {
            throw new System.NotImplementedException();
        }

        public book get(string category)
        {
            book book = new book();
            book.Name = "";
            book.Author = "";
            book.Picture = null;
            book.Category = "";
            int index = 0;
            if (category == "All")
            {
               
                SqlCommand command = new SqlCommand("SELECT COUNT(Id) FROM [book]", con);

                con.Open();
                int count = Convert.ToInt32(command.ExecuteScalar());


                Random random = new Random();
                index = random.Next(1,count + 1);
                SqlCommand command2 = new SqlCommand("SELECT author, category, name, picture FROM [book] WHERE Id = @Id", con);
                command2.Parameters.AddWithValue("@Id", index);
                SqlDataReader reader = command2.ExecuteReader();
                if (reader.Read())
                {
                    book.Author = reader["author"].ToString();
                    book.Category = reader["category"].ToString();
                    book.Name = reader["name"].ToString();
                    book.Picture = (byte[])(reader["picture"]);
                }




            }
            else
            {
                SqlCommand command = new SqlCommand("SELECT COUNT(Id) FROM [book] WHERE category = @category", con);
                command.Parameters.AddWithValue("@category", category);
                con.Open();
                int count = Convert.ToInt32(command.ExecuteScalar());
                con.Close();
                Random random = new Random();
                con.Open();
                SqlCommand command2 = new SqlCommand("SELECT Id FROM [book] WHERE category = @category", con);
                command2.Parameters.AddWithValue("@category", category);
                SqlDataReader reader = command2.ExecuteReader();
                int i = 0;
                int[] ids = new int[count];
                while (reader.Read())
                {
                    ids[i] = Convert.ToInt32(reader["Id"]);
                    i++;
                }
                con.Close();
                index = random.Next(0, count);
                con.Open();
                SqlCommand command3 = new SqlCommand("SELECT author, category, name, picture FROM [book] WHERE Id = @Id", con);
                command3.Parameters.AddWithValue("@Id", ids[index]);
                SqlDataReader reader2 = command3.ExecuteReader();
                if (reader2.Read())
                {
                    book.Author = reader2["author"].ToString();
                    book.Category = reader2["category"].ToString();
                    book.Name = reader2["name"].ToString();
                    book.Picture = (byte[])(reader2["picture"]);
                }
            }
            return book;
            con.Close();
        }

        public  void update()
        {
            throw new System.NotImplementedException();
        }
    }
}