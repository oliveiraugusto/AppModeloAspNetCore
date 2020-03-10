using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace AppModelo.Class
{
    public class Conexao
    {
        public readonly string StringDeConexao = @"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=DesenvolvimentoWeb;Integrated Security=True";

        public bool TestarConexao()
        {
            string sql = "SELECT COUNT(*) FROM usuarios WHERE usuario = 'admin'";
            SqlConnection conexao = new SqlConnection(StringDeConexao);
            SqlCommand cmd = new SqlCommand(sql, conexao);

            try
            {
                conexao.Open();
                int resultado = (int)cmd.ExecuteScalar();

                if (resultado == 1)
                    return true;
                else
                    return false;

            }
            catch (Exception ex)
            {
                throw new Exception("Não foi possivel conectar ao banco de dados "+ex.Message);
            }
            finally
            {
                conexao.Close();
            }
        }

    }
}
