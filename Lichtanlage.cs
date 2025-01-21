using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FahrradHandel
{
    public class Lichtanlage : BaseFahrrad
    {

        private int? lichtanlageID;
        private int leuchtstaerke;
        private string stromversorgung;
        private string montagemoeglichkeit;
        public int? LichtanlageID { get => lichtanlageID; set => lichtanlageID = value; }
        public int Leuchtstaerke { get => leuchtstaerke; set => leuchtstaerke = value; }
        public string Stromversorgung { get => stromversorgung; set => stromversorgung = value; }
        public string Montagemoeglichkeit { get => montagemoeglichkeit; set => montagemoeglichkeit = value; }


        public Lichtanlage(int? lichtanlageID, string marke, string modell, decimal preis, int stk_auf_lager, int leuchtstaerke, string stromversorgung, string montagemoaglichkeit) : base(marke, modell, preis, stk_auf_lager)
        {
            this.lichtanlageID = lichtanlageID;
            this.leuchtstaerke = leuchtstaerke;
            this.stromversorgung = stromversorgung;
            montagemoeglichkeit = montagemoaglichkeit;
        }


    }
}
