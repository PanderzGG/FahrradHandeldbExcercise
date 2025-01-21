using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FahrradHandel
{
    public class Vorbau : BaseFahrrad
    {
        private int? vorbauID;
        private int laenge;
        private int winkel;
        private string material;

        public int? VorbauID { get => vorbauID; set => vorbauID = value; }
        public int Laenge { get => laenge; set => laenge = value; }
        public int Winkel { get => winkel; set => winkel = value; }
        public string Material { get => material; set => material = value; }

        public Vorbau(int? vorbauID, string marke, string modell, decimal preis, int stk_auf_lager, int laenge, int winkel, string material) : base(marke, modell, preis, stk_auf_lager)
        {
            this.vorbauID = vorbauID;
            this.laenge = laenge;
            this.winkel = winkel;
            this.material = material;
        }

    }
}
