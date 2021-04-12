using System;
using System.Collections.Generic;
using System.Text;
using Tabuleiro;

namespace Xadrez
{
    class PosicaoXadez
    {
        public char Coluna { get; set; }
        public int Linha { get; set; }

        public PosicaoXadez(char coluna, int linha)
        {
            Coluna = coluna;
            Linha = linha;
        }

        public Posicao toPosicao()
        {
            return new Posicao(8 - Linha, Coluna - 'a');
        }


        public override string ToString()
        {
            return "" + Coluna + Linha;
        }
    }
}
