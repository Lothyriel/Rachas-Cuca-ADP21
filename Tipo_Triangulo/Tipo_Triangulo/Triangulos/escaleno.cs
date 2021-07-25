namespace Tipo_Triangulo
{
    public class escaleno : Triangulo
    {
        public escaleno(double x, double y, double z) : base(x, y, z) { }
        public override string ToString()
        {
            return "Este é um triângulo escaleno de lados: "+x+", "+y+", "+z;
        }
    }
}
