using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FahrradHandel
{
    public class Fahrrad
    {
        private int fahrradID;
        private string marke;
        private string modell;
        private decimal preis;
        private int aufLager;

        private int rahmenID;
        private int laufraederID;
        private int reifenID;
        private int gabelID;
        private int lenkerID;
        private int vorbauID;
        private int sattelID;
        private int sattelstuetzeID;
        private int pedaleID;
        private int kettenblattID;
        private int ketteID;
        private int schaltwerkID;
        private int ritzelID;
        private int tretlagerID;
        private int bremseID;
        private int bremshebelID;
        private int lichtanlageID;
        private int staenderID;
        private int klingelID;
        private string imagePath;

        

        public int FahrradID { get => fahrradID; set => fahrradID = value; }
        public string Marke { get => marke; set => marke = value; }
        public string Modell { get => modell; set => modell = value; }
        public decimal Preis { get => preis; set => preis = value; }
        public int AufLager { get => aufLager; set => aufLager = value; }
        public int RahmenID { get => rahmenID; set => rahmenID = value; }
        public int LaufraederID { get => laufraederID; set => laufraederID = value; }
        public int ReifenID { get => reifenID; set => reifenID = value; }
        public int GabelID { get => gabelID; set => gabelID = value; }
        public int LenkerID { get => lenkerID; set => lenkerID = value; }
        public int VorbauID { get => vorbauID; set => vorbauID = value; }
        public int SattelID { get => sattelID; set => sattelID = value; }
        public int SattelstuetzeID { get => sattelstuetzeID; set => sattelstuetzeID = value; }
        public int PedaleID { get => pedaleID; set => pedaleID = value; }
        public int KettenblattID { get => kettenblattID; set => kettenblattID = value; }
        public int KetteID { get => ketteID; set => ketteID = value; }
        public int SchaltwerkID { get => schaltwerkID; set => schaltwerkID = value; }
        public int RitzelID { get => ritzelID; set => ritzelID = value; }
        public int TretlagerID { get => tretlagerID; set => tretlagerID = value; }
        public int BremseID { get => bremseID; set => bremseID = value; }
        public int BremshebelID { get => bremshebelID; set => bremshebelID = value; }
        public int LichtanlageID { get => lichtanlageID; set => lichtanlageID = value; }
        public int StaenderID { get => staenderID; set => staenderID = value; }
        public int KlingelID { get => klingelID; set => klingelID = value; }
        public string ImagePath { get => imagePath; set => imagePath = value; }

        public Fahrrad(string marke, string modell, decimal preis, int aufLager)
        {
            this.marke = marke;
            this.modell = modell;
            this.preis = preis;
            this.aufLager = aufLager;
        }

        public Fahrrad(int fahrradID, string marke, string modell, decimal preis, int aufLager, int rahmenID, int laeuferraederID, int reifenID, int gabelID, int lenkerID, int vorbauID, int sattelID, int sattelstuetzeID, int pedaleID, int kettenblattID, int ketteID, int schaltwerkID, int ritzelID, int tretlagerID, int bremseID, int bremshebelID, int lichtanlageID, int staenderID, int klingelID, string imagePath)
        {
            this.fahrradID = fahrradID;
            this.marke = marke;
            this.modell = modell;
            this.preis = preis;
            this.aufLager = aufLager;
            this.rahmenID = rahmenID;
            this.laufraederID = laeuferraederID;
            this.reifenID = reifenID;
            this.gabelID = gabelID;
            this.lenkerID = lenkerID;
            this.vorbauID = vorbauID;
            this.sattelID = sattelID;
            this.sattelstuetzeID = sattelstuetzeID;
            this.pedaleID = pedaleID;
            this.kettenblattID = kettenblattID;
            this.ketteID = ketteID;
            this.schaltwerkID = schaltwerkID;
            this.ritzelID = ritzelID;
            this.tretlagerID = tretlagerID;
            this.bremseID = bremseID;
            this.bremshebelID = bremshebelID;
            this.lichtanlageID = lichtanlageID;
            this.staenderID = staenderID;
            this.klingelID = klingelID;
            this.imagePath = imagePath;
        }

        public Fahrrad(string marke, string modell, decimal preis, int aufLager, int rahmenID, int laeuferraederID, int reifenID, int gabelID, int lenkerID, int vorbauID, int sattelID, int sattelstuetzeID, int pedaleID, int kettenblattID, int ketteID, int schaltwerkID, int ritzelID, int tretlagerID, int bremseID, int bremshebelID, int lichtanlageID, int staenderID, int klingelID, string imagePath)
        {
            this.marke = marke;
            this.modell = modell;
            this.preis = preis;
            this.aufLager = aufLager;
            this.rahmenID = rahmenID;
            this.laufraederID = laeuferraederID;
            this.reifenID = reifenID;
            this.gabelID = gabelID;
            this.lenkerID = lenkerID;
            this.vorbauID = vorbauID;
            this.sattelID = sattelID;
            this.sattelstuetzeID = sattelstuetzeID;
            this.pedaleID = pedaleID;
            this.kettenblattID = kettenblattID;
            this.ketteID = ketteID;
            this.schaltwerkID = schaltwerkID;
            this.ritzelID = ritzelID;
            this.tretlagerID = tretlagerID;
            this.bremseID = bremseID;
            this.bremshebelID = bremshebelID;
            this.lichtanlageID = lichtanlageID;
            this.staenderID = staenderID;
            this.klingelID = klingelID;
            this.imagePath = imagePath;
        }
    }
}
