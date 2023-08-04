using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_S.SOLID_S_Do
{
    public class Personel
    {
        public string Adi { get; set; }
        public string SoyAdi { get; set; }
        public int CalismaSuresiYil { get; set; }

        public List<Personel> PersonelGetir()
        {
            List<Personel> personel = new List<Personel>()
                {
                    new Personel()
                    {
                        Adi="nida",
                        SoyAdi="Gökhan",
                        CalismaSuresiYil=7
                    },
                        new Personel()
                    {
                        Adi="melike",
                        SoyAdi="memiş",
                        CalismaSuresiYil=15
                    },
                            new Personel()
                    {
                        Adi="servet",
                        SoyAdi="İflazoğlu",
                        CalismaSuresiYil=9
                    },
                };

            return personel;
        }
    }
}
