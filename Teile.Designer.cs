namespace FahrradHandel
{
    partial class Teile
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panelButtonTeileFahrrad = new Panel();
            labelButtonTeileFahrraeder = new Label();
            panelTitel = new Panel();
            labelFahrradHandel = new Label();
            labelButtonTeileZurueck = new Label();
            panelButtonTeileZurueck = new Panel();
            panelButtonTeileFahrrad.SuspendLayout();
            panelTitel.SuspendLayout();
            panelButtonTeileZurueck.SuspendLayout();
            SuspendLayout();
            // 
            // panelButtonTeileFahrrad
            // 
            panelButtonTeileFahrrad.BackColor = Color.FromArgb(110, 73, 225);
            panelButtonTeileFahrrad.Controls.Add(labelButtonTeileFahrraeder);
            panelButtonTeileFahrrad.Location = new Point(-8, 179);
            panelButtonTeileFahrrad.Name = "panelButtonTeileFahrrad";
            panelButtonTeileFahrrad.Size = new Size(561, 67);
            panelButtonTeileFahrrad.TabIndex = 7;
            // 
            // labelButtonTeileFahrraeder
            // 
            labelButtonTeileFahrraeder.AutoSize = true;
            labelButtonTeileFahrraeder.Font = new Font("Segoe UI", 20F);
            labelButtonTeileFahrraeder.ForeColor = Color.White;
            labelButtonTeileFahrraeder.Location = new Point(207, 15);
            labelButtonTeileFahrraeder.Name = "labelButtonTeileFahrraeder";
            labelButtonTeileFahrraeder.Size = new Size(129, 37);
            labelButtonTeileFahrraeder.TabIndex = 0;
            labelButtonTeileFahrraeder.Text = "Fahrräder";
            // 
            // panelTitel
            // 
            panelTitel.BackColor = Color.FromArgb(16, 11, 34);
            panelTitel.Controls.Add(labelFahrradHandel);
            panelTitel.Location = new Point(0, 0);
            panelTitel.Name = "panelTitel";
            panelTitel.Size = new Size(1100, 179);
            panelTitel.TabIndex = 6;
            // 
            // labelFahrradHandel
            // 
            labelFahrradHandel.AutoSize = true;
            labelFahrradHandel.FlatStyle = FlatStyle.Flat;
            labelFahrradHandel.Font = new Font("Segoe UI", 46F);
            labelFahrradHandel.ForeColor = Color.White;
            labelFahrradHandel.Location = new Point(120, 47);
            labelFahrradHandel.Name = "labelFahrradHandel";
            labelFahrradHandel.Size = new Size(860, 84);
            labelFahrradHandel.TabIndex = 0;
            labelFahrradHandel.Text = "Fahrradhandel Kauf im Bundle";
            // 
            // labelButtonTeileZurueck
            // 
            labelButtonTeileZurueck.AutoSize = true;
            labelButtonTeileZurueck.Font = new Font("Segoe UI", 20F);
            labelButtonTeileZurueck.ForeColor = Color.White;
            labelButtonTeileZurueck.Location = new Point(226, 15);
            labelButtonTeileZurueck.Name = "labelButtonTeileZurueck";
            labelButtonTeileZurueck.Size = new Size(96, 37);
            labelButtonTeileZurueck.TabIndex = 1;
            labelButtonTeileZurueck.Text = "Zurück";
            // 
            // panelButtonTeileZurueck
            // 
            panelButtonTeileZurueck.BackColor = Color.FromArgb(110, 73, 225);
            panelButtonTeileZurueck.Controls.Add(labelButtonTeileZurueck);
            panelButtonTeileZurueck.Location = new Point(553, 179);
            panelButtonTeileZurueck.Name = "panelButtonTeileZurueck";
            panelButtonTeileZurueck.Size = new Size(548, 67);
            panelButtonTeileZurueck.TabIndex = 8;
            // 
            // Teile
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(43, 30, 86);
            ClientSize = new Size(1101, 836);
            Controls.Add(panelButtonTeileZurueck);
            Controls.Add(panelButtonTeileFahrrad);
            Controls.Add(panelTitel);
            Name = "Teile";
            Text = "Teile";
            panelButtonTeileFahrrad.ResumeLayout(false);
            panelButtonTeileFahrrad.PerformLayout();
            panelTitel.ResumeLayout(false);
            panelTitel.PerformLayout();
            panelButtonTeileZurueck.ResumeLayout(false);
            panelButtonTeileZurueck.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelButtonTeileFahrrad;
        private Label labelButtonTeileFahrraeder;
        private Panel panelTitel;
        private Label labelFahrradHandel;
        private Label labelButtonTeileZurueck;
        private Panel panelButtonTeileZurueck;
    }
}