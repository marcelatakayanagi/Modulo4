using Ficha10G1;
using System;

namespace Ficha11G1
{

    public class F11G1
    {
        #region Ex1
        //Solicitar um número. Apresentar “Passou” se o valor for superior a 9,44 ou “Chumbou” caso contrário
        public static void Ex1()
        {
            Console.WriteLine($"Introduza nota");
            var grade = double.Parse(Console.ReadLine());

            if (grade > 9.44)
            {
                Console.WriteLine($"Passou");
            }
            else
            {
                Console.WriteLine($"Chumbou");
            }
        }
        #endregion

        #region Ex2
        /*Solicitar a altura e o peso, apresentando o resultado do BMI, classificando-o da seguinte forma: > Abaixo do peso (até 18.5)
        > Normal (entre 18,5 e 24,9) > Acima do peso (entre 25 e 29,9) > Obeso (a partir de 30) */
        public static void Ex2()
        {
            var weight = 00.00;
            var height = 0.00;
            Console.WriteLine($"Introduza peso");
            weight = double.Parse(Console.ReadLine());
            Console.WriteLine($"Introduza altura");
            height = double.Parse(Console.ReadLine());

            var bmi = CalculateBmi(weight, height);

            if (bmi < 18.5)
            {
                Console.WriteLine($"Abaixo do peso");
            }
            else if (bmi >= 18.5 && bmi <= 24.9)
            {
                Console.WriteLine($"Normal");
            }
            else if (bmi >= 25 && bmi <= 29.9)
            {
                Console.WriteLine($"Acima do peso");
            }
            else
            {
                Console.WriteLine($"Obeso");
            }
        }
        public static double CalculateBmi(double weight, double height)
        {
            return weight / (height * height);
        }
        #endregion

        #region Ex3
        //Solicitar um número, validando se este é múltiplo de 3 e / ou 7 
        public static void Ex3()
        {
            var num = F10G1.ReadAndConvert();

            if (num % 3 == 0 && num % 7 == 0)
            {
                Console.WriteLine($"O número {num} é múltiplo de 3 e de 7");
            }
            else if (num % 3 == 0)
            {
                Console.WriteLine($"O número {num} é múltiplo de 3");
            }
            else if (num % 7 == 0)
            {
                Console.WriteLine($"O número {num} é múltiplo de 7");
            }
            else
            {
                Console.WriteLine($"O número {num} não é múltiplo de 3 nem de 7");
            }

        }
        #endregion

        #region Ex4
        //Solicitar um número e verificar se este se encontra entre 30 e 50, inclusive 
        public static void Ex4()
        {
            var num = F10G1.ReadAndConvert();

            if (num >= 30 && num <= 50)
            {
                Console.WriteLine($"O número {num} está entre 30 e 50");
            }
            else
            {
                Console.WriteLine($"O número {num} não está entre 30 e 50");
            }
        }
        #endregion

        #region Ex5
        // Solicitar um número e verificar se este se encontra entre 10 e 20, inclusive 
        public static void Ex5()
        {
            var num = F10G1.ReadAndConvert();

            if (num >= 10 && num <= 20)
            {
                Console.WriteLine($"O número {num} está entre 10 e 20");
            }
            else
            {
                Console.WriteLine($"O número {num} não está entre 10 e 20");
            }
        }
        #endregion

        #region Ex6
        /*Solicite o andar onde o elevador se deverá dirigir, sabendo que este poderá ir do -2 ao 6º andar. As portas do 3º e 5º andar 
        estão avariadas. Caso o elevador não possa ir para um determinado andar deverá apresentar a mensagem “Piso indisponível”.*/
        public static void Ex6()
        {
            Console.WriteLine($"Qual andar?");
            var floor = int.Parse(Console.ReadLine());

            if (floor < -2 || floor > 6 || floor == 3 || floor == 5)
            {
                Console.WriteLine($"Andar {floor} indisponível");
            }
            else
            {
                Console.WriteLine($"Andar {floor}");
            }

        }
        #endregion

        #region Ex7
        //Solicitar dez números e apresentar a sua soma (apresente uma resposta para cada estrutura de repetição).
        public static void Ex7For()
        {
            var total = 0.0;
            for (int i = 0; i < 10; i++)
            {
                var num = F10G1.ReadAndConvert();
                total = total + num;
            }
            Console.WriteLine($"A total da soma é {total}");
        }
        public static void Ex7DoWhile()
        {
            var total = 0.0;
            int i = 0;
            do
            {
                var num = F10G1.ReadAndConvert();
                total = total + num;
                i++;
            } while (i < 10);
            Console.WriteLine($"A total da soma é {total}");
        }
        public static void Ex7While()
        {
            var total = 0.0;
            int i = 0;
            while (i < 10)
            {
                var num = F10G1.ReadAndConvert();
                total = total + num;
                i++;
            }
            Console.WriteLine($"A total da soma é {total}");
        }
        #endregion

        #region Ex8
        /*Solicitar o nome, preço e quantidade produtos, e apresentar no final o valor total de cada produto e o valor total da compra. 
         * A aplicação deverá requisitar produtos até que o utilizador decida terminar o registo. */
        public static void Ex8()
        {
            var total = 0.0;
            var continuar = true;

            while (continuar)
            {
                total += F10G1.RequestProductPriceQuantity();

                var validKey = false;
                while (!validKey)
                {
                    Console.WriteLine("Tem mais produtos para registrar? (S/N)\n");
                    var key = Console.ReadKey().Key;

                    switch (key)
                    {
                        case ConsoleKey.S:
                            validKey = true;
                            break;
                        case ConsoleKey.N:
                            continuar = false;
                            validKey = true;
                            break;
                        default:
                            Console.WriteLine("Letra inválida. Tente novamente\n");
                            break;
                    }

                }
            }
            Console.WriteLine($"O valor total da compra é {total}");
        }
        #endregion

        #region Ex9
        //Solicitar números até que seja inserido 0, e apresentar a média 
        public static void Ex9()
        {
            var num = 0;
            var sum = 0;
            var count = 0;
            Console.WriteLine("Introduza um número");
            num = int.Parse(Console.ReadLine());
            sum = sum + num;

            while (num > 0)
            {
                Console.WriteLine("Introduza um número");
                num = int.Parse(Console.ReadLine());
                sum = sum + num;
                count++;
            }
            int media = sum / count;
            Console.WriteLine($"A média dos números é {media}");
        }


        #endregion

        #region Ex10
        // Solicitar dois números e uma operação. Apresentar o resultado da operação com base nos números inseridos 
        public static void Ex10()
        {
            var continua = true; /*Usado como interruptor que quando estiver ligado -operação não exisitente- o loop vai continuar a rodar, quando 
            for desligado apresenta a operação desejada*/

            Console.WriteLine("Introduza o primeiro número");
            var n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduza o segundo número");
            var n2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduza a operação que deseja realizar (soma(+), sub(-), mult(*), div(/), resto da div(%))");
            var op = Console.ReadLine();
            while (continua)
            {
                Console.WriteLine($"Operação inexistente. Introduza uma operação válida (soma(+), sub(-), mult(*), div(/), resto da div(%))");
                op = Console.ReadLine();

                switch (op)
                {
                    case "+":
                        Console.WriteLine($"{n1} + {n2} = {n1 + n2}");
                        continua = false;
                        break;
                    case "-":
                        Console.WriteLine($"{n1} - {n2} = {n1 - n2}");
                        continua = false;
                        break;
                    case "*":
                        Console.WriteLine($"{n1} * {n2} = {n1 * n2}");
                        continua = false;
                        break;
                    case "/":
                        Console.WriteLine($"{n1} / {n2} = {n1 / n2}");
                        continua = false;
                        break;
                    case "%":
                        Console.WriteLine($"{n1} % {n2} = {n1 % n2}");
                        continua = false;
                        break;
                    default:
                        Console.WriteLine($"Operação inexistente.");
                        break;
                }
            }
        }
        #endregion

        #region Ex11
        //Solicitar um caracter e apresentar uma tabela 3x3 
        public static void Ex11()
        {
            Console.WriteLine("Introduza um caracter");
            var caracter = char.Parse(Console.ReadLine());

            for (var i = 0; i < 3; i++)
            {
                for (var j = 0; j < 3; j++)
                {
                    Console.Write(caracter);
                }
                Console.Write("\n");
            }
           
        }
        #endregion

        #region Ex12
        //Solicitar um caracter e um número (n), e apresentar uma tabela nxn 
        public static void Ex12()
        {
            Console.WriteLine("Digite um caracter");
            var caracter = char.Parse(Console.ReadLine());
            Console.WriteLine("Digite um número");
            var num = int.Parse(Console.ReadLine());

            for (int i = 0; i < num; i++)
            {
                for ( int j = 0; j < num; j++)
                {
                    Console.Write(caracter);
                }
                Console.Write("\n");
            }
        }
        #endregion

        #region Ex13
        //Solicitar dois caracteres e dois números (m e n), e apresentar uma tabela mxn 
        public static void Ex13()
        {
            Console.WriteLine("Introduza um número");
            var m = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduza um número");
            var n = int.Parse(Console.ReadLine());

            for(int i=0; i < m; i++)
            {
                for (int j=0; j < n; j++)
                {
                    Console.Write(m);
                }
                Console.Write("\n");
            }
        }
        #endregion
    }
}
