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
        Datenbank db = new Datenbank();

        private string auswahl;
        public TeilHinzufuegen(string auswahl)
        {
            InitializeComponent();
            this.auswahl = auswahl;
            onLoadHideTabPages();

        }

        private void onLoadHideTabPages()
        {
            string currentPage = string.Format("tabPage{0}", auswahl);

            foreach (TabPage tab in tabControlTeilHinzufügen.TabPages)
            {
                if (tab.Name != currentPage)
                {
                    tabControlTeilHinzufügen.TabPages.Remove(tab);
                }
            }
        }

        #region Hinzufuegen Buttons
        private bool isBoxEmpty(TabPage tabPage)
        {
            return tabPage.Controls.OfType<TextBox>().Any(tb => string.IsNullOrWhiteSpace(tb.Text));
        }

        private void panelBremseHinzufuegen_Click(object sender, EventArgs e)
        {
            bool anyEmpty = isBoxEmpty(tabControlTeilHinzufügen.SelectedTab);

            try
            {
                if (!anyEmpty)
                {
                    Bremsen bremse = new Bremsen(
                            -1,
                            textBoxBremsenBremsart.Text,
                            textBoxBremsenBremsmaterial.Text,
                            Convert.ToInt32(textBoxBremsenDurchmesser.Text),
                            textBoxBremsenMarke.Text,
                            textBoxBremsenModell.Text,
                            Convert.ToDecimal(textBoxBremsenPreis.Text),
                            Convert.ToInt32(textBoxBremsenStkAufLager.Text)
                        );

                    db.newBremsen(bremse);

                    MessageBox.Show(textBoxBremsenModell.Text + " wurde erfolgreich hinzugefügt");

                    this.Close();
                }
                else
                {
                    MessageBox.Show("Bitte füllen Sie alle Felder aus");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bremse konnte nicht angelegt werden");
            }
        }

        private void panelBremshebelHinzufuegen_Click(object sender, EventArgs e)
        {
            bool anyEmpty = isBoxEmpty(tabControlTeilHinzufügen.SelectedTab);
            bool isVerstellbar = false;

            if (radioButtonVerstellbarJa.Checked)
            {
                isVerstellbar = true;
            }
            else if (radioButtonVerstellbarNein.Checked)
            {
                isVerstellbar = false;
            }
            else
            {
                MessageBox.Show("Wählen Sie die Verstellbarkeit aus");
            }

            try
            {
                if (!anyEmpty)
                {
                    Bremshebel bremsh = new Bremshebel(
                        -1,
                        textBoxBremhMarke.Text,
                        textBoxBremhModell.Text,
                        Convert.ToDecimal(textBoxBremhPreis.Text),
                        Convert.ToInt32(textBoxBremhAufLager.Text),
                        textBoxBremhHebelmaterial.Text,
                        isVerstellbar,
                        textBoxBremhErgonomie.Text
                        );

                    db.newBremshebel(bremsh);

                    MessageBox.Show(textBoxBremhModell.Text + " wurde erfolgreich hinzugefügt");


                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(textBoxBremhMarke.Text + Environment.NewLine +
                                textBoxBremhModell.Text + Environment.NewLine +
                                textBoxBremhPreis.Text + Environment.NewLine +
                                textBoxBremsenStkAufLager.Text + Environment.NewLine +
                                textBoxBremhHebelmaterial.Text + Environment.NewLine +
                                isVerstellbar + Environment.NewLine +
                                textBoxBremhErgonomie.Text);
            }
        }

        private void panelGabelHinzufuegen_Click(object sender, EventArgs e)
        {
            // To do nimmt FederWeg nur Int annehmen.
            bool anyEmpty = isBoxEmpty(tabControlTeilHinzufügen.SelectedTab);

            try
            {
                if (!anyEmpty)
                {
                    Gabel gabel = new Gabel(
                        -1,
                        textBoxGabelMarke.Text,
                        textBoxGabelModell.Text,
                        Convert.ToDecimal(textBoxGabelPreis.Text),
                        Convert.ToInt32(textBoxGabelAufLager.Text),
                        textBoxGabelGabelTyp.Text,
                        textBoxGabelMAterial.Text,
                        Convert.ToInt32(textBoxGabelFederweg.Text)
                        );

                    db.newGabel(gabel);

                    MessageBox.Show(textBoxGabelModell.Text + " wurde erfolgreich erstellt.");
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void panelKetteHinzufuegen_Click(object sender, EventArgs e)
        {
            bool anyEmpty = isBoxEmpty(tabControlTeilHinzufügen.SelectedTab);

            try
            {
                if (!anyEmpty)
                {
                    Kette kette = new Kette(
                        -1,
                        textBoxKetteMarke.Text,
                        textBoxKetteModell.Text,
                        Convert.ToDecimal(textBoxKettePreis.Text),
                        Convert.ToInt32(textBoxKetteAufLager.Text),
                        textBoxKetteKettenart.Text,
                        textBoxKetteMaterial.Text,
                        Convert.ToInt32(textBoxKetteLaenge.Text)
                        );

                    db.newKette(kette);

                    MessageBox.Show(textBoxKetteModell.Text + " wurde erfolgreich erstellt.");
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void panelKettenblatthinzufuegen_Click(object sender, EventArgs e)
        {
            bool anyEmpty = isBoxEmpty(tabControlTeilHinzufügen.SelectedTab);

            try
            {
                if (!anyEmpty)
                {
                    Kettenblatt kettenb = new Kettenblatt(
                        -1,
                        textBoxKettenblattMarke.Text,
                        textBoxKettenblattModell.Text,
                        Convert.ToDecimal(textBoxKettenblattPreis.Text),
                        Convert.ToInt32(textBoxKettenblattAufLager.Text),
                        Convert.ToInt32(textBoxKettenblattZahnanzahl.Text),
                        textBoxKettenblattMaterial.Text,
                        Convert.ToInt32(textBoxKettenblattLochkreis.Text)
                        );

                    db.newKettenblatt(kettenb);

                    MessageBox.Show(textBoxKettenblattModell.Text + " wurde erfolgreich erstellt.");
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void panelKlingelHInzufuegen_Click(object sender, EventArgs e)
        {
            bool anyEmpty = isBoxEmpty(tabControlTeilHinzufügen.SelectedTab);

            try
            {
                if (!anyEmpty)
                {
                    Klingel klingel = new Klingel(
                        -1,
                        textBoxKlingelMarke.Text,
                        textBoxKlingelModell.Text,
                        Convert.ToDecimal(textBoxKlingelPreis.Text),
                        Convert.ToInt32(textBoxKlingelAufLager.Text),
                        textBoxKlingelKlingeltyp.Text,
                        textBoxKlingelMaterial.Text,
                        Convert.ToInt32(textBoxKlingelLautstaerke.Text)
                        );

                    db.newKlingel(klingel);

                    MessageBox.Show(textBoxKlingelModell.Text + " wurde erfolgreich erstellt.");
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void panelLaufradHinzufuegen_Click(object sender, EventArgs e)
        {
            bool anyEmpty = isBoxEmpty(tabControlTeilHinzufügen.SelectedTab);

            try
            {
                if (!anyEmpty)
                {
                    Laufraeder laufrad = new Laufraeder(
                        -1,
                        textBoxLaufradMarke.Text,
                        textBoxLaufradModell.Text,
                        Convert.ToDecimal(textBoxLaufradPreis.Text),
                        Convert.ToInt32(textBoxLaufradAufLager.Text),
                        textBoxLaufradFelgengr.Text,
                        textBoxLaufradNabenart.Text,
                        textBoxLaufradReifentyp.Text
                        );

                    db.newLaufrad(laufrad);

                    MessageBox.Show(textBoxKlingelModell.Text + " wurde erfolgreich erstellt.");
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void panelLenkerHinzufuegen_Click(object sender, EventArgs e)
        {
            bool anyEmpty = isBoxEmpty(tabControlTeilHinzufügen.SelectedTab);

            try
            {
                if (!anyEmpty)
                {
                    Lenker lenker = new Lenker(
                        -1,
                        textBoxLenkerMarke.Text,
                        textBoxLenkerModell.Text,
                        Convert.ToDecimal(textBoxLenkerPreis.Text),
                        Convert.ToInt32(textBoxLenkerAufLager.Text),
                        textBoxLenkerLenkertyp.Text,
                        textBoxLenkerMaterial.Text,
                        Convert.ToInt32(textBoxLenkerBreite.Text)
                        );

                    db.newLenker(lenker);

                    MessageBox.Show(textBoxLenkerModell.Text + " wurde erfolgreich erstellt.");
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void panelLichtanlageHinzufuegen_Click(object sender, EventArgs e)
        {
            bool anyEmpty = isBoxEmpty(tabControlTeilHinzufügen.SelectedTab);

            try
            {
                if (!anyEmpty)
                {
                    Lichtanlage lichtan = new Lichtanlage(
                        -1,
                        textBoxLichtanlageMarke.Text,
                        textBoxLichtanlageModell.Text,
                        Convert.ToDecimal(textBoxLichtanlagePreis.Text),
                        Convert.ToInt32(textBoxLichtanlageAufLager.Text),
                        Convert.ToInt32(textBoxLichtanlageLeuchtstaerke.Text),
                        textBoxLichtanlageStromversorgung.Text,
                        textBoxLichtanlageMontage.Text
                        );

                    db.newLichtanlage(lichtan);

                    MessageBox.Show(textBoxLichtanlageModell.Text + " wurde erfolgreich erstellt.");
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void panelPedaleHinzufuegen_Click(object sender, EventArgs e)
        {
            bool anyEmpty = isBoxEmpty(tabControlTeilHinzufügen.SelectedTab);

            bool isVerstellbar = false;

            if (radioButtonPedalRefJa.Checked)
            {
                isVerstellbar = true;
            }
            else if (radioButtonPedalRefNein.Checked)
            {
                isVerstellbar = false;
            }
            else
            {
                MessageBox.Show("Wählen Sie die Verstellbarkeit aus");
            }

            try
            {
                if (!anyEmpty)
                {
                    Pedale pedal = new Pedale(
                        -1,
                        textBoxPedaleMarke.Text,
                        textBoxPedaleModell.Text,
                        Convert.ToDecimal(textBoxPedalePreis.Text),
                        Convert.ToInt32(textBoxPedaleAufLager.Text),
                        textBoxPedalePedaltyp.Text,
                        textBoxPedaleMaterial.Text,
                        isVerstellbar

                        );

                    db.newPedale(pedal);

                    MessageBox.Show(textBoxLichtanlageModell.Text + " wurde erfolgreich erstellt.");
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void panelRahmenHinzufuegen_Click(object sender, EventArgs e)
        {
            bool anyEmpty = isBoxEmpty(tabControlTeilHinzufügen.SelectedTab);

            try
            {
                if (!anyEmpty)
                {
                    Rahmen rahmen = new Rahmen(
                        -1,
                        textBoxRahmenMarke.Text,
                        textBoxRahmenModell.Text,
                        Convert.ToDecimal(textBoxRahmenPreis.Text),
                        Convert.ToInt32(textBoxRahmenAufLager.Text),
                        textBoxRahmenMaterial.Text,
                        textBoxRahmenGroesse.Text,
                        textBoxRahmenFarben.Text
                        );

                    db.newRahmen(rahmen);

                    MessageBox.Show(textBoxRahmenModell.Text + " wurde erfolgreich erstellt.");
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void panelReifenHinzufuegen_Click(object sender, EventArgs e)
        {
            bool anyEmpty = isBoxEmpty(tabControlTeilHinzufügen.SelectedTab);

            try
            {
                if (!anyEmpty)
                {
                    Reifen reifen= new Reifen(
                        -1,
                        textBoxReifenMarke.Text,
                        textBoxReifenModell.Text,
                        Convert.ToDecimal(textBoxReifenPreis.Text),
                        Convert.ToInt32(textBoxReifenAufLager.Text),
                        textBoxReifenReifentyp.Text,
                        textBoxReifenGroesse.Text,
                        textBoxReifenProfil.Text
                        );

                    db.newReifen(reifen);

                    MessageBox.Show(textBoxReifenModell.Text + " wurde erfolgreich erstellt.");
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        #endregion
    }
}
