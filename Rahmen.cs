using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FahrradHandel
{
    public class Rahmen : BaseFahrrad
    {
        private int? rahmenID;
        private string material;
        private string groesse;
        private string farbe;

        public int? RahmenID { get => rahmenID; set => rahmenID = value; }
        public string Material { get => material; set => material = value; }
        public string Groesse { get => groesse; set => groesse = value; }
        public string Farbe { get => farbe; set => farbe = value; }

        public Rahmen(int? rahmenID, string marke, string modell, decimal preis, int stk_auf_lager, string material, string groesse, string farbe) : base(marke, modell, preis, stk_auf_lager)
        {
            this.rahmenID = rahmenID;
            this.material = material;
            this.groesse = groesse;
            this.farbe = farbe;
        }

    }
}
