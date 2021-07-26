using System.Collections.Generic;
using System.Linq;

namespace Poker
{
    public enum ClassMao
    {
        CartaAlta, UmPar, DoisPares, Trinca, Straight, Flush, FullHouse, Quadra, StraightFlush, RoyalFlush
    }
    public class Mao
    {
        public ClassMao classificacao;
        public List<Carta> cartasMao;
        public Mao(List<Carta> baralho)
        {
            classificacao = definirMao(baralho);
        }
        private ClassMao definirMao(List<Carta> baralho)
        {
            //grupos
            var grupos = agruparPorCartas(baralho);
            if (temQuadra(grupos))
            {
                cartasMao = getNumeroCartaGrupo(baralho, grupos, 4);
                return ClassMao.Quadra;
            }

            if (tem3Iguais(grupos))
            {
                cartasMao = getNumeroCartaGrupo(baralho, grupos, 3);
                if (grupos.Count == 2)                                      //da pra melhorar
                    return ClassMao.FullHouse;
                else
                    return ClassMao.Trinca;
            }

            int pares = getQuantidadePares(grupos);
            cartasMao = getNumeroCartaGrupo(baralho, grupos, 2);
            if (pares == 1) return ClassMao.UmPar;
            if (pares == 2) return ClassMao.DoisPares;

            //sequencias
            if (saoSequencia(baralho))
            {
                cartasMao = baralho;
                if (saoMesmoNaipe(baralho))
                    if (ehRoyalFlush(baralho))
                        return ClassMao.RoyalFlush;
                    else
                        return ClassMao.StraightFlush;

                return ClassMao.Straight;
            }

            //mesmo naipe
            if (saoMesmoNaipe(baralho))
                return ClassMao.Flush;

            cartasMao = new List<Carta>() { baralho.Max(x => x) };
            return ClassMao.CartaAlta;
        }

        #region definirMao

        private static bool ehRoyalFlush(List<Carta> baralho)
        {
            List<Numero> royal = new List<Numero>() { Numero.NT, Numero.NJ, Numero.NQ, Numero.NK, Numero.NA };
            return baralho.Select(c => c.numero).Except(royal).Count() == 0;
        }
        private static List<Carta> getNumeroCartaGrupo(List<Carta> baralho, Dictionary<Numero, int> grupos, int quantidade)
        {
            var numero = grupos.ToList().Find(g => g.Value == quantidade).Key;
            return baralho.Where(c => c.numero == numero).ToList();
        }
        private static int getQuantidadePares(Dictionary<Numero, int> grupos)
        {
            return grupos.Where(g => g.Value == 2).Count();
        }
        private static bool tem3Iguais(Dictionary<Numero, int> grupos)
        {
            return grupos.Where(g => g.Value == 3).Count() == 1;
        }
        private static bool temQuadra(Dictionary<Numero, int> grupos)
        {
            return grupos.Any(c => c.Value == 4);
        }
        private static bool saoMesmoNaipe(List<Carta> cartas)
        {
            return cartas.All(x => x.naipe == cartas.First().naipe);
        }
        private static Dictionary<Numero, int> agruparPorCartas(List<Carta> cartas)
        {
            return cartas.GroupBy(c => c.numero).ToDictionary(c => c.Key, g => g.Count());
        }
        private static bool saoSequencia(List<Carta> baralho)
        {
            if (saoSequencia(baralho.Select(c => c.numero == Numero.NA ? -1 : (int)c.numero)))      //resolver ace high e five high
                return true;
            return saoSequencia(baralho.Select(c => (int)c.numero));
        }
        private static bool saoSequencia(IEnumerable<int> numeros)
        {
            numeros = numeros.OrderBy(n => n);

            int elementos = numeros.Count();
            int primeiroElemento = numeros.First();
            int ultimoElemento = numeros.Last();

            int resultado = (primeiroElemento + ultimoElemento) * elementos / 2;                //soma de gauss
            int resultadoCerto = ((primeiroElemento * 2) + elementos - 1) * elementos / 2;      //soma sempre correta de gauss

            return resultado == resultadoCerto;
        }
        #endregion

        public override string ToString()
        {
            return classificacao.ToString();
        }
    }
}
