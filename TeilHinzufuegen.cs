using FahrradHandel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FahrradHandel
{
    public partial class TeilHinzufuegen : Form
    {
        private string auswahl;
        public TeilHinzufuegen(string auswahl)
        {
            InitializeComponent();
            this.auswahl = auswahl;
        }

        public void onLoadForm()
        {
            switch (auswahl.ToLower())
            {
                case "bremsen":

                    break;
                case "bremshebel":

                    break;
                case "gabel":

                    break;
                case "kette":

                    break;
                case "kettenblatt":

                    break;
                case "klingel":

                    break;
                case "laufraeder":

                    break;
                case "lenker":

                    break;
                case "lichtanlage":

                    break;
                case "pedale":

                    break;
                case "rahmen":

                    break;
                case "reifen":

                    break;
                case "ritzel":

                    break;
                case "sattel":

                    break;
                case "sattelstuetze":

                    break;
                case "schaltwerk":

                    break;
                case "staender":

                    break;
                case "tretlager":

                    break;
                case "vorbau":

                    break;
                case "":
                    break;
            }
        }

        private void tabPageBremsen_Click(object sender, EventArgs e)
        {

        }
    }
}
