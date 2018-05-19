using Aula1805_Camadas.Controllers;
using Aula1805_Camadas.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula1805_Camadas.Views
{
    class AtividadesView
    {
        AtividadesController ac = new AtividadesController();

        public void ExibirMenu()
        {
            int opcao = 6;
            do
            {
                Console.WriteLine("====================================");
                Console.WriteLine("= 1) Cadastrar Atividade =");
                Console.WriteLine("= 2) Listar Atividades =");
                Console.WriteLine("= 3) Editar Atividade =");
                Console.WriteLine("= 4) Excluir Atividade =");
                Console.WriteLine("= 5) Sair =");
                Console.WriteLine("====================================");

                Console.Write("Digite uma opção:");
                opcao = int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        CadastrarAtividade(ac);
                        break;

                    case 2:
                        ExibirAtividadesCadastradas();
                        break;

                    case 3:
                        EditarAtividadeCadastrada();
                        break;

                    case 4:
                        ExcluirAtividadeCadastrada();
                        break;

                    default:
                        break;
                }
                Console.ReadKey();
            } while (opcao != 6);
            
        }

        private void ExcluirAtividadeCadastrada()
        {
            ExibirAtividadesCadastradas();
            Console.Write("Digite o ID da atividde a ser excluida: ");
            int id = int.Parse(Console.ReadLine());

            Atividade atividade = ac.BuscarPorID(id);

            if (atividade != null)
                ac.Excluir(atividade);
            else
                Console.WriteLine("Atividade não encontrada");
        }

        public void EditarAtividadeCadastrada()
        {
            ExibirAtividadesCadastradas();
                        
            Atividade atividade = new Atividade();
            Console.Write("Digite o ID da atividde a ser alterada: ");
            atividade.AtividadeID = int.Parse(Console.ReadLine());

            Console.Write("Digite o novo nome: ");
            atividade.Nome = Console.ReadLine();

            Console.Write("Ativo? S/N");
            atividade.Ativo = Console.ReadLine() == "S" ? true : false;

            ac.Editar(atividade);
        }

        private void ExibirAtividadesCadastradas()
        {
            Console.WriteLine("-- Exibindo atividades cadastradas --");
            foreach (Atividade a in ac.Listar())
            {
                Console.WriteLine(" - Dados Atividade - ");
                Console.WriteLine("ID: " + a.AtividadeID);
                Console.WriteLine("Nome: " + a.Nome);
                Console.WriteLine("Ativo: " + a.Ativo);
                Console.WriteLine("--");
            }
            Console.WriteLine("--FIM DA LISTA--");
        }

        private static Atividade CadastrarAtividade(AtividadesController ac)
        {
            Atividade atividade = new Atividade();
            Console.WriteLine("Digite o nome da atividade:");
            atividade.Nome = Console.ReadLine();
            atividade.Ativo = true;
            ac.Salvar(atividade);
            return atividade;
        }
    }
}
