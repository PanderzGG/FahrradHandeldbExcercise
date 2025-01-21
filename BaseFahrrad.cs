using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FahrradHandel
{
    public class BaseFahrrad
    {
        

        public string Marke { get; set; }
        public string Modell { get; set; }
        public decimal Preis { get; set; }
        public int Stk_auf_lager { get; set; }

        public BaseFahrrad(string marke, string modell, decimal preis, int stk_auf_lager)
        {
            Marke = marke;
            Modell = modell;
            Preis = preis;
            Stk_auf_lager = stk_auf_lager;
        }

    }
}
