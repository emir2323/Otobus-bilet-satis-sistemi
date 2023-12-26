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
    public partial class bilgigüncelle : Form
    {
        public bilgigüncelle()
        {
            InitializeComponent();
        }
        OleDbConnection baglanoku = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=biletkayitlari.accdb");
        bool değer = false;
        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
        

        private void buttongüncelle_Click(object sender, EventArgs e)
        {
            #region
            if (comboOtobüs.Text == "METRO" && (Convert.ToInt32(textBoxkoltukno.Text) < 0 || Convert.ToInt32(textBoxkoltukno.Text) > 27))
            {
                textBoxkoltukno.Text = "";
                MessageBox.Show("METRO TURİZMİN ''MİN. 1'' -- ''MAX. 27'' NOLU KOLTUK NUMARASI VARDIR");

            }
            else if (comboOtobüs.Text == "PAMUKKALE" && (Convert.ToInt32(textBoxkoltukno.Text) < 0 || Convert.ToInt32(textBoxkoltukno.Text) > 41))
            {

                textBoxkoltukno.Text = "";
                MessageBox.Show("PAMUKKALE TURİZMİN ''MİN. 1'' -- ''MAX. 41'' NOLU KOLTUK NUMARASI VARDIR");
            }
            else if (comboOtobüs.Text == "ES" && (Convert.ToInt32(textBoxkoltukno.Text) < 0 || Convert.ToInt32(textBoxkoltukno.Text) > 45))
            {

                textBoxkoltukno.Text = "";
                MessageBox.Show("ES TURİZMİN ''MİN. 1'' -- ''MAX. 45'' NOLU KOLTUK NUMARASI VARDIR");
            }
            else if (comboOtobüs.Text == "KAMİLKOÇ" && (Convert.ToInt32(textBoxkoltukno.Text) < 0 || Convert.ToInt32(textBoxkoltukno.Text) > 31))
            {

                textBoxkoltukno.Text = "";
                MessageBox.Show("KAMİK KOÇ TURİZMİN ''MİN. 1'' -- ''MAX. 31'' NOLU KOLTUK NUMARASI VARDIR");
            }
            else
            {

                if (textBoxisim.Text == "" || textBoxSoyisim.Text == "" || comboKalkış.SelectedIndex == -1 || comboVarış.SelectedIndex == -1 || textBoxkoltukno.Text == "" || comboSaat.SelectedIndex == -1 || comboOtobüs.SelectedIndex == -1)
                {
                    if (textBoxisim.Text == "")
                        errorProvider1.SetError(textBoxisim, "İsim Boş Bırakılamaz");
                    else
                        errorProvider1.SetError(textBoxisim, "");
                    if (textBoxSoyisim.Text == "")
                        errorProvider1.SetError(textBoxSoyisim, "Soyİsim Boş Bırakılamaz");
                    else
                        errorProvider1.SetError(textBoxSoyisim, "");
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
                    if (textBoxkoltukno.Text == "")
                        errorProvider1.SetError(textBoxkoltukno, "Koltuk Numarası Giriniz");
                    else
                        errorProvider1.SetError(textBoxkoltukno, "");
                    if (comboOtobüs.SelectedIndex == -1)
                        errorProvider1.SetError(comboOtobüs, "Otobüs Firması Seçiniz");
                    else
                        errorProvider1.SetError(comboOtobüs, "");

                }
                else
                {
                    baglanoku.Open();
                    OleDbCommand komut = new OleDbCommand();
                    komut.Connection = baglanoku;
                    komut.CommandText = "Select * From bilet";
                    OleDbDataReader oku = komut.ExecuteReader();
                    while (oku.Read())
                    {
                        string biniş = oku["Biniş"].ToString();
                        string iniş = oku["İniş"].ToString();
                        string tarih = oku["Tarih"].ToString();
                        string saat = oku["Saat"].ToString();
                        string koltukno = oku["KoltukNo"].ToString();
                        string otobüs = oku["Otobüs_Türü"].ToString();
                        if (comboKalkış.Text == biniş && comboVarış.Text == iniş && dateTarih.Text == tarih && comboSaat.Text == saat && textBoxkoltukno.Text == koltukno && comboOtobüs.Text == otobüs)
                        {

                            değer = true;
                            break;

                        }

                    }
                    baglanoku.Close();
                    if (değer == true)
                    {
                        MessageBox.Show("Bu Bilet Yeri Satılmıştır!!!!!!");
                        this.Hide();
                    }
                    else if (değer == false)
                    {
                        this.DialogResult = DialogResult.OK;
                        this.Hide();
                    }

                }
            }
            #endregion
        }

        private void buttonçıkıs_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Hide();
        }

        private void bilgigüncelle_Load(object sender, EventArgs e)
        {
            comboKalkış.Items.Add("ANKARA");
            comboKalkış.Items.Add("İSTANBUL");
            comboKalkış.Items.Add("KONYA");
            comboKalkış.Items.Add("ANTALYA");
            comboKalkış.Items.Add("MERSİN");
        }

        private void comboKalkış_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            #region
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
            #endregion
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
        
    }
}
