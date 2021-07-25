using System;
using System.Collections.Generic;

namespace Data_PorExtenso
{
    public class Data
    {
        String[] unidades = new String[] { "", "um", "dois", "três", "quatro", "cinco", "seis", "sete", "oito", "nove" };
        String[] dezVinte = new String[] { "", "onze", "doze", "treze", "quatorze", "quinze", "dezesseis", "dezessete", "dezoito", "dezenove" };
        String[] dezenas = new String[] { "", "dez", "vinte", "trinta", "quarenta", "cinquenta", "sessenta", "setenta", "oitenta", "noventa" };

        String[] unidadesTempoSingular = new String[] { "segundo", "minuto", "hora", "dia", "semana", "mês", "ano" };
        String[] unidadesTempoPlural = new String[] { "segundos", "minutos", "horas", "dias", "semanas", "meses", "anos" };

        private DateTime agora;
        public Data(DateTime agora)
        {
            this.agora = agora;
        }
        public string periodoPorExtenso(DateTime data)
        {
            if (data >= agora)
                return "Erro, Data futura ou atual!";
            if (data.Year <= agora.Year - 99)
                return "Período muito grande, data não suportada";

            List<String> listaDeUnidades = listaUnidades(data);

            Stack<String> periodoPorExtenso = new Stack<String>();

            int iUnidadesTempo = 0;
            periodoPorExtenso.Push("atrás");
            for (int i = listaDeUnidades.Count; i > 0; i--)
            {
                String separador = "";
                String unidadeTempo = "";
                String espaco = "";
                String unidadeAtual = listaDeUnidades[i - 1];

                if (unidadeAtual != "00")
                {
                    separador = " ";
                    espaco = " ";
                    unidadeTempo += getUnidadeTempo(iUnidadesTempo, unidadeAtual);
                }
                periodoPorExtenso.Push(unidadeEmExtenso(unidadeAtual, iUnidadesTempo) + separador + unidadeTempo + espaco);
                iUnidadesTempo++;
            }

            return montarString(periodoPorExtenso);
        }
        private string unidadeEmExtenso(String unidadeTempo, int iUnidadesTempo)
        {
            String separacao = "";

            int dezena = (int)Char.GetNumericValue(unidadeTempo[0]);
            int unidade = (int)Char.GetNumericValue(unidadeTempo[1]);

            String dezenas = this.dezenas[dezena];
            String unidades = this.unidades[unidade];

            if (dezena == 1 && unidade != 0) { dezenas = dezVinte[unidade]; unidades = ""; }
            else if (dezena > 1 && unidade != 0) separacao = " e ";

            if (unidade == 1 && (iUnidadesTempo == 2 || iUnidadesTempo == 4)) unidades = "uma";
            else if (unidade == 2 && (iUnidadesTempo == 2 || iUnidadesTempo == 4)) unidades = "duas";

            return dezenas + separacao + unidades;
        }
        private List<String> listaUnidades(DateTime data)
        {
            TimeSpan periodo = agora - data;
            List<long> listaUnidades = new List<long>();

            long resto;
            long totalSegundos = Convert.ToInt64(periodo.TotalSeconds);

            listaUnidades.Add(totalSegundos / 365 / 24 / 60 / 60);
            resto = totalSegundos % (365 * 24 * 60 * 60);

            listaUnidades.Add(resto / 30 / 24 / 60 / 60);
            resto = resto % (30 * 24 * 60 * 60);

            listaUnidades.Add(resto / 7 / 24 / 60 / 60);
            resto = resto % (7 * 24 * 60 * 60);

            listaUnidades.Add(resto / 24 / 60 / 60);
            resto = resto % (24 * 60 * 60);

            listaUnidades.Add(resto / 60 / 60);
            resto = resto % (60 * 60);

            listaUnidades.Add(resto / 60);
            resto = resto % 60;

            listaUnidades.Add(resto);

            List<String> listaUnidadesString = new List<String>();
            foreach (Double unidade in listaUnidades)
            {
                String unidadeStr = unidade.ToString();
                if (unidadeStr.Length < 2) unidadeStr = "0" + unidadeStr;
                listaUnidadesString.Add(unidadeStr);
            }
            return listaUnidadesString;
        }
        private string getUnidadeTempo(int iUnidadesTempo, String unidade)
        {
            if (unidade == "01") return unidadesTempoSingular[iUnidadesTempo];
            else return unidadesTempoPlural[iUnidadesTempo];
        }
        private string montarString(Stack<String> unidadePorExtenso)
        {
            String chequePorExtenso = null;
            while (unidadePorExtenso.Count > 0)
                chequePorExtenso += unidadePorExtenso.Pop();
            return chequePorExtenso;
        }
    }
}