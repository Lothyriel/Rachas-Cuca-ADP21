using System;
using System.Collections.Generic;

namespace Poker
{
    public class CriaJogo
    {
        public Jogo jogo;
        private List<Carta> baralhoCompleto;
        private static Random rnd = new Random();

        public CriaJogo(int quantidadeJogadores)
        {
            baralhoCompleto = criaBaralho();
            List<Jogador> jogadores = new List<Jogador>();
            for (int i = 0; i < quantidadeJogadores; i++)
            {
                jogadores.Add(darCartas());
            }
            jogo = new Jogo(jogadores);
        }
        private List<Carta> criaBaralho()
        {
            List<Carta> baralhoCompleto = new List<Carta>();
            for (Numero numero = Numero.N2; numero <= Numero.NA; numero++)
            {
                for (Naipe naipe = Naipe.D; naipe <= Naipe.C; naipe++)
                {
                    baralhoCompleto.Add(new Carta(numero, naipe));
                }
            }
            return baralhoCompleto;
        }
        private Jogador darCartas()
        {
            List<Carta> baralho = new List<Carta>();
            for (int i = 0; i < 5; i++)
            {
                baralho.Add(pegarCarta());
            }

            return new Jogador(baralho);
        }
        private Carta pegarCarta()
        {
            var carta = baralhoCompleto[rnd.Next(baralhoCompleto.Count)];
            baralhoCompleto.Remove(carta);
            return carta;
        }

        public override string ToString()
        {
            return jogo.ToString();
        }
    }
}
