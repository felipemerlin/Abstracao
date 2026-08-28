namespace Abstracao
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // CRIANDO O OBJETO (INSTANCIAÇÃO)
            Carro meuFusca = new Carro();
            meuFusca.Marca = "Volkswagen";
            meuFusca.Modelo = "Fusca";
            meuFusca.Ano = 1975;
            meuFusca.Cor = "Azul";

            Carro carroVizinho = new Carro();
            carroVizinho.Marca = "Fiat";
            carroVizinho.Modelo = "Uno";
            carroVizinho.Ano = 2010;
            carroVizinho.Cor = "Prata";

            Produto Caneta = new Produto();
            Caneta.Nome = "Caneta";
            Caneta.Preco = 8.00;
            Caneta.QuantidadeEmEstoque = 10;

            Produto Caderno = new Produto();
            Caderno.Nome = "Caderno";
            Caderno.Preco = 30.00;
            Caderno.QuantidadeEmEstoque = 10;


            Console.WriteLine("Informações do meu carro:");
            meuFusca.ExibirInformacoes();

            Console.WriteLine();

            Console.WriteLine("Informações do carro do vizinho:");
            carroVizinho.ExibirInformacoes();

            Console.WriteLine();

            Console.WriteLine("Informações da caneta:");
            Caneta.ExibirInformacoes();

            Console.WriteLine();

            Console.WriteLine("Informações do caderno:");
            Caderno.ExibirInformacoes();

            Console.ReadKey();
        }
    }
}