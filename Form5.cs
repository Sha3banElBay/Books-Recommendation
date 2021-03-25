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
    public partial class Form5 : Form
    {
        public admin admin;
        public Form5()
        {
            InitializeComponent();
        }

        private void textBox3_Click(object sender, EventArgs e)
        {
            textBox3.Clear();
            iconPictureBox4.IconColor = Color.FromArgb(0, 139, 139);
            textBox3.ForeColor = Color.FromArgb(0, 139, 139);
            panel3.BackColor = Color.FromArgb(0, 139, 139);
            textBox3.PasswordChar = '*';
        }

        private void button2_Click(object sender, EventArgs e)
        {
            bool logged = false;
            if (textBox3.Text != "Password" && textBox3.Text != "")
            {
                if (textBox3.Text.Length >= 8)
                {
                     admin = new admin("admin", textBox3.Text);
                    logged = admin.logIn();
                    if (logged)
                    {
                        this.Hide();
                        Form4 frm = new Form4();
                        frm.ShowDialog();
                        this.Close();
                    }
                    else
                        MessageBox.Show("Password is invalid!");
                }
                else
                    MessageBox.Show("Password Must be 8 Charachters");
            }
            else
                MessageBox.Show("Fields cannot be Empty");
        }
    }
}
