

using System.Security.Cryptography.X509Certificates;


Funcionario f1 = new Funcionario();
f1.Gravar();
Console.WriteLine(f1.nome);
Console.ReadLine();
abstract class Pessoa
{
    public string nome;
    public int idade;
    public string Email;

    public abstract void Gravar();
    
}

 class Funcionario : Pessoa
{
    public override void Gravar()
    {
        nome = "duke";
        idade = 32;
        Email = "duke@gmail.com";
    }
}



