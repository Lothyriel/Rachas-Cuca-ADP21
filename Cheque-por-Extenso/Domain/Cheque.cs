using System.Numerics;
using System.Text;

namespace ChequeExtenso
{
    public class Cheque
    {
        private readonly string[] Unidades = new[] { "", "um", "dois", "três", "quatro", "cinco", "seis", "sete", "oito", "nove" };
        private readonly string[] DezVinte = new[] { "", "onze", "doze", "treze", "quatorze", "quinze", "dezesseis", "dezessete", "dezoito", "dezenove" };
        private readonly string[] Dezenas = new[] { "", "dez", "vinte", "trinta", "quarenta", "cinquenta", "sessenta", "setenta", "oitenta", "noventa" };
        private readonly string[] Centenas = new[] { "", "cento", "duzentos", "trezentos", "quatrocentos", "quinhentos", "seiscentos", "setecentos", "oitocentos", "novecentos" };
        private readonly string[] MultiplicadorSingular = new[] { "centavo", "real", "mil", "milhão", "bilhão", "trilhão", "quadrilhão", "quintilhão", "sextilhão", "septilhão" };
        private readonly string[] MultiplicadorPlural = new[] { "centavos", "reais", "mil", "milhões", "bilhões", "trilhões", "quadrilhões", "quintilhões", "sextilhões", "septilhões" };

        public string ChequePorExtenso(decimal valor)
        {
            var max = 999999999999999999999999999m;

            if (valor > max || valor <= 0)
                return "Valor não suportado";

            var classes = GetClasses(valor);
            var ChequePorExtenso = new Stack<string>();

            int iMultip = 0;
            var redondo = EhValorRedondo(valor);

            for (int i = classes.Count; i > 0; i--)
            {
                string separador = "";
                string classeAtual = classes[i - 1];
                string multiplicador = GetMultiplicador(iMultip, classeAtual);

                if (classeAtual != "000" || (iMultip == 1 && valor > 1))                                                                //permite colocar "reais" em todas os cheques que possuem valor maior ou igual 1 real
                {
                    if (iMultip == 1 && classes[i] != "000") separador = " e ";                                                         //e para separar centavos
                    else if (iMultip > 1 && classes[i] != "000") separador = " ";
                    else if (i < classes.Count - 2 && redondo) separador = " de";                                                       //inserir "de reais" em valores redondos a partir de 1.000.000
                    else if (i < classes.Count - 2) separador = " e ";
                    ChequePorExtenso.Push(" " + multiplicador + separador);
                }
                iMultip++;
                ChequePorExtenso.Push(ClasseEmExtenso(classeAtual));
            }
            return MontarString(ChequePorExtenso);
        }
        private string GetMultiplicador(int iMultip, string classeAtual)
        {
            return classeAtual == "001" ? MultiplicadorSingular[iMultip] : MultiplicadorPlural[iMultip];
        }

        public static bool EhValorRedondo(decimal valor)
        {
            var valorSemDecimal = new BigInteger(valor);
            string strValor = valorSemDecimal.ToString();
            var expoente = new BigInteger(Math.Pow(10, strValor.Length - 1));

            return valorSemDecimal % expoente == 0;
        }
        private static string MontarString(Stack<string> classesPorExtenso)
        {
            var ChequePorExtenso = new StringBuilder();

            while (classesPorExtenso.Count > 0)
                ChequePorExtenso.Append(classesPorExtenso.Pop());

            return ChequePorExtenso.ToString();
        }
        private string ClasseEmExtenso(string classe)
        {
            string separacaoCentenas = "";
            string separacaoDezenas = "";

            int centena = (int)char.GetNumericValue(classe[0]);
            int dezena = (int)char.GetNumericValue(classe[1]);
            int unidade = (int)char.GetNumericValue(classe[2]);

            var centenas = Centenas[centena];
            var dezenas = Dezenas[dezena];
            var unidades = Unidades[unidade];

            if (classe == "100") centenas = "cem";
            else if (centena > 0 && dezena + unidade > 0) separacaoCentenas = " e ";                       //maior que 100 com dezena ou unidade
            if (dezena == 1 && unidade != 0) { dezenas = DezVinte[unidade]; unidades = ""; }                        //11-19
            else if (dezena > 1 && unidade != 0) separacaoDezenas = " e ";                                          //maior que 20 com unidade

            return centenas + separacaoCentenas + dezenas + separacaoDezenas + unidades;
        }
        private static List<string> GetClasses(decimal valor)                                                                        //centavos por ultimo
        {
            string valorStr = valor.ToString("000,000,000,000,000,000,000,000,000.00");
            string[] classesEDecimal = valorStr.Split(',');
            string[] classes = classesEDecimal[0].Split('.');

            return new List<string>(classes)
            {
                "0" + classesEDecimal[1]
            };
        }
    }
}