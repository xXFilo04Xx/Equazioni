using System;
using EquazioniLibrary;

namespace ProvaEquazioni
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = 5;
            double b = 6;
            double c = -17;
            Console.WriteLine(Equazioni.EquationDegree2(a,b,c));
        }
    }
}
