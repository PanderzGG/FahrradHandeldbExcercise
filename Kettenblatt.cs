using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FahrradHandel
{
    public class Kettenblatt : Fahrrad
    {
        private int kettenblattID;
        private int zahnanzahl;
        private string material;
        private int lochkreis;

        public int KettenblattID { get => kettenblattID; set => kettenblattID = value; }
        public int Zahnanzahl { get => zahnanzahl; set => zahnanzahl = value; }
        public string Material { get => material; set => material = value; }
        public int Lochkreis { get => lochkreis; set => lochkreis = value; }

        public Kettenblatt(int kettenblattID, string marke, string modell, decimal preis, int aufLager, int zahnanzahl, string material, int lochkreis) : base(marke, modell, preis, aufLager)
        {
            this.kettenblattID = kettenblattID;
            this.zahnanzahl = zahnanzahl;
            this.material = material;
            this.lochkreis = lochkreis;
        }
    }
}
