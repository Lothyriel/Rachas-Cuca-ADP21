namespace Tipo_Triangulo
{
    public class isosceles : Triangulo
    {
        public isosceles(double x, double y, double z) : base(x, y, z) { }
        public override string ToString()
        {
            return "Este é um triângulo isosceles de lados: " + x+", "+y+", "+z;
        }
    }
}
