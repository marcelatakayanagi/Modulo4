using System;

namespace Ficha13
{
	public class F13G1
	{
		#region Calculadora
		public static void Calculadora()
		{
			string resp = "S";

			while (resp == "S")
			{

				Console.Clear();
				Console.BackgroundColor = ConsoleColor.DarkGray;
				Console.ForegroundColor = ConsoleColor.Green;
				Console.WriteLine("     CALCULADORA CONSOLE     ");
				Console.ResetColor();

				Console.BackgroundColor = ConsoleColor.Gray;
				Console.ForegroundColor = ConsoleColor.Magenta;
				Console.WriteLine("   |+|  |-|  |*|  |/|  |.|   ");
				Console.ResetColor();

				Console.BackgroundColor = ConsoleColor.Gray;
				Console.ForegroundColor = ConsoleColor.Green;
				Console.WriteLine("       |7|   |8|   |9|       ");
				Console.ResetColor();

				Console.BackgroundColor = ConsoleColor.Gray;
				Console.ForegroundColor = ConsoleColor.Green;
				Console.WriteLine("       |4|   |5|   |6|       ");
				Console.ResetColor();

				Console.BackgroundColor = ConsoleColor.Gray;
				Console.ForegroundColor = ConsoleColor.Green;
				Console.WriteLine("       |1|   |2|   |3|       "); 
				Console.ResetColor();

				Console.BackgroundColor = ConsoleColor.Gray;
				Console.ForegroundColor = ConsoleColor.Green;
				Console.WriteLine("             |0|             ");
				Console.ResetColor();

				Console.BackgroundColor = ConsoleColor.Gray;
				Console.ForegroundColor = ConsoleColor.Magenta;
				Console.WriteLine("-----------------------------");
				Console.ResetColor();

				Console.WriteLine("Insira o primeiro número ou X para sair");
				var num1 = double.Parse(Console.ReadLine());
				Console.WriteLine("Insira a operação desejada");
				var op = Console.ReadLine();
				Console.WriteLine("Insira o segundo número");
				var num2 = double.Parse(Console.ReadLine());

				switch (op)
				{
					case "+":
						Console.WriteLine($"{num1} + {num2} = {num1 + num2}");
						break;
					case "somar":
						Console.WriteLine($"{num1} + {num2} = {num1 + num2}");
						break;
					case "-":
						Console.WriteLine($"{num1} - {num2} = {num1 - num2}");
						break;
					case "subtrair":
						Console.WriteLine($"{num1} - {num2} = {num1 - num2}");
						break;
					case "*":
						Console.WriteLine($"{num1} * {num2} = {num1 * num2}");
						break;
					case "multiplicar":
						Console.WriteLine($"{num1} * {num2} = {num1 * num2}");
						break;
					case "/":
						Console.WriteLine($"{num1} / {num2} = {num1 / num2}");
						break;
					case "dividir":
						Console.WriteLine($"{num1} / {num2} = {num1 / num2}");
						break;
					case "%":
						Console.WriteLine($"{num1} % {num2} = {num1 % num2}");
						break;
					case "resto da divisão":
						Console.WriteLine($"{num1} % {num2} = {num1 % num2}");
						break;
					default:
						Console.WriteLine("Operação inválida. Tente Denovo");
						break;
				}
				Console.WriteLine();
				Console.WriteLine("Deseja realizar outra consulta?(S/N): ");
				resp = Console.ReadLine().ToString().ToUpper();
			}
		}
		#endregion
	}
}







 
