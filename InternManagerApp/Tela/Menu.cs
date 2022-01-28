using Calculo;
using Diretorio;
using Funcoes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tela
{
    internal class Menu
    {
        public const int SAIDA_PROGRAMA = 0;
        public const int LER_ARQUIVOS = 1;
        public const int TABUADA = 2;
        public const int CALCULO_MEDIA = 3;
        public const int CADASTRAR_ESTAGIARIOS = 4;
        public static void Criar()
        {
            while (true)
            {
                string mensagem = "Olá! usuário, bem vindo ao programa" +
                    "\n\n    Utilizando programação funcional." +
                    "\n\n" +
                    "\n    Digite uma das opções abaixo:" +
                    "\n      0 - Sair do programa" +
                    "\n      1 - Ler arquivos" +
                    "\n      2 - Executar a tabuada" +
                    "\n      3 - Calcular a média de alunos" +
                    "\n      4 - Cadastrar Estagiário";

                Console.WriteLine(mensagem);

                int valor = int.Parse(Console.ReadLine());

                if (SAIDA_PROGRAMA == valor)
                {
                    break;
                }
                else if (valor == LER_ARQUIVOS)
                {
                    Console.WriteLine("============== Opção Ler Arquivos =============");
                    Arquivo.Ler(1);
                }
                else if (valor == TABUADA)
                {
                    Console.WriteLine("============== Opção Tabuada =============");
                    Console.WriteLine("Digite o número que deseja na tabuada");
                    int numero = int.Parse(Console.ReadLine());
                    Tabuada.Calcular(numero);
                }
                else if (valor == CALCULO_MEDIA)
                {
                    Media.Aluno();
                    Console.WriteLine("==========================================");
                }
                else if (valor == CADASTRAR_ESTAGIARIOS)
                {
                    Console.Clear();
                    TelaEstagiario.Chamar();
                    Console.WriteLine("\n========================================");
                    
                }
                else
                {
                    Console.WriteLine("Opção inválida, digite novamente.");
                }
            }
        }
    }
}
