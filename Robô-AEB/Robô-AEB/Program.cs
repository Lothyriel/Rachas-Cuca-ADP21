using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robô_AEB
{
    class Program
    {
        static int x,x_grid;
        static int y,y_grid;
        static string direcao;

        static void Main(string[] args)
        {
            int robos = 1;
            while (true)
            {
                Console.WriteLine("Digite o tamanho da área de análise no formato (X Y) separado por espaço");
                string entrada = Console.ReadLine();

                if (!valido(entrada))
                {
                    Console.WriteLine("Digite dimensões válidas para a área!");
                    continue;
                }
                else
                {
                    while (true)
                    {
                        Console.WriteLine("Digite os dados iniciais do robô[" + robos + "] no formato (X Y direcao) separado por espaço");
                        entrada = Console.ReadLine();

                        if (!valido(entrada))
                        {
                            Console.WriteLine("Digite coordenadas válidas para o robo!");
                            continue;
                        }
                        else
                        {
                            robos++;
                            Robo r = new Robo(x, y, direcao[0]);
                            while (true)
                            {
                                Console.WriteLine("Insira os comandos.");
                                string comandos = Console.ReadLine();
                                comandos = comandos.ToUpper();

                                for (int i = 0; i < comandos.Length; i++)
                                {
                                    if (comandos[i] == 'E') { r.esquerda(); }
                                    else
                                    if (comandos[i] == 'D') { r.direita(); }
                                    else
                                    if (comandos[i] == 'M') { r.move(); }
                                    else
                                    {
                                        Console.WriteLine("Comando[" + comandos[i] + "] não interpretado pelo robô!");
                                    }
                                }
                                if (r.getX() < 0 || r.getY() < 0|| r.getX() > x_grid  || r.getY() > y_grid)
                                {
                                    Console.WriteLine("O Robô saiu da área, perdemos contato!!!");
                                }
                                else
                                {
                                    Console.WriteLine(r.ToString());
                                }
                                break;
                            }
                            continue;
                        }
                    }
                }
            }
        }
        public static bool valido(string dados)
        {
            string[] split = dados.Split(' ');                                                              // SEPARA A STRING EM SUBSTRINGS AO ENCONTRAR ' '                                                                          //Console.WriteLine(string.Join(" ", s)); JUNTA A STRING DNV
            if (split.Length == 2)
            {
                return int.TryParse(split[0], out x_grid) && int.TryParse(split[1], out y_grid);
            }
            else if (split.Length == 3)
            {
                direcao = split[2].ToUpper();
                bool EhDirecao = direcao == "N" || direcao == "S" || direcao == "L" || direcao == "O";
                return int.TryParse(split[0], out x) && int.TryParse(split[1], out y) && EhDirecao;
            }
            else {
                return false;
            }                                                                                           
        }
    }
}
