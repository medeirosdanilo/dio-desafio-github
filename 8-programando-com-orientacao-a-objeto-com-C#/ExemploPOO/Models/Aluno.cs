namespace ExemploPOO.models
{
    public class Aluno : Pessoa
    {
        public int Nota { get; set; }

        public override void Apresentar()
        {
            System.Console.WriteLine($"O Aluno, {Nome}, de {Idade} anos de idade, tirou a nota {Nota} no 2° Semestre de 2021.");
        }
    }
}