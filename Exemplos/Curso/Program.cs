
using Curso;

public class curso
{
    static void Main(string[] args)
    {
        Matricula nova_matricula = new Matricula();
        nova_matricula.nome = "Adalberto";
        nova_matricula.curso = "Jiu Jitsu";
        nova_matricula.matricula_aluno = 2345;
        Console.WriteLine("Academia Fight Matricula");
        Console.WriteLine("Nome\t\tCurso\t\tMatricula");
        Console.WriteLine(nova_matricula.nome + "\t" + nova_matricula.curso + "\t" + nova_matricula.matricula_aluno);
        Console.ReadLine();
    }
}



