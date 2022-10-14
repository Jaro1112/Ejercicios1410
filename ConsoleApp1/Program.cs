using System;
using System.Text;

namespace ejemplo27
{
    public class clase
    {
        public static void Main()
        {

            double lpg = 3.785;
            double lv, cg, pg, vv;


            Console.WriteLine("Cantidad de litros");
            lv = double.Parse(Console.ReadLine());

            Console.WriteLine("Cual es el precio por galon");
            pg = double.Parse(Console.ReadLine());

            cg = lv / lpg;
            vv = cg * pg;

            Console.WriteLine($"El valor de la venta es {vv}");
            Console.WriteLine($"El total de galones vendidos es de {cg}");


        }
    }

}