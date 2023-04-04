using ByteBank3.Funcionarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ByteBank3
{
    internal class Program
    {
        static void Main(string[] args)
        {

            GerenciadorBonificacao gerenciador = new GerenciadorBonificacao();

            Funcionario carlos = new Funcionario();

            carlos.Nome = "Carlos";
            carlos.CPF = "123456789";
            carlos.Salario = 2000;

            gerenciador.Registrar(carlos);


            Diretor Roberta = new Diretor();
            Roberta.Nome = "Roberta";
            Roberta.CPF = "1234567898";
            Roberta.Salario = 5000;

            Funcionario robertaTeste = Roberta;

            Console.WriteLine("Bonificação de uma referencia de Diretor: " + Roberta.GetBonificacao());
            Console.WriteLine("Bonificação de uma referencia de funcionario: " + robertaTeste.GetBonificacao());

            gerenciador.Registrar(Roberta);
            Console.WriteLine(Roberta.Nome);
            Console.WriteLine(Roberta.GetBonificacao());

            Console.WriteLine(carlos.Nome);
            Console.WriteLine(carlos.GetBonificacao());

            
            Console.WriteLine("O total e:" + gerenciador.GetTotalBonicacao());

            Console.ReadLine();
        }
    }
}
