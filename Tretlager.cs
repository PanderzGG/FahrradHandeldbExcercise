using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FahrradHandel
{
    public class Tretlager : Fahrrad
    {
        private int tretlagerID;
        private int achsendurchmesser;
        private string lagerart;
        private string material;

        public int TretlagerID { get => tretlagerID; set => tretlagerID = value; }
        public int Achsendurchmesser { get => achsendurchmesser; set => achsendurchmesser = value; }
        public string Lagerart { get => lagerart; set => lagerart = value; }
        public string Material { get => material; set => material = value; }

        public Tretlager(int tretlagerID, string marke, string modell, decimal preis, int aufLager, int achsendurchmesser, string lagerart, string material) : base(marke, modell, preis, aufLager)
        {
            this.tretlagerID = tretlagerID;
            this.achsendurchmesser = achsendurchmesser;
            this.lagerart = lagerart;
            this.material = material;
        }
    }
}
