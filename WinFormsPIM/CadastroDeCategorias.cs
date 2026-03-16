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
    public partial class CadastroDeCategorias : Form
    {
        public CadastroDeCategorias()
        {
            InitializeComponent();
        }

        private void CadastroDeCategorias_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'fazendaDataSet.Categoria'. Você pode movê-la ou removê-la conforme necessário.
            this.categoriaTableAdapter.Fill(this.fazendaDataSet.Categoria);

        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            this.categoriaBindingSource.AddNew();
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            // Verifica se os campos obrigatórios estão preenchidos
            if (!ValidarCampos())
            {
                MessageBox.Show("Por favor, preencha todos os campos obrigatórios.", "Preencha os campos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return; // Interrompe a execução do método se a validação falhar
            }

            this.categoriaBindingSource.EndEdit();
            this.categoriaTableAdapter.Update(this.fazendaDataSet.Categoria);
            MessageBox.Show("Categoria criada com sucesso!", "Categoria Cadastrada", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private bool ValidarCampos()
        {
            // Verifica se o campo txtCat está preenchido
            if (string.IsNullOrWhiteSpace(txtCat.Text))
            {
                return false; // Um ou mais campos obrigatórios não estão preenchidos
            }

            return true; // Todos os campos obrigatórios estão preenchidos
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.categoriaBindingSource.CancelEdit();
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
                this.categoriaBindingSource.RemoveCurrent();
                this.categoriaTableAdapter.Update(this.fazendaDataSet.Categoria);
                MessageBox.Show("Categoria excluída com sucesso!", "Excluído", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                // O usuário clicou em "Não" - cancele a operação
                MessageBox.Show("Operação cancelada.", "Cancelado", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCat_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != ' ')
            {
                e.Handled = true; // Impede a entrada de caracteres que não sejam letras ou espaço
            }

        }
    }
}