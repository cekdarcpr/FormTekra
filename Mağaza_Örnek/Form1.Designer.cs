namespace Mağaza_Örnek
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            listBox1 = new ListBox();
            listBox2 = new ListBox();
            listBox3 = new ListBox();
            listBox4 = new ListBox();
            label5 = new Label();
            fiyat1 = new Label();
            fiyat2 = new Label();
            fiyat3 = new Label();
            fiyat4 = new Label();
            button1 = new Button();
            Sepet = new ListBox();
            label6 = new Label();
            label7 = new Label();
            textBox1 = new TextBox();
            richTextBox1 = new RichTextBox();
            checkBox1 = new CheckBox();
            button2 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(114, 33);
            label1.Name = "label1";
            label1.Size = new Size(75, 21);
            label1.TabIndex = 0;
            label1.Text = "GÖMLEK";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(282, 33);
            label2.Name = "label2";
            label2.Size = new Size(96, 21);
            label2.TabIndex = 1;
            label2.Text = "PANTOLON";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(463, 33);
            label3.Name = "label3";
            label3.Size = new Size(57, 21);
            label3.TabIndex = 2;
            label3.Text = "CEKET";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(636, 33);
            label4.Name = "label4";
            label4.Size = new Size(86, 21);
            label4.TabIndex = 3;
            label4.Text = "AYAKKABI";
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Items.AddRange(new object[] { "", "Kısa Kol", "Uzun Kol", "Hakim Yaka" });
            listBox1.Location = new Point(114, 67);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(120, 94);
            listBox1.TabIndex = 4;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // listBox2
            // 
            listBox2.FormattingEnabled = true;
            listBox2.ItemHeight = 15;
            listBox2.Items.AddRange(new object[] { "", "Keten", "Kot", "Kumaş" });
            listBox2.Location = new Point(282, 67);
            listBox2.Name = "listBox2";
            listBox2.Size = new Size(120, 94);
            listBox2.TabIndex = 5;
            listBox2.SelectedIndexChanged += listBox2_SelectedIndexChanged;
            // 
            // listBox3
            // 
            listBox3.FormattingEnabled = true;
            listBox3.ItemHeight = 15;
            listBox3.Items.AddRange(new object[] { "", "Kot", "Deri", "Kumaş" });
            listBox3.Location = new Point(463, 67);
            listBox3.Name = "listBox3";
            listBox3.Size = new Size(120, 94);
            listBox3.TabIndex = 6;
            listBox3.SelectedIndexChanged += listBox3_SelectedIndexChanged;
            // 
            // listBox4
            // 
            listBox4.FormattingEnabled = true;
            listBox4.ItemHeight = 15;
            listBox4.Items.AddRange(new object[] { "", "Bot", "Spor", "Deri" });
            listBox4.Location = new Point(636, 67);
            listBox4.Name = "listBox4";
            listBox4.Size = new Size(120, 94);
            listBox4.TabIndex = 7;
            listBox4.SelectedIndexChanged += listBox4_SelectedIndexChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(12, 199);
            label5.Name = "label5";
            label5.Size = new Size(37, 17);
            label5.TabIndex = 8;
            label5.Text = "Fiyat";
            // 
            // fiyat1
            // 
            fiyat1.AutoSize = true;
            fiyat1.Location = new Point(147, 201);
            fiyat1.Name = "fiyat1";
            fiyat1.Size = new Size(13, 15);
            fiyat1.TabIndex = 9;
            fiyat1.Text = "0";
            // 
            // fiyat2
            // 
            fiyat2.AutoSize = true;
            fiyat2.Location = new Point(315, 201);
            fiyat2.Name = "fiyat2";
            fiyat2.Size = new Size(13, 15);
            fiyat2.TabIndex = 10;
            fiyat2.Text = "0";
            // 
            // fiyat3
            // 
            fiyat3.AutoSize = true;
            fiyat3.Location = new Point(496, 201);
            fiyat3.Name = "fiyat3";
            fiyat3.Size = new Size(13, 15);
            fiyat3.TabIndex = 11;
            fiyat3.Text = "0";
            // 
            // fiyat4
            // 
            fiyat4.AutoSize = true;
            fiyat4.Location = new Point(669, 201);
            fiyat4.Name = "fiyat4";
            fiyat4.Size = new Size(13, 15);
            fiyat4.TabIndex = 12;
            fiyat4.Text = "0";
            // 
            // button1
            // 
            button1.Location = new Point(300, 241);
            button1.Name = "button1";
            button1.Size = new Size(166, 23);
            button1.TabIndex = 13;
            button1.Text = "Sepete Ekle";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Sepet
            // 
            Sepet.FormattingEnabled = true;
            Sepet.ItemHeight = 15;
            Sepet.Location = new Point(87, 286);
            Sepet.Name = "Sepet";
            Sepet.Size = new Size(147, 139);
            Sepet.TabIndex = 14;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(87, 268);
            label6.Name = "label6";
            label6.Size = new Size(97, 15);
            label6.TabIndex = 15;
            label6.Text = "Sepetteki Ürünler";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(50, 445);
            label7.Name = "label7";
            label7.Size = new Size(67, 15);
            label7.TabIndex = 16;
            label7.Text = "Toplam -->";
            // 
            // textBox1
            // 
            textBox1.Enabled = false;
            textBox1.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            textBox1.Location = new Point(123, 437);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 27);
            textBox1.TabIndex = 17;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(548, 286);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(208, 174);
            richTextBox1.TabIndex = 18;
            richTextBox1.Text = "";
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(328, 288);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(68, 19);
            checkBox1.TabIndex = 19;
            checkBox1.Text = "Öğrenci";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(300, 336);
            button2.Name = "button2";
            button2.Size = new Size(166, 71);
            button2.TabIndex = 20;
            button2.Text = "Fatura Oluştur";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(856, 492);
            Controls.Add(button2);
            Controls.Add(checkBox1);
            Controls.Add(richTextBox1);
            Controls.Add(textBox1);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(Sepet);
            Controls.Add(button1);
            Controls.Add(fiyat4);
            Controls.Add(fiyat3);
            Controls.Add(fiyat2);
            Controls.Add(fiyat1);
            Controls.Add(label5);
            Controls.Add(listBox4);
            Controls.Add(listBox3);
            Controls.Add(listBox2);
            Controls.Add(listBox1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private ListBox listBox1;
        private ListBox listBox2;
        private ListBox listBox3;
        private ListBox listBox4;
        private Label label5;
        private Label fiyat1;
        private Label fiyat2;
        private Label fiyat3;
        private Label fiyat4;
        private Button button1;
        private ListBox Sepet;
        private Label label6;
        private Label label7;
        private TextBox textBox1;
        private RichTextBox richTextBox1;
        private CheckBox checkBox1;
        private Button button2;
    }
}