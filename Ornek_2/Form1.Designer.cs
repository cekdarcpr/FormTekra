namespace Ornek_2
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
            button = new Button();
            Vize = new Label();
            Final = new Label();
            Ortalama = new Label();
            Durum = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            lblortalama = new Label();
            lblDurum = new Label();
            SuspendLayout();
            // 
            // button
            // 
            button.Location = new Point(154, 115);
            button.Name = "button";
            button.Size = new Size(100, 37);
            button.TabIndex = 0;
            button.Text = "Sonuc";
            button.UseVisualStyleBackColor = true;
            button.Click += button_Click;
            // 
            // Vize
            // 
            Vize.AutoSize = true;
            Vize.Location = new Point(110, 55);
            Vize.Name = "Vize";
            Vize.Size = new Size(28, 15);
            Vize.TabIndex = 1;
            Vize.Text = "Vize";
            // 
            // Final
            // 
            Final.AutoSize = true;
            Final.Location = new Point(110, 87);
            Final.Name = "Final";
            Final.Size = new Size(32, 15);
            Final.TabIndex = 2;
            Final.Text = "Final";
            // 
            // Ortalama
            // 
            Ortalama.AutoSize = true;
            Ortalama.Location = new Point(276, 55);
            Ortalama.Name = "Ortalama";
            Ortalama.Size = new Size(56, 15);
            Ortalama.TabIndex = 3;
            Ortalama.Text = "Ortalama";
            // 
            // Durum
            // 
            Durum.AutoSize = true;
            Durum.Location = new Point(276, 87);
            Durum.Name = "Durum";
            Durum.Size = new Size(44, 15);
            Durum.TabIndex = 4;
            Durum.Text = "Durum";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(154, 47);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 5;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(154, 84);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 6;
            // 
            // lblortalama
            // 
            lblortalama.AutoSize = true;
            lblortalama.Location = new Point(350, 55);
            lblortalama.Name = "lblortalama";
            lblortalama.Size = new Size(0, 15);
            lblortalama.TabIndex = 7;
            // 
            // lblDurum
            // 
            lblDurum.AutoSize = true;
            lblDurum.Location = new Point(350, 87);
            lblDurum.Name = "lblDurum";
            lblDurum.Size = new Size(0, 15);
            lblDurum.TabIndex = 8;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(482, 235);
            Controls.Add(lblDurum);
            Controls.Add(lblortalama);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(Durum);
            Controls.Add(Ortalama);
            Controls.Add(Final);
            Controls.Add(Vize);
            Controls.Add(button);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button;
        private Label Vize;
        private Label Final;
        private Label Ortalama;
        private Label Durum;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label lblortalama;
        private Label lblDurum;
    }
}