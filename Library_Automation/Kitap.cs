using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Automation
{
    public class Kitap
    {
        public uint UID { get; set; }
        public string KitapAdi { get; set; }
        public string Yazar { get; set; }
        public string Yayinevi { get; set; }
        public uint BasimYili { get; set; }
        public string Tur { get; set; }
        public Uye Sahip { get; set; }
        public List<Uye> EskiSahipler;

        public void KitapKirala(Uye t_uye)
        {
            Sahip = t_uye;
        }

        public void KiralikSonlandir()
        {
            EskiSahipler.Add(Sahip);
            Sahip = null;
        }      
    }
}
