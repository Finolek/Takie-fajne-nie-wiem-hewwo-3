using ConsoleApp4;
using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            RownanieKwadratowe rownanie = new RownanieKwadratowe(1, -3, 4);

            try
            {
                double[] rozwiazania = rownanie.ObliczRozwiazanie();
                Console.WriteLine("Rozwiązania: x1 = {0}, x2 = {1}", rozwiazania[0], rozwiazania[1]);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Błąd: {0}", ex.Message);
            }
        }
    }
}