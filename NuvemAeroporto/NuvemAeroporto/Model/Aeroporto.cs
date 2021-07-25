namespace NuvemAeroporto
{
    public class Aeroporto : Ponto
    {
        public Aeroporto(int x, int y) : base(x, y)
        {
            bazucado = false;
        }

        public bool bazucado;
        public override string ToString()
        {
            return "A";
        }
    }
}