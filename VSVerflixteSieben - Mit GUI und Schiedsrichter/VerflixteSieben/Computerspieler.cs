using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VerflixteSieben
{
    public class Computerspieler : Spieler
    {
        private int punkteGegner;
        private int wurfzahlGegner;

        public Computerspieler(Wuerfel pWuerfel1, Wuerfel pWuerfel2, Topf pTopf) :
            // mit base() wird der Konstruktor aus der Oberklasse aufgerufen
            base(pWuerfel1, pWuerfel2, pTopf)
        {
        }

        public void SpielBeginnen()
        {
            punkteGegner = 999;
            wurfzahlGegner = 999;
        }

        public void AlsZweiterSpielerSpielen(int punkteGegner, int wurfzahlGegner)
        {
            this.punkteGegner = punkteGegner;
            this.wurfzahlGegner = wurfzahlGegner;
        }

        public bool WillWuerfeln()
        {
            if (this.PunktestandAngeben() < punkteGegner || this.WurfAnzahlAngeben() < wurfzahlGegner)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
