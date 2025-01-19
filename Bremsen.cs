using System;

namespace FahrradHandel
{
    public class Bremsen : Fahrrad
    {
        private int bremsenID;
        private string bremsArt;
        private string bremsbelagmaterial;
        private int durchmesser;

        public int BremsenID { get => bremsenID; set => bremsenID = value; }
        public string BremsArt { get => bremsArt; set => bremsArt = value; }
        public string Bremsbelagmaterial { get => bremsbelagmaterial; set => bremsbelagmaterial = value; }
        public int Durchmesser { get => durchmesser; set => durchmesser = value; }


        public Bremsen(int bremsenID, string bremsArt, string bremsbelagmaterial, int durchmesser, string marke, string modell, decimal preis, int aufLager)
            : base(marke, modell, preis, aufLager)
        {
            this.bremsenID = bremsenID;
            this.bremsArt = bremsArt;
            this.bremsbelagmaterial = bremsbelagmaterial;
            this.durchmesser = durchmesser;
        }
    }
}

