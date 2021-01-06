namespace DelegateEvents_calisma
{
    partial class Form1
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
            this.btn_ekle = new System.Windows.Forms.Button();
            this.lst_ogrenci_listesi = new System.Windows.Forms.ListBox();
            this.lst_Kalanlar = new System.Windows.Forms.ListBox();
            this.lst_gecenler = new System.Windows.Forms.ListBox();
            this.txt_adi = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_soyadi = new System.Windows.Forms.TextBox();
            this.txt_vize = new System.Windows.Forms.TextBox();
            this.txt_final = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_guncelle = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_ekle
            // 
            this.btn_ekle.Location = new System.Drawing.Point(47, 208);
            this.btn_ekle.Name = "btn_ekle";
            this.btn_ekle.Size = new System.Drawing.Size(93, 39);
            this.btn_ekle.TabIndex = 4;
            this.btn_ekle.Text = "Ekle";
            this.btn_ekle.UseVisualStyleBackColor = true;
            this.btn_ekle.Click += new System.EventHandler(this.btn_ekle_Click);
            // 
            // lst_ogrenci_listesi
            // 
            this.lst_ogrenci_listesi.FormattingEnabled = true;
            this.lst_ogrenci_listesi.ItemHeight = 16;
            this.lst_ogrenci_listesi.Location = new System.Drawing.Point(286, 37);
            this.lst_ogrenci_listesi.Name = "lst_ogrenci_listesi";
            this.lst_ogrenci_listesi.Size = new System.Drawing.Size(178, 324);
            this.lst_ogrenci_listesi.TabIndex = 6;
            this.lst_ogrenci_listesi.SelectedIndexChanged += new System.EventHandler(this.lst_ogrenci_listesi_SelectedIndexChanged);
            // 
            // lst_Kalanlar
            // 
            this.lst_Kalanlar.FormattingEnabled = true;
            this.lst_Kalanlar.ItemHeight = 16;
            this.lst_Kalanlar.Location = new System.Drawing.Point(70, 422);
            this.lst_Kalanlar.Name = "lst_Kalanlar";
            this.lst_Kalanlar.Size = new System.Drawing.Size(178, 260);
            this.lst_Kalanlar.TabIndex = 7;
            // 
            // lst_gecenler
            // 
            this.lst_gecenler.FormattingEnabled = true;
            this.lst_gecenler.ItemHeight = 16;
            this.lst_gecenler.Location = new System.Drawing.Point(286, 422);
            this.lst_gecenler.Name = "lst_gecenler";
            this.lst_gecenler.Size = new System.Drawing.Size(178, 260);
            this.lst_gecenler.TabIndex = 8;
            // 
            // txt_adi
            // 
            this.txt_adi.Location = new System.Drawing.Point(82, 19);
            this.txt_adi.Name = "txt_adi";
            this.txt_adi.Size = new System.Drawing.Size(140, 22);
            this.txt_adi.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 17);
            this.label1.TabIndex = 9;
            this.label1.Text = "Adı ";
            // 
            // txt_soyadi
            // 
            this.txt_soyadi.Location = new System.Drawing.Point(82, 56);
            this.txt_soyadi.Name = "txt_soyadi";
            this.txt_soyadi.Size = new System.Drawing.Size(140, 22);
            this.txt_soyadi.TabIndex = 1;
            // 
            // txt_vize
            // 
            this.txt_vize.Location = new System.Drawing.Point(83, 94);
            this.txt_vize.Name = "txt_vize";
            this.txt_vize.Size = new System.Drawing.Size(86, 22);
            this.txt_vize.TabIndex = 2;
            // 
            // txt_final
            // 
            this.txt_final.Location = new System.Drawing.Point(85, 144);
            this.txt_final.Name = "txt_final";
            this.txt_final.Size = new System.Drawing.Size(86, 22);
            this.txt_final.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 17);
            this.label2.TabIndex = 10;
            this.label2.Text = "Soyadı";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 17);
            this.label3.TabIndex = 11;
            this.label3.Text = "Vize";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(34, 149);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 17);
            this.label4.TabIndex = 12;
            this.label4.Text = "Final";
            // 
            // btn_guncelle
            // 
            this.btn_guncelle.Location = new System.Drawing.Point(162, 208);
            this.btn_guncelle.Name = "btn_guncelle";
            this.btn_guncelle.Size = new System.Drawing.Size(86, 39);
            this.btn_guncelle.TabIndex = 5;
            this.btn_guncelle.Text = "Güncelle";
            this.btn_guncelle.UseVisualStyleBackColor = true;
            this.btn_guncelle.Click += new System.EventHandler(this.btn_guncelle_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(115, 392);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 17);
            this.label5.TabIndex = 13;
            this.label5.Text = "Kalanlar";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(304, 392);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 17);
            this.label6.TabIndex = 14;
            this.label6.Text = "Geçenler";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(308, 14);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(102, 17);
            this.label7.TabIndex = 15;
            this.label7.Text = "Ögrenci Listesi";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(521, 737);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_adi);
            this.Controls.Add(this.txt_soyadi);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txt_vize);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_final);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btn_guncelle);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lst_gecenler);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lst_Kalanlar);
            this.Controls.Add(this.lst_ogrenci_listesi);
            this.Controls.Add(this.btn_ekle);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_ekle;
        private System.Windows.Forms.ListBox lst_ogrenci_listesi;
        private System.Windows.Forms.ListBox lst_Kalanlar;
        private System.Windows.Forms.ListBox lst_gecenler;
        private System.Windows.Forms.TextBox txt_adi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_soyadi;
        private System.Windows.Forms.TextBox txt_vize;
        private System.Windows.Forms.TextBox txt_final;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_guncelle;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}

