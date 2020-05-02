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

namespace Market_Uygulaması
{
    public partial class Genelİşlemler : Form
    {
        public Genelİşlemler()
        {
            InitializeComponent();
        }
        int musteriSira,ürünsira;
        Boolean hatalı = true;
        public static string barkod;
        int musterisirasatis,satisSiraSil;
        double toplam;

        SqlConnection baglan = new SqlConnection("Data Source=0ĞUZ\\SQLEXPRESS;Initial Catalog=Market Otomasyon;Integrated Security=True;");

        #region müşteri işlemleri
        private void müsterikaydet()
        {
            baglan.Open();
            SqlCommand komut = new SqlCommand("insert into Musteri(musteriAdsoyad,tcNo,telNo,adres) values('" + textBox2.Text.ToString() + "','" + maskedTextBox1.Text.ToString() + "','" + maskedTextBox2.Text.ToString() + "','" + textBox3.Text.ToString() + "')", baglan);
            komut.ExecuteNonQuery();
            baglan.Close();
        }
        private void musteritemizle()
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            maskedTextBox1.Clear();
            maskedTextBox2.Clear();
        }
        private void musterigüncelle()
        {
            baglan.Open();
            SqlCommand komut = new SqlCommand("update Musteri set musteriAdsoyad='" + textBox2.Text + "',tcNo='" + maskedTextBox1.Text + "',telNo='" + maskedTextBox2.Text + "',adres='" + textBox3.Text + "' where musteriSira='"+musteriSira+"' ", baglan);
            komut.ExecuteNonQuery();
            this.musteriTableAdapter1.Fill(this.market_OtomasyonDataSet2.Musteri);
            baglan.Close();
        }
        private void musterisil()
        {
            baglan.Open();
            SqlCommand komut = new SqlCommand("delete from Musteri where musteriSira='" + musteriSira + "'  ", baglan);
            komut.ExecuteNonQuery();
            this.musteriTableAdapter1.Fill(this.market_OtomasyonDataSet2.Musteri);
            baglan.Close();
        }
        private void btnkaydetmüş_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == "" || textBox3.Text == "" || maskedTextBox1.Text == "" || maskedTextBox2.Text == "")
            {
                MessageBox.Show("Boş Alanları Doldurunuz", "Boş Alan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                müsterikaydet();
                musteritemizle();
                this.musteriTableAdapter1.Fill(this.market_OtomasyonDataSet2.Musteri);
            }

        }

        private void dataGridView4_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int seçilenalan = dataGridView4.SelectedCells[0].RowIndex;
            string adsoyad = dataGridView4.Rows[seçilenalan].Cells[1].Value.ToString();
            string tcno = dataGridView4.Rows[seçilenalan].Cells[2].Value.ToString();
            string telno = dataGridView4.Rows[seçilenalan].Cells[3].Value.ToString();
            string adres = dataGridView4.Rows[seçilenalan].Cells[4].Value.ToString();
            musteriSira = int.Parse(dataGridView4.Rows[seçilenalan].Cells[0].Value.ToString());

            textBox2.Text = adsoyad;
            maskedTextBox1.Text = tcno;
            maskedTextBox2.Text = telno;
            textBox3.Text = adres;
        }

        private void btnyenimüş_Click_1(object sender, EventArgs e)
        {
            musteritemizle();
        }

        private void btngüncellemüş_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == "" || textBox3.Text == "" || maskedTextBox1.Text == "" || maskedTextBox2.Text == "")
            {
                MessageBox.Show("Boş Alanları Doldurunuz", "Boş Alan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                musterigüncelle();
                musteritemizle();

            }

        }

        private void btnsilmüş_Click(object sender, EventArgs e)
        {
            musterisil();
            musteritemizle();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            baglan.Open();

            DataTable tbl = new DataTable();
            SqlDataAdapter ara = new SqlDataAdapter("select *from Musteri where musteriAdsoyad like '%" + textBox1.Text + "%' ", baglan);
            ara.Fill(tbl);
            baglan.Close();
            dataGridView4.DataSource = tbl;

        }


        #endregion

        #region ürün işlemleri
        private void ürünkaydet()
        {
            string birimfiyat = txtbirim.Text.ToString().Replace(",", ".");
            Convert.ToDouble(birimfiyat);
            baglan.Open();
            SqlCommand komut = new SqlCommand("select *from ürün", baglan);
            komut.ExecuteNonQuery();
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                if (oku["barkod"].ToString() == txtbarkod.Text)
                {
                    MessageBox.Show("Barkod Numarası Başka Ürünle Aynı Olamaz", "Barkod Numarası", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    hatalı = false;
                    txtbarkod.Clear();
                }
                
            }
            baglan.Close();
           if(hatalı)
                {
                    baglan.Open();
                    SqlCommand komut2 = new SqlCommand("insert into ürün(ürünadi,barkod,stokMiktari,birimFiyatı,kategori) values('" + txtisim.Text + "','" + txtbarkod.Text + "','" + int.Parse(txtmiktar.Text) + "','" + birimfiyat + "','" + cmbxkategori.Text + "')", baglan);
                    komut2.ExecuteNonQuery();
                    this.ürünTableAdapter.Fill(this.market_OtomasyonDataSet3.ürün);
                    baglan.Close();
                    ürüntemizle();
               baglan.Close();
                }
           hatalı = true;
        
        }
        private void ürüngüncelle()
        {
            string birimfiyat = txtbirim.Text.ToString().Replace(",", ".");
            Convert.ToDouble(birimfiyat);
            baglan.Close();
                baglan.Open();
                SqlCommand komut2 = new SqlCommand("update ürün set ürünadi='" + txtisim.Text + "',barkod='" + txtbarkod.Text + "',stokMiktari='" + int.Parse(txtmiktar.Text) + "',birimFiyatı='" + birimfiyat + "',kategori='" + cmbxkategori.Text + "' where ürünSira='" + ürünsira + "' ", baglan);
                komut2.ExecuteNonQuery();
                this.ürünTableAdapter.Fill(this.market_OtomasyonDataSet3.ürün);
                baglan.Close();
                ürüntemizle();
            
           
        }
        private void ürünsil()
        {
            baglan.Open();
            SqlCommand komut = new SqlCommand("delete from ürün where ürünSira='" + ürünsira + "' ", baglan);
            komut.ExecuteNonQuery();
            this.ürünTableAdapter.Fill(this.market_OtomasyonDataSet3.ürün);
            baglan.Close();
        }
        private void ürüntemizle()
        {
            txtisim.Clear();
            txtbarkod.Clear();
            txtbirim.Clear();
            txtmiktar.Clear();
            cmbxkategori.Text = "";
            txtarama.Clear();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            int seçilenalan = dataGridView1.SelectedCells[0].RowIndex;
            string ürünadı = dataGridView1.Rows[seçilenalan].Cells[1].Value.ToString();
            barkod = dataGridView1.Rows[seçilenalan].Cells[2].Value.ToString();
            string stokmiktarı = dataGridView1.Rows[seçilenalan].Cells[3].Value.ToString();
            string birimfiyat = dataGridView1.Rows[seçilenalan].Cells[4].Value.ToString();
            string kategori = dataGridView1.Rows[seçilenalan].Cells[5].Value.ToString();
            ürünsira = int.Parse(dataGridView4.Rows[seçilenalan].Cells[0].Value.ToString());

            txtisim.Text = ürünadı;
            txtbarkod.Text=barkod;
            txtmiktar.Text = stokmiktarı;
            txtbirim.Text = birimfiyat;
            cmbxkategori.Text = kategori;
        }

        private void btnkaydetürün_Click(object sender, EventArgs e)
        {
            if (txtbarkod.Text == "" || txtisim.Text == "" || txtbirim.Text == "" || txtmiktar.Text == "" || cmbxkategori.Text == "")
            {
                MessageBox.Show("Boş Alanları Doldurunuz", "Boş Alan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else 
                ürünkaydet();   
        }

        private void btnsilürün_Click(object sender, EventArgs e)
        {
            ürünsil();
            ürüntemizle();
            
           
        }

        private void btngüncelleürün_Click(object sender, EventArgs e)
        {
            if (txtbarkod.Text == "" || txtisim.Text == "" || txtbirim.Text == "" || txtmiktar.Text == "" || cmbxkategori.Text == "")
            {
                MessageBox.Show("Boş Alanları Doldurunuz", "Boş Alan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                ürüngüncelle();
               
            }

        }

        private void btnyeniürün_Click(object sender, EventArgs e)
        {
            ürüntemizle();
        }

        private void txtarama_TextChanged(object sender, EventArgs e)
        {
            baglan.Open();

            DataTable tblo = new DataTable();
            SqlDataAdapter arama = new SqlDataAdapter("select *from ürün where ürünadi like '%" + txtarama.Text + "%' ", baglan);
            arama.Fill(tblo);
            baglan.Close();
            dataGridView1.DataSource = tblo;
        }

        #endregion

        #region satış işlemleri

        private void satismüslistele()
        {
            if (rdbtümü.Checked)
            {
                baglan.Open();

                DataTable tblo = new DataTable();
                SqlDataAdapter listele = new SqlDataAdapter("select satısSira,satisTarih,satisToplam,musteriAdsoyad,musteri.musteriSira from satis join Musteri on satis.musteriSira=Musteri.musteriSira ", baglan);
                listele.Fill(tblo);
                baglan.Close();
                dataGridView2.DataSource = tblo;
            }
        }
        
        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int seçilenalan = dataGridView2.SelectedCells[0].RowIndex;
            musterisirasatis = int.Parse(dataGridView2.Rows[seçilenalan].Cells[4].Value.ToString());

            baglan.Open();
            DataTable tblo = new DataTable();
            SqlDataAdapter listele = new SqlDataAdapter("select barkod,ürünadi,üsMiktar,birimFiyatı,kategori from satisdetay join satis on satis.satısSira=satisdetay.satisSira join ürün on satisdetay.ürünSira=ürün.ürünSira join Musteri on satis.musteriSira=Musteri.musteriSira where musteri.musteriSira='" + musterisirasatis + "' ", baglan);
            listele.Fill(tblo);
            baglan.Close();
            dataGridView3.DataSource = tblo;
        }
        private void rdbtümü_CheckedChanged(object sender, EventArgs e)
        {
            satismüslistele();
            satisTopla();
        }
        private void satisSil()
        {
            int seçilenalan = dataGridView2.SelectedCells[0].RowIndex;
             satisSiraSil= int.Parse(dataGridView2.Rows[seçilenalan].Cells[0].Value.ToString());
            baglan.Open();
            SqlCommand komut=new SqlCommand("delete from satis where satis.satısSira='"+satisSiraSil+"' ",baglan);
            komut.ExecuteNonQuery();
            baglan.Close();
            satismüslistele();
        }
        private void satisTopla()
        {
            
            baglan.Open();
            SqlCommand komut = new SqlCommand("select satisToplam from satis", baglan);
            komut.ExecuteNonQuery();
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                toplam = double.Parse(oku["satisToplam"].ToString());
            }
            baglan.Close();
            labeltoplam.Text = "Liste Toplamı:"+toplam.ToString()+" tl ";
        }

        #endregion

        private void Genelİşlemler_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'market_OtomasyonDataSet3.ürün' table. You can move, or remove it, as needed.
            this.ürünTableAdapter.Fill(this.market_OtomasyonDataSet3.ürün);
            // TODO: This line of code loads data into the 'market_OtomasyonDataSet2.Musteri' table. You can move, or remove it, as needed.
            this.musteriTableAdapter1.Fill(this.market_OtomasyonDataSet2.Musteri);
            dataGridView2.Columns[4].Visible = false;
            
            
            
        }

        private void btnsilsatış_Click(object sender, EventArgs e)
        {
            satisSil();
        }

     

      

       
        //private void txtbarkod_TextChanged(object sender, EventArgs e)
        //{
            //baglan.Close();

            //if (txtbarkod.Text != barkod)
            //{
            //    baglan.Open();
            //    SqlCommand komut = new SqlCommand("select barkod from  ürün", baglan);
            //    komut.ExecuteNonQuery();
            //    SqlDataReader oku = komut.ExecuteReader();
            //    while (oku.Read())
            //    {
            //        if (oku["barkod"].ToString() == txtbarkod.Text)
            //        {
            //            MessageBox.Show("Barkod Numarası Başka Ürünle Aynı Olamaz", "Barkod Numarası", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //            hatalı = false;
            //            txtbarkod.Clear();
            //        }
            //        baglan.Close();
            //    }
            //    hatalı = true;

            //}
        //}


    }
}

