using System;

namespace Tipo_Triangulo
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("\nDigite os 3 lados do triangulo separados por enter");
                string x = Console.ReadLine();
                string y = Console.ReadLine();
                string z = Console.ReadLine();
                Triangulo triangulo = null;

                Console.Clear();

                string validacao = validaLados.valida(x, y, z);
                if (validacao == "")
                {
                    triangulo = classificaTriangulo.classifica(Convert.ToDouble(x), Convert.ToDouble(y), Convert.ToDouble(z));
                    Console.WriteLine(triangulo.ToString());
                }
                else { Console.WriteLine(validacao); }
            }
        }
    }
}
