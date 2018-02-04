using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilletLib
{
   public class MC : KøretøjBaseKlasse
    {

        public override string Nummerplade { get; set; }
        public override DateTime Dato { get; set; }
        public override bool HarBrobizz { get; set; }
        public override int WeekendRabat { get; set; }
        public override int Brobizz { get; set; }

       
        public override int Pris()
        {
            return 125;
        }

        public override string køretøj()
        {
            return "MC";    
        }
    }
}
