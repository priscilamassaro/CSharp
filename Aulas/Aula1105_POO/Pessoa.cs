
namespace Aula1105_POO
{
    abstract class Pessoa //não pode ser instanciada
    {
        private string nome;

        public string Nome
        {
            get => nome; // get { return nome; }
            set => nome = value; // set { nome = value }
        }

        public string Cpf { get; private set; }

        //Construtor

        public Pessoa() {

        }
        public Pessoa(string nome)
        {
            Nome = nome;
        }

        public Pessoa(string nome, string cpf)
        {
            Nome = nome;
            Cpf = cpf;
        }   
        
    }
}
