using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            string r = "sim";
            r.ToLower();

            while (r == "sim")
            {
                Console.Clear();
                Console.WriteLine("Digite a operação desejada:");
                Console.WriteLine("1 - SOMA");
                Console.WriteLine("2 - SUBTRAÇÃO");
                Console.WriteLine("3 - MULTIPLICAÇÃO");
                Console.WriteLine("4 - DIVISÂO");
                int respostaOperacao = int.Parse(Console.ReadLine());

                switch (respostaOperacao)
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


                    default:
                        Console.WriteLine("Operação inválida");
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
        }
    }
}