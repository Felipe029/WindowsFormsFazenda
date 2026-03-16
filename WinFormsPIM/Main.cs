using CrystalDecisions.Windows.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsPIM
{
    public partial class Main : Form
    {
        int ehFuncionario;
        public Main(int ehFuncionario)
        {
            InitializeComponent();
            this.ehFuncionario = ehFuncionario;
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            {
                Application.Exit();
            }

        }
            

        //Cliente
        private void escolherProdutosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Vendas FormVendas = new Vendas();
            FormVendas.Show();
        }

        //Cliente
        private void produtosPorCategoriaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProdutosPorCategoria FormProdutoPorCategoria = new ProdutosPorCategoria();
            FormProdutoPorCategoria.Show();
        }

        private void produtosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ehFuncionario == 0) // Se não for funcionário
            {
                MessageBox.Show("Você não tem acesso a esta funcionalidade.", "Acesso Negado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // Impede a abertura do formulário
            }

            CadastroProdutos FormProduto = new CadastroProdutos();
            FormProduto.Show();
        }

        private void pessoasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ehFuncionario == 0) // Se não for funcionário
            {
                MessageBox.Show("Você não tem acesso a esta funcionalidade.", "Acesso Negado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // Impede a abertura do formulário
            }
        }

        private void fornecedoresToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (ehFuncionario == 0) // Se não for funcionário
            {
                MessageBox.Show("Você não tem acesso a esta funcionalidade.", "Acesso Negado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // Impede a abertura do formulário
            }

            CadastroFornecedores FormFornecedores = new CadastroFornecedores();
            FormFornecedores.Show();
        }

        private void categoriasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ehFuncionario == 0) // Se não for funcionário
            {
                MessageBox.Show("Você não tem acesso a esta funcionalidade.", "Acesso Negado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // Impede a abertura do formulário
            }

            CadastroDeCategorias FormCategorias = new CadastroDeCategorias();
            FormCategorias.Show();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Login FormLogin = new Login();
            FormLogin.Show();
            this.Hide();
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ehFuncionario == 0) // Se não for funcionário
            {
                MessageBox.Show("Você não tem acesso a esta funcionalidade.", "Acesso Negado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // Impede a abertura do formulário
            }
            CadastroPessoas FormCliente = new CadastroPessoas();
            FormCliente.Show();
        }

        private void funcionáriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ehFuncionario == 0) // Se não for funcionário
            {
                MessageBox.Show("Você não tem acesso a esta funcionalidade.", "Acesso Negado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // Impede a abertura do formulário
            }
            txtCargaHoraria FormFuncionarios = new txtCargaHoraria();
            FormFuncionarios.Show();
        }
        private void vendasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ehFuncionario == 0) // Se não for funcionário
            {
                MessageBox.Show("Você não tem acesso a esta funcionalidade.", "Acesso Negado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // Impede a abertura do formulário
            }
            RelatorioVendas relatorioVendas = new RelatorioVendas();
            relatorioVendas.Show();
        }

        private void produçãoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (ehFuncionario == 0) // Se não for funcionário
            {
                MessageBox.Show("Você não tem acesso a esta funcionalidade.", "Acesso Negado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // Impede a abertura do formulário
            }
            RelatorioProdutos relatorioProdutos = new RelatorioProdutos();
            relatorioProdutos.Show();
        }

        private void Main_Load(object sender, EventArgs e)
        {

        }
    }
}
