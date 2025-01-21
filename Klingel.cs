using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FahrradHandel
{
    public class Klingel : BaseFahrrad
    {
        private int? klingelID;
        private string klingeltyp;
        private string material;
        private int lautstaerke;

        public int? KlingelID { get => klingelID; set => klingelID = value; }
        public string Klingeltyp { get => klingeltyp; set => klingeltyp = value; }
        public string Material { get => material; set => material = value; }
        public int Lautstaerke { get => lautstaerke; set => lautstaerke = value; }

        public Klingel(int? klingelID, string marke, string modell, decimal preis, int stk_auf_lager, string klingeltyp, string material, int lautstaerke) : base(marke, modell, preis, stk_auf_lager)
        {
            this.klingelID = klingelID;
            this.klingeltyp = klingeltyp;
            this.material = material;
            this.lautstaerke = lautstaerke;
        }
    }
}
