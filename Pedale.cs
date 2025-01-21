using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FahrradHandel
{
    public class Pedale : BaseFahrrad
    {
        private int? pedaleID;
        private string pedaltyp;
        private string material;
        private bool reflektoren;
        public int? PedaleID { get => pedaleID; set => pedaleID = value; }
        public string Pedaltyp { get => pedaltyp; set => pedaltyp = value; }
        public string Material { get => material; set => material = value; }
        public bool Reflektoren { get => reflektoren; set => reflektoren = value; }

        public Pedale(int? pedaleID, string marke, string modell, decimal preis, int stk_auf_lager, string pedaltyp, string material, bool reflektoren) : base(marke, modell, preis, stk_auf_lager)
        {
            this.pedaleID = pedaleID;
            this.pedaltyp = pedaltyp;
            this.material = material;
            this.reflektoren = reflektoren;
        }


    }
}
