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

        public abstract bool[,] MovimentosPossiveis();
    }
}
