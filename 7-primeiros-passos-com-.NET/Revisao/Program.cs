namespace Revisao
{
    class Program
    {
        static void Main(string[] args)
        {
            Aluno[] alunos = new Aluno[5];
            var indiceAluno = 0;
            string opcaoUsuario = ObterOpcaoUsuario();

            while (opcaoUsuario.ToUpper() != "X")
            {
                switch (opcaoUsuario)
                {
                    case "1":
                        Console.WriteLine("Insira o nome do aluno: ");
                        Aluno aluno = new Aluno();
                        aluno.Nome = Console.ReadLine();

                        Console.WriteLine();
                        Console.WriteLine("Informe a nota do aluno");

                        if (decimal.TryParse(Console.ReadLine(), out decimal nota))
                        {
                            aluno.Nota = nota;
                        }
                        else
                        {
                            throw new ArgumentException("O Valor deve ser decimal!");
                        }

                        alunos[indiceAluno] = aluno;
                        indiceAluno++;
                        break;

                    case "2":
                        foreach (var a in alunos)
                        {
                            if (!string.IsNullOrEmpty(a.Nome))
                            {
                                Console.WriteLine($"ALUNO: {a.Nome} - NOTA: {a.Nota}");
                            }
                        }
                        break;

                    case "3":
                        //TODO: Calcular média geral
                        break;

                    default:
                        throw new ArgumentOutOfRangeException();
                }

                opcaoUsuario = ObterOpcaoUsuario();

            }
        }

        private static string ObterOpcaoUsuario()
        {
            Console.WriteLine();
            Console.WriteLine("Bem vindo ao Programa, escolha uma das opções abaixo: ");
            Console.WriteLine("1 - Inserir Novo Aluno");
            Console.WriteLine("2 - Listar Alunos");
            Console.WriteLine("3 - Calcular Média Geral");
            Console.WriteLine("X - Sair");
            Console.WriteLine();

            string? opcaoUsuario = Console.ReadLine();
            Console.WriteLine();
            return opcaoUsuario;
        }
    }
}

