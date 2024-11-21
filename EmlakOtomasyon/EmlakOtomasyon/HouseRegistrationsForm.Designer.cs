namespace EmlakOtomasyon
{
    partial class HouseRegistrations
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
            columnHeader10 = new ColumnHeader();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            columnHeader5 = new ColumnHeader();
            columnHeader6 = new ColumnHeader();
            columnHeader7 = new ColumnHeader();
            columnHeader8 = new ColumnHeader();
            columnHeader9 = new ColumnHeader();
            SatilikRD = new RadioButton();
            KiralikRD = new RadioButton();
            listView2 = new ListView();
            columnHeader21 = new ColumnHeader();
            columnHeader20 = new ColumnHeader();
            columnHeader11 = new ColumnHeader();
            columnHeader12 = new ColumnHeader();
            columnHeader13 = new ColumnHeader();
            columnHeader14 = new ColumnHeader();
            columnHeader15 = new ColumnHeader();
            columnHeader16 = new ColumnHeader();
            columnHeader17 = new ColumnHeader();
            columnHeader18 = new ColumnHeader();
            columnHeader19 = new ColumnHeader();
            Düzenle = new Button();
            Sil = new Button();
            findRegister = new Button();
            SuspendLayout();
            // 
            // listView1
            // 
            listView1.BackColor = SystemColors.ControlLight;
            listView1.Columns.AddRange(new ColumnHeader[] { columnHeader10, columnHeader1, columnHeader2, columnHeader3, columnHeader4, columnHeader5, columnHeader6, columnHeader7, columnHeader8, columnHeader9 });
            listView1.FullRowSelect = true;
            listView1.Location = new Point(12, 52);
            listView1.MultiSelect = false;
            listView1.Name = "listView1";
            listView1.Size = new Size(1164, 425);
            listView1.TabIndex = 1;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            listView1.SelectedIndexChanged += listView1_SelectedIndexChanged;
            // 
            // columnHeader10
            // 
            columnHeader10.Width = 0;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Oda Sayısı";
            columnHeader1.Width = 150;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Kat Numarası";
            columnHeader2.Width = 150;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Semt";
            columnHeader3.Width = 100;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Alanı";
            columnHeader4.Width = 80;
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "Yapım Tarihi";
            columnHeader5.Width = 150;
            // 
            // columnHeader6
            // 
            columnHeader6.Text = "Türü";
            columnHeader6.Width = 100;
            // 
            // columnHeader7
            // 
            columnHeader7.Text = "Aktif";
            columnHeader7.Width = 80;
            // 
            // columnHeader8
            // 
            columnHeader8.Text = "Emlak Numarası";
            columnHeader8.Width = 150;
            // 
            // columnHeader9
            // 
            columnHeader9.Text = "Fiyat";
            columnHeader9.Width = 100;
            // 
            // SatilikRD
            // 
            SatilikRD.AutoSize = true;
            SatilikRD.Checked = true;
            SatilikRD.Location = new Point(94, 529);
            SatilikRD.Name = "SatilikRD";
            SatilikRD.Size = new Size(70, 24);
            SatilikRD.TabIndex = 2;
            SatilikRD.TabStop = true;
            SatilikRD.Text = "Satılık";
            SatilikRD.UseVisualStyleBackColor = true;
            SatilikRD.CheckedChanged += SatilikRD_CheckedChanged;
            // 
            // KiralikRD
            // 
            KiralikRD.AutoSize = true;
            KiralikRD.Location = new Point(94, 568);
            KiralikRD.Name = "KiralikRD";
            KiralikRD.Size = new Size(71, 24);
            KiralikRD.TabIndex = 3;
            KiralikRD.Text = "Kiralık";
            KiralikRD.UseVisualStyleBackColor = true;
            // 
            // listView2
            // 
            listView2.BackColor = SystemColors.ControlLight;
            listView2.Columns.AddRange(new ColumnHeader[] { columnHeader21, columnHeader20, columnHeader11, columnHeader12, columnHeader13, columnHeader14, columnHeader15, columnHeader16, columnHeader17, columnHeader18, columnHeader19 });
            listView2.FullRowSelect = true;
            listView2.Location = new Point(12, 52);
            listView2.MultiSelect = false;
            listView2.Name = "listView2";
            listView2.Size = new Size(1164, 425);
            listView2.TabIndex = 4;
            listView2.UseCompatibleStateImageBehavior = false;
            listView2.View = View.Details;
            listView2.Visible = false;
            listView2.SelectedIndexChanged += listView2_SelectedIndexChanged;
            // 
            // columnHeader21
            // 
            columnHeader21.Width = 0;
            // 
            // columnHeader20
            // 
            columnHeader20.Text = "Oda Sayısı";
            columnHeader20.Width = 150;
            // 
            // columnHeader11
            // 
            columnHeader11.Text = "Kat Numarası";
            columnHeader11.Width = 150;
            // 
            // columnHeader12
            // 
            columnHeader12.Text = "Semt";
            columnHeader12.Width = 100;
            // 
            // columnHeader13
            // 
            columnHeader13.Text = "Alanı";
            columnHeader13.Width = 80;
            // 
            // columnHeader14
            // 
            columnHeader14.Text = "Yapım Tarihi";
            columnHeader14.Width = 150;
            // 
            // columnHeader15
            // 
            columnHeader15.Text = "Türü";
            columnHeader15.Width = 100;
            // 
            // columnHeader16
            // 
            columnHeader16.Text = "Aktif";
            columnHeader16.Width = 80;
            // 
            // columnHeader17
            // 
            columnHeader17.Text = "Emlak Numarası";
            columnHeader17.Width = 150;
            // 
            // columnHeader18
            // 
            columnHeader18.Text = "Depozito";
            columnHeader18.Width = 100;
            // 
            // columnHeader19
            // 
            columnHeader19.Text = "Kira";
            columnHeader19.Width = 100;
            // 
            // Düzenle
            // 
            Düzenle.BackColor = Color.LimeGreen;
            Düzenle.Location = new Point(479, 529);
            Düzenle.Name = "Düzenle";
            Düzenle.Size = new Size(207, 72);
            Düzenle.TabIndex = 5;
            Düzenle.Text = "Kaydı Düzenle";
            Düzenle.UseVisualStyleBackColor = false;
            Düzenle.Click += Düzenle_Click;
            // 
            // Sil
            // 
            Sil.BackColor = Color.LimeGreen;
            Sil.Location = new Point(739, 529);
            Sil.Name = "Sil";
            Sil.Size = new Size(207, 72);
            Sil.TabIndex = 6;
            Sil.Text = "Kaydı Sil";
            Sil.UseVisualStyleBackColor = false;
            Sil.Click += Sil_Click;
            // 
            // findRegister
            // 
            findRegister.BackColor = Color.LimeGreen;
            findRegister.Location = new Point(248, 529);
            findRegister.Name = "findRegister";
            findRegister.Size = new Size(174, 72);
            findRegister.TabIndex = 7;
            findRegister.Text = "Kayıt Sorgula";
            findRegister.UseVisualStyleBackColor = false;
            findRegister.Click += findRegister_Click;
            // 
            // HouseRegistrations
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            ClientSize = new Size(1186, 660);
            Controls.Add(findRegister);
            Controls.Add(Sil);
            Controls.Add(Düzenle);
            Controls.Add(listView2);
            Controls.Add(KiralikRD);
            Controls.Add(SatilikRD);
            Controls.Add(listView1);
            Name = "HouseRegistrations";
            Text = "Ev Kayıtları";
            Load += EvKayıtları_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ListView listView1;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private ColumnHeader columnHeader6;
        private ColumnHeader columnHeader7;
        private ColumnHeader columnHeader8;
        private ColumnHeader columnHeader9;
        private RadioButton SatilikRD;
        private RadioButton KiralikRD;
        private ListView listView2;
        private ColumnHeader columnHeader10;
        private ColumnHeader columnHeader11;
        private ColumnHeader columnHeader12;
        private ColumnHeader columnHeader13;
        private ColumnHeader columnHeader14;
        private ColumnHeader columnHeader15;
        private ColumnHeader columnHeader16;
        private ColumnHeader columnHeader17;
        private ColumnHeader columnHeader18;
        private ColumnHeader columnHeader19;
        private Button Düzenle;
        private ColumnHeader columnHeader20;
        private ColumnHeader columnHeader21;
        private Button button1;
        private Button Sil;
        private Button findRegister;
    }
}