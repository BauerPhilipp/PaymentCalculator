using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Payment
{
    internal static class ChangeCalculator
    {
        /// <summary>
        /// Der zu wechselnde Betrag
        /// </summary>
        public static int ChangeValue { get; private set; } = -1;

        /// <summary>
        /// Minimale Anzahl an Banknoten/Münzen
        /// </summary>
        public static int TotalCount { get; private set; }

        /// <summary>
        /// Ausgabe der Stückelung des zuvor festgelegten Betrages.
        /// </summary>
        /// <returns></returns>
        public static string PrintResult()
        {
            TotalCount = 0;

            StringBuilder sb = new StringBuilder();
            sb.Append($"Übergabegetrag: {ChangeValue} Euro\n");
            sb.Append("Wird gewechselt in:\n");
            sb.Append($"{CalculateCountOf(500)} x 500 Euro\n");
            sb.Append($"{CalculateCountOf(200)} x 200 Euro\n");
            sb.Append($"{CalculateCountOf(100)} x 100 Euro\n");
            sb.Append($"{CalculateCountOf(50)} x 50 Euro\n");
            sb.Append($"{CalculateCountOf(20)} x 20 Euro\n");
            sb.Append($"{CalculateCountOf(10)} x 10 Euro\n");
            sb.Append($"{CalculateCountOf(5)} x 5 Euro\n");
            sb.Append($"{CalculateCountOf(2)} x 2 Euro\n");
            sb.Append($"{CalculateCountOf(1)} x 1 Euro\n");
            sb.Append($"Gesamtanzahl an Banknote und Münzen: {TotalCount} Stk.!");        


            sb.Append("");


            return sb.ToString();
        }

        /// <summary>
        /// Gibt zurück wie oft der übergebene Wert in den festgelegten Betrag (ChangeValue) passt
        /// </summary>
        /// <param name="value">Der zu prüfende Wert (Banknote/Münze)</param>
        /// <returns></returns>
        private static int CalculateCountOf(int value)
        {
            if(ChangeValue == 0)
                return 0;
            int count = ChangeValue / value;
            TotalCount += count;
            ChangeValue -= count * value;
            return count;
        }

        /// <summary>
        /// Abfrage eines Betrages für die anschließende Stückelung 
        /// </summary>
        public static void GetInput()
        {
            int value;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Bitte einen ganzzahligen Betrag eingeben:");
            while (!(int.TryParse(Console.ReadLine(), out value)) || value < 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Ungültige Eingabe! Beispiel für eine korrekte Eingabe: 21");
                Console.ForegroundColor = ConsoleColor.White;
            }
            ChangeValue = value;
        }
    }
}
