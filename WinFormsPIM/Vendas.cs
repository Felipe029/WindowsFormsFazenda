using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using clmodel;
using Info.DAL;

namespace WinFormsPIM
{
    public partial class Vendas : Form
    {
        public Vendas()
        {
            InitializeComponent();
        }

        public Venda VendaCorrente
        {
            get
            {
                return (Venda)this.vendaBindingSource.Current;
            }
        }

        public ItemVenda ItemCorrente
        {
            get
            {
                return (ItemVenda)this.itemVendaBindingSource.Current;
            }
        }

        public ContaAReceber ContaCorrente
        {
            get
            {
                return (ContaAReceber)this.contaAReceberBindingSource.Current;
            }
        }

        private void Vendas_Load(object sender, EventArgs e)
        {
            this.produtosBindingSource.DataSource =
                DataContextFactory.DataContext.Produtos;

            this.itemVendaBindingSource.DataSource =
                DataContextFactory.DataContext.ItemVenda;

            // TODO: esta linha de código carrega dados na tabela 'fazendaDataSet.Clientes'. Você pode movê-la ou removê-la conforme necessário.
            this.clientesTableAdapter.Fill(this.fazendaDataSet.Clientes);

            this.vendaBindingSource.DataSource =
                DataContextFactory.DataContext.Venda;

            this.contaAReceberBindingSource.DataSource =
                DataContextFactory.DataContext.ContaAReceber;

            this.statusDePagamentoBindingSource.DataSource =
                DataContextFactory.DataContext.StatusDePagamento;
        }
        private void NovoItem()
        {
            this.itemVendaBindingSource.AddNew();
            this.ItemCorrente.CodigoVenda = this.VendaCorrente.CodigoVenda;
            this.ItemCorrente.Quantidade = 1;
        }
        private void btnNovaVenda_Click(object sender, EventArgs e)
        {
            if (CboPessoa.Items.Count == 0 || string.IsNullOrWhiteSpace(CboPessoa.Text) || CboPessoa.SelectedIndex == -1)
            //if (CboPessoa.Items.Count == 0)
            {
                MessageBox.Show("Por favor, selecione um cliente!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
                this.vendaBindingSource.AddNew();
                this.vendaBindingSource.EndEdit();
                DataContextFactory.DataContext.SubmitChanges();
                CboPessoa.Enabled = false;
                groupBox.Visible = true;
                btnNovaVenda.Enabled = false;
                this.itemVendaBindingSource.DataSource =
                DataContextFactory.DataContext.ItemVenda.Where(x => x.CodigoProduto == this.VendaCorrente.CodigoVenda);
                NovoItem();
        }
        public void MostraSomaValores()
        {
            decimal total = 0;

            foreach (DataGridViewRow dg in DtvItens.Rows)
            {
                // Verifica se a linha está visível
                if (!dg.IsNewRow && dg.Visible)
                {
                    decimal v1 = Convert.ToDecimal(dg.Cells[2].Value);
                    decimal v2 = Convert.ToDecimal(dg.Cells[3].Value);
                    decimal subtotal = v1 * v2;
                    dg.Cells[4].Value = subtotal;
                    total = total + subtotal;
                }
            }
            this.VendaCorrente.Valor = total;
        }
        private void btnNovoItem_Click(object sender, EventArgs e)
        {
            this.itemVendaBindingSource.EndEdit();
            DtvItens.Refresh();
            DataContextFactory.DataContext.SubmitChanges();
            MostraSomaValores();
            NovoItem();
        }
        private void btnExcluir_Click(object sender, EventArgs e)
        {
            // Verifica se há alguma linha selecionada no DataGridView
            if (DtvItens.SelectedRows.Count == 0)
            {
                MessageBox.Show("Nenhum produto selecionado para exclusão.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            DialogResult resultado = MessageBox.Show("Você tem certeza que deseja excluir?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resultado == DialogResult.Yes)
            {
                this.itemVendaBindingSource.RemoveCurrent();
                MostraSomaValores();
                DataContextFactory.DataContext.SubmitChanges();
                MessageBox.Show("Produto excluído com sucesso!", "Excluído", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                // O usuário clicou em "Não" - cancele a operação
                MessageBox.Show("Operação cancelada.", "Cancelado", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
        }
        private void btnFDP_Click_1(object sender, EventArgs e)
        {
            if (MessageBox.Show("Tem certeza que deseja finalizar essa venda?\nNão será possível adicionar um novo item.",
                "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.itemVendaBindingSource.CancelEdit();
                DataContextFactory.DataContext.SubmitChanges();
                this.VendaCorrente.Desconto = 0;
                btnNovoItem.Enabled = false;
                CboProduto.Enabled = false;
                txtValor.Enabled = false;
                txtCodigoVenda.Enabled = false;
                txtQuantidade.Enabled = false;
                txtDesconto.ReadOnly = false;
                txtDesconto.Focus();
                btnFDP.Enabled = false;
                btnFV.Enabled = true;
                btnExcluir.Enabled = false;
            }
        }
        private void txtDesconto_TextChanged(object sender, EventArgs e)
        {
            // Obtém o texto atual do TextBox.
            string textoAtual = txtDesconto.Text;

            // Remove todos os caracteres que não sejam dígitos, ponto ou vírgula.
            string textoValido = new string(textoAtual.Where(c => char.IsDigit(c) || c == '.' || c == ',').ToArray());

            // Verifica se o texto válido é diferente do texto atual.
            if (textoValido != textoAtual)
            {
                // Se o texto válido é diferente, atualiza o texto do TextBox.
                txtDesconto.Text = textoValido;
                // Define o índice do cursor para o final do texto.
                txtDesconto.SelectionStart = txtDesconto.Text.Length;
            }
        }
        private void DtvItens_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == 1 && e.Value is Produtos produto)
            {
                e.Value = produto.Nome;
            }
        }

        private void btnFV_Click(object sender, EventArgs e)
        {
            this.VendaCorrente.Desconto = Convert.ToDecimal(txtDesconto.Text);
            this.VendaCorrente.ValorPago = (decimal)(this.VendaCorrente.Valor - this.VendaCorrente.Desconto);
            this.vendaBindingSource.EndEdit();
            DataContextFactory.DataContext.SubmitChanges();
            txtDesconto.Enabled = false;
            btnFV.Enabled = false;
            // Contas a receber
            this.contaAReceberBindingSource.AddNew();
            CboStatus.Enabled = true;
            this.ContaCorrente.CodigoVenda = this.VendaCorrente.CodigoVenda;
            this.ContaCorrente.DataCompra = DateTime.Now;
            this.ContaCorrente.DataVencimento = DateTime.Now;
        }

        private void CboStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CboStatus.SelectedItem != null)
            {
                var status = (StatusDePagamento)CboStatus.SelectedItem;
                if (status.CodigoStatus == 1)
                {
                    this.ContaCorrente.CodigoStatus = (int)status.CodigoStatus;
                    this.ContaCorrente.DataPagamento = DateTime.Now;
                    BtnFinalizar.Enabled = true;
                    TxtDataVencimento.Enabled = false;
                }
                else if (status.CodigoStatus == 2)
                {
                    this.ContaCorrente.CodigoStatus = (int)status.CodigoStatus;
                    this.ContaCorrente.DataVencimento = DateTime.Now;
                    this.ContaCorrente.DataPagamento = null;
                    TxtDataVencimento.Enabled = true;
                    BtnFinalizar.Enabled = true;
                }
            }
        }

        private void BtnFinalizar_Click(object sender, EventArgs e)
        {
            this.contaAReceberBindingSource.EndEdit();
            TxtDataVencimento.Enabled = false;
            CboStatus.Enabled = false;
            DataContextFactory.DataContext.SubmitChanges();
            //btnImprimir.Enabled = true;
            BtnFinalizar.Enabled = false;
            MessageBox.Show("Compra finalizada com sucesso!", "Compra Finalizada", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void CboProduto_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CboProduto.SelectedItem != null)
            {
                var pro = (Produtos)CboProduto.SelectedItem;
                this.ItemCorrente.CodigoProduto = (int)pro.Id;
                this.ItemCorrente.Valor = (Decimal)pro.Preco;
            }
        }
    }
}

    


