// See https://akausing System;
using System.Text;

namespace ejemplo211
{
    public class clase
    {
        public static void Main()
        {

            double A, L, P;

            Console.WriteLine("Cual es la Altura");
            A = double.Parse(Console.ReadLine());

            Console.WriteLine("Cual es el Largo");
            L = double.Parse(Console.ReadLine());

            Console.WriteLine("Cual es el precio por metro cubico");
            P = double.Parse(Console.ReadLine());


            double Area = A * L;

            double Volumen = Math.Pow(Area, 3);

            Console.WriteLine($"El volumen es de {Volumen} metros cubicos");

            double Ptotal = Volumen * P;
            
            Console.WriteLine($"El precio es de {Ptotal}");
        }
    }

}