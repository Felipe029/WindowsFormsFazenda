using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using cldal;
using clmodel;
using System.Data.Sql;
using System.Data.SqlClient;


namespace WinFormsPIM
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            string Usuario = tbUsuario.Text.Trim();
            string Senha = tbSenha.Text.Trim();

            // Verifica se os campos estão vazios
            if (string.IsNullOrWhiteSpace(Usuario) || string.IsNullOrWhiteSpace(Senha))
            {
                MessageBox.Show("Preencha todos os campos abaixo!", "Preencha os campos!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return; // Retorna para evitar continuar a execução
            }

            // Conexão com o banco de dados
            string connectionString = @"Data Source=FELIPE\SQLEXPRESS;Initial Catalog=Fazenda;Integrated Security=True;";

            try
            {
                // Usando SqlConnection para conectar ao banco
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();

                    // Consulta SQL para buscar o usuário e seu status de funcionário
                    string query = "SELECT EhFuncionario FROM Usuario WHERE Username=@Username AND Password=@Password";

                    // Preparando o comando SQL
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        // Adicionando parâmetros para evitar SQL Injection
                        cmd.Parameters.AddWithValue("@Username", Usuario);
                        cmd.Parameters.AddWithValue("@Password", Senha);

                        // Executando o comando e verificando se o usuário existe
                        object result = cmd.ExecuteScalar();

                        if (result != null) // Se o resultado não for nulo
                        {
                            int ehFuncionario = Convert.ToInt32(result); // Converte o resultado para int

                            // Login bem-sucedido, abre a tela do menu principal
                            MessageBox.Show("Login bem-sucedido!", "Entrando", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            Main FormMenu = new Main(ehFuncionario); // Passa o valor de ehFuncionario
                            FormMenu.Show();
                            this.Hide();
                        }
                        else
                        {
                            // Se não encontrar o usuário, exibe uma mensagem de erro
                            MessageBox.Show("Nome de usuário ou senha inválidos!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Tratamento de erros (conexão falhou, etc.)
                MessageBox.Show("Ocorreu um erro: " + ex.Message);
            }
        }

        private void BtnCadastrar_Click(object sender, EventArgs e)
        {
            Cadastro FormCadastrar = new Cadastro();
            FormCadastrar.Show();
            this.Hide();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            // Códigos de inicialização se necessário
        }
    }
}
