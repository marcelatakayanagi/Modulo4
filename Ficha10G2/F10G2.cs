using System;

namespace Ficha10G2
{
    public class F10G2
    {
        #region Ex1
        // Escrever “Diz-me algo que eu não saiba” c. Ler x d. Escrever “Eu já sabia que “ x 
        public static void Ex1()
        {
            Console.WriteLine("Diz-me algo que eu não saiba");
            var text = Console.ReadLine();
            Console.WriteLine($"Eu já sabia que {text}");
        }
        #endregion

        #region Ex2
        //b. Escrever “Introduz dois números” c. Ler fstNum d. Ler sndNum e. Escrever “O primeiro número é “ fstNum “e o 
        //segundo número é “ sndNum
        public static void Ex2()
        {
            var fstNum = Ficha10G1.F10G1.ReadAndConvert();
            var sndNum = Ficha10G1.F10G1.ReadAndConvert();

            Console.WriteLine($"O primeiro número é {fstNum} e o segundo número é {sndNum}");
        }
        #endregion

        #region Ex3
         /* Escrever “Introduz a temperatura” c. Ler temp d. tempF = temp * 9 / 5 + 32 e.
         * tempK = temp + 273.15 f. Escrever “A temperatura “ temp “ºC é “ tempF “ºF e “ tempK “ºK” */
        public static void Ex3()
        {
            Console.WriteLine($"Introduza a temperatura");
            var temp = double.Parse(Console.ReadLine());

            var tempF = ConvertCForF(temp);
            var tempK = ConvertCForK(temp);

            Console.WriteLine($"A temperatura {temp} ºC é {tempF} ºF e {tempK} ºK");
        }
        public static double ConvertCForF(double temp)
        {
            var tempF = temp * (9 / 5) + 32;
            return tempF;
        }
        public static double ConvertCForK(double temp)
        {
            var tempK = temp + 273.15;
            return tempK;
        }
        #endregion
    }
}
