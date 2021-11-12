// BİLİMSEL HESAP MAKİNASININ FORMU //
////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//Ayşenur ÖZTÜRK
//200707037
//2.sınıf güz dönemi
//Görsel programlama
///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace calculator
{
    public partial class BİLİMSEL : Form
    {
        //global olarak tanımlanmış değerler 
        //bir çok butonda ortak olarak kullanılacaklar 
        double sayi1;
        string ıslem;
        public BİLİMSEL()
        {
            InitializeComponent();
        }
        private void button_gecmis_Click(object sender, EventArgs e)
        {
            listBox1.Visible = true;//listbox görünür hale gelir 
           //formun yüksekliğini ve genişliğini açılan listBox1 e göre ayarlar
            this.Width = 702;
            this.Height = 635;
        }
        public void yazi(int rakam)
        {
            string yazii = rakam.ToString();//int olarak alınan değeri stringe cevirir 
            if (textBox1.Text == "0" && textBox1.Text == null)//textbox1 de hiçbir şey yazmıyorsa ya da 0 değeri var ise
            {
                textBox1.Text = yazii;//texbox1 parametre olarak aldığımız değere eşitler
            }
            else
            {
                textBox1.Text += yazii;//değilse textbox1 deki değeri aldığımız parametreyi ekler böylece 
                                       // 11 222 3333 gibi aynı ifadeleri peşpeşe kullanabiliriz 
            }
        }

        //////////////////////////////////////////////////////////////////////////////////////////
        // rakam butonlarına basıldığında değeri yazdırabilmek için
        private void button_0_Click(object sender, EventArgs e)
        {
            yazi(0);
        }

        private void button_1_Click(object sender, EventArgs e)
        {
            yazi(1);
        }

        private void button_2_Click(object sender, EventArgs e)
        {
            yazi(2);
        }

        private void button_3_Click(object sender, EventArgs e)
        {
            yazi(3);
        }

        private void button_4_Click(object sender, EventArgs e)
        {
            yazi(4);
        }

        private void button_5_Click(object sender, EventArgs e)
        {
            yazi(5);
        }

        private void button_6_Click(object sender, EventArgs e)
        {
            yazi(6);
        }

        private void button_7_Click(object sender, EventArgs e)
        {
            yazi(7);
        }

        private void button_8_Click(object sender, EventArgs e)
        {
            yazi(8);
        }

        private void button_9_Click(object sender, EventArgs e)
        {
            yazi(9);
        }
        //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        // Dört temel işlemin butonları için
        // aynı zamanda sayi1 buarada alınır ve bu değer elde tutulur
        public void ıslemler()
        {
            sayi1 = Convert.ToDouble(textBox1.Text);//numara değeri texbox1 deki değere dönüştürelerek eşitlenir
            textBox2.Text = sayi1 + ıslem;//textBox2 deki değeri sayi1 ve işlem değeri ile birleştirip yazar
            textBox1.Text = "";//textbox1 temzilenmesi için
        }
        private void button_carpi_Click(object sender, EventArgs e)
        {
            ıslem = "*";//ıslem değişkeninin değeri "*" eşitlenir 
            if (textBox1.Text == "")//eğer textBox1 içi boş ise
            {
                sayi1 = 0;//sayi1 değeri 0 olur
                textBox2.Text = sayi1 + ıslem;
            }
            else//değilse
                ıslemler();//fonksiyonu çağrılır ve gerekli işlemler yapılır
        }

        private void button_eksi_Click(object sender, EventArgs e)
        {
            ıslem = "-";//ıslem değişkeninin değeri "-" eşitlenir 
            if (textBox1.Text == "")//eğer textBox1 içi boş ise
            {
                sayi1 = 0;//sayi1 değeri 0 olur 
                textBox2.Text = sayi1 + ıslem;
            }
            else//değilse
                ıslemler();//fonksiyonu çağrılır ve gerekli işlemler yapılır
        }

        private void button_arti_Click(object sender, EventArgs e)
        {
            ıslem = "+";//ıslem değişkeninin değeri "+" eşitlenir 
            if (textBox1.Text == "")//eğer textBox1 içi boş ise
            {
                sayi1 = 0;//sayi1 değeri 0 olur
                textBox2.Text = sayi1 + ıslem;
            }
            else//değilse
                ıslemler();//fonksiyonu çağrılır ve gerekli işlemler yapılır
        }
        private void button2_Click(object sender, EventArgs e)
        {
            ıslem = "/";//ıslem değişkeninin değeri "/" eşitlenir 
            if (textBox1.Text == "")//eğer textBox1 içi boş ise
            {
                sayi1 = 0;//sayi1 değeri 0 olur
                textBox2.Text = sayi1 + ıslem;
            }
            else//değilse
                ıslemler();//fonksiyonu çağrılır ve gerekli işlemler yapılır
        }
        //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        //eşittir butonu ile sayi2 değeri alınır ve ıslem değişkeninin değerine göre işleme tabi tutulur
        private void button_esittir_Click(object sender, EventArgs e)
        {
            double sayi2;
            double sonuc;
            //eğer textBox2 boş ise yani sayi1 sadece alındıysa ve eşittir butonuna basıldıysa
            // misal 3=3 6=6 diyebilmek için 
            if (textBox2.Text == "")
            {
                textBox2.Text = Convert.ToString(textBox1.Text + "=");//textbox1 deki değeri textbox2 ye yaz
            }
            if (ıslem == "+")//eğer islem değeri "+" ise 
            {
                sayi2 = Convert.ToDouble(textBox1.Text);//sayi2 değeri alınır textBox1 den 
                //burada say1 değeri girilmez ve direk "+" operatörüne tıklanırsa sayi1 değerini 0 olarak kabul edilerek 
                //sayi2 ile öyle işleme girmesi için olan if kodları 
                if (textBox2.Text == "0+")
                {
                    sonuc = 0 + sayi2;
                    textBox2.Text = Convert.ToString(0 + "+" + sayi2 + "=");
                }
                else// değilse
                {
                   //toplama işlemi yapılarak textBox2 de işlemler yazılı olarak gösterilir 
                    sonuc = sayi1 + sayi2;
                    textBox2.Text = Convert.ToString(sayi1 + "+" + sayi2 + "=");
                }
                textBox1.Text = Convert.ToString(sonuc);
                listBox1.Items.Add(textBox2.Text + sonuc);//geçmiş kısmıda yapılan işlemler kaydedilemsi için listeye eklenir
            }
            else if (ıslem == "-")
            {
                sayi2 = Convert.ToDouble(textBox1.Text);//sayi2 değeri alınır textBox1 den 
                //burada say1 değeri girilmez ve direk "-" operatörüne tıklanırsa sayi1 değerini 0 olarak kabul edilerek 
                //sayi2 ile öyle işleme girmesi için olan if kodları 
                if (textBox2.Text == "0-")
                {
                    sonuc = 0 - sayi2;
                    textBox2.Text = Convert.ToString(0 + "-" + sayi2 + "=");
                }
                else
                {
                    //çıkarma işlemi yapılarak textBox2 de işlemler yazılı olarak gösterilir 
                    sonuc = sayi1 - sayi2;
                    textBox2.Text = Convert.ToString(sayi1 + "-" + sayi2 + "=");
                }
                textBox1.Text = Convert.ToString(sonuc);
                listBox1.Items.Add(textBox2.Text + sonuc);//geçmiş kısmıda yapılan işlemler kaydedilemsi için listeye eklenir
            }
            else if (ıslem == "*")
            {
                sayi2 = Convert.ToDouble(textBox1.Text);//sayi2 değeri alınır textBox1 den 
                 //burada say1 değeri girilmez ve direk "*" operatörüne tıklanırsa sayi1 değerini 0 olarak kabul edilerek 
                //sayi2 ile öyle işleme girmesi için olan if kodları 
                if (textBox2.Text == "0*")
                {
                    sonuc = 0 * sayi2;
                    textBox2.Text = Convert.ToString(0 + "*" + sayi2 + "=");
                }
                else
                {
                    //çarpma işlemi yapılarak textBox2 de işlemler yazılı olarak gösterilir 
                    sonuc = sayi1 * sayi2;
                    textBox2.Text = Convert.ToString(sayi1 + "*" + sayi2 + "=");
                }
                textBox1.Text = Convert.ToString(sonuc);
                listBox1.Items.Add(textBox2.Text + sonuc);//geçmiş kısmıda yapılan işlemler kaydedilemsi için listeye eklenir
            }
          else  if (ıslem == "/")
          {
                //burada say1 değeri girilmez ve direk "/" operatörüne tıklanırsa sayi1 değerini 0 olarak kabul edilerek 
                //sayi2 ile öyle işleme girmesi için olan if kodları 
                sayi2 = Convert.ToDouble(textBox1.Text);//sayi2 değeri alınır textBox1 den 
                if (textBox2.Text == "0/")
                {
                    sonuc = 0 / sayi2;
                    textBox2.Text = Convert.ToString(0 + "/" + sayi2 + "=");
                }
                else
                {
                    //bölme işlemi yapılarak textBox2 de işlemler yazılı olarak gösterilir 
                    sonuc = sayi1 / sayi2;
                    textBox2.Text = Convert.ToString(sayi1 + "/" + sayi2 + "=");
                }
                textBox1.Text = Convert.ToString(sonuc);
                listBox1.Items.Add(textBox2.Text + sonuc);//geçmiş kısmıda yapılan işlemler kaydedilemsi için listeye eklenir
          }
            //üssünü alırken kullanıyoruz button_x_n_Click devamı olan işlemler olarak düşünülebilir
            else
            {
                sayi2 = Convert.ToDouble(textBox1.Text);//sayi2 değeri alınır textBox1 den 
                textBox2.Text= sayi1 + "^"+sayi2+"=";
                textBox1.Text = Convert.ToString(Math.Pow(sayi1,sayi2));//
                listBox1.Items.Add(textBox2.Text + textBox1.Text);//geçmiş kısmıda yapılan işlemler kaydedilemsi için listeye eklenir
            }

        }
        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        //temizlmek için
        private void button_geri_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }
        //temizlik için olan buton 
        private void button_C_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
        }
        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        //math kütüphanesinden log10 nesnesi ile logaritmada 10 tabanında işlem yapmak için 
        private void button_log_Click(object sender, EventArgs e)
        {
            sayi1 = Convert.ToDouble(textBox1.Text);//numara değeri texbox1 deki değere dönüştürelerek eşitlenir
            textBox2.Text = "log" + "("+sayi1+")";
            textBox1.Text = Convert.ToString(Math.Log10(sayi1));//
            listBox1.Items.Add(textBox2.Text + "=" + textBox1.Text);//geçmiş kısmıda yapılan işlemler kaydedilemsi için listeye eklenir
        }
         //math kütüphanesinden ln nesnesi ile logaritmada e tabanında işlem yapmak için
        private void button_ln_Click(object sender, EventArgs e)
        {
            sayi1 = Convert.ToDouble(textBox1.Text);//numara değeri texbox1 deki değere dönüştürelerek eşitlenir
            textBox2.Text = "ln" + "(" + sayi1 + ")";
            textBox1.Text = Convert.ToString(Math.Log(sayi1));
            listBox1.Items.Add(textBox2.Text + "=" + textBox1.Text);//geçmiş kısmıda yapılan işlemler kaydedilemsi için listeye eklenir
        }
        //sayının karesini alka için olan kodlar
        private void button_x_kare_Click(object sender, EventArgs e)
        {
            sayi1 = Convert.ToDouble(textBox1.Text);//numara değeri texbox1 deki değere dönüştürelerek eşitlenir
            textBox2.Text = "sqr(" + sayi1 + ")";
            textBox1.Text = Convert.ToString(sayi1 * sayi1);
            listBox1.Items.Add(textBox2.Text + "=" + textBox1.Text);//geçmiş kısmıda yapılan işlemler kaydedilemsi için listeye eklenir
        }
        // sayi1 üssü sayi2 olarak işlem yapmak için
        private void button_x_n_Click(object sender, EventArgs e)
        {

            sayi1 = Convert.ToDouble(textBox1.Text);
            textBox2.Text = sayi1 + "^" ;
            textBox1.Text = "";
        }
        //math kütüphanesinden sin nesnesi ile sinis değerini hesaplamak için
        private void button_sin_Click(object sender, EventArgs e)
        {
            sayi1 = Convert.ToDouble(textBox1.Text);//numara değeri texbox1 deki değere dönüştürelerek eşitlenir
            textBox2.Text = "sin(" + sayi1 + ")";
            textBox1.Text = Convert.ToString(Math.Sin(sayi1*(Math.PI/180)));
            listBox1.Items.Add(textBox2.Text + "=" + textBox1.Text);//geçmiş kısmıda yapılan işlemler kaydedilemsi için listeye eklenir
        }
        //math kütüphanesinden cos nesnesi ile cosinüs değerini hesaplamak için
        private void button_cos_Click(object sender, EventArgs e)
        {
            sayi1 = Convert.ToDouble(textBox1.Text);//numara değeri texbox1 deki değere dönüştürelerek eşitlenir
            textBox2.Text = "cos(" + sayi1 + ")";
            textBox1.Text = Convert.ToString(Math.Cos(sayi1 * (Math.PI / 180)));
            listBox1.Items.Add(textBox2.Text + "=" + textBox1.Text);//geçmiş kısmıda yapılan işlemler kaydedilemsi için listeye eklenir
        }
        //math kütüphanesinden tan nesnesi ile tanjant değerini hesaplamak için
        private void button_tan_Click(object sender, EventArgs e)
        {
            sayi1 = Convert.ToDouble(textBox1.Text);//numara değeri texbox1 deki değere dönüştürelerek eşitlenir
            textBox2.Text = "tan(" + sayi1 + ")";
            textBox1.Text = Convert.ToString(Math.Tan(sayi1 * (Math.PI / 180)));
            listBox1.Items.Add(textBox2.Text + "=" + textBox1.Text);//geçmiş kısmıda yapılan işlemler kaydedilemsi için listeye eklenir
        }
        //math kütüphanesinden tan nesnesi ile cotanjant(1/tanjant) değerini hesaplamak için
        private void button_cot_Click(object sender, EventArgs e)
        {
            sayi1 = Convert.ToDouble(textBox1.Text);//numara değeri texbox1 deki değere dönüştürelerek eşitlenir
            textBox2.Text = "cot(" + sayi1 + ")";
            textBox1.Text = Convert.ToString(1/Math.Tan(sayi1 * (Math.PI / 180)));
            listBox1.Items.Add(textBox2.Text + "=" + textBox1.Text);//geçmiş kısmıda yapılan işlemler kaydedilemsi için listeye eklenir
        }
        //faktöriyel hesaplamak için 
        private void button_faktoriyel_Click(object sender, EventArgs e)
        {
            double faktoriyel = 1;
            sayi1 = Convert.ToDouble(textBox1.Text);//numara değeri texbox1 deki değere dönüştürelerek eşitlenir
            textBox2.Text = sayi1 + "!";//yazımı güzelleştirmek için
            for (int i = 1; i <= sayi1; i++)//girilen sayi1 değerine kadar giden bir for 
            {
                faktoriyel *= i;//her i değerinde tek tek çarpılarak faktoriyel değerine eşitler
            }
            textBox1.Text = Convert.ToString(faktoriyel);
            listBox1.Items.Add(textBox2.Text + "=" + textBox1.Text);//geçmiş kısmıda yapılan işlemler kaydedilemsi için listeye eklenir
        }
        // abs butonu negatif sayıları pozitif
        //pozitifler negatifleşir
        private void button_abs_Click(object sender, EventArgs e)
        {
            double abs;
            sayi1 = Convert.ToDouble(textBox1.Text);
            abs = sayi1 * -1;
            textBox1.Text = Convert.ToString(abs);
        }
        //gilirlen sayıyı ondalıklı hale getirir
        private void button_virgul_Click(object sender, EventArgs e)
        {
            string ondalık;
            sayi1 = Convert.ToDouble(textBox1.Text);
            ondalık = Convert.ToString(sayi1 + ",");
            textBox1.Text = ondalık;
        }
        //math kütüphanesinden sqrt nesnesi ile sayının karekökünü alarak işlem yapmak için
        private void button_kok_Click(object sender, EventArgs e)
        {
            sayi1 = Convert.ToDouble(textBox1.Text);//numara değeri texbox1 deki değere dönüştürelerek eşitlenir
            textBox2.Text = "√" + sayi1;
            textBox1.Text = Convert.ToString(Math.Sqrt(sayi1));
            listBox1.Items.Add(textBox2.Text + "=" + textBox1.Text);//geçmiş kısmıda yapılan işlemler kaydedilemsi için listeye eklenir
        }
        //comBox1 ile yapılan seçimlerle formlar arası geçiş sağlanır
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text=="Standart")
            {
                Standart f1 = new Standart();
                f1.Show();// form1 gösterir 
                this.Hide(); // açık olan formu gizle 
            }
            if (comboBox1.Text=="Bilimsel")
            {
                BİLİMSEL f2 = new BİLİMSEL();
                f2.Show();// BİLİMSEL formunu gösterir 
                this.Hide(); // açık olan formu gizle 
            }
            if (comboBox1.Text == "Tarihler arasındaki fark")
            {
                Form2 f2 = new Form2();
                f2.Show();// form2 gösterir 
                this.Hide();// açık olan formu gizle
            }
        }
        //euler sayısını kullanmak için olan kod
        private void button20_Click(object sender, EventArgs e)
        {
            double euler;
            euler = 2.7182818284590452;
            textBox1.Text = Convert.ToString(euler);
        }
        //pi sayısı için olan kod
        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = Convert.ToString(Math.PI);//math kütüphanesinin pi nesnesi
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void BİLİMSEL_Load(object sender, EventArgs e)
        {

        }

        private void button_standart_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
