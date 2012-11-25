using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VerflixteSieben
{
    public class Wuerfel
    {
        /// <summary>
        /// Attribut der Klasse Wuerfel:
        /// </summary>
        private Int32 punkte;

        /// <summary>
        /// Ein Zufallszahlengenerator für alle erzeugten Würfel.
        /// </summary>
        private static Random zufallszahlenGenerator = new Random();

        /// <summary>
        /// Konstruktor für Objekte der Klasse Wuerfel:
        /// </summary>
        public Wuerfel()
        {
            // initialisiert die Augenzahl mit 0 
            punkte = 0;
        }

        /// <summary>
        /// Diese Methode gibt die gewürfelte Augenzahl zurück.
        /// </summary>
        public Int32 punktzahlAngeben()
        {
            return this.punkte;
        }

        /// <summary>
        /// Diese Methode liefert einen Zufallswert zwischen 1 und maximum 
        /// </summary>
        private Int32 zufallsZahlAusgeben(Int32 maximum)
        {
            Int32 wert = 0;
            wert = zufallszahlenGenerator.Next(maximum) + 1;
            return wert;
        }

        /// <summary>
        /// lässt den Würfel rollen
        /// </summary>
        public void rollen()
        {
            this.punkte = zufallsZahlAusgeben(6);
        }
    }
}
