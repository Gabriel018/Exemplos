using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heranca
{
     class Funcionario
     {
        public int matricula;
        public string setor;
        public double salario;
        public bool situaçao_empresa;
        public void Ativo()
        {
            situaçao_empresa = true;
        }

        public void Desligado()
        {
            situaçao_empresa = false;
        }

         public string Situacao()
        {
            if (situaçao_empresa)
            {
                return  "Ativo";

            }
            else
            {
                return "Desligado";
            }
            
        }

         
         public class Cadastro : Funcionario
        {
           public string nome;
           public int cpf;


            public Cadastro(string nome,int cpf)
            {
                this.nome = nome;
                this.cpf = cpf;
                Desligado();


            }
        }

    }


}

