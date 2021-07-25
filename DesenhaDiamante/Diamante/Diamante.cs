using System;
using System.Collections.Generic;
using System.Linq;

namespace DiamanteLetras
{
    public class Diamante
    {
        public static String ExibirDiamante(char letraFinal)
        {
            String espacos = "";
            List<String> listaLetras = new List<String>();

            for (int i = 'A'; i <= letraFinal; i++)
            {
                bool casoA = i != 'A';
                String margem = gerarMargem(letraFinal - i);

                String letraAtual = Char.ConvertFromUtf32(i);

                listaLetras.Add(margem + letraAtual + espacos + (casoA ? letraAtual : ""));

                espacos += casoA ? "  " : " ";
            }

            listaLetras.AddRange(gerarParteInvertida(listaLetras));
            return adicionandoEspacos(listaLetras);
        }
        private static String adicionandoEspacos(List<String> listaLetras)
        {
            String diamante = "";
            listaLetras.ForEach(x => diamante += x + "\n");
            return diamante;
        }
        private static String gerarMargem(int tamanho)
        {
            List<String> listaMargem = Enumerable.Repeat(" ", tamanho).ToList();
            String margem = "";
            listaMargem.ForEach(x => margem += x);
            return margem;
        }
        private static List<String> gerarParteInvertida(List<string> listaLetras)
        {
            var reverso = new List<string>(listaLetras);
            reverso.Reverse();
            reverso.RemoveAt(0);
            return reverso;
        }
    }
}