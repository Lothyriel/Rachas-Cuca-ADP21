namespace Tipo_Triangulo
{
    public class equilatero : Triangulo
    {
        public equilatero(double x,double y, double z) : base(x, y, z) { }
        public override string ToString()
        {
            return "Este é um triângulo equilátero de lados: "+x+", "+y+", "+z;
        }
    }
}
