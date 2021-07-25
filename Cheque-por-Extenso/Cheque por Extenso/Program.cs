using System;

namespace Cheque_por_Extenso
{
    public class Program
    {
        static void Main(string[] args)
        {
            Cheque cheque = new Cheque();

            Decimal dec = 0.01m;
            while (cheque.chequePorExtenso(dec) != "Valor não suportado")
            {
                Console.WriteLine(cheque.chequePorExtenso(dec));
                dec += 0.01m;
            }
            Console.ReadLine();
        }
    }
}
