using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;




namespace OtobusBiletSatis
{
    public partial class KayıtForm : Form
    {
        public KayıtForm()
        {
            InitializeComponent();
        }

        private void buttonKayıtOluştur_Click(object sender, EventArgs e)
        {
            if (textBoxisim.Text == "" || textBoxsoyisim.Text == "")
            {
                if (textBoxisim.Text == "")
                    errorProvider1.SetError(textBoxisim, "Lütfen İsim Giriniz");
                else
                    errorProvider1.SetError(textBoxisim, "");

                if (textBoxsoyisim.Text == "")
                    errorProvider1.SetError(textBoxsoyisim, "Lütfen Soyisim Giriniz");
                else
                    errorProvider1.SetError(textBoxsoyisim, "");

            }
            else
            {

                this.DialogResult = DialogResult.OK;
                this.Close();

            }
        
            
        }

        private void buttonKayıtİptal_Click(object sender, EventArgs e)
        {
           
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void KayıtForm_Load(object sender, EventArgs e)
        {

        }

        private void radioButtonBAY_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
