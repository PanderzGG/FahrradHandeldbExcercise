using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FahrradHandel
{
    public class Staender : Fahrrad
    {
        private int staenderID;
        private string typ;
        private string material;
        private bool verstellbar;

        public int StaenderID { get => staenderID; set => staenderID = value; }
        public string Typ { get => typ; set => typ = value; }
        public string Material { get => material; set => material = value; }
        public bool Verstellbar { get => verstellbar; set => verstellbar = value; }

        public Staender(int staenderID, string marke, string modell, decimal preis, int aufLager, string typ, string material, bool verstellbar) : base(marke, modell, preis, aufLager)
        {
            this.staenderID = staenderID;
            this.typ = typ;
            this.material = material;
            this.verstellbar = verstellbar;
        }
    }
}
