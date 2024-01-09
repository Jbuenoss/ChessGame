namespace Tabuleiro
{
    abstract internal class Peca
    {
        public Posicao posicao { get; set; }
        public Cor cor { get; protected set; }
        public int QuantMovimentos { get; protected set; }
        public TabuleiroGame Tab { get; protected set; }

        public Peca(Cor cor, TabuleiroGame tab)
        {
            this.posicao = null;
            this.cor = cor;
            Tab = tab;
            QuantMovimentos = 0;
        }

        public void IncrementeMovimento()
        {
            QuantMovimentos++;
        }
        public bool ExisteMovimentoPossiveis()
        {
            bool[,] temp = MovimentosPossiveis();
            for(int i = 0; i < Tab.Linhas; i++)
            {
                for(int j = 0; j < Tab.Colunas; j++)
                {
                    if (temp[i, j])
                    {
                        return true;
                    }
                }
            }
            return false;
        }
        public bool PodeMoverPeca(Posicao pos)
        {
            return MovimentosPossiveis()[pos.Linha, pos.Coluna];
        }

        public abstract bool[,] MovimentosPossiveis();
    }
}
