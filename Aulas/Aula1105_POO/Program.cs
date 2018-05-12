using System;

namespace Aula1105_POO
{
    class Program
    {
        static void Main(string[] args)
        {
            Aluno a = new Aluno("Joana");

            //a.Nome = "Maria"; //set
            //a.Cpf = "123456789-09"; //set privado

            Console.WriteLine("Aluno: " + a.Nome); //get
            Console.WriteLine("CPF: " + a.Cpf); //get

            Console.ReadKey();

        }
    }
}
