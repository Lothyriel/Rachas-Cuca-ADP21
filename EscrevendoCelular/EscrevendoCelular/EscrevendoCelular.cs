using System;
using System.Collections.Generic;

namespace Escrevendo_Celular
{
    public class EscrevendoCelular
    {
        private Dictionary<char, string> caracteres = new Dictionary<char, string>();
        public EscrevendoCelular()
        {
            caracteres.Add('a', "2");
            caracteres.Add('b', "22");
            caracteres.Add('c', "222");
            caracteres.Add('d', "3");
            caracteres.Add('e', "33");
            caracteres.Add('f', "333");
            caracteres.Add('g', "4");
            caracteres.Add('h', "44");
            caracteres.Add('i', "444");
            caracteres.Add('j', "5");
            caracteres.Add('k', "55");
            caracteres.Add('l', "555");
            caracteres.Add('m', "6");
            caracteres.Add('n', "66");
            caracteres.Add('o', "666");
            caracteres.Add('p', "7");
            caracteres.Add('q', "77");
            caracteres.Add('r', "777");
            caracteres.Add('s', "7777");
            caracteres.Add('t', "8");
            caracteres.Add('u', "88");
            caracteres.Add('v', "888");
            caracteres.Add('w', "9");
            caracteres.Add('x', "99");
            caracteres.Add('y', "999");
            caracteres.Add('z', "9999");
            caracteres.Add(' ', "0");
        }
        public String escrevendoCelular(String fraseEntrada)
        {
            String numerosSaida = "";
            fraseEntrada = fraseEntrada.ToLowerInvariant();
            if (fraseEntrada.Length > 255) return "Frase muito grande!";
            for (int i = 0; i < fraseEntrada.Length; i++)
            {
                String espaco = "";
                if (i > 0)
                {
                    String atual = caracteres[fraseEntrada[i]];
                    String anterior = caracteres[fraseEntrada[i - 1]];
                    if (atual.Contains(anterior))
                        espaco = "_";
                }
                numerosSaida += espaco + caracteres[fraseEntrada[i]];
            }
            return numerosSaida;
        }
    }
}