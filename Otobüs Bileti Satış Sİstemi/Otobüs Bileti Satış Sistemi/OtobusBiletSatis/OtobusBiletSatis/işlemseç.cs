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

    public partial class işlemseç : Form
    {
        
        public işlemseç()
        {
            InitializeComponent();
        }
       


        OleDbConnection baglan = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=biletkayitlari.accdb");
        int sayac = 0;
        satılanbiletler bilet = new satılanbiletler();
        private void verigöster()
        {
            
           
            
            try
            {
                  
                baglan.Open();
                OleDbCommand komut = new OleDbCommand();
                komut.Connection = baglan;
                komut.CommandText = "Select * From bilet";
                OleDbDataReader oku = komut.ExecuteReader();
               
                
                
                    while (oku.Read())
                    {

                    ListViewItem ekle = new ListViewItem();
                    ekle.Text = oku["RezNo"].ToString();
                        ekle.SubItems.Add(oku["İsim"].ToString());
                        ekle.SubItems.Add(oku["Soyisim"].ToString());
                        ekle.SubItems.Add(oku["Cinsiyet"].ToString());
                        ekle.SubItems.Add(oku["Telefon"].ToString());
                        ekle.SubItems.Add(oku["Biniş"].ToString());
                        ekle.SubItems.Add(oku["İniş"].ToString());
                        ekle.SubItems.Add(oku["Tarih"].ToString());
                        ekle.SubItems.Add(oku["Saat"].ToString());
                        ekle.SubItems.Add(oku["Fiyat"].ToString());
                         ekle.SubItems.Add(oku["KoltukNo"].ToString());
                    if (oku["Otobüs_Türü"].ToString() == "METRO")
                        bilet.listViewMETRO.Items.Add(ekle);
                    else if (oku["Otobüs_Türü"].ToString() == "PAMUKKALE")
                        bilet.listViewPAMUKKALE.Items.Add(ekle);
                    else if (oku["Otobüs_Türü"].ToString() == "ES")
                        bilet.listViewES.Items.Add(ekle);
                    else if (oku["Otobüs_Türü"].ToString() == "KAMİLKOÇ")
                        bilet.listViewKAMİLKOÇ.Items.Add(ekle);
                   

                }


                
              
                
               
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


        private void button1_Click(object sender, EventArgs e)
        {
          
            Form1 aç = new Form1();
            this.Hide();
            aç.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            kullanıcıgirişi aç = new kullanıcıgirişi();
            this.Hide();
            aç.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            verigöster();
            bilet.ShowDialog();
            
            
        }

        private void işlemseç_Load(object sender, EventArgs e)
        {
          
        }

  

        private void label1_Click(object sender, EventArgs e)
        {

        }
      
        
    }
}
