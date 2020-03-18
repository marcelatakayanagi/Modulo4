using System;

namespace Ficha10G1
{
    public class F10G1
    {
        #region G1Ex1
        //Solicitar um [nome] e apresentar a mensagem “Olá [nome]” 
        public static void G1Ex1()
        {
            Console.WriteLine("Digite seu nome");
            var name = Console.ReadLine();

            Console.WriteLine($"Olá {name}");
        }
        #endregion

        #region G1Ex2
        //Solicitar os números [a] e [b] e apresentar a sua soma 
        public static void G1Ex2()
        {
            Console.WriteLine("Digite o 1º número");
            var n1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o 2º número");
            var n2 = double.Parse(Console.ReadLine());
            var sum = SumN1N2(n1, n2);

            Console.WriteLine(sum);
        }
        private static double SumN1N2(double n1, double n2)
        {
            return n1 + n2;
        }
        #endregion

        #region G1Ex3
        //Solicitar dez números, [a], [b], [c], [d], [e], [f], [g], [h], [i], [j] e apresentar a sua soma 
        public static void G1Ex3()
        {
            var sum = ReadAndConvert();
            sum += ReadAndConvert();
            sum += ReadAndConvert();
            sum += ReadAndConvert();
            sum += ReadAndConvert();
            sum += ReadAndConvert();
            sum += ReadAndConvert();
            sum += ReadAndConvert();
            sum += ReadAndConvert();
            sum += ReadAndConvert();

            Console.WriteLine(sum);
        }
        public static double ReadAndConvert()
        {
            Console.WriteLine("Introduza um número");
            return double.Parse(Console.ReadLine());
        }
        #endregion

        #region G1Ex4
        //Solicitar dois números, [a] e [b], trocar as suas posições e apresentar os seus valores. 
        public static void G1Ex4()
        {
            var a = ReadAndConvert();
            var b = ReadAndConvert();

            var c = a;
            a = b;
            b = c;

            Console.WriteLine($"O valor do primeiro valor é: {a} e o segundo valor é {b}");
        }
        #endregion

        #region G1Ex5a
        //Apresentar uma solução genérica para: a. [-1] + [4] x [6] 
        public static void G1Ex5a()
        {
            var n1 = ReadAndConvert();
            var n2 = ReadAndConvert();
            var n3 = ReadAndConvert();

            var res = CalculateSolution5A(n1, n2, n3);
            Console.WriteLine(res);
        }
        private static double CalculateSolution5A(double n1, double n2, double n3)
        {
            return n1 + n2 * n3;
        }
        #endregion

        #region G1Ex5b
        //b. -[1] + [4] x [6] 
        public static void G1Ex5b()
        {
            var n1 = ReadAndConvert();
            var n2 = ReadAndConvert();
            var n3 = ReadAndConvert();

            var res = CalculateSolution5B(n1, n2, n3);
            Console.WriteLine(res);
        }
        private static double CalculateSolution5B(double n1, double n2, double n3)
        {
            return -(n1) + n2 * n3;
        }
        #endregion

        #region G1Ex5c
        //([35] + [5]) % [7] 
        public static void G1Ex5c()
        {
            var n1 = ReadAndConvert();
            var n2 = ReadAndConvert();
            var n3 = ReadAndConvert();

            var res = CalcutateSolution5C(n1, n2, n3);
            Console.WriteLine(res);
        }
        private static double CalcutateSolution5C(double n1, double n2, double n3)
        {
            return (n1 + n2) % n3;
        }
        #endregion

        #region G1Ex5d
        //[14] + [-4] x [6] / [11] 
        public static void G1Ex5d()
        {
            var n1 = ReadAndConvert();
            var n2 = ReadAndConvert();
            var n3 = ReadAndConvert();
            var n4 = ReadAndConvert();

            var res = CalculateSolution5D(n1, n2, n3, n4);
            Console.WriteLine(res);
        }
        private static double CalculateSolution5D(double n1, double n2, double n3, double n4)
        {
            return n1 + n2 * n3 / n4;
        }
        #endregion

        #region G1Ex5e
        //[2] + [15] / [6] * [1] - [7] % [2] 
        public static void G1Ex5e()
        {
            var n1 = ReadAndConvert();
            var n2 = ReadAndConvert();
            var n3 = ReadAndConvert();
            var n4 = ReadAndConvert();
            var n5 = ReadAndConvert();
            var n6 = ReadAndConvert();

            var res = CalculateSolution5E(n1, n2, n3, n4, n5, n6);
            Console.WriteLine(res);
        }
        private static double CalculateSolution5E(double n1, double n2, double n3, double n4, double n5, double n6)
        {
            return n1 + n2 / n3 * n4 - n5 % n6;
        }
        #endregion

        #region G1Ex6
        //Solicitar um número [a] e apresentar a tabuada até ao 10 
        public static void G1Ex6()
        {
            var num = ReadAndConvert();
            CalcularTabuada(num);
        }
        private static void CalcularTabuada(double num)
        {
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(num * i);
            }
        }
        #endregion

        #region G1Ex7
        //Solicitar dois números [a] e [b] e apresentar a sua média 
        public static void G1Ex7()
        {
            var n1 = ReadAndConvert();
            Console.WriteLine("Introduza o segundo número");
            var n2 = ReadAndConvert();
            var res = CalculateAvaregeBetweenTwoNumbers(n1, n2);
            Console.WriteLine(res);
        }
        private static double CalculateAvaregeBetweenTwoNumbers(double n1, double n2)
        {
            return (n1 + n2) / 2;
        }
        #endregion

        #region G1Ex8
        //Solicitar cinco números [a], [b], [c], [d], [e] e apresentar a sua média 
        public static void G1Ex8()
        {
            var n1 = ReadAndConvert();
            var n2 = ReadAndConvert();
            var n3 = ReadAndConvert();
            var n4 = ReadAndConvert();
            var n5 = ReadAndConvert();
            var res = CalculateAvaregeBetweenFiveNumbers(n1, n2, n3, n4, n5);
            Console.WriteLine(res);
        }
        private static double CalculateAvaregeBetweenFiveNumbers(double n1, double n2, double n3, double n4, double n5)
        {
            return (n1 + n2 + n3 + n4 + n5) / 5;
        }
        #endregion

        #region G1Ex9
        //Solicitar dez números, [a], [b], [c], [d], [e], [f], [g], [h], [i], [j] e apresentar a sua média 
        public static void G1Ex9()
        {
            var n1 = ReadAndConvert();
            var n2 = ReadAndConvert();
            var n3 = ReadAndConvert();
            var n4 = ReadAndConvert();
            var n5 = ReadAndConvert();
            var n6 = ReadAndConvert();
            var n7 = ReadAndConvert();
            var n8 = ReadAndConvert();
            var n9 = ReadAndConvert();
            var n10 = ReadAndConvert();

            var res = CalculateAvaregeBetweenTenNumbers(n1, n2, n3, n4, n5, n6, n7, n8, n9, n10);
            Console.WriteLine(res);
        }
        private static double CalculateAvaregeBetweenTenNumbers(double n1, double n2, double n3, double n4, double n5, double n6, double n7, double n8, double n9, double n10)
        {
            return (n1 + n2 + n3 + n4 + n5 + n6 + n7 + n8 + n9 + n10) / 10;
        }
        #endregion

        #region G1Ex10
        // Solicitar um caracter [a] e apresentar uma tabela 3x3 onde cada espaço é preenchido pelo caracter. 
        public static void G1Ex10()
        {
            Console.WriteLine("Introduza o caracter");
            var caracter = Console.ReadLine();

            Console.WriteLine(caracter + caracter + caracter);
            Console.WriteLine(caracter + caracter + caracter);
            Console.WriteLine(caracter + caracter + caracter);

        }
        #endregion

        #region G1Ex11
        // Solicitar o nome, o preço e a quantidade de 5 produtos, apresentado no final o preço total de cada produto e o valor total da compra. 
        public static void G1Ex11()
        {
            var p1 = RequestProductPriceQuantity();
            var p2 = RequestProductPriceQuantity();
            var p3 = RequestProductPriceQuantity();
            var p4 = RequestProductPriceQuantity();
            var p5 = RequestProductPriceQuantity();

            var total = p1 + p2 + p3 + p4 + p5;
            Console.WriteLine($"O valor total é {total} ");
        }
        public static double RequestProductPriceQuantity()
        {
            Console.WriteLine("Nome do produto");
            var product = Console.ReadLine();
            Console.WriteLine("Preço do Produto");
            var price = double.Parse(Console.ReadLine());
            Console.WriteLine("Quantidade do Produto");
            var quantity = double.Parse(Console.ReadLine());

            var subtotal = price * quantity;
            Console.WriteLine($"O produto {product} tem o valor de {subtotal} euros\n");
            return subtotal;
        }
        #endregion
    }
}
