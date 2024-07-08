namespace Payment
{
    internal class Program
    {
        static bool run = true;


        static void Main(string[] args)
        {
            Greeting();
            while (run)
            {
                ChangeCalculator.GetInput();
                Console.WriteLine(ChangeCalculator.PrintResult());
            }
            
        }

        /// <summary>
        /// Ausgabe einer Begrüßung
        /// </summary>
        private static void Greeting()
        {
            Console.WriteLine("Hallo");
            Console.WriteLine("Dieses Programm übernimmt einen ganzzahligen Eurobetrag");
            Console.WriteLine("und ermittelt die mindest benötigte Anzahl an Banknoten und Münzen!");
        }



    }
}
