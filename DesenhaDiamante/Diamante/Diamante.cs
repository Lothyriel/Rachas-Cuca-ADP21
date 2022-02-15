using System;
using System.Collections.Generic;

namespace DiamanteLetras
{
    public class Diamante
    {
        public static string ExibirDiamante(char letraFinal)
        {
            string espacos = "";
            List<string> listaLetras = new List<string>();

            for (int i = 'A'; i <= letraFinal; i++)
            {
                bool casoA = i != 'A';
                string margem = new string(' ', letraFinal - i);

                string letraAtual = Char.ConvertFromUtf32(i);

                listaLetras.Add(margem + letraAtual + espacos + (casoA ? letraAtual : ""));

                espacos += casoA ? "  " : " ";
            }

            listaLetras.AddRange(gerarParteInvertida(listaLetras));
            return adicionandoEspacos(listaLetras);
        }
        private static string adicionandoEspacos(List<string> listaLetras)
        {
            string diamante = "";
            listaLetras.ForEach(x => diamante += x + "\n");
            return diamante;
        }
        private static List<string> gerarParteInvertida(List<string> listaLetras)
        {
            var reverso = new List<string>(listaLetras);
            reverso.Reverse();
            reverso.RemoveAt(0);
            return reverso;
        }
    }
}