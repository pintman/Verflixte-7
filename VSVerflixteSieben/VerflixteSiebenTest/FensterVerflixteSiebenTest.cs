using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using VerflixteSieben;

namespace VerflixteSiebenTest
{
    public partial class FensterVerflixteSiebenTest : Form
    {

        Wuerfel wuerfel1;
        Wuerfel wuerfel2;
        Spieler spieler1;
        Spieler spieler2;
        Topf topf = new Topf();

        public FensterVerflixteSiebenTest()
        {
            InitializeComponent();
        }

        private void btnTestStarten_Click(object sender, EventArgs e)
        {
            Initialisierung();

            EinsaetzeMachen();

            ZugVonSpieler1();

            ZugVonSpieler2();

            AuswertungDurchführen();
        }

        private void AuswertungDurchführen()
        {
            if (spieler1.punktestandAngeben() > spieler2.punktestandAngeben())
            {
                Ausgeben("Spieler 1 hat gewonnen!");
                spieler1.topfLeeren();
            }
            else if (spieler2.punktestandAngeben() > spieler1.punktestandAngeben())
            {
                Ausgeben("Spieler 2 hat gewonnen!");
                spieler2.topfLeeren();
            }
        }

        private void ZugVonSpieler2()
        {
            Ausgeben("Spieler 2 würfelt höchstens so oft wie Spieler 1");
            do
            {
                spieler2.wuerfeln();
                Ausgeben("Würfel 1: " + wuerfel1.punktzahlAngeben() + " Würfel 2: " + wuerfel2.punktzahlAngeben());

            } while (spieler2.wurfAnzahlAngeben() < spieler1.wurfAnzahlAngeben()
                && wuerfel1.punktzahlAngeben() + wuerfel2.punktzahlAngeben() != 7);

            Ausgeben("Punkte von Spieler 2: " + spieler2.punktestandAngeben());
            Ausgeben("Anzahl Würfe von Spieler 2: " + spieler2.wurfAnzahlAngeben());
        }

        private void ZugVonSpieler1()
        {
            Ausgeben("Spieler 1 würfelt höchstens 5-mal");
            for (int i = 1; i <= 5; i++)
            {
                spieler1.wuerfeln();
                Ausgeben("Würfel 1: " + wuerfel1.punktzahlAngeben() + " Würfel 2: " + wuerfel2.punktzahlAngeben());
                if (wuerfel1.punktzahlAngeben() + wuerfel2.punktzahlAngeben() == 7)
                {
                    break;
                }
            }

            Ausgeben("Punkte von Spieler 1: " + spieler1.punktestandAngeben());
            Ausgeben("Anzahl Würfe von Spieler 1: " + spieler1.wurfAnzahlAngeben());
        }

        private void EinsaetzeMachen()
        {
            Ausgeben("Spieler machen Einsatz");
            spieler1.einsatzSetzen(50);
            spieler1.einsatzSetzen(50);
        }

        private void Initialisierung()
        {
            Ausgeben("Erzeuge Topf");

            Ausgeben("Erzeuge Wuerfel");
            wuerfel1 = new Wuerfel();
            wuerfel2 = new Wuerfel();

            Ausgeben("Erzeuge Spieler");
            spieler1 = new Spieler(wuerfel1, wuerfel2, topf);
            spieler2 = new Spieler(wuerfel1, wuerfel2, topf);
        }

        private void Ausgeben(String sText)
        {
            tbAusgabe.Text += sText + System.Environment.NewLine;
        }
    }
}
