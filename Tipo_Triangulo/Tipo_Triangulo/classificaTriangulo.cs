namespace Tipo_Triangulo
{
    public class classificaTriangulo
    {
        public static Triangulo classifica(double x, double y, double z)
        {
            Triangulo triangulo;
            if (x == y && x == z) { triangulo = new equilatero(x, y, z); }
            else if (x == y&&(x==z||y==z)) { triangulo = new isosceles(x, y, z); }
            else { triangulo = new escaleno(x, y, z); }
            return triangulo;
        }
    }
}
