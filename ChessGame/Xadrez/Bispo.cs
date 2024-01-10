using Tabuleiro;
namespace Xadrez
{
    internal class Bispo : Peca
    {
        public Bispo(TabuleiroGame tab, Cor cor) : base(cor, tab)
        {
        }
        public override string ToString()
        {
            return "B";
        }
        private bool PodeMover(Posicao pos)
        {
            Peca p = Tab.peca(pos);
            return p == null || p.cor != cor;
        }
        public override bool[,] MovimentosPossiveis()
        {
            bool[,] mat = new bool[Tab.Linhas, Tab.Colunas];

            Posicao pos = new Posicao(0, 0);

            //NO
            pos.DefinirValores(posicao.Linha - 1, posicao.Coluna-1);
            while (Tab.PosicaoValida(pos) && PodeMover(pos))
            {
                mat[pos.Linha, pos.Coluna] = true;
                if (Tab.peca(pos) != null && Tab.peca(pos).cor != cor)
                {
                    break;
                }
                pos.DefinirValores((pos.Linha - 1), (pos.Coluna - 1));
            }
            //NE
            pos.DefinirValores(posicao.Linha -1, posicao.Coluna+1);
            while (Tab.PosicaoValida(pos) && PodeMover(pos))
            {
                mat[pos.Linha, pos.Coluna] = true;
                if (Tab.peca(pos) != null && Tab.peca(pos).cor != cor)
                {
                    break;
                }
                pos.DefinirValores(pos.Linha - 1, pos.Coluna + 1);
            }
            //SE
            pos.DefinirValores(pos.Linha+1, posicao.Coluna + 1);
            while (Tab.PosicaoValida(pos) && PodeMover(pos))
            {
                mat[pos.Linha, pos.Coluna] = true;
                if (Tab.peca(pos) != null && Tab.peca(pos).cor != cor)
                {
                    break;
                }
                pos.DefinirValores(pos.Linha + 1, pos.Coluna + 1);
            }
            //SO
            pos.DefinirValores(posicao.Linha+1, (pos.Coluna - 1));
            while (Tab.PosicaoValida(pos) && PodeMover(pos))
            {
                mat[pos.Linha, pos.Coluna] = true;
                if (Tab.peca(pos) != null && Tab.peca(pos).cor != cor)
                {
                    break;
                }
                pos.DefinirValores(pos.Linha + 1, pos.Coluna - 1);
            }
            return mat;
        }

        
    }
}
