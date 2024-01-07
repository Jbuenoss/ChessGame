using Tabuleiro;
namespace Xadrez
{
    internal class Torre : Peca
    {
        public Torre(TabuleiroGame tab, Cor cor) : base(cor, tab)
        {

        }

        public override string ToString()
        {
            return "T";
        }
    }
}
