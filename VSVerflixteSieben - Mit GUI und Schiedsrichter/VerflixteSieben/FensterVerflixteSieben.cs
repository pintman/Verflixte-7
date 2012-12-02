using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace VerflixteSieben
{
    public partial class FensterVerflixteSieben : Form
    {
        private Spieler spieler1;
        private Spieler spieler2;
        private Wuerfel wuerfel1;
        private Wuerfel wuerfel2;
        private Topf topf;
        private Schiedsrichter schiri;

        public FensterVerflixteSieben()
        {
            InitializeComponent();

            wuerfel1 = new Wuerfel();
            wuerfel2 = new Wuerfel();
            topf = new Topf();
            spieler1 = new Spieler(wuerfel1, wuerfel2, topf);
            spieler2 = new Spieler(wuerfel1, wuerfel2, topf);
            schiri = new Schiedsrichter();

            AnzeigenAktualisieren();
        }

        private void btnSp1Wuerfeln_Click(object sender, EventArgs e)
        {
            #region
            //Computerspieler computer = new Computerspieler(wuerfel1, wuerfel2, topf);
            //spieler1 = computer;
            //computer.SpielBeginnen();
            //while (computer.WillWuerfeln() && computer.DarfWuerfeln())
            //{
            //    computer.wuerfeln();
            //    schiri.WurfAuswerten(computer, wuerfel1, wuerfel2);
            //    AnzeigenAktualisieren();
            //}
            #endregion

            spieler1.Wuerfeln();
            schiri.WurfAuswerten(spieler1, wuerfel1, wuerfel2);

            AnzeigenAktualisieren();
        }

        private void btnSp2Wuerfeln_Click(object sender, EventArgs e)
        {
            spieler2.Wuerfeln();
            schiri.WurfAuswerten(spieler2, wuerfel1, wuerfel2);
            
            AnzeigenAktualisieren();
        }

        private void btnEinsaetzeSetzen_Click(object sender, EventArgs e)
        {
            spieler1.EinsatzSetzen(Convert.ToInt32(nudEinsatzSpieler1.Value));
            spieler2.EinsatzSetzen(Convert.ToInt32(nudEinsatzSpieler2.Value));
            
            AnzeigenAktualisieren();
        }

        private void btnSpieler1TopfLeeren_Click(object sender, EventArgs e)
        {
            spieler1.TopfLeeren();

            AnzeigenAktualisieren();
        }

        private void btnSpieler2TopfLeeren_Click(object sender, EventArgs e)
        {
            spieler2.TopfLeeren();

            AnzeigenAktualisieren();
        }

        private void AnzeigenAktualisieren()
        {
            lblTopf.Text = "Topf: " + topf.EinsatzAbfragen();

            lblWuerfelergebnisse.Text = "Würfel: " + wuerfel1.PunktzahlAngeben() + "    " + wuerfel2.PunktzahlAngeben();

            lblAnzahlWurfeSp1.Text = "Würfe: " + spieler1.WurfAnzahlAngeben();
            lblPunkteSp1.Text = "Punkte: " + spieler1.PunktestandAngeben();

            lblAnzahlWurfeSp2.Text = "Würfe: " + spieler2.WurfAnzahlAngeben();
            lblPunkteSp2.Text = "Punkte: " + spieler2.PunktestandAngeben();

            if (!spieler1.DarfWuerfeln())
            {
                btnSp1Wuerfeln.Enabled = false;
            }
            else
            {
                btnSp1Wuerfeln.Enabled = true;
            }

            if (!spieler2.DarfWuerfeln() || spieler2.WurfAnzahlAngeben() == spieler1.WurfAnzahlAngeben())
            {
                btnSp2Wuerfeln.Enabled = false;
            }
            else
            {
                btnSp2Wuerfeln.Enabled = true;
            }
        }
    }
}
