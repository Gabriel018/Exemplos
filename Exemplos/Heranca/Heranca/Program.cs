
using static Heranca.Funcionario;

namespace Heranca
{
    class empresa
    {
        static void Main(string[] args)
        {

            Cadastro cad1 = new Cadastro("Aderbal",12345689);
            
            Console.WriteLine("Nome:"+ cad1.nome+"\t"+"Cpf:\t"+cad1.cpf+"\t"+"Situaçao\t"+ cad1.Situacao());
        }
    }
}


