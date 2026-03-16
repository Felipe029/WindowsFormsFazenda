using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WinFormsPIM
{
    public partial class CadastroFornecedores : Form
    {
        public CadastroFornecedores()
        {
            InitializeComponent();
        }
        private void CadastroFornecedores_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'fazendaDataSet.Fornecedor'. Você pode movê-la ou removê-la conforme necessário.
            this.fornecedorTableAdapter.Fill(this.fazendaDataSet.Fornecedor);
            // TODO: esta linha de código carrega dados na tabela 'fazendaDataSet.Fornecedor'. Você pode movê-la ou removê-la conforme necessário.
            this.fornecedorTableAdapter.Fill(this.fazendaDataSet.Fornecedor);
        }
        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            this.fornecedorBindingSource.AddNew();
        }
        private void btnGravar_Click(object sender, EventArgs e)
        {
            try
            {
                // Verifica se os campos obrigatórios estão preenchidos
                if (!ValidarCampos())
                {
                    MessageBox.Show("Por favor, preencha todos os campos obrigatórios.", "Preencha os campos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return; // Interrompe a execução do método se a validação falhar
                }

                this.fornecedorBindingSource.EndEdit();
                this.fornecedorTableAdapter.Update(this.fazendaDataSet.Fornecedor);
                MessageBox.Show("Fornecedor cadastrado com sucesso!", "Fornecedor Cadastrado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao cadastrar fornecedor: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private bool ValidarCampos()
        {
            // Verifica se os campos obrigatórios estão preenchidos
            if (string.IsNullOrWhiteSpace(txtRazao.Text) ||
                string.IsNullOrWhiteSpace(maskedCNPJ.Text) ||
                string.IsNullOrWhiteSpace(txtContato.Text) ||
                string.IsNullOrWhiteSpace(txtEndereco.Text))
            {
                return false; // Um ou mais campos obrigatórios não estão preenchidos
            }

            return true; // Todos os campos obrigatórios estão preenchidos
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            // Verifica se há alguma linha selecionada no DataGridView
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Nenhum produto selecionado para exclusão.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            DialogResult resultado = MessageBox.Show("Você tem certeza que deseja excluir?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resultado == DialogResult.Yes)
            {
                this.fornecedorBindingSource.RemoveCurrent();
                this.fornecedorTableAdapter.Update(this.fazendaDataSet.Fornecedor);
                MessageBox.Show("Fornecedor excluído com sucesso!", "Excluído", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                // O usuário clicou em "Não" - cancele a operação
                MessageBox.Show("Operação cancelada.", "Cancelado", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void txtRazao_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verifica se a tecla pressionada é uma letra ou o caractere de controle (Backspace, por exemplo)
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != ' ')
            {
                e.Handled = true; // Impede a entrada de caracteres que não sejam letras ou espaço
            }

        }
        public bool existeFornecedor(string cnpj)
        {
            bool existe = false;

            using (SqlConnection conexao = new SqlConnection(@"Data Source=FELIPE\SQLEXPRESS;Initial Catalog=Fazenda;Integrated Security=True;"))
            {
                try
                {
                    conexao.Open();
                    SqlCommand comandoSql = new SqlCommand("SELECT COUNT(*) FROM Fornecedor WHERE CNPJ = @CNPJ", conexao);
                    comandoSql.Parameters.AddWithValue("@CNPJ", cnpj);
                    int count = (int)comandoSql.ExecuteScalar();
                    existe = count > 0; // Se count for maior que 0, o fornecedor já existe
                }
                catch (Exception ex)
                {
                    // Aqui você pode registrar o erro, se necessário
                    MessageBox.Show("Erro ao verificar fornecedor: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            return existe;
        }
        private void maskedCNPJ_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Presume-se que você tenha um TextBox chamado maskedCNPJ para capturar o CNPJ do fornecedor.
            string cnpj = maskedCNPJ.Text.Trim();

            if (existeFornecedor(cnpj))
            {
                maskedCNPJ.Clear();
                MessageBox.Show("Número de fornecedor já existe!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
                
            }
        }

        private void btnCancelar_Click_1(object sender, EventArgs e)
        {
            this.fornecedorBindingSource.CancelEdit();
        }
    }
}
