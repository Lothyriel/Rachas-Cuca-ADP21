using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robô_AEB
{
    class Robo
    {
        private int x;
        private int y;
        private char direcao;

        public Robo(int x, int y, char direcao)
        {
            this.x = x;
            this.y = y;
            this.direcao = direcao;
        }
        public int getX()
        {
            return x;
        }
        public int getY()
        {
            return y;
        }
        public override string ToString()
        {
            return "X: " + x + " Y: " + y + " Direção: " + char.ToUpper(direcao);
        }
        public void move()
        {
            if (direcao == 'N') { y++; }
            if (direcao == 'S') { y--; }                //professor acho q x como altura ficaria mais claro pra remeter as coordenadas
            if (direcao == 'L') { x++; }                //de matrizes mas deixei como o arquivo pedia
            if (direcao == 'O') { x--; }
        }
        public void esquerda()
        {
            if (direcao == 'N') { direcao = 'O'; }
            else
            if (direcao == 'S') { direcao = 'L'; }
            else
            if (direcao == 'L') { direcao = 'N'; }
            else
            if (direcao == 'O') { direcao = 'S'; }
        }
        public void direita()
        {
            if (direcao == 'N') { direcao = 'L'; }
            else
            if (direcao == 'S') { direcao = 'O'; }
            else
            if (direcao == 'L') { direcao = 'S'; }
            else
            if (direcao == 'O') { direcao = 'N'; }
        }
    }
}
