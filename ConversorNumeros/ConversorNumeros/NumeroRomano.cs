using System;
using System.Collections.Generic;

namespace ConversorNumerosRomanos_Arabicos
{
    public class NumeroRomano
    {
        private Dictionary<String, int> algarismosRomanos = new Dictionary<string, int>()
        {{ "x",10000 },{ "v",5000 },{ "i",1000 },{ "M",1000 },{ "D",500 },{ "C",100},{ "L",50 },{ "X",10},{ "V",5},{ "I",1},{ "0",0},};

        public String numeroRomano;

        public int paraArabico()
        {
            substituirAlgarismoMacrom(ref numeroRomano);
            int numeroArabico = 0;
            for (int i = 0; i < numeroRomano.Length; i++)
            {
                Char algarismo = numeroRomano[i];
                Char algarismoAnterior = i > 0 ? numeroRomano[i - 1] : '0';

                if (temSubtracaoLadoEsquerdo(algarismo, algarismoAnterior))
                    numeroArabico += inserirLadoEsquerdo(algarismo, algarismoAnterior);
                else
                    numeroArabico += converterAlgarismoParaArabico(algarismo);
            }
            return numeroArabico;
        }
        private void substituirAlgarismoMacrom(ref string numeroRomano)
        {
            numeroRomano = numeroRomano.Replace("Ī", "i");
            numeroRomano = numeroRomano.Replace("V̄", "v");
            numeroRomano = numeroRomano.Replace("X̄", "x");
        }
        private int inserirLadoEsquerdo(char algarismo, char algarismoAnterior)
        {
            return converterAlgarismoParaArabico(algarismo) - 2 * converterAlgarismoParaArabico(algarismoAnterior);
        }
        private bool temSubtracaoLadoEsquerdo(char algarismo, char algarismoAnterior)
        {
            return converterAlgarismoParaArabico(algarismoAnterior) < converterAlgarismoParaArabico(algarismo);
        }
        private int converterAlgarismoParaArabico(char letra)
        {
            return algarismosRomanos[letra.ToString()];
        }
    }
}
