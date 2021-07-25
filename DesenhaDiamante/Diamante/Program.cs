using System;

namespace DiamanteLetras
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 65; i < 90; i++)
                Console.WriteLine(Diamante.ExibirDiamante((char)i));
            Console.ReadLine();
        }
    }
}
