using System;
using System.Collections.Generic;
using System.Text;

namespace Tabuleiro
{
    class Peca
    {
        public Posicao posicao { get; set; }
        public Cor cor { get; protected set; }
        public int QtdeMovimentos { get; set; }
        public TabuleiroClass tabuleiro { get; protected set; }

        public Peca(Posicao posicao, TabuleiroClass tab, Cor cor)
        {
            this.posicao = posicao;
            this.cor = cor;
            QtdeMovimentos = 0;
            tabuleiro = tab;

        }

    }
}
