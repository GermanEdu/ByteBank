using ByteBank;
using ByteBank.Funcionarios;
using System;

namespace ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            GerenciadorBonificacao gerenciador = new GerenciadorBonificacao();

 

            Console.WriteLine(Funcionario.TotalDeFuncionarios);



            Diretor Eduardo = new Diretor("3237012836");
            Eduardo.Nome = "Eduardo";

            Desenvolvedor Guilherme = new Desenvolvedor("456,564,256-87");

            Guilherme.Nome = "Guilherme";

            gerenciador.Registrar(Guilherme);


            
            gerenciador.Registrar(Eduardo);

            Console.WriteLine(Funcionario.TotalDeFuncionarios);

            Funcionario eduardoteste = Eduardo;

            Eduardo.AumentarSalario();
            Console.WriteLine("Novo salário de roberta: " + Eduardo.Salario);

            Console.WriteLine("Bonificação de uma referencia diretor: " + Eduardo.GetBonificacao());
            Console.WriteLine("Bonificação de uma referencia funcionario: " + Guilherme.GetBonificacao());



     
            Console.WriteLine();
            Console.WriteLine(Eduardo.Nome);
            Console.WriteLine(Eduardo.GetBonificacao());

            Console.WriteLine();

            Console.WriteLine("Total de bonificação: " + gerenciador.getTotalBonificacao());


            Console.ReadLine();


        }
    }
}
