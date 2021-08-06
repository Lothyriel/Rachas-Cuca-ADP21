using System;
using System.Linq;

namespace Poker.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            CriaJogo cj;
            int iteracoes = 0;
            do
            {
                cj = new CriaJogo(2);
                Console.WriteLine(cj);
                iteracoes++;
            } while (!saiuMao(cj.jogo));
            Console.WriteLine("Iterações: " + iteracoes);
            Console.ReadKey();
        }

        private static bool saiuMao(Jogo jogo)
        {
            return jogo.jogadores.Any(j => j.mao.classificacao == ClassMao.RoyalFlush);
        }
        private static bool empate(Jogo jogo)
        {
            return jogo.ganhadores().Count > 1;
        }
    }
}