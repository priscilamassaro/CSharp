using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula1105_POO
{
    class Aluno : Pessoa //aluno herda pessoa
    {        
        public Aluno(string nome) : base(nome){
            Nome = nome;
        }

        public Aluno(string nome, string cpf) : base(nome, cpf)
            {
            Nome = nome;
            Cpf = cpf;
        }
    }
}
