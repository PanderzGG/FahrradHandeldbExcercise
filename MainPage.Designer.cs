namespace FahrradHandel
{
    partial class MainPage
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panelTitel = new Panel();
            labelFahrradHandel = new Label();
            panelFahrraddesTages = new Panel();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            labelRadDesTagesModell = new Label();
            panelRadDesTagesText = new Panel();
            labelRadDesTagesAuflager = new Label();
            labelRadDesTagesAufLagerWert = new Label();
            labelRadDesTagesPreisWert = new Label();
            labelRadDesTagesPreis = new Label();
            labelRadDesTagesMarke = new Label();
            labelRadDesTagesMarkeWert = new Label();
            panelButtonFahrrad = new Panel();
            labelButtonFahrrad = new Label();
            panelButtonTeile = new Panel();
            labelEinzelTeile = new Label();
            panelTitel.SuspendLayout();
            panelFahrraddesTages.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panelRadDesTagesText.SuspendLayout();
            panelButtonFahrrad.SuspendLayout();
            panelButtonTeile.SuspendLayout();
            SuspendLayout();
            // 
            // panelTitel
            // 
            panelTitel.BackColor = Color.FromArgb(57, 91, 100);
            panelTitel.Controls.Add(labelFahrradHandel);
            panelTitel.Location = new Point(-5, 0);
            panelTitel.Name = "panelTitel";
            panelTitel.Size = new Size(870, 179);
            panelTitel.TabIndex = 0;
            // 
            // labelFahrradHandel
            // 
            labelFahrradHandel.AutoSize = true;
            labelFahrradHandel.FlatStyle = FlatStyle.Flat;
            labelFahrradHandel.Font = new Font("Segoe UI", 46F);
            labelFahrradHandel.ForeColor = Color.FromArgb(231, 246, 242);
            labelFahrradHandel.Location = new Point(5, 47);
            labelFahrradHandel.Name = "labelFahrradHandel";
            labelFahrradHandel.Size = new Size(860, 84);
            labelFahrradHandel.TabIndex = 0;
            labelFahrradHandel.Text = "Fahrradhandel Kauf im Bundle";
            // 
            // panelFahrraddesTages
            // 
            panelFahrraddesTages.BackColor = Color.FromArgb(57, 91, 100);
            panelFahrraddesTages.Controls.Add(panel1);
            panelFahrraddesTages.Controls.Add(panelRadDesTagesText);
            panelFahrraddesTages.Location = new Point(62, 264);
            panelFahrraddesTages.Name = "panelFahrraddesTages";
            panelFahrraddesTages.Size = new Size(732, 378);
            panelFahrraddesTages.TabIndex = 1;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(231, 246, 242);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(labelRadDesTagesModell);
            panel1.Location = new Point(380, 29);
            panel1.Name = "panel1";
            panel1.Size = new Size(325, 324);
            panel1.TabIndex = 9;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.FromArgb(240, 247, 244);
            pictureBox1.Location = new Point(13, 57);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(297, 250);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // labelRadDesTagesModell
            // 
            labelRadDesTagesModell.AutoSize = true;
            labelRadDesTagesModell.Enabled = false;
            labelRadDesTagesModell.Font = new Font("Segoe UI", 30F);
            labelRadDesTagesModell.ForeColor = Color.FromArgb(44, 51, 51);
            labelRadDesTagesModell.Location = new Point(0, 0);
            labelRadDesTagesModell.Name = "labelRadDesTagesModell";
            labelRadDesTagesModell.Size = new Size(147, 54);
            labelRadDesTagesModell.TabIndex = 1;
            labelRadDesTagesModell.Text = "Modell";
            // 
            // panelRadDesTagesText
            // 
            panelRadDesTagesText.BackColor = Color.FromArgb(231, 246, 242);
            panelRadDesTagesText.Controls.Add(labelRadDesTagesAuflager);
            panelRadDesTagesText.Controls.Add(labelRadDesTagesAufLagerWert);
            panelRadDesTagesText.Controls.Add(labelRadDesTagesPreisWert);
            panelRadDesTagesText.Controls.Add(labelRadDesTagesPreis);
            panelRadDesTagesText.Controls.Add(labelRadDesTagesMarke);
            panelRadDesTagesText.Controls.Add(labelRadDesTagesMarkeWert);
            panelRadDesTagesText.Location = new Point(19, 29);
            panelRadDesTagesText.Name = "panelRadDesTagesText";
            panelRadDesTagesText.Size = new Size(325, 324);
            panelRadDesTagesText.TabIndex = 8;
            // 
            // labelRadDesTagesAuflager
            // 
            labelRadDesTagesAuflager.AutoSize = true;
            labelRadDesTagesAuflager.Enabled = false;
            labelRadDesTagesAuflager.Font = new Font("Segoe UI", 18F);
            labelRadDesTagesAuflager.ForeColor = Color.FromArgb(44, 51, 51);
            labelRadDesTagesAuflager.Location = new Point(18, 231);
            labelRadDesTagesAuflager.Name = "labelRadDesTagesAuflager";
            labelRadDesTagesAuflager.Size = new Size(121, 32);
            labelRadDesTagesAuflager.TabIndex = 6;
            labelRadDesTagesAuflager.Text = "Auf Lager:";
            // 
            // labelRadDesTagesAufLagerWert
            // 
            labelRadDesTagesAufLagerWert.AutoSize = true;
            labelRadDesTagesAufLagerWert.Enabled = false;
            labelRadDesTagesAufLagerWert.Font = new Font("Segoe UI", 30F);
            labelRadDesTagesAufLagerWert.ForeColor = Color.FromArgb(44, 51, 51);
            labelRadDesTagesAufLagerWert.Location = new Point(13, 263);
            labelRadDesTagesAufLagerWert.Name = "labelRadDesTagesAufLagerWert";
            labelRadDesTagesAufLagerWert.Size = new Size(218, 54);
            labelRadDesTagesAufLagerWert.TabIndex = 7;
            labelRadDesTagesAufLagerWert.Text = "Unbekannt";
            // 
            // labelRadDesTagesPreisWert
            // 
            labelRadDesTagesPreisWert.AutoSize = true;
            labelRadDesTagesPreisWert.Enabled = false;
            labelRadDesTagesPreisWert.Font = new Font("Segoe UI", 30F);
            labelRadDesTagesPreisWert.ForeColor = Color.FromArgb(44, 51, 51);
            labelRadDesTagesPreisWert.Location = new Point(47, 146);
            labelRadDesTagesPreisWert.Name = "labelRadDesTagesPreisWert";
            labelRadDesTagesPreisWert.Size = new Size(126, 54);
            labelRadDesTagesPreisWert.TabIndex = 5;
            labelRadDesTagesPreisWert.Text = "#,##€";
            // 
            // labelRadDesTagesPreis
            // 
            labelRadDesTagesPreis.AutoSize = true;
            labelRadDesTagesPreis.Enabled = false;
            labelRadDesTagesPreis.Font = new Font("Segoe UI", 18F);
            labelRadDesTagesPreis.ForeColor = Color.FromArgb(44, 51, 51);
            labelRadDesTagesPreis.Location = new Point(13, 114);
            labelRadDesTagesPreis.Name = "labelRadDesTagesPreis";
            labelRadDesTagesPreis.Size = new Size(69, 32);
            labelRadDesTagesPreis.TabIndex = 4;
            labelRadDesTagesPreis.Text = "Preis:";
            // 
            // labelRadDesTagesMarke
            // 
            labelRadDesTagesMarke.AutoSize = true;
            labelRadDesTagesMarke.Enabled = false;
            labelRadDesTagesMarke.Font = new Font("Segoe UI", 18F);
            labelRadDesTagesMarke.ForeColor = Color.FromArgb(44, 51, 51);
            labelRadDesTagesMarke.Location = new Point(13, 6);
            labelRadDesTagesMarke.Name = "labelRadDesTagesMarke";
            labelRadDesTagesMarke.Size = new Size(86, 32);
            labelRadDesTagesMarke.TabIndex = 3;
            labelRadDesTagesMarke.Text = "Marke:";
            // 
            // labelRadDesTagesMarkeWert
            // 
            labelRadDesTagesMarkeWert.AutoSize = true;
            labelRadDesTagesMarkeWert.Enabled = false;
            labelRadDesTagesMarkeWert.Font = new Font("Segoe UI", 30F);
            labelRadDesTagesMarkeWert.ForeColor = Color.FromArgb(44, 51, 51);
            labelRadDesTagesMarkeWert.Location = new Point(3, 38);
            labelRadDesTagesMarkeWert.Name = "labelRadDesTagesMarkeWert";
            labelRadDesTagesMarkeWert.Size = new Size(218, 54);
            labelRadDesTagesMarkeWert.TabIndex = 2;
            labelRadDesTagesMarkeWert.Text = "MarkeWert";
            // 
            // panelButtonFahrrad
            // 
            panelButtonFahrrad.BackColor = Color.FromArgb(165, 201, 202);
            panelButtonFahrrad.Controls.Add(labelButtonFahrrad);
            panelButtonFahrrad.Location = new Point(-5, 179);
            panelButtonFahrrad.Name = "panelButtonFahrrad";
            panelButtonFahrrad.Size = new Size(430, 67);
            panelButtonFahrrad.TabIndex = 2;
            panelButtonFahrrad.Click += panelButtonFahrrad_Click;
            // 
            // labelButtonFahrrad
            // 
            labelButtonFahrrad.AutoSize = true;
            labelButtonFahrrad.Font = new Font("Segoe UI", 20F);
            labelButtonFahrrad.ForeColor = Color.FromArgb(231, 246, 242);
            labelButtonFahrrad.Location = new Point(151, 15);
            labelButtonFahrrad.Name = "labelButtonFahrrad";
            labelButtonFahrrad.Size = new Size(129, 37);
            labelButtonFahrrad.TabIndex = 0;
            labelButtonFahrrad.Text = "Fahrräder";
            labelButtonFahrrad.Click += labelButtonFahrrad_Click;
            // 
            // panelButtonTeile
            // 
            panelButtonTeile.BackColor = Color.FromArgb(165, 201, 202);
            panelButtonTeile.Controls.Add(labelEinzelTeile);
            panelButtonTeile.Location = new Point(424, 179);
            panelButtonTeile.Name = "panelButtonTeile";
            panelButtonTeile.Size = new Size(443, 67);
            panelButtonTeile.TabIndex = 3;
            panelButtonTeile.Click += panelButtonTeile_Click;
            // 
            // labelEinzelTeile
            // 
            labelEinzelTeile.AutoSize = true;
            labelEinzelTeile.Font = new Font("Segoe UI", 20F);
            labelEinzelTeile.ForeColor = Color.FromArgb(231, 246, 242);
            labelEinzelTeile.Location = new Point(186, 15);
            labelEinzelTeile.Name = "labelEinzelTeile";
            labelEinzelTeile.Size = new Size(70, 37);
            labelEinzelTeile.TabIndex = 1;
            labelEinzelTeile.Text = "Teile";
            // 
            // MainPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(44, 51, 51);
            ClientSize = new Size(861, 685);
            Controls.Add(panelButtonTeile);
            Controls.Add(panelFahrraddesTages);
            Controls.Add(panelButtonFahrrad);
            Controls.Add(panelTitel);
            ForeColor = SystemColors.ControlText;
            Name = "MainPage";
            Text = "Fahrradhandel";
            panelTitel.ResumeLayout(false);
            panelTitel.PerformLayout();
            panelFahrraddesTages.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panelRadDesTagesText.ResumeLayout(false);
            panelRadDesTagesText.PerformLayout();
            panelButtonFahrrad.ResumeLayout(false);
            panelButtonFahrrad.PerformLayout();
            panelButtonTeile.ResumeLayout(false);
            panelButtonTeile.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelTitel;
        private Label labelFahrradHandel;
        private Panel panelFahrraddesTages;
        private Label labelRadDesTagesModell;
        private PictureBox pictureBox1;
        private Label labelRadDesTagesAuflager;
        private Label labelRadDesTagesPreisWert;
        private Label labelRadDesTagesPreis;
        private Label labelRadDesTagesMarke;
        private Label labelRadDesTagesMarkeWert;
        private Label labelRadDesTagesAufLagerWert;
        private Panel panelButtonFahrrad;
        private Panel panelButtonTeile;
        private Label labelButtonFahrrad;
        private Label labelEinzelTeile;
        private Panel panelRadDesTagesText;
        private Panel panel1;
    }
}
