using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FahrradHandel
{
    public class Bremshebel : Fahrrad
    {
        private int bremshebelID;
        private string hebelmaterial;
        private bool verstellbar;
        private string ergonomie;

        public int BremshebelID { get => bremshebelID; set => bremshebelID = value; }
        public string Hebelmaterial { get => hebelmaterial; set => hebelmaterial = value; }
        public bool Verstellbar { get => verstellbar; set => verstellbar = value; }
        public string Ergonomie { get => ergonomie; set => ergonomie = value; }

        public Bremshebel(int bremshebelID, string marke, string modell, decimal preis, int aufLager, string hebelmaterial, bool verstellbar, string ergonomie) : base(marke, modell, preis, aufLager)
        {
            this.bremshebelID = bremshebelID;
            this.hebelmaterial = hebelmaterial;
            this.verstellbar = verstellbar;
            this.ergonomie = ergonomie;
        }
    }
}
