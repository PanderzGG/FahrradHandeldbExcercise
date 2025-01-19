using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
    public partial class Fahrraeder : Form
    {
        private Color naviButton = Color.FromArgb(0, 0, 0);

        private List<Fahrrad> fahrrad = new List<Fahrrad>();

        private bool fahrradBearbeiten = false;
        private int? fahrradID;

        private string imageName = "fahrradschema.png";

        Datenbank db = new Datenbank();
        public Fahrraeder()
        {
            InitializeComponent();
            onLoad();
            onLoadPanelBorder();
            this.Load += Fahrraeder_Load;

        }

        private void onLoadPanelBorder()
        {
            panelButtonNeuesFahrrad.Paint += new PaintEventHandler(panelBorder);
            panelButtonFahrradZurueck.Paint += new PaintEventHandler(panelBorder);
        }

        private void panelBorder(object sender, PaintEventArgs e)
        {
            var panel = sender as Panel;
            if (panel == null)
            {
                return; // Abbrechen, wenn sender kein Panel ist
            }

            Color borderColor = naviButton;
            int borderWidth = 15;

            using (Pen pen = new Pen(borderColor, borderWidth))
            {
                e.Graphics.DrawRectangle(pen, 0, 0, panel.Width - 1, panel.Height - 1);
            }
        }

        private void onLoad()
        {
            dataGridViewFahrrad.Rows.Clear();
            fahrrad = db.getFahrrad();

            foreach (Fahrrad f in fahrrad)
            {
                dataGridViewFahrrad.Rows.Add(f.Marke, f.Modell, f.Preis, f.AufLager);
            }

            clearSelect();
        }

        private void Fahrraeder_Load(object sender, EventArgs e)
        {
            dataGridViewFahrrad.Rows.Clear();
            fahrrad = db.getFahrrad();

            foreach (Fahrrad f in fahrrad)
            {
                dataGridViewFahrrad.Rows.Add(f.Marke, f.Modell, f.Preis, f.AufLager);
            }

            clearSelect();
        }

        private void panelButtonNeuesFahrrad_Click(object sender, EventArgs e)
        {
            openNewRad();
        }
        private void labelNeuesFahrrad_Click(object sender, EventArgs e)
        {
            openNewRad();
        }

        private void openNewRad()
        {
            NeuesFahrrad f = new NeuesFahrrad(fahrradBearbeiten, fahrradID.Value);

            f.FormClosed += NeuesFahrrad_FormClosed;

            f.Show();
        }

        private void NeuesFahrrad_FormClosed(object sender, FormClosedEventArgs e)
        {
            onLoad();
        }

        private void dataGridViewFahrrad_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridViewFahrrad.CurrentRow != null)
            {
                fahrradBearbeiten = true;
                labelNeuesFahrrad.Text = "Fahrrad bearbeiten";
                fahrradID = fahrrad[dataGridViewFahrrad.CurrentRow.Index].FahrradID;
            }
            else
            {
                clearSelect();
            }
        }

        private void panelClearSelect_Click(object sender, EventArgs e)
        {
            clearSelect();
        }

        private void labelAuswahlAufheben_Click(object sender, EventArgs e)
        {
            clearSelect();
        }

        private void clearSelect()
        {
            dataGridViewFahrrad.ClearSelection();
            fahrradBearbeiten = false;
            labelNeuesFahrrad.Text = "Neues Fahrrad";
        }

        private void panelButtonFahrradZurueck_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void labelButtonZurück_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panelFahrradLoeschen_Click(object sender, EventArgs e)
        {
            buttonLoeschen();
        }

        private void labelfahrradLoeschen_Click(object sender, EventArgs e)
        {
            buttonLoeschen();
        }

        private void buttonLoeschen()
        {
            fahrradID = fahrrad.Find(x => x.Modell == dataGridViewFahrrad.CurrentRow.Cells[1].Value.ToString()).FahrradID;
            db.deleteFahrrad(fahrradID.Value);
            onLoad();
        }
    }
}
