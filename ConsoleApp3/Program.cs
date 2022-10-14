using System;
using System.Text;

namespace ejemplo29
{
    public class clase
    {
        public static void Main()
        {
            Console.WriteLine("Cual es su pago por hora");
            int pagoh = int.Parse(Console.ReadLine());

            Console.WriteLine("Cual es la cantidad de horas que trabaja al dia");
            int htrabajo = int.Parse(Console.ReadLine());

            Console.WriteLine("Cuantos dias trabaja a la semana");
            int hsem = int.Parse(Console.ReadLine());

            int pagodia = pagoh * htrabajo;

            int pagosem = pagodia * hsem;

            Console.WriteLine($"Su pago semanal es de {pagosem}");

        }
    }

}