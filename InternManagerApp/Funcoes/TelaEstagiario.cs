using Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Funcoes
{
    class TelaEstagiario
    {
        public static void Chamar()
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
                    break;
                }
                else if(valor == 1)
                {
                    var estagiario = new Estagiario();
                    Console.WriteLine("Digite o nome do estagiário: ");
                    estagiario.Nome = Console.ReadLine() ?? string.Empty;

                    /* Operador ternário = Se for ?? verificará se é o primeiro valor será null ou não, caso seja, definirá o direito
                     * https://docs.microsoft.com/pt-br/dotnet/csharp/language-reference/operators/null-coalescing-operator */ 

                    Console.WriteLine("Informe a idade do estagiário:  ");
                    estagiario.Idade = Console.ReadLine();

                    Console.WriteLine("Digite a squad na qual o estagiário pertence: ");
                    estagiario.Squad = Console.ReadLine();

                    Console.WriteLine("Digite o líder responsável pelo estagiário: ");
#pragma warning disable CS8601 // Possible null reference assignment.
                    estagiario.Lider = Console.ReadLine();
#pragma warning restore CS8601 // Possible null reference assignment.
                   

                    estagiario.Gravar();

                    estagiario.Deletar();
                }
                else if(valor == 2)
                {
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

                        Console.WriteLine("============================================================");
                    }
                }
                else if (valor == 3)
                {
                   
                    Console.Write("Digite o nome e sobrenome do estagiário que deseja deletar: ");
                    
                    Console.WriteLine("Você deletou o estagiário");
                }
                Console.ReadLine();
            }
        }
    }
}
