using System;
using System.Collections.Generic;
using System.Numerics;

namespace Cheque_por_Extenso
{
    public class Cheque
    {
        String[] unidades = new String[] { "", "um", "dois", "três", "quatro", "cinco", "seis", "sete", "oito", "nove" };
        String[] dezVinte = new String[] { "", "onze", "doze", "treze", "quatorze", "quinze", "dezesseis", "dezessete", "dezoito", "dezenove" };
        String[] dezenas = new String[] { "", "dez", "vinte", "trinta", "quarenta", "cinquenta", "sessenta", "setenta", "oitenta", "noventa" };
        String[] centenas = new String[] { "", "cento", "duzentos", "trezentos", "quatrocentos", "quinhentos", "seiscentos", "setecentos", "oitocentos", "novecentos" };

        String[] multiplicadorSingular = new String[] { "centavo", "real", "mil", "milhão", "bilhão", "trilhão", "quadrilhão", "quintilhão", "sextilhão", "septilhão" };
        String[] multiplicadorPlural = new String[] { "centavos", "reais", "mil", "milhões", "bilhões", "trilhões", "quadrilhões", "quintilhões", "sextilhões", "septilhões" };

        public string chequePorExtenso(Decimal valor)
        {
            Decimal max = 999999999999999999999999999m;
            if (valor > max || valor <= 0)
                return "Valor não suportado";

            List<String> classes = listaDeClasses(valor);
            Stack<String> chequePorExtenso = new Stack<String>();

            int iMultip = 0;
            bool redondo = ehValorRedondo(valor);
            for (int i = classes.Count; i > 0; i--)
            {
                String separador = "";
                String classeAtual = classes[i - 1];
                String multiplicador = getMultiplicador(iMultip, classeAtual);

                if (classeAtual != "000" || (iMultip == 1 && valor > 1))                                                   //permite colocar "reais" em todas os cheques que possuem valor maior ou igual 1 real
                {
                    if (iMultip == 1 && classes[i] != "000") separador = " e ";                                                         //e para separar centavos
                    else if (iMultip > 1 && classes[i] != "000") separador = " ";
                    else if (i < classes.Count - 2 && redondo) separador = " de";                                                       //inserir "de reais" em valores redondos a partir de 1.000.000
                    else if (i < classes.Count - 2) separador = " e ";
                    chequePorExtenso.Push(" " + multiplicador + separador);
                }
                iMultip++;
                chequePorExtenso.Push(classeEmExtenso(classeAtual));
            }
            return montarString(chequePorExtenso);
        }
        private string getMultiplicador(int iMultip, string classeAtual)
        {
            if (classeAtual == "001") return multiplicadorSingular[iMultip];
            else return multiplicadorPlural[iMultip];
        }
        public bool ehValorRedondo(decimal valor)
        {
            BigInteger valorSemDecimal = new BigInteger(valor);
            String strValor = valorSemDecimal.ToString();
            BigInteger expoente = new BigInteger(Math.Pow(10, strValor.Length - 1));
            return valorSemDecimal % expoente == 0;
        }
        private string montarString(Stack<String> classesPorExtenso)
        {
            String chequePorExtenso = null;
            while (classesPorExtenso.Count > 0)
                chequePorExtenso += classesPorExtenso.Pop();
            return chequePorExtenso;
        }
        private string classeEmExtenso(String classe)
        {
            String separacaoCentenas = "";
            String separacaoDezenas = "";

            int centena = (int)Char.GetNumericValue(classe[0]);
            int dezena = (int)Char.GetNumericValue(classe[1]);
            int unidade = (int)Char.GetNumericValue(classe[2]);

            String centenas = this.centenas[centena];
            String dezenas = this.dezenas[dezena];
            String unidades = this.unidades[unidade];

            if (classe == "100") centenas = "cem";
            else if (centena > 0 && dezena + unidade > 0) separacaoCentenas = " e ";                       //maior que 100 com dezena ou unidade
            if (dezena == 1 && unidade != 0) { dezenas = dezVinte[unidade]; unidades = ""; }                        //11-19
            else if (dezena > 1 && unidade != 0) separacaoDezenas = " e ";                                          //maior que 20 com unidade

            return centenas + separacaoCentenas + dezenas + separacaoDezenas + unidades;
        }
        private List<String> listaDeClasses(Decimal valor)                                                                        //centavos por ultimo
        {
            String valorStr = valor.ToString("000,000,000,000,000,000,000,000,000.00");
            String[] classesEDecimal = valorStr.Split(',');
            String[] classes = classesEDecimal[0].Split('.');

            List<String> listaClasses = new List<String>();

            foreach (String item in classes)
            {
                listaClasses.Add(item);
            }
            listaClasses.Add("0" + classesEDecimal[1]);

            return listaClasses;
        }
    }
}