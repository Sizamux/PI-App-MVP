using ProjOkProjetos.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;
using MySql.Data.MySqlClient;
using System.Data;
using System.Windows.Forms;
using static System.Windows.Forms.AxHost;
using System.Globalization;
using System.Runtime.InteropServices.ComTypes;

namespace ProjOkProjetos.Crud
{
    internal class CRUD_Ord_Ser
    {
        static MySqlConnection connection;
        static string[] formats = { "dd/MM/yyyy", "dd/M/yyyy", "d/M/yyyy", "d/MM/yyyy",
                    "dd/MM/yy", "dd/M/yy", "d/M/yy", "d/MM/yy", "yyyy","d","dd","MM","M"};


        //Test
        public void TestConnection()
        {
            {
                try
                {
                    connection = new MySqlConnection(ConnectionWDatabase.GetRDSConnectionString());
                    connection.Open();
                    Console.WriteLine("Opened connection");
                }
                catch (Exception e)
                {
                    Console.WriteLine("Can't open connection");
                    Console.WriteLine(e.ToString());
                }
            }
        }

        //Read - Leitura - Select na Database
        public static DataTable read_Ord_Serv_All() {
            string query = "SELECT * FROM Ord_Servicos";
            List<Ord_Serv> servicos = new List<Ord_Serv>();
            using (connection = new MySqlConnection(ConnectionWDatabase.GetRDSConnectionString()))
            using (MySqlCommand command = new MySqlCommand(query, connection))
            using (MySqlDataAdapter adapter = new MySqlDataAdapter(command))
            {
                DataTable tb_Ord_Serv = new DataTable();
                adapter.Fill(tb_Ord_Serv);
                return tb_Ord_Serv;
            }
        }
        public static DataTable read_Ord_Serv_emProgresso_List()
        {
            string query = "SELECT * FROM Ord_Servicos WHERE fase_atual != 'Concluido'";
            List<Ord_Serv> servicos = new List<Ord_Serv>();
            using (connection = new MySqlConnection(ConnectionWDatabase.GetRDSConnectionString()))
            using (MySqlCommand command = new MySqlCommand(query, connection))
            using (MySqlDataAdapter adapter = new MySqlDataAdapter(command))
            {
                DataTable tb_Ord_Serv = new DataTable();
                adapter.Fill(tb_Ord_Serv);
                return tb_Ord_Serv;
            }
        }
        public static DataTable read_Ord_Serv_Pesquisa_List(string valor_de_pesquisa)
        {
            string query;

            DateTime pesquisaDateTime;
            if (DateTime.TryParseExact(valor_de_pesquisa, formats, System.Globalization.CultureInfo.InvariantCulture, System.Globalization.DateTimeStyles.None, out pesquisaDateTime))
            {
                query = "SELECT * FROM Ord_Servicos WHERE (fase_atual = @search) or "
                + "(numero_de_PO = @search) or "
                + "(descricao_de_PO = @search) or "
                + "(nome_operadora = @search) or"
                + "(YEAR(data_de_criacao) = @search) or"
                + "(MONTH(data_de_criacao) = @search) or"
                + "(DAYOFMONTH(data_de_criacao) = @search)";
                Console.WriteLine(pesquisaDateTime);
            }
            else {
                query = "SELECT * FROM Ord_Servicos WHERE (fase_atual = @search) or "
                + "(numero_de_PO = @search) or "
                + "(descricao_de_PO = @search) or "
                + "(nome_operadora = @search)";
            }


            List<Ord_Serv> servicos = new List<Ord_Serv>();
            using (connection = new MySqlConnection(ConnectionWDatabase.GetRDSConnectionString()))
            using (MySqlCommand command = new MySqlCommand(query, connection))
            using (MySqlDataAdapter adapter = new MySqlDataAdapter(command))
            {
                command.Parameters.AddWithValue("@search", valor_de_pesquisa);
                                  
                DataTable tb_Ord_Serv = new DataTable();
                adapter.Fill(tb_Ord_Serv);
                return tb_Ord_Serv;
            }
        }
        public static DataTable read_Ord_Serv_One(int id)
        {
            string query = "SELECT * FROM Ord_Servicos WHERE id = @id";
            using (connection = new MySqlConnection(ConnectionWDatabase.GetRDSConnectionString()))
            using (MySqlCommand command = new MySqlCommand(query, connection))
            using (MySqlDataAdapter adapter = new MySqlDataAdapter(command))
            {
                command.Parameters.AddWithValue("@id", id);
                DataTable tb_Ord_Serv = new DataTable();
                adapter.Fill(tb_Ord_Serv);
                return tb_Ord_Serv;
            }
        }
        public static void update_Ord_Serv_modfase(int id,string fase,string numero_de_PO,string nome_operadora, string descricao_de_PO)
        {   
            string query = "update Ord_Servicos set numero_de_PO=@numero_de_PO,nome_operadora=@nome_operadora, descricao_de_PO=@descricao_de_PO, fase_atual = @fase, ultima_modificacao = CURDATE() " +
                "where id = @id";

            using (connection = new MySqlConnection(ConnectionWDatabase.GetRDSConnectionString()))
            using (MySqlCommand command = new MySqlCommand(query, connection))
            {
                connection.Open();
                command.Parameters.AddWithValue("@fase", fase);
                command.Parameters.AddWithValue("@numero_de_PO", numero_de_PO);
                command.Parameters.AddWithValue("@nome_operadora", nome_operadora);
                command.Parameters.AddWithValue("@descricao_de_PO", descricao_de_PO);
                command.Parameters.AddWithValue("@id", id);
                command.ExecuteNonQuery();
                connection.Close();
            }
        }
        public static void insert_Ord_Serv(string numero_de_PO, string descricao_de_PO, string nome_operadora, string fase)
        {
            string query = "INSERT INTO Ord_Servicos (numero_de_PO, nome_operadora, descricao_de_PO, fase_atual, data_de_criacao, ultima_modificacao)" +
                "VALUES (@numero_de_PO, @nome_operadora, @descricao_de_PO, @fase_atual, CURDATE(), CURDATE())";

            using (connection = new MySqlConnection(ConnectionWDatabase.GetRDSConnectionString()))
            using (MySqlCommand command = new MySqlCommand(query, connection))
            {
                connection.Open();
                command.Parameters.AddWithValue("@numero_de_PO", numero_de_PO);
                command.Parameters.AddWithValue("@descricao_de_PO", descricao_de_PO);
                command.Parameters.AddWithValue("@nome_operadora", nome_operadora);
                command.Parameters.AddWithValue("@fase_atual", fase);
                command.ExecuteNonQuery();
                connection.Close();
            }
        }
        public static void delete_Ord_Serv(int id)
        {
            string query = "DELETE FROM Ord_Servicos WHERE id=@id";

            using (connection = new MySqlConnection(ConnectionWDatabase.GetRDSConnectionString()))
            using (MySqlCommand command = new MySqlCommand(query, connection))
            {
                connection.Open();
                command.Parameters.AddWithValue("@id", id);
                command.ExecuteNonQuery();
                connection.Close();
            }
        }
    }
}
