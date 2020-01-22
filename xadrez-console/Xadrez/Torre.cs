using xadrez_console.Tabuleiro;
using xadrez_console.Tabuleiro.Enum;

namespace xadrez_console.Xadrez
{
    class Torre : Peca
    {
        public Torre(Tab tab, Cor cor) : base(cor, tab)
        {
        }

        public override string ToString()
        {
            return "T";
        }
    }
}
