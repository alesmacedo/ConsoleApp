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
            Console.WriteLine("================== Cadastro de estagiário ==================");
            while (true)
            {
                string mensagem = "\n     Digite uma das opções abaixo:" +
                    "\n      0 - Voltar ao menu principal" +
                    "\n      1 - Cadastrar estagiário" +
                    "\n      2 - Listar estagiários" +
                    "\n      3 - Deletar estagiário";

                Console.WriteLine(mensagem);

                int valor = int.Parse(Console.ReadLine() ?? String.Empty);

                if (valor == 0)
                {
                    Console.Clear();
                    Menu.Criar();

                    break;
                }
                else if (valor == 1) //CREATE
                {
                    estagiarioRepositorio.Create();
                }
                else if (valor == 2) //LIST
                {
                    estagiarioRepositorio.List();

                }
                else if (valor == 3) //DELETE
                {
                    estagiarioRepositorio.Delete();
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Opção inválida, pressione 'enter' para retornar ao menu de gerenciamento.");
                    Console.ReadLine();
                }
            }
        }
    }
}
