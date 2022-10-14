using System;
using System.Text;

namespace ejemplo210
{
    public class clase
    {
        public static void Main()
        {

            Console.WriteLine("Cuantos metros desea ordenar");
            double metros = int.Parse(Console.ReadLine());

            double metrosxpul = 0.0254;

            double pulg = metros / metrosxpul;

            Console.WriteLine($"Debe comprar un total de {pulg} pulgadas");
        }
    }

}

