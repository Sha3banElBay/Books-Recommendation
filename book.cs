using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Books_Recommendation
{
    public class book
    {
        private string name;
        private string author;
        private string category;
        private byte[] picture;
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }

        public int id
        {
            get => default;
            set
            {
            }
        }

        public string Author
        {
            get
            {
                return author;
            }
            set
            {
                author = value;
            }
        }

        public string Category
        {
            get
            {
                return category;
            }
            set
            {
                category = value;
            }
        }

        public string link
        {
            get => default;
            set
            {
            }
        }

        public byte[] Picture
        {
            get
            {
                return picture;
            }
            set
            {
                picture = value;
            }
        }

        public bookDb bookDb = new bookDb();
       

        public bool addBook(string name, string author, string category, byte[] picture)
        {
            return bookDb.add(name, author, category, picture);
        }

        public void deleteBook()
        {
            bookDb.delete();
        }

        public void updateBook()
        {
            bookDb.update();
        }

        public book getBook(string category)
        {
            return bookDb.get(category);
        }
    }
}