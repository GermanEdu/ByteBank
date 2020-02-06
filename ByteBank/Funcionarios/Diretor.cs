using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Funcionarios
{
    // : o diretor herda da classe Funcionario seus atrubutos, no caso é uma classe devivada da classe funcionario  
    public class Diretor : Funcionario
    {


        public double GetBonificacao()
        {
              return Salario;
           
        }

    }
}
