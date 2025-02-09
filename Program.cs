using System;

namespace Calculator
{
    class Program
    {
        static int Menu()
        {
            Console.Clear();
            Console.WriteLine("Digite a operação desejada:");
            Console.WriteLine("1 - SOMA");
            Console.WriteLine("2 - SUBTRAÇÃO");
            Console.WriteLine("3 - MULTIPLICAÇÃO");
            Console.WriteLine("4 - DIVISÂO");
            Console.WriteLine("5 - SAIR");
            int respostaOperacao = int.Parse(Console.ReadLine());

            return respostaOperacao;

        }
        static void Main(string[] args)
        {
            string r = "sim";
            r.ToLower();

            while (r == "sim")
            {
                switch (Menu())
                {
                    case 1:
                        Soma();
                        break;

                    case 2:
                        Subtracao();
                        break;

                    case 3:
                        Multiplicacao();
                        break;

                    case 4:
                        Divisao();
                        break;

                    case 5:
                        Console.Clear();
                        Console.WriteLine("Programa Finalizado");
                        Console.ReadKey();
                        System.Environment.Exit(0);
                        break;

                    default:
                        Console.WriteLine("Operação inválida");
                        Menu();
                        break;
                }
                Console.WriteLine("Calcular novamente ? sim/nao ");
                r = Console.ReadLine();
            }
            Console.Clear();
            Console.WriteLine("Programa finalizado");
        }
        static void Soma()
        {
            Console.Clear();

            Console.WriteLine("Digite o primeiro número:");
            float v1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo número");
            float v2 = float.Parse(Console.ReadLine());

            float s = v1 + v2;

            Console.WriteLine($"O resultado da soma é {s}");
            Console.ReadKey();
        }

        static void Subtracao()
        {
            Console.Clear();

            Console.WriteLine("Digite o primeiro número:");
            float v1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo número");
            float v2 = float.Parse(Console.ReadLine());

            float s = v1 - v2;

            Console.WriteLine($"O resultado da subtração é {s}");
            Console.ReadKey();
        }

        static void Multiplicacao()
        {
            Console.Clear();

            Console.WriteLine("Digite o primeiro número:");
            float v1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo número");
            float v2 = float.Parse(Console.ReadLine());

            float s = v1 * v2;

            Console.WriteLine($"O resultado da multiplicação é {s}");
            Console.ReadKey();
        }

        static void Divisao()
        {
            Console.Clear();

            Console.WriteLine("Digite o primeiro número:");
            float v1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo número");
            float v2 = float.Parse(Console.ReadLine());

            float s = v1 / v2;

            Console.WriteLine($"O resultado da divisão é {s.ToString("F2")}");
            Console.ReadKey();
        }
    }
}