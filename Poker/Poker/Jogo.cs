using System.Collections.Generic;
using System.Linq;

namespace Poker
{
    public class Jogo
    {
        public List<Jogador> jogadores;
        public Jogo(List<Jogador> jogadores)
        {
            this.jogadores = jogadores;
        }
        public string resultado()
        {
            var ganhadores = this.ganhadores();
            string resultado = "";
            ganhadores.ForEach(j => resultado += $"Jogador {jogadores.IndexOf(j) + 1} | ");
            return resultado;
        }
        public List<Jogador> ganhadores()
        {
            Jogador ganhador = jogadores.First();
            var ganhadores = new List<Jogador>();
            foreach (var jogador in jogadores.Skip(1))
            {
                ClassMao maoJogador = jogador.mao.classificacao;
                ClassMao? maoGanhador = ganhador?.mao.classificacao;
                if (maoJogador > maoGanhador)
                    ganhadores.Add(jogador);
                else if (maoGanhador > maoJogador)
                    ganhadores.Add(ganhador);
                else
                    ganhadores.AddRange(desempateMao(ganhador, jogador));
            }
            return ganhadores;
        }
        private static List<Jogador> desempateMao(Jogador jogador1, Jogador jogador2)
        {
            int j1Pontos = calcularPontos(jogador1);
            int j2Pontos = calcularPontos(jogador2);

            if (j1Pontos > j2Pontos)
                return new List<Jogador>() { jogador1 };
            else if (j2Pontos > j1Pontos)
                return new List<Jogador>() { jogador2 };
            else
                return desempateKickers(jogador1, jogador2);
        }
        private static List<Jogador> desempateKickers(Jogador jogador1, Jogador jogador2)
        {
            var kickers1 = ordenarFila(jogador1);
            var kickers2 = ordenarFila(jogador2);

            while (kickers1.Any())
            {
                Carta kicker1 = kickers1.Dequeue();
                Carta kicker2 = kickers2.Dequeue();

                if (kicker1 > kicker2)
                    return new List<Jogador>() { jogador1 };
                else if (kicker2 > kicker1)
                    return new List<Jogador>() { jogador2 };
            }
            return new List<Jogador>() { jogador1, jogador2 };
        }
        private static Queue<Carta> ordenarFila(Jogador jogador1)
        {
            return new Queue<Carta>(jogador1.baralho.Except(jogador1.mao.cartasMao).OrderByDescending(c => c.numero));
        }
        private static int calcularPontos(Jogador jogador)
        {
            var j1Pontos = jogador.mao.cartasMao.Sum(c => (int)c.numero);
            if (ehFiveHigh(jogador))
                j1Pontos -= (int)Numero.NA;
            return j1Pontos;
        }
        private static bool ehFiveHigh(Jogador jogador)
        {
            ClassMao mao = jogador.mao.classificacao;
            var baralho = jogador.baralho;
            return (mao == ClassMao.Straight || mao == ClassMao.StraightFlush) && baralho.Max().numero == Numero.NA && baralho.Min().numero == Numero.N2;
        }
        public override string ToString()
        {
            string jogadores = "";
            this.jogadores.ForEach(j => jogadores += j + "\n");
            jogadores += resultado();
            return jogadores;
        }
    }
}
