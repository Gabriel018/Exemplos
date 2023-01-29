using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Usuario
{
    class Users
    {
        private string Nome;
        private int idade;
        private int cpf;
        private int conta;
        public Users(string Nome)
        {
            this.Nome = Nome;
            this.idade = 0;
        }

        public string Getnome()
        {
            return Nome;
        }

        public int GetIdade()
        {
            return idade;
        }

    }
}
