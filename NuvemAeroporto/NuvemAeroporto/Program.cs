using System;

namespace NuvemAeroporto
{
    class Program
    {
        static void Main(string[] args)
        {
            string limites = "7 8";

            string mapa = @"..#...##
                            .##.....
                            ###.A..A
                            .#......
                            .#....A.
                            ...A....
                            ........";

            NuvemAeroporto na = new NuvemAeroporto(limites, mapa);
            Console.WriteLine(na.resultadoPrevisao());

            Console.ReadLine();

            limites = "7 8";

            mapa = @"A.......
                     ........
                     ........
                     ....#...
                     ........
                     ........
                     ........";

            na = new NuvemAeroporto(limites, mapa);
            Console.WriteLine(na.resultadoPrevisao());

            Console.ReadLine();
        }
    }
}
