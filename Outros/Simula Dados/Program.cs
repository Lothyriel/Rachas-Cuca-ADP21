using System;
using System.Collections.Generic;

namespace Simula_Dados
{
    class Program
    {
        static void Main(string[] args)
        {
            List<String> combinacoesMaiores = new List<string>();
            List<String> combinacoesMenores = new List<string>();

            int limiar = 3;
            for (int i = 1; i <= 6; i++)
            {
                for (int j = 1; j <= 6; j++)
                {
                    for (int k = 1; k <= 6; k++)
                    {
                        bool condicao = j + i + k == limiar;
                        String resultado = $"Dado: {i} Dado: {j} Dado: {k}";
                        if (condicao) combinacoesMaiores.Add(resultado);
                        else combinacoesMenores.Add(resultado);
                    }
                }

            }
            Console.WriteLine($"Maiores que {limiar}: {combinacoesMaiores.Count}");
            Console.WriteLine($"Menores que {limiar}: {combinacoesMenores.Count}");

            Console.ReadLine();
        }
    }
}
