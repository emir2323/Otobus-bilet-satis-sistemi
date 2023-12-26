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
    public partial class satılanbiletler : Form
    {
        public satılanbiletler()
        {
            InitializeComponent();
        }
        OleDbConnection baglan = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=biletkayitlari.accdb");
        OleDbConnection baglanoku = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=biletkayitlari.accdb");
        private void button1_Click(object sender, EventArgs e)
        {
            işlemseç aç = new işlemseç();
            this.Hide();
            aç.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
           
            if (güncellenecekrezno.Text == "")
                errorProvider1.SetError(güncellenecekrezno, "RezNO Giriniz");
            else
            {
                bool durum = false;
                baglanoku.Open();
                OleDbCommand komut = new OleDbCommand();
                komut.Connection = baglanoku;
                komut.CommandText = "Select * From bilet";
                OleDbDataReader oku = komut.ExecuteReader();
                while (oku.Read())
                {
                    string reznotut = oku["RezNo"].ToString();
                    string isim = oku["İsim"].ToString();
                    string soyisim = oku["Soyisim"].ToString();
                    string cinsiyet = oku["Cinsiyet"].ToString();
                    string tel = oku["Telefon"].ToString();
                    string biniş = oku["Biniş"].ToString();

                    if (reznotut == güncellenecekrezno.Text)
                    {


                        durum = true;
                        bilgigüncelle aç = new bilgigüncelle();
                        aç.textBoxisim.Text = isim;
                        aç.textBoxSoyisim.Text = soyisim;
                        aç.maskedTextBoxtelefon.Text = tel;
                        aç.textBoxcinsiyet.Text = cinsiyet;
                       

                        DialogResult sonuc = aç.ShowDialog();
                        if (sonuc == DialogResult.OK)
                        {
                            try
                            {
                                baglan.Open();
                                OleDbCommand komut3 = new OleDbCommand();
                                komut3.Connection = baglan;
                                komut3.CommandText = ("update bilet set İsim='" + aç.textBoxisim.Text.ToString() + "',Soyisim='" + aç.textBoxSoyisim.Text.ToString() + "',Telefon='" + aç.maskedTextBoxtelefon.Text.ToString() + "',Biniş='" + aç.comboKalkış.Text.ToString() + "',İniş='" + aç.comboVarış.Text.ToString() + "',Tarih='" + aç.dateTarih.Text.ToString() + "',Saat='" + aç.comboSaat.Text.ToString() + "',Fiyat='" + aç.textBoxFiyat.Text.ToString() + "',KoltukNo='" + aç.textBoxkoltukno.Text.ToString() + "',Otobüs_Türü='" + aç.comboOtobüs.Text.ToString() + "' where RezNo='" + güncellenecekrezno.Text + "'");
                                komut3.ExecuteNonQuery();
                                MessageBox.Show("güncelleme yapıldı");
                                işlemseç işlemaç = new işlemseç();
                                this.Hide();
                                işlemaç.ShowDialog();

                                break;
                            }
                            catch (Exception y)
                            {
                                MessageBox.Show("veri tabanı hatasıı" + y.Message);
                            }
                            finally
                            {
                                baglan.Close();

                            }
                        }
                        else if (sonuc == DialogResult.Cancel)
                        {
                            aç.Hide();
                            this.Show();
                        }
                    }
                }
                baglanoku.Close();
                if (durum == false)
                    MessageBox.Show("Girilen RezNo İçin Bilet Bulunamadı...");
            }
           
        }
        private void button4_Click(object sender, EventArgs e)
        {
            
            
            if (SilinecekRezNo.Text == "")
                    errorProvider1.SetError(SilinecekRezNo, "RezNO Giriniz");
            else
            {
                baglanoku.Open();
                OleDbCommand komut2 = new OleDbCommand();
                komut2.Connection = baglanoku;
                komut2.CommandText = "Select * From bilet";
                OleDbDataReader oku = komut2.ExecuteReader();
                while (oku.Read())
                {
                    string reznotut = oku["RezNo"].ToString();
                    if (reznotut == SilinecekRezNo.Text)
                    {
                        try
                        {
                            baglan.Open();
                            OleDbCommand komut = new OleDbCommand();
                            komut.Connection = baglan;
                            
                            komut.CommandText = "delete from bilet where RezNo='" + SilinecekRezNo.Text + "'";
                            komut.ExecuteNonQuery();
                            MessageBox.Show("BİLET İADESİ YAPILMIŞTIR");
                            işlemseç aç = new işlemseç();
                            this.Hide();
                            aç.ShowDialog();



                        }
                        catch (Exception r)
                        {
                            MessageBox.Show("Veri Tabanı Bağlantısında Hata Oluştu" + r.Message);
                        }
                        finally
                        {
                            
                            baglan.Close();
                           

                        }
                       
                    }

                }
                MessageBox.Show("Girilen RezNo İçin Bilet Bulunamadı...");
                baglanoku.Close();
            }
            
        }

        private void satılanbiletler_Load(object sender, EventArgs e)
        {

        }
    }
}
