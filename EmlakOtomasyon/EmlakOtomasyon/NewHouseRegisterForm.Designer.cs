namespace EmlakOtomasyon
{
    partial class NewHouseRegisterForm
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
            Oda = new TextBox();
            Kat = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            tür = new Label();
            Alanı = new TextBox();
            comboBox1 = new ComboBox();
            aktif = new Label();
            groupBox1 = new GroupBox();
            Fiyat = new TextBox();
            Kira = new TextBox();
            label12 = new Label();
            label11 = new Label();
            label10 = new Label();
            Depozito = new TextBox();
            label9 = new Label();
            SatilikRD = new RadioButton();
            KiraRD = new RadioButton();
            button1 = new Button();
            yt = new DateTimePicker();
            comboBox2 = new ComboBox();
            isActive = new RadioButton();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // Oda
            // 
            Oda.BackColor = Color.FromArgb(192, 255, 255);
            Oda.Location = new Point(311, 122);
            Oda.Name = "Oda";
            Oda.Size = new Size(92, 27);
            Oda.TabIndex = 0;
            // 
            // Kat
            // 
            Kat.BackColor = Color.FromArgb(192, 255, 255);
            Kat.Location = new Point(439, 122);
            Kat.Name = "Kat";
            Kat.Size = new Size(92, 27);
            Kat.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 162);
            label1.Location = new Point(394, 9);
            label1.Name = "label1";
            label1.Size = new Size(265, 41);
            label1.TabIndex = 2;
            label1.Text = "Yeni Kayıt Ekleme";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.Navy;
            label2.Location = new Point(311, 94);
            label2.Name = "label2";
            label2.Size = new Size(78, 20);
            label2.TabIndex = 3;
            label2.Text = "Oda Sayısı";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.Navy;
            label3.Location = new Point(439, 94);
            label3.Name = "label3";
            label3.Size = new Size(98, 20);
            label3.TabIndex = 4;
            label3.Text = "Kat Numarası";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.Navy;
            label4.Location = new Point(695, 94);
            label4.Name = "label4";
            label4.Size = new Size(43, 20);
            label4.TabIndex = 5;
            label4.Text = "Semt";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = Color.Navy;
            label5.Location = new Point(570, 94);
            label5.Name = "label5";
            label5.Size = new Size(47, 20);
            label5.TabIndex = 6;
            label5.Text = "Alanı ";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.ForeColor = Color.Navy;
            label6.Location = new Point(160, 94);
            label6.Name = "label6";
            label6.Size = new Size(89, 20);
            label6.TabIndex = 7;
            label6.Text = "Yapım Tarihi";
            // 
            // tür
            // 
            tür.AutoSize = true;
            tür.ForeColor = Color.Navy;
            tür.Location = new Point(823, 94);
            tür.Name = "tür";
            tür.Size = new Size(38, 20);
            tür.TabIndex = 8;
            tür.Text = "Türü";
            // 
            // Alanı
            // 
            Alanı.BackColor = Color.FromArgb(192, 255, 255);
            Alanı.Location = new Point(570, 122);
            Alanı.Name = "Alanı";
            Alanı.Size = new Size(92, 27);
            Alanı.TabIndex = 10;
            // 
            // comboBox1
            // 
            comboBox1.BackColor = Color.FromArgb(192, 255, 255);
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(695, 122);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(92, 28);
            comboBox1.TabIndex = 11;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // aktif
            // 
            aktif.AutoSize = true;
            aktif.ForeColor = Color.Navy;
            aktif.Location = new Point(101, 94);
            aktif.Name = "aktif";
            aktif.Size = new Size(40, 20);
            aktif.TabIndex = 12;
            aktif.Text = "Aktif";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(Fiyat);
            groupBox1.Controls.Add(Kira);
            groupBox1.Controls.Add(label12);
            groupBox1.Controls.Add(label11);
            groupBox1.Controls.Add(label10);
            groupBox1.Controls.Add(Depozito);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(SatilikRD);
            groupBox1.Controls.Add(KiraRD);
            groupBox1.Location = new Point(311, 195);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(381, 254);
            groupBox1.TabIndex = 13;
            groupBox1.TabStop = false;
            // 
            // Fiyat
            // 
            Fiyat.BackColor = Color.FromArgb(192, 255, 255);
            Fiyat.Location = new Point(60, 148);
            Fiyat.Name = "Fiyat";
            Fiyat.Size = new Size(92, 27);
            Fiyat.TabIndex = 8;
            // 
            // Kira
            // 
            Kira.BackColor = Color.FromArgb(192, 255, 255);
            Kira.Location = new Point(258, 208);
            Kira.Name = "Kira";
            Kira.Size = new Size(92, 27);
            Kira.TabIndex = 7;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.ForeColor = Color.Navy;
            label12.Location = new Point(60, 125);
            label12.Name = "label12";
            label12.Size = new Size(40, 20);
            label12.TabIndex = 6;
            label12.Text = "Fiyat";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.ForeColor = Color.Navy;
            label11.Location = new Point(258, 185);
            label11.Name = "label11";
            label11.Size = new Size(78, 20);
            label11.TabIndex = 5;
            label11.Text = "Kira Ücreti";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.ForeColor = Color.Navy;
            label10.Location = new Point(258, 125);
            label10.Name = "label10";
            label10.Size = new Size(71, 20);
            label10.TabIndex = 4;
            label10.Text = "Depozito";
            // 
            // Depozito
            // 
            Depozito.BackColor = Color.FromArgb(192, 255, 255);
            Depozito.Location = new Point(258, 148);
            Depozito.Name = "Depozito";
            Depozito.Size = new Size(92, 27);
            Depozito.TabIndex = 3;
            Depozito.TextChanged += textBox1_TextChanged;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(159, 23);
            label9.Name = "label9";
            label9.Size = new Size(75, 20);
            label9.TabIndex = 2;
            label9.Text = "Kayıt Türü";
            // 
            // SatilikRD
            // 
            SatilikRD.AutoSize = true;
            SatilikRD.Cursor = Cursors.Hand;
            SatilikRD.ForeColor = SystemColors.ControlText;
            SatilikRD.Location = new Point(60, 71);
            SatilikRD.Name = "SatilikRD";
            SatilikRD.Size = new Size(70, 24);
            SatilikRD.TabIndex = 1;
            SatilikRD.TabStop = true;
            SatilikRD.Text = "Satılık";
            SatilikRD.UseVisualStyleBackColor = true;
            // 
            // KiraRD
            // 
            KiraRD.AutoSize = true;
            KiraRD.Cursor = Cursors.Hand;
            KiraRD.ForeColor = SystemColors.ControlText;
            KiraRD.Location = new Point(258, 71);
            KiraRD.Name = "KiraRD";
            KiraRD.Size = new Size(56, 24);
            KiraRD.TabIndex = 0;
            KiraRD.TabStop = true;
            KiraRD.Text = "Kira";
            KiraRD.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.BackColor = Color.LimeGreen;
            button1.Location = new Point(402, 467);
            button1.Name = "button1";
            button1.Size = new Size(194, 72);
            button1.TabIndex = 14;
            button1.Text = "Kaydı Tamamla";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // yt
            // 
            yt.CalendarMonthBackground = Color.FromArgb(192, 255, 255);
            yt.Location = new Point(160, 122);
            yt.Name = "yt";
            yt.Size = new Size(92, 27);
            yt.TabIndex = 3;
            // 
            // comboBox2
            // 
            comboBox2.BackColor = Color.FromArgb(192, 255, 255);
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(823, 122);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(92, 28);
            comboBox2.TabIndex = 15;
            // 
            // isActive
            // 
            isActive.AutoSize = true;
            isActive.Cursor = Cursors.Hand;
            isActive.Location = new Point(101, 127);
            isActive.Name = "isActive";
            isActive.Size = new Size(17, 16);
            isActive.TabIndex = 16;
            isActive.TabStop = true;
            isActive.UseVisualStyleBackColor = true;
            // 
            // NewHouseRegisterForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 192, 192);
            ClientSize = new Size(994, 601);
            Controls.Add(isActive);
            Controls.Add(comboBox2);
            Controls.Add(yt);
            Controls.Add(button1);
            Controls.Add(groupBox1);
            Controls.Add(aktif);
            Controls.Add(comboBox1);
            Controls.Add(Alanı);
            Controls.Add(tür);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(Kat);
            Controls.Add(Oda);
            Name = "NewHouseRegisterForm";
            Text = "addRegister";
            Load += addRegister_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox Oda;
        private TextBox Kat;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label tür;
        private TextBox Alanı;
        private ComboBox comboBox1;
        private Label aktif;
        private GroupBox groupBox1;
        private Label label9;
        private RadioButton SatilikRD;
        private RadioButton KiraRD;
        private Button button1;
        private DateTimePicker dateTimePicker1;
        private TextBox Kira;
        private Label label12;
        private Label label11;
        private Label label10;
        private TextBox Depozito;
        private ComboBox comboBox2;
        private RadioButton ak;
        private TextBox Fiyat;
        private Label label6;
        private DateTimePicker yt;
        private RadioButton isActive;
    }
}