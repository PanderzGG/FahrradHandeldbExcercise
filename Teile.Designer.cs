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
            panel1 = new Panel();
            comboBoxTeilAuswahl = new ComboBox();
            labelTeile = new Label();
            dataGridViewTeile = new DataGridView();
            panelTeilHinzufuegen = new Panel();
            label1 = new Label();
            panelButtonTeileFahrrad.SuspendLayout();
            panelTitel.SuspendLayout();
            panelButtonTeileZurueck.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewTeile).BeginInit();
            panelTeilHinzufuegen.SuspendLayout();
            SuspendLayout();
            // 
            // panelButtonTeileFahrrad
            // 
            panelButtonTeileFahrrad.BackColor = Color.FromArgb(165, 201, 202);
            panelButtonTeileFahrrad.Controls.Add(labelButtonTeileFahrraeder);
            panelButtonTeileFahrrad.Location = new Point(-8, 179);
            panelButtonTeileFahrrad.Name = "panelButtonTeileFahrrad";
            panelButtonTeileFahrrad.Size = new Size(621, 67);
            panelButtonTeileFahrrad.TabIndex = 7;
            // 
            // labelButtonTeileFahrraeder
            // 
            labelButtonTeileFahrraeder.AutoSize = true;
            labelButtonTeileFahrraeder.Font = new Font("Segoe UI", 20F);
            labelButtonTeileFahrraeder.ForeColor = Color.FromArgb(231, 246, 242);
            labelButtonTeileFahrraeder.Location = new Point(243, 15);
            labelButtonTeileFahrraeder.Name = "labelButtonTeileFahrraeder";
            labelButtonTeileFahrraeder.Size = new Size(129, 37);
            labelButtonTeileFahrraeder.TabIndex = 0;
            labelButtonTeileFahrraeder.Text = "Fahrräder";
            // 
            // panelTitel
            // 
            panelTitel.BackColor = Color.FromArgb(57, 91, 100);
            panelTitel.Controls.Add(labelFahrradHandel);
            panelTitel.Location = new Point(0, 0);
            panelTitel.Name = "panelTitel";
            panelTitel.Size = new Size(1233, 179);
            panelTitel.TabIndex = 6;
            // 
            // labelFahrradHandel
            // 
            labelFahrradHandel.AutoSize = true;
            labelFahrradHandel.FlatStyle = FlatStyle.Flat;
            labelFahrradHandel.Font = new Font("Segoe UI", 46F);
            labelFahrradHandel.ForeColor = Color.FromArgb(231, 246, 242);
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
            labelButtonTeileZurueck.ForeColor = Color.FromArgb(231, 246, 242);
            labelButtonTeileZurueck.Location = new Point(262, 15);
            labelButtonTeileZurueck.Name = "labelButtonTeileZurueck";
            labelButtonTeileZurueck.Size = new Size(96, 37);
            labelButtonTeileZurueck.TabIndex = 1;
            labelButtonTeileZurueck.Text = "Zurück";
            // 
            // panelButtonTeileZurueck
            // 
            panelButtonTeileZurueck.BackColor = Color.FromArgb(165, 201, 202);
            panelButtonTeileZurueck.Controls.Add(labelButtonTeileZurueck);
            panelButtonTeileZurueck.Location = new Point(619, 179);
            panelButtonTeileZurueck.Name = "panelButtonTeileZurueck";
            panelButtonTeileZurueck.Size = new Size(614, 67);
            panelButtonTeileZurueck.TabIndex = 8;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(165, 201, 202);
            panel1.Controls.Add(comboBoxTeilAuswahl);
            panel1.Controls.Add(labelTeile);
            panel1.Location = new Point(57, 278);
            panel1.Name = "panel1";
            panel1.Size = new Size(271, 112);
            panel1.TabIndex = 9;
            // 
            // comboBoxTeilAuswahl
            // 
            comboBoxTeilAuswahl.Font = new Font("Segoe UI", 18F);
            comboBoxTeilAuswahl.FormattingEnabled = true;
            comboBoxTeilAuswahl.Location = new Point(20, 36);
            comboBoxTeilAuswahl.Name = "comboBoxTeilAuswahl";
            comboBoxTeilAuswahl.Size = new Size(230, 40);
            comboBoxTeilAuswahl.TabIndex = 1;
            comboBoxTeilAuswahl.SelectedIndexChanged += comboBoxTeilAuswahl_SelectedIndexChanged;
            // 
            // labelTeile
            // 
            labelTeile.AutoSize = true;
            labelTeile.Font = new Font("Segoe UI", 16F);
            labelTeile.Location = new Point(20, 3);
            labelTeile.Name = "labelTeile";
            labelTeile.Size = new Size(45, 30);
            labelTeile.TabIndex = 0;
            labelTeile.Text = "Teil";
            // 
            // dataGridViewTeile
            // 
            dataGridViewTeile.AllowUserToAddRows = false;
            dataGridViewTeile.AllowUserToDeleteRows = false;
            dataGridViewTeile.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewTeile.BorderStyle = BorderStyle.None;
            dataGridViewTeile.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewTeile.Location = new Point(334, 278);
            dataGridViewTeile.MultiSelect = false;
            dataGridViewTeile.Name = "dataGridViewTeile";
            dataGridViewTeile.ReadOnly = true;
            dataGridViewTeile.RowHeadersVisible = false;
            dataGridViewTeile.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewTeile.Size = new Size(882, 546);
            dataGridViewTeile.TabIndex = 10;
            // 
            // panelTeilHinzufuegen
            // 
            panelTeilHinzufuegen.BackColor = Color.FromArgb(165, 201, 202);
            panelTeilHinzufuegen.Controls.Add(label1);
            panelTeilHinzufuegen.Location = new Point(57, 420);
            panelTeilHinzufuegen.Name = "panelTeilHinzufuegen";
            panelTeilHinzufuegen.Size = new Size(271, 80);
            panelTeilHinzufuegen.TabIndex = 10;
            panelTeilHinzufuegen.Click += panelTeilHinzufuegen_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F);
            label1.Location = new Point(66, 24);
            label1.Name = "label1";
            label1.Size = new Size(139, 32);
            label1.TabIndex = 0;
            label1.Text = "Hinzufügen";
            label1.Click += panelTeilHinzufuegen_Click;
            // 
            // Teile
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(44, 51, 51);
            ClientSize = new Size(1232, 836);
            Controls.Add(panelTeilHinzufuegen);
            Controls.Add(panelButtonTeileZurueck);
            Controls.Add(dataGridViewTeile);
            Controls.Add(panel1);
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
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewTeile).EndInit();
            panelTeilHinzufuegen.ResumeLayout(false);
            panelTeilHinzufuegen.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelButtonTeileFahrrad;
        private Label labelButtonTeileFahrraeder;
        private Panel panelTitel;
        private Label labelFahrradHandel;
        private Label labelButtonTeileZurueck;
        private Panel panelButtonTeileZurueck;
        private Panel panel1;
        private Label labelTeile;
        private ComboBox comboBoxTeilAuswahl;
        private DataGridView dataGridViewTeile;
        private Panel panelTeilHinzufuegen;
        private Label label1;
    }
}