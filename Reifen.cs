using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FahrradHandel
{
    public class Reifen : BaseFahrrad
    {
        private int? reifenID;
        private string reifentyp;
        private string groesse;
        private string profil;

        public int? ReifenID { get => reifenID; set => reifenID = value; }
        public string Reifentyp { get => reifentyp; set => reifentyp = value; }
        public string Groesse { get => groesse; set => groesse = value; }
        public string Profil { get => profil; set => profil = value; }


        public Reifen(int? reifenID, string marke, string modell, decimal preis, int stk_auf_lager, string reifentyp, string groesse, string profil) : base(marke, modell, preis, stk_auf_lager)
        {
            this.reifenID = reifenID;
            this.reifentyp = reifentyp;
            this.groesse = groesse;
            this.profil = profil;
        }
    }
}
