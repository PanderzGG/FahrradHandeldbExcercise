using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FahrradHandel
{
    public class Gabel : Fahrrad
    {
        private int gabelID;
        private string gabeltyp;
        private string material;
        private int federweg;

        public int GabelID { get => gabelID; set => gabelID = value; }
        public string Gabeltyp { get => gabeltyp; set => gabeltyp = value; }
        public string Material { get => material; set => material = value; }
        public int Federweg { get => federweg; set => federweg = value; }

        public Gabel(int gabelID, string marke, string modell, decimal preis, int aufLager, string gabeltyp, string material, int federweg) : base(marke, modell, preis, aufLager)
        {
            this.gabelID = gabelID;
            this.gabeltyp = gabeltyp;
            this.material = material;
            this.federweg = federweg;
        }


    }
}
