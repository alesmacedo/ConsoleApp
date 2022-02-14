using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositorio
{
    public class EstagiarioRepositorio
    {
        string connectionString = @"Data Source=LAPTOP-F79UVNP0\SQLEXPRESS;Initial Catalog=InternManagerDb;Integrated Security=True";
        public void Create()
        {
            Console.Clear();

            SqlConnection sqlConnection;
           
            try //Tentar rodar e se não funcionar retorna catch com uma mensagem ao usuario informando que teve erro
            {
                sqlConnection = new SqlConnection(connectionString);
                sqlConnection.Open();
                Console.WriteLine("Aplicação conectada ao banco de dados!");
                //Create => CRUD
                Console.Write("\nDigite o nome do estagiário: ");
                string userName = Console.ReadLine() ?? string.Empty;

                /* Operador ternário = Se for ?? verificará se é o primeiro valor será null ou não, caso seja, definirá o direito
                 * https://docs.microsoft.com/pt-br/dotnet/csharp/language-reference/operators/null-coalescing-operator */

                Console.Write("Informe a idade do estagiário:  ");
                int userAge = int.Parse(Console.ReadLine() ?? string.Empty);

                Console.Write("Digite a squad na qual o estagiário pertence: ");
                string userSquad = Console.ReadLine() ?? string.Empty;

                Console.Write("Digite o líder responsável pelo estagiário: ");
                string userLeader = Console.ReadLine() ?? string.Empty;

                string insertQuery = "INSERT INTO DETAILSINTERN(user_name,user_age,user_squad,user_leader)" +
                "VALUES('" + userName + "'," + userAge + ",'" + userSquad + "','" + userLeader + "')";
                SqlCommand insertCommand = new SqlCommand(insertQuery, sqlConnection);
                insertCommand.ExecuteNonQuery();
                Console.WriteLine("\nEstagiário registrado com sucesso!");
                sqlConnection.Close();
            }
            catch (Exception) //Erro com uma mensagem mais bonita kk
            {
                Console.WriteLine("Houve um erro, por favor informe uma idade válida!");
            }

        }
        public void List()
        {
            Console.Clear();

            SqlConnection sqlConnection;
            
            try
            {
                sqlConnection = new SqlConnection(connectionString);
                sqlConnection.Open();

                string displayQuery = "SELECT * FROM DetailsIntern";
                SqlCommand displayCommand = new SqlCommand(displayQuery, sqlConnection);
                SqlDataReader dataReader = displayCommand.ExecuteReader();
                while (dataReader.Read())
                {
                    Console.WriteLine("Id: " + dataReader.GetValue(0).ToString());
                    Console.WriteLine("Nome: " + dataReader.GetValue(1).ToString());
                    Console.WriteLine("Idade: " + dataReader.GetValue(2).ToString());
                    Console.WriteLine("Squad: " + dataReader.GetValue(3).ToString());
                    Console.WriteLine("Líder: " + dataReader.GetValue(4).ToString());
                }

                dataReader.Close();
                sqlConnection.Close();
            }
            catch (Exception)
            {
                Console.WriteLine("Houve um erro, por favor tente novamente!");
            }
        }
        public void Delete()
        {
            Console.Clear();

            SqlConnection sqlConnection;
            
            try
            {
                sqlConnection = new SqlConnection(connectionString);
                sqlConnection.Open();

                int d_id;
                Console.Write("Digite o ID do estagiário que deseja deletar: ");
                d_id = int.Parse(Console.ReadLine() ?? string.Empty);
                string deleteQuery = "DELETE FROM DetailsIntern WHERE user_id =" + d_id;
                SqlCommand deleteCommand = new SqlCommand(deleteQuery, sqlConnection);
                deleteCommand.ExecuteNonQuery();
                Console.Clear();
                Console.WriteLine("Estagiário deletado com sucesso!");
                Console.WriteLine("\nPressione a tecla 'enter' para retornar ao menu principal.");
                sqlConnection.Close();
                Console.ReadKey();
            }
            catch (Exception)
            {
                Console.WriteLine("Houve um erro, por favor informe um ID válido!");
            }
        }
    }
}
