using System;
using System.Linq;

namespace Poker.ConsoleApp
{
    class Program
    {
        static void Main()
        {
            CriaJogo cj;
            int iteracoes = 0;
            do
            {
                cj = new CriaJogo(2);
                Console.WriteLine(cj);
                iteracoes++;
            } while (!SaiuMao(cj.jogo));

            //Console.WriteLine(cj);

            Console.WriteLine("Iterações: " + iteracoes);
            Console.ReadKey();
        }

        private static bool SaiuMao(Jogo jogo)
        {
            return jogo.jogadores.Any(j => j.mao.classificacao == ClassMao.RoyalFlush);
        }
        private static bool Empate(Jogo jogo)
        {
            return jogo.ganhadores().Count > 1;
        }
    }
}