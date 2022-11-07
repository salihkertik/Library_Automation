using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library_Automation
{
    public partial class Form1 : Form
    {
        public List<Kitap> kitaplar = new List<Kitap>();

        public uint KitapSayac = 0;
        public List<string> KitapTurleri = new List<string>();
        public string[] kitapturleri = {"Polisiye", "Bilim Kurgu", "Gerilim", "Deneme" };

        public Form1()
        {
            InitializeComponent();
            //BindingSource bindingSource = new BindingSource();
            //bindingSource.DataSource = kutuphane.KitapList;
            //kitapGrid.DataSource = bindingSource;
            //var list = new BindingList<Kitap>(kutuphane.KitapList);

            comboBox1.DataSource = kitapturleri;
            
        }
        Kutuphane kutuphane = new Kutuphane();
        private void KitapEkle_Click(object sender, EventArgs e)
        {
            Kitap kitap = new Kitap();
            kitap.Yazar = YazarAdi.Text;
            kitap.Tur = comboBox1.Text;
            kitap.KitapAdi = KitapAdi.Text;
            kitap.Yayinevi = YayinEvi.Text;
            kitap.BasimYili = Convert.ToUInt32(BasimYili.Text);

            KitapSayac += 1;
            kitap.UID = KitapSayac;

            kutuphane.kitaplar.Add(kitap);

            kitapGrid.DataSource = null;
            kitapGrid.DataSource = kutuphane.kitaplar;
        }

        private void KitapTasi_Click(object sender, EventArgs e)
        {

        }
    }
}
