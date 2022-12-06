using MySql.Data.MySqlClient;
using ProjOkProjetos.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjOkProjetos.Crud
{
    internal class CRUD_Itn_Serv_Rec
    {
        static MySqlConnection connection;
        public static DataTable select_ItnServ_referenciaAServ(int id_OrdServ)
        {
            string query = "SELECT * FROM Itn_Serv_Rec WHERE id_OrdServ=@id_OrdServ";
            using (connection = new MySqlConnection(ConnectionWDatabase.GetRDSConnectionString()))
            using (MySqlCommand command = new MySqlCommand(query, connection))
            using (MySqlDataAdapter adapter = new MySqlDataAdapter(command))
            {
                command.Parameters.AddWithValue("@id_OrdServ", id_OrdServ);
                DataTable tb_Itn_Serv_Rec = new DataTable();
                adapter.Fill(tb_Itn_Serv_Rec);
                return tb_Itn_Serv_Rec;
            }
        }
        public static DataTable select_ItnServ_referenciaARec(int id_OrdRec)
        {
            string query = "SELECT * FROM Itn_Serv_Rec WHERE id_OrdRec=@id_OrdRec";
            using (connection = new MySqlConnection(ConnectionWDatabase.GetRDSConnectionString()))
            using (MySqlCommand command = new MySqlCommand(query, connection))
            using (MySqlDataAdapter adapter = new MySqlDataAdapter(command))
            {
                command.Parameters.AddWithValue("@id_OrdRec", id_OrdRec);
                DataTable tb_Itn_Serv_Rec = new DataTable();
                adapter.Fill(tb_Itn_Serv_Rec);
                return tb_Itn_Serv_Rec;
            }
        }
        public static void insert_ItnServ_referenciaAServ(string descricao, double valor, int id_OrdServ)
        {           
            string query = "INSERT INTO Itn_Serv_Rec (descricao, valor, id_OrdServ) " +
                            "VALUES (@descricao, @valor, @id_OrdServ)";

            using (connection = new MySqlConnection(ConnectionWDatabase.GetRDSConnectionString()))
            using (MySqlCommand command = new MySqlCommand(query, connection))
            {
                connection.Open();
                command.Parameters.AddWithValue("@descricao", descricao);
                command.Parameters.AddWithValue("@valor", valor);
                command.Parameters.AddWithValue("@id_OrdServ", id_OrdServ);
                command.ExecuteNonQuery();
                connection.Close();
            }
        }

        public static void update_ItnServ_recId(int id, int id_OrdRec)
        {
            string query = "update Itn_Serv_Rec set id_OrdRec = @id_OrdRec " +
                "where id = @id";

            using (connection = new MySqlConnection(ConnectionWDatabase.GetRDSConnectionString()))
            using (MySqlCommand command = new MySqlCommand(query, connection))
            {
                connection.Open();
                command.Parameters.AddWithValue("@id", id);
                command.Parameters.AddWithValue("@id_OrdRec", id_OrdRec);   
                command.ExecuteNonQuery();
                connection.Close();
            }
        }

        public static void update_ItnServ_limparrecId(int id)
        {
            string query = "update Itn_Serv_Rec set id_OrdRec = NULL " +
                        "where id = @id";

            using (connection = new MySqlConnection(ConnectionWDatabase.GetRDSConnectionString()))
            using (MySqlCommand command = new MySqlCommand(query, connection))
            {
                connection.Open();
                command.Parameters.AddWithValue("@id", id);
                command.ExecuteNonQuery();
                connection.Close();
            }
        }
        public static void update_ItnServ(int id,string descricao, double valor)
        {
            string query = "update Itn_Serv_Rec set descricao = @descricao, valor = @valor " +
                        "where id = @id";

            using (connection = new MySqlConnection(ConnectionWDatabase.GetRDSConnectionString()))
            using (MySqlCommand command = new MySqlCommand(query, connection))
            {
                connection.Open();
                command.Parameters.AddWithValue("@descricao", descricao);
                command.Parameters.AddWithValue("@valor", valor);
                command.Parameters.AddWithValue("@id", id);
                command.ExecuteNonQuery();
                connection.Close();
            }
        }
        
        public static void delete_Itn_Serv(int id)
        {
            string query = "DELETE FROM Itn_Serv_Rec WHERE id=@id";

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
