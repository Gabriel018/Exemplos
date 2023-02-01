
class test
{
    static void Main(string[] args)
    {
        Pessoa pessoa1 = new Pessoa("Gabriel",12,"gabriel@gmail.com");
        Pessoa pessoa2 = new Pessoa("Rafael", 17, "grfal@gmail.com");
        Pessoa pessoa3 = new Pessoa("Adalberto", 15, "adal@gmail.com");
        Pessoa pessoa4 = new Pessoa("Lucas", 14, "luc@gmail.com");
        Pessoa pessoa5 = new Pessoa("Genival", 22, "ginivall@gmail.com");



    }

    public class Pessoa
    {
        public string Nome;
        public int Idade;
        public string Email;


        public  Pessoa(string Nome, int Idade,string Email) {
            this.Nome = Nome;
            this.Idade = Idade;
            this.Email = Email;

        }


        public string info()
        {
            Console.WriteLine("Nome:{0}", this.Nome);
            Console.WriteLine("Nome:{0}", this.Idade);
            Console.WriteLine("Nome:{0}", this.Email);
        }
    }
}

     

    


