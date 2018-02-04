
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilletLib
{
    public class KøretøjBaseKlasse
    {

        private string _nummerplade;
        private DateTime _dato;
        private bool _harbrobizz;

        public KøretøjBaseKlasse()
        {
            _nummerplade = Nummerplade;
            _dato = Dato;
            _harbrobizz = HarBrobizz;
            if (Nummerplade.Length >= 8)
            {

                throw new ArgumentOutOfRangeException("Nummerplade var for lang");


            }


        }

        public string Nummerplade { get; set; }
        public DateTime Dato { get; set; }
        public bool HarBrobizz { get; set; }
       
       

        public virtual int Pris()
        {
            return 0;
        }

        public virtual string køretøj()
        {
            return "Køretøj";
        }

        int prismedrabat;
        public int Billet(int Pris)
        {

            if (HarBrobizz == true)
            {
                prismedrabat = Pris * (100 / 5);
                return prismedrabat;
            }
            else
            {
                return Pris;
            }
           
        }

        int prismedmegetrabat;

        public int rabat(int Pris)
        {
            if (Dato.DayOfWeek.Equals("Lørdag") || Dato.DayOfWeek.Equals("Søndag") )
            {
                prismedmegetrabat = Pris * (100 / 20);
                return prismedmegetrabat;
            }
            else
            {
                return Pris;
            }
        }

    }
}
