using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DelegateEvents_calisma
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        


        private void btn_ekle_Click(object sender, EventArgs e)
        {
            Ogrenci o = new Ogrenci();

            o.Adi = txt_adi.Text;
            o.Soyadi = txt_soyadi.Text;
            o.Gecti += O_Gecti;
            o.Kaldi += O_Kaldi;
            o.Final += Convert.ToDouble(txt_final.Text);
            o.Vize += Convert.ToDouble(txt_vize.Text);

            lst_ogrenci_listesi.Items.Add(o);

        }
        private void O_Kaldi(object sender, GectiKaldiErguman e)
        {
            lst_gecenler.Items.Remove(e.AdiSoyadi);
            lst_Kalanlar.Items.Remove(e.AdiSoyadi);
            lst_Kalanlar.Items.Add(e.AdiSoyadi);
        }

        private void O_Gecti(object sender, GectiKaldiErguman e)
        {
            lst_Kalanlar.Items.Remove(e.AdiSoyadi);
            lst_gecenler.Items.Remove(e.AdiSoyadi);
            lst_gecenler.Items.Add(e.AdiSoyadi);
        }

        private void lst_ogrenci_listesi_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lst_ogrenci_listesi.SelectedItem == null) return;
            Ogrenci secili = (Ogrenci)lst_ogrenci_listesi.SelectedItem;
            txt_adi.Text = secili.Adi;
            txt_soyadi.Text = secili.Soyadi;
            txt_final.Text = secili.Final.ToString();
            txt_vize.Text = secili.Vize.ToString();




        }

        private void btn_guncelle_Click(object sender, EventArgs e)
        {
            Ogrenci guncelle = new Ogrenci();
            guncelle.Adi = txt_adi.Text;
            guncelle.Soyadi = txt_soyadi.Text;
            guncelle.Vize = Convert.ToDouble(txt_vize.Text);
            guncelle.Final = Convert.ToDouble(txt_final.Text);
            lst_ogrenci_listesi.Items.Add(guncelle);
                
        }
    }
    
}
