using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsPIM.FazendaDataSetTableAdapters;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WinFormsPIM
{
    public partial class CadastroProdutos : Form
    {
        public object Categoria { get; private set; }

        public CadastroProdutos()
        {
            InitializeComponent();
        }

        private void CadastroProdutos_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'fazendaDataSet.Categoria'. Você pode movê-la ou removê-la conforme necessário.
            this.categoriaTableAdapter.Fill(this.fazendaDataSet.Categoria);
            // TODO: esta linha de código carrega dados na tabela 'fazendaDataSet.Produtos'. Você pode movê-la ou removê-la conforme necessário.
            this.produtosTableAdapter.Fill(this.fazendaDataSet.Produtos);
        }
        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            this.produtosBindingSource.AddNew();
        }
        private void btnGravar_Click(object sender, EventArgs e)
        {
            // Verifica se os campos obrigatórios estão preenchidos
            if (!ValidarCampos())
            {
                MessageBox.Show("Por favor, preencha todos os campos obrigatórios.", "Preencha os campos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return; // Interrompe a execução do método se a validação falhar
            }

            this.produtosBindingSource.EndEdit();
            this.produtosTableAdapter.Update(this.fazendaDataSet.Produtos);
            MessageBox.Show("Produto gravado com sucesso!", "Cadastrado", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private bool ValidarCampos()
        {
            // Exemplo: considere que você tenha campos como txtNome, mskTel, txtEmail, txtEndereco que são obrigatórios
            // Substitua esses nomes pelos controles reais que você está usando
            if (string.IsNullOrWhiteSpace(txtProduto.Text) ||
                string.IsNullOrWhiteSpace(txtPreco.Text) ||
                string.IsNullOrWhiteSpace(comboCat.Text) ||
                string.IsNullOrWhiteSpace(richtxtDesc.Text))
            {
                return false; // Um ou mais campos obrigatórios não estão preenchidos
            }

            return true; // Todos os campos obrigatórios estão preenchidos
        }
        private void btnExcluir_Click(object sender, EventArgs e)
        {
            // Verifica se há alguma linha selecionada no DataGridView
            if (dataGridViewProdutos.SelectedRows.Count == 0)
            {
                MessageBox.Show("Nenhum produto selecionado para exclusão.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            DialogResult resultado = MessageBox.Show("Você tem certeza que deseja excluir?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resultado == DialogResult.Yes)
            {
                this.produtosBindingSource.RemoveCurrent();
                this.produtosTableAdapter.Update(this.fazendaDataSet.Produtos);
                MessageBox.Show("Produto excluído com sucesso!", "Excluído", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                // O usuário clicou em "Não" - cancele a operação
                MessageBox.Show("Operação cancelada.", "Cancelado", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.produtosBindingSource.CancelEdit();
        }
        private void txtPreco_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verifica se a tecla pressionada não é um dígito e não é a tecla Backspace
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '.' && e.KeyChar != ',' && !char.IsControl(e.KeyChar))
            {
                // Cancela o evento para impedir a entrada de caracteres não numéricos
                e.Handled = true;
            }

            // Verifica se o número total de caracteres já é igual ao máximo permitido
            if (txtPreco.Text.Length >= 8 && !char.IsControl(e.KeyChar))
            {
                // Cancela o evento para impedir a entrada se o limite foi atingido
                e.Handled = true;
            }
        }

        private void txtProduto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != ' ')
            {
                e.Handled = true; // Impede a entrada de caracteres que não sejam letras ou espaço
            }

        }
    }
}
