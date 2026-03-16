using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;

using clmodel;
using System.Security.Cryptography.X509Certificates;
using System.Windows.Input;


namespace cldal
{
    public class LoginDal
    {
        private SqlConnection _conexaoLogin;
        private SqlCommand _comandoSql;
        private Conexao _conexaoBanco;

        public LoginDal()
        {
            _conexaoBanco = new Conexao();
            _conexaoLogin = _conexaoBanco.obterConexao();
        }

        public static bool existeUsername(LoginModel parLogin)
        {
            bool res = false;

            using (SqlConnection conexao = new SqlConnection(@"Data Source=FELIPE\SQLEXPRESS;Initial Catalog=Fazenda;Integrated Security=True;"))
            {
                try
                {
                    conexao.Open();
                    SqlCommand comandoSql = new SqlCommand("SELECT COUNT(*) FROM Usuario WHERE Username = @Username", conexao);
                    comandoSql.Parameters.AddWithValue("@Username", parLogin.Usuario);

                    int count = (int)comandoSql.ExecuteScalar();
                    res = count > 0; // Se count for maior que 0, o usuário já existe
                }
                catch (Exception ex)
                {
                    throw new Exception("Erro ao verificar o usuário: " + ex.Message);
                }
            }

            return res;
        }

        public bool inserirU(LoginModel parLogin)
        {
            if (existeUsername(parLogin))
            {
                return false; // Retorna falso se o usuário já existe
            }
            try
            {
                _comandoSql = new SqlCommand();
                _comandoSql.Connection = _conexaoLogin;
                _comandoSql.CommandText =
                    "INSERT INTO usuario (Username, Password, EhFuncionario) VALUES (@Username, @Password, @EhFuncionario)";
                _comandoSql.Parameters.Add("@Username", SqlDbType.VarChar).Value = parLogin.Usuario;
                _comandoSql.Parameters.Add("@Password", SqlDbType.VarChar).Value = parLogin.Senha;
                _comandoSql.Parameters.AddWithValue("@EhFuncionario", parLogin.EhFuncionario); // Adiciona o valor de EhFuncionario
                _comandoSql.ExecuteNonQuery();

                return true; // Retorna verdadeiro se o cadastro foi bem-sucedido
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao inserir o usuário: " + ex.Message);
            }
        }


        public void atualizarU(LoginModel parLogin)
        {
            try
            {
                _comandoSql = new SqlCommand();
                _comandoSql.Connection = _conexaoLogin;
                _comandoSql.CommandText =
                    "UPDATE Usuarios SET Username = @Username, Password = @Password, EhFuncionario = @EhFuncionario";
                _comandoSql.Parameters.Add("@Username", SqlDbType.VarChar).Value = parLogin.Usuario;
                _comandoSql.Parameters.Add("@Password", SqlDbType.VarChar).Value = parLogin.Senha;
                _comandoSql.Parameters.AddWithValue("@EhFuncionario", parLogin.EhFuncionario); // Adiciona o valor de EhFuncionario
                _comandoSql.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao atualizar o usuário: " + ex.Message);
            }
        }

        public bool ObterUsuario(string username, string password)
        {
            bool achou = false;
            SqlDataReader leitor;

            try
            {
                _comandoSql = new SqlCommand();
                _comandoSql.Connection = _conexaoLogin;
                _comandoSql.CommandText =
                    "SELECT Username FROM Usuarios WHERE Username = @Username AND Password = @Password";
                _comandoSql.Parameters.Add("@Username", SqlDbType.VarChar, 50).Value = username;
                _comandoSql.Parameters.Add("@Password", SqlDbType.VarChar, 100).Value = password;

                leitor = _comandoSql.ExecuteReader();
                if (leitor.Read())
                {
                    achou = true;
                }

                leitor.Close();
                return achou;
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao obter o usuário: " + ex.Message);
            }
        }
    }
}
