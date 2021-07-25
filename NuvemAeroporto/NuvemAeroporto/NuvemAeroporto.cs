using System;
using System.Collections.Generic;
using System.Linq;

namespace NuvemAeroporto
{
    class NuvemAeroporto
    {
        List<Aeroporto> aeroportos = new List<Aeroporto>();
        HashSet<Nuvem> nuvens = new HashSet<Nuvem>();

        int L, C;
        public NuvemAeroporto(string limites, string dados)
        {
            L = (int)Char.GetNumericValue(limites[0]);
            C = (int)Char.GetNumericValue(limites[2]);
            mapearPontos(dados);
        }
        public string resultadoPrevisao()
        {
            int diasParaBazucarOPrimeiro = 0;
            int diasParaBazucarTodos = 0;

            mostrarEstadoAtual(diasParaBazucarTodos);

            while (aeroportos.Any(x => !x.bazucado))
            {
                if (aeroportos.All(x => !x.bazucado))
                    diasParaBazucarOPrimeiro++;
                diasParaBazucarTodos++;

                espalharNuvens();
                bazucarAeroportos();

                mostrarEstadoAtual(diasParaBazucarTodos);
            }
            return $"\nPrimeiro: {diasParaBazucarOPrimeiro} Todos: {diasParaBazucarTodos}";
        }

        private void mostrarEstadoAtual(int diasTotais)
        {
            Ponto[,] pontos = preenchendoMatriz();

            String saida = "";

            for (int i = 0; i < L; i++)
            {
                saida += "\n";
                for (int j = 0; j < C; j++)
                {
                    Ponto ponto = pontos[i, j] != null ? pontos[i, j] : new Ponto(i, j);
                    saida += ponto + " ";
                }
            }
            Console.WriteLine(saida + " Dia: " + diasTotais);

            Ponto[,] preenchendoMatriz()
            {
                pontos = new Ponto[L + 1, C + 1];

                aeroportos.ForEach(a => pontos[a.x, a.y] = a);
                nuvens.ToList().ForEach(n => pontos[n.x, n.y] = n);
                return pontos;
            }
        }
        private void espalharNuvens()
        {
            List<Nuvem> nuvensAux = new List<Nuvem>(nuvens);
            foreach (var nuvem in nuvensAux)
            {
                int x = nuvem.x;
                int y = nuvem.y;

                int sobe = x - 1;
                int desce = x + 1;
                int esquerda = y - 1;
                int direita = y + 1;

                if (sobe >= 0)
                    nuvens.Add(new Nuvem(sobe, y));
                if (desce < C)
                    nuvens.Add(new Nuvem(desce, y));
                if (esquerda >= 0)
                    nuvens.Add(new Nuvem(x, esquerda));
                if (direita <= L)
                    nuvens.Add(new Nuvem(x, direita));
            }
        }
        private void bazucarAeroportos()
        {
            foreach (var aero in aeroportos.Where(x => !x.bazucado))
            {
                var nuvemNoAeroporto = nuvens.ToList().Exists(n => n.x == aero.x && n.y == aero.y);
                if (nuvemNoAeroporto)
                    aero.bazucado = true;
            }
        }
        private void mapearPontos(string dados)
        {
            var linhas = dados.Split('\n').ToList();
            linhas = linhas.Select(x => x.removerEspaco()).ToList();
            for (int i = 0; i < linhas.Count; i++)
            {
                string linhaAtual = linhas[i];
                for (int j = 0; j < linhaAtual.Length; j++)
                {
                    if (linhaAtual[j] == '#') { nuvens.Add(new Nuvem(i, j)); }
                    if (linhaAtual[j] == 'A') { aeroportos.Add(new Aeroporto(i, j)); }
                }
            }
        }
        private void mostrarEstadoAtualFEIAO(int diasTotais)
        {
            String saida = "";

            for (int i = 0; i < L; i++)
            {
                saida += "\n";
                for (int j = 0; j < C; j++)
                {
                    Aeroporto ae = aeroportos.Find(a => a.x == i && a.y == j);
                    Nuvem nu = nuvens.ToList().Find(n => n.x == i && n.y == j);

                    if (nu != null)
                        saida += '#';
                    else if (ae != null)
                        saida += 'A';
                    else
                        saida += '.';

                    saida += " ";
                }
            }
            Console.WriteLine(saida + " Dia: " + diasTotais);
        }
    }
    static class Extensions
    {
        public static string removerEspaco(this string palavra)
        {
            return new string(palavra.Where(c => !Char.IsWhiteSpace(c)).ToArray());
        }
    }
}

