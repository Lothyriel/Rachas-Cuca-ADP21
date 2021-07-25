namespace NuvemAeroporto
{
    public class Nuvem : Ponto
    {
        public Nuvem(int x, int y) : base(x, y) { }
        public override string ToString()
        {
            return "#";
        }
    }
}