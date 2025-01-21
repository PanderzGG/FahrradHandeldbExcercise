using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FahrradHandel
{
    public class Laufraeder : BaseFahrrad
    {
        private int? laufraederID;
        private string felgengroesse;
        private string nabenart;
        private string reifentyp;
        public int? LaufraederID { get => laufraederID; set => laufraederID = value; }
        public string Felgengroesse { get => felgengroesse; set => felgengroesse = value; }
        public string Nabenart { get => nabenart; set => nabenart = value; }
        public string Reifentyp { get => reifentyp; set => reifentyp = value; }

        public Laufraeder(int? laufraederID, string marke, string modell, decimal preis, int stk_auf_lager, string felgengroesse, string nabenart, string reifentyp) : base(marke, modell, preis, stk_auf_lager)
        {
            this.laufraederID = laufraederID;
            this.felgengroesse = felgengroesse;
            this.nabenart = nabenart;
            this.reifentyp = reifentyp;
        }


    }
}
