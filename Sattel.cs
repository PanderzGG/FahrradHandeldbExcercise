using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FahrradHandel
{
    public class Sattel : BaseFahrrad
    {
        private int? sattelID;
        private string satteltyp;
        private string material;
        private string polsterung;

        public int? SattelID { get => sattelID; set => sattelID = value; }
        public string Satteltyp { get => satteltyp; set => satteltyp = value; }
        public string Material { get => material; set => material = value; }
        public string Polsterung { get => polsterung; set => polsterung = value; }

        public Sattel(int? sattelID, string marke, string modell, decimal preis, int stk_auf_lager, string satteltyp, string material, string polsterung) : base(marke, modell, preis, stk_auf_lager)
        {
            this.sattelID = sattelID;
            this.satteltyp = satteltyp;
            this.material = material;
            this.polsterung = polsterung;
        }
    }
}
