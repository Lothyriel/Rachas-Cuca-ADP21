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
        public string getGanhador()
        {
            var ganhador = maiorMao(jogadores);
            int id = jogadores.IndexOf(ganhador);
            return id != -1 ? $"Jogador {id + 1}" : "Empate";
        }
        private static Jogador maiorMao(List<Jogador> jogadores)
        {
            Jogador ganhador = jogadores.First();
            foreach (var jogador in jogadores.Skip(1))
            {
                ClassMao maoJogador = jogador.mao.classificacao;
                ClassMao? maoGanhador = ganhador?.mao.classificacao;
                if (maoJogador > maoGanhador)
                    ganhador = jogador;
                else if (maoJogador == maoGanhador)
                    ganhador = desempateCartasMao(ganhador, jogador);
            }
            return ganhador;
        }
        private static Jogador desempateCartasMao(Jogador jogador1, Jogador jogador2)
        {
            var j1Pontos = jogador1.mao.cartasMao.Sum(c => (int)c.numero);
            var j2Pontos = jogador2.mao.cartasMao.Sum(c => (int)c.numero);

            if (j1Pontos > j2Pontos)
                return jogador1;
            else if (j2Pontos > j1Pontos)
                return jogador2;
            else
                return desempateCartas(jogador1, jogador2);
        }
        private static Jogador desempateCartas(Jogador jogador1, Jogador jogador2)
        {
            var j1Pontos = jogador1.baralho.Sum(c => (int)c.numero);
            var j2Pontos = jogador2.baralho.Sum(c => (int)c.numero);

            if (j1Pontos > j2Pontos)
                return jogador1;
            else if (j2Pontos > j1Pontos)
                return jogador2;
            else
                return null;
        }
        public override string ToString()
        {
            string jogadores = "";
            this.jogadores.ForEach(j => jogadores += j + "\n");
            jogadores += getGanhador();
            return jogadores;
        }
    }
}
