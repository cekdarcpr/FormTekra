namespace GünTekrar
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            sayı1 = new Label();
            sayı2 = new Label();
            sonuc = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            topla = new Button();
            lblSonuc = new Label();
            SuspendLayout();
            // 
            // sayı1
            // 
            sayı1.AutoSize = true;
            sayı1.Location = new Point(33, 57);
            sayı1.Name = "sayı1";
            sayı1.Size = new Size(45, 15);
            sayı1.TabIndex = 0;
            sayı1.Text = "1. SAYI ";
            // 
            // sayı2
            // 
            sayı2.AutoSize = true;
            sayı2.Location = new Point(33, 86);
            sayı2.Name = "sayı2";
            sayı2.Size = new Size(42, 15);
            sayı2.TabIndex = 1;
            sayı2.Text = "2. SAYI";
            // 
            // sonuc
            // 
            sonuc.AutoSize = true;
            sonuc.Location = new Point(215, 86);
            sonuc.Name = "sonuc";
            sonuc.Size = new Size(0, 15);
            sonuc.TabIndex = 2;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(91, 49);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(91, 78);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 4;
            // 
            // topla
            // 
            topla.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            topla.Location = new Point(104, 107);
            topla.Name = "topla";
            topla.Size = new Size(78, 33);
            topla.TabIndex = 5;
            topla.Text = "TOPLA";
            topla.UseVisualStyleBackColor = true;
            topla.Click += topla_Click;
            // 
            // lblSonuc
            // 
            lblSonuc.AutoSize = true;
            lblSonuc.Location = new Point(197, 86);
            lblSonuc.Name = "lblSonuc";
            lblSonuc.Size = new Size(0, 15);
            lblSonuc.TabIndex = 6;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(345, 204);
            Controls.Add(lblSonuc);
            Controls.Add(topla);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(sonuc);
            Controls.Add(sayı2);
            Controls.Add(sayı1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label sayı1;
        private Label sayı2;
        private Label sonuc;
        private TextBox textBox1;
        private TextBox textBox2;
        private Button topla;
        private Label lblSonuc;
    }
}