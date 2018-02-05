using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilletLib
{
    public class Bil : KøretøjBaseKlasse
    {



        public override string Nummerplade { get; set; }
        public override DateTime Dato { get; set; }
        public override bool HarBrobizz { get; set; }
        public override int WeekendRabat { get; set; }
        public override int Brobizz { get; set; }




        public override int Pris()
        {
            return 240;
        }

        public override string køretøj()
        {
            return "Bil";    
        }

       


        int prisMedMegetRabat;

        public int weekendRabat(int Pris)
        {
            if (Dato.DayOfWeek == DayOfWeek.Saturday || Dato.DayOfWeek == DayOfWeek.Sunday)
            {
                prisMedMegetRabat = Pris - (Pris * 20/ 100);
                return prisMedMegetRabat;
            }
            else
            {
                return Pris;
            }
        }
    }
}
