namespace ExemploPOO.models
{
    public class Professor : Pessoa
    {
        public double Salario { get; set; }

         public override void Apresentar()
        {
            System.Console.WriteLine($"O Professor, {Nome}, de {Idade} anos de idade, tem o salario de {Salario} mês.");
        }
    }
}