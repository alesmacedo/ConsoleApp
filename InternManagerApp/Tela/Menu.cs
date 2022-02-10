using Funcoes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tela
{
    public class Menu
    {
        public static void Criar()
        {

            while (true)
            {
                string mensagem = "================== Menu Principal ==================\n" +
                    "\n    Digite uma das opções abaixo:" +
                    "\n      0 - Sair do programa" +
                    "\n      1 - Acessar tela para" +
                    " gerenciamento de estagiário";
                Console.WriteLine(mensagem);

                int valor = int.Parse(Console.ReadLine() ?? String.Empty);

                if (valor == 0)
                {
                    break;
                }
                else if (valor == 1)
                {
                    Console.Clear();
                    TelaEstagiario.DisplayAppOptions();
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("Opção inválida, digite novamente.\n");
                }
            }
        }
    }
}