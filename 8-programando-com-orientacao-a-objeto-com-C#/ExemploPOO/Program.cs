using System;
using ExemploPOO.Helper;
using ExemploPOO.Interfaces;
using ExemploPOO.models;

namespace ExemploPOO
{
    public class Program
    {

        static void Main(string[] args)
        {
            var caminho = "C:\\workspace\\dio-desafio-github\\8-programando-com-orientacao-a-objeto-com-C#\\TrabalhandoComArquivos";
            var caminhoPathCombine = Path.Combine(caminho, "Pasta teste 3", "SubPasta Teste 3");

            FileHelper helper = new FileHelper();
            //helper.ListarDiretorios(caminho);
            //helper.ListarArquivosDiretorios(caminho);
            System.Console.WriteLine("Criando diretório: " + caminhoPathCombine);
            helper.CriarDiretorio(caminhoPathCombine);



            
            // INTERFACES
            
            // ICalculadora calc = new Calculadora();
            // System.Console.WriteLine(calc.Dividir(10, 2));



            //CLASSES ABSTRATAS

            // Corrente c = new Corrente();
            // c.Creditar(100);

            // c.exibirSaldo();



            //POLIMORFISMO EM TEMPO DE COMPILAÇÃO

            // Calculadora calc = new Calculadora();
            // System.Console.WriteLine("Resultado da Primeira soma: " + calc.Somar(10, 10));
            // System.Console.WriteLine("Resultado da Segunda soma: " + calc.Somar(10, 10, 10));



            //POLIMORFISMO EM TEMPO DE EXECUÇÃO

            // Professor p1 = new Professor();
            // p1.Nome = "Danilo";
            // p1.Idade = 32;
            // p1.Salario = 5000;

            // p1.Apresentar();



            //POLIMORFISMO

            // //Valores Válidos
            // Retangulo r = new Retangulo();
            // r.DefinirMedidas(30, 30);
            // System.Console.WriteLine($"Área {r.obterArea()}");


            // //Valores Inválidos
            // Retangulo r2 = new Retangulo();
            // r2.DefinirMedidas(0, 0);
            // System.Console.WriteLine($"Área {r2.obterArea()}");



            //ABSTRAÇÃO

            // Pessoa p1 = new Pessoa();

            // p1.Nome = "Bob";

            // p1.Idade = 20;

            // p1.Apresentar();

        }
    }
}

