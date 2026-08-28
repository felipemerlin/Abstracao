namespace Abstracao
{
    public class Aluno
    {
        //ATRIBUTOS
        public string Nome;
        public int Matricula;
        public double Nota1;
        public double Nota2;

        //METODOS (COMPORTAMENTO)
        public void CalcularMedia()
        {
            double Media = (Nota1 + Nota2) / 2;
            Console.WriteLine($"O nome do aluno é: {Nome}");
            Console.WriteLine($"O matrícula do aluno é: {Matricula}");
            Console.WriteLine($"A primeira nota do aluno é: {Nota1}");
            Console.WriteLine($"A segunda nota do aluno é: {Nota2}");
            Console.WriteLine($"A média do aluno é: {Media}");
        }
    }
}