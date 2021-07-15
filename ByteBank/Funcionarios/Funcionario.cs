using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Funcionarios
{
    public abstract class Funcionario
    {
        public static int TotalDeFuncionario { get; private set; }
        public string Nome { get; set; }
        public string CPF { get; set; }
        public double Salario { get; protected set; }

        public Funcionario(String cpf, double salario)
        {
            CPF = cpf;
            Salario = salario;
            TotalDeFuncionario++;
        }
        //Abstract - sempre vai obrigar a implementar na classe filha
        public abstract double GetBonificacao();

        public abstract void AumentarSalario();
        
    }
}
