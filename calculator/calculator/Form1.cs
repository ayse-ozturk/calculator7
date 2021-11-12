// STANDART HESAP MAKİNASININ FORMU //
////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//Ayşenur ÖZTÜRK
//200707037
//2.sınıf güz dönemi
//Görsel programlama
////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace calculator
{
    public partial class Standart : Form
    {   //global olarak tanımlanmış değerler 
        //bir çok butonda ortak olarak kullanılacaklar 
        double sayi1;
        string ıslem;
        public Standart()
        {
            InitializeComponent();

        }
        public void ıslemler()
        {    
            sayi1 = Convert.ToDouble(textBox1.Text);//sayi1 değerini texbox1 deki değere dönüştürelerek eşitler
            textBox2.Text = sayi1 + ıslem;//textBox2 deki değeri sayi1 ve işlem değeri ile birleştirip yazar
            textBox1.Text = "";//textbox1 temzilenmesi için
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
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
        //////////////////////////////////////////////////////////////////////////////////////////
        // rakam butonlarına basıldığında değeri yazdırabilmek için
        private void button_0_Click(object sender, EventArgs e)
        {
            yazi(0);
        }
        private void button3_Click_1(object sender, EventArgs e)
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

        private void button4_Click(object sender, EventArgs e)
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
        //////////////////////////////////////////////////////////////////////////////////////////////
        // Dört temel işlemin butonları için
        // aynı zamanda sayi1 buarada alınır ve bu değer elde tutulur
        private void eksi_Click(object sender, EventArgs e)
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

        private void arti_Click(object sender, EventArgs e)
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

        private void bolu_Click(object sender, EventArgs e)
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

        private void button3_Click(object sender, EventArgs e)
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
        ////////////////////////////////////////////////////////////////////////////////////////////////////////////
        private void button_bir_bolu_x_Click(object sender, EventArgs e)
        {
            
            sayi1 = Convert.ToDouble(textBox1.Text);//numara değeri texbox1 deki değere dönüştürelerek eşitlenir
            textBox2.Text = "1/" + sayi1;//yazımı güzellşetirmek için
            textBox1.Text =Convert.ToString( 1/(sayi1));//sayi1 değeri bölülü olarak yazılır ve stringe cevrilip textBox1 yazılır 
            listBox1.Items.Add(textBox2.Text+"="+textBox1.Text);//geçmiş kısmıda yapılan işlemler kaydedilemsi için listeye eklenir
        }
        private void button_x_kare_Click(object sender, EventArgs e)
        {
            sayi1 = Convert.ToDouble(textBox1.Text);//numara değeri texbox1 deki değere dönüştürelerek eşitlenir
            textBox2.Text = "sqr(" + sayi1+")";
            textBox1.Text = Convert.ToString(sayi1*sayi1);//ifadenin karesi alınır ve stringe cevrilerek textBox1 yazılır
            listBox1.Items.Add(textBox2.Text + "="+textBox1.Text);//geçmiş kısmıda yapılan işlemler kaydedilemsi için listeye eklenir
        }
        private void button_iki_kok_Click(object sender, EventArgs e)
        {
            sayi1 = Convert.ToDouble(textBox1.Text);//numara değeri texbox1 deki değere dönüştürelerek eşitlenir
            textBox2.Text = "√" + sayi1 ;
            textBox1.Text = Convert.ToString(Math.Sqrt(sayi1));//math kütüphanesinden sqrt kök alır ve stirnge cevirerek yazdırır
            listBox1.Items.Add(textBox2.Text +"="+ textBox1.Text);//geçmiş kısmıda yapılan işlemler kaydedilemsi için listeye eklenir
        }
        //eşittir butonu ile sayi2 değeri alınır ve ıslem değişkeninin değerine göre işleme tabi tutulur  
        private void button6_Click(object sender, EventArgs e)
        {
            double sayi2; 
            double sonuc;
            //eğer textBox2 boş ise yani sayi1 sadece alındıysa ve eşittir butonuna basıldıysa
            // misal 3=3 6=6 diyebilmek için 
            if (textBox2.Text == "")
            {
                textBox2.Text = Convert.ToString(textBox1.Text + "=");//textbox1 deki değeri textbox2 ye yaz
            }
            if (ıslem=="+")//eğer islem değeri "+" ise 
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
            if (ıslem == "-")
            {
                sayi2 = Convert.ToDouble(textBox1.Text);//sayi2 değeri alınır textBox1 den 
                //burada say1 değeri girilmez ve direk "-" operatörüne tıklanırsa sayi1 değerini 0 olarak kabul edilerek 
                //sayi2 ile öyle işleme girmesi için olan if kodları 
                if (textBox2.Text=="0-")
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
            if (ıslem == "*")
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
            if (ıslem == "/")
            {
                sayi2 = Convert.ToDouble(textBox1.Text);//sayi2 değeri alınır textBox1 den 
                //burada say1 değeri girilmez ve direk "/" operatörüne tıklanırsa sayi1 değerini 0 olarak kabul edilerek 
                //sayi2 ile öyle işleme girmesi için olan if kodları 
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
        }
        //temizlemek için
        private void c_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";//textBox1 temizle
            textBox2.Text = ""; //textBox2 temizle
        }
        //textbox1 temizlmek için
        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }
        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Visible = true;//listbox görünür hale gelir 
          //formun yüksekliğini ve genişliğini açılan listBox1 e göre ayarlar
            this.Width = 702;
            this.Height = 635;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        // abs butonu negatif sayıları pozitif
        //pozitifler negatifleşir
        private void button_abs_Click(object sender, EventArgs e)
        {
            double abs;
            sayi1 = Convert.ToDouble(textBox1.Text);
            abs= sayi1* -1;
            textBox1.Text = Convert.ToString(abs);
        }
        //temizlemek için
        private void button_CE_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }
        //gilirlen sayıyı ondalıklı hale getirir
        private void button_virgul_Click(object sender, EventArgs e)
        {
            string ondalık;
            sayi1 = Convert.ToDouble(textBox1.Text);
            ondalık = Convert.ToString(sayi1+",");
            textBox1.Text = ondalık;
        }
        //comBox1 ile yapılan seçimlerle formlar arası geçiş sağlanır
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Standart")
            {
                Standart f1 = new Standart();
                f1.Show();// form1 gösterir 
                this.Hide(); // açık olan formu gizle 
            }
            if (comboBox1.Text == "Bilimsel")
            {
                BİLİMSEL f2 = new BİLİMSEL();
                f2.Show();// BİLİMSEL formunun gösterir 
                this.Hide();// açık olan formu gizle
            }
            if (comboBox1.Text == "Tarihler arasındaki fark")
            {
                Form2 f2 = new Form2();
                f2.Show();// form2 gösterir 
                this.Hide();// açık olan formu gizle
            }
        }
    }
}
