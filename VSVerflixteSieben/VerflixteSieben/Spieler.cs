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
        private Int32 punkte;
        private Int32 vermoegen;
        private Int32 wurfAnzahl;

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
            this.wurfAnzahl = 0;
        }

        /// <summary>
        /// Die bis dahin erreichte Punktesumme wird zurückgegeben.
        /// </summary>
        public Int32 punktestandAngeben()
        {
            return this.punkte;
        }


        /// <summary>
        /// (Hier fehlen die Kommentare. Das ist Ihre Aufgabe:.........) 
        /// </summary>
        public void topfLeeren()
        {
            this.vermoegen = this.vermoegen + this.topf.einsatzAbgeben();
            this.punkte = 0;
            this.wurfAnzahl = 0;
        }

        /// <summary>
        /// 
        /// </summary>
        public Int32 wurfAnzahlAngeben()
        {
            return this.wurfAnzahl;
        }

        /// <summary>
        /// 
        /// </summary>
        public void einsatzSetzen(Int32 einsatz)
        {
            if (this.vermoegen < einsatz)
            {
                einsatz = this.vermoegen;
            }
            this.topf.einsatzAufnehmen(einsatz);
            this.vermoegen = this.vermoegen - einsatz;
        }

        /// <summary>
        /// 
        /// </summary>
        public void wuerfeln()
        {
            wuerfel1.rollen();
            wuerfel2.rollen();
            this.punkte = this.punktestandAngeben() + wuerfel1.punktzahlAngeben() + wuerfel2.punktzahlAngeben();
            this.wurfAnzahl++;
        }

        /// <summary>
        /// 
        /// </summary>
        public void setName(String neuerName)
        {
            this.name = neuerName;
        }
    }
}
