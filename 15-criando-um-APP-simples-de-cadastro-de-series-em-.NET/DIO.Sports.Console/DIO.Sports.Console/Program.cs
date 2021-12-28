using System;
using DIO.Sports;

namespace DIO.Sports.Console
{
	class Program
	{
		static SportsRepositorio repositorio = new SportsRepositorio();
		static void Main(string[] args)
		{
			string opcaoUsuario = ObterOpcaoUsuario();

			while (opcaoUsuario.ToUpper() != "X")
			{
				switch (opcaoUsuario)
				{
					case "1":
						ListarSports();
						break;
					case "2":
						InserirSports();
						break;
					case "3":
						AtualizarSports();
						break;
					case "4":
						ExcluirSports();
						break;
					case "5":
						VisualizarSports();
						break;
					case "C":
						System.Console.Clear();
						break;

					default:
						throw new ArgumentOutOfRangeException();
				}

				opcaoUsuario = ObterOpcaoUsuario();
			}

			System.Console.WriteLine("Obrigado por assistir.");
			System.Console.ReadLine();
		}

		private static void ExcluirSports()
		{
			System.Console.Write("Digite o id do Esporte: ");
			int indiceSports = int.Parse(System.Console.ReadLine());

			repositorio.Exclui(indiceSports);
		}

		private static void VisualizarSports()
		{
			System.Console.Write("Digite o id do Esporte: ");
			int indiceSports = int.Parse(System.Console.ReadLine());

			var serie = repositorio.RetornaPorId(indiceSports);

			System.Console.WriteLine(serie);
		}

		private static void AtualizarSports()
		{
			System.Console.Write("Digite o id do Esporte: ");
			int indiceSports = int.Parse(System.Console.ReadLine());

			// https://docs.microsoft.com/pt-br/dotnet/api/system.enum.getvalues?view=netcore-3.1
			// https://docs.microsoft.com/pt-br/dotnet/api/system.enum.getname?view=netcore-3.1
			foreach (int i in Enum.GetValues(typeof(Genero)))
			{
				System.Console.WriteLine("{0}-{1}", i, Enum.GetName(typeof(Genero), i));
			}
			System.Console.Write("Digite o gênero esportivo entre as opções acima: ");
			int entradaGenero = int.Parse(System.Console.ReadLine());

			System.Console.Write("Digite o titulo do esporte: ");
			string entradaTitulo = System.Console.ReadLine();

			System.Console.Write("Digite o Ano: ");
			int entradaAno = int.Parse(System.Console.ReadLine());

			System.Console.Write("Digite a Descrição: ");
			string entradaDescricao = System.Console.ReadLine();

			Sports atualizaSports = new Sports(id: indiceSports,
										genero: (Genero)entradaGenero,
										titulo: entradaTitulo,
										ano: entradaAno,
										descricao: entradaDescricao);

			repositorio.Atualiza(indiceSports, atualizaSports);
		}
		private static void ListarSports()
		{
			System.Console.WriteLine("Listar esportes");

			var lista = repositorio.Lista();

			if (lista.Count == 0)
			{
				System.Console.WriteLine("Nenhum esporte cadastrado.");
				return;
			}

			foreach (var sport in lista)
			{
				var excluido = sport.retornaExcluido();

				System.Console.WriteLine("#ID {0}: - {1} {2}", sport.retornaId(), sport.retornaTitulo(), (excluido ? "*Excluído*" : ""));
			}
		}

		private static void InserirSports()
		{
			System.Console.WriteLine("Inserir novo esporte");

			// https://docs.microsoft.com/pt-br/dotnet/api/system.enum.getvalues?view=netcore-3.1
			// https://docs.microsoft.com/pt-br/dotnet/api/system.enum.getname?view=netcore-3.1
			foreach (int i in Enum.GetValues(typeof(Genero)))
			{
				System.Console.WriteLine("{0}-{1}", i, Enum.GetName(typeof(Genero), i));
			}
			System.Console.Write("Digite o gênero esportivo entre as opções acima: ");
			int entradaGenero = int.Parse(System.Console.ReadLine());

			System.Console.Write("Digite o título do esporte: ");
			string entradaTitulo = System.Console.ReadLine();

			System.Console.Write("Digite o Ano: ");
			int entradaAno = int.Parse(System.Console.ReadLine());

			System.Console.Write("Digite a Descrição: ");
			string entradaDescricao = System.Console.ReadLine();

			Sports novoSport = new Sports(id: repositorio.ProximoId(),
										genero: (Genero)entradaGenero,
										titulo: entradaTitulo,
										ano: entradaAno,
										descricao: entradaDescricao);

			repositorio.Insere(novoSport);
		}

		private static string ObterOpcaoUsuario()
		{
			System.Console.WriteLine();
			System.Console.WriteLine("*** DIO Esportes ***");
			System.Console.WriteLine("Informe a opção desejada:");

			System.Console.WriteLine("1- Listar esporte");
			System.Console.WriteLine("2- Inserir novo esporte");
			System.Console.WriteLine("3- Atualizar esporte");
			System.Console.WriteLine("4- Excluir esporte");
			System.Console.WriteLine("5- Visualizar esporte");
			System.Console.WriteLine("C- Limpar Tela");
			System.Console.WriteLine("X- Sair");
			System.Console.WriteLine();

			string opcaoUsuario = System.Console.ReadLine().ToUpper();
			System.Console.WriteLine();
			return opcaoUsuario;
		}
	}
}
