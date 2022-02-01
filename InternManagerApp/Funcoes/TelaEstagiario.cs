using Classes;
using System;
using Tela;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Funcoes
{
    class TelaEstagiario
    { 
        public static void DisplayAppOptions()
        {
            Console.WriteLine("================== Cadastro de estagiário ==================");
            while (true)
            {
                string mensagem = "Digite uma das opções abaixo:" +
                    "\n      0 - Voltar ao menu principal" +
                    "\n      1 - Cadastrar estagiário" +
                    "\n      2 - Listar estagiários" +
                    "\n      3 - Deletar estagiário";

                Console.WriteLine(mensagem);

                int valor = int.Parse(Console.ReadLine());

                if (valor == 0)
                {
                    Console.Clear();
                    Menu.Criar();

                    break;
                }
                else if (valor == 1)
                {
                    var estagiario = new Estagiario();
                    Console.Clear();
                    Console.WriteLine("Digite o nome do estagiário: ");
                    estagiario.Nome = Console.ReadLine() ?? string.Empty;

                    /* Operador ternário = Se for ?? verificará se é o primeiro valor será null ou não, caso seja, definirá o direito
                     * https://docs.microsoft.com/pt-br/dotnet/csharp/language-reference/operators/null-coalescing-operator */

                    Console.WriteLine("Informe a idade do estagiário:  ");
                    estagiario.Idade = Console.ReadLine() ?? string.Empty;

                    Console.WriteLine("Digite a squad na qual o estagiário pertence: ");
                    estagiario.Squad = Console.ReadLine() ?? string.Empty;

                    Console.WriteLine("Digite o líder responsável pelo estagiário: ");
                    estagiario.Lider = Console.ReadLine() ?? string.Empty;


                    estagiario.Gravar();

                    estagiario.Deletar();
                }
                else if (valor == 2)
                {
                    Console.Clear();
                    var estagiarios = Estagiario.LerEstagiarios();
                    foreach (Estagiario c in estagiarios)
                    {
                        Console.Write("Nome: ");
                        Console.WriteLine(c.Nome);
                        Console.Write("Idade: ");
                        Console.WriteLine(c.Idade);
                        Console.Write("Squad: ");
                        Console.WriteLine(c.Squad);
                        Console.Write("Líder: ");
                        Console.WriteLine(c.Lider);

                        Console.WriteLine("==========================================================");
                    }
                }
                else if (valor == 3)
                {
                    Console.Clear();
                    Console.Write("Digite o nome e sobrenome do estagiário que deseja deletar: ");
                    Console.ReadLine();
                    Console.Clear();
                    Console.WriteLine("Estagiário deletado com sucesso!");
                    Console.ReadKey();
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