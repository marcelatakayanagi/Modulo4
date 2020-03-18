using Ficha10G2;
using System;

namespace Ficha11G2
{
    public class F11G2
    {
        #region Ex1_1
        public static void Ex1_1()
        {
            Console.WriteLine("Indtruz temperatura");
            var temp = double.Parse(Console.ReadLine());
            var escala = " ";
            var tempC4K = F10G2.ConvertCForK(temp);
            var tempC4F = F10G2.ConvertCForF(temp);
            var tempK4C = ConvertKForC(temp);
            var tempK4F = ConvertKForF(temp);
            var tempF4C = ConvertFForC(temp);
            var tempF4K = ConvertFForK(temp);

            while (escala != "C" && escala != "K" && escala != "F")
            {
                Console.WriteLine("Em que escala?(C, K ou F)");
                escala = Console.ReadLine();
            }
            switch (escala)
            {
                case "C":
                    Console.WriteLine($"{temp}ºC é equivalente a {tempC4K}ºK e {tempC4F} ºF");
                    break;
                case "K":
                    Console.WriteLine($"{temp}ºK é equivalente a {tempK4C}ºC e {tempK4F}ºF");
                    break;
                case "F":
                    Console.WriteLine($"{temp}ºF é equivalente a {tempF4C}ºC e {tempF4K}ºK");
                    break;
                default:
                    Console.WriteLine("Escala inexistente");
                    break;
            }           
        }
        public static double ConvertKForC(double temp)
        {
           return temp - 273.15;
        }
        public static double ConvertKForF(double temp)
        {
            return temp * (9/5) - 459.67;
        }
        public static double ConvertFForC(double temp)
        {
            return (temp - 32) * 9/5;
        }
        public static double ConvertFForK(double temp)
        {
            return (temp + 459.67) * 5/9;
        }
        #endregion

        #region Ex1_2
        public static void Ex1_2()
        {
            Console.WriteLine("Qual o limite?");
            var num = int.Parse(Console.ReadLine());

            for(int cont = 0; cont <= num; cont++)
            {
                if(cont % 2 == 1)
                {
                    Console.WriteLine(cont);
                    cont++;
                }
            }
        }
        #endregion

        #region Ex1_3
        public static void Ex1_3()
        {
            var caracteres = "";
            var caracter = "";

            do
            {
                Console.WriteLine("Introduz um número, ou enter para terminar");
                caracter = Console.ReadLine();
                caracteres = caracter + caracteres;
            } while (caracter != "");
            Console.WriteLine(caracteres);
        }
        #endregion

    }
}
