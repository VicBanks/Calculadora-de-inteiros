using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declarar variaveis e inicialize com zero.
            int num1 = 0; int num2 = 0;

            // Abrir Display C# console calculatora app.
            Console.WriteLine("Console Calculatora em C#\r");
            Console.WriteLine("------------------------\n");

            // Pedir ao usuario para digitar um numero.
            Console.WriteLine("Digite um numero, e aperte Enter");
            num1 = Convert.ToInt32(Console.ReadLine());

            // Pedir ao usuario pra digitar outro numero.
            Console.WriteLine("Digite outro numero, e aperte Enter");
            num2 = Convert.ToInt32(Console.ReadLine());

            // Escolha uma op.
            Console.WriteLine("Choose an option from the following list:");
            Console.WriteLine("\ta - Add");
            Console.WriteLine("\ts - Subtract");
            Console.WriteLine("\tm - Multiply");
            Console.WriteLine("\td - Divide");
            Console.Write("Sua Opção? ");

            //Use uma instrucao para fazer a operacao
            switch (Console.ReadLine())
            {
                case "a":
                    Console.WriteLine($"Your result: {num1} + {num2} = " + (num1 + num2));
                    break;
                case "s":
                    Console.WriteLine($"Your result: {num1} - {num2} = " + (num1 - num2));
                    break;
                case "m":
                    Console.WriteLine($"Your result: {num1} * {num2} = " + (num1 * num2));
                    break;
                case "d":
                    Console.WriteLine($"Your result: {num1} / {num2} = " + (num1 / num2));
                    break;
            }
            // Espere o usuario responder antes de fechar
            Console.Write("Pressione qualquer tecla para fechar a Calculadora...");
            Console.ReadKey();
        }
    }
}
