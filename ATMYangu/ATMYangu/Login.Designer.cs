namespace ATMYangu
{
    partial class Login
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            textBox1 = new TextBox();
            button1 = new Button();
            panel1 = new Panel();
            panel3 = new Panel();
            pictureBox1 = new PictureBox();
            panel4 = new Panel();
            panel2 = new Panel();
            label3 = new Label();
            panel5 = new Panel();
            panel6 = new Panel();
            label4 = new Label();
            panel7 = new Panel();
            panel8 = new Panel();
            textBox2 = new TextBox();
            label5 = new Label();
            pictureBox2 = new PictureBox();
            linkLabel1 = new LinkLabel();
            linkLabel2 = new LinkLabel();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel4.SuspendLayout();
            panel2.SuspendLayout();
            panel5.SuspendLayout();
            panel6.SuspendLayout();
            panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.FlatStyle = FlatStyle.Flat;
            label1.Font = new Font("Segoe UI", 15F);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(370, 9);
            label1.Name = "label1";
            label1.Size = new Size(61, 28);
            label1.TabIndex = 0;
            label1.Text = "Login";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.ForeColor = SystemColors.ControlLightLight;
            label2.Location = new Point(101, 88);
            label2.Name = "label2";
            label2.Size = new Size(81, 21);
            label2.TabIndex = 1;
            label2.Text = "Username";
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.MenuText;
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Segoe UI", 15F);
            textBox1.ForeColor = Color.Gray;
            textBox1.Location = new Point(30, 18);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(394, 27);
            textBox1.TabIndex = 2;
            textBox1.Text = "Enter username";
            textBox1.Click += textBox1_Click;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // button1
            // 
            button1.FlatAppearance.BorderColor = Color.FromArgb(0, 192, 0);
            button1.FlatAppearance.BorderSize = 2;
            button1.FlatAppearance.MouseOverBackColor = Color.Lime;
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = SystemColors.ControlLightLight;
            button1.Location = new Point(310, 364);
            button1.Name = "button1";
            button1.Size = new Size(178, 41);
            button1.TabIndex = 4;
            button1.Text = "Login";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            button1.MouseEnter += button1_MouseEnter;
            button1.MouseLeave += button1_MouseLeave;
            // 
            // panel1
            // 
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(textBox1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(463, 69);
            panel1.TabIndex = 6;
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.None;
            panel3.BackColor = SystemColors.ControlLightLight;
            panel3.Location = new Point(30, 51);
            panel3.Name = "panel3";
            panel3.Size = new Size(394, 1);
            panel3.TabIndex = 10;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(35, 82);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(51, 50);
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // panel4
            // 
            panel4.Controls.Add(panel2);
            panel4.Controls.Add(panel1);
            panel4.Location = new Point(193, 64);
            panel4.Name = "panel4";
            panel4.Size = new Size(463, 110);
            panel4.TabIndex = 10;
            // 
            // panel2
            // 
            panel2.Controls.Add(label3);
            panel2.Location = new Point(3, 75);
            panel2.Name = "panel2";
            panel2.Size = new Size(457, 27);
            panel2.TabIndex = 11;
            panel2.Visible = false;
            panel2.Paint += panel2_Paint;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Dock = DockStyle.Left;
            label3.Font = new Font("Segoe UI", 12F);
            label3.ForeColor = Color.Red;
            label3.Location = new Point(0, 0);
            label3.Name = "label3";
            label3.Size = new Size(198, 21);
            label3.TabIndex = 2;
            label3.Text = "Invalid user name try again";
            // 
            // panel5
            // 
            panel5.Controls.Add(panel6);
            panel5.Controls.Add(panel7);
            panel5.Location = new Point(193, 180);
            panel5.Name = "panel5";
            panel5.Size = new Size(463, 113);
            panel5.TabIndex = 11;
            // 
            // panel6
            // 
            panel6.Controls.Add(label4);
            panel6.Location = new Point(3, 75);
            panel6.Name = "panel6";
            panel6.Size = new Size(457, 30);
            panel6.TabIndex = 11;
            panel6.Visible = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Dock = DockStyle.Left;
            label4.Font = new Font("Segoe UI", 12F);
            label4.ForeColor = Color.Red;
            label4.Location = new Point(0, 0);
            label4.Name = "label4";
            label4.Size = new Size(192, 21);
            label4.TabIndex = 2;
            label4.Text = "Invalid password try again";
            label4.Click += label4_Click;
            // 
            // panel7
            // 
            panel7.Controls.Add(panel8);
            panel7.Controls.Add(textBox2);
            panel7.Dock = DockStyle.Top;
            panel7.Location = new Point(0, 0);
            panel7.Name = "panel7";
            panel7.Size = new Size(463, 69);
            panel7.TabIndex = 6;
            // 
            // panel8
            // 
            panel8.Anchor = AnchorStyles.None;
            panel8.BackColor = SystemColors.ControlLightLight;
            panel8.Location = new Point(30, 36);
            panel8.Name = "panel8";
            panel8.Size = new Size(394, 1);
            panel8.TabIndex = 10;
            // 
            // textBox2
            // 
            textBox2.BackColor = SystemColors.MenuText;
            textBox2.BorderStyle = BorderStyle.None;
            textBox2.Font = new Font("Segoe UI", 15F);
            textBox2.ForeColor = Color.Gray;
            textBox2.Location = new Point(30, 3);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(394, 27);
            textBox2.TabIndex = 2;
            textBox2.Text = "Enter password";
            textBox2.Click += textBox2_Click;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F);
            label5.ForeColor = SystemColors.ControlLightLight;
            label5.Location = new Point(101, 189);
            label5.Name = "label5";
            label5.Size = new Size(76, 21);
            label5.TabIndex = 12;
            label5.Text = "Password";
            // 
            // pictureBox2
            // 
            pictureBox2.Location = new Point(35, 183);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(51, 50);
            pictureBox2.TabIndex = 13;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Font = new Font("Segoe UI", 10F);
            linkLabel1.LinkColor = Color.White;
            linkLabel1.Location = new Point(354, 331);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(112, 19);
            linkLabel1.TabIndex = 14;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Forgot password";
            // 
            // linkLabel2
            // 
            linkLabel2.AutoSize = true;
            linkLabel2.Font = new Font("Segoe UI", 10F);
            linkLabel2.LinkColor = Color.White;
            linkLabel2.Location = new Point(354, 422);
            linkLabel2.Name = "linkLabel2";
            linkLabel2.Size = new Size(134, 19);
            linkLabel2.TabIndex = 15;
            linkLabel2.TabStop = true;
            linkLabel2.Text = "Create New Account";
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(800, 450);
            Controls.Add(linkLabel2);
            Controls.Add(linkLabel1);
            Controls.Add(pictureBox2);
            Controls.Add(label5);
            Controls.Add(panel5);
            Controls.Add(panel4);
            Controls.Add(pictureBox1);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Login";
            Text = "Login";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel4.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel5.ResumeLayout(false);
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox textBox1;
        private Button button1;
        private Panel panel1;
        private PictureBox pictureBox1;
        private Panel panel3;
        private Panel panel4;
        private Panel panel2;
        private Label label3;
        private Panel panel5;
        private Panel panel6;
        private Label label4;
        private Panel panel7;
        private Panel panel8;
        private TextBox textBox2;
        private Label label5;
        private PictureBox pictureBox2;
        private LinkLabel linkLabel1;
        private LinkLabel linkLabel2;
    }
}