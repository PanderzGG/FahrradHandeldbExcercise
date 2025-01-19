﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FahrradHandel
{
    public class Kette : Fahrrad
    {
        private int ketteID;
        private string kettenart;
        private string material;
        private int laenge;

        public new int KetteID { get => ketteID; set => ketteID = value; }
        public string Kettenart { get => kettenart; set => kettenart = value; }
        public string Material { get => material; set => material = value; }
        public int Laenge { get => laenge; set => laenge = value; }

        public Kette(int ketteID, string marke, string modell, decimal preis, int aufLager, string kettenart, string material, int laenge) : base(marke, modell, preis, aufLager)
        {
            this.ketteID = ketteID;
            this.kettenart = kettenart;
            this.material = material;
            this.laenge = laenge;
        }
    }
}