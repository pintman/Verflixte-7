using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VerflixteSieben
{
    public class Spieler
    {
        /*
         * Eine Person kennt zwei Würfel und den Topf:
         */
        private Wuerfel wuerfel1;
        private Wuerfel wuerfel2;
        private Topf topf;

        /* 
         * Hier folgen die Attribute der Klasse Person:
         */
        private String name;
        private int punkte;
        private int vermoegen;
        private int wurfAnzahl;
        private Boolean darfWuerfeln;

        /// <summary>
        /// Konstruktor für Objekte der Klasse Spieler
        /// Mit der folgenden Methode wird ein Objekt der Klasse Spieler hergestellt.
        /// </summary>
        public Spieler(Wuerfel pWuerfel1, Wuerfel pWuerfel2, Topf pTopf)
        {
            this.wuerfel1 = pWuerfel1;
            this.wuerfel2 = pWuerfel2;
            this.topf = pTopf;
            this.vermoegen = 1000;
            this.darfWuerfeln = true;
        }

        /// <summary>
        /// Die bis dahin erreichte Punktesumme wird zurückgegeben.
        /// </summary>
        public int PunktestandAngeben()
        {
            return this.punkte;
        }
        public void PunkteAendern(int punktzahl)
        {
            this.punkte = this.PunktestandAngeben() + punktzahl;
        }


        /// <summary>
        /// (Hier fehlen die Kommentare. Das ist Ihre Aufgabe:.........) 
        /// </summary>
        public void TopfLeeren()
        {
            this.vermoegen = this.vermoegen + this.topf.EinsatzAbgeben();
            this.punkte = 0;
            this.wurfAnzahl = 0;
            this.darfWuerfeln = true;
        }

        /// <summary>
        /// 
        /// </summary>
        public int WurfAnzahlAngeben()
        {
            return this.wurfAnzahl;
        }

        /// <summary>
        /// 
        /// </summary>
        public void EinsatzSetzen(int einsatz)
        {
            if (this.vermoegen < einsatz)
            {
                einsatz = this.vermoegen;
            }
            this.topf.EinsatzAufnehmen(einsatz);
            this.vermoegen = this.vermoegen - einsatz;
        }

        /// <summary>
        /// 
        /// </summary>
        public void Wuerfeln()
        {
            wuerfel1.Rollen();
            wuerfel2.Rollen();
            this.wurfAnzahl++;
        }

        /// <summary>
        /// 
        /// </summary>
        public void NameGeben(String neuerName)
        {
            this.name = neuerName;
        }

        public bool DarfWuerfeln()
        {
            return this.darfWuerfeln;
        }
        public void WuerfelnVerbieten()
        {
            this.darfWuerfeln = false;
        }
    }
}
