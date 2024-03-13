namespace ATMYangu
{
    partial class Bills
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
            panel1 = new Panel();
            textBox1 = new TextBox();
            label3 = new Label();
            label2 = new Label();
            button1 = new Button();
            label1 = new Label();
            panel2 = new Panel();
            textBox2 = new TextBox();
            label4 = new Label();
            panel3 = new Panel();
            textBox3 = new TextBox();
            label5 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(textBox1);
            panel1.Location = new Point(390, 141);
            panel1.Name = "panel1";
            panel1.Size = new Size(328, 59);
            panel1.TabIndex = 11;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(17, 14);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(294, 23);
            textBox1.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15F);
            label3.Location = new Point(458, 99);
            label3.Name = "label3";
            label3.Size = new Size(79, 28);
            label3.TabIndex = 10;
            label3.Text = "balance";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15F);
            label2.Location = new Point(83, 99);
            label2.Name = "label2";
            label2.Size = new Size(294, 28);
            label2.TabIndex = 9;
            label2.Text = "Your current available balance is:";
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ActiveCaptionText;
            button1.FlatAppearance.BorderColor = Color.Lime;
            button1.FlatAppearance.BorderSize = 2;
            button1.FlatAppearance.MouseDownBackColor = Color.Lime;
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = SystemColors.ControlLightLight;
            button1.Location = new Point(262, 347);
            button1.Name = "button1";
            button1.Size = new Size(213, 51);
            button1.TabIndex = 8;
            button1.Text = "Pay Bill";
            button1.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F);
            label1.Location = new Point(83, 150);
            label1.Name = "label1";
            label1.Size = new Size(211, 28);
            label1.TabIndex = 7;
            label1.Text = "Enter Account Number";
            // 
            // panel2
            // 
            panel2.Controls.Add(textBox2);
            panel2.Location = new Point(390, 196);
            panel2.Name = "panel2";
            panel2.Size = new Size(328, 59);
            panel2.TabIndex = 13;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(17, 14);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(294, 23);
            textBox2.TabIndex = 2;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 15F);
            label4.Location = new Point(83, 202);
            label4.Name = "label4";
            label4.Size = new Size(164, 28);
            label4.TabIndex = 12;
            label4.Text = "Enter Bill Amount";
            // 
            // panel3
            // 
            panel3.Controls.Add(textBox3);
            panel3.Location = new Point(390, 261);
            panel3.Name = "panel3";
            panel3.Size = new Size(328, 59);
            panel3.TabIndex = 15;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(17, 14);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(294, 23);
            textBox3.TabIndex = 2;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 15F);
            label5.Location = new Point(83, 270);
            label5.Name = "label5";
            label5.Size = new Size(222, 28);
            label5.TabIndex = 14;
            label5.Text = "Enter purpose of the bill";
            // 
            // Bills
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel3);
            Controls.Add(label5);
            Controls.Add(panel2);
            Controls.Add(label4);
            Controls.Add(panel1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(button1);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Bills";
            Text = "Bills";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private TextBox textBox1;
        private Label label3;
        private Label label2;
        private Button button1;
        private Label label1;
        private Panel panel2;
        private TextBox textBox2;
        private Label label4;
        private Panel panel3;
        private TextBox textBox3;
        private Label label5;
    }
}