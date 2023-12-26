namespace OtobusBiletSatis
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.comboOtobüs = new System.Windows.Forms.ComboBox();
            this.comboKalkış = new System.Windows.Forms.ComboBox();
            this.comboVarış = new System.Windows.Forms.ComboBox();
            this.comboSaat = new System.Windows.Forms.ComboBox();
            this.dateTarih = new System.Windows.Forms.DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxFiyat = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.rezerveEtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.RezNo = new System.Windows.Forms.TextBox();
            this.geridön = new System.Windows.Forms.Button();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.groupBox1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(586, 474);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Firma Seçiniz:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 28);
            this.label2.TabIndex = 1;
            this.label2.Text = "Kalkış Yeri:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 28);
            this.label3.TabIndex = 2;
            this.label3.Text = "Varış Yeri";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(586, 323);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 28);
            this.label4.TabIndex = 3;
            this.label4.Text = "Tarih";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(586, 396);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 28);
            this.label5.TabIndex = 4;
            this.label5.Text = "Saat";
            // 
            // comboOtobüs
            // 
            this.comboOtobüs.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboOtobüs.FormattingEnabled = true;
            this.comboOtobüs.Items.AddRange(new object[] {
            "METRO",
            "PAMUKKALE",
            "ES",
            "KAMİLKOÇ"});
            this.comboOtobüs.Location = new System.Drawing.Point(756, 471);
            this.comboOtobüs.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comboOtobüs.Name = "comboOtobüs";
            this.comboOtobüs.Size = new System.Drawing.Size(178, 36);
            this.comboOtobüs.TabIndex = 5;
            this.comboOtobüs.SelectedIndexChanged += new System.EventHandler(this.comboOtobüs_SelectedIndexChanged);
            // 
            // comboKalkış
            // 
            this.comboKalkış.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboKalkış.FormattingEnabled = true;
            this.comboKalkış.Location = new System.Drawing.Point(179, 13);
            this.comboKalkış.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comboKalkış.Name = "comboKalkış";
            this.comboKalkış.Size = new System.Drawing.Size(178, 36);
            this.comboKalkış.TabIndex = 6;
            this.comboKalkış.SelectedIndexChanged += new System.EventHandler(this.comboKalkış_SelectedIndexChanged);
            // 
            // comboVarış
            // 
            this.comboVarış.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboVarış.FormattingEnabled = true;
            this.comboVarış.Location = new System.Drawing.Point(179, 98);
            this.comboVarış.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comboVarış.Name = "comboVarış";
            this.comboVarış.Size = new System.Drawing.Size(178, 36);
            this.comboVarış.TabIndex = 7;
            this.comboVarış.SelectedIndexChanged += new System.EventHandler(this.comboVarış_SelectedIndexChanged);
            // 
            // comboSaat
            // 
            this.comboSaat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboSaat.FormattingEnabled = true;
            this.comboSaat.Location = new System.Drawing.Point(756, 396);
            this.comboSaat.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comboSaat.Name = "comboSaat";
            this.comboSaat.Size = new System.Drawing.Size(178, 36);
            this.comboSaat.TabIndex = 8;
            // 
            // dateTarih
            // 
            this.dateTarih.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTarih.Location = new System.Drawing.Point(756, 323);
            this.dateTarih.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dateTarih.Name = "dateTarih";
            this.dateTarih.Size = new System.Drawing.Size(178, 34);
            this.dateTarih.TabIndex = 9;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.comboKalkış);
            this.groupBox1.Controls.Add(this.comboVarış);
            this.groupBox1.Location = new System.Drawing.Point(575, 64);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(384, 161);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "İSTİKAMET";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(586, 253);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 28);
            this.label6.TabIndex = 12;
            this.label6.Text = "Fiyat";
            // 
            // textBoxFiyat
            // 
            this.textBoxFiyat.Enabled = false;
            this.textBoxFiyat.Location = new System.Drawing.Point(754, 253);
            this.textBoxFiyat.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxFiyat.Name = "textBoxFiyat";
            this.textBoxFiyat.Size = new System.Drawing.Size(178, 34);
            this.textBoxFiyat.TabIndex = 13;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rezerveEtToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(148, 28);
            // 
            // rezerveEtToolStripMenuItem
            // 
            this.rezerveEtToolStripMenuItem.Name = "rezerveEtToolStripMenuItem";
            this.rezerveEtToolStripMenuItem.Size = new System.Drawing.Size(147, 24);
            this.rezerveEtToolStripMenuItem.Text = "Rezerve Et";
            this.rezerveEtToolStripMenuItem.Click += new System.EventHandler(this.rezerveEtToolStripMenuItem_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.BlinkRate = 300;
            this.errorProvider1.ContainerControl = this;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(88, -1);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(213, 19);
            this.label8.TabIndex = 15;
            this.label8.Text = "*****KOLTUK SEÇİM ALANI*****";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(581, 9);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(158, 28);
            this.label9.TabIndex = 16;
            this.label9.Text = "Rezervasyon No";
            // 
            // RezNo
            // 
            this.RezNo.Enabled = false;
            this.RezNo.Location = new System.Drawing.Point(754, 6);
            this.RezNo.Name = "RezNo";
            this.RezNo.Size = new System.Drawing.Size(183, 34);
            this.RezNo.TabIndex = 17;
            // 
            // geridön
            // 
            this.geridön.BackColor = System.Drawing.Color.White;
            this.geridön.ForeColor = System.Drawing.Color.Black;
            this.geridön.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.geridön.ImageKey = "turn-left.png";
            this.geridön.ImageList = this.ımageList1;
            this.geridön.Location = new System.Drawing.Point(725, 539);
            this.geridön.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.geridön.Name = "geridön";
            this.geridön.Size = new System.Drawing.Size(207, 59);
            this.geridön.TabIndex = 10;
            this.geridön.Text = "GERİ DÖN";
            this.geridön.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.geridön.UseVisualStyleBackColor = false;
            this.geridön.Click += new System.EventHandler(this.geridön_Click);
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "turn-left.png");
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1051, 611);
            this.Controls.Add(this.RezNo);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBoxFiyat);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.geridön);
            this.Controls.Add(this.dateTarih);
            this.Controls.Add(this.comboSaat);
            this.Controls.Add(this.comboOtobüs);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kayıt Ekranı";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem rezerveEtToolStripMenuItem;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        public System.Windows.Forms.TextBox RezNo;
        public System.Windows.Forms.ComboBox comboOtobüs;
        public System.Windows.Forms.ComboBox comboKalkış;
        public System.Windows.Forms.ComboBox comboVarış;
        public System.Windows.Forms.ComboBox comboSaat;
        public System.Windows.Forms.DateTimePicker dateTarih;
        public System.Windows.Forms.TextBox textBoxFiyat;
        public System.Windows.Forms.Button geridön;
        private System.Windows.Forms.ImageList ımageList1;
    }
}

