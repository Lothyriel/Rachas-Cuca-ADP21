using System;

namespace Poker
{
    public enum Naipe
    {
        D, H, S, C
    }
    public enum Numero
    {
        N2, N3, N4, N5, N6, N7, N8, N9, NT, NJ, NQ, NK, NA
    }
    public class Carta : IComparable<Carta>
    {
        public Numero numero;
        public Naipe naipe;
        public Carta(Numero numero, Naipe naipe)
        {
            this.naipe = naipe;
            this.numero = numero;
        }

        public static Carta getCarta(string carta)
        {
            var numero = (Numero)Enum.Parse(typeof(Numero), "N" + carta[0]);
            var naipe = (Naipe)Enum.Parse(typeof(Naipe), carta[1].ToString());
            return new Carta(numero, naipe);
        }
        public static bool operator <(Carta a, Carta b)
        {
            return a.numero < b.numero;
        }
        public static bool operator >(Carta a, Carta b)
        {
            return a.numero > b.numero;
        }
        public override string ToString()
        {
            return $"{numero.ToString()[1]}{naipe}";
        }
        public int CompareTo(Carta other)
        {
            return numero.CompareTo(other.numero);
        }
    }
}
