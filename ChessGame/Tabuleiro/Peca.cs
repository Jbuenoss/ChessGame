namespace Tabuleiro
{
    internal class Peca
    {
        public Peca()
        {
        }

        public Posicao posicao { get; set; }
        public Cor cor { get; protected set; }
        public int QuantMovimentos { get; protected set; }
        public TabuleiroGame Tab { get; protected set; }

        public Peca(Posicao posicao, Cor cor, TabuleiroGame tab)
        {
            this.posicao = posicao;
            this.cor = cor;
            Tab = tab;
            QuantMovimentos = 0;
        }
    }
}
