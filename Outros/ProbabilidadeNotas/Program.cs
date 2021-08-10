using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ProbabilidadeNotas
{
    class Program
    {
        static int alternativas = 4;
        static int qntQuestoes = 15;

        static Prova gabarito = new Prova(qntQuestoes, alternativas);
        static void Main()
        {
            Resultado.casosAmostragem = 90000000;

            //Parallel.For(0, Resultado.casosAmostragem, x =>                                                                               //PARALELO SIMPLESMENTE SOME COM MEUS DADOS???
            //  {
            //      Resultado.add(new Prova(qntQuestoes, alternativas).getNota(gabarito));
            //  });

            for (int i = 0; i < Resultado.casosAmostragem; i++)
                Resultado.add(new Prova(qntQuestoes, alternativas).getNota(gabarito));


            Resultado.mostrar();

            Console.ReadKey();
        }
    }

    internal class Resultado
    {
        internal static int casosAmostragem;

        private static double menorOuIgual4;
        private static double resto;
        private static Dictionary<int, int> resultados = new Dictionary<int, int>() { { 0, 0 }, { 1, 0 }, { 2, 0 }, { 3, 0 }, { 4, 0 }, { 5, 0 }, { 6, 0 }, { 7, 0 }, { 8, 0 }, { 9, 0 }, { 10, 0 } };

        internal static void add(int nota)
        {
            if (nota <= 4)
                menorOuIgual4++;
            else
                resto++;
            resultados[nota]++;
        }
        internal static void mostrar()
        {
            Console.WriteLine($"Menor ou igual a 4: { menorOuIgual4 / casosAmostragem * 100}%");
            Console.WriteLine($"Maior que 4: {resto / casosAmostragem * 100}%");
            Console.WriteLine($"Total: {(resto + menorOuIgual4) / casosAmostragem * 100}%");
            foreach (var item in resultados)
                Console.WriteLine($"{item.Key}\t{item.Value}");
        }
    }

    internal class Prova
    {
        private static Random rnd = new Random();
        private int[] respostas;

        public Prova(int qntQuestoes, int alternativas)
        {
            respostas = new int[qntQuestoes];

            for (int i = 0; i < respostas.Length; i++)
            {
                respostas[i] = rnd.Next(alternativas);
            }
        }
        internal int getNota(Prova gabarito)
        {
            double nota = 0;
            for (int i = 0; i < respostas.Length; i++)
            {
                if (gabarito.respostas[i] == respostas[i])
                    nota += 10d / respostas.Length;
            }
            return (int)Math.Round(nota, 1);
        }
    }
}
