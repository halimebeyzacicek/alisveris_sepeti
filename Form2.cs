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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        public string gidecek_ad=" ";//Form1'e gönderilecek ürünün adı.
        public string gidecek_b_fiyat = " ";//Form1'e gönderilecek ürünün birim fiyatı.
        string tl = "₺";//Para biriminin yanina tl.
        public Form1 frm1;//Form1'e ulaşmak için.
        
        private void Form2_Load(object sender, EventArgs e)//Form2 ilk kez görüntülenmeden önce oluşur.
        {

            this.tbl_AntikalarTableAdapter.Fill(this.dbo_antikaDataSet.Tbl_Antikalar);//Veri tabanını alıyoruz.
           
            ad.ReadOnly = true;//Bu Text_Box'lara yazma yapılmasını istemiyoruz.
            yas.ReadOnly = true;
            malzeme.ReadOnly = true;
            ulke.ReadOnly = true;
            b_fiyat.ReadOnly = true;
        }

        private void sec_buton_Click(object sender, EventArgs e)
        {
            Form1 frm1 = (Form1)Application.OpenForms["Form1"];//Açık olan Form1'i gösteriyoruz.
            
            frm1.secilenler.Add("1");//Secilenler Listesinin boyuyla ilgili aşağıda işlem yaptığımız için ilk balta boş olamaz bundan dolayı bir eleman koyuyoruz.//Yani dolas zaten baslangıç olarak sıfır. Eğer bu(frm1.secilenler.Count) da sıfır olursa//bu ifade hatalı olur----->"dolas < frm1.secilenler.Count"
            
            int kontrol_2 = 0;//Birinci if'de sürekli kalmamak için kotrol amaçlı.
            int kontrol_3 = 0;

            for (int dolas = 0; dolas < frm1.secilenler.Count; dolas++)//Secilenler kadar dolaşıcam. Çünkü Seçilenler Listesi içinde şimdi seçtiğim var mı diye bakıcam. 
            {
                if (ad.Text == frm1.secilenler[dolas] && kontrol_2 == 0)//Eğer Secilenler içinde seçtiğim ürünün adı varsa Hata mesajı gösterilecek. //Burada kontrol_2 sürekli bu if içerisine girmeyi engelliyor. Eğer sürekli girilirse ekranda hep messageBox görülecek.
                {
                    kontrol_2 += 1;
                    MessageBox.Show("Bu Ürünü Zaten Seçtiniz!");
                    kontrol_3 = 2;//Burada amaç tekrar2 nin değerini değiştirmek.Eğer değişmezse hem bu if'e hem alttaki if'e girer.(İlk buraya girip sonra girmezse ve alttaki if e girerse)Bu istemiyorum //Eğer birinci if'e girmezse ikincisine girmesini istiyorum. //bu if içerisinde kontrol_2 i değiştirediğimiz için buraya değil alttaki ife girip seçilen ürün yüne seçilebilir.//(for olduğu için bu if bir çok kez kontrol ediliyor bir kere kotrol edilip çıkılmıyor.)Bundan dolayı kontrol_3 var.
                }
            }
            if (kontrol_3 == 0)//Eğer Birinci if'e girilmediyse buraya girmek istiyorum..Bunu kontrol_3'ün değişip değişmemesiyle anlıyoruz. //Bu if içerisinde form1'e gönderme işlemleri vs. yapılacak. 
            {
                if (ad.Text != "")//Eğer ürün seçmeden seçe basarsak ""-> bu secilenler listesine eklenecek(yani boşluk karakteri)
                {
                    frm1.secilen.Text = this.ad.Text;//Gönderilecek ürünün adi Form1'de yer alan secilen_list_box'ına yazılır.

                    frm1.secilenler.Add(ad.Text);//Gönderilecek ürün adi seçilenler listesine eklenir.

                    frm1.birim_fiyat_label.Text = b_fiyat.Text;//Gönderilecek ürünün birim fiyati Form1'de yer alan birim_fiyat_list_box'ına yazılır.
                }
                if (ad.Text == "")//Eğer (hiç bir ürün seçmeden seçe basılırsa)bir şey seçilmediyse yani ad text box'i boşsa aşağıdakileri yap.
                {
                    frm1.secilen.Text = "?";
                    frm1.birim_fiyat_label.Text = "?";
                }
                Application.OpenForms["Form1"].Show();//Açık olan Form1'i gösteriyoruz.
                Hide();//Bu Form2'yi saklıyoruz.
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)//DataGRidView1'de herhangi bir hücreye basınca bunlar olsun. 
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;//DataGRidView1'in seçilen hücrelerinin sıfırıncı indexin row index'ini secilene at.
            //Herhangi bir hücreye tıkladığımda bu hücrenin satır index'ini secilen değişkenine atadım.

            ad.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();//Secilenin adını "ad" isimli text_box'a yazdırıyoruz.(Alttakilerde aynı şekilde.)
            yas.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            malzeme.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            ulke.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            b_fiyat.Text = dataGridView1.Rows[secilen].Cells[5].Value.ToString()+tl;//tl'yi de ekliyorum.

            pictureBox1.ImageLocation = dataGridView1.Rows[secilen].Cells[6].Value.ToString();//Resmin picture_box'da görünmesini sağlıyoruz.
        }
        
        private void geri_don_button_Click(object sender, EventArgs e)
        {
            Application.OpenForms["Form1"].Show();//Açık olan Form1'i gösteriyoruz.
            Hide();//Bu Form2'yi saklıyoruz. 
        }
    }
}
