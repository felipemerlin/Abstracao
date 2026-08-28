namespace Abstracao
{
    internal class Jogador
    {
        //ATRIBUTOS
        public string Nome;
        public string Posicao;
        public int NumCamisa;

        //METODOS (COMPORTAMENTO)
        public Jogador(string nome, string posicao, int numeroCamisa)
        {
            Nome = nome;
            Posicao = posicao;
            NumCamisa = numeroCamisa;
        }
    }
}