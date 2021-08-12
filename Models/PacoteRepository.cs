using MySqlConnector;
using System.Collections.Generic;

namespace Atividade02.Models
{
    public class PacoteRepository
    {
        private const string _strConexao = "Database=agencia; Data Source=127.0.0.1; User Id=root;";

        public void Insert(Pacote p){
            MySqlConnection conexao = new MySqlConnection(_strConexao);
            conexao.Open();

            string sql = "INSERT INTO pacote(nome, origem, destino, atrativos, saida, retorno, usuario)";
            sql = sql + "VALUES (@Nome, @Origem, @Destino, @Atrativos, @Saida, @Retorno, @Usuario)";
            MySqlCommand comando = new MySqlCommand(sql, conexao);
            comando.Parameters.AddWithValue("@Nome",p.Nome);
            comando.Parameters.AddWithValue("@Origem",p.Origem);
            comando.Parameters.AddWithValue("@Destino",p.Destino);
            comando.Parameters.AddWithValue("@Atrativos",p.Atrativos);
            comando.Parameters.AddWithValue("@Saida",p.Saida);
            comando.Parameters.AddWithValue("@Retorno",p.Retorno);
            comando.Parameters.AddWithValue("@Usuario",p.Usuario);

            comando.ExecuteNonQuery();

            conexao.Close();
        }

        public void Excluir(Pacote p){
            MySqlConnection conexao = new MySqlConnection(_strConexao);
            conexao.Open();

            string sql = "DELETE FROM pacote WHERE id = @Id";
            MySqlCommand comando = new MySqlCommand(sql, conexao);
            comando.Parameters.AddWithValue("@Id", p.Id);
            comando.ExecuteNonQuery();
            conexao.Close();
        }

        public void Editar(Pacote p){
            MySqlConnection conexao = new MySqlConnection(_strConexao);
            conexao.Open();

            string sql = "UPDATE pacote SET nome = @Nome, origem = @Origem, destino = @Destino, atrativos = @Atrativos, saida = @Saida, retorno = @Retorno, usuario = @Usuario WHERE id = @Id";

            MySqlCommand comando = new MySqlCommand(sql, conexao);
            comando.Parameters.AddWithValue("@Id", p.Id);
            comando.Parameters.AddWithValue("@Nome",p.Nome);
            comando.Parameters.AddWithValue("@Origem",p.Origem);
            comando.Parameters.AddWithValue("@Destino",p.Destino);
            comando.Parameters.AddWithValue("@Atrativos",p.Atrativos);
            comando.Parameters.AddWithValue("@Saida",p.Saida);
            comando.Parameters.AddWithValue("@Retorno",p.Retorno);
            comando.Parameters.AddWithValue("@Usuario",p.Usuario);
            comando.ExecuteNonQuery();
            conexao.Close();
        }

        public List<Pacote> Listar(){
            MySqlConnection conexao = new MySqlConnection(_strConexao);
            conexao.Open();

            string sql = "SELECT * FROM pacote";

            MySqlCommand comando = new MySqlCommand(sql, conexao);

            MySqlDataReader reader= comando.ExecuteReader();

            List<Pacote> lista = new List<Pacote>();

            while(reader.Read()){
                Pacote package = new Pacote();

                package.Id = reader.GetInt32("Id");
                if (!reader.IsDBNull(reader.GetOrdinal("Nome")))
                    package.Nome = reader.GetString("Nome");
                if (!reader.IsDBNull(reader.GetOrdinal("Origem")))
                    package.Origem = reader.GetString("Origem");
                if (!reader.IsDBNull(reader.GetOrdinal("Destino")))
                    package.Destino = reader.GetString("Destino");
                if (!reader.IsDBNull(reader.GetOrdinal("Atrativos")))
                    package.Atrativos = reader.GetString("Atrativos");
                if (!reader.IsDBNull(reader.GetOrdinal("Saida")))
                    package.Saida = reader.GetString("Saida");
                if (!reader.IsDBNull(reader.GetOrdinal("Retorno")))
                    package.Retorno = reader.GetString("Retorno");
                if (!reader.IsDBNull(reader.GetOrdinal("Usuario")))
                    package.Usuario = reader.GetInt32("Usuario");

                lista.Add(package);
            }
            conexao.Close();
            return lista;
        }
    }
}