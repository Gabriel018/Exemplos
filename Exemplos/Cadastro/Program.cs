

namespace Cadatro;


class Cadastro

{

    enum categoria { Açao=1, Aventura, Horror, Cult, Romance }

  
    public static void Main(string[] args)
    {   
        inicio:
        Console.Clear();
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("Selecione  o filme desejado:");
        Console.WriteLine("1-açao\n2-Aventura\n3-Horror\n4-Cult\n5-Romance");
        int index = int.Parse(Console.ReadLine());
        categoria operacao = (categoria)index;

          switch(operacao)
        {
            case categoria.Açao: Console.WriteLine("Filmes de Açao");
                break;
            case categoria.Aventura: Console.WriteLine("Filmes de ventura");
                break;
            case categoria.Horror: Console.WriteLine("Filmes de Horror");
                break;
            case categoria.Cult: Console.WriteLine("Filmes Cult");
                break;
            case categoria.Romance: Console.WriteLine("Filmes de Romance");
                break;

        }
         Console.WriteLine("Deseja Continuar: [S/N]");
        char escolha=char.Parse(Console.ReadLine());
        if (escolha == 'S' || escolha == 's') 
        {
            goto inicio;
        }
        else
        {
            Console.Clear();
        }
     }

   
 }


