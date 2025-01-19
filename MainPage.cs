using System.Windows.Forms;

namespace FahrradHandel
{
    public partial class MainPage : Form
    {
        private Random rd = new Random();
        private int radDesTages;

        private List<Fahrrad> fahrraeder = new List<Fahrrad>();


        private Datenbank db = new Datenbank();

        public MainPage()
        {
            InitializeComponent();
            onLoadLists();
            onLoadRadDesTages();
        }




        #region onLoad

        private void onLoadLists()
        {
            fahrraeder = db.getFahrrad();
        }

        private void onLoadRadDesTages()
        {
            int maxRan = fahrraeder.Count;
            radDesTages = rd.Next(0, maxRan);

            labelRadDesTagesMarkeWert.Text = fahrraeder[radDesTages].Marke;
            labelRadDesTagesPreisWert.Text = fahrraeder[radDesTages].Preis.ToString() + " €";
            labelRadDesTagesModell.Text = fahrraeder[radDesTages].Modell;

            int lager = fahrraeder[radDesTages].AufLager;

            if (lager > 0)
            {
                labelRadDesTagesAufLagerWert.Text = "Auf Lager";
            }
            else
            {
                labelRadDesTagesAufLagerWert.Text = "Nicht auf Lager";

            }

            #endregion
        }

        private void onLoadPicture()
        {
            string path = fahrraeder[radDesTages].ImagePath;
            pictureBox1.ImageLocation = path;
        }

        #region Fenster Oeffnen
        private void panelButtonTeile_Click(object sender, EventArgs e)
        {
            Teile t = new Teile();

            t.FormClosed += Teile_FormClosed;

            t.Show();
        }

        private void Teile_FormClosed(object sender, FormClosedEventArgs e)
        {
            onLoadLists();
        }

        private void panelButtonFahrrad_Click(object sender, EventArgs e)
        {
            loadFahrrad();
        }

        private void labelButtonFahrrad_Click(object sender, EventArgs e)
        {
            loadFahrrad();
        }

        private void loadFahrrad()
        {
            Fahrraeder f = new Fahrraeder();

            f.FormClosed += Fahrraeder_FormClosed;

            f.Show();
        }

        private void Fahrraeder_FormClosed(object sender, FormClosedEventArgs e)
        {
            onLoadLists();
        }



        #endregion

        
    }
}