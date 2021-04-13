using System;
using System.Collections.Generic;
using System.Text;

namespace Tabuleiro
{
    abstract class Peca
    {
        public Posicao posicao { get; set; }
        public Cor cor { get; protected set; }
        public int QtdeMovimentos { get; set; }
        public TabuleiroClass tabuleiro { get; protected set; }

        public Peca(TabuleiroClass tab, Cor cor)
        {
            this.posicao = null;
            this.cor = cor;
            QtdeMovimentos = 0;
            tabuleiro = tab;

        }

        public void incrementarQtdeMovimentos()
        {
            QtdeMovimentos++;
        }

        public abstract bool[,] MovimentosPossiveis();
    }
}
