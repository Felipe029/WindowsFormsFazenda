using cldal;
using clmodel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Collections;

namespace WinFormsPIM
{
    public partial class Cadastro : Form
    {
        public Cadastro()
        {
            InitializeComponent();
        }

        public void LimparTela()
        {
            tbUsuario.Clear();
            tbSenha.Clear();
            tbSenha2.Clear();
            radioSim.Checked = false;
            radioNao.Checked = false;
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            LimparTela();
        }

        private void btnVoltaLogin_Click(object sender, EventArgs e)
        {
            Login FormLogin = new Login();
            FormLogin.Show();
            this.Hide();
        }

        public int ehFuncionario;
        private void BtnCadastrar_Click_1(object sender, EventArgs e)
        {
            LoginDal login = new LoginDal();
            LoginModel loginMo = new LoginModel();

            if (string.IsNullOrWhiteSpace(tbUsuario.Text) ||
                string.IsNullOrWhiteSpace(tbSenha.Text) ||
                string.IsNullOrWhiteSpace(tbSenha2.Text) ||
                (!radioSim.Checked && !radioNao.Checked))
            {
                MessageBox.Show("Preencha todos os campos abaixo!", "Preencha os campos!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (tbSenha.Text != tbSenha2.Text)
            {
                MessageBox.Show("As senhas são diferentes!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Verifica se é funcionário
            int EhFuncionario = radioSim.Checked ? 1 : 0;
            loginMo.Usuario = tbUsuario.Text.Trim();
            loginMo.Senha = tbSenha.Text.Trim();
            loginMo.EhFuncionario = EhFuncionario;

            // Verifica se o usuário já existe
            if (!login.inserirU(loginMo))
            {
                MessageBox.Show("Esse usuário já existe!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            MessageBox.Show("Login criado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //MessageBox.Show(EhFuncionario == 1 ? "Você é um funcionário!" : "Você não é um funcionário!",
                //"Informação",
                //MessageBoxButtons.OK,
                //EhFuncionario == 1 ? MessageBoxIcon.Information : MessageBoxIcon.Exclamation);

            

            Login FormLogin = new Login();
            FormLogin.Show();
            this.Hide();

        }
    }
}



