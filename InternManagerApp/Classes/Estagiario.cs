using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    public class Estagiario
    {
        /// <summary>
        /// Construtor da classe
        /// </summary>
        /// <param name="nome">Para preencher o nome do objeto</param>
        /// <param name="idade"></param>
        /// <param name="squad"></param>
        /// <param name="lider"></param>
        public Estagiario(string nome, string idade, string squad, string lider)
        {
            this.Nome = nome;
            this.Idade = idade;
            this.Squad = squad;
            this.Lider = lider;
        }

        /// <summary>
        /// Construtor com parametro telefone inteiro
        /// </summary>
        /// <param name="idade">telefone inteiro</param>
        public Estagiario(int idade)
        {
            this.Nome = idade.ToString();
        }

        /// <summary>
        /// Construtor sem parametros
        /// </summary>
        public Estagiario() 
        { }
        
        public static string Teste;

        public string Nome;
        public string Idade;
        public string Squad;
        public string Lider;

        private string sobrenome = "Santos";

        public void Gravar()
        {
            var estagiarios = Estagiario.LerEstagiarios();
            estagiarios.Add(this);
            if (File.Exists(caminhoBaseEstagiarios()))
            {
                StreamWriter r = new StreamWriter(caminhoBaseEstagiarios());
                r.WriteLine("nome;idade;squad;lider;");
                foreach (Estagiario c in estagiarios)
                {
                    var linha = c.Nome + ";" + c.Idade + ";" + c.Squad + ";" + c.Lider + ";";
                    r.WriteLine(linha);
                }
                r.Close();
            }
        }

        public void Deletar()
      

        {
           
        }

        private static string caminhoBaseEstagiarios()
        {
            return ConfigurationManager.AppSettings["BaseDeEstagiarios"];
        }

        public static List<Estagiario> LerEstagiarios()
        {
            var estagiarios = new List<Estagiario>();
            if (File.Exists(caminhoBaseEstagiarios()))
            {
                using (StreamReader arquivo = File.OpenText(caminhoBaseEstagiarios()))
                {
                    string linha;
                    int i = 0;
                    while ((linha = arquivo.ReadLine()) != null)
                    {
                        i++;
                        if (i == 0) continue;
                        var estagiarioArquivo = linha.Split(';');

                        var estagiario = new Estagiario(estagiarioArquivo[0], estagiarioArquivo[1], estagiarioArquivo[2], estagiarioArquivo[3]);
                        estagiarios.Add(estagiario);
                    }
                }
            }

            return estagiarios;
        }
    }
}
