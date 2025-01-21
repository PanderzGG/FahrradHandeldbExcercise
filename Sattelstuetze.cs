using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FahrradHandel
{
    public class Sattelstuetze : BaseFahrrad
    {
        private int? sattelstuetzeID;
        private int durchmesser;
        private string material;
        private bool federung;

        public int? SattelstuetzeID { get => sattelstuetzeID; set => sattelstuetzeID = value; }
        public int Durchmesser { get => durchmesser; set => durchmesser = value; }
        public string Material { get => material; set => material = value; }
        public bool Federung { get => federung; set => federung = value; }

        public Sattelstuetze(int? sattelstuetzeID, string marke, string modell, decimal preis, int stk_auf_lager, int durchmesser, string material, bool federung) : base(marke, modell, preis, stk_auf_lager)
        {
            this.sattelstuetzeID = sattelstuetzeID;
            this.durchmesser = durchmesser;
            this.material = material;
            this.federung = federung;
        }
    }
}
