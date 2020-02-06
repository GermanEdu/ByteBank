using ByteBank.Funcionarios;
using System;

namespace ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            GerenciadorBonificacao gerenciador = new GerenciadorBonificacao();

            Funcionario Algum = new Funcionario();

            Algum.Nome = "Carlos";
            Algum.Salario = 2000;

            gerenciador.Registrar(Algum);

            Funcionario pedro = new Diretor();


            Diretor Eduardo = new Diretor();
            Eduardo.Nome = "Eduardo";
            Eduardo.Salario = 5000;
            gerenciador.Registrar(Eduardo);


            Funcionario eduardoteste = Eduardo;

            Console.WriteLine("Bonificação de uma referencia diretor: " + Eduardo.GetBonificacao());
            Console.WriteLine("Bonificação de uma referencia funcionario: " + eduardoteste.GetBonificacao());


            Console.WriteLine(Algum.Nome);
            Console.WriteLine(Algum.GetBonificacao());
            Console.WriteLine();
            Console.WriteLine(Eduardo.Nome);
            Console.WriteLine(Eduardo.GetBonificacao());

            Console.WriteLine();

            Console.WriteLine("Total de bonificação: " + gerenciador.getTotalBonificacao());


            Console.ReadLine();


        }
    }
}
