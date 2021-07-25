﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace Poker
{
    public class Jogador
    {
        public Mao mao;
        public List<Carta> baralho;
        public Jogador(String strBaralho)
        {
            baralho = getCartas(strBaralho);
            mao = new Mao(baralho);
        }
        public Jogador(List<Carta> baralho)
        {
            this.baralho = baralho;
            mao = new Mao(baralho);
        }
        private static List<Carta> getCartas(String strBaralho)
        {
            List<Carta> baralho = new List<Carta>();
            var cartas = strBaralho.Split(' ');
            cartas.ToList().ForEach(x => baralho.Add(Carta.getCarta(x)));
            return baralho;
        }
        public override string ToString()
        {
            string baralho = "";
            this.baralho.ForEach(c => baralho += c + " ");
            baralho += mao.classificacao;
            return baralho;
        }
    }
}
