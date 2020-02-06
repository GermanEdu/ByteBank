using ByteBank;
using ByteBank.Funcionarios;
using ByteBank.Sistemas;
using System;

namespace ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {

            UsarSistema();

            GerenciadorBonificacao gerenciador = new GerenciadorBonificacao();



            Console.WriteLine(Funcionario.TotalDeFuncionarios);



            Diretor Eduardo = new Diretor("3237012836");
            Eduardo.Nome = "Eduardo Germano";

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


        }
        
            public static void UsarSistema()
        {
            SistemaLogin sistemalogin = new SistemaLogin();
            Diretor Roberta = new Diretor("45646546");
            Roberta.Nome = "Roberta";
            Roberta.Senha = "123";

           // Funcionario Eduardo = new Funcionario(1500,"222.145.156-78");



            sistemalogin.Logar(Roberta, "123");

            sistemalogin.Logar(Roberta, "abc");



            Console.ReadLine();
        }

       
        
    }


}

