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
        private Int32 einsatz;

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
        public Int32 einsatzAbgeben()
        {
            Int32 merkEinsatz = this.einsatz;
            this.einsatz = 0;
            return merkEinsatz;
        }

        /// <summary>
        /// nimmt den einsatz auf
        /// </summary>
        public void einsatzAufnehmen(int einsatz)
        {
            this.einsatz = this.einsatz + einsatz;
        }
    }
}
