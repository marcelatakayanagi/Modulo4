using System;

namespace Ficha14G1
{
    public class F14G1
    {
        #region Ex1
        //Apresentar os n primeiros números naturais. 
        public static void Ex1()
        {
            Console.WriteLine("Insira um número");
            var num = int.Parse(Console.ReadLine());

            for (var i = 0; i < num; i++)
            {
                Console.WriteLine(i);
            }
        }
        #endregion

        #region Ex2
        //Apresentar os n primeiros números naturais por ordem descendente. 
        public static void Ex2()
        {
            Console.WriteLine("Insira um número");
            var num = int.Parse(Console.ReadLine());

            for (var i = 0; i < num; i++)
            {         
                        Console.WriteLine(num -i);               
            }
        }
        #endregion

        #region Ex3
        //Apresentar a soma dos n primeiros números naturais. 
        public static void Ex3()
        {
            Console.WriteLine("Insira um número");
            var num = int.Parse(Console.ReadLine());
            var soma = 0;

            for (int i = 1; i <= num; i++)
            {
                soma += i;
            }
            Console.WriteLine($"A soma dos números é {soma}");
        }
        #endregion

        #region Ex4
        //Apresentar os números pares entre dois números 
        public static void Ex4()
        {
            Console.WriteLine("Insira um número");
            var n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Insira outro número");
            var n2 = int.Parse(Console.ReadLine());

            for (int i = n1; i <= n2; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
            }



        }
        #endregion

        #region Ex5
        //Apresentar os n primeiros números da série de Fibonacci  
        public static void Ex5()
        {
            Console.WriteLine("Insira um número");
            var num = int.Parse(Console.ReadLine());
            int n = 0;
            for (int i = 0; n < num; i++)
            {
                n = fib(i);
                Console.WriteLine(n);
            }
        }
        public static int fib(int n)
        {
            if (n == 0)
            {
                return 0;
            }
            else if (n <= 2)
            {
                return 1;
            }
            else
            {
                return fib(n - 1) + fib(n - 2);
            }
        }
        #endregion

        #region Ex6
        public static void Ex6()
        {
            Console.WriteLine("Insira um número");
            var n = int.Parse(Console.ReadLine());
            var fat = 0;

            for (fat = 1; n > 1; n = n - 1)
            {
                fat = fat * n;
            }
            Console.WriteLine(fat);
        }
        #endregion


    }
}