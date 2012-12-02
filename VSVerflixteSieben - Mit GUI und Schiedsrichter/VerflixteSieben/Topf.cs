using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VerflixteSieben
{
    public class Topf
    {
        /// <summary>
        ///Attribut der Klasse Topf:
        /// </summary>
        private int einsatz;

        /// <summary>
        /// Konstruktor für Objekte der Klasse Topf:
        /// </summary>
        public Topf()
        {
            // der Einsatz wird auf 0 gesetzt
            this.einsatz = 0;
        }

        /// <summary>
        /// Gibt die Summe, die im Topf liegt, zurück und leert den Topf.
        /// </summary>
        public int EinsatzAbgeben()
        {
            int merkEinsatz = this.einsatz;
            this.einsatz = 0;
            return merkEinsatz;
        }

        public int EinsatzAbfragen()
        {
            return this.einsatz;
        }

        /// <summary>
        /// nimmt den einsatz auf
        /// </summary>
        public void EinsatzAufnehmen(int einsatz)
        {
            this.einsatz = this.einsatz + einsatz;
        }
    }
}
