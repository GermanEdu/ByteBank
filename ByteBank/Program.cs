using ByteBank.Funcionarios;
using System;

namespace ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            GerenciadorBonificacao gerenciador = new GerenciadorBonificacao();

            Funcionario Algum = new Funcionario(2500, "586.568.235-78");
            Algum.Nome = "Carlos";
         



            Algum.AumentarSalario();
            Console.WriteLine("Novo Salario: " + Algum.Salario);




            Console.WriteLine(Funcionario.TotalDeFuncionarios);

            gerenciador.Registrar(Algum);

           

            Diretor Eduardo = new Diretor("3237012836");
            Eduardo.Nome = "Eduardo";  
            
            gerenciador.Registrar(Eduardo);

            Console.WriteLine(Funcionario.TotalDeFuncionarios);

            Funcionario eduardoteste = Eduardo;

            Eduardo.AumentarSalario();
            Console.WriteLine("Novo salário de roberta: " + Eduardo.Salario);

            Console.WriteLine("Bonificação de uma referencia diretor: " + Eduardo.GetBonificacao());
            Console.WriteLine("Bonificação de uma referencia funcionario: " + Algum.GetBonificacao());


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
