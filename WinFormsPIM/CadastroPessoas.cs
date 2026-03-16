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
    public partial class CadastroPessoas : Form
    {
        public CadastroPessoas()
        {
            InitializeComponent();
        }

        private void CadastroPessoas_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'fazendaDataSet.Clientes'. Você pode movê-la ou removê-la conforme necessário.
            this.clientesTableAdapter.Fill(this.fazendaDataSet.Clientes);
        }
        private void btnNovo_Click(object sender, EventArgs e)
        {
            this.clientesBindingSource.AddNew();
        }
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            // Verifica se os campos obrigatórios estão preenchidos
            if (!ValidarCampos())
            {
                MessageBox.Show("Por favor, preencha todos os campos obrigatórios.", "Preencha os campos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return; // Interrompe a execução do método se a validação falhar
            }

            this.clientesBindingSource.EndEdit();
            this.clientesTableAdapter.Update(this.fazendaDataSet.Clientes);
            MessageBox.Show("Novo cliente cadastrado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private bool ValidarCampos()
        {
            // Exemplo: considere que você tenha campos como txtNome, mskTel, txtEmail, txtEndereco que são obrigatórios
            // Substitua esses nomes pelos controles reais que você está usando
            if (string.IsNullOrWhiteSpace(txtNome.Text) ||
                string.IsNullOrWhiteSpace(mskTel.Text) ||
                string.IsNullOrWhiteSpace(txtEmail.Text) ||
                string.IsNullOrWhiteSpace(txtEndereco.Text))
            {
                return false; // Um ou mais campos obrigatórios não estão preenchidos
            }

            return true; // Todos os campos obrigatórios estão preenchidos
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.clientesBindingSource.CancelEdit();
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
                this.clientesBindingSource.RemoveCurrent();
                this.clientesTableAdapter.Update(this.fazendaDataSet.Clientes);
                MessageBox.Show("Cliente excluído com sucesso!", "Excluído", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Operação cancelada.", "Cancelado", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            // Verifica se a coluna é a coluna "Telefone"
            if (e.ColumnIndex == 2) // Substitua por um índice válido
            {
                if (e.Value != null && e.Value.ToString() != "")
                {
                    // Formata o número de telefone
                    string numeroTelefone = e.Value.ToString();

                    // Remove todos os caracteres não numéricos
                    numeroTelefone = new string(numeroTelefone.Where(char.IsDigit).ToArray());

                    // Verifica o comprimento do número para aplicar a formatação correta
                    if (numeroTelefone.Length == 11)
                    {
                        e.Value = string.Format("({0}) {1}-{2}",
                            numeroTelefone.Substring(0, 2), // DDD
                            numeroTelefone.Substring(2, 5), // Número principal (5 dígitos)
                            numeroTelefone.Substring(7, 4)); // Número final (4 dígitos)
                    }
                    else if (numeroTelefone.Length == 10)
                    {
                        e.Value = string.Format("({0}) {1}-{2}",
                            numeroTelefone.Substring(0, 2), // DDD
                            numeroTelefone.Substring(2, 4), // Número principal (4 dígitos)
                            numeroTelefone.Substring(6, 4)); // Número final (4 dígitos)
                    }
                    else
                    {
                        // Se o número não tiver 10 ou 11 dígitos, você pode optar por não formatar ou mostrar uma mensagem de erro
                        e.Value = numeroTelefone; // Ou defina como string vazia
                    }

                    e.FormattingApplied = true;
                }
            }
        }

        private void txtNome_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != ' ')
            {
                e.Handled = true; // Impede a entrada de caracteres que não sejam letras ou espaço
            }

        }

        
    }
}



