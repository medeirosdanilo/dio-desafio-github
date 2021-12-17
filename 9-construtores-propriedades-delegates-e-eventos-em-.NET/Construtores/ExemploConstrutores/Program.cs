using System;
using ExemploConstrutores.Models;

namespace ExemploConstrutores
{
    class Program
    {
        public delegate void Operacao(int x, int y);
        static void Main(string[] args)
        {
            Matematica m = new Matematica(10, 20);
            m.Somar();



            //MULTI CAST DELEGATE

            // Abaixo outra maneira de chamar o delegate, passar o metodo para o delegate sem o new
            // Operacao op = Calculadora.Somar;
            // Operacao op = new Operacao(Calculadora.Somar);
            // op += Calculadora.Subtrair;

            // op.Invoke(10, 10);


             



            //CONSTANTES

            // const double pi = 3.14;
            // System.Console.WriteLine(pi);



            // READONLY

            // Data data = new Data();
            // // data.SetMes(12);

            // data.Mes = 11;


            // data.ApresentarMes();



            //CONSTRUTOR NA HERANÇA

            //    Aluno p1 = new Aluno("Danilo", "Medeiros", "Teste");
            //    p1.Apresentar();

        }
    }
}
