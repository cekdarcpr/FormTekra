﻿namespace Ornek_2
{
    partial class Ornek2
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
            textBox1 = new TextBox();
            lblSonuc = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(106, 107);
            label1.Name = "label1";
            label1.Size = new Size(47, 15);
            label1.TabIndex = 0;
            label1.Text = "SONUC";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(106, 70);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 1;
            // 
            // lblSonuc
            // 
            lblSonuc.AutoSize = true;
            lblSonuc.Location = new Point(168, 107);
            lblSonuc.Name = "lblSonuc";
            lblSonuc.Size = new Size(0, 15);
            lblSonuc.TabIndex = 2;
            // 
            // button1
            // 
            button1.Location = new Point(212, 70);
            button1.Name = "button1";
            button1.Size = new Size(104, 52);
            button1.TabIndex = 3;
            button1.Text = "HESAPLA";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Ornek2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(587, 307);
            Controls.Add(button1);
            Controls.Add(lblSonuc);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Name = "Ornek2";
            Text = "Ornek2";
            //Load += Ornek2_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private Label lblSonuc;
        private Button button1;
    }
}