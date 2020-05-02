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
    public partial class musterisec : Form
    {
        public musterisec()
        {
            InitializeComponent();
        }

        SqlConnection baglan = new SqlConnection("Data Source=0ĞUZ\\SQLEXPRESS;Initial Catalog=Market Otomasyon;Integrated Security=True;");
        public static string isim, tel;
        public static int musteriSira;
        private void ekle()
        {
            baglan.Open();
            SqlCommand komut = new SqlCommand("Select *from Musteri", baglan);
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                ListViewItem ekle =new ListViewItem();
                ekle.Text = oku["musteriSira"].ToString();
                ekle.SubItems.Add(oku["musteriAdsoyad"].ToString());
                ekle.SubItems.Add(oku["tcNo"].ToString());
                ekle.SubItems.Add(oku["telNo"].ToString());
                ekle.SubItems.Add(oku["adres"].ToString());
                listView1.Items.Add(ekle);

            }
            baglan.Close();
        }
        public void listView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            musteriSira = int.Parse(listView1.SelectedItems[0].SubItems[0].Text);
            isim = listView1.SelectedItems[0].SubItems[1].Text;
            tel = listView1.SelectedItems[0].SubItems[3].Text;
            

            this.Hide();
        }

        private void musterisec_Load(object sender, EventArgs e)
        {
            ekle();
            
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
