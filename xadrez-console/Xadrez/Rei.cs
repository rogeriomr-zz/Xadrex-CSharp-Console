using xadrez_console.Tabuleiro;
using xadrez_console.Tabuleiro.Enum;

namespace xadrez_console.Xadrez
{
    class Rei : Peca
    {
        public Rei(Tab tab, Cor cor) : base(cor, tab)
        {
        }

        public override string ToString()
        {
            return "R";
        }
    }
}
