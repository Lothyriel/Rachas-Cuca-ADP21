using System;
using System.Linq;

namespace Poker.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            CriaJogo cj;
            int jogos = 0;
            do
            {
                cj = new CriaJogo(2);
                Console.WriteLine(cj);
                jogos++;
            } while (!empate(cj.jogo));
            Console.WriteLine("Iterações: " + jogos);
            Console.ReadKey();
        }

        private static bool saiuRoyalFlush(Jogo jogo)
        {
            return jogo.jogadores.Any(j => j.mao.classificacao == ClassMao.RoyalFlush);
        }
        private static bool empate(Jogo jogo)
        {
            return jogo.getGanhador() == "Empate";
        }
    }
}