using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;
namespace Books_Recommendation
{
    public partial class Form3 : Form
    {
        public Form1 frm1 = new Form1();
        public Form2 frm2 = new Form2();
        public Form3()
        {
            InitializeComponent();
            panel2.Hide();
            comboBox1.SelectedIndex = 0;
            
                label2.Text = "Hello, You can now get the best of books recommendation ";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel2.Show();
            book book;
            bookDb book1 = new bookDb();

            if (frm1.signed)
            {
                book = book1.get(comboBox1.SelectedItem.ToString());
                textBox1.Text = book.Name;
                textBox2.Text = book.Author;
                textBox3.Text = book.Category;
                MemoryStream ms = new MemoryStream(book.Picture);
                pictureBox1.Image = Image.FromStream(ms);
            }

            else
            {
                book = book1.get(comboBox1.SelectedItem.ToString());
                textBox1.Text = book.Name;
                textBox2.Text = book.Author;
                textBox3.Text = book.Category;
                MemoryStream ms = new MemoryStream(book.Picture);
                pictureBox1.Image = Image.FromStream(ms);
            }


        }

       
    }
}
