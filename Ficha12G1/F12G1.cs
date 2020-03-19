using Ficha10G1;
using System;

namespace Ficha12G1
{
    public class F12G1
    {
        #region Ex1
        //Solicitar três números e apresentar o seu produto.
        public static void Ex1()
        {
            var total = 1.0;
            for (int count = 0; count < 3; count++)
            {
                Console.WriteLine("Digite um número");
                var num = double.Parse(Console.ReadLine());
                total *= num;
            }
            Console.WriteLine($"O produto é igual a {total}");
        }

        #endregion

        #region Ex2
        //Solicitar dois números e apresentar os valores de cada operação aritmética 
        public static void Ex2()
        {
            var n1 = F10G1.ReadAndConvert();
            var n2 = F10G1.ReadAndConvert();

            Console.WriteLine($"{n1} + {n2} = {n1 + n2}");
            Console.WriteLine($"{n1} - {n2} = {n1 - n2}");
            Console.WriteLine($"{n1} * {n2} = {n1 * n2}");
            Console.WriteLine($"{n1} / {n2} = {n1 / n2}");
            Console.WriteLine($"{n1} % {n2} = {n1 % n2}");
        }
        #endregion

        #region Ex3
        //Solicitar três números e apresentar o resultado de  (x+y).z and x.y + y.z
        public static void Ex3()
        {
            var n1 = F10G1.ReadAndConvert(); //x
            var n2 = F10G1.ReadAndConvert(); //y
            var n3 = F10G1.ReadAndConvert();//z
            var res1 = CalculateEquation1(n1, n2, n3);
            var res2 = CalculateEquation2(n1, n2, n3);

            Console.WriteLine($"O resultado é {res1} e {res2}");
        }
        public static double CalculateEquation1(double n1, double n2, double n3)
        {
            return (n1 + n2) * n3;
        }
        public static double CalculateEquation2(double n1, double n2, double n3)
        {
            return n1 * n2 + n2 * n3;
        }

        #endregion

        #region Ex4
        //Solicitar um número e apresentar todos os números primos até ao indicado. 
        public static void Ex4()
        {
            Console.WriteLine("Introduz um número");
            var num = int.Parse(Console.ReadLine());

            var cont = 2;

            while (cont < num)
            {
                var isPrime = true;
                var contb = 2;

                while (contb < cont)
                {
                    if (cont % contb == 0)
                    {
                        isPrime = false;
                    }
                    contb++;
                }
                if (isPrime)
                {
                    Console.WriteLine(cont);
                }
                cont++;
            }
        }
        #endregion

        #region Ex5
        /*Apresentar a expressão “Hello?”, e caso o utilizador escreva 
        “Is it me you’re looking for?”, deverá apresentar “I can see it in your eyes”*/
        public static void Ex5()
        {
            Console.WriteLine("Hello?");
            var text = Console.ReadLine();

            if (text == "Is it me you´re looking for")
            {
                Console.WriteLine("I can see it in your eyes");
            }
        }
        #endregion

        #region Ex6
        //Solicitar uma quantidade de itens e distribuí-los entre duas pessoas através das 
        //expressões “Um pra mim” e “Um pra ti”. 
        public static void Ex6()
        {
            Console.WriteLine("Quantos itens?");
            var itens = int.Parse(Console.ReadLine());

            while (itens > 0)
            {
                if (itens % 2 == 0)
                {
                    Console.WriteLine("um pra ti");
                }
                else
                {
                    Console.WriteLine("Um pra mim");
                }
                itens--;
            }
        }
        #endregion

        #region Ex7
        //Solicitar um ano e determinar se é bissexto. 
        public static void Ex7()
        {
            Console.WriteLine("Ano");
            var year = int.Parse(Console.ReadLine());

            if (year % 4 == 0)
            {
                if (year % 100 != 0 || year % 400 == 0)
                {
                    Console.WriteLine($"O ano {year} é bissexto");
                }
                else
                {
                    Console.WriteLine($"O ano {year} não é bissexto");
                }
            }

        }
        #endregion

        #region Ex8
        //Apresentar a letra para a música “99 beers on the wall”.
        public static void Ex8()
        {
            var beerCont = 99;

            while (beerCont > 0)
            {
                Console.WriteLine($"{beerCont} bottles of beer on the wall");
                beerCont--;
                if (beerCont != 0)
                {
                    Console.WriteLine($"Take one down and pass it around, {beerCont} bottles of beer on the wall.");
                }
                else
                {
                    Console.WriteLine($"No more bottles of beer on the wall, no more bottles of beer.");
                }
                Console.WriteLine("");
            }
        }
        #endregion

        #region Ex9
        //Verificar se um triângulo é isóscele, escaleno ou equilátero.
        public static void Ex9()
        {
            Console.WriteLine("Introduza o primeiro lado");
            var ladoA = double.Parse(Console.ReadLine());
            Console.WriteLine("Introduza o segundo lado");
            var ladoB = double.Parse(Console.ReadLine());
            Console.WriteLine("Introduza o terceiro lado");
            var ladoC = double.Parse(Console.ReadLine());

            if (ladoA == ladoB && ladoA == ladoC && ladoB == ladoC)
            {
                Console.WriteLine("O triângulo é Equilátero");
            }
            else if (ladoA != ladoB && ladoA != ladoB && ladoB != ladoC)
            {
                Console.WriteLine("O triângulo é Escaleno");
            }
            else
            {
                Console.WriteLine("O triângulo é Isóceles");
            }
        }
        #endregion

        #region Ex10
        //Verificar com base em dois valores (valor inicial e valor total) se uma operação deu 
        //lucro ou prejuízo.
        public static void Ex10()
        {
            Console.WriteLine("Introduza o valor Inicial");
            var valInicial = double.Parse(Console.ReadLine());
            Console.WriteLine("Introduza o valor Final");
            var valFinal = double.Parse(Console.ReadLine());
            var profit = valFinal - valFinal;

            if (profit > 0)
            {
                Console.WriteLine("Lucro");
            }else if(profit == 0)
            {
                Console.WriteLine("Neutro");
            }
            else
            {
                Console.WriteLine("Prejuízo");
            }
        }

        #endregion

        #region Ex11
        //Retornar o nome do mês e o seu número de dias com base num valor numérico (1-12) 
        public static void Ex11()
        {
            Console.WriteLine("Qual mês?");
            var month = int.Parse(Console.ReadLine());

            while(month < 1 || month > 12)
            {
                Console.WriteLine("Qual mês?");
                month = int.Parse(Console.ReadLine());
            }

            var days = "";
            if (month == 2)
            {
                days = "28 ou 29";
            }else if (month % 2 == 0 && month < 8 || month > 7 && month % 2 == 1)
            {
                days = "30";
            }
            else
            {
                days = "31";
            }
            var extenso = string.Empty;
            switch (month)
            {
                case 1: extenso = "Janeiro"; break;
                case 2: extenso = "Fevereiro"; break;
                case 3: extenso = "Março"; break;
                case 4: extenso = "Abril"; break;
                case 5: extenso = "Maio"; break;
                case 6: extenso = "Junho"; break;
                case 7: extenso = "Julho"; break;
                case 8: extenso = "Agosto"; break;
                case 9: extenso = "Setembro"; break;
                case 10: extenso = "Outubro"; break;
                case 11: extenso = "Novembro"; break;
                case 12: extenso = "Dezembro"; break;
            }
            Console.WriteLine($"{extenso} - {days} dias");
        }

        #endregion

        #region Ex12
        // Produz uma árvore de taNal (árvore de Natal invertida) 
        public static void Ex12()
        {
            Console.WriteLine("Qual a dimensão do triângulo?");
            var num = int.Parse(Console.ReadLine());
            var stars = num * 2 - 1;
            var counter = 0;
            while (counter < num)
            {
                var spaces = 0;
                while (spaces != counter)
                {
                    Console.Write(" ");
                    spaces++;
                }

                var starCounter = 0;
                while (stars != starCounter)
                {
                    Console.Write("*");
                    starCounter++;
                }
                stars -= 2;
                Console.WriteLine("");
                counter++;
            }
        }
        #endregion

        #region Ex13
        /* Apresentar a fatura da água de uma pessoa, através da quantidade de unidades de 
        água consumidas e a região onde a pessoa de acordo com a seguinte tabela. a. Região A – 2€ por unidade 
        Região B – 1.20€ por unidade. Região C – 1€ por unidade. Região D – 0.75€ por unidade */
        public static void Ex13()
        {
            Console.WriteLine("Qual a quantidade de água consumida?");
            var consumption = double.Parse(Console.ReadLine());
            Console.WriteLine("Qual a região");
            var region = Console.ReadKey().Key;
            var total = 0.0;

            switch (region)
            {
                case ConsoleKey.A:
                    total = consumption * 2.0;
                    break;
                case ConsoleKey.B:
                    total = consumption * 1.2;
                    break;
                case ConsoleKey.C:
                    total = consumption * 1.0;
                    break;
                case ConsoleKey.D:
                    total = consumption * 0.75;
                    break;
            }
            Console.WriteLine($"\n O valor a ser pago é:{total}");

        }
        #endregion

        #region Ex14
        // Apresentar os primeiros n números de Fibonacci (sem recursividade) 
        public static void Ex14()
        {
            Console.WriteLine("Quantos números?");
            var n = int.Parse(Console.ReadLine());
            for (var i = 1; i <= n; i++)
            {
                Console.Write(Fibonacci(i) + " ");
            }
        }
        private static int Fibonacci(int count)
        {
            if (count <= 1)
            {
                return 1;
            }
            var current = 1;
            var previous = 1;
            for (var i = 2; i < count; ++i)
            {
                int temp = current;
                current += previous;
                previous = temp;
            }
            return current;
        }
        #endregion

        #region Ex15
        //Solicitar um número n, e caso este faça parte da série de Fibonacci, apresentar “n é Fibonice!” 
        public static void Ex15()
        {
            Console.WriteLine("Qual o número?");
            var num = int.Parse(Console.ReadLine());
            var currFib = 0;
            var fibCounter = 0;
            while (currFib < num)
            {
                currFib = Fibonacci(fibCounter);
                fibCounter++;
                if (num == currFib) Console.WriteLine($"{num} é Fibonice!");
                else if (num < currFib) Console.WriteLine($"{num} não é Fibonice!");
            }

        }
        #endregion

        #region Ex16
        public static void Ex16()
        {
            Console.WriteLine("Pense em um número entre 1 a 100");
            int min = 1;
            int max = 100;
            bool numeroCerto = false;

            while (!numeroCerto)
            {
                Console.WriteLine();
                var avg = (int)Math.Floor((double)(min + max) / 2);
                var intconf = max - min;
                var keyOk = false;
                if (intconf == 1)
                {
                    for (int i = min; i < max; i++)
                    {
                        Console.WriteLine($"É{i}?");
                        var key = Console.ReadKey().Key;
                        if (key == ConsoleKey.Y || key == ConsoleKey.S)
                        {
                            numeroCerto = true;
                            break;
                        }
                        Console.WriteLine();
                    }
                }
                if (!numeroCerto)
                {
                    while (!keyOk)
                    {
                        Console.WriteLine($" O número é inferior a {avg}?");
                        switch (Console.ReadKey().Key)
                        {
                            case ConsoleKey.Y:
                            case ConsoleKey.S:
                                keyOk = true;
                                max = avg - 1;
                                break;
                            case ConsoleKey.N:
                                keyOk = true;
                                min = avg;
                                break;
                            default:
                                break;
                        }
                    }
                }
            }
        }
        #endregion
    }
}
