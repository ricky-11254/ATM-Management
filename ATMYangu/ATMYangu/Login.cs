using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATMYangu
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "username")
            {
                panel2.Visible = true;
                return;
            }
            if (textBox2.Text != "password")
            {
                panel6.Visible = true;
                return;
            }

            if (textBox1.Text == "username" && textBox2.Text == "password")
            {
                Home home = new Home();
                home.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid username or password. Try again");
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (textBox1.Text == "")
                {
                    textBox1.Text = "Enter Username";
                }
                textBox1.ForeColor = Color.White;
                panel2.Visible = false;
                textBox1.Focus();
            }
            catch { }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (textBox2.Text == "")
                {
                    textBox2.Text = "Enter Password";
                }
                textBox2.ForeColor = Color.White;
                panel6.Visible = false;
                textBox2.Focus();
            }
            catch { }

        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            textBox1.SelectAll();
        }

        private void textBox2_Click(object sender, EventArgs e)
        {
            textBox2.SelectAll();
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            button1.ForeColor = Color.Black;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.ForeColor = Color.White;
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
