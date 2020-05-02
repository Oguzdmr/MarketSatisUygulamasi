namespace Market_Uygulaması
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btngenelislem = new System.Windows.Forms.Button();
            this.btncıkıs = new System.Windows.Forms.Button();
            this.btnrapor = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtadsoyad = new System.Windows.Forms.TextBox();
            this.mskdtxttelno = new System.Windows.Forms.MaskedTextBox();
            this.txtbarkod = new System.Windows.Forms.TextBox();
            this.txtmiktar = new System.Windows.Forms.TextBox();
            this.btnürünekle = new System.Windows.Forms.Button();
            this.btnürüncıkar = new System.Windows.Forms.Button();
            this.btnmüsterisec = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.labelfiyat = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button4 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btngenelislem
            // 
            this.btngenelislem.BackColor = System.Drawing.Color.Gray;
            this.btngenelislem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btngenelislem.Location = new System.Drawing.Point(12, 12);
            this.btngenelislem.Name = "btngenelislem";
            this.btngenelislem.Size = new System.Drawing.Size(169, 49);
            this.btngenelislem.TabIndex = 0;
            this.btngenelislem.Text = "Genel  İşlemler";
            this.btngenelislem.UseVisualStyleBackColor = false;
            this.btngenelislem.Click += new System.EventHandler(this.btngenelislem_Click);
            // 
            // btncıkıs
            // 
            this.btncıkıs.BackColor = System.Drawing.Color.Gray;
            this.btncıkıs.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btncıkıs.ForeColor = System.Drawing.Color.DarkRed;
            this.btncıkıs.Location = new System.Drawing.Point(250, 12);
            this.btncıkıs.Name = "btncıkıs";
            this.btncıkıs.Size = new System.Drawing.Size(182, 49);
            this.btncıkıs.TabIndex = 1;
            this.btncıkıs.Text = "Çıkış";
            this.btncıkıs.UseVisualStyleBackColor = false;
            this.btncıkıs.Click += new System.EventHandler(this.btncıkıs_Click);
            // 
            // btnrapor
            // 
            this.btnrapor.BackColor = System.Drawing.Color.Gray;
            this.btnrapor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnrapor.Location = new System.Drawing.Point(486, 12);
            this.btnrapor.Name = "btnrapor";
            this.btnrapor.Size = new System.Drawing.Size(168, 49);
            this.btnrapor.TabIndex = 2;
            this.btnrapor.Text = "Satış Raporları";
            this.btnrapor.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(12, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Ad Soyad:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(245, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Tel No:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(9, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Barkod No:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(247, 116);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "Miktar:";
            // 
            // txtadsoyad
            // 
            this.txtadsoyad.Location = new System.Drawing.Point(88, 80);
            this.txtadsoyad.Name = "txtadsoyad";
            this.txtadsoyad.Size = new System.Drawing.Size(151, 20);
            this.txtadsoyad.TabIndex = 7;
            // 
            // mskdtxttelno
            // 
            this.mskdtxttelno.Location = new System.Drawing.Point(317, 80);
            this.mskdtxttelno.Mask = "(999) 000-0000";
            this.mskdtxttelno.Name = "mskdtxttelno";
            this.mskdtxttelno.Size = new System.Drawing.Size(113, 20);
            this.mskdtxttelno.TabIndex = 8;
            // 
            // txtbarkod
            // 
            this.txtbarkod.Location = new System.Drawing.Point(88, 116);
            this.txtbarkod.Name = "txtbarkod";
            this.txtbarkod.Size = new System.Drawing.Size(151, 20);
            this.txtbarkod.TabIndex = 9;
            // 
            // txtmiktar
            // 
            this.txtmiktar.Location = new System.Drawing.Point(317, 117);
            this.txtmiktar.Name = "txtmiktar";
            this.txtmiktar.Size = new System.Drawing.Size(113, 20);
            this.txtmiktar.TabIndex = 10;
            // 
            // btnürünekle
            // 
            this.btnürünekle.BackColor = System.Drawing.Color.Gray;
            this.btnürünekle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnürünekle.ForeColor = System.Drawing.Color.Black;
            this.btnürünekle.Location = new System.Drawing.Point(458, 112);
            this.btnürünekle.Name = "btnürünekle";
            this.btnürünekle.Size = new System.Drawing.Size(156, 29);
            this.btnürünekle.TabIndex = 11;
            this.btnürünekle.Text = "Ürün Ekle";
            this.btnürünekle.UseVisualStyleBackColor = false;
            this.btnürünekle.Click += new System.EventHandler(this.btnürünekle_Click);
            // 
            // btnürüncıkar
            // 
            this.btnürüncıkar.BackColor = System.Drawing.Color.Gray;
            this.btnürüncıkar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnürüncıkar.ForeColor = System.Drawing.Color.Black;
            this.btnürüncıkar.Location = new System.Drawing.Point(629, 112);
            this.btnürüncıkar.Name = "btnürüncıkar";
            this.btnürüncıkar.Size = new System.Drawing.Size(152, 29);
            this.btnürüncıkar.TabIndex = 12;
            this.btnürüncıkar.Text = "Seçili Ürünü Çıkar";
            this.btnürüncıkar.UseVisualStyleBackColor = false;
            this.btnürüncıkar.Click += new System.EventHandler(this.btnürüncıkar_Click);
            // 
            // btnmüsterisec
            // 
            this.btnmüsterisec.BackColor = System.Drawing.Color.Gray;
            this.btnmüsterisec.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnmüsterisec.ForeColor = System.Drawing.Color.Black;
            this.btnmüsterisec.Location = new System.Drawing.Point(458, 75);
            this.btnmüsterisec.Name = "btnmüsterisec";
            this.btnmüsterisec.Size = new System.Drawing.Size(97, 29);
            this.btnmüsterisec.TabIndex = 13;
            this.btnmüsterisec.Text = "Müşteri Seç";
            this.btnmüsterisec.UseVisualStyleBackColor = false;
            this.btnmüsterisec.Click += new System.EventHandler(this.btnmüsterisec_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(691, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(165, 84);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Gray;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button2.Location = new System.Drawing.Point(374, 420);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(132, 49);
            this.button2.TabIndex = 17;
            this.button2.Text = "Satış İptal";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Gray;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button3.Location = new System.Drawing.Point(522, 420);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(132, 49);
            this.button3.TabIndex = 18;
            this.button3.Text = "Satışı Tamamla";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // labelfiyat
            // 
            this.labelfiyat.BackColor = System.Drawing.Color.Gray;
            this.labelfiyat.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelfiyat.Location = new System.Drawing.Point(677, 420);
            this.labelfiyat.Name = "labelfiyat";
            this.labelfiyat.Size = new System.Drawing.Size(179, 46);
            this.labelfiyat.TabIndex = 19;
            this.labelfiyat.Text = "0";
            this.labelfiyat.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // listView1
            // 
            this.listView1.BackColor = System.Drawing.Color.Gray;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.listView1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.listView1.Location = new System.Drawing.Point(9, 150);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(847, 267);
            this.listView1.TabIndex = 20;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listView1_MouseDoubleClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Barkod";
            this.columnHeader1.Width = 141;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Ürün İsmi";
            this.columnHeader2.Width = 266;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Miktar";
            this.columnHeader3.Width = 168;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Birim Fiyat";
            this.columnHeader4.Width = 164;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Toplam";
            this.columnHeader5.Width = 103;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Gray;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button4.ForeColor = System.Drawing.Color.Black;
            this.button4.Location = new System.Drawing.Point(580, 75);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(96, 29);
            this.button4.TabIndex = 21;
            this.button4.Text = "Müşteri Yaz";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Tan;
            this.ClientSize = new System.Drawing.Size(868, 475);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.labelfiyat);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnmüsterisec);
            this.Controls.Add(this.btnürüncıkar);
            this.Controls.Add(this.btnürünekle);
            this.Controls.Add(this.txtmiktar);
            this.Controls.Add(this.txtbarkod);
            this.Controls.Add(this.mskdtxttelno);
            this.Controls.Add(this.txtadsoyad);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnrapor);
            this.Controls.Add(this.btncıkıs);
            this.Controls.Add(this.btngenelislem);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btngenelislem;
        private System.Windows.Forms.Button btncıkıs;
        private System.Windows.Forms.Button btnrapor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtbarkod;
        private System.Windows.Forms.TextBox txtmiktar;
        private System.Windows.Forms.Button btnürünekle;
        private System.Windows.Forms.Button btnürüncıkar;
        private System.Windows.Forms.Button btnmüsterisec;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label labelfiyat;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        public System.Windows.Forms.TextBox txtadsoyad;
        public System.Windows.Forms.MaskedTextBox mskdtxttelno;
        private System.Windows.Forms.Button button4;
    }
}

