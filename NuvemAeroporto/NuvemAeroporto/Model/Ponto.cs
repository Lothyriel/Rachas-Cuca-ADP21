namespace NuvemAeroporto
{
    public class Ponto
    {
        public int x;
        public int y;
        public Ponto(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public override bool Equals(object obj)
        {
            return obj is Ponto ponto && x == ponto.x && y == ponto.y;
        }
        public override int GetHashCode()
        {
            return x.GetHashCode() ^ 69 + y.GetHashCode();
        }
        public override string ToString()
        {
            return ".";
        }
    }
}