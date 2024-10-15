using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bilgi_Yarismasi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int soruno = 0, dogru = 0, yanlis = 0;

        private void BtnB_Click(object sender, EventArgs e)
        {
            BtnA.Enabled = false;
            BtnB.Enabled = false;
            BtnC.Enabled = false;
            BtnD.Enabled = false;
            BtnSonraki.Enabled = true;

            label5.Text = BtnB.Text;

            if (label4.Text == label5.Text)
            {
                dogru++;
                LblDogru.Text =dogru.ToString();
                pictureBox1.Visible = true;
                
            
           }
            else
            {
                yanlis++;
                LblYanlis.Text =yanlis.ToString();
                pictureBox2.Visible = true;
            }

        }

        private void BtnC_Click(object sender, EventArgs e)
        {
            BtnA.Enabled = false;
            BtnB.Enabled = false;
            BtnC.Enabled = false;
            BtnD.Enabled = false;
            BtnSonraki.Enabled = true;

            label5.Text = BtnC.Text;
            if (label4.Text == label5.Text)
            {
                dogru++;
                LblDogru.Text = dogru.ToString();
                pictureBox1.Visible = true;
            }
            else
            {
                yanlis++;
                LblYanlis.Text=yanlis.ToString();
                pictureBox2.Visible = true;

            }

        }

        private void BtnD_Click(object sender, EventArgs e)
        {
            BtnA.Enabled = false;
            BtnB.Enabled = false;
            BtnC.Enabled = false;
            BtnD.Enabled = false;
            BtnSonraki.Enabled = true;

            label5.Text = BtnD.Text;
            if (label4.Text == label5.Text)
            {
                dogru++;
                LblDogru.Text=dogru.ToString();
                pictureBox1.Visible = true;
            }
            else
            {
                yanlis++;
                LblYanlis.Text = yanlis.ToString();
                pictureBox2.Visible = true;
            }

        }

        private void BtnA_Click(object sender, EventArgs e)
        {
            BtnA.Enabled = false;
            BtnB.Enabled = false;
            BtnC.Enabled = false;
            BtnD.Enabled = false;
            BtnSonraki.Enabled = true;
            
            label5.Text = BtnA.Text;
            if (label4.Text == label5.Text)
            {
                dogru++;
                LblDogru.Text = dogru.ToString();
                pictureBox1.Visible = true;
            }
            else
            {
                yanlis++;
                pictureBox2.Visible = true;
                LblYanlis.Text = yanlis.ToString();

            }
           
            
        }

        private void BtnSonraki_Click(object sender, EventArgs e)
        {
            pictureBox1.Visible=false;
            pictureBox2.Visible=false;
            
            BtnA.Enabled = true;
            BtnB.Enabled = true;
            BtnC.Enabled = true;
            BtnD.Enabled = true;
            BtnSonraki.Enabled = false;
            
            soruno++;
            LblSoruno.Text = soruno.ToString();
            if (soruno == 1) {
                richTextBox1.Text = "Cumhuriyet kaç yılında kurulmuştur?";
                BtnA.Text = "1920";
                BtnB.Text = "1921";
                BtnC.Text = "1922";
                BtnD.Text = "1923";
                label4.Text = "1923";
            }
            if (soruno == 2) 
            {
                richTextBox1.Text = "Hangi il Ege Bölgesinde her almaz?";
                BtnA.Text = "Aydın";
                BtnB.Text = "Balıkesir";
                BtnC.Text = "İzmir";
                BtnD.Text = "Manisa";
                label4.Text = "Balıkesir";
            }
            if (soruno == 3)
            {
                richTextBox1.Text = "Hangisi Son Kuşlar Kitabının Yazarıdır?";
                BtnA.Text = "Sait Faik";
                BtnB.Text = "Cemal Süreyya";
                BtnC.Text = "Atilla İlhan";
                BtnD.Text = "Reşat Nuri";
                label4.Text = "Sait Faik";
            }
            if (soruno == 4)
            {
                richTextBox1.Text = "Kur'an-ı Kerim'de hangisi üzerine yemin edilmemiştir?";
                BtnA.Text = "Deniz";
                BtnB.Text = "Güneş";
                BtnC.Text = "Arı";
                BtnD.Text = "Kalem";
                label4.Text = "Arı";
            }   
            if (soruno == 5)
            {
                richTextBox1.Text = "On kıtadan oluşan İstiklal Marşı'nın tamamında, bu kelimelerden hangisi diğerlerinden daha az geçer?";
                BtnA.Text = "Vatan";
                BtnB.Text = "Kan";
                BtnC.Text = "Toprak";
                BtnD.Text = "Yurt";
                label4.Text = "Toprak";
            }
            if (soruno == 6)
            {
                richTextBox1.Text = "Hangisi \"Dede Korkut Hikayeleri\"ndeki karakterlerden biri değildir?";
                BtnA.Text = "Bala Hatun";
                BtnB.Text = "Bala Çiçek";
                BtnC.Text = "Bamsı Beyrek";
                BtnD.Text = "Bayındır Han";
                label4.Text = "Bala Hatun";
                BtnSonraki.Text = "Sonuçlar";
            }
            if (soruno == 7) 
            {
                BtnA.Enabled = false;
                BtnB.Enabled = false;
                BtnC.Enabled = false;
                BtnD.Enabled = false;
                BtnSonraki.Enabled = false;
                MessageBox.Show("Dogru: " + dogru + "\n" + "Yanlis: " + yanlis);
                

            }

        }
    }
}
