using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Funcionarios
{
    // : o diretor herda da classe Funcionario seus atributos, no caso é uma classe devivada da classe funcionario  
    public class Diretor : Funcionario
    {


        public Diretor(string cpf) : base(5000, cpf)
        {
            Console.WriteLine("Criando Diretor: ");
        }


        public override void  AumentarSalario()
        {

            Salario *= 1.15; // salario é igual a 15 %

        }






        public override double GetBonificacao()
        {

            return Salario * 0.5;
           
        }

    }
}
