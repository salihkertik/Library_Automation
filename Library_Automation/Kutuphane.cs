using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library_Automation
{
    public class Kutuphane
    {
        public string KutuphaneIsmi { get; set; }
        public List<Raf> raflar = new List<Raf>();
        public List<Kitap> kitaplar = new List<Kitap>();
        public List<Uye> UyeList;

        public void UyeEkle(Uye t_uye)
        {
            UyeList.Add(t_uye);
        }

        public void UyeSil(Uye t_uye)
        {
            if (t_uye.AldigiKitapList.Count >= 0)
            {
                MessageBox.Show("Üyelik Silinemedi, Kiralık Kitap Mevcut..");
            }
            else
            {
                UyeList.Remove(t_uye);
            }
            
        }

        public void RafEkle(Raf t_raf)
        {
            RafList.Add(t_raf);
        }

        public void RafSil(Raf t_raf)
        {
            RafList.Remove(t_raf);
        }

        public void KitapEkle()
        {

        }


    }
}
