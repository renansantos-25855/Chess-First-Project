using System;
using System.Collections.Generic;
using System.Text;
using Tabuleiro;

namespace Xadrez
{
    class Rei : Peca
    {
        public Rei(TabuleiroClass tab, Cor cor) : base(tab, cor)
        {

        }

        private bool podeMover(Posicao pos)
        {
            Peca p = tabuleiro.peca(pos);
            return p == null || p.cor != this.cor;
        }
        public override bool[,] MovimentosPossiveis()
        {
            bool[,] mat = new bool[tabuleiro.Linhas, tabuleiro.Colunas];
            Posicao pos = new Posicao(0, 0);


            //Acima

            pos.definirValores(posicao.Linha - 1, posicao.Coluna);

            if(tabuleiro.posicaoValida(pos) && podeMover(pos))
            {
                mat[pos.Linha, pos.Coluna] = true;
            }

            //Nordeste

            pos.definirValores(posicao.Linha - 1, posicao.Coluna + 1);

            if (tabuleiro.posicaoValida(pos) && podeMover(pos))
            {
                mat[pos.Linha, pos.Coluna] = true;
            }

            //Direita

            pos.definirValores(posicao.Linha, posicao.Coluna + 1);

            if (tabuleiro.posicaoValida(pos) && podeMover(pos))
            {
                mat[pos.Linha, pos.Coluna] = true;
            }

            //Suldeste

            pos.definirValores(posicao.Linha + 1, posicao.Coluna + 1);

            if (tabuleiro.posicaoValida(pos) && podeMover(pos))
            {
                mat[pos.Linha, pos.Coluna] = true;
            }

            //Abaixo

            pos.definirValores(posicao.Linha + 1, posicao.Coluna);

            if (tabuleiro.posicaoValida(pos) && podeMover(pos))
            {
                mat[pos.Linha, pos.Coluna] = true;
            }

            // Suldoeste

            pos.definirValores(posicao.Linha + 1, posicao.Coluna - 1);

            if (tabuleiro.posicaoValida(pos) && podeMover(pos))
            {
                mat[pos.Linha, pos.Coluna] = true;
            }

            //Esquerda

            pos.definirValores(posicao.Linha, posicao.Coluna - 1);

            if (tabuleiro.posicaoValida(pos) && podeMover(pos))
            {
                mat[pos.Linha, pos.Coluna] = true;
            }

            //Noroeste

            pos.definirValores(posicao.Linha - 1, posicao.Coluna -1);

            if (tabuleiro.posicaoValida(pos) && podeMover(pos))
            {
                mat[pos.Linha, pos.Coluna] = true;
            }

            return mat;
        }


        public override string ToString()
        {
            return "R";
        }
    }
}
