using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Automation
{
    public class Uye
    {
        public string Isim { get; set; }
        public string Soyisim { get; set; }
        public List<Kitap> AldigiKitapList;
        public List<Kitap> EskiAldigiKitapList;

        public void Kirala(Kitap t_kitap)
        {
            AldigiKitapList.Add(t_kitap);
            t_kitap.KitapKirala(this);

        }
        public void KiralikSonlandir(Kitap t_kitap)
        {
            AldigiKitapList.Remove(t_kitap);
            EskiAldigiKitapList.Add(t_kitap);
            t_kitap.KiralikSonlandir();
        }
    }
}
