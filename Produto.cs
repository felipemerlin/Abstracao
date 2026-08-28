namespace Abstracao
{
    public class Produto
    {
        // ATRIBUTOS
        public string Nome;
        public double Preco;
        public int QuantidadeEmEstoque;

        // MÉTODOS (COMPORTAMENTO)
        public void ExibirInformacoes()
        {
            Console.WriteLine($"Nome: {Nome}");
            Console.WriteLine($"Preço: R$ {Preco}");
            Console.WriteLine($"Quantidade em estoque: {QuantidadeEmEstoque}");
            Console.WriteLine("-----------------------------");
        }
    }
}