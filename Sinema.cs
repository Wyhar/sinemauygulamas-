using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sinemauygulaması
{
    internal class Sinema
    {
        int toplamKoltukSayisi;
        int bosKoltukSayisi;
        double bakiye;
        string salonNo;

        const double TAM = 150.00;
        const double INDIRIMLI = 100.00;

        public Sinema (string salon , int koltuksayi)
        {
            toplamKoltukSayisi = koltuksayi;
            salonNo = salon;
            bosKoltukSayisi = toplamKoltukSayisi;
            bakiye = 0;
        }
        public void BiletSat(bool indirimli)
        {
            bosKoltukSayisi--;
            if (indirimli)
            {
                bakiye = INDIRIMLI;
            }
            else
            {
                bakiye += TAM;
            }


        }
        public int BosKoLltukOgren()
        {
            return bosKoltukSayisi;
        }

        public double BakiyeOgren()
        {
            return bakiye;
        }
        public void BiletIpral (bool indirimli)
        {
            bosKoltukSayisi++;
            if (indirimli)
            {
                bakiye = INDIRIMLI;
            }
            else
            {
                bakiye += TAM;
            }
        }

    }
}
