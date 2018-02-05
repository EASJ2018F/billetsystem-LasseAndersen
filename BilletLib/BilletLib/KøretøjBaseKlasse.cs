
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilletLib
{
    public abstract class KøretøjBaseKlasse
    {

        public abstract string Nummerplade { get; set; }
        public abstract DateTime Dato { get; set; }
        public abstract bool HarBrobizz { get; set; }
        public abstract int WeekendRabat { get; set; }
        public abstract int Brobizz { get; set; }



        public abstract int Pris();

        public abstract string køretøj();
        

        public int NummerpladeCheck()
        {
            if (Nummerplade.Length > 7)
            {
                throw new ArgumentException("Nummerpladen er for lang eller for kort");
            }
            return Nummerplade.Length;
        }

        int prismedrabat;
        public int Billet(int Pris)
        {

            if (HarBrobizz)
            {
                prismedrabat = Pris * (100 / 5);
                return prismedrabat;
            }
            else
            {
                return Pris;
            }
           
        }



 

    }
}
