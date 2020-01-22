using xadrez_console.Tabuleiro.Enum;

namespace xadrez_console.Tabuleiro
{
    class Peca
    {
        public Posicao Posicao { get; set; }
        public Cor Cor { get; protected set; }
        public int QtdMovimentos { get; protected set; }
        public Tab Tab { get; set; }

        public Peca(Tab tab, Cor cor)
        {
            Posicao = null;
            Cor = cor;
            QtdMovimentos = 0;
            Tab = tab;
        }
    }
}
