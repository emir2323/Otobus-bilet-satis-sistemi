namespace OtobusBiletSatis
{
    partial class KayıtForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KayıtForm));
            this.textBoxisim = new System.Windows.Forms.TextBox();
            this.textBoxsoyisim = new System.Windows.Forms.TextBox();
            this.maskedTextBoxtelefon = new System.Windows.Forms.MaskedTextBox();
            this.radioButtonBAY = new System.Windows.Forms.RadioButton();
            this.radioButton2BAYAN = new System.Windows.Forms.RadioButton();
            this.buttonKayıtOluştur = new System.Windows.Forms.Button();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.buttonKayıtİptal = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxisim
            // 
            this.textBoxisim.Location = new System.Drawing.Point(183, 50);
            this.textBoxisim.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxisim.Name = "textBoxisim";
            this.textBoxisim.Size = new System.Drawing.Size(311, 22);
            this.textBoxisim.TabIndex = 1;
            // 
            // textBoxsoyisim
            // 
            this.textBoxsoyisim.Location = new System.Drawing.Point(181, 126);
            this.textBoxsoyisim.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxsoyisim.Name = "textBoxsoyisim";
            this.textBoxsoyisim.Size = new System.Drawing.Size(311, 22);
            this.textBoxsoyisim.TabIndex = 1;
            // 
            // maskedTextBoxtelefon
            // 
            this.maskedTextBoxtelefon.Location = new System.Drawing.Point(183, 201);
            this.maskedTextBoxtelefon.Margin = new System.Windows.Forms.Padding(4);
            this.maskedTextBoxtelefon.Mask = "(999) 000-0000";
            this.maskedTextBoxtelefon.Name = "maskedTextBoxtelefon";
            this.maskedTextBoxtelefon.Size = new System.Drawing.Size(309, 22);
            this.maskedTextBoxtelefon.TabIndex = 3;
            // 
            // radioButtonBAY
            // 
            this.radioButtonBAY.AutoSize = true;
            this.radioButtonBAY.BackColor = System.Drawing.Color.Transparent;
            this.radioButtonBAY.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.radioButtonBAY.ForeColor = System.Drawing.Color.Black;
            this.radioButtonBAY.Location = new System.Drawing.Point(203, 267);
            this.radioButtonBAY.Margin = new System.Windows.Forms.Padding(4);
            this.radioButtonBAY.Name = "radioButtonBAY";
            this.radioButtonBAY.Size = new System.Drawing.Size(74, 30);
            this.radioButtonBAY.TabIndex = 4;
            this.radioButtonBAY.Text = "BAY";
            this.radioButtonBAY.UseVisualStyleBackColor = false;
            this.radioButtonBAY.CheckedChanged += new System.EventHandler(this.radioButtonBAY_CheckedChanged);
            // 
            // radioButton2BAYAN
            // 
            this.radioButton2BAYAN.AutoSize = true;
            this.radioButton2BAYAN.BackColor = System.Drawing.Color.Transparent;
            this.radioButton2BAYAN.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.radioButton2BAYAN.ForeColor = System.Drawing.Color.Black;
            this.radioButton2BAYAN.Location = new System.Drawing.Point(344, 267);
            this.radioButton2BAYAN.Margin = new System.Windows.Forms.Padding(4);
            this.radioButton2BAYAN.Name = "radioButton2BAYAN";
            this.radioButton2BAYAN.Size = new System.Drawing.Size(103, 30);
            this.radioButton2BAYAN.TabIndex = 5;
            this.radioButton2BAYAN.Text = "BAYAN";
            this.radioButton2BAYAN.UseVisualStyleBackColor = false;
            // 
            // buttonKayıtOluştur
            // 
            this.buttonKayıtOluştur.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonKayıtOluştur.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonKayıtOluştur.ForeColor = System.Drawing.Color.Lime;
            this.buttonKayıtOluştur.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonKayıtOluştur.ImageKey = "give-money.png";
            this.buttonKayıtOluştur.ImageList = this.ımageList1;
            this.buttonKayıtOluştur.Location = new System.Drawing.Point(160, 336);
            this.buttonKayıtOluştur.Margin = new System.Windows.Forms.Padding(4);
            this.buttonKayıtOluştur.Name = "buttonKayıtOluştur";
            this.buttonKayıtOluştur.Size = new System.Drawing.Size(139, 48);
            this.buttonKayıtOluştur.TabIndex = 6;
            this.buttonKayıtOluştur.Text = "SATIŞ";
            this.buttonKayıtOluştur.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonKayıtOluştur.UseVisualStyleBackColor = false;
            this.buttonKayıtOluştur.Click += new System.EventHandler(this.buttonKayıtOluştur_Click);
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "give-money.png");
            this.ımageList1.Images.SetKeyName(1, "cancel.png");
            // 
            // buttonKayıtİptal
            // 
            this.buttonKayıtİptal.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonKayıtİptal.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonKayıtİptal.ForeColor = System.Drawing.Color.Red;
            this.buttonKayıtİptal.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonKayıtİptal.ImageKey = "cancel.png";
            this.buttonKayıtİptal.ImageList = this.ımageList1;
            this.buttonKayıtİptal.Location = new System.Drawing.Point(332, 336);
            this.buttonKayıtİptal.Margin = new System.Windows.Forms.Padding(4);
            this.buttonKayıtİptal.Name = "buttonKayıtİptal";
            this.buttonKayıtİptal.Size = new System.Drawing.Size(140, 48);
            this.buttonKayıtİptal.TabIndex = 7;
            this.buttonKayıtİptal.Text = "İPTAL ";
            this.buttonKayıtİptal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonKayıtİptal.UseVisualStyleBackColor = false;
            this.buttonKayıtİptal.Click += new System.EventHandler(this.buttonKayıtİptal_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(13, 46);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 26);
            this.label1.TabIndex = 9;
            this.label1.Text = "İSİM";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(13, 197);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(150, 26);
            this.label4.TabIndex = 9;
            this.label4.Text = "TELEFON NO:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(13, 122);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 26);
            this.label2.TabIndex = 9;
            this.label2.Text = "SOYİSİM";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // KayıtForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(613, 399);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonKayıtİptal);
            this.Controls.Add(this.buttonKayıtOluştur);
            this.Controls.Add(this.radioButton2BAYAN);
            this.Controls.Add(this.radioButtonBAY);
            this.Controls.Add(this.maskedTextBoxtelefon);
            this.Controls.Add(this.textBoxsoyisim);
            this.Controls.Add(this.textBoxisim);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "KayıtForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "+";
            this.Load += new System.EventHandler(this.KayıtForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonKayıtOluştur;
        private System.Windows.Forms.Button buttonKayıtİptal;
        public System.Windows.Forms.TextBox textBoxisim;
        public System.Windows.Forms.TextBox textBoxsoyisim;
        public System.Windows.Forms.MaskedTextBox maskedTextBoxtelefon;
        public System.Windows.Forms.RadioButton radioButtonBAY;
        public System.Windows.Forms.RadioButton radioButton2BAYAN;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ImageList ımageList1;
    }
}