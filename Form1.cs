using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace PsikoAnalizTestUygulamasi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection baglan = new SqlConnection("Data Source=IRFAN\\SQLEXPRESS; Initial Catalog=karaktertest;Integrated Security=True");
        private void butonlaripasifyap()
        {
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = false;
            button6.Enabled = false;
            button7.Enabled = false;
        }
        private void butonlariaktifyap()
        {
            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
            button5.Enabled = true;
            button6.Enabled = true;
            button7.Enabled = true;
        }
        int soru;
        private void Form1_Load(object sender, EventArgs e)
        {
            button9.Visible = false;


        }

        private void button8_Click(object sender, EventArgs e)
        {
            button8.Enabled = false;
            butonlariaktifyap();
            button8.Text = "İLERİ";
            soru++;
            label5.Text=soru.ToString();
            button4.Visible = false;
            button5.Visible = false;
            button6.Visible = false;
            button7.Visible = false;
            if (soru == 1)
            {
                baglan.Open();
                SqlCommand komut = new SqlCommand("Select *from soru1 order by NEWID()", baglan);
                SqlDataReader oku = komut.ExecuteReader();
                while (oku.Read())
                {
                    richTextBox1.Text = (oku["soru"].ToString());
                    button1.Text = (oku["a"].ToString());
                    button2.Text = (oku["b"].ToString());
                    button3.Text = (oku["c"].ToString());

                }
                baglan.Close();
            }
            if (soru == 2)
            {
                button4.Visible = true;
                button5.Visible = true;
                baglan.Open();
                SqlCommand komut = new SqlCommand("Select *from soru2 order by NEWID()", baglan);
                SqlDataReader oku = komut.ExecuteReader();
                while (oku.Read())
                {
                    richTextBox1.Text = (oku["soru"].ToString());
                    button1.Text = (oku["a"].ToString());
                    button2.Text = (oku["b"].ToString());
                    button3.Text = (oku["c"].ToString());
                    button4.Text = (oku["d"].ToString());
                    button5.Text = (oku["e"].ToString());
                }
                baglan.Close();
            }
            if (soru == 3)
            {
                button4.Visible = true;
                button5.Visible = true;
                baglan.Open();
                SqlCommand komut = new SqlCommand("Select *from soru3 order by NEWID()", baglan);
                SqlDataReader oku = komut.ExecuteReader();
                while (oku.Read())
                {
                    richTextBox1.Text = (oku["soru"].ToString());
                    button1.Text = (oku["a"].ToString());
                    button2.Text = (oku["b"].ToString());
                    button3.Text = (oku["c"].ToString());
                    button4.Text = (oku["d"].ToString());
                    button5.Text = (oku["e"].ToString());
                }
                baglan.Close();
            }
            if (soru == 4)
            {
                button4.Visible = true;
                baglan.Open();
                SqlCommand komut = new SqlCommand("Select *from soru4 order by NEWID()", baglan);
                SqlDataReader oku = komut.ExecuteReader();
                while (oku.Read())
                {
                    richTextBox1.Text = (oku["soru"].ToString());
                    button1.Text = (oku["a"].ToString());
                    button2.Text = (oku["b"].ToString());
                    button3.Text = (oku["c"].ToString());
                    button4.Text = (oku["d"].ToString());
                }
                baglan.Close();
            }
            if (soru == 5)
            {
                button4.Visible = true;
                baglan.Open();
                SqlCommand komut = new SqlCommand("Select *from soru5 order by NEWID()", baglan);
                SqlDataReader oku = komut.ExecuteReader();
                while (oku.Read())
                {
                    richTextBox1.Text = (oku["soru"].ToString());
                    button1.Text = (oku["a"].ToString());
                    button2.Text = (oku["b"].ToString());
                    button3.Text = (oku["c"].ToString());
                    button4.Text = (oku["d"].ToString());
                }
                baglan.Close();
            }
            if (soru == 6)
            {
                baglan.Open();
                SqlCommand komut = new SqlCommand("Select *from soru6 order by NEWID()", baglan);
                SqlDataReader oku = komut.ExecuteReader();
                while (oku.Read())
                {
                    richTextBox1.Text = (oku["soru"].ToString());
                    button1.Text = (oku["a"].ToString());
                    button2.Text = (oku["b"].ToString());
                    button2.Text = (oku["c"].ToString());

                }
                baglan.Close();
            }
            if (soru == 7)
            {
                baglan.Open();
                SqlCommand komut = new SqlCommand("Select *from soru7 order by NEWID()", baglan);
                SqlDataReader oku = komut.ExecuteReader();
                while (oku.Read())
                {
                    richTextBox1.Text = (oku["soru"].ToString());
                    button1.Text = (oku["a"].ToString());
                    button2.Text = (oku["b"].ToString());
                    button3.Text = (oku["c"].ToString());
                }
                baglan.Close();
            }
            if (soru == 8)
            {
                button4.Visible = true;
                button5.Visible = true;
                button6.Visible = true;
                button7.Visible = true;
                baglan.Open();
                SqlCommand komut = new SqlCommand("Select *from soru8 order by NEWID()", baglan);
                SqlDataReader oku = komut.ExecuteReader();
                while (oku.Read())
                {
                    richTextBox1.Text = (oku["soru"].ToString());
                    button1.Text = (oku["a"].ToString());
                    button2.Text = (oku["b"].ToString());
                    button3.Text = (oku["c"].ToString());
                    button4.Text = (oku["d"].ToString());
                    button5.Text = (oku["e"].ToString());
                    button6.Text = (oku["f"].ToString());
                    button7.Text = (oku["g"].ToString());

                }
                baglan.Close();
            }

            if (soru == 9)
            {
                button4.Visible = true;
                button5.Visible = true;
                baglan.Open();
                SqlCommand komut = new SqlCommand("Select *from soru9 order by NEWID()", baglan);
                SqlDataReader oku = komut.ExecuteReader();
                while (oku.Read())
                {
                    richTextBox1.Text = (oku["soru"].ToString());
                    button1.Text = (oku["a"].ToString());
                    button2.Text = (oku["b"].ToString());
                    button3.Text = (oku["c"].ToString());
                    button4.Text = (oku["d"].ToString());
                    button5.Text = (oku["e"].ToString());
                }
                baglan.Close();
            }
            if (soru == 10)
            {
                button8.Visible = false;
                button9.Visible = true;
                button4.Visible = true;
                button5.Visible = true;
                button6.Visible = true;
                baglan.Open();
                SqlCommand komut = new SqlCommand("Select *from soru10 order by NEWID()", baglan);
                SqlDataReader oku = komut.ExecuteReader();
                while (oku.Read())
                {
                    richTextBox1.Text = (oku["soru"].ToString());
                    button1.Text = (oku["a"].ToString());
                    button2.Text = (oku["b"].ToString());
                    button3.Text = (oku["c"].ToString());
                    button4.Text = (oku["d"].ToString());
                    button5.Text = (oku["e"].ToString());
                    button6.Text = (oku["f"].ToString());

                }
                baglan.Close();
            }
        }
        int toplam=0;
        private void button1_Click(object sender, EventArgs e)
        {
            button8.Enabled = true;
            butonlaripasifyap();
            if(soru==1) //BU YAPILANLAR YALNIZCA A ŞIKKI İÇİN GEÇERLİYDİ.
            {
                toplam = toplam + 2;
            }
            if(soru==2 || soru==5 || soru == 6 || soru == 7 || soru == 8)
            {
                toplam = toplam + 6;
            }
            if(soru==3 || soru ==4 || soru ==10)
            {
                toplam = toplam + 4;
            }
            if (soru == 9)
            {
                toplam = toplam + 7;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button8.Enabled = true;

            butonlaripasifyap();

            if (soru==1 || soru ==2 || soru ==5 || soru == 6)//BU YAPILANLAR YALNIZCA B ŞIKKI İÇİN GEÇERLİYDİ.
            {
                toplam=toplam + 4;
            }
            if (soru == 3 || soru == 7 || soru == 10)
            {
                toplam = toplam + 2;
            }
            if (soru==4 || soru == 9)
                {
                  toplam = toplam + 6;
            }if(soru==8)
            {
                toplam = toplam + 7;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button8.Enabled = true;

            butonlaripasifyap();

            if (soru == 1)//BU YAPILANLAR YALNIZCA C ŞIKKI İÇİN GEÇERLİYDİ.
            {
                toplam = toplam + 6;
            }
            if (soru == 2)
            {
                toplam = toplam + 7;

            }if(soru == 3 || soru == 8)
            {
                toplam= toplam + 5;
            }
            if(soru==4 || soru == 6)
            {
                toplam = toplam + 2;
            }if(soru==5 || soru == 10)
            {
                toplam= toplam+3;
            }
            if(soru==7 || soru == 9)
            {
                toplam = toplam+4;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            button8.Enabled = true;

            butonlaripasifyap();

            if (soru == 2 || soru ==9) //BU YAPILANLAR YALNIZCA D ŞIKKI İÇİN GEÇERLİYDİ.
            {
                toplam = toplam + 2;
            }
            if(soru == 3)
            {
                toplam = toplam + 7;
            }
            if (soru == 4)
            {
                toplam = toplam + 1;
            }
            if(soru==5 || soru == 10)
            {
                toplam = toplam + 5;
            }
            if (soru == 8)
            {
                toplam = toplam + 4;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            button8.Enabled = true;

            butonlaripasifyap();

            if (soru==2 || soru ==9)
            {
                toplam = toplam + 1;
            }
            if (soru == 3 || soru ==10)
            {
                toplam = toplam + 6;
            }
            if (soru == 5)
            {
                toplam = toplam + 2;
            }
            if (soru == 8)
            {
                toplam = toplam + 3;
            }     
        }

        private void button6_Click(object sender, EventArgs e)
        {
            button8.Enabled = true;

            butonlaripasifyap();

            if (soru == 8)
            {
                toplam = toplam + 2;
            }
            if (soru == 10)
            {
                toplam = toplam + 1;
            }
        }

        private void button7_Click(object sender, EventArgs e)
        
        {
            button8.Enabled = true;

            butonlaripasifyap();
            toplam += 1;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if(toplam>=31 && toplam <= 40)
            {
                richTextBox1.Text = "İnsanlar sizi mantıklı, ihtiyatlı, dikkatli ve pratik birisi olarak görürler. Sizi zeki, yetenekli ve hünerli ama alçak gönüllü olarak tanırlar. Çok hızlı arkadaşlık kurmayan, ama arkadaşlarına karşı çok sadık olan ve onlardan da aynı şeyi bekleyen birisiniz.";
            }
            if(toplam>=41 && toplam <= 50)
            {
                richTextBox1.Text = "İnsanlar sizi taze, canlı, çekici, eğlendirici, pratik ve daima ilginç birisi olarak görürler; her zaman ilgi odağı olan ama çok aşırıya kaçmayacak kadar da dengeli birisi.. İnsanlar sizi ayrıca iyiliksever, düşünceli, anlayışlı ve kendilerini neşelendiren ve rahatlatan birisi olarak tanırlar.";
            }
            if(toplam>=51 && toplam <= 60)
            {
                richTextBox1.Text = "insanlar sizi heyecan verici, havai, düşüncesiz yapıda, doğal liderlik özellikleri olan, her zaman doğru olmasa da hızlı karar veren birisi olarak tanırlar. Seni cesur, maceraperest birisi olarak tanırlar; her şeyi bir kez denemek isteyen, macera yaşamak için fırsatları kaçırmayan birisi.. Yaydığınız heyecandan dolayı insanlar sizinle aynı iş yerinde yaşamaktan zevk alırlar.";
            }
            if (toplam >= 60)
            {
                richTextBox1.Text = "İnsanlar sana kırılgan bir eşya muamelesi yapıyorlar. Kibirli, bencil ve aşırı baskın birisi olarak görülüyorsun. İnsanlar size hayranlık duyup sizin gibi olmak isteyebilirler ama size her zaman güvenmezler ve sizinle çok yakın ilişkide olmaktan kaçınırlar.";
            }
            label3.Text = toplam.ToString();
        }
    } 
}
