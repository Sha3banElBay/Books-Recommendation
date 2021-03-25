using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Books_Recommendation
{
    public class admin : Person
    {
        userDb userDb = new userDb();
        private string username;
        private string password;
        public string Password
        {
            get => default;
            set
            {
                password = value;
            }
        }

        public string Username
        {
            get => default;
            set
            {
                username = value;
            }
        }

        public admin(string username, string password)
        {
            this.Username = username;
            this.Password = password;
        }

        public book book = new book();
      

        public bool addBook(string name, string author, string category, byte[] picture)
        {
            return book.addBook(name, author, category, picture);
        }

        public void updateBook()
        {
            book.updateBook();
        }

        public void deleteBook()
        {
            book.deleteBook();
        }

        public bool logIn()
        {
            return userDb.get("admin", password);
        }
    }
}