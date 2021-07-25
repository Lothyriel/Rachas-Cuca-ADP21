using System;
using System.Collections.Generic;
using System.IO;

namespace Sudoku
{
    class Program
    {
        static string sudokuString =
                     @"1 3 2 5 7 9 4 6 8
                       4 9 8 2 6 1 3 7 5  
                       7 5 6 3 8 4 2 1 9  
                       6 4 3 1 5 8 7 9 2
                       5 2 1 7 9 3 8 4 6
                       9 8 7 4 2 6 5 3 1
                       2 1 4 9 3 5 6 8 7
                       3 6 5 8 1 7 9 2 4
                       8 7 9 6 4 2 1 5 3";

        static int[,] sudokuInt = new int[9, 9];

        static int[,] certo = new int[,] {
                     {1,5,2,3,4,7,6,8,9},
                     {3,6,8,5,1,9,2,4,7},
                     {4,7,9,2,6,8,1,5,3},
                     {5,1,3,4,7,2,8,9,6},
                     {6,2,4,8,9,3,7,1,5},
                     {8,9,7,1,5,6,3,2,4},
                     {7,4,1,6,2,5,9,3,8},
                     {2,3,6,9,8,4,5,7,1},
                     {9,8,5,7,3,1,4,6,2}};

        static int[,] erradoRegiao = new int[,] {
                     {1,2,3,4,5,6,7,8,9},
                     {2,3,4,5,6,7,8,9,1},
                     {3,4,5,6,7,8,9,1,2},
                     {4,5,6,7,8,9,1,2,3},
                     {5,6,7,8,9,1,2,3,4},
                     {6,7,8,9,1,2,3,4,5},
                     {7,8,9,1,2,3,4,5,6},
                     {8,9,1,2,3,4,5,6,7},
                     {9,1,2,3,4,5,6,7,8}};
        static void Main(string[] args)
        {
            //testar(certo);
            //testar(erradoRegiao);

            stringtoInt(sudokuString);
            testar(sudokuInt);

            Console.ReadLine();
        }

        private static void stringtoInt(string sudokuString)
        {
            using (StringReader reader = new StringReader(sudokuString))
            {
                string linhaSudoku = "";

                for (int x = 0; x < 9; x++)
                {
                    linhaSudoku = reader.ReadLine();

                    string[] valores = linhaSudoku.Trim().Split();

                    for (int y = 0; y < 9; y++)
                    {
                        sudokuInt[x, y] = Convert.ToInt32(valores[y]);
                    }
                }
            }
        }

        private static void testar(int[,] matriz)
        {
            printarMatriz(matriz);
            if (verificarColunas(matriz) && verificarLinhas(matriz) && verificarRegioes(matriz))
            { Console.WriteLine("\nSIM!"); }
            else
            { Console.WriteLine("\nNÃO!"); }
            if (verificarColunas(matriz)) { Console.WriteLine("Colunas corretas"); } else { Console.WriteLine("Coluna errado"); }
            if (verificarLinhas(matriz)) { Console.WriteLine("Linhas corretas"); }
            if (verificarRegioes(matriz)) { Console.WriteLine("Regiões corretas"); }
        }

        private static bool verificarRegioes(int[,] matriz)
        {
            HashSet<int> numeros;
            bool certo = true;

            for (int s = 0; s < 9; s += 3)
            {
                for (int m = 0; m < 9; m += 3)
                {
                    numeros = new HashSet<int>();

                    for (int i = 0; i < 3; i++)
                    {
                        for (int j = 0; j < 3; j++)
                        {
                            certo = numeros.Add(matriz[i + s, j + m]);

                            //teste(matriz, numeros, certo, s, m, i, j);

                            if (!certo) { return certo; }
                        }
                    }
                }
            }
            return certo;
        }

        private static bool verificarColunas(int[,] matriz)
        {
            bool certo = true;

            for (int j = 0; j < 9; j++)
            {
                HashSet<int> numeros = new HashSet<int>();
                for (int i = 0; i < 9; i++)
                {
                    certo = numeros.Add(matriz[i, j]);
                    if (!certo) { return certo; }
                }
            }
            return certo;
        }

        private static bool verificarLinhas(int[,] matriz)
        {
            bool certo = true;

            for (int i = 0; i < 9; i++)
            {
                HashSet<int> numeros = new HashSet<int>();
                for (int j = 0; j < 9; j++)
                {
                    certo = numeros.Add(matriz[i, j]);
                    if (!certo) { return certo; }
                }
            }
            return certo;
        }

        private static void printarMatriz(int[,] matriz)
        {
            for (int i = 0; i < 9; i++)
            {
                Console.WriteLine();
                for (int j = 0; j < 9; j++)
                {
                    Console.Write(matriz[i, j] + " ");
                }
            }
            Console.WriteLine();
        }

        private static void teste(int[,] matriz, HashSet<int> numeros, bool certo, int s, int m, int i, int j)
        {
            Console.WriteLine(certo);
            foreach (int k in numeros)
            {
                Console.Write(k);
            }
            Console.WriteLine("\n[" + (i + s) + "][" + (j + m) + "]= " + matriz[i + s, j + m] + "\n");
        }
    }

}