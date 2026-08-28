namespace Abstracao
{
    internal class Time
    {
        //ATRIBUTOS
        public string NomeDoTime;
        public List<Jogador> ListaDeJogadores;
        public Time(string nomeDoTime)
        {
            NomeDoTime = nomeDoTime;
            ListaDeJogadores = new List<Jogador>();
        }

        // MÉTODOS (COMPORTAMENTO)
        public void AdicionarJogador(Jogador jogador)
        {
            ListaDeJogadores.Add(jogador);
        }

        public void ListarJogadores()
        {
            Console.WriteLine();
            Console.WriteLine($"Escalação da {NomeDoTime}:");
            foreach (Jogador jogador in ListaDeJogadores)
            {
                Console.WriteLine($"- {jogador.Nome} | Posição: {jogador.Posicao} | Número da camisa: {jogador.NumCamisa}");
            }
        }
    }
}