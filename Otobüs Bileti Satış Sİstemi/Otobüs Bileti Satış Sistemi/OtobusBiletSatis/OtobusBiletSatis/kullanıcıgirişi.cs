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
    public partial class kullanıcıgirişi : Form
    {
        public kullanıcıgirişi()
        {
            InitializeComponent();
        }
        OleDbConnection baglan = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=kullanıcıgirisi.accdb");

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        bool durum = false;
        private void button1_Click(object sender, EventArgs e)
        {

            //Oturum açmak için veri tabanı kontrolü
            #region
            try
            {

                baglan.Open();
                OleDbCommand komut = new OleDbCommand();
                komut.Connection = baglan;
                komut.CommandText = "Select * From kullanıcı";
                OleDbDataReader oku = komut.ExecuteReader();
                while (oku.Read())
                {
                    if (textBox1.Text == oku["KullanıcıAdı"].ToString() && textBox2.Text == oku["Sifre"].ToString())
                    {
                        durum = true;
                        işlemseç işlemseçaç = new işlemseç();
                        this.Hide();
                        işlemseçaç.ShowDialog();
                    }


                }
                if (durum == false)
                    MessageBox.Show("Kullanıcı Adı Veya Şifre Hatalıdır");

            }
            catch (Exception hata)
            {
                MessageBox.Show("Veri Tabanı Bağlantısında Hata Oluştu" + hata.Message);
            }
            finally
            {
                baglan.Close();
            }
            #endregion
        }

        private void kullanıcıgirişi_Load(object sender, EventArgs e)
        {
            this.AcceptButton = button1; this.CancelButton = button2;
        }
    }
}
