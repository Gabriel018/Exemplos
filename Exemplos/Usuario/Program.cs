
using Usuario;
 class Usuarios
{
    static void Main()
    {
        Users user = new  Users("Adalberto");
 
        Console.WriteLine(user.Getnome()+"\t"+user.GetIdade());
        Console.ReadLine();
    }
}
