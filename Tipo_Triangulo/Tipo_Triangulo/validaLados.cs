namespace Tipo_Triangulo
{
    public class validaLados
    {
        public static string valida(string x, string y, string z)
        {
            double dx = 0, dy = 0, dz = 0;
            string validacao = "";
            if (!double.TryParse(x, out dx) || !double.TryParse(y, out dy) || !double.TryParse(z, out dz))
            {
                validacao += "um dos lados não era um número! /";
            }
            if (dx + dy < dz || dx + dz < dy || dy + dz < dx) { validacao += "a soma de dois lados é maior do que o lado restante! /"; }
            if (dx <= 0 || dy <= 0 || dz <= 0) { validacao += "um dos lados é igual ou menor a 0"; }
            return validacao;
        }
    }
}
