﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diretorio
{
    internal class Arquivo
    {
        private static string caminhoArquivo()
        {
            return ConfigurationManager.AppSettings["CaminhoArquivos"];
        }
        public static void Ler(int numeroArquivo)
        {
            string arquivoComCaminho = caminhoArquivo() + "arq" + numeroArquivo + ".txt";
            Console.WriteLine("================= Lendo arquivo\n" + arquivoComCaminho + " ================");
            if (File.Exists(arquivoComCaminho))
            {
                using (StreamReader arquivo = File.OpenText(arquivoComCaminho))
                {
                    string linha;
                    while ((linha = arquivo.ReadLine()) != null)
                    {
                        Console.WriteLine(linha);
                    }
                }
            }
            string arquivoComCaminho2 = ConfigurationManager.AppSettings["caminho_arquivos"] + "arq" + (numeroArquivo + 1) + ".txt";
            if (File.Exists(arquivoComCaminho2))
            {
                Arquivo.Ler(numeroArquivo + 1);
            }
        }
    }
}