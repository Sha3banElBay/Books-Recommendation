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
using System.Text.RegularExpressions;

namespace Books_Recommendation
{
    public partial class Form1 : Form
    {
        public user user;
        public bool signed = false;

        public Form1()
        {
            InitializeComponent();
        }


        private void textBox1_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            iconPictureBox3.IconColor = Color.FromArgb(0, 139, 139);
            textBox1.ForeColor = Color.FromArgb(0, 139, 139);
            panel2.BackColor = Color.FromArgb(0, 139, 139);

            iconPictureBox2.IconColor = Color.FromArgb(220, 220, 220);
            textBox2.ForeColor = Color.FromArgb(220, 220, 220);
            panel1.BackColor = Color.FromArgb(220, 220, 220);



            iconPictureBox4.IconColor = Color.FromArgb(220, 220, 220);
            textBox3.ForeColor = Color.FromArgb(220, 220, 220);
            panel3.BackColor = Color.FromArgb(220, 220, 220);

        }

        private void textBox2_Click(object sender, EventArgs e)
        {
            textBox2.Clear();
            iconPictureBox2.IconColor = Color.FromArgb(0, 139, 139);
            textBox2.ForeColor = Color.FromArgb(0, 139, 139);
            panel1.BackColor = Color.FromArgb(0, 139, 139);


            iconPictureBox3.IconColor = Color.FromArgb(220, 220, 220);
            textBox1.ForeColor = Color.FromArgb(220, 220, 220);
            panel2.BackColor = Color.FromArgb(220, 220, 220);

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
            textBox3.PasswordChar = '*';

            iconPictureBox2.IconColor = Color.FromArgb(220, 220, 220);
            textBox2.ForeColor = Color.FromArgb(220, 220, 220);
            panel1.BackColor = Color.FromArgb(220, 220, 220);

            iconPictureBox3.IconColor = Color.FromArgb(220, 220, 220);
            textBox1.ForeColor = Color.FromArgb(220, 220, 220);
            panel2.BackColor = Color.FromArgb(220, 220, 220);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 frm = new Form2();
            frm.ShowDialog();
            this.Close();
        }

        private void textBox2_Click_1(object sender, EventArgs e)
        {
            textBox2.Clear();
            iconPictureBox2.IconColor = Color.FromArgb(0, 139, 139);
            textBox2.ForeColor = Color.FromArgb(0, 139, 139);
            panel1.BackColor = Color.FromArgb(0, 139, 139);


            iconPictureBox3.IconColor = Color.FromArgb(220, 220, 220);
            textBox1.ForeColor = Color.FromArgb(220, 220, 220);
            panel2.BackColor = Color.FromArgb(220, 220, 220);

            iconPictureBox4.IconColor = Color.FromArgb(220, 220, 220);
            textBox3.ForeColor = Color.FromArgb(220, 220, 220);
            panel3.BackColor = Color.FromArgb(220, 220, 220);
        }

        private void textBox3_Click_1(object sender, EventArgs e)
        {
            textBox3.Clear();
            iconPictureBox4.IconColor = Color.FromArgb(0, 139, 139);
            textBox3.ForeColor = Color.FromArgb(0, 139, 139);
            panel3.BackColor = Color.FromArgb(0, 139, 139);
            textBox3.PasswordChar = '*';


            iconPictureBox2.IconColor = Color.FromArgb(220, 220, 220);
            textBox2.ForeColor = Color.FromArgb(220, 220, 220);
            panel1.BackColor = Color.FromArgb(220, 220, 220);

            iconPictureBox3.IconColor = Color.FromArgb(220, 220, 220);
            textBox1.ForeColor = Color.FromArgb(220, 220, 220);
            panel2.BackColor = Color.FromArgb(220, 220, 220);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if ((textBox1.Text != "UserName" && textBox1.Text != "") && (textBox2.Text != "Email" && textBox2.Text != "") && (textBox3.Text != "Password" && textBox3.Text != ""))
            {
                Regex regex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
                Match match = regex.Match(textBox2.Text);
                if (match.Success)
                {
                    if (textBox3.Text.Length >= 8)
                    {
                        user = new user(textBox1.Text, textBox3.Text);
                        user.Email = textBox2.Text;
                        signed  = user.signUp();
                    }
                    else
                    {
                        MessageBox.Show("Password Must be 8 Charachters");
                    }
                }
                else
                    MessageBox.Show("Enter Valid Email");
            }
            else
                MessageBox.Show("Fields cannot be Empty");

            if (signed)
            {
                this.Hide();
                Form3 frm = new Form3();
                frm.ShowDialog();
                this.Close();
            }
        }

            private void button3_Click(object sender, EventArgs e)
            {
                this.Hide();
                Form5 frm = new Form5();
                frm.ShowDialog();
                this.Close();
            }


    }



       
    }

