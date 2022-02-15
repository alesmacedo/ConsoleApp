using System;
using Tela;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Repositorio;

namespace Funcoes
{
    class TelaEstagiario
    {
        static EstagiarioRepositorio estagiarioRepositorio = new EstagiarioRepositorio();
        public static void DisplayAppOptions()
        {
            Console.WriteLine("================== Cadastro de estagiário ==================\n");
            Console.WriteLine("      0 - Voltar ao menu principal");
            Console.WriteLine("      1 - Cadastrar estagiário");
            Console.WriteLine("      2 - Listar estagiários");
            Console.WriteLine("      3 - Deletar estagiário");
            Console.Write("\n     Digite uma das opções acima [0, 1, 2, 3]: ");

            string valor = Console.ReadLine() ?? String.Empty;

                switch (valor)
                {
                case "0":
                    Console.Clear();
                    Menu.Criar();

                    break;
                
                case "1":  //CREATE
                
                    estagiarioRepositorio.Create();
                    break;
                case "2": //LIST
                
                    estagiarioRepositorio.List();
                    Console.WriteLine("\nPressione \"enter\" para voltar ao menu principal.");
                    break;
                case "3":  //DELETE
                
                    estagiarioRepositorio.Delete();
                    break;
                default:
                
                    Console.Clear();
                    Console.WriteLine("Você digitou uma opção inválida, tente novamente.\n");
                    TelaEstagiario.DisplayAppOptions();
                    Console.ReadLine();
                    break;
            }
        }
    }
}
