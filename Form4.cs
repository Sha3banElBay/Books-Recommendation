using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Books_Recommendation
{
    public partial class Form4 : Form
    {
        public string picture = "";
        public OpenFileDialog dlg = new OpenFileDialog();

        public Form4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dlg.Filter = "jpeg|*.jpg|bmp|*.bmp|all files|*.*";
            dlg.Title = "Select Book Picture";
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.ImageLocation = dlg.FileName.ToString();
                
            }

        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            iconPictureBox3.IconColor = Color.FromArgb(0, 139, 139);
            textBox1.ForeColor = Color.FromArgb(0, 139, 139);
            panel4.BackColor = Color.FromArgb(0, 139, 139);

            iconPictureBox2.IconColor = Color.FromArgb(220, 220, 220);
            textBox2.ForeColor = Color.FromArgb(220, 220, 220);
            panel2.BackColor = Color.FromArgb(220, 220, 220);



            iconPictureBox4.IconColor = Color.FromArgb(220, 220, 220);
            textBox3.ForeColor = Color.FromArgb(220, 220, 220);
            panel3.BackColor = Color.FromArgb(220, 220, 220);
        }

        private void textBox2_Click(object sender, EventArgs e)
        {
            textBox2.Clear();
            iconPictureBox2.IconColor = Color.FromArgb(0, 139, 139);
            textBox2.ForeColor = Color.FromArgb(0, 139, 139);
            panel2.BackColor = Color.FromArgb(0, 139, 139);


            iconPictureBox3.IconColor = Color.FromArgb(220, 220, 220);
            textBox1.ForeColor = Color.FromArgb(220, 220, 220);
            panel4.BackColor = Color.FromArgb(220, 220, 220);

            iconPictureBox4.IconColor = Color.FromArgb(220, 220, 220);
            textBox3.ForeColor = Color.FromArgb(220, 220, 220);
            panel3.BackColor = Color.FromArgb(220, 220, 220);
        }

        private void textBox3_Click(object sender, EventArgs e)
        {
            textBox3.Clear();
            iconPictureBox4.IconColor = Color.FromArgb(0, 139, 139);
            textBox3.ForeColor = Color.FromArgb(0, 139, 139);
            panel3.BackColor = Color.FromArgb(0, 139, 139);

            iconPictureBox2.IconColor = Color.FromArgb(220, 220, 220);
            textBox2.ForeColor = Color.FromArgb(220, 220, 220);
            panel2.BackColor = Color.FromArgb(220, 220, 220);

            iconPictureBox3.IconColor = Color.FromArgb(220, 220, 220);
            textBox1.ForeColor = Color.FromArgb(220, 220, 220);
            panel4.BackColor = Color.FromArgb(220, 220, 220);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string pic = dlg.FileName.ToString();
            if ((textBox1.Text != "Book Name" && textBox1.Text != "") && (textBox2.Text != "Author" && textBox2.Text != "") && (textBox3.Text != "Category" && textBox3.Text != "") && (picture != ""))
            {
                Form5 frm = new Form5();
                book book = new book();
                byte[] img = null;
                FileStream fs = new FileStream(pic, FileMode.Open, FileAccess.Read);
                BinaryReader br = new BinaryReader(fs);
                img = br.ReadBytes((int)fs.Length);
                bool added = book.addBook(textBox1.Text, textBox2.Text, textBox3.Text, img);
                if (added)
                {
                    MessageBox.Show("Book Added Successfully");
                }
            }
            else
                MessageBox.Show("Fields cannot be empty");
        }
    }
}
