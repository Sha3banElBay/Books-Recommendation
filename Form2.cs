using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace Books_Recommendation
{
    public partial class Form2 : Form
    {
        public user user;
        public bool logged = false;
        public Form2()
        {
            InitializeComponent();
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            iconPictureBox3.IconColor = Color.FromArgb(0, 139, 139);
            textBox1.ForeColor = Color.FromArgb(0, 139, 139);
            panel2.BackColor = Color.FromArgb(0, 139, 139);


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


            iconPictureBox3.IconColor = Color.FromArgb(220, 220, 220);
            textBox1.ForeColor = Color.FromArgb(220, 220, 220);
            panel2.BackColor = Color.FromArgb(220, 220, 220);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            if ((textBox1.Text != "UserName" && textBox1.Text != "") && (textBox3.Text != "Password" && textBox3.Text != ""))
            {
                if (textBox3.Text.Length >= 8)
                {
                    user = new user(textBox1.Text, textBox3.Text);
                    logged =  user.logIn();
                    if (logged)
                    {
                        this.Hide();
                        Form3 frm = new Form3();
                        frm.ShowDialog();
                        this.Close();
                    }
                    else
                        MessageBox.Show("UserName or password are invalid!");
                }
                else
                    MessageBox.Show("Password Must be 8 Charachters");
            }
            else
                MessageBox.Show("Fields cannot be Empty");
        }
    }
}
