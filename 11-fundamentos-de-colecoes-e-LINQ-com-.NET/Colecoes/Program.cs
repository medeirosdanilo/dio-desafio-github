using System;
using System.Collections.Generic;
using Colecoes.Helper;

namespace Colecoes
{
    class program
    {
        static void Main(string[] args)
        {
            int[] arrayNumeros = new int[10] {100, 1, 4, 0, 8, 15, 19, 19, 4, 100 };

            var minimo = arrayNumeros.Min();
            var maximo = arrayNumeros.Max();
            var medio = arrayNumeros.Average();
            var soma = arrayNumeros.Sum();
            var arrayUnico = arrayNumeros.Distinct().ToArray();

            System.Console.WriteLine($"Mínimo: {minimo}");
            System.Console.WriteLine($"Máximo: {maximo}");
            System.Console.WriteLine($"Médio: {medio}");
            System.Console.WriteLine($"Soma: {soma}");
        System.Console.WriteLine($"Array original: {string.Join(", ", arrayNumeros)}");
        System.Console.WriteLine($"Array distinto: {string.Join(", ", arrayUnico)}");




            //VALORES PARES COM QUERY E METODO LINQ

            // var numerosParesQuery = 
            //     from num in arrayNumeros
            //     where num % 2 == 0
            //     orderby num
            //     select num;

            // var numerosParesMetodo = arrayNumeros.Where(x => x % 2 == 0).OrderBy(x => x).ToList();

            // System.Console.WriteLine("Numeros pares Query: " + string.Join(", ", numerosParesQuery));
            // System.Console.WriteLine("Numeros pares Método: " + string.Join(", ", numerosParesMetodo));



            //ACESSANDO DICIONARIO DE FORMA SEGURA

            // Dictionary<string, string> estados = new Dictionary<string, string>();

            // estados.Add("SP", "São Paulo");
            // estados.Add("RJ", "Rio de Janeiro");
            // estados.Add("PR", "Paraná");

            // foreach (KeyValuePair<string, string> item in estados)
            // {
            //     //System.Console.WriteLine($"Chave: {item.Key}, Valor: {item.Value}");
            // }

            //var teste = estados["SC"];

            // string valorProcurado = "SC";

            // if (estados.TryGetValue(valorProcurado, out string estadoEncontrado))
            // {
            //     System.Console.WriteLine(estadoEncontrado);
            // }
            // else
            // {
            //     System.Console.WriteLine($"Chave {valorProcurado} não existe no dicionário");
            // }


            //REMOVENDO VALORES

            // System.Console.WriteLine($"Removendo o valor {valorProcurado}");

            // estados.Remove(valorProcurado);

            // foreach (KeyValuePair<string, string> item in estados)
            // {
            //     System.Console.WriteLine($"Chave: {item.Key}, Valor: {item.Value}");
            // }

            //ATUALIZANDO VALORES

            // System.Console.WriteLine("Valor original");
            // System.Console.WriteLine(estados[valorProcurado]);

            // estados[valorProcurado] = "RJ - Teste atualização";

            // System.Console.WriteLine("Valor atualizado");
            // System.Console.WriteLine(estados[valorProcurado]);


            //TRABALHANDO COM PILHAS

            // Stack<string> pilhaLivro = new Stack<string>();

            // pilhaLivro.Push(".NET");
            // pilhaLivro.Push("DDD");
            // pilhaLivro.Push("Código Limpo");

            // System.Console.WriteLine($"Livros para leitura {pilhaLivro.Count}");

            // while (pilhaLivro.Count > 0)
            // {
            //     System.Console.WriteLine($"Próximo livro para leitura: {pilhaLivro.Peek()}");
            //     System.Console.WriteLine($"{pilhaLivro.Pop()} lido com sucesso!");
            // }

            // System.Console.WriteLine($"Livros para leitura {pilhaLivro.Count}");

            //TRABALHANDO COM FILAS

            // Queue<string> fila = new Queue<string>();

            // fila.Enqueue("Danilo");
            // fila.Enqueue("Gabi");
            // fila.Enqueue("Gil");

            // System.Console.WriteLine($"Pessoas na fila {fila.Count}");

            // while (fila.Count > 0)
            // {
            //     System.Console.WriteLine($"Vez de {fila.Peek()}");
            //     System.Console.WriteLine($"{fila.Dequeue()} atendido!");
            // }

            // System.Console.WriteLine($"Pessoas na fila {fila.Count}");




            // OperacoesLista opLista = new OperacoesLista();
            // List<string> estados = new List<string>{"SP", "RJ", "SC"};
            // string[] estadosArray = new string[2] {"MG", "RS"};

            // System.Console.WriteLine($"Quantidade de elementos na lista: {estados.Count}");

            // opLista.ImprimirListaString(estados);

            // // estados.Remove("RJ");
            // // System.Console.WriteLine("");
            // // System.Console.WriteLine("Após remoção do elemento: ");

            // // estados.AddRange(estadosArray);

            // estados.Insert(1, "PR");

            // opLista.ImprimirListaString(estados);



            //LAÇO FOR PARA INDICE DO ELEMENTO
            // foreach (var item in estados)
            // {
            //     System.Console.WriteLine(item);
            // }

            // OperacoesArray op = new OperacoesArray();
            // int[] array = new int[5] { 6, 3, 8, 1, 9 };
            // //int[] arrayCopia = new int[10];
            // string[] arrayString = op.ConverterParaArrayString(array);
            // int valorProcurado = 9;



            //REDIMENSIONAR ARRAY

            // System.Console.WriteLine($"Capacidade total do array: {array.Length}");

            // op.RedimensionarArray(ref array, array.Length * 2);

            // System.Console.WriteLine($"Capacidade atual do array após redimensionar: {array.Length}");



            //ENCONTRA INDICE VALOR ARRAY

            // int indice = op.ObterIndice(array, valorProcurado);

            // if (indice > -1)
            // {
            //     System.Console.WriteLine("O Indice do elemento {0} é: {1}", valorProcurado, indice);   
            // }
            // else
            // {
            //     System.Console.WriteLine("Valor não existente no array");
            // }



            //ENCONTRA ELEMENTO ARRAY

            // int valorAchado = op.ObterValor(array, valorProcurado);

            // if (valorAchado > 0)
            // {
            //     System.Console.WriteLine("Encontrei o valor!");
            // }
            // else
            // {
            //     System.Console.WriteLine("Não encontrei o valor procurado.");
            // }



            // VERIFICA ELEMENTOS ARRAY

            // bool TodosMaiorQue = op.TodosMaiorQue(array, valorProcurado);

            // if(TodosMaiorQue)
            // {
            //     System.Console.WriteLine("Todos os valores são maior que " + valorProcurado);
            // }
            // else
            // {
            //     System.Console.WriteLine("Existe valores que não são maiores do que " + valorProcurado);
            // }



            //VERIFICA EXISTENCIA ARRAY

            // int valorProcurado = 10;
            // bool existe = op.Existe(array, valorProcurado);

            // if (existe)
            // {
            //     System.Console.WriteLine("Encontrei o valor procurado: " + valorProcurado);
            // }
            // else
            // {
            //     System.Console.WriteLine("Não encontrei o valor procurado: " + valorProcurado);
            // }


            //COPIANDO ARRAY

            // System.Console.WriteLine("Array antes da Copia: ");
            // op.ImprimirArray(arrayCopia);

            // op.Copiar(ref array, ref arrayCopia);
            // System.Console.WriteLine("Array após a copia: ");
            // op.ImprimirArray(arrayCopia);

            //ARRAY ORDENADO

            // System.Console.WriteLine("Array Original: ");
            // op.ImprimirArray(array);

            // // op.OrdenarBubbleSort(ref array);
            // op.Ordenar(ref array);

            // System.Console.WriteLine("Array Ordenado: ");
            // op.ImprimirArray(array);

            //ARRAY MULTIDIMENSIONAL

            // int[,] matriz = new int[4, 2]
            // {
            //     { 8, 8 },
            //     { 10, 20 },
            //     { 50, 100 },
            //     { 90, 200 },
            // };

            // for (int i = 0; i < matriz.GetLength(0); i++)
            // {
            //     for (int j = 0; j < matriz.GetLength(1); j++)
            //     {
            //         System.Console.WriteLine(matriz[i, j]);
            //     }
            // }



            //ARRAYS

            // int[] arrayInteiros = new int[3];

            // arrayInteiros[0] = 10;
            // arrayInteiros[1] = 20;
            // arrayInteiros[2] = 30;

            // System.Console.WriteLine("Percorrendo o array pelo laço For");
            // for (int i = 0; i < arrayInteiros.Length; i++)
            // {
            //     System.Console.WriteLine(arrayInteiros[i]);
            // }

            // System.Console.WriteLine("Percorrendo o array pelo laço ForEach");
            // foreach (int item in arrayInteiros)
            // {
            //     System.Console.WriteLine(item);
            // }
        }
    }
}