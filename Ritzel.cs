using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FahrradHandel
{
    public class Ritzel : Fahrrad
    {
        private int ritzelID;
        private int zahnanzahl;
        private string material;
        private bool freilauf;

        public int RitzelID { get => ritzelID; set => ritzelID = value; }
        public int Zahnanzahl { get => zahnanzahl; set => zahnanzahl = value; }
        public string Material { get => material; set => material = value; }
        public bool Freilauf { get => freilauf; set => freilauf = value; }

        public Ritzel(int ritzelID, string marke, string modell, decimal preis, int aufLager, int zahnanzahl, string material, bool freilauf) : base(marke, modell, preis, aufLager)
        {
            this.ritzelID = ritzelID;
            this.zahnanzahl = zahnanzahl;
            this.material = material;
            this.freilauf = freilauf;
        }
    }
}
