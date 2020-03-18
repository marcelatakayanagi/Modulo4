using System;

namespace Ficha11G3
{
    public class F11G3
    {
        #region Ex1
        public static void Ex1()
        {
            Console.WriteLine("Indroduz número");
            var n = int.Parse(Console.ReadLine());

            if(n % 2 == 0)
            {
                Console.WriteLine(n * 3);
            }
            else
            {
                Console.WriteLine(n * 2);
            }
        }
        #endregion

        #region Ex2
        public static void Ex2()
        {
            Console.WriteLine("Qual a dimensão do triângulo");
            var n = int.Parse(Console.ReadLine());
            var i = 1;

            while (n > 0)
            {
                var a = 0;
                n--;
                while (a != n)
                {
                    Console.Write(" ");
                    a++;
                }
                var b = 0;
                while (i != b)
                {
                    Console.Write("*");
                    b++;
                }
                i += 2;
                Console.Write("\n");
            }
        }
        #endregion
    }
}
