using System.Xml;

namespace Tabuleiro
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
    }
}
