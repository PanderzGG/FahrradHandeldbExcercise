using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FahrradHandel
{
    public class Laufraeder : Fahrrad
    {
        private int laufraederID;
        private string felgengroesse;
        private string narbenart;
        private string reifentyp;
        public int LaufraederID { get => laufraederID; set => laufraederID = value; }
        public string Felgengroesse { get => felgengroesse; set => felgengroesse = value; }
        public string Narbenart { get => narbenart; set => narbenart = value; }
        public string Reifentyp { get => reifentyp; set => reifentyp = value; }

        public Laufraeder(int laufraederID, string marke, string modell, decimal preis, int aufLager, string felgengroesse, string narbenart, string reifentyp) : base(marke, modell, preis, aufLager)
        {
            this.laufraederID = laufraederID;
            this.felgengroesse = felgengroesse;
            this.narbenart = narbenart;
            this.reifentyp = reifentyp;
        }


    }
}
