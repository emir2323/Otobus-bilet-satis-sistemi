using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace OtobusBiletSatis
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        



        private void Form1_Load(object sender, EventArgs e)
        {
            Random rnd = new Random();
            RezNo.Text = rnd.Next(999999999).ToString();
            timer1.Interval = 50;
            timer1.Enabled = true;
            timer1.Start();
            comboKalkış.Items.Add("ANKARA");
            comboKalkış.Items.Add("İSTANBUL");
            comboKalkış.Items.Add("KONYA");
            comboKalkış.Items.Add("ANTALYA");
            comboKalkış.Items.Add("MERSİN");

        }
        
        private void comboOtobüs_SelectedIndexChanged(object sender, EventArgs e)
        {
            
           
            if (comboOtobüs.Text == "METRO")
            {

                koltuklar(8, true);

            }
            else if (comboOtobüs.Text == "PAMUKKALE")
            {
                koltuklar(14, false);
            }
            else if (comboOtobüs.Text == "ES")
            {
                koltuklar(12, true);
            }
            else if (comboOtobüs.Text == "KAMİLKOÇ")
            {
                koltuklar(8, true);
            }
            MessageBox.Show("LÜTFEN KOLTUK SEÇİMİNİZİ YAPARKEN \n" +
                "" +
                "KOLTUK ÜZERİNE GELİP *SAĞ TIK* YAPINIZ");
          
        }

        public void koltuklar(int sıra,bool arka_beslimi)
        {
            
     

        git:
            foreach (Control bak in this.Controls)
            { 

                if (bak is Button)
                {
                    Button btn = bak as Button;
                    if (btn.Text == "OLUŞTUR" || btn.Text=="GERİ DÖN")
                        continue;
                    else
                    { this.Controls.Remove(btn); goto git;}
                        
                    
                }
                if (bak is Label)
                {
                    Label lbl = bak as Label;
                    if (lbl.Text != "KAPI")
                        continue;
                    else
                    { this.Controls.Remove(lbl); goto git; }

                }


            }
           
            
      
            int koltukno = 1;
            for (int i = 0; i <sıra; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if (comboOtobüs.Text == "PAMUKKALE")
                        if (j == 1 && i<=10)
                            continue;
                    if (comboOtobüs.Text == "METRO")
                    {
                        if ((i == 0 || i == 1 || i == 2 || i == 3 )&& j == 3)
                            continue;
                    }
                    if(sıra>=10)
                    {
                        if (i == 4 && j > 2)
                        {
                            Label metin = new Label();
                            metin.Text = "KAPI";
                            metin.Left = 200;
                            metin.Top = 195;
                            this.Controls.Add(metin);
                            continue;
                        }

                        if (i == 10 && j > 2)
                        {
                            Label metin = new Label();
                            metin.Text = "KAPI";
                            metin.Left = 200;
                            metin.Top = 435;
                            this.Controls.Add(metin);
                            continue;
                        }
                          

                    }
                    else
                    {
                        if (i == 4 && j > 2)
                        {
                            Label metin = new Label();
                            metin.Text = "KAPI";
                            metin.Left = 203;
                            metin.Top = 315;
                            this.Controls.Add(metin);
                            continue;
                        }
                            
                    }
                   

                    if(arka_beslimi==true)
                    {
                        if(i!=sıra-1 && j==2) 
                        {
                            continue;
                        }

                    }
                    else
                    {
                        if (j == 2)
                            continue;
                    }
                   if(sıra<10)
                    { 
                    Button oluştur = new Button();
                    oluştur.Height = 35;
                    oluştur.Width = 40;
                    oluştur.Top = 150+(i*40);
                    oluştur.Left = 50+(45*j);
                    oluştur.Text = koltukno.ToString();
                    oluştur.ContextMenuStrip = contextMenuStrip1;
                    oluştur.MouseDown += koltuk_mausedown;
                    koltukno++;
                    this.Controls.Add(oluştur);
                        }
                   else
                    {
                        Button oluştur = new Button();
                        oluştur.Height = 35;
                        oluştur.Width = 40;
                        oluştur.Top = 30 + (i * 40);
                        oluştur.Left = 50 + (45 * j);
                        oluştur.Text = koltukno.ToString();
                        oluştur.ContextMenuStrip = contextMenuStrip1;
                        oluştur.MouseDown += koltuk_mausedown;
                        koltukno++;
                        this.Controls.Add(oluştur);

                    }
                   


                }
            }
           

        }
        public Button tıklama;
        public void koltuk_mausedown(object sender, MouseEventArgs e)
        {
            tıklama = sender as Button;
            
        }
        private void comboKalkış_SelectedIndexChanged(object sender, EventArgs e)
        {
            
           
            if (comboKalkış.Text == "ANKARA")
            {
                comboVarış.Items.Clear();
                comboVarış.Items.Add("İSTANBUL");
                comboVarış.Items.Add("KONYA");
                comboVarış.Items.Add("ANTALYA");
                comboVarış.Items.Add("MERSİN");
            }
            else if (comboKalkış.Text == "İSTANBUL")
            {
                comboVarış.Items.Clear();
                comboVarış.Items.Add("ANKARA");
                comboVarış.Items.Add("KONYA");
                comboVarış.Items.Add("ANTALYA");
                comboVarış.Items.Add("MERSİN");

            }
            else if (comboKalkış.Text == "KONYA")
            {
                comboVarış.Items.Clear();
                comboVarış.Items.Add("ANKARA");
                comboVarış.Items.Add("İSTANBUL");
                comboVarış.Items.Add("ANTALYA");
                comboVarış.Items.Add("MERSİN");
            }

            else if (comboKalkış.Text == "ANTALYA")
            {
                comboVarış.Items.Clear();
                comboVarış.Items.Add("ANKARA");
                comboVarış.Items.Add("İSTANBUL");
                comboVarış.Items.Add("KONYA");
                comboVarış.Items.Add("MERSİN");
            }
            else if (comboKalkış.Text == "MERSİN")
            {
                comboVarış.Items.Clear();
                comboVarış.Items.Add("ANKARA");
                comboVarış.Items.Add("İSTANBUL");
                comboVarış.Items.Add("KONYA");
                comboVarış.Items.Add("ANTALYA");
            }
          

        }

        private void comboVarış_SelectedIndexChanged(object sender, EventArgs e)
        {
          
          
            if (comboKalkış.Text == "ANKARA" && comboVarış.Text == "İSTANBUL")
                    textBoxFiyat.Text = "200 TL";
                else if (comboKalkış.Text == "ANKARA" && comboVarış.Text == "KONYA")
                    textBoxFiyat.Text = "130 TL";
                else if (comboKalkış.Text == "ANKARA" && comboVarış.Text == "ANTALYA")
                    textBoxFiyat.Text = "220 TL";
                else if (comboKalkış.Text == "ANKARA" && comboVarış.Text == "MERSİN")
                    textBoxFiyat.Text = "185 TL";
                else if (comboKalkış.Text == "İSTANBUL" && comboVarış.Text == "ANKARA")
                    textBoxFiyat.Text = "170 TL";
                else if (comboKalkış.Text == "İSTANBUL" && comboVarış.Text == "KONYA")
                    textBoxFiyat.Text = "420 TL";
                else if (comboKalkış.Text == "İSTANBUL" && comboVarış.Text == "ANTALYA")
                    textBoxFiyat.Text = "250 TL";
                else if (comboKalkış.Text == "İSTANBUL" && comboVarış.Text == "MERSİN")
                    textBoxFiyat.Text = "400 TL";
                else if (comboKalkış.Text == "KONYA" && comboVarış.Text == "ANKARA")
                    textBoxFiyat.Text = "130 TL";
                else if (comboKalkış.Text == "KONYA" && comboVarış.Text == "İSTANBUL")
                    textBoxFiyat.Text = "420 TL";
                else if (comboKalkış.Text == "KONYA" && comboVarış.Text == "ANTALYA")
                    textBoxFiyat.Text = "200 TL";
                else if (comboKalkış.Text == "KONYA" && comboVarış.Text == "MERSİN")
                    textBoxFiyat.Text = "230 TL";
                else if (comboKalkış.Text == "ANTALYA" && comboVarış.Text == "ANKARA")
                    textBoxFiyat.Text = "200 TL";
                else if (comboKalkış.Text == "ANTALYA" && comboVarış.Text == "İSTANBUL")
                    textBoxFiyat.Text = "220 TL";
                else if (comboKalkış.Text == "ANTALYA" && comboVarış.Text == "KONYA")
                    textBoxFiyat.Text = "200 TL";
                else if (comboKalkış.Text == "ANTALYA" && comboVarış.Text == "MERSİN")
                    textBoxFiyat.Text = "240 TL";
                else if (comboKalkış.Text == "MERSİN" && comboVarış.Text == "ANKARA")
                    textBoxFiyat.Text = "400 TL";
                else if (comboKalkış.Text == "MERSİN" && comboVarış.Text == "İSTANBUL")
                    textBoxFiyat.Text = "210 TL";
                else if (comboKalkış.Text == "MERSİN" && comboVarış.Text == "KONYA")
                    textBoxFiyat.Text = "150 TL";
                else if (comboKalkış.Text == "MERSİN" && comboVarış.Text == "ANTALYA")
                    textBoxFiyat.Text = "100 TL";


            

          
          
            if (comboKalkış.Text == "ANKARA" && (comboVarış.Text == "İSTANBUL" || comboVarış.Text == "MERSİN"))
            {
                comboSaat.Items.Clear();
                comboSaat.Items.Add("10.00-17.00");
                comboSaat.Items.Add("16.00-23.00");
                comboSaat.Items.Add("24.00-06.00");
                comboSaat.Items.Add("06.00-12.00");
            }
            else if (comboKalkış.Text == "ANKARA" && (comboVarış.Text == "KONYA" || comboVarış.Text == "ANTALYA"))
            {
                comboSaat.Items.Clear();
                comboSaat.Items.Add("09.30-14.30");
                comboSaat.Items.Add("12.00-16.00");
                comboSaat.Items.Add("18.00-23.00");
                comboSaat.Items.Add("23.00-05.00");
                comboSaat.Items.Add("24.00-06.00");
                comboSaat.Items.Add("16.00-22.00");
                comboSaat.Items.Add("06.00-13.00");

            }
            else if (comboKalkış.Text == "İSTANBUL" && (comboVarış.Text == "ANKARA" || comboVarış.Text == "MERSİN"))
            {
                comboSaat.Items.Clear();
                comboSaat.Items.Add("08.00-17.00");
                comboSaat.Items.Add("16.00-24.00");
                comboSaat.Items.Add("24.00-09.00");
                comboSaat.Items.Add("12.00-20.00");
                comboSaat.Items.Add("09.00-18.00");
                comboSaat.Items.Add("21.00-05.00");
                comboSaat.Items.Add("06.00-14.00");
            }
            else if (comboKalkış.Text == "İSTANBUL" && (comboVarış.Text == "KONYA" || comboVarış.Text == "ANTALYA"))
            {
                comboSaat.Items.Clear();
                comboSaat.Items.Add("08.30-14.30");
                comboSaat.Items.Add("11.00-17.00");
                comboSaat.Items.Add("14.00-20.00");
                comboSaat.Items.Add("23.00-05.00");

            }
            else if (comboKalkış.Text == "KONYA" && (comboVarış.Text == "ANKARA" || comboVarış.Text == "İSTANBUL"))
            {
                comboSaat.Items.Clear();
                comboSaat.Items.Add("08.00-15.00");
                comboSaat.Items.Add("16.00-24.00");
                comboSaat.Items.Add("24.00-07.00");
            }
            else if (comboKalkış.Text == "KONYA" && (comboVarış.Text == "MERSİN" || comboVarış.Text == "ANTALYA"))
            {
                comboSaat.Items.Clear();
                comboSaat.Items.Add("08.30-12.30");
                comboSaat.Items.Add("11.00-17.00");
                comboSaat.Items.Add("14.00-18.00");
                comboSaat.Items.Add("23.00-05.00");

            }
            else if (comboKalkış.Text == "ANTALYA" && (comboVarış.Text == "ANKARA" || comboVarış.Text == "KONYA"))
            {
                comboSaat.Items.Clear();
                comboSaat.Items.Add("07.00-13.00");
                comboSaat.Items.Add("16.00-21.00");
                comboSaat.Items.Add("01.00-06.00");
            }
            else if (comboKalkış.Text == "ANTALYA" && (comboVarış.Text == "MERSİN" || comboVarış.Text == "İSTANBUL"))
            {
                comboSaat.Items.Clear();
                comboSaat.Items.Add("08.30-16.30");
                comboSaat.Items.Add("11.00-18.00");
                comboSaat.Items.Add("13.00-20.00");
                comboSaat.Items.Add("22.00-05.00");

            }
            else if (comboKalkış.Text == "MERSİN" && (comboVarış.Text == "ANKARA" || comboVarış.Text == "KONYA"))
            {
                comboSaat.Items.Clear();
                comboSaat.Items.Add("07.00-16.00");
                comboSaat.Items.Add("16.00-24.00");
                comboSaat.Items.Add("01.00-11.00");
            }
            else if (comboKalkış.Text == "MERSİN" && (comboVarış.Text == "ANTALYA" || comboVarış.Text == "İSTANBUL"))
            {
                comboSaat.Items.Clear();
                comboSaat.Items.Add("08.30-16.30");
                comboSaat.Items.Add("14.00-18.00");
                comboSaat.Items.Add("11.00-20.00");
                comboSaat.Items.Add("22.00-05.00");

            }
            else
                comboSaat.Items.Clear();
            
        }

    
        OleDbConnection baglan = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=biletkayitlari.accdb");
        string tut;
        OleDbConnection baglanoku2 = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=biletkayitlari.accdb");
        KayıtForm kayıt = new KayıtForm();
        bool değer = false;
        private void rezerveEtToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
            #region
            if (comboKalkış.SelectedIndex == -1 || comboVarış.SelectedIndex == -1 ||
              comboSaat.SelectedIndex == -1)
            {
                if (comboKalkış.SelectedIndex == -1)
                    errorProvider1.SetError(comboKalkış, "Kalkış Şehrini Seçinizi");
                else
                    errorProvider1.SetError(comboKalkış, "");
                if (comboVarış.SelectedIndex == -1)
                    errorProvider1.SetError(comboVarış, "Varış Şehrini Seçiniz");
                else
                    errorProvider1.SetError(comboVarış, "");
                if (comboSaat.SelectedIndex == -1)
                    errorProvider1.SetError(comboSaat, "Saat Seçiniz");
                else
                    errorProvider1.SetError(comboSaat, "");
               
            }
            else
            {
               
               DialogResult sonuc= kayıt.ShowDialog();
                if(sonuc==DialogResult.OK)
                {
                   

                    baglanoku2.Open();
                    OleDbCommand komut2 = new OleDbCommand();
                    komut2.Connection = baglanoku2;
                    komut2.CommandText = "Select * From bilet";
                    OleDbDataReader oku = komut2.ExecuteReader();
                    while (oku.Read())
                    {
                     //OLUŞTURALAN BİLET DAHA ÖNCE SATILMIŞMI KONTROLÜ
                        string biniş = oku["Biniş"].ToString();
                        string iniş = oku["İniş"].ToString();
                        string tarih = oku["Tarih"].ToString();
                        string saat = oku["Saat"].ToString();
                        string koltukno = oku["KoltukNo"].ToString();
                        string otobüs = oku["Otobüs_Türü"].ToString();
                        if (comboKalkış.Text == biniş && comboVarış.Text == iniş && dateTarih.Text == tarih && comboSaat.Text == saat && tıklama.Text == koltukno&&comboOtobüs.Text==otobüs)
                        {
                            
                            değer = true;
                            break;
                           
                        }
                      
                    }
                    if(değer==true)
                    {
                        MessageBox.Show("Bu Bilet Yeri Satılmıştır!!!!!!");

                    }
                    else if(değer==false)
                    {
                        verikaydet();
                        işlemseç işlem = new işlemseç();
                        this.Hide();
                        işlem.ShowDialog();

                    }
                    baglanoku2.Close();
                    
                }
                else if(sonuc==DialogResult.Cancel)
                {
                    kayıt.Hide();
                }
            }
            #endregion
             
        }
        private void verikaydet()
        {
          
           
            try
            {


                baglan.Open();
                if (kayıt.radioButtonBAY.Checked)
                    tut = "BAY";
                tıklama.BackColor = Color.Blue;
                
                if (kayıt.radioButton2BAYAN.Checked)
                    tut = "BAYAN";
                tıklama.BackColor= Color.Red;
                
                
                OleDbCommand komut = new OleDbCommand("insert into bilet(RezNo,İsim,Soyisim,Cinsiyet,Telefon,Biniş,İniş,Tarih,Saat,Fiyat,KoltukNo,Otobüs_Türü) values('" +RezNo.Text.ToString()+ "','" +kayıt.textBoxisim.Text.ToString() + "','" + kayıt.textBoxsoyisim.Text.ToString() + "','" + tut.ToString() + "','" + kayıt.maskedTextBoxtelefon.Text.ToString() + "','" + comboKalkış.Text.ToString()+ "','" +comboVarış.Text.ToString() + "','" + dateTarih.Text.ToString() + "','" + comboSaat.Text.ToString() + "','" + textBoxFiyat.Text.ToString() + "','"+tıklama.Text.ToString()+"','" + comboOtobüs.Text.ToString() + "')", baglan);
                komut.ExecuteNonQuery();
                MessageBox.Show("BİLET SATILMIŞTIR TEŞEKKÜRLER...");
               

            }
            catch (Exception e)
            {
                MessageBox.Show("Veri Tabanı Bağlantısında Hata Oluştu" + e.Message);
            }
            finally
            {
                baglan.Close();
            }
           
        }
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
          
            #region
            System.Drawing.Graphics grafikçiz;
            grafikçiz = this.CreateGraphics();
            Pen kalem = new Pen(System.Drawing.Color.Black,5);
            grafikçiz.DrawLine(kalem, 20, 20, 320, 20);

            System.Drawing.Graphics grafikçiz2;
            grafikçiz2 = this.CreateGraphics();
            Pen kalem2 = new Pen(System.Drawing.Color.Black, 5);
            grafikçiz2.DrawLine(kalem2, 320, 20, 320, 600);

            System.Drawing.Graphics grafikçiz3;
            grafikçiz3 = this.CreateGraphics();
            Pen kalem3 = new Pen(System.Drawing.Color.Black, 5);
            grafikçiz3.DrawLine(kalem3,20,600,320,600);

            System.Drawing.Graphics grafikçiz4;
            grafikçiz4 = this.CreateGraphics();
            Pen kalem4 = new Pen(System.Drawing.Color.Black, 5);
            grafikçiz4.DrawLine(kalem4, 20, 20, 20, 600);

            #endregion
        }
        private void geridön_Click(object sender, EventArgs e)
        {
            işlemseç işlem = new işlemseç();
            this.Hide();
            işlem.ShowDialog();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
