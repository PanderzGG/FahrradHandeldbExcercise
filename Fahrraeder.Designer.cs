namespace FahrradHandel
{
    partial class Fahrraeder
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            panelTitel = new Panel();
            labelFahrradHandel = new Label();
            panelButtonNeuesFahrrad = new Panel();
            labelNeuesFahrrad = new Label();
            panelButtonFahrradZurueck = new Panel();
            labelButtonZurück = new Label();
            dataGridViewFahrrad = new DataGridView();
            marke = new DataGridViewTextBoxColumn();
            modell = new DataGridViewTextBoxColumn();
            preis = new DataGridViewTextBoxColumn();
            stkaufLager = new DataGridViewTextBoxColumn();
            panelClearSelect = new Panel();
            labelAuswahlAufheben = new Label();
            panelFahrradLoeschen = new Panel();
            labelfahrradLoeschen = new Label();
            panelTitel.SuspendLayout();
            panelButtonNeuesFahrrad.SuspendLayout();
            panelButtonFahrradZurueck.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewFahrrad).BeginInit();
            panelClearSelect.SuspendLayout();
            panelFahrradLoeschen.SuspendLayout();
            SuspendLayout();
            // 
            // panelTitel
            // 
            panelTitel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panelTitel.BackColor = Color.FromArgb(57, 91, 100);
            panelTitel.Controls.Add(labelFahrradHandel);
            panelTitel.Location = new Point(0, 0);
            panelTitel.Name = "panelTitel";
            panelTitel.Size = new Size(903, 179);
            panelTitel.TabIndex = 1;
            // 
            // labelFahrradHandel
            // 
            labelFahrradHandel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            labelFahrradHandel.AutoSize = true;
            labelFahrradHandel.FlatStyle = FlatStyle.Flat;
            labelFahrradHandel.Font = new Font("Segoe UI", 46F);
            labelFahrradHandel.ForeColor = Color.FromArgb(231, 246, 242);
            labelFahrradHandel.Location = new Point(21, 47);
            labelFahrradHandel.Name = "labelFahrradHandel";
            labelFahrradHandel.Size = new Size(860, 84);
            labelFahrradHandel.TabIndex = 0;
            labelFahrradHandel.Text = "Fahrradhandel Kauf im Bundle";
            // 
            // panelButtonNeuesFahrrad
            // 
            panelButtonNeuesFahrrad.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panelButtonNeuesFahrrad.BackColor = Color.FromArgb(165, 201, 202);
            panelButtonNeuesFahrrad.Controls.Add(labelNeuesFahrrad);
            panelButtonNeuesFahrrad.Location = new Point(447, 179);
            panelButtonNeuesFahrrad.Name = "panelButtonNeuesFahrrad";
            panelButtonNeuesFahrrad.Size = new Size(456, 67);
            panelButtonNeuesFahrrad.TabIndex = 5;
            panelButtonNeuesFahrrad.Click += panelButtonNeuesFahrrad_Click;
            // 
            // labelNeuesFahrrad
            // 
            labelNeuesFahrrad.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            labelNeuesFahrrad.Font = new Font("Segoe UI", 20F);
            labelNeuesFahrrad.ForeColor = Color.FromArgb(231, 246, 242);
            labelNeuesFahrrad.Location = new Point(133, 11);
            labelNeuesFahrrad.Name = "labelNeuesFahrrad";
            labelNeuesFahrrad.Size = new Size(191, 44);
            labelNeuesFahrrad.TabIndex = 1;
            labelNeuesFahrrad.Text = "Neues Fahrrad";
            labelNeuesFahrrad.TextAlign = ContentAlignment.MiddleCenter;
            labelNeuesFahrrad.Click += labelNeuesFahrrad_Click;
            // 
            // panelButtonFahrradZurueck
            // 
            panelButtonFahrradZurueck.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panelButtonFahrradZurueck.BackColor = Color.FromArgb(165, 201, 202);
            panelButtonFahrradZurueck.Controls.Add(labelButtonZurück);
            panelButtonFahrradZurueck.ForeColor = SystemColors.ControlLightLight;
            panelButtonFahrradZurueck.Location = new Point(-2, 179);
            panelButtonFahrradZurueck.Name = "panelButtonFahrradZurueck";
            panelButtonFahrradZurueck.Size = new Size(451, 67);
            panelButtonFahrradZurueck.TabIndex = 4;
            panelButtonFahrradZurueck.Click += panelButtonFahrradZurueck_Click;
            // 
            // labelButtonZurück
            // 
            labelButtonZurück.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            labelButtonZurück.AutoSize = true;
            labelButtonZurück.Font = new Font("Segoe UI", 20F);
            labelButtonZurück.ForeColor = Color.FromArgb(231, 246, 242);
            labelButtonZurück.Location = new Point(177, 15);
            labelButtonZurück.Name = "labelButtonZurück";
            labelButtonZurück.Size = new Size(96, 37);
            labelButtonZurück.TabIndex = 0;
            labelButtonZurück.Text = "Zurück";
            labelButtonZurück.Click += labelButtonZurück_Click;
            // 
            // dataGridViewFahrrad
            // 
            dataGridViewFahrrad.AllowUserToAddRows = false;
            dataGridViewFahrrad.AllowUserToDeleteRows = false;
            dataGridViewFahrrad.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(57, 91, 100);
            dataGridViewCellStyle1.ForeColor = Color.FromArgb(231, 246, 242);
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(165, 201, 202);
            dataGridViewCellStyle1.SelectionForeColor = Color.FromArgb(44, 51, 51);
            dataGridViewFahrrad.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewFahrrad.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewFahrrad.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewFahrrad.BackgroundColor = Color.FromArgb(44, 51, 51);
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(110, 73, 225);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dataGridViewFahrrad.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewFahrrad.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewFahrrad.Columns.AddRange(new DataGridViewColumn[] { marke, modell, preis, stkaufLager });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(44, 51, 51);
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(231, 246, 242);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(165, 201, 202);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(44, 51, 51);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dataGridViewFahrrad.DefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewFahrrad.GridColor = Color.FromArgb(231, 246, 242);
            dataGridViewFahrrad.Location = new Point(51, 275);
            dataGridViewFahrrad.MultiSelect = false;
            dataGridViewFahrrad.Name = "dataGridViewFahrrad";
            dataGridViewFahrrad.ReadOnly = true;
            dataGridViewFahrrad.RowHeadersVisible = false;
            dataGridViewFahrrad.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewFahrrad.Size = new Size(800, 350);
            dataGridViewFahrrad.TabIndex = 6;
            dataGridViewFahrrad.SelectionChanged += dataGridViewFahrrad_SelectionChanged;
            // 
            // marke
            // 
            marke.HeaderText = "Marke";
            marke.Name = "marke";
            marke.ReadOnly = true;
            // 
            // modell
            // 
            modell.HeaderText = "Modell";
            modell.Name = "modell";
            modell.ReadOnly = true;
            // 
            // preis
            // 
            preis.HeaderText = "Preis in €";
            preis.Name = "preis";
            preis.ReadOnly = true;
            // 
            // stkaufLager
            // 
            stkaufLager.HeaderText = "Stück auf Lager";
            stkaufLager.Name = "stkaufLager";
            stkaufLager.ReadOnly = true;
            // 
            // panelClearSelect
            // 
            panelClearSelect.Anchor = AnchorStyles.None;
            panelClearSelect.BackColor = Color.FromArgb(165, 201, 202);
            panelClearSelect.Controls.Add(labelAuswahlAufheben);
            panelClearSelect.Location = new Point(686, 641);
            panelClearSelect.Name = "panelClearSelect";
            panelClearSelect.Size = new Size(165, 53);
            panelClearSelect.TabIndex = 7;
            panelClearSelect.Click += panelClearSelect_Click;
            // 
            // labelAuswahlAufheben
            // 
            labelAuswahlAufheben.Anchor = AnchorStyles.None;
            labelAuswahlAufheben.AutoSize = true;
            labelAuswahlAufheben.ForeColor = Color.FromArgb(231, 246, 242);
            labelAuswahlAufheben.Location = new Point(29, 19);
            labelAuswahlAufheben.Name = "labelAuswahlAufheben";
            labelAuswahlAufheben.Size = new Size(105, 15);
            labelAuswahlAufheben.TabIndex = 0;
            labelAuswahlAufheben.Text = "Auswahl aufheben";
            labelAuswahlAufheben.Click += labelAuswahlAufheben_Click;
            // 
            // panelFahrradLoeschen
            // 
            panelFahrradLoeschen.Anchor = AnchorStyles.None;
            panelFahrradLoeschen.BackColor = Color.FromArgb(165, 201, 202);
            panelFahrradLoeschen.Controls.Add(labelfahrradLoeschen);
            panelFahrradLoeschen.Location = new Point(51, 641);
            panelFahrradLoeschen.Name = "panelFahrradLoeschen";
            panelFahrradLoeschen.Size = new Size(165, 53);
            panelFahrradLoeschen.TabIndex = 8;
            panelFahrradLoeschen.Click += panelFahrradLoeschen_Click;
            // 
            // labelfahrradLoeschen
            // 
            labelfahrradLoeschen.Anchor = AnchorStyles.None;
            labelfahrradLoeschen.AutoSize = true;
            labelfahrradLoeschen.ForeColor = Color.FromArgb(231, 246, 242);
            labelfahrradLoeschen.Location = new Point(35, 19);
            labelfahrradLoeschen.Name = "labelfahrradLoeschen";
            labelfahrradLoeschen.Size = new Size(94, 15);
            labelfahrradLoeschen.TabIndex = 0;
            labelfahrradLoeschen.Text = "Fahrrad Löschen";
            labelfahrradLoeschen.Click += labelfahrradLoeschen_Click;
            // 
            // Fahrraeder
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(44, 51, 51);
            ClientSize = new Size(903, 706);
            Controls.Add(panelFahrradLoeschen);
            Controls.Add(panelClearSelect);
            Controls.Add(dataGridViewFahrrad);
            Controls.Add(panelButtonNeuesFahrrad);
            Controls.Add(panelButtonFahrradZurueck);
            Controls.Add(panelTitel);
            Name = "Fahrraeder";
            Text = "Fahrraeder";
            panelTitel.ResumeLayout(false);
            panelTitel.PerformLayout();
            panelButtonNeuesFahrrad.ResumeLayout(false);
            panelButtonFahrradZurueck.ResumeLayout(false);
            panelButtonFahrradZurueck.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewFahrrad).EndInit();
            panelClearSelect.ResumeLayout(false);
            panelClearSelect.PerformLayout();
            panelFahrradLoeschen.ResumeLayout(false);
            panelFahrradLoeschen.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelTitel;
        private Label labelFahrradHandel;
        private Panel panelButtonNeuesFahrrad;
        private Label labelNeuesFahrrad;
        private Panel panelButtonFahrradZurueck;
        private Label labelButtonZurück;
        private DataGridView dataGridViewFahrrad;
        private DataGridViewTextBoxColumn marke;
        private DataGridViewTextBoxColumn modell;
        private DataGridViewTextBoxColumn preis;
        private DataGridViewTextBoxColumn stkaufLager;
        private Panel panelClearSelect;
        private Label labelAuswahlAufheben;
        private Panel panelFahrradLoeschen;
        private Label labelfahrradLoeschen;
    }
}