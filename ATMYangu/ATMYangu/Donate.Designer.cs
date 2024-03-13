namespace ATMYangu
{
    partial class Donate
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
            panel1.SuspendLayout();
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
            button1.Location = new Point(258, 300);
            button1.Name = "button1";
            button1.Size = new Size(213, 51);
            button1.TabIndex = 8;
            button1.Text = "Donate";
            button1.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F);
            label1.Location = new Point(83, 150);
            label1.Name = "label1";
            label1.Size = new Size(224, 28);
            label1.TabIndex = 7;
            label1.Text = "Enter Amount to donate";
            // 
            // Donate
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(button1);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Donate";
            Text = "Donate";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
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
    }
}