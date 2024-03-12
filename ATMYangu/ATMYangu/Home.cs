namespace ATMYangu
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }
        public void loadform(object Form)
        {
            if (this.panel2.Controls.Count > 0)
                this.panel2.Controls.RemoveAt(0);
            Form f = Form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.panel2.Controls.Add(f);
            this.panel2.Tag = f;
            f.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            loadform(new Withdraw());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            loadform(new Transfer());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            loadform(new Donate());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            loadform(new Balance());
        }

        private void button5_Click(object sender, EventArgs e)
        {
            loadform(new Bills());
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Home_Load(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
