using ByteBank.Funcionarios;
using ByteBank.Sistemas;
using System;

namespace ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            //CalcularBonificacao();
            UsarSistema();
            Console.ReadLine();
        }

        public static void CalcularBonificacao()
        {
            GerenciadorBonificacao gerenciador = new GerenciadorBonificacao();

            Funcionario pedro = new Designer("013.098.155-93");
            pedro.Nome = "Pedro";
            gerenciador.Registrar(pedro);

            Funcionario paulo = new Auxiliar("027.098.155-93");
            paulo.Nome = "Paulo";
            gerenciador.Registrar(paulo);

            Diretor camila = new Diretor("034.098.155-93");
            camila.Nome = "Camila";
            camila.Senha = "456";
            gerenciador.Registrar(camila);

            GerenteDeContas tiago = new GerenteDeContas("055.098.155-93");
            tiago.Nome = "Tiago";
            tiago.Senha = "123";
            gerenciador.Registrar(tiago);

            Funcionario catia = new Desenvolvedor("145.555.155-93");
            catia.Nome = "Catia";
            gerenciador.Registrar(catia);

            SistemaInterno sistemaInterno = new SistemaInterno();
            sistemaInterno.Logar(tiago, "123");
            sistemaInterno.Logar(camila, "456");



            Console.WriteLine("Total de Bonificações no mês:"+gerenciador.GetTotalBonificacao());
        }

        public static void UsarSistema()
        {

            SistemaInterno sistemaInterno = new SistemaInterno();

            ParceiroComercial parceiro = new ParceiroComercial();
            parceiro.Senha = "123";

            Diretor camila = new Diretor("034.098.155-93");
            camila.Nome = "Camila";
            camila.Senha = "456";
            
            GerenteDeContas tiago = new GerenteDeContas("055.098.155-93");
            tiago.Nome = "Tiago";
            tiago.Senha = "123";

            sistemaInterno.Logar(tiago, "123");
            sistemaInterno.Logar(camila, "456");
            sistemaInterno.Logar(parceiro, "123");




        }
    }
}
