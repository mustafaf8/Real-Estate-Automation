namespace EmlakOtomasyon
{
    partial class Login
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
            button1 = new Button();
            name = new TextBox();
            password = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label5 = new Label();
            label4 = new Label();
            button2 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.LimeGreen;
            button1.Location = new Point(309, 348);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 0;
            button1.Text = "Giriş";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // name
            // 
            name.Location = new Point(309, 211);
            name.Name = "name";
            name.Size = new Size(215, 27);
            name.TabIndex = 2;
            // 
            // password
            // 
            password.Location = new Point(309, 285);
            password.Name = "password";
            password.Size = new Size(215, 27);
            password.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(204, 214);
            label2.Name = "label2";
            label2.Size = new Size(99, 20);
            label2.TabIndex = 4;
            label2.Text = "Kullanıcı Adı :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(257, 288);
            label3.Name = "label3";
            label3.Size = new Size(46, 20);
            label3.TabIndex = 5;
            label3.Text = "Şifre :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Stencil", 25.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.Crimson;
            label5.Location = new Point(114, 72);
            label5.Name = "label5";
            label5.Size = new Size(610, 52);
            label5.TabIndex = 7;
            label5.Text = "NAHSAN MENKUL DEGERLER";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.ForeColor = Color.Red;
            label4.Location = new Point(343, 399);
            label4.Name = "label4";
            label4.Size = new Size(153, 28);
            label4.TabIndex = 8;
            label4.Text = "BİLGİLER HATALI";
            label4.TextAlign = ContentAlignment.TopCenter;
            label4.Visible = false;
            // 
            // button2
            // 
            button2.BackColor = Color.LimeGreen;
            button2.Location = new Point(430, 348);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 9;
            button2.Text = "kayıt Ol";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // Login
            // 
            AllowDrop = true;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = Color.FromArgb(0, 192, 192);
            ClientSize = new Size(824, 524);
            Controls.Add(button2);
            Controls.Add(label4);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(password);
            Controls.Add(name);
            Controls.Add(button1);
            Name = "Login";
            Text = "Giriş Sayfası";
            Load += Giriş_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private TextBox name;
        private TextBox password;
        private Label label2;
        private Label label3;
        private Label label5;
        private Label label4;
        private Button button2;
    }
}
