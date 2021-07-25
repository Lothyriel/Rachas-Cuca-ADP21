using System;

namespace Aprendendo_Delegates
{
    class Program
    {
        delegate int operacao(int a, int b);

        static void Main(string[] args)
        {
            int soma(int a, int b) { return a + b; }
            int subtracao(int a, int b) { return a - b; }

            void calcular(int a, int b, operacao op)
            {
                Console.WriteLine("Resultado: " + op(a, b));
            }

            calcular(5, 10, soma);
            calcular(5, 10, subtracao);

            Console.ReadLine();
        }
    }
}
