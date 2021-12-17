namespace ExemploConstrutores.Models
{
    public class Pessoa
    {
        private readonly string nome;
        private readonly string sobrenome;
        public Pessoa()
        {
            nome = string.Empty;
            sobrenome = string.Empty;
        }

        public Pessoa(string nome, string sobrenome)
        {
            this.nome = nome;
            this.sobrenome = sobrenome;
            System.Console.WriteLine("Construtor classe Pessoa");
        }

        public void Apresentar()
        {
            System.Console.WriteLine($"Olá, meu nome é: {nome} {sobrenome}");
        }
    }
}