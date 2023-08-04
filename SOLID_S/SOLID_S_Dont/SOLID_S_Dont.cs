using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDSample.UI01
{
    public class SOLID_S_Dont
    {
        public int MaasHesapla(int _calisilanGun)
        {
            return 50 * _calisilanGun;
        }

        public void IzinGunuHesapla(int _ID)
        {
            int calisilanToplamSure = 0;


            if (calisilanToplamSure <= 5)
            {
                Console.WriteLine("10 gün izin hakediş bulunmaktadır");
            }
            else if (calisilanToplamSure <= 10)
            {
                Console.WriteLine("15 gün izin hakediş bulunmaktadır");
            }
            else
            {
                Console.WriteLine("20 gün izin hakediş bulunmaktadır");
            }
        }

        class Personel
        {
            public int ID { get; set; }
            public string Adi { get; set; }
            public string SoyAdi { get; set; }
            public int CalismaSuresiYil { get; set; }

            public List<Personel> PersonelGetir()
            {
                List<Personel> personel = new List<Personel>()
                {
                    new Personel()
                    {
                        ID=1,
                        Adi="nida",
                        SoyAdi="memiş",
                        CalismaSuresiYil=7
                    },
                        new Personel()
                    {
                        ID=2,
                        Adi="melike",
                        SoyAdi="İflazoğlu",
                        CalismaSuresiYil=15
                    },
                        new Personel()
                    {
                        ID=3,
                        Adi="servet",
                        SoyAdi="Gökhan",
                        CalismaSuresiYil=9
                    },
                };

                return personel;
            }
        }
    }
}
