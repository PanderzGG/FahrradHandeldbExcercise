using Org.BouncyCastle.Asn1.Cms.Ecc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FahrradHandel
{
    public class Lenker : Fahrrad
    {
        private int lenkerID;
        private string lenkertyp;
        private string material;
        private int breite;
        public int LenkerID { get => lenkerID; set => lenkerID = value; }
        public string Lenkertyp { get => lenkertyp; set => lenkertyp = value; }
        public string Material { get => material; set => material = value; }
        public int Breite { get => breite; set => breite = value; }

        public Lenker(int lenkerID, string marke, string modell, decimal preis, int aufLager, string lenkertyp, string material, int breite) : base(marke, modell, preis, aufLager)
        {
            this.lenkerID = lenkerID;
            this.lenkertyp = lenkertyp;
            this.material = material;
            this.breite = breite;
        }


    }
}
