using MySql.Data.MySqlClient;
using ProjOkProjetos.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ProjOkProjetos.Crud
{
    internal class CRUD_Ord_Rec
    {
        static MySqlConnection connection;

        public static DataTable read_Ord_Rec_All()
        {
            string query = "SELECT * FROM Ord_Recebimento";
            using (connection = new MySqlConnection(ConnectionWDatabase.GetRDSConnectionString()))
            using (MySqlCommand command = new MySqlCommand(query, connection))
            using (MySqlDataAdapter adapter = new MySqlDataAdapter(command))
            {
                DataTable tb_Ord_Rec = new DataTable();
                adapter.Fill(tb_Ord_Rec);
                return tb_Ord_Rec;
            }
        }
        public static DataTable read_Ord_Rec_AllwInnerJoin()
        {
            string query = "SELECT Ord_Recebimento.id, numero_de_NF, data_de_recebimento, count(Itn_Serv_Rec.id) quantidade_de_itens, sum(Itn_Serv_Rec.valor) valortotal, status, data_de_criacao, ultima_modificacao " +
                "FROM Ord_Recebimento  INNER JOIN Itn_Serv_Rec  ON Itn_Serv_Rec.id_OrdRec = Ord_Recebimento.id GROUP BY  Ord_Recebimento.id";
            using (connection = new MySqlConnection(ConnectionWDatabase.GetRDSConnectionString()))
            using (MySqlCommand command = new MySqlCommand(query, connection))
            using (MySqlDataAdapter adapter = new MySqlDataAdapter(command))
            {
                DataTable tb_Ord_Rec = new DataTable();
                adapter.Fill(tb_Ord_Rec);
                return tb_Ord_Rec;
            }
        }
        public static DataTable read_Ord_Rec_One(int id)
        {
            string query = "SELECT * FROM Ord_Recebimento WHERE id = @id";
            using (connection = new MySqlConnection(ConnectionWDatabase.GetRDSConnectionString()))
            using (MySqlCommand command = new MySqlCommand(query, connection))
            using (MySqlDataAdapter adapter = new MySqlDataAdapter(command))
            {
                command.Parameters.AddWithValue("@id", id);
                DataTable tb_Ord_Rec = new DataTable();
                adapter.Fill(tb_Ord_Rec);
                return tb_Ord_Rec;
            }
        }

        public static void update_Ord_Rec_modstatus(int id,string numero_de_NF, string status, string data_de_recebimento)
        {
            string query = "update Ord_Recebimento set numero_de_NF = @numero_de_NF, status = @status, data_de_recebimento = STR_TO_DATE(@data_de_recebimento, '%m/%d/%Y'), ultima_modificacao = CURDATE() " +
                "where id = @id";

            using (connection = new MySqlConnection(ConnectionWDatabase.GetRDSConnectionString()))
            using (MySqlCommand command = new MySqlCommand(query, connection))
            {
                connection.Open();
                command.Parameters.AddWithValue("@numero_de_NF", numero_de_NF);
                command.Parameters.AddWithValue("@status", status);
                command.Parameters.AddWithValue("@data_de_recebimento", data_de_recebimento);
                command.Parameters.AddWithValue("@id", id);
                command.ExecuteNonQuery();
                connection.Close();
            }
        }
        public static void insert_Ord_Rec(string numero_de_NF, string status, string data_de_recebimento)
        {
            string query = "INSERT INTO Ord_Recebimento (numero_de_NF, status, data_de_recebimento, data_de_criacao, ultima_modificacao)" +
                "VALUES (@numero_de_NF, @status, STR_TO_DATE(@data_de_recebimento, '%m/%d/%Y'), CURDATE(), CURDATE())";

            using (connection = new MySqlConnection(ConnectionWDatabase.GetRDSConnectionString()))
            using (MySqlCommand command = new MySqlCommand(query, connection))
            {
                connection.Open();
                command.Parameters.AddWithValue("@numero_de_NF", numero_de_NF);
                command.Parameters.AddWithValue("@status", status);
                command.Parameters.AddWithValue("@data_de_recebimento", data_de_recebimento);
                command.ExecuteNonQuery();
                connection.Close();
            }
        }
        public static int insert_Ord_Rec_wScopeReturn(string numero_de_NF, string status, string data_de_recebimento)
        {
            string query = "INSERT INTO Ord_Recebimento (numero_de_NF, status, data_de_recebimento, data_de_criacao, ultima_modificacao)" +
                "VALUES (@numero_de_NF, @status, STR_TO_DATE(@data_de_recebimento, '%m/%d/%Y'), CURDATE(), CURDATE()); SELECT LAST_INSERT_ID();";

            using (connection = new MySqlConnection(ConnectionWDatabase.GetRDSConnectionString()))
            using (MySqlCommand command = new MySqlCommand(query, connection))
            {
                connection.Open();
                command.Parameters.AddWithValue("@numero_de_NF", numero_de_NF);
                command.Parameters.AddWithValue("@status", status);
                command.Parameters.AddWithValue("@data_de_recebimento", data_de_recebimento);
                int g = Convert.ToInt32(command .ExecuteScalar());
                connection.Close();
                return g;
            }
        }
        public static void delete_Ord_Rec(int id)
        {
            string query = "DELETE FROM Ord_Recebimento WHERE id=@id";

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
