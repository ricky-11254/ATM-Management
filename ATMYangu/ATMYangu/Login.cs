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
            string username = textBox1.Text;
            string password = textBox2.Text;
            if(username == "username" && password == "password")
            {
                Home home = new Home();
                home.Show();
                this.Hide();
            } else
            {
                MessageBox.Show("Invalid username or password. Try again");
            }

        }
    }
}
