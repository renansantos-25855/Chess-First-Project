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

        public void decrementarQtdeMovimentos()
        {
            QtdeMovimentos--;
        }

        public bool existeMovimentosPossiveis()
        {
            bool[,] mat = MovimentosPossiveis();

            for (int i = 0; i < tabuleiro.Linhas; i++)
            {
                for (int j = 0; j < tabuleiro.Colunas; j++)
                {
                    if (mat[i, j])
                    {
                        return true;
                    }
                }
            }

            return false;
        }

        public bool movimentoPossivel(Posicao pos)
        {
            return MovimentosPossiveis()[pos.Linha, pos.Coluna];
        }

        public abstract bool[,] MovimentosPossiveis();
    }
}
