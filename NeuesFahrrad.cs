using Org.BouncyCastle.Tls;
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

    public partial class NeuesFahrrad : Form
    {
        private string imageName = "fahrradschema.png";
        private bool fahrradBearbeiten;
        private int fahrradID;
        private decimal projektPreis;

        
        #region Lists

        private List<Fahrrad> fahrraeder = new List<Fahrrad>();
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
        Datenbank db = new Datenbank();

        public NeuesFahrrad(bool fahrradBearbeiten, int fahrradID)
        {
            InitializeComponent();
            this.fahrradBearbeiten = fahrradBearbeiten;
            this.fahrradID = fahrradID;
            onLoadLists();
            onLoadFahrradNeu();
            //onLoadPanelBorder();
            onLoadPreisUpdate();
            
        }

        private void onLoadPreisUpdate()
        {
            comboBoxBremsen.SelectedIndexChanged += preisUpdate;
            comboBoxBremshebel.SelectedIndexChanged += preisUpdate;
            comboBoxGabel.SelectedIndexChanged += preisUpdate;
            comboBoxKette.SelectedIndexChanged += preisUpdate;
            comboBoxKettenblatt.SelectedIndexChanged += preisUpdate;
            comboBoxKlingel.SelectedIndexChanged += preisUpdate;
            comboBoxLaufrad.SelectedIndexChanged += preisUpdate;
            comboBoxLenker.SelectedIndexChanged += preisUpdate;
            comboBoxLichtanlagen.SelectedIndexChanged += preisUpdate;
            comboBoxPedale.SelectedIndexChanged += preisUpdate;
            comboBoxRahmen.SelectedIndexChanged += preisUpdate;
            comboBoxReifen.SelectedIndexChanged += preisUpdate;
            comboBoxRitzel.SelectedIndexChanged += preisUpdate;
            comboBoxSattel.SelectedIndexChanged += preisUpdate;
            comboBoxSattelstuetzen.SelectedIndexChanged += preisUpdate;
            comboBoxSchaltwerk.SelectedIndexChanged += preisUpdate;
            comboBoxStaender.SelectedIndexChanged += preisUpdate;
            comboBoxTretlager.SelectedIndexChanged += preisUpdate;
            comboBoxVorbau.SelectedIndexChanged += preisUpdate;
            onLoadPreisHack();
        }

        private void onLoadPreisHack()
        {
            int selectedIndex = comboBoxBremsen.SelectedIndex;
            comboBoxBremsen.SelectedIndex = -1;
            comboBoxBremsen.SelectedIndex = selectedIndex;
        }

        private void onLoadFahrradNeu()
        {
            string sourcePath = Path.Combine(Application.StartupPath, "Images", imageName);

            try
            {
                panelCycle.BackgroundImage = Image.FromFile(sourcePath);
                panelCycle.BackgroundImageLayout = ImageLayout.Zoom;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


            if (fahrradBearbeiten)
            {
                
                textBoxModell.Text = fahrraeder.Find(x => x.FahrradID == fahrradID).Modell;
                comboBoxBremsen.Text = bremsen.Find(x => x.BremsenID == fahrraeder.Find(x => x.FahrradID == fahrradID).BremseID).Modell;
                comboBoxBremshebel.Text = bremshebel.Find(x => x.BremshebelID == fahrraeder.Find(x => x.FahrradID == fahrradID).BremshebelID).Modell;
                comboBoxGabel.Text = gabel.Find(x => x.GabelID == fahrraeder.Find(x => x.FahrradID == fahrradID).GabelID).Modell;
                comboBoxKette.Text = kette.Find(x => x.KetteID == fahrraeder.Find(x => x.FahrradID == fahrradID).KetteID).Modell;
                comboBoxKettenblatt.Text = kettenblatt.Find(x => x.KettenblattID == fahrraeder.Find(x => x.FahrradID == fahrradID).KettenblattID).Modell;
                comboBoxKlingel.Text = klingel.Find(x => x.KlingelID == fahrraeder.Find(x => x.FahrradID == fahrradID).KlingelID).Modell;
                comboBoxLaufrad.Text = laufraeder.Find(x => x.LaufraederID == fahrraeder.Find(x => x.FahrradID == fahrradID).LaufraederID).Modell;
                comboBoxLenker.Text = lenker.Find(x => x.LenkerID == fahrraeder.Find(x => x.FahrradID == fahrradID).LenkerID).Modell;
                comboBoxLichtanlagen.Text = lichtanlage.Find(x => x.LichtanlageID == fahrraeder.Find(x => x.FahrradID == fahrradID).LichtanlageID).Modell;
                comboBoxPedale.Text = pedale.Find(x => x.PedaleID == fahrraeder.Find(x => x.FahrradID == fahrradID).PedaleID).Modell;
                comboBoxRahmen.Text = rahmen.Find(x => x.RahmenID == fahrraeder.Find(x => x.FahrradID == fahrradID).RahmenID).Modell;
                comboBoxReifen.Text = reifen.Find(x => x.ReifenID == fahrraeder.Find(x => x.FahrradID == fahrradID).ReifenID).Modell;
                comboBoxRitzel.Text = ritzel.Find(x => x.RitzelID == fahrraeder.Find(x => x.FahrradID == fahrradID).RitzelID).Modell;
                comboBoxSattel.Text = sattel.Find(x => x.SattelID == fahrraeder.Find(x => x.FahrradID == fahrradID).SattelID).Modell;
                comboBoxSattelstuetzen.Text = sattelstuetze.Find(x => x.SattelstuetzeID == fahrraeder.Find(x => x.FahrradID == fahrradID).SattelstuetzeID).Modell;
                comboBoxSchaltwerk.Text = schaltwerk.Find(x => x.SchaltwerkID == fahrraeder.Find(x => x.FahrradID == fahrradID).SchaltwerkID).Modell;
                comboBoxStaender.Text = staender.Find(x => x.StaenderID == fahrraeder.Find(x => x.FahrradID == fahrradID).StaenderID).Modell;
                comboBoxTretlager.Text = tretlager.Find(x => x.TretlagerID == fahrraeder.Find(x => x.FahrradID == fahrradID).TretlagerID).Modell;
                comboBoxVorbau.Text = vorbau.Find(x => x.VorbauID == fahrraeder.Find(x => x.FahrradID == fahrradID).VorbauID).Modell;
            }

        }

        private void onLoadLists()
        {
            fahrraeder = db.getFahrrad();
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

            fillList();
        }

        #region Draw

        private void panelBorder(object sender, PaintEventArgs e)
        {
            var panel = sender as Panel;
            if (panel == null)
            {
                return; // Abbrechen, wenn sender kein Panel ist
            }

            Color borderColor = Color.FromArgb(16, 11, 34);
            int borderWidth = 15;

            using (Pen pen = new Pen(borderColor, borderWidth))
            {
                e.Graphics.DrawRectangle(pen, 0, 0, panel.Width - 1, panel.Height - 1);
            }
        }

        private void panelBorderc(object sender, PaintEventArgs e)
        {
            var panel = sender as Panel;
            if (panel == null)
            {
                return; // Abbrechen, wenn sender kein Panel ist
            }

            Color borderColor = Color.FromArgb(16, 11, 34);
            int borderWidth = 15;

            using (Pen pen = new Pen(borderColor, borderWidth))
            {
                e.Graphics.DrawRectangle(pen, 0, 0, panel.Width - 1, panel.Height - 1);
            }
        }

        private void onLoadPanelBorder()
        {
            panelLenker.Paint += new PaintEventHandler(panelBorder);
            panelLichtanlagen.Paint += new PaintEventHandler(panelBorder);
            panelReifen.Paint += new PaintEventHandler(panelBorder);
            panelAntrieb.Paint += new PaintEventHandler(panelBorder);
            panelSchaltung.Paint += new PaintEventHandler(panelBorder);
            panelSattel.Paint += new PaintEventHandler(panelBorder);
            panelModell.Paint += new PaintEventHandler(panelBorder);
            panelButtonHinzufuegen.Paint += new PaintEventHandler(panelBorder);
            panelAbbrechenFahrrad.Paint += new PaintEventHandler(panelBorder);
            panelCycle.Paint += new PaintEventHandler(panelBorderc);

        }
        #endregion

        private void fillList()
        {
            foreach (Bremsen b in bremsen)
            {
                comboBoxBremsen.Items.Add(b.Modell);
            }
            foreach (Bremshebel b in bremshebel)
            {
                comboBoxBremshebel.Items.Add(b.Modell);
            }
            foreach (Gabel g in gabel)
            {
                comboBoxGabel.Items.Add(g.Modell);
            }
            foreach (Kette k in kette)
            {
                comboBoxKette.Items.Add(k.Modell);
            }
            foreach (Kettenblatt k in kettenblatt)
            {
                comboBoxKettenblatt.Items.Add(k.Modell);
            }
            foreach (Klingel k in klingel)
            {
                comboBoxKlingel.Items.Add(k.Modell);
            }
            foreach (Laufraeder l in laufraeder)
            {
                comboBoxLaufrad.Items.Add(l.Modell);
            }
            foreach (Lenker l in lenker)
            {
                comboBoxLenker.Items.Add(l.Modell);
            }
            foreach (Lichtanlage l in lichtanlage)
            {
                comboBoxLichtanlagen.Items.Add(l.Modell);
            }
            foreach (Pedale p in pedale)
            {
                comboBoxPedale.Items.Add(p.Modell);
            }
            foreach (Rahmen r in rahmen)
            {
                comboBoxRahmen.Items.Add(r.Modell);
            }
            foreach (Reifen r in reifen)
            {
                comboBoxReifen.Items.Add(r.Modell);
            }
            foreach (Ritzel r in ritzel)
            {
                comboBoxRitzel.Items.Add(r.Modell);
            }
            foreach (Sattel s in sattel)
            {
                comboBoxSattel.Items.Add(s.Modell);
            }
            foreach (Sattelstuetze s in sattelstuetze)
            {
                comboBoxSattelstuetzen.Items.Add(s.Modell);
            }
            foreach (Schaltwerk s in schaltwerk)
            {
                comboBoxSchaltwerk.Items.Add(s.Modell);
            }
            foreach (Staender s in staender)
            {
                comboBoxStaender.Items.Add(s.Modell);
            }
            foreach (Tretlager t in tretlager)
            {
                comboBoxTretlager.Items.Add(t.Modell);
            }
            foreach (Vorbau v in vorbau)
            {
                comboBoxVorbau.Items.Add(v.Modell);
            }
        }


        private void preisUpdate(object sender, EventArgs e)
        {
            ComboBox comboBox = sender as ComboBox;

            #region getPreis

            decimal gesamtPreis = 0;
            

            if (comboBoxBremsen.SelectedItem != null)
                gesamtPreis += bremsen.Find(x => x.Modell == comboBoxBremsen.Text)?.Preis ?? 0;

            if (comboBoxBremshebel.SelectedItem != null)
                gesamtPreis += bremshebel.Find(x => x.Modell == comboBoxBremshebel.Text)?.Preis ?? 0;

            if (comboBoxGabel.SelectedItem != null)
                gesamtPreis += gabel.Find(x => x.Modell == comboBoxGabel.Text)?.Preis ?? 0;

            if (comboBoxKette.SelectedItem != null)
                gesamtPreis += kette.Find(x => x.Modell == comboBoxKette.Text)?.Preis ?? 0;

            if (comboBoxKettenblatt.SelectedItem != null)
                gesamtPreis += kettenblatt.Find(x => x.Modell == comboBoxKettenblatt.Text)?.Preis ?? 0;

            if (comboBoxKlingel.SelectedItem != null)
                gesamtPreis += klingel.Find(x => x.Modell == comboBoxKlingel.Text)?.Preis ?? 0;

            if (comboBoxLaufrad.SelectedItem != null)
                gesamtPreis += laufraeder.Find(x => x.Modell == comboBoxLaufrad.Text)?.Preis ?? 0;

            if (comboBoxLenker.SelectedItem != null)
                gesamtPreis += lenker.Find(x => x.Modell == comboBoxLenker.Text)?.Preis ?? 0;

            if (comboBoxLichtanlagen.SelectedItem != null)
                gesamtPreis += lichtanlage.Find(x => x.Modell == comboBoxLichtanlagen.Text)?.Preis ?? 0;

            if (comboBoxPedale.SelectedItem != null)
                gesamtPreis += pedale.Find(x => x.Modell == comboBoxPedale.Text)?.Preis ?? 0;

            if (comboBoxRahmen.SelectedItem != null)
                gesamtPreis += rahmen.Find(x => x.Modell == comboBoxRahmen.Text)?.Preis ?? 0;

            if (comboBoxReifen.SelectedItem != null)
                gesamtPreis += reifen.Find(x => x.Modell == comboBoxReifen.Text)?.Preis ?? 0;

            if (comboBoxRitzel.SelectedItem != null)
                gesamtPreis += ritzel.Find(x => x.Modell == comboBoxRitzel.Text)?.Preis ?? 0;

            if (comboBoxSattel.SelectedItem != null)
                gesamtPreis += sattel.Find(x => x.Modell == comboBoxSattel.Text)?.Preis ?? 0;

            if (comboBoxSattelstuetzen.SelectedItem != null)
                gesamtPreis += sattelstuetze.Find(x => x.Modell == comboBoxSattelstuetzen.Text)?.Preis ?? 0;

            if (comboBoxSchaltwerk.SelectedItem != null)
                gesamtPreis += schaltwerk.Find(x => x.Modell == comboBoxSchaltwerk.Text)?.Preis ?? 0;

            if (comboBoxStaender.SelectedItem != null)
                gesamtPreis += staender.Find(x => x.Modell == comboBoxStaender.Text)?.Preis ?? 0;

            if (comboBoxTretlager.SelectedItem != null)
                gesamtPreis += tretlager.Find(x => x.Modell == comboBoxTretlager.Text)?.Preis ?? 0;

            if (comboBoxVorbau.SelectedItem != null)
                gesamtPreis += vorbau.Find(x => x.Modell == comboBoxVorbau.Text)?.Preis ?? 0;
            // Fügen Sie ähnliche Blöcke für alle anderen ComboBoxes hinzu

            projektPreis = gesamtPreis;
            #endregion

            if (comboBox != null)
            {

                labelPreisWert.Text = gesamtPreis.ToString("F2") + " €";

            }
        }

        #region save
        private void panelButtonHinzufuegen_Click(object sender, EventArgs e)
        {
            hinzufuegen();
        }

        private void labelButtonHinzufügen_Click(object sender, EventArgs e)
        {
            hinzufuegen();
        }

        private void hinzufuegen()
        {
            string modell = textBoxModell.Text;

            decimal preis = projektPreis;

            string image = "";

            #region id fetch
            string marke = fahrraeder.Find(x => x.FahrradID == fahrradID).Marke;
            int aufLager = fahrraeder.Find(x => x.FahrradID == fahrradID).AufLager;
            int? bremsID = bremsen.Find(x => x.Modell == comboBoxBremsen.Text).BremsenID;
            int? bremshebelID = bremshebel.Find(x => x.Modell == comboBoxBremshebel.Text).BremshebelID;
            int? gabelID = gabel.Find(x => x.Modell == comboBoxGabel.Text).GabelID;
            int? ketteID = kette.Find(x => x.Modell == comboBoxKette.Text).KetteID;
            int? kettenblattID = kettenblatt.Find(x => x.Modell == comboBoxKettenblatt.Text).KettenblattID;
            int? klingelID = klingel.Find(x => x.Modell == comboBoxKlingel.Text).KlingelID;
            int? laufradID = laufraeder.Find(x => x.Modell == comboBoxLaufrad.Text).LaufraederID;
            int? lenkerID = lenker.Find(x => x.Modell == comboBoxLenker.Text).LenkerID;
            int? lichtID = lichtanlage.Find(x => x.Modell == comboBoxLichtanlagen.Text).LichtanlageID;
            int? pedaleID = pedale.Find(x => x.Modell == comboBoxPedale.Text).PedaleID;
            int? rahmenID = rahmen.Find(x => x.Modell == comboBoxRahmen.Text).RahmenID;
            int? reifenID = reifen.Find(x => x.Modell == comboBoxReifen.Text).ReifenID;
            int? ritzelID = ritzel.Find(x => x.Modell == comboBoxRitzel.Text).RitzelID;
            int? sattelID = sattel.Find(x => x.Modell == comboBoxSattel.Text).SattelID;
            int? sattelstuetzeID = sattelstuetze.Find(x => x.Modell == comboBoxSattelstuetzen.Text).SattelstuetzeID;
            int? schaltwerkID = schaltwerk.Find(x => x.Modell == comboBoxSchaltwerk.Text).SchaltwerkID;
            int? staenderID = staender.Find(x => x.Modell == comboBoxStaender.Text).StaenderID;
            int? tretlagerID = tretlager.Find(x => x.Modell == comboBoxTretlager.Text).TretlagerID;
            int? vorbauID = vorbau.Find(x => x.Modell == comboBoxVorbau.Text).VorbauID;
            #endregion

            try
            {
                switch (fahrradBearbeiten)
                {
                    case true:

                        Fahrrad fahrradEdit = new Fahrrad(
                            fahrradID,
                            marke,
                            modell,
                            preis,
                            aufLager,
                            rahmenID,
                            laufradID,
                            reifenID,
                            gabelID,
                            lenkerID,
                            vorbauID,
                            sattelID,
                            sattelstuetzeID,
                            pedaleID,
                            kettenblattID,
                            ketteID,
                            schaltwerkID,
                            ritzelID,
                            tretlagerID,
                            bremsID,
                            bremshebelID,
                            lichtID,
                            staenderID,
                            klingelID,
                            image
                        );

                        db.newFahrrad(fahrradEdit);
                        MessageBox.Show("Fahrrad wurde bearbeitet");
                        break;
                    case false:

                        Fahrrad fahrradNeu = new Fahrrad(
                            -1,
                            "Custom Bundle",
                            modell,
                            preis,
                            1,
                            rahmenID,
                            laufradID,
                            reifenID,
                            gabelID,
                            lenkerID,
                            vorbauID,
                            sattelID,
                            sattelstuetzeID,
                            pedaleID,
                            kettenblattID,
                            ketteID,
                            schaltwerkID,
                            ritzelID,
                            tretlagerID,
                            bremsID,
                            bremshebelID,
                            lichtID,
                            staenderID,
                            klingelID,
                            image
                        );
                        db.newFahrrad(fahrradNeu);
                        MessageBox.Show("Fahrrad wurde hinzugefügt");
                        break;
                }

                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("BO DIGGAH " + ex.Message);
            }
        }

        #endregion

        #region Abbrechen

        private void panel1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void labelAbbrechen_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #endregion


    }
}
