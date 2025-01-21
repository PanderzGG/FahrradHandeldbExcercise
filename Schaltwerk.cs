using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FahrradHandel
{
    public class Schaltwerk : BaseFahrrad
    {
        private int? schaltwerkID;
        private string schaltungstyp;
        private string material;
        private int schaltstufen;

        public int? SchaltwerkID { get => schaltwerkID; set => schaltwerkID = value; }
        public string Schaltungstyp { get => schaltungstyp; set => schaltungstyp = value; }
        public string Material { get => material; set => material = value; }
        public int Schaltstufen { get => schaltstufen; set => schaltstufen = value; }

        public Schaltwerk(int? schaltwerkID, string marke, string modell, decimal preis, int stk_auf_lager, string schaltungstyp, string material, int schaltstufen) : base(marke, modell, preis, stk_auf_lager)
        {
            this.schaltwerkID = schaltwerkID;
            this.schaltungstyp = schaltungstyp;
            this.material = material;
            this.schaltstufen = schaltstufen;
        }
    }
}
