using Diretorio;
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
                string mensagem = "Olá! Seja bem vindo!" +
                    "\n    Digite uma das opções abaixo:" +
                    "\n      0 - Sair do programa" +
                    "\n      1 - Acessar tela de gerenciamento de estagiário";
                Console.WriteLine(mensagem);

                int valor = int.Parse(Console.ReadLine());

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
                    Console.WriteLine("Opção inválida, digite novamente.");
                }
            }
        }
    }
}