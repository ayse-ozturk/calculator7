// TARİH ARASI FARK HESAP MAKİNASININ FORMU //
////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//Ayşenur ÖZTÜRK
//200707037
//2.sınıf güz dönemi
//Görsel programlama
////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
using System;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace calculator
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        //gün farkını hesaplamak için
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            //TimeSpan olarak oluşturduğumuz GunFarki değeri dateTimePicker2 değerinden  dateTimePicker1 değeri çıkarılır
            TimeSpan GunFarki = dateTimePicker2.Value.Subtract(dateTimePicker1.Value);//dateTimePicker1.volue değeri veriri
                                                                                      //Subtract çıkarma işlemini ifade eder
            label4.Text = GunFarki.Days.ToString() + " gün";//gün fark değerini gün olarak yazdırır
        }
        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            TimeSpan fark = dateTimePicker2.Value.Subtract(dateTimePicker1.Value);//dateTimePicker1.volue değeri veriri
                                                                                  //Subtract çıkarma işlemini ifade eder
            label4.Text = fark.Days.ToString()+" gün";//gün fark değerini gün olarak yazdırır
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox2.Text == "Standart")
            {
                Standart f1 = new Standart();
                f1.Show();//standart formu gösterilir
                this.Hide();// açık olan formu gizle 

            }
            if (comboBox2.Text == "Bilimsel")
            {
                BİLİMSEL f5 = new BİLİMSEL();
                f5.Show();//BİLİMSEL formu gösterilir
                this.Hide();// açık olan formu gizle 

            }
            if (comboBox2.Text == "Tarihler arasındaki fark")
            {
                Form2 f2 = new Form2();
                f2.Show();//Form2 gösterilir
                this.Hide();// açık olan formu gizle 

            }
        }
        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}

