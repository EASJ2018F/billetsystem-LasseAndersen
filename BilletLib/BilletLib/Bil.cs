using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilletLib
{
    public class Bil : KøretøjBaseKlasse
    {

        private String _nummerplade;
        private DateTime _dato;

        public Bil(string nummerplade, DateTime dato)
        {
            _nummerplade = nummerplade;
            _dato = dato;
           
        }

        public string NummerPlade
        {
            get
            {
                return _nummerplade;
            }
            set
            {
                value = _nummerplade;
            }
        }
        public DateTime Dato
        {
            get
            {
                return _dato;
            }
            set
            {
                value = _dato;
            }
        }

        

        public override int Pris()
        {
            return 240;
        }

        public override string køretøj()
        {
            return "Bil";    
        }

    }
}
