﻿namespace Tabuleiro
{
    internal class TabuleiroGame
    {
        public int Linhas { get; set; }
        public int Colunas { get; set; }
        private Peca[,] Pecas;

        public TabuleiroGame(int linhas, int colunas)
        {
            Linhas = linhas;
            Colunas = colunas;
            Pecas = new Peca[linhas, colunas];
        }

        public Peca peca(int linha, int coluna)
        {
            return Pecas[linha, coluna];
        }
        public Peca peca(Posicao pos)
        {
            return Pecas[pos.Linha, pos.Coluna];
        }

        public void ColocarPeca(Peca peca, Posicao posicao)
        {
            if (ExistePeca(posicao))
            {
                throw new TabuleiroException("Já existe uma peça nessa posição!");
            }
            Pecas[posicao.Linha, posicao.Coluna] = peca;
            peca.posicao = posicao;
        }

        public Peca RetirarPeca(Posicao pos)
        {
            if(peca(pos) == null)
            {
                return null;
            }
            Peca aux = peca(pos);
            aux.posicao = null;
            Pecas[pos.Linha, pos.Coluna] = null;
            return aux;
        }

        public bool ExistePeca(Posicao pos)
        {
            ValidarPosicao(pos);    //corta o programa se acontecer
            return peca(pos) != null;
        }

        public bool PosicaoValida(Posicao pos)
        {
            if(pos.Linha<0 || pos.Linha>= Linhas || pos.Coluna<0 || pos.Coluna>= Colunas)
            {
                return false;
            }
            return true;
        }
        public void ValidarPosicao(Posicao pos)
        {
            if (!PosicaoValida(pos))
            {
                throw new TabuleiroException("Posição Inválida!");
            }
        }
    }
}
