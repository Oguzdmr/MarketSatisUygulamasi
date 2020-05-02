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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        SqlConnection baglan = new SqlConnection("Data Source=0ĞUZ\\SQLEXPRESS;Initial Catalog=Market Otomasyon;Integrated Security=True;");
        double toplam;
        int üsmiktar,ürünSira,satisSira;
        string tarih=DateTime.Now.ToString();
        Boolean ürünyok = true;
        
        private void ürünoku()
        {
            baglan.Open();
            SqlCommand komut = new SqlCommand("Select * from ürün", baglan);
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                if (txtbarkod.Text == oku["barkod"].ToString())
                {
                    ürünSira = int.Parse(oku["ürünSira"].ToString());
                    ListViewItem ekle = new ListViewItem();
                    ekle.Text = oku["barkod"].ToString();
                    ekle.SubItems.Add(oku["ürünadi"].ToString());
                    ekle.SubItems.Add(txtmiktar.Text);
                    üsmiktar = int.Parse(txtmiktar.Text.ToString());
                    ekle.SubItems.Add(oku["birimFiyatı"].ToString());
                    ekle.SubItems.Add((double.Parse(txtmiktar.Text) * double.Parse(oku["birimFiyatı"].ToString())).ToString());
                    listView1.Items.Add(ekle);
                    toplam += double.Parse(txtmiktar.Text) * double.Parse(oku["birimFiyatı"].ToString());
                    labelfiyat.Text = Convert.ToString(toplam);
                    ürünyok=false;
                }
                
            }
            if (ürünyok)
                    MessageBox.Show("Ürün Bulunamadı!!!","Ürün",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            baglan.Close();
            ürünyok = true;
            
        }

        private void satis()
        {
            string toplam2=toplam.ToString().Replace(",", ".");
            Convert.ToDouble(toplam2);
            baglan.Open();
            SqlCommand komut1 = new SqlCommand("insert into satis(musteriSira,satisToplam) values('"+musterisec.musteriSira+"','"+toplam2+"') ",baglan);
            komut1.ExecuteNonQuery();
            baglan.Close();

            baglan.Open();
            SqlCommand komut2 = new SqlCommand("select satısSira from satis", baglan);
            SqlDataReader satissiraoku = komut2.ExecuteReader();
            while (satissiraoku.Read())
            {
                satisSira = int.Parse(satissiraoku["satısSira"].ToString());
            }
            baglan.Close();


            baglan.Open();
            SqlCommand komut3 = new SqlCommand("insert into satisdetay(üsMiktar,ürünSira,satisSira) values('" + üsmiktar + "','"+ürünSira+"','"+satisSira+"')",baglan);
            komut3.ExecuteNonQuery();
            baglan.Close();

        }
        private void btnürünekle_Click(object sender, EventArgs e)
        {
            if (txtmiktar.Text == "" || txtbarkod.Text == "")
            {
                MessageBox.Show("Alanları Doldurunuz!!!","Boş Alan",MessageBoxButtons.OK,MessageBoxIcon.Warning);
               
            }
            else {
                ürünoku();
                txtbarkod.Clear();
                txtmiktar.Clear();
                
           
            }
               
        }

        private void button4_Click(object sender, EventArgs e)
        {
             txtadsoyad.Text = musterisec.isim;
             mskdtxttelno.Text = musterisec.tel;

        }

        private void btnmüsterisec_Click(object sender, EventArgs e)
        {
            musterisec sec = new musterisec();
            
            
            sec.Show();
            
        }

        private void btncıkıs_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void listView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            listView1.FullRowSelect = true;
        }

        private void btnürüncıkar_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedIndices.Count > 0) 
                listView1.Items.RemoveAt(listView1.SelectedItems[0].Index); 
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            txtadsoyad.Clear();
            mskdtxttelno.Clear();
            labelfiyat.Text = "0";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            satis();
            listView1.Items.Clear();
            txtadsoyad.Clear();
            mskdtxttelno.Clear();
            labelfiyat.Text = "0";

        }

        private void btngenelislem_Click(object sender, EventArgs e)
        {
            Genelİşlemler frm = new Genelİşlemler();
            frm.Show();
            this.Hide();
        }
    }
}
