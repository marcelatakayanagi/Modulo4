using System;

namespace Ficha10G3
{
    public class F10G3
    {
        #region Ex1
        public static void Ex1()
        {
            Console.WriteLine($"Quantas horas?");
            var hours = double.Parse(Console.ReadLine());
            Console.WriteLine($"Quantos minutos?");
            var min = double.Parse(Console.ReadLine());
            Console.WriteLine($"Quantos segundos?");
            var sec = double.Parse(Console.ReadLine());

            var total = hours * 3600 + min * 60 + sec;
            Console.WriteLine($"{hours}:{min}:{sec} é equivalente a {total} segundos");
        }
        #endregion

        #region Ex2
        public static void Ex2()
        {
            Console.WriteLine($"Qual raio?");
            var raio = double.Parse(Console.ReadLine());
            var perimeter = CalculatePerimeter(raio);
            var area = CalculateArea(raio);

            Console.WriteLine($"A área do círculo é {area} e o perímetro é {perimeter}");
        }
        public static double CalculatePerimeter(double raio)
        {
            return 2 * 3.14 * raio;
        }
        public static double CalculateArea(double raio)
        {
            return 3.14 * raio * raio;
            #endregion
        }
    }  
}
