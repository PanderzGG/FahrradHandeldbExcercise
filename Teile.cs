using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FahrradHandel
{

    public partial class Teile : Form
    {
        private Datenbank db = new Datenbank();

        #region Lists
        private List<string> teilAuswahl = new List<string>();

        private List<Bremsen> bremsen = new List<Bremsen>();
        private List<Bremshebel> bremshebel = new List<Bremshebel>();
        private List<Gabel> gabel = new List<Gabel>();
        private List<Kette> kette = new List<Kette>();
        private List<Kettenblatt> kettenblatt = new List<Kettenblatt>();
        private List<Klingel> klingel = new List<Klingel>();
        private List<Laufraeder> laufraeder = new List<Laufraeder>();
        private List<Lenker> lenker = new List<Lenker>();
        private List<Lichtanlage> lichtanlage = new List<Lichtanlage>();
        private List<Pedale> pedale = new List<Pedale>();
        private List<Rahmen> rahmen = new List<Rahmen>();
        private List<Reifen> reifen = new List<Reifen>();
        private List<Ritzel> ritzel = new List<Ritzel>();
        private List<Sattel> sattel = new List<Sattel>();
        private List<Sattelstuetze> sattelstuetze = new List<Sattelstuetze>();
        private List<Schaltwerk> schaltwerk = new List<Schaltwerk>();
        private List<Staender> staender = new List<Staender>();
        private List<Tretlager> tretlager = new List<Tretlager>();
        private List<Vorbau> vorbau = new List<Vorbau>();


        #endregion
        public Teile()
        {
            InitializeComponent();
            onLoadAuswahl();
            onLoadLists();

            //Abo
            this.KeyDown += new KeyEventHandler(deleteTeil);

            // Stellt sicher, dass Tasta eingaben empfangen werden
            this.KeyPreview = true;
        }

        #region OnLoad

        private void onLoadLists()
        {
            bremsen = db.getBremsen();
            bremshebel = db.getBremshebel();
            gabel = db.getGabel();
            kette = db.getKette();
            kettenblatt = db.getKettenblatt();
            klingel = db.getKlingel();
            laufraeder = db.getLaufraeder();
            lenker = db.getLenker();
            lichtanlage = db.getLichtanlage();
            pedale = db.getPedale();
            rahmen = db.getRahmen();
            reifen = db.getReifen();
            ritzel = db.getRitzel();
            sattel = db.getSattel();
            sattelstuetze = db.getSattelstuetze();
            schaltwerk = db.getSchaltwerk();
            staender = db.getStaender();
            tretlager = db.getTretlager();
            vorbau = db.getVorbau();
        }

        private void onLoadAuswahl()
        {
            teilAuswahl = db.getTableName();

            foreach (string s in teilAuswahl)
            {
                if (s == "fahrrad")
                {
                    continue;
                }
                else
                {
                    comboBoxTeilAuswahl.Items.Add(s);
                }

            }
        }

        #endregion

        private void comboBoxTeilAuswahl_SelectedIndexChanged(object sender, EventArgs e)
        {


            List<string> spaltenName = new List<string>();


            string auswahl = comboBoxTeilAuswahl.SelectedItem.ToString();
            spaltenName = db.getselectedTeil(auswahl);


            dataGridViewTeile.Columns.Clear();
            dataGridViewTeile.Rows.Clear();

            foreach (string s in spaltenName)
            {
                dataGridViewTeile.Columns.Add(s, s);
            }

            switch (auswahl.ToLower())
            {
                case "bremsen":
                    foreach (Bremsen v in bremsen)
                    {
                        dataGridViewTeile.Rows.Add(v.BremsenID, v.Marke, v.Modell, v.Preis, v.AufLager, v.BremsArt, v.Bremsbelagmaterial, v.Durchmesser);
                    }
                    break;
                case "bremshebel":
                    foreach (Bremshebel v in bremshebel)
                    {
                        dataGridViewTeile.Rows.Add(v.BremshebelID, v.Marke, v.Modell, v.Preis, v.AufLager, v.Hebelmaterial, v.Verstellbar, v.Ergonomie);
                    }
                    break;
                case "gabel":
                    foreach (Gabel v in gabel)
                    {
                        dataGridViewTeile.Rows.Add(v.GabelID, v.Marke, v.Modell, v.Preis, v.AufLager, v.Gabeltyp, v.Material, v.Federweg);
                    }
                    break;
                case "kette":
                    foreach (Kette v in kette)
                    {
                        dataGridViewTeile.Rows.Add(v.KetteID, v.Marke, v.Modell, v.Preis, v.AufLager, v.Kettenart, v.Material, v.Laenge);
                    }
                    break;
                case "kettenblatt":
                    foreach (Kettenblatt v in kettenblatt)
                    {
                        dataGridViewTeile.Rows.Add(v.KettenblattID, v.Marke, v.Modell, v.Preis, v.AufLager, v.Zahnanzahl, v.Material, v.Lochkreis);
                    }
                    break;
                case "klingel":
                    foreach (Klingel v in klingel)
                    {
                        dataGridViewTeile.Rows.Add(v.KlingelID, v.Marke, v.Modell, v.Preis, v.AufLager, v.Klingeltyp, v.Material, v.Lautstaerke);
                    }
                    break;
                case "laufraeder":
                    foreach (Laufraeder v in laufraeder)
                    {
                        dataGridViewTeile.Rows.Add(v.LaufraederID, v.Marke, v.Modell, v.Preis, v.AufLager, v.Felgengroesse, v.Narbenart, v.Reifentyp);
                    }
                    break;
                case "lenker":
                    foreach (Lenker v in lenker)
                    {
                        dataGridViewTeile.Rows.Add(v.LenkerID, v.Marke, v.Modell, v.Preis, v.AufLager, v.Lenkertyp, v.Material, v.Breite);
                    }
                    break;
                case "lichtanlage":
                    foreach (Lichtanlage v in lichtanlage)
                    {
                        dataGridViewTeile.Rows.Add(v.LichtanlageID, v.Marke, v.Modell, v.Preis, v.AufLager, v.Leuchtstaerke, v.Stromversorgung, v.Montagemoeglichkeit);
                    }
                    break;
                case "pedale":
                    foreach (Pedale v in pedale)
                    {
                        dataGridViewTeile.Rows.Add(v.PedaleID, v.Marke, v.Modell, v.Preis, v.AufLager, v.Pedaltyp, v.Material, v.Reflektoren);
                    }
                    break;
                case "rahmen":
                    foreach (Rahmen v in rahmen)
                    {
                        dataGridViewTeile.Rows.Add(v.RahmenID, v.Marke, v.Modell, v.Preis, v.AufLager, v.Material, v.Groesse, v.Farbe);
                    }
                    break;
                case "reifen":
                    foreach (Reifen v in reifen)
                    {
                        dataGridViewTeile.Rows.Add(v.ReifenID, v.Marke, v.Modell, v.Preis, v.AufLager, v.Reifentyp, v.Groesse, v.Profil);
                    }
                    break;
                case "ritzel":
                    foreach (Ritzel v in ritzel)
                    {
                        dataGridViewTeile.Rows.Add(v.RitzelID, v.Marke, v.Modell, v.Preis, v.AufLager, v.Zahnanzahl, v.Material, v.Freilauf);
                    }
                    break;
                case "sattel":
                    foreach (Sattel v in sattel)
                    {
                        dataGridViewTeile.Rows.Add(v.SattelID, v.Marke, v.Modell, v.Preis, v.AufLager, v.Satteltyp, v.Material, v.Polsterung);
                    }
                    break;
                case "sattelstuetze":
                    foreach (Sattelstuetze v in sattelstuetze)
                    {
                        dataGridViewTeile.Rows.Add(v.SattelstuetzeID, v.Marke, v.Modell, v.Preis, v.AufLager, v.Durchmesser, v.Material, v.Federung);
                    }
                    break;
                case "schaltwerk":
                    foreach (Schaltwerk v in schaltwerk)
                    {
                        dataGridViewTeile.Rows.Add(v.SchaltwerkID, v.Marke, v.Modell, v.Preis, v.AufLager, v.Schaltungstyp, v.Material, v.Schaltstufen);
                    }
                    break;
                case "staender":
                    foreach (Staender v in staender)
                    {
                        dataGridViewTeile.Rows.Add(v.StaenderID, v.Marke, v.Modell, v.Preis, v.AufLager, v.Typ, v.Material, v.Verstellbar);
                    }
                    break;
                case "tretlager":
                    foreach (Tretlager v in tretlager)
                    {
                        dataGridViewTeile.Rows.Add(v.TretlagerID, v.Marke, v.Modell, v.Preis, v.AufLager, v.Achsendurchmesser, v.Lagerart, v.Material);
                    }
                    break;
                case "vorbau":
                    foreach (Vorbau v in vorbau)
                    {
                        dataGridViewTeile.Rows.Add(v.GabelID, v.Marke, v.Modell, v.Preis, v.AufLager, v.Laenge, v.Winkel, v.Material);
                    }
                    break;
                case "":
                    break;
            }
        }

        private void deleteTeil(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Delete && dataGridViewTeile.CurrentRow != null)
            {
                DialogResult result = MessageBox.Show("Sind Sie sicher, dass Sie " + dataGridViewTeile.CurrentRow.Cells[2].Value + " löschen möchten?", "Bestätigung", MessageBoxButtons.YesNo);
                int index = dataGridViewTeile.CurrentRow.Index;
                int delID;
                string auswahl = comboBoxTeilAuswahl.SelectedItem.ToString();

                if (result == DialogResult.Yes)
                {
                    delID = Convert.ToInt32(dataGridViewTeile.CurrentRow.Cells[0].Value);

                    dataGridViewTeile.Rows.RemoveAt(index);
                    db.deleteTeil(auswahl, delID);

                    onLoadLists();
                }
                else
                {
                    return;
                }

            }
        }

        private void panelTeilHinzufuegen_Click(object sender, EventArgs e)
        {
            if(comboBoxTeilAuswahl.Text != "")
            {
                string auswahl = comboBoxTeilAuswahl.Text;

                TeilHinzufuegen teil = new TeilHinzufuegen(auswahl);

                teil.FormClosed += neuesTeil;

                teil.Show();
            }
        }

        private void neuesTeil(object sender, FormClosedEventArgs e)
        {
            onLoadLists();
        }

        //if (dataGridViewTeile.SelectedCells[0].Value != null)
        //{
        //    delID = Convert.ToInt32(dataGridViewTeile.SelectedCells[0].Value);

        //    MessageBox.Show(delID.ToString());
        //}
        //else
        //{
        //    return;
        //}

    }
}
