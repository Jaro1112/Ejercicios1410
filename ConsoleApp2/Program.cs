using System;
using System.Text;

namespace ejemplo25
{
    public class clase
    {
        public static void Main()
        {

            double a;
            double b;
            double c;

            Console.WriteLine("Digite el dato A");
            a = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite el dato B");
            b = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite el dato C");
            c = double.Parse(Console.ReadLine());


            double ar = b * c;

            double at = ((a - c) * b) / 2;

            double ato = at + ar;

            Console.WriteLine($"El resultado de la area total es {ato}");


        }
    }

}