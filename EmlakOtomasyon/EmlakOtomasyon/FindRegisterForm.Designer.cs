namespace EmlakOtomasyon
{
    partial class FindRegisterForm
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
            listView1 = new ListView();
            isActive = new RadioButton();
            comboBox2 = new ComboBox();
            aktif = new Label();
            comboBox1 = new ComboBox();
            alanTextBox = new TextBox();
            tür = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            katNumarasiTextBox = new TextBox();
            odaSayisiTextBox = new TextBox();
            AraButton = new Button();
            satilikRD = new RadioButton();
            kiralikRD = new RadioButton();
            groupBox1 = new GroupBox();
            radioButton1 = new RadioButton();
            label1 = new Label();
            label6 = new Label();
            label7 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // listView1
            // 
            listView1.Location = new Point(12, 47);
            listView1.Name = "listView1";
            listView1.Size = new Size(1160, 425);
            listView1.TabIndex = 0;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.SelectedIndexChanged += listView1_SelectedIndexChanged;
            // 
            // isActive
            // 
            isActive.AutoSize = true;
            isActive.Cursor = Cursors.Hand;
            isActive.Location = new Point(887, 518);
            isActive.Name = "isActive";
            isActive.Size = new Size(17, 16);
            isActive.TabIndex = 30;
            isActive.TabStop = true;
            isActive.UseVisualStyleBackColor = true;
            // 
            // comboBox2
            // 
            comboBox2.BackColor = Color.FromArgb(192, 255, 255);
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(759, 513);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(92, 28);
            comboBox2.TabIndex = 29;
            // 
            // aktif
            // 
            aktif.AutoSize = true;
            aktif.ForeColor = Color.Navy;
            aktif.Location = new Point(887, 485);
            aktif.Name = "aktif";
            aktif.Size = new Size(40, 20);
            aktif.TabIndex = 28;
            aktif.Text = "Aktif";
            // 
            // comboBox1
            // 
            comboBox1.BackColor = Color.FromArgb(192, 255, 255);
            comboBox1.DropDownHeight = 140;
            comboBox1.FormattingEnabled = true;
            comboBox1.IntegralHeight = false;
            comboBox1.Location = new Point(631, 513);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(92, 28);
            comboBox1.TabIndex = 27;
            // 
            // alanTextBox
            // 
            alanTextBox.BackColor = Color.FromArgb(192, 255, 255);
            alanTextBox.Location = new Point(506, 513);
            alanTextBox.Name = "alanTextBox";
            alanTextBox.Size = new Size(92, 27);
            alanTextBox.TabIndex = 26;
            // 
            // tür
            // 
            tür.AutoSize = true;
            tür.ForeColor = Color.Navy;
            tür.Location = new Point(759, 485);
            tür.Name = "tür";
            tür.Size = new Size(38, 20);
            tür.TabIndex = 25;
            tür.Text = "Türü";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = Color.Navy;
            label5.Location = new Point(506, 485);
            label5.Name = "label5";
            label5.Size = new Size(47, 20);
            label5.TabIndex = 23;
            label5.Text = "Alanı ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.Navy;
            label4.Location = new Point(631, 485);
            label4.Name = "label4";
            label4.Size = new Size(43, 20);
            label4.TabIndex = 22;
            label4.Text = "Semt";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.Navy;
            label3.Location = new Point(375, 485);
            label3.Name = "label3";
            label3.Size = new Size(98, 20);
            label3.TabIndex = 21;
            label3.Text = "Kat Numarası";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.Navy;
            label2.Location = new Point(247, 485);
            label2.Name = "label2";
            label2.Size = new Size(78, 20);
            label2.TabIndex = 20;
            label2.Text = "Oda Sayısı";
            // 
            // katNumarasiTextBox
            // 
            katNumarasiTextBox.BackColor = Color.FromArgb(192, 255, 255);
            katNumarasiTextBox.Location = new Point(375, 513);
            katNumarasiTextBox.Name = "katNumarasiTextBox";
            katNumarasiTextBox.Size = new Size(92, 27);
            katNumarasiTextBox.TabIndex = 18;
            // 
            // odaSayisiTextBox
            // 
            odaSayisiTextBox.BackColor = Color.FromArgb(192, 255, 255);
            odaSayisiTextBox.Location = new Point(247, 513);
            odaSayisiTextBox.Name = "odaSayisiTextBox";
            odaSayisiTextBox.Size = new Size(92, 27);
            odaSayisiTextBox.TabIndex = 17;
            // 
            // AraButton
            // 
            AraButton.BackColor = Color.LimeGreen;
            AraButton.Location = new Point(978, 564);
            AraButton.Name = "AraButton";
            AraButton.Size = new Size(194, 72);
            AraButton.TabIndex = 31;
            AraButton.Text = "Ara";
            AraButton.UseVisualStyleBackColor = false;
            AraButton.Click += AraButton_Click;
            // 
            // satilikRD
            // 
            satilikRD.AutoSize = true;
            satilikRD.Location = new Point(6, 14);
            satilikRD.Name = "satilikRD";
            satilikRD.Size = new Size(17, 16);
            satilikRD.TabIndex = 32;
            satilikRD.TabStop = true;
            satilikRD.UseVisualStyleBackColor = true;
            // 
            // kiralikRD
            // 
            kiralikRD.AutoSize = true;
            kiralikRD.Location = new Point(96, 14);
            kiralikRD.Name = "kiralikRD";
            kiralikRD.Size = new Size(17, 16);
            kiralikRD.TabIndex = 33;
            kiralikRD.TabStop = true;
            kiralikRD.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(satilikRD);
            groupBox1.Controls.Add(kiralikRD);
            groupBox1.Location = new Point(67, 503);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(137, 37);
            groupBox1.TabIndex = 34;
            groupBox1.TabStop = false;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Cursor = Cursors.Hand;
            radioButton1.Location = new Point(945, 518);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(17, 16);
            radioButton1.TabIndex = 36;
            radioButton1.TabStop = true;
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.Navy;
            label1.Location = new Point(945, 485);
            label1.Name = "label1";
            label1.Size = new Size(46, 20);
            label1.TabIndex = 35;
            label1.Text = "Tümü";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.ForeColor = Color.Navy;
            label6.Location = new Point(67, 485);
            label6.Name = "label6";
            label6.Size = new Size(49, 20);
            label6.TabIndex = 37;
            label6.Text = "Satılık";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.ForeColor = Color.Navy;
            label7.Location = new Point(153, 485);
            label7.Name = "label7";
            label7.Size = new Size(48, 20);
            label7.TabIndex = 38;
            label7.Text = "kiralık";
            // 
            // FindRegisterForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            ClientSize = new Size(1184, 662);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(radioButton1);
            Controls.Add(label1);
            Controls.Add(groupBox1);
            Controls.Add(AraButton);
            Controls.Add(isActive);
            Controls.Add(comboBox2);
            Controls.Add(aktif);
            Controls.Add(comboBox1);
            Controls.Add(alanTextBox);
            Controls.Add(tür);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(katNumarasiTextBox);
            Controls.Add(odaSayisiTextBox);
            Controls.Add(listView1);
            Name = "FindRegisterForm";
            Text = "FindRegisterForm";
            Load += FindRegisterForm_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListView listView1;
        private RadioButton isActive;
        private ComboBox comboBox2;
        private Label aktif;
        private ComboBox comboBox1;
        private TextBox alanTextBox;
        private Label tür;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private TextBox katNumarasiTextBox;
        private TextBox odaSayisiTextBox;
        private Button AraButton;
        private RadioButton satilikRD;
        private RadioButton radioButton2;
        private RadioButton kiralikRD;
        private GroupBox groupBox1;
        private RadioButton radioButton1;
        private Label label1;
        private Label label6;
        private Label label7;
    }
}