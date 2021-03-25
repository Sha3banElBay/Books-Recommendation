using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Books_Recommendation
{
    public class user : Person
    {
        private string username;
        private string email;
        private string password;
        public string Password
        {
            get
            {
                return password;
            }
            set
            {
                password = value;
            }
        }

        public string Username
        {
            get
            {
                return username;
            }
            set
            {
                username = value;
            }
        }

        public string Email
        {
            get
            {
                return email;
            }
            set
            {
                email = value;
            }
        }

        public user(string username, string password)
        {
            Username = username;
            Password = password;
        }
        public book book = new book();
        public userDb userDb = new userDb();

        public book recommend(string category)
        {
            return book.getBook(category);
        }

        public void editProfile()
        {
            userDb.update();
        }

        public bool signUp()
        {
            return userDb.add(username, email, password);
        }

        public bool logIn()
        {
            return userDb.get(Username, Password);
        }
    }
}