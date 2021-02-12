using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace staj_3
{
    public partial class Form1 : Form
    {
        public Form2 frm2;//Form 2'ye ulaşmak için.
        public Form4 frm4;//Form 4'e ulaşmak için.
        int sepet_toplami = 0;//Sepetteki ürünlerin toplam fiyatı.
        string tl = "₺";//Para biriminin yanina tl.
        public List<string> secilenler = new List<string>();//Form1'e taşınan ürünlerin bulunduğu liste.

        public Form1()
        {
            InitializeComponent();
        }

        int adet;//Ürünün adet.
        int urun_tutar;//birim fiyat ile adet çarpımı.

        private void button1_Click(object sender, EventArgs e)//Ürün_Seç butonu.
        {
            Form2 frm2 = new Form2();//Form 2'yi açıyoruz.(Yeni bir Form2 oluşturarak.)

            frm2.Show();
            Hide();//Bu Formu gizle.
        }
      
        private void Form1_Load(object sender, EventArgs e)//Form1 ilk kez görüntülenmeden önce oluşur.
        {
            //this.FormBorderStyle = FormBorderStyle.FixedSingle;//boyutlamamak için
            toplam.ReadOnly = true;//Sepet toplamının yazıldığı tbox. 
        }

        private void sepete_ekle_buton_Click(object sender, EventArgs e)
        {
             try//Eğer birim_fiyat_label'i boşsa Form2'den ürün seçilmemiş demektir.(Hata) Ürün seçiniz uyarısı yapılacak.  //Aslında burada hatanın nedeni Form2'den bir şey gelmediği için birim_fiyat_label'da yazan "?" nin int'e dönüştürülememesi. 
             {
                urun_tutar = (Convert.ToInt32(birim_fiyat_label.Text.Remove(birim_fiyat_label.Text.Length - 1))) ;

                try//Eğer adet_gir_text_box'i boşsa.(Hata) Adet Girin uyarısı yapılacak.  //Aslında burada hatanın nedeni ""(boşluk)'un int'e çevrilememesi.
                {
                     adet = Convert.ToInt32(adet_gir_text_box.Text);//Adet bilgisi değişkene atanıyor.(Lazım olacak)
                     if (adet > 15)//(Adetin en fazla 15 seçilmesini istiyoruz.)
                     {
                         MessageBox.Show("Aynı Üründen En Fazla 15 Tane Alabilirsiniz!");
                     }
                     else if (adet == 0)//(Adetin sıfır girilmesini istemiyoruz.)
                     {
                         MessageBox.Show(@"Adet Olarak ""0"" Giremezsiniz!");//@ kullanma nedenimiz, çift tırmak yazmak istiyoruz.
                     }
                     else//iki if'ten de çıkmayı başarabilirse buraya giriyor.
                     {
                        urun_tutar *= adet;//Şuan urun tutarı bulmuş olduk.
                        
                        urun_adi_clb.Items.Add(secilen.Text);//Seçilen ürünün bilgileri checkedlistbox ve listbox'lara ekleniyor.
                        urun_adet_lb.Items.Add(adet); 
                        birim_fiyat_lb.Items.Add(birim_fiyat_label.Text);

                        tutar_lb.Items.Add(Convert.ToString(urun_tutar) + tl);//???Tutar bilgisi listbox'a sonuna tl alarak ekleniyor.

                        adet_gir_text_box.Text = " ";//Her şey eski haline getiriliyor.
                        secilen.Text = "?";
                        birim_fiyat_label.Text = "?";

                        toplam.Text = " ";
                        sepet_toplami += urun_tutar;//Sepet toplamına secilen ürünün fiyatı da ekleniyor.
                        toplam.Text = (Convert.ToString(sepet_toplami) + tl);//Toplam textbox'ı yenileniyor.

                     }
                }
                catch{ MessageBox.Show("Lütfen Adet Giriniz!");}
             }
             catch{MessageBox.Show("Lütfen Ürün Seçiniz!");}
        }

        private void sil_btn_Click(object sender, EventArgs e)
        {
            string secilen_sira_no = urun_adi_clb.SelectedIndex.ToString();//Seçilenin sıra no'su.
            
            if (secilen_sira_no == "-1")//Hiç bir şey seçilmediğinde -1 olduğu için -1 kotrolü yapıyoruz.
            {
                MessageBox.Show("Lütfen Silenecek Ürünü Seçiniz!");
            }
            else
            {
                int secilenkactane = urun_adi_clb.CheckedItems.Count;//checked_list_box'da kaç tane Item seçildiğini buluyoruz.

                if (secilenkactane != 1)//Eğer 1'den farklıysa uyarı veriliyor.Çünkü ürünlerin tek tek silinmesini istiyoruz.
                {
                    MessageBox.Show("Ürünleri Teker Teker Silebilirsiniz!");
                }
                else
                {
                    string sil_secilenin_adi = Convert.ToString(urun_adi_clb.Items[Convert.ToInt32(secilen_sira_no)]);//urun_adi_clb'nin secilen_sira_no'cu ürünü.(Silinmek için secilen ürünün adı.)

                    this.secilenler.Remove(sil_secilenin_adi);//Seçilenler listesinden silmek için seçtiğimizi çıkarıyoruz.
                    
                    urun_adi_clb.Items.RemoveAt(Convert.ToInt32(secilen_sira_no));//Adı,adet,tutar ve birim fiyatıda silicez.
                    urun_adet_lb.Items.RemoveAt(Convert.ToInt32(secilen_sira_no));
                    birim_fiyat_lb.Items.RemoveAt(Convert.ToInt32(secilen_sira_no));

                    tutar_lb.SelectedIndex = (Convert.ToInt32(secilen_sira_no));//Tutar_lb'nin seçilen index'i, secilen_sıra_no olsun diyoruz.                    
                    int silinecek_fiyat_kacinci = tutar_lb.SelectedIndex;//Tutar lbox'ının secileninin kaçıncı olduğunu değişkene atıyoruz. (Silinecek, tutar list box'ının kaçıncı elemanı.)

                    //Not:toplam.Text=Convert.ToString(tutar_lb.Items[a]);-------->tutar labelinin a. elemanını yazma.
                    string tlvefiyat = Convert.ToString(tutar_lb.Items[silinecek_fiyat_kacinci]);//600₺'i tutuyor.(yani 600+tl.)
                    tlvefiyat = tlvefiyat.Remove(tlvefiyat.Length - 1);//eski tlvefiyat'ın son karakterini çıkartıyoruz ve tekrar tlfiyat'a atıyoruz.(600=600-tl)

                    //toplam.Text = " ";

                    sepet_toplami -= Convert.ToInt32(tlvefiyat);//sepet toplamından silinecek ürünün fiyatını çıkartıyoruz.Şuan tlvefiyat'ta 600 var.(600₺ değil)
                    toplam.Text = Convert.ToString(sepet_toplami) + tl;//Toplam_textbox'ının değerini güncelliyoruz.
                    
                    tutar_lb.Items.RemoveAt(Convert.ToInt32(secilen_sira_no));//Silinecek ürünün tutarı siliniyor.
                                                                              //Silmeyi saonra yapıyoruz Çünkü üst kısımda kullanıyoruz.
                }
            }
            
        }

        private void adet_gir_text_box_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8)//Adet_gir_textbox'ına sadece sayı girilmesini istiyoruz.  //e.Keycahar=klavyeden basılan tuş.//IsDigit=Rakam olup olmadığı kontrolü.(Klavyeden basılan tuş sayı değilse demiş olduk.)//Ve klavyeden silme işlemi de yapmak istiyoruz. Bundan dolayı backspace tuşunuda ekliyoruz.(ASCII) 
            {
                e.Handled = true;//Basılan tuşu kabul etme diyoruz.(False olursa kabul et demek.)
            }
        }

        private void odeme_btn_Click(object sender, EventArgs e)
        {
            Form4 frm4 = new Form4();//Form 4'ü açıyoruz.(Yeni bir Form4 oluşturarak.)

            frm4.Show();
            Hide();//Bu Formu gizle.
        }

        private void adet_gir_text_box_TextChanged(object sender, EventArgs e)
        {

        }

        private void toplam_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
