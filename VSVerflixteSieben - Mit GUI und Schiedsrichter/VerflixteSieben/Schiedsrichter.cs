using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VerflixteSieben
{
    public class Schiedsrichter    
    {
        public void WurfAuswerten(Spieler spieler, Wuerfel wuerfel1, Wuerfel wuerfel2)
        {
            if (wuerfel1.PunktzahlAngeben() + wuerfel2.PunktzahlAngeben() == 7)
            {
                spieler.PunkteAendern(-7);
                spieler.WuerfelnVerbieten();
            }
            else
            {
                spieler.PunkteAendern(wuerfel1.PunktzahlAngeben() + wuerfel2.PunktzahlAngeben());
            }
        }
    }
}
